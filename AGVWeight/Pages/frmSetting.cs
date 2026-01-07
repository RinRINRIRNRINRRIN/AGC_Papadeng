using AGVWeight.Functions;
using AGVWeight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVWeight.Pages
{
    public partial class frmSetting : Form
    {
        public string DevicePortName { get; private set; }
        public string DevicePort { get; private set; }

        public frmSetting()
        {
            InitializeComponent();
            foreach (TextBox txt in groupBox2.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }
        }



        void getConfig()
        {
            string deviceName = ConfigurationManager.AppSettings["MODBUS_DEVICE_NAME"];
            string ipThaiscale = ConfigurationManager.AppSettings["IP_THAISCALE"];
            string ipMetler = ConfigurationManager.AppSettings["IP_METLER"];
            cbbCom.Items.Add(deviceName);
            cbbCom.SelectedIndex = 0;

            if (ipMetler != "" && ipMetler != null)
            {
                string[] ipMet = ipMetler.Split('.');
                txtMet1.Text = ipMet[0];
                txtMet2.Text = ipMet[1];
                txtMet3.Text = ipMet[2];
                txtMet4.Text = ipMet[3];
            }

            if (ipThaiscale != "" && ipThaiscale != null)
            {
                string[] ipTsc = ipThaiscale.Split('.');

                txtTsc1.Text = ipTsc[0];
                txtTsc2.Text = ipTsc[1];
                txtTsc3.Text = ipTsc[2];
                txtTsc4.Text = ipTsc[3];
            }
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            getConfig();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbCom.Text == "")
            {
                MessageBox.Show("กรุณาเลือกพอร์ตสำหรับทำ Server", "Modbus COM Port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (TextBox txt in pnMET.Controls.OfType<TextBox>())
                if (txt.Text == "")
                {
                    MessageBox.Show("กรุณากรอกเลขที่ ip ให้ครบก่อนทดสอบ", "กรอก IP ไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            foreach (TextBox txt in pnTSC.Controls.OfType<TextBox>())
                if (txt.Text == "")
                {
                    MessageBox.Show("กรุณากรอกเลขที่ ip ให้ครบก่อนทดสอบ", "กรอก IP ไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            string ipAddressThaiScale = $"{txtTsc1.Text}.{txtTsc2.Text}.{txtTsc3.Text}.{txtTsc4.Text}";
            string ipAddressMettler = $"{txtMet1.Text}.{txtMet2.Text}.{txtMet3.Text}.{txtMet4.Text}";

            // เช็คว่า ip ซ้ำกันหรือไม่
            if (ipAddressMettler == ipAddressThaiScale)
            {
                MessageBox.Show("ip address ซ้ำกันโปรดตรวจสอบอีกครั้ง", "Ip address ซ้ำกัน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                string portNameUrlToSave = DevicePortName;
                string portIdToSave = DevicePort;

                if (string.IsNullOrEmpty(portNameUrlToSave))
                {
                    portNameUrlToSave = config.AppSettings.Settings["MODBUS_DEVICE_NAME"].Value;
                    portIdToSave = config.AppSettings.Settings["MODBUS_PORT_NAME"].Value;

                    // ตรวจสอบอีกครั้งว่าถ้าค่า Config เดิมว่าง แล้ว User ไม่เลือกใหม่ ต้องแจ้งเตือน
                    if (string.IsNullOrEmpty(portNameUrlToSave))
                    {
                        MessageBox.Show("กรุณาเลือก Comport ใหม่อีกครั้ง", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                config.AppSettings.Settings["MODBUS_DEVICE_NAME"].Value = portNameUrlToSave;
                config.AppSettings.Settings["MODBUS_PORT_NAME"].Value = portIdToSave;
                config.AppSettings.Settings["IP_THAISCALE"].Value = ipAddressThaiScale;
                config.AppSettings.Settings["IP_METLER"].Value = ipAddressMettler;

                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("บันทึกการตั้งค่าสำเร็จ กรุณาเปิดโปรแกรมใหม่อีกครั้ง", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show("ไม่สามารถบันทึกค่า Config ได้: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbCom_DropDown(object sender, EventArgs e)
        {
            Comport port = new Comport();
            List<PortsModel> ports = port.getDeviceName();
            if (ports == null)
            {
                MessageBox.Show("เกิดข้อผิดผลาดในการดึง comport \n" +
                    "Error : " + port.ERR, "Get port computer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbbCom.Items.Clear();
            foreach (var item in ports)
            {
                cbbCom.Items.Add(item);
            }
        }

        private void cbbCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCom.SelectedItem is PortsModel selectedDevice)
            {
                // กำหนดค่าไปที่ Prop 
                DevicePortName = selectedDevice.DeviceNames;
                DevicePort = selectedDevice.DevicePort;
            }
        }

        private void checkNumber(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            // 1. เช็คก่อนเลยว่าถ้ากด "จุด" ให้ส่ง TAB แล้วจบการทำงานของปุ่มนี้ไปเลย
            if (e.KeyChar == '.' && txt.Text != "")
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; // กันไม่ให้เครื่องหมาย . ปรากฏใน TextBox
                return; // ออกจากฟังก์ชันทันที
            }


            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkLength(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text.Length == 3)
                SendKeys.Send("{TAB}");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private async void testConnect(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string ip = "";
            switch (btn.Tag)
            {
                case "MET":
                    // เช็คค่าว่าง
                    foreach (TextBox txt in pnMET.Controls.OfType<TextBox>())
                        if (txt.Text == "")
                        {
                            MessageBox.Show("กรุณากรอกเลขที่ ip ให้ครบก่อนทดสอบ", "กรอก IP ไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    ip = $"{txtMet1.Text}.{txtMet2.Text}.{txtMet3.Text}.{txtMet4.Text}";
                    break;
                case "TSC":
                    // เช็คค่าว่าง
                    foreach (TextBox txt in pnTSC.Controls.OfType<TextBox>())
                        if (txt.Text == "")
                        {
                            MessageBox.Show("กรุณากรอกเลขที่ ip ให้ครบก่อนทดสอบ", "กรอก IP ไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    ip = $"{txtTsc1.Text}.{txtTsc2.Text}.{txtTsc3.Text}.{txtTsc4.Text}";
                    break;
            }
            this.Enabled = false;
            Ping ping = new Ping();
            PingReply pingReply = await ping.SendPingAsync(ip, 5000);
            if (pingReply.Status == IPStatus.Success)
            {
                MessageBox.Show("ผลการทดสอบ \n" +
                    "Response : " + pingReply.Status, "ทดสอบการเชื่อมต่อ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ผลการทดสอบ \n" +
    "Response : " + pingReply.Status, "ทดสอบการเชื่อมต่อ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Enabled = true;


        }
    }
}
