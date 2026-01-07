using AGVWeight.Db;
using AGVWeight.Models;
using AGVWeight.Reports;
using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AGVWeight.Pages
{
    public partial class frmWeighing : Form
    {
        public frmWeighing()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;

        private readonly string IpMet = ConfigurationManager.AppSettings["IP_METLER"];
        private readonly string IpTsc = ConfigurationManager.AppSettings["IP_THAISCALE"];

        CancellationTokenSource _cts = new CancellationTokenSource();
        List<TcpClient> tcpClients = new List<TcpClient>();
        ModbusServer modbusServer;

        private System.Timers.Timer watchdogTimer;
        /// <summary>
        /// สำหรับกำหนดค่าเป็นน้ำหนักล่าสุดเพื่อเอาไปใช้ อัพเดทที่ label
        /// </summary>
        private string weightString { get; set; }
        ///// <summary>
        ///// สำหรับกำหนดค่าเป็นน้ำหนักลางเพื่อเอาไปใช้
        ///// </summary>
        //private int weight { get; set; }

        private int newWeight = 0;
        private int lastWeight = 0;

        /// <summary>
        /// น้ำหนักที่เลือกจากเครื่องชั่ง
        /// </summary>
        private string WeightSelect { get; set; } = "0";
        /// <summary>
        /// เครื่องชั่งที่เลือก
        /// </summary>
        private string IndicatorSelect { get; set; }

        /// <summary>
        /// สำหรับเก็บเลขที่ออเดอร์ เมื่อมีการเลือกรายการที่ต้องการจะชั่งออก
        /// </summary>
        private int orderId { get; set; } = 0;
        /// <summary>
        /// สำหรับเก็บค่าน้ำหนักชั่งเข้า เมื่อมีการเลือกรายการที่ต้องการจะชั่งออก
        /// </summary>
        private int FirstWeight { get; set; } = 0;


        /// <summary>
        /// ทดสอบการเชื่อมต่อ
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        async Task connectTcp(string ip)
        {
            // วนลูปตราบเท่าที่โปรแกรมยังไม่ปิด
            while (!_cts.Token.IsCancellationRequested)
            {
                TcpClient tcpClient = new TcpClient();
                try
                {
                    updateWeightUI(ip, "Connecting........");
                    await tcpClient.ConnectAsync(ip, 1932);

                    if (tcpClient.Connected)
                    {
                        // เก็บเข้า list เฉพาะตัวที่ใช้งานจริง (ควรล้างตัวเก่าออกด้วยถ้ามี)
                        lock (tcpClients) { tcpClients.Add(tcpClient); }

                        // ทำงานรับข้อมูล (รอจนกว่าจะหลุด)
                        await getParameter(tcpClient, _cts.Token);
                    }
                }
                catch (Exception ex)
                {
                    updateWeightUI(ip, "Server Offline"); // แจ้ง UI ว่าเชื่อมต่อไม่ได้
                }
                finally
                {
                    // ทำความสะอาดทรัพยากร
                    tcpClient.Close();
                    lock (tcpClients) { tcpClients.Remove(tcpClient); }
                }

                // *** สำคัญ: ถ้าหลุด ให้รอ 3-5 วินาทีก่อนลองใหม่ เพื่อป้องกันการยิงรัวๆ (Retry Storm)
                await Task.Delay(3000, _cts.Token);
            }
        }

        /// <summary>
        /// ขอข้อมูลและรอการตอบกลับ
        /// </summary>
        /// <param name="tcp"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        async Task getParameter(TcpClient tcp, CancellationToken token)
        {
            string remoteIp = ((IPEndPoint)tcp.Client.RemoteEndPoint).Address.ToString();
            try
            {
                // กำหนดค่า ns
                NetworkStream ns = tcp.GetStream();
                var buff = new byte[4096];
                // ดึงเฉพาะ IP Address ออกมาเพื่อเช็คใน Switch (ตัด Port ออก)
                // เช็คว่าหยุดทำงาน และ ยังเชื่อมต่อได้อยู่หรือไม่
                while (!token.IsCancellationRequested && tcp.Connected)
                {
                    byte[] req = Encoding.UTF8.GetBytes("GET WEIGHT"); // กำหนด req
                    await ns.WriteAsync(req, 0, req.Length); // ส่งคำขอ
                    int res = await ns.ReadAsync(buff, 0, req.Length); // รอตอบกลับ server จะใช้เวลาไม่นาน
                    if (res == 0)
                    {
                        updateWeightUI(remoteIp, "Disconnect");
                    }
                    string resStr = Encoding.UTF8.GetString(buff, 0, res); // รออ่านผลลัพท์
                    int wgh = 0;
                    // server จะส่งน้ำหนักมาเสมอ หากเชื่อมต่อเครื่องชั่งได้ แต่หากเชื่อมต่อเครื่องชั่งไม่ได้ server จะส่งมาว่า ERROR
                    if (int.TryParse(resStr, out wgh))
                    {
                        // อัปเดต UI
                        weightString = resStr;
                        //weight = wgh;
                        updateWeightUI(remoteIp, wgh.ToString());
                    }

                    await Task.Delay(200, token);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error on {tcp.Client.RemoteEndPoint}: {ex.Message}");
            }
            finally
            {
                tcp.Close();
                _ = Task.Run(async () =>
                {
                    await connectTcp(remoteIp);
                });
            }
        }

        void updateWeightUI(string remoteIp, string mes)
        {
            BeginInvoke(new MethodInvoker(delegate ()
            {
                if (remoteIp == IpMet)
                {
                    lblMet.Text = mes;
                    if (mes.Length > 5)
                    {
                        lblMet.ForeColor = Color.Red;
                        lblMet.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                    }
                    else
                    {
                        lblMet.ForeColor = Color.Green;
                        lblMet.Font = new Font("Segoe UI", 70, FontStyle.Bold);
                    }
                }

                else if (remoteIp == IpTsc)
                {
                    lblTsc.Text = mes;

                    if (mes.Length > 5)
                    {
                        lblTsc.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                        lblTsc.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblTsc.ForeColor = Color.Green;
                        lblTsc.Font = new Font("Segoe UI", 70, FontStyle.Bold);
                    }
                }
            }));
        }

        void defineConfig()
        {
            lblIpMet.Text = IpMet;
            lblIpTsc.Text = IpTsc;
            lblSlaveId.Text = "1";
            lblComDevice.Text = ConfigurationManager.AppSettings["MODBUS_DEVICE_NAME"];
            lblPort.Text = ConfigurationManager.AppSettings["MODBUS_PORT_NAME"];
        }

        void clearScreen()
        {
            foreach (TextBox txt in gbInformation.Controls.OfType<TextBox>())
                txt.Clear();

            foreach (ComboBox cbb in gbInformation.Controls.OfType<ComboBox>())
            {
                cbb.Items.Clear();
                cbb.Items.Add("");
                cbb.SelectedIndex = 0;
            }

            gbList.Enabled = true;
            gbInformation.Enabled = true;
            orderId = 0;
            dgv.ClearSelection();
        }

        void saveFirstWeight()
        {
            // เช็คค่าว่าง
            foreach (TextBox txt in gbInformation.Controls.OfType<TextBox>())
                if (txt.Tag == "REQUIRE" && txt.Text == "")
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบก่อนการบันทึก", "พบข้อมูลว่าง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            foreach (ComboBox cbb in gbInformation.Controls.OfType<ComboBox>())
                if (cbb.Text == "")
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบก่อนการบันทึก", "พบข้อมูลว่าง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            //  เติมค่าว่างหาก textbox ที่ไม่ใช่ require เป็นค่าว่าง
            foreach (TextBox txt in gbInformation.Controls.OfType<TextBox>())
                if (txt.Tag != "REQUIRE" && txt.Text == "")
                    txt.Text = "-";


            // กำหนดน้ำหนัก
            int weight = 0;
            if (IndicatorSelect == "MET")
                if (!int.TryParse(lblMet.Text, out weight))
                    return;


            if (IndicatorSelect == "TSC")
                if (!int.TryParse(lblTsc.Text, out weight))
                    return;

            // เช็คน้ำหนัก
            if (weight <= 100)
            {
                MessageBox.Show("น้ำหนักที่บันทึกต้องมากกว่า 100 Kg", "น้ำหนักน้อยกว่าที่กำหนด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OrderDb orderDb = new OrderDb();
            string orderNumber = orderDb.generateOrder();  // สร้างเลขที่ชั่งเข้า
            if (orderDb == null)
            {
                MessageBox.Show("เกิดข้อผิดผลาด สร้างเลขที่ชั่ง\nError : " + orderDb.Error, "เกิดข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // กำหนดค่าข้อมูลหลัก
            OrderModel orderModel = new OrderModel
            {
                LicensePlate = txtLicensePlate.Text.Trim(),
                Typez = cbbType.Text,
                Transport_name = cbbTransport.Text,
                Customer_name = cbbCustomer.Text,
                Product_name = cbbProduct.Text,
                SoNumber = txtSo.Text,
                DnNo = txtDn.Text,
                SealNo = txtSealNo.Text,
                Shipment = txtShipment.Text,
                ContainerNo = txtContainer.Text,
                DateWeight = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("en-EN")),
                NetWeight = 0,
                Status = "Process",
                OrderNumber = orderNumber
            };
            // สร้างข้อมูลหลัก
            if (!orderDb.addNew(orderModel))
            {
                MessageBox.Show("เกิดข้อผิดผลาดในการบันทึกชั่งรอบแรก \n Error : " + orderDb.Error, "เกิดข้อผิดผลาดบันทึกชั่งรอบแรก", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ดึงข้อมูหลักมาเก็บที่ model
            orderModel = orderDb.getOrderByOrderNumber(orderNumber);

            // สร้างข้อมูลรอง
            if (!saveWeightDetail(weight, "FIRST WEIGHT", orderModel.Id))
                return;

            MessageBox.Show("บันทึกรายการชั่งรอบแรกสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearScreen(); // เครียหน้าเจอให้พร้อมสำหรับเริ่มงานใหม่
            showFirstWeight(); // แสดงรายการชั่งเข้า
        }

        void saveSecondWeight()
        {
            // กำหนดน้ำหนัก
            int weight = 0;
            if (IndicatorSelect == "MET")
                if (!int.TryParse(lblMet.Text, out weight))
                    return;


            if (IndicatorSelect == "TSC")
                if (!int.TryParse(lblTsc.Text, out weight))
                    return;

            // เช็คน้ำหนัก
            if (weight <= 100)
            {
                MessageBox.Show("น้ำหนักที่บันทึกต้องมากกว่า 100 Kg", "น้ำหนักน้อยกว่าที่กำหนด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // สร้างข้อมูล รอง
            if (!saveWeightDetail(weight, "SECOND WEIGHT", orderId))
                return;

            // อัพเดทสถานะและน้ำหนักสุทธิ
            int net = Math.Abs(FirstWeight - weight);
            OrderDb orderDb = new OrderDb();
            orderDb.updateStatusAndNetWeightById(orderId, "Success", net);

            MessageBox.Show("บันทึกรายการชั่งรอบแรกสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult dialogResult = MessageBox.Show("คุณต้องการพิมพ์ตั๋วโดยดูตัวอย่างการพิมพ์หรือไม่", "ดูตัวอย่างการพิมพ์", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                frmReport frmReport = new frmReport(orderId, true);
                frmReport.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                frmReport frmReport = new frmReport(orderId, false);
                frmReport.ShowDialog();
            }
            clearScreen(); // เครียหน้าเจอให้พร้อมสำหรับเริ่มงานใหม่
            showFirstWeight(); // แสดงรายการชั่งเข้า
        }

        bool saveWeightDetail(int wgh, string weightType, int orderId)
        {
            bool isSuccess = true;
            OrderDetailDb orderDetailDb = new OrderDetailDb();
            OrderDetailModel orderDetailModel = new OrderDetailModel
            {
                DateTimez = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("en-EN")),
                IndicatorWeight = IndicatorSelect,
                OrderId = orderId,
                Weight = wgh,
                WeightType = weightType
            };
            if (!orderDetailDb.addNew(orderDetailModel))
            {
                MessageBox.Show("เกิดข้อผิดผลาดในการบันทึกรายละเอียดชั่ง \nError : " + orderDetailDb.Error, "เกิดข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ลบข้อมูลที่มีการสร้างข้อมูลหบักไป 
                OrderDb orderDb = new OrderDb();
                orderDb.deleteById(orderId);
                isSuccess = false;
            }
            return isSuccess;
        }

        void showFirstWeight()
        {
            OrderDb orderDb = new OrderDb();
            dgv.Rows.Clear();
            List<OrderModel> orderModels = orderDb.getOrderByStatus("Process");
            if (orderModels == null)
                if (orderDb.Error == "ไม่พบรายการ")
                {
                    lblFirstWeightCount.Text = "ไม่มีรายการรถค้างชั่ง";
                    return;
                }
                else
                {
                    MessageBox.Show("เกิดข้อผิดผลาด เรียกรายการรถค้างชั่ง \nError : " + orderDb.Error, "เกิดข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            lblFirstWeightCount.Text = "จำนวนรายการทั้งหมด " + orderModels.Count.ToString();
            // กำหนดค่าที่ dgv 
            foreach (OrderModel model in orderModels)
            {
                OrderDetailDb orderDetailDb = new OrderDetailDb();
                List<OrderDetailModel> orderDetailModel = orderDetailDb.getOrderDetailById(model.Id);
                dgv.Rows.Add("", "", model.Id, model.OrderNumber, model.DateWeight, model.LicensePlate, orderDetailModel[0].Weight, model.Typez, model.Product_name, model.Customer_name, orderDetailModel[0].IndicatorWeight);
            }
        }

        void showFirstWeightOnGroupBox(int orderId)
        {
            OrderDb orderDb = new OrderDb();
            OrderModel model = orderDb.getOrderById(orderId);
            foreach (ComboBox cbb in gbInformation.Controls.OfType<ComboBox>())
                cbb.Items.Clear();

            // กำหนดค่าแสดงที่ข้อมูลชั่ง สำหรับชั่งออก
            txtLicensePlate.Text = model.LicensePlate;
            cbbType.Items.Add(model.Typez);
            cbbType.SelectedIndex = 0;
            cbbTransport.Items.Add(model.Transport_name);
            cbbTransport.SelectedIndex = 0;
            cbbCustomer.Items.Add(model.Customer_name);
            cbbCustomer.SelectedIndex = 0;
            cbbProduct.Items.Add(model.Product_name);
            cbbProduct.SelectedIndex = 0;
            txtSo.Text = model.SoNumber;
            txtDn.Text = model.DnNo;
            txtSealNo.Text = model.SealNo;
            txtShipment.Text = model.Shipment;
            txtContainer.Text = model.ContainerNo;
        }

        bool openModbusServer()
        {
            bool isSuccess = true;
            // ลองทดสอบPort 
            SerialPort serialPort = new SerialPort();
            serialPort.PortName = "COM1";
            serialPort.BaudRate = 9600;
            serialPort.Parity = System.IO.Ports.Parity.None;
            serialPort.StopBits = System.IO.Ports.StopBits.One;
            serialPort.DataBits = 8;
            try
            {
                serialPort.Open();
                serialPort.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("เกิดข้อผิดผลาดสำหรับสร้าง Modbus Server \nError : " + ex.Message, "Modbus Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // 1. สร้าง Instance ของ Modbus Server
            modbusServer = new ModbusServer();

            // 2. ตั้งค่า Serial Port
            // หมายเหตุ: ต้องติดตั้ง Virtual Serial Port และจับคู่ COM1 กับ COM2 ไว้
            modbusServer.SerialPort = "COM1";
            modbusServer.Baudrate = 9600;
            modbusServer.UnitIdentifier = 1; // Slave ID: 1
            modbusServer.Parity = System.IO.Ports.Parity.None;
            modbusServer.StopBits = System.IO.Ports.StopBits.One;

            // 3. เริ่มการทำงานของ Server
            try
            {
                modbusServer.Listen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดผลาดสำหรับสร้าง Modbus Server \nError : " + ex.Message, "Modbus Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }

        short[] FloatToRegisters2(float value)
        {
            // แปลง float เป็น byte array (ได้ 4 bytes)
            byte[] bytes = BitConverter.GetBytes(value);

            // แบบปกติ (CD AB หรือ Little Endian ซึ่งเป็นมาตรฐานส่วนใหญ่บน PC)
            return new short[]
            {
        // ต้อง Cast (short) เพื่อแปลงจาก ushort เป็น short
        (short)BitConverter.ToUInt16(bytes, 0), // Low Word
        (short)BitConverter.ToUInt16(bytes, 2)  // High Word
            };
        }

        private void frmWeighing_Load(object sender, EventArgs e)
        {
            // เปิด Server Modbus 
            if (!openModbusServer())
                this.Close();

            // ตั้งเวลา Timeout ไว้ที่ 2000 ms (2 วินาที)
            watchdogTimer = new System.Timers.Timer(2000);
            watchdogTimer.Elapsed += OnTimedEvent;
            watchdogTimer.AutoReset = false; // ให้ทำงานครั้งเดียวแล้วหยุดจนกว่าจะ Start ใหม่
            tmUpdateModbusServer.Start();

            defineConfig();    // กำหนดค่ามาแสดงที่โปรแกรม
            showFirstWeight(); // แสดงรายการชั่งเข้า หรือ ค้างชั่ง

            _ = Task.Run(async () =>
            {
                await connectTcp(IpMet);
            });

            // เชื่อมต่อเครื่องชั่ง ip
            _ = Task.Run(async () =>
            {
                await connectTcp(IpTsc);
            });
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate ()
            {
                btnSave.Enabled = true;
            }));
        }

        private void frmWeighing_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cts.Cancel();
            foreach (TcpClient item in tcpClients)
            {
                item.Close();
                item.Dispose();
            }
            tmUpdateModbusServer.Stop();  // หยุดการส่งน้ำหนักไปที่ Modbus Server
            modbusServer.StopListening(); // หยุดเชื่อมต่อ Port

        }

        private void selectIndicator(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            int wgh = 0;
            if (rdb.Checked)
            {
                switch (rdb.Tag)
                {
                    case "TSC":
                        pnMet.Visible = false;
                        pnTsc.Visible = true;
                        WeightSelect = lblTsc.Text;
                        if (int.TryParse(lblTsc.Text, out wgh))
                            WeightSelect = wgh.ToString();
                        break;
                    case "MET":
                        pnMet.Visible = true;
                        pnTsc.Visible = false;
                        WeightSelect = lblMet.Text;
                        if (int.TryParse(lblMet.Text, out wgh))
                            WeightSelect = wgh.ToString();
                        break;
                }
                IndicatorSelect = rdb.Tag.ToString();
                watchdogTimer.Stop();
                watchdogTimer.Start();
            }
        }


        private void selectIndicator2(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            switch (lbl.Tag)
            {
                case "TSC":
                    rdbTsc.Checked = true;
                    break;
                case "MET":
                    rdbMet.Checked = true;
                    break;
            }
        }

        private void selectCombobox(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;
            cbb.Items.Clear();
            switch (cbb.Tag)
            {
                case "TYPE":
                    TypeDb typeDb = new TypeDb();
                    List<TypeModel> types = typeDb.getAllType();
                    foreach (TypeModel tyM in types)
                        cbb.Items.Add(tyM.Namez);
                    break;
                case "CUSTOMER":
                    CustomerDb customerDb = new CustomerDb();
                    List<CustomerModel> custs = customerDb.getAllCustomer();
                    foreach (CustomerModel cust in custs)
                        cbb.Items.Add(cust.Namez);
                    break;
                case "TRANSPORT":
                    TransportDb transportDb = new TransportDb();
                    List<TransportModel> trans = transportDb.getAllTransport();
                    foreach (TransportModel tyM in trans)
                        cbb.Items.Add(tyM.Namez);
                    break;
                case "PRODUCT":
                    ProductDb productDb = new ProductDb();
                    List<ProductModel> pros = productDb.getAllProduct();
                    foreach (ProductModel pro in pros)
                        cbb.Items.Add(pro.Namez);
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool isHave = false;
            // เช็คว่ามีค่าว่างให้ลบหรือไม่
            foreach (TextBox txt in gbInformation.Controls.OfType<TextBox>())
                if (txt.Text != "")
                    isHave = true;

            foreach (ComboBox cbb in gbInformation.Controls.OfType<ComboBox>())
                if (cbb.Text != "")
                    isHave = true;

            if (isHave)
            {
                DialogResult res = MessageBox.Show("คุณต้องการยกเลิกรายการที่เลือก หรือ ที่กำลังคีย์อยู่หรือไม่?", "ยกเลิกรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    clearScreen();
            }
        }

        private void tmStableCheck_Tick(object sender, EventArgs e)
        {
            if (IndicatorSelect == "MET")
                if (!int.TryParse(lblMet.Text, out newWeight))
                {
                    btnSave.Enabled = false;
                    return;
                }

            if (IndicatorSelect == "TSC")
                if (!int.TryParse(lblTsc.Text, out newWeight))
                {
                    btnSave.Enabled = false;
                    return;
                }

            if (newWeight != lastWeight)
            {
                btnSave.Enabled = false;
                lastWeight = newWeight;
                watchdogTimer.Stop();
                watchdogTimer.Start();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // เอา textbox ทะเบียนรถไปค้นหาที่ datagrid
            foreach (DataGridViewRow rw in dgv.Rows)
            {
                string license = rw.Cells["cl_licensePlate"].Value.ToString();
                if (license == txtLicensePlate.Text && gbInformation.Enabled)
                {
                    orderId = int.Parse(rw.Cells["cl_id"].Value.ToString());
                    FirstWeight = int.Parse(rw.Cells["cl_weightIn"].Value.ToString());
                    DialogResult res = MessageBox.Show("เนื่องจากคีย์ทะเบียนรถซ้ำกับทะเบียนรถที่มีรายการชั่งรองแรกอยู่แล้ว ระบบจะบังคับชั่งรอบสองก่อน \nยืนยันหรือไม่?", "ชั่งรถรอบสอง", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No)
                        return;
                    showFirstWeightOnGroupBox(orderId);
                    saveSecondWeight();
                    return;
                }
            }

            // เช็ค first weight or second weight
            if (orderId == 0) // first weight
                saveFirstWeight();
            else
                saveSecondWeight();


        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                OrderDb orderDb = new OrderDb();
                string clName = dgv.Columns[e.ColumnIndex].Name;
                switch (clName)
                {
                    case "cl_delete":
                        orderId = int.Parse(dgv.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());
                        FirstWeight = int.Parse(dgv.Rows[e.RowIndex].Cells["cl_weightIn"].Value.ToString());
                        DialogResult res = MessageBox.Show("คุณต้องการยกเลิกรายการรถที่เลือกหรือไม่", "ยกเลิกรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            if (!orderDb.updateStatusAndNetWeightById(orderId, "Cancel", 0))
                            {
                                MessageBox.Show("เกิดข้อผิดผลาด ยกเลิกเลขที่ชั่ง \nError : " + orderDb.Error, "เกิดข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            showFirstWeight();
                        }
                        clearScreen();
                        break;
                    case "cl_select":
                        orderId = int.Parse(dgv.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());
                        FirstWeight = int.Parse(dgv.Rows[e.RowIndex].Cells["cl_weightIn"].Value.ToString());
                        dgv.Rows[e.RowIndex].Selected = true;
                        showFirstWeightOnGroupBox(orderId);
                        gbInformation.Enabled = false;
                        gbList.Enabled = false;
                        break;
                }
            }
            catch
            {


            }
        }

        private void tmUpdateModbusServer_Tick(object sender, EventArgs e)
        {
            float value = 0;
            if (IndicatorSelect == "MET")
                if (!float.TryParse(lblMet.Text, out value))
                    return;

            if (IndicatorSelect == "TSC")
                if (!float.TryParse(lblTsc.Text, out value))
                    return;

            // 2. เรียกฟังก์ชันแปลงค่า
            short[] registers = FloatToRegisters2(value);

            // 3. เขียนลง Holding Register
            // Float 1 ตัว ต้องใช้ 2 ช่อง (เช่น ช่องที่ 1 และ 2)

            // เขียนส่วนแรก (Low Word) ลง Register ที่ 1
            modbusServer.holdingRegisters[3] = registers[0];

            // เขียนส่วนที่สอง (High Word) ลง Register ที่ 2
            modbusServer.holdingRegisters[4] = registers[1];
        }
    }
}
