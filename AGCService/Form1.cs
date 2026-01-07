using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
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

namespace AGCService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            Opacity = 0;
            createTray();
        }


        NotifyIcon _tray;
        ContextMenuStrip _menu;
        ToolStripMenuItem _start, _stop, _exit;
        TcpListener _listener;
        CancellationTokenSource _cts;
        List<TcpClient> _clients = new List<TcpClient>();
        private readonly int _port = 1932;
        private readonly string _portName = ConfigurationManager.AppSettings["PORT"];
        private readonly string _scaleName = ConfigurationManager.AppSettings["SCALE"];
        List<byte> buffer = new List<byte>();

        private object _lockObj = new object();
        private string _latestWeight = "0.0";
        private System.Timers.Timer watchdogTimer;
        private string ErrorDes { get; set; }

        void createTray()
        {
            // create menu 
            _menu = new ContextMenuStrip();
            _start = new ToolStripMenuItem("Start Server", null, async (s, e) => await startServer());
            _stop = new ToolStripMenuItem("Stop Server", null, (s, e) => stopServer());
            _exit = new ToolStripMenuItem("Exit", null, (s, e) => { stopServer(); _tray.Visible = false; Application.Exit(); });
            _menu.Items.AddRange(new ToolStripItem[] { _start, _stop, new ToolStripSeparator(), _exit });
            // create tary
            _tray = new NotifyIcon
            {
                Text = "TSC Service",
                Icon = new System.Drawing.Icon(Application.StartupPath + "\\mainback.ico"),
                Visible = true,
                ContextMenuStrip = _menu,

            };

            _tray.BalloonTipClicked += _tray_BalloonTipClicked;

            _tray.DoubleClick += _tray_DoubleClick;

            _start.Enabled = false;
            _stop.Enabled = false;
        }

        private void _tray_BalloonTipClicked(object sender, EventArgs e)
        {
            switch (ErrorDes)
            {
                case "SCALE":
                    tryConnectPort();
                    break;
                case "SERVER":
                    break;
            }
        }

        private void _tray_DoubleClick(object sender, EventArgs e)
        {
            if (Opacity == 0) { Opacity = 1; WindowState = FormWindowState.Normal; ShowInTaskbar = true; }
            else { ShowInTaskbar = false; WindowState = FormWindowState.Minimized; Opacity = 0; }

        }

        private async Task startServer()
        {
            if (_listener != null)
            {
                showBalloon("พบการทำงานโปรแกรมซ้อนกัน");
                return;
            }

            try
            {
                _cts = new CancellationTokenSource();
                _listener = new TcpListener(IPAddress.Any, _port);
                _listener.Start();
                Console.WriteLine("Start server on port " + _port);
                _ = Task.Run(async () =>
                {
                    await acceptLoopAsync(_cts.Token);
                });
                await Task.Delay(100);
                _start.Enabled = false;
                _stop.Enabled = true;
                showBalloon("เปิดเซิร์ฟเวอร์สำเร็จ พอร์ต : " + _port);
            }
            catch (Exception ex)
            {
                showBalloon($"เกิดข้อผิดผลาดในการเปิดเซิร์ฟเวอร์ \n" +
                    $"ERROR : " + ex.Message);
                ErrorDes = "SERVER";
                _listener = null;
                _cts.Dispose();
                _cts = null;
                _start.Enabled = true;
                _stop.Enabled = false;
            }
        }
        private void stopServer()
        {
            try
            {
                _cts?.Cancel();
                _listener.Stop();
                foreach (var item in _clients)
                {
                    item.Close();
                    item.Dispose();
                }
            }
            catch (Exception ex)
            {
                showBalloon("Server stop have error : " + ex.Message);
            }
            finally
            {
                _listener = null;
                _cts?.Dispose(); _cts = null;
                _start.Enabled = true;
                _stop.Enabled = false;
                showBalloon("Server stopped");
            }
        }

        void showBalloon(string text, int timeout = 30000)
        {
            _tray.BalloonTipTitle = "TSCService";
            _tray.BalloonTipText = text;
            _tray.ShowBalloonTip(timeout);
        }

        async Task acceptLoopAsync(CancellationToken ct)
        {
            try
            {
                while (!ct.IsCancellationRequested)
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    var remoteEndPoint = client.Client.RemoteEndPoint?.ToString() ?? "unknow";
                    Console.WriteLine($"[CONNECT] Client " + remoteEndPoint + " connected");
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        lbClient.Items.Add(remoteEndPoint);
                    }));
                    _clients.Add(client);
                    _ = HandleClientAsync(client, ct);
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbPort.Text == "" || cbbScale.Text == "")
            {
                MessageBox.Show("กรุณาเลือกพอร์ตการเชื่อมต่อ หรือ เครื่องชั่งก่อนการบันทึก", "ค่าว่าง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["PORT"].Value = cbbPort.Text;
            config.AppSettings.Settings["SCALE"].Value = cbbScale.Text;
            config.Save(ConfigurationSaveMode.Modified);
            MessageBox.Show("บันทึกรายการสำเร็จ โปรแกรมจะปิดตัวและเปิดใหม่อีกครั้ง", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;
            cbb.Items.Clear();
            switch (cbb.Tag.ToString())
            {
                case "COM":
                    string[] coms = SerialPort.GetPortNames();
                    foreach (var item in coms)
                        cbb.Items.Add(item);
                    break;
                case "SCALE":
                    string[] scales = { "METLER", "X3" };
                    foreach (var item in scales)
                        cbb.Items.Add(item);
                    break;
            }
        }

        async Task HandleClientAsync(TcpClient client, CancellationToken token)
        {
            NetworkStream ns = null;
            var remoteEndPoint = client.Client.RemoteEndPoint?.ToString() ?? "unknow";
            try
            {
                ns = client.GetStream();
                var buffer = new byte[4096];
                while (!token.IsCancellationRequested && client.Connected)
                {
                    int read = await ns.ReadAsync(buffer, 0, buffer.Length, token);
                    if (read == 0) break; // ไม่เจอข้อมูล ให้ break
                    string msg = Encoding.UTF8.GetString(buffer, 0, read);
                    Console.WriteLine($"Client {client.Client.RemoteEndPoint} send : {msg}");

                    string res = "";
                    lock (_lockObj)
                    {
                        res = _latestWeight;
                    }
                    ;

                    var buf = Encoding.UTF8.GetBytes($"{res}\n\r");

                    if (msg == "GET WEIGHT")
                    {
                        await ns.WriteAsync(buf, 0, buf.Length, token);
                    }
                }
            }
            catch
            {


            }
            finally
            {
                // *** ส่วนที่เพิ่ม: ทำงานเสมอเมื่อ Loop จบ หรือ Error ***

                // 1. ลบออกจาก List<TcpClient> ภายใน
                if (_clients.Contains(client))
                {
                    _clients.Remove(client);
                }

                // 2. ลบออกจาก ListBox (UI) ต้องใช้ Invoke เพราะคนละ Thread
                this.BeginInvoke(new MethodInvoker(delegate ()
                {
                    if (lbClient.Items.Contains(remoteEndPoint))
                    {
                        lbClient.Items.Remove(remoteEndPoint);
                    }
                }));

                // 3. ปิด Connection และคืน Resource
                client.Close();
                client.Dispose();

                Console.WriteLine($"Client {remoteEndPoint} cleaned up.");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                watchdogTimer.Stop();
                int a = serialPort1.BytesToRead;
                byte[] data = new byte[a];
                byte[] b = null;
                int wgh = 0;
                string byteConvertString = "";
                string wghStrSub = "";
                lock (_lockObj)
                    _latestWeight = "ERROR";

                switch (_scaleName)
                {
                    case "METLER":
                        serialPort1.Read(data, 0, data.Length);
                        buffer.AddRange(data);

                        while (buffer.Count >= 17)
                        {
                            if (buffer[0] == 0x02 && buffer[16] == 0x0d)
                            {
                                b = buffer.Take(16).ToArray();
                                buffer.RemoveRange(0, 16);
                                byteConvertString = Encoding.ASCII.GetString(b);
                                wghStrSub = byteConvertString.Substring(4, 8).Trim();
                                if (int.TryParse(wghStrSub, out wgh))
                                {
                                    Console.WriteLine("SCALE : " + _scaleName + "," + wgh);
                                    lock (_lockObj)
                                    {
                                        _latestWeight = wgh.ToString();
                                    }
                                }
                            }
                            else
                            {
                                buffer.RemoveAt(0);
                            }
                        }
                        break;
                    case "X3":
                        serialPort1.Read(data, 0, data.Length);
                        buffer.AddRange(data);

                        while (buffer.Count >= 11)
                        {
                            if (buffer[0] == 0x02 && buffer[10] == 0x03)
                            {
                                b = buffer.Take(10).ToArray();
                                buffer.RemoveRange(0, 10);
                                byteConvertString = Encoding.ASCII.GetString(b);
                                wghStrSub = byteConvertString.Substring(4).Trim();
                                if (int.TryParse(wghStrSub, out wgh))
                                {
                                    Console.WriteLine("SCALE : " + _scaleName + "," + wgh);
                                    lock (_lockObj)
                                    {
                                        _latestWeight = wgh.ToString();

                                    }
                                }
                            }
                            else
                            {
                                buffer.RemoveAt(0);
                            }
                        }
                        break;
                }
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    label5.Text = _latestWeight;
                }));
                watchdogTimer.Start();
            }
            catch (Exception ex)
            {
                showBalloon("เกิดข้อผิดผลาดในการรับน้ำหนักจากเครื่องชั่ง : " + _scaleName + "\n" +
                    "ERROR : " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            Opacity = 0;
        }

        bool tryConnectPort()
        {
            try
            {
                serialPort1.PortName = cbbPort.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.StopBits = StopBits.One;
                switch (_scaleName)
                {
                    case "X3":
                        serialPort1.Parity = Parity.Even;
                        serialPort1.DataBits = 7;
                        break;
                    case "METLER":
                        serialPort1.Parity = Parity.None;
                        serialPort1.DataBits = 8;
                        break;
                }
                serialPort1.Open();
                showBalloon("เชื่อมต่อเครื่องชั่งสำเร็จ\n" +
                    "COM : " + cbbPort.Text + "\n" +
                    "SCALE : " + cbbScale.Text);
            }
            catch (Exception ex)
            {
                showBalloon("ไม่สามารถเชื่อมต่อเครื่องชั่งได้ \n" +
                    "ERROR : " + ex.Message + "\n" +
                    "โปรดตรวจการตั้งค่าใหม่อีกครั้ง");
                ErrorDes = "SCALE";
                return false;
            }
            return true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate ()
            {
                _latestWeight = "ERROR";
                label5.Text = "ERROR";
            }));
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // ค้นหา process ที่ชื่อเหมือนกัน
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);

            // ตรวจสอบว่ามี process ชื่อนี้ที่ ID ไม่ตรงกับตัวปัจจุบันหรือไม่
            if (processes.Any(p => p.Id != current.Id))
            {
                showBalloon("มีบริการเก่าเปิดอยู่แล้วไม่สามารถเปิดซ้ำกันได้");
                Application.Exit();
                return;
            }

            // ตั้งเวลา Timeout ไว้ที่ 2000 ms (2 วินาที)
            watchdogTimer = new System.Timers.Timer(2000);
            watchdogTimer.Elapsed += OnTimedEvent;
            watchdogTimer.AutoReset = false; // ให้ทำงานครั้งเดียวแล้วหยุดจนกว่าจะ Start ใหม่




            // load config
            cbbPort.Items.Clear();
            cbbScale.Items.Clear();
            cbbPort.Items.Add(_portName);
            cbbPort.SelectedIndex = 0;
            cbbScale.Items.Add(_scaleName);
            cbbScale.SelectedIndex = 0;

            // connect scale
            if (!tryConnectPort())
                return;

            await startServer();
        }
    }
}
