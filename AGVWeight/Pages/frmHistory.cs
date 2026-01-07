using AGVWeight.Db;
using AGVWeight.Models;
using AGVWeight.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVWeight.Pages
{
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
            cbbStatus.SelectedIndex = 0;
            cbbStatus.Enabled = false;
            txtLicense.Enabled = false;
            txtOrder.Enabled = false;
        }

        void showOrderList()
        {
            string _start = dtpStart.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.CreateSpecificCulture("en-EN"));
            string _end = dtpStop.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.CreateSpecificCulture("en-EN"));

            lblCount.Text = "0";
            lblCancelCount.Text = "0";
            lblProcessCount.Text = "0";
            lblSuccessCount.Text = "0";
            dgv.Rows.Clear();
            OrderDb orderDb = new OrderDb();
            List<OrderModel> list = orderDb.getOrderList(_start, _end, cbbStatus.Text, txtLicense.Text, txtOrder.Text);

            if (list != null && list.Count > 0)
                definDataGridViewList(list);
            else if (list.Count == 0)
                MessageBox.Show("ไม่พบรายการ", "ไม่พบรายการ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (list == null)
                MessageBox.Show("เกิดข้อผิดผลาดในการค้นหารายการ \nError : " + orderDb.Error, "เกิดข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void definDataGridViewList(List<OrderModel> list)
        {

            int successCount = 0;
            int processCount = 0;
            int cancelCount = 0;

            // define datagridview
            foreach (OrderModel model in list)
            {
                switch (model.Status)
                {
                    case "Success":
                        successCount++;
                        break;
                    case "Process":
                        processCount++;
                        break;
                    case "Cancel":
                        cancelCount++;
                        break;
                }
                dgv.Rows.Add(null, null, model.Id, model.OrderNumber, model.DateWeight, model.LicensePlate, model.NetWeight.ToString("#,###"), model.Typez, model.Product_name, model.Customer_name, model.Status);
            }

            // update ui
            foreach (DataGridViewRow rw in dgv.Rows)
            {
                string status = rw.Cells["cl_status"].Value.ToString();
                rw.Cells["cl_status"].Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                rw.Cells["cl_status"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                switch (status)
                {
                    case "Success":
                        rw.Cells["cl_status"].Style.ForeColor = Color.Green;
                        break;
                    case "Process":
                        rw.Cells["cl_status"].Style.ForeColor = Color.Blue;
                        break;
                    case "Cancel":
                        rw.Cells["cl_status"].Style.ForeColor = Color.Red;
                        break;
                }
            }

            lblSuccessCount.Text = successCount.ToString("N0");
            lblProcessCount.Text = processCount.ToString("N0");
            lblCancelCount.Text = cancelCount.ToString("N0");
            lblCount.Text = list.Count.ToString("N0");
        }


        private void frmHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showOrderList();
        }

        private void selectConditionSearch(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            switch (cb.Tag)
            {
                case "ORDER":
                    if (cb.Checked)
                        txtOrder.Enabled = true;
                    else
                    {
                        txtOrder.Clear();
                        txtOrder.Enabled = false;
                    }
                    break;
                case "LICENSE":
                    if (cb.Checked)
                        txtLicense.Enabled = true;
                    else
                    {
                        txtLicense.Clear();
                        txtLicense.Enabled = false;
                    }
                    break;
                case "STATUS":
                    if (cb.Checked)
                        cbbStatus.Enabled = true;
                    else
                    {
                        cbbStatus.SelectedIndex = 0;
                        cbbStatus.Enabled = false;
                    }
                    break;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string clName = dgv.Columns[e.ColumnIndex].Name;
                switch (clName)
                {
                    case "cl_print":
                        string status = dgv.Rows[e.RowIndex].Cells["cl_status"].Value.ToString();
                        if (status == "Cancel" || status == "Process")
                        {
                            MessageBox.Show("ไม่สามารถพิมพ์รายการที่ยังไม่สำเร็จหรือถูกยกเลิกไปแล้ว", "พิมพ์ใบชั่ง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int order_id = int.Parse(dgv.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());
                        frmReport frmReport = new frmReport(order_id, true);
                        this.Hide();
                        frmReport.ShowDialog();
                        this.Show();
                        break;
                    case "cl_detail":
                        break;
                }
            }
            catch
            {


            }
        }

        private void dtpStop_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStop.Value < dtpStart.Value)
            {
                MessageBox.Show("ไม่สามารถเลือกวันที่สิ้นสุด มากกว่า วันที่เริ่มต้นได้", "รูปแบบวันที่ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStop.Value = dtpStart.Value;
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpStop.Value)
            {
                MessageBox.Show("ไม่สามารถเลือกวันที่เริ่มต้น มากกว่า วันที่สิ้นสุดได้", "รูปแบบวันที่ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStart.Value = dtpStop.Value;
            }
        }
    }
}
