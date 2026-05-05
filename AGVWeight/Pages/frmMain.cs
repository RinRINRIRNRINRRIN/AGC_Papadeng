using AGVWeight.Db;
using AGVWeight.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVWeight
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ขอมลประเภทToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            this.Hide();
            switch (item.Tag)
            {
                case "TYPE":
                    frmTypes frmTypes = new frmTypes();
                    frmTypes.ShowDialog();
                    break;
                case "PRODUCT":
                    frmProduct frmProduct = new frmProduct();
                    frmProduct.ShowDialog();
                    break;
                case "CUSTOMER":
                    frmCustomer frmCustomer = new frmCustomer();
                    frmCustomer.ShowDialog();
                    break;
                case "TRANSPORT":
                    frmTransport frmTransport = new frmTransport();
                    frmTransport.ShowDialog();
                    break;
                case "SETTING":
                    frmSetting frmSetting = new frmSetting();
                    frmSetting.ShowDialog();
                    break;
                case "HIRE":
                    frmHire frmHire = new frmHire();
                    frmHire.ShowDialog();
                    break;
                case "WEIGHT":
                    frmWeighing frmWeight = new frmWeighing();
                    frmWeight.ShowDialog();
                    break;
                case "HISTORY":
                    frmHistory frmHistory = new frmHistory();
                    frmHistory.ShowDialog();
                    break;

            }
            this.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!DbContact.tryConnectDatabase())
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อฐานข้อมูลได้กรุณาตรวจสอบฐานข้อมูลอีกครั้ง \n Error : " + DbContact.Error, "เกิดข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
        }
    }
}
