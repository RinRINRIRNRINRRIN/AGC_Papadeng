using AGVWeight.Db;
using AGVWeight.Models;
using System;
using System.Collections;
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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            this.Size = new Size(603, 578);
            int x = (this.Width - gbInformation.Width) / 2;
            int y = (this.Height - gbInformation.Height) / 2;
            gbInformation.Location = new Point(x, y);
        }

        private int _id = 0;

        void showAllInformation()
        {
            ProductDb productDb = new ProductDb();
            List<ProductModel> lists = productDb.getAllProduct();
            defineDatagrid(lists);
        }

        void defineDatagrid(List<ProductModel> lists)
        {
            dgv.Rows.Clear();
            if (lists == null)
                return;

            foreach (ProductModel list in lists)
                dgv.Rows.Add("", "", list.Id, list.Namez);
        }


        void clearScreen()
        {
            _id = 0;
            txtName.Clear();
            gbInformation.Visible = false;
            panel1.Visible = true;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            showAllInformation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบก่อนการบันทึก", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductDb typeDb = new ProductDb();
            ProductModel model = new ProductModel
            {
                Id = _id,
                Namez = txtName.Text,
            };

            if (_id == 0)
            {
                if (!typeDb.addNew(model))
                {
                    MessageBox.Show("เกิดข้อผิดผลาดในการเพิ่มข้อมูล \nError : " + typeDb.Error, "เกิดข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("เพิ่มรายการใหม่สำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!typeDb.updateById(model))
                {
                    MessageBox.Show("เกิดข้อผิดผลาดในการแก้ไขข้อมูล \nError : " + typeDb.Error, "เกิดข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("อัพเดทข้อมูล", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            clearScreen();
            showAllInformation();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string clName = dgv.Columns[e.ColumnIndex].Name;
                int id = int.Parse(dgv.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());
                switch (clName)
                {
                    case "cl_delete":
                        DialogResult res = MessageBox.Show("คุณต้องการลบรายการหรือไม่", "ลบรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            ProductDb typeDb = new ProductDb();
                            if (!typeDb.removeById(id))
                            {
                                MessageBox.Show("เกิดข้อผิดผลาดในการลบข้อมูล \nError : " + typeDb.Error, "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            MessageBox.Show("ลบรายการสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showAllInformation();
                        }
                        break;
                    case "cl_edit":
                        _id = int.Parse(dgv.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());
                        string type_name = dgv.Rows[e.RowIndex].Cells["cl_name"].Value.ToString();
                        txtName.Text = type_name;
                        gbInformation.Visible = true;
                        panel1.Visible = false;
                        break;
                }
            }
            catch
            {


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                showAllInformation();
            else
            {
                ProductDb typeDb = new ProductDb();
                List<ProductModel> lists = typeDb.getProductNameByLike(textBox1.Text);
                if (lists == null)
                {
                    MessageBox.Show("เกิดข้อผิดผลาดในการค้นหารายการ \nError : " + typeDb.Error, "เกิดข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                defineDatagrid(lists);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbInformation.Visible = true;
            panel1.Visible = false;
        }
    }
}
