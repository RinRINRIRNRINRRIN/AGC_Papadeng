//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
using AGVWeight.Db;
using AGVWeight.Models;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVWeight.Reports
{
    public partial class frmReport : Form
    {
        public frmReport(int order_id, bool isPreview)
        {
            InitializeComponent();
            this.order_id = order_id;
            this.IsPrevice = isPreview;
        }

        private readonly bool IsPrevice;
        private readonly int order_id;
        private OrderModel orderModel;
        void print()
        {
            ReportDocument report = (ReportDocument)crystalReportViewer1.ReportSource;
            if (report == null)
            {
                MessageBox.Show("ไม่พบ report", "ไม่พบ report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            // ชื่อฟอร์มกระดาษที่สร้างไว้ใน Windows
            string customFormName = "TSC";

            // ใช้ default printer (หรือระบุชื่อเครื่องพิมพ์เองก็ได้)
            PrintDocument pd = new PrintDocument();
            // pd.PrinterSettings.PrinterName = "ชื่อเครื่องพิมพ์ของคุณ";

            // หา paper size ที่ชื่อ = TSC
            System.Drawing.Printing.PaperSize found = pd.PrinterSettings.PaperSizes
                .Cast<System.Drawing.Printing.PaperSize>()
                .FirstOrDefault(p =>
                    p.PaperName.Equals(customFormName, StringComparison.OrdinalIgnoreCase));

            if (found == null)
            {
                MessageBox.Show($"ไม่พบฟอร์ม '{customFormName}' ในเครื่องพิมพ์ {pd.PrinterSettings.PrinterName}");
                this.Close();
                return;
            }

            // เซ็ตค่าให้รายงาน
            report.PrintOptions.PrinterName = pd.PrinterSettings.PrinterName;
            report.PrintOptions.PaperOrientation = PaperOrientation.Landscape;  // หรือ Portrait ตามต้องการ
            report.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)found.RawKind;

            // พิมพ์ (1 ชุด, ไม่ collate, ทุกหน้า)
            report.PrintToPrinter(1, false, 0, 0);

            this.Close();
        }

        void DefineReportParameter()
        {
            // get main order
            OrderDb orderDb = new OrderDb();
            OrderModel _orderModel = orderDb.getOrderById(order_id);
            orderModel = _orderModel;

            // get order detail
            string wghIn = "", wghOut = "", DateIn = "", DateOut = "", TimeIn = "", TimeOut = "";
            OrderDetailDb orderDetailDb = new OrderDetailDb();
            List<OrderDetailModel> orderDetailModels = orderDetailDb.getOrderDetailById(order_id);
            foreach (OrderDetailModel model in orderDetailModels)
            {
                string[] dates = model.DateTimez.Split(' ');
                if (model.WeightType == "FIRST WEIGHT")
                {
                    wghIn = model.Weight.ToString("N0");
                    DateIn = dates[0].Trim();
                    TimeIn = dates[1].Trim();
                }
                if (model.WeightType == "SECOND WEIGHT")
                {
                    wghOut = model.Weight.ToString("N0");
                    DateOut = dates[0].Trim();
                    TimeOut = dates[1].Trim();
                }
            }
            //rptTicketTSC rpt = new rptTicketTSC();
            rptTicket rpt = new rptTicket();
            rpt.SetParameterValue("rptOrderNumber", orderModel.OrderNumber);
            rpt.SetParameterValue("rptCustomer", orderModel.Customer_name);
            rpt.SetParameterValue("rptProduct", orderModel.Product_name);
            rpt.SetParameterValue("rptDaliveryNote", orderModel.DnNo);
            rpt.SetParameterValue("rptShipmentDocNo", orderModel.Shipment);
            rpt.SetParameterValue("rptTransport", orderModel.Transport_name);
            rpt.SetParameterValue("rptContainer", orderModel.ContainerNo);
            rpt.SetParameterValue("rptLicensePlate", orderModel.LicensePlate);
            rpt.SetParameterValue("rptDateIn", DateIn);
            rpt.SetParameterValue("rptDateOut", DateOut);
            rpt.SetParameterValue("rptTimeIn", TimeIn);
            rpt.SetParameterValue("rptTimeOut", TimeOut);
            rpt.SetParameterValue("rptWeightIn", wghIn);
            rpt.SetParameterValue("rptWeightOut", wghOut);
            rpt.SetParameterValue("rptWeightNet", orderModel.NetWeight.ToString("N0"));

            crystalReportViewer1.EnableRefresh = false;
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Zoom(180);
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            DefineReportParameter();
            if (!IsPrevice)
            {
                this.WindowState = FormWindowState.Minimized;
                print();
            }
            label3.Text = orderModel.LicensePlate;
            label4.Text = orderModel.OrderNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}
