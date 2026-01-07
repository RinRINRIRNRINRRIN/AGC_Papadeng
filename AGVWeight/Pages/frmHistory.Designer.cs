namespace AGVWeight.Pages
{
    partial class frmHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            this.gbList = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCancelCount = new System.Windows.Forms.Label();
            this.lblProcessCount = new System.Windows.Forms.Label();
            this.lblSuccessCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFirstWeightCount = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cl_print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_ordernumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_licensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_netWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbList
            // 
            this.gbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbList.Controls.Add(this.pictureBox3);
            this.gbList.Controls.Add(this.pictureBox1);
            this.gbList.Controls.Add(this.pictureBox2);
            this.gbList.Controls.Add(this.lblCancelCount);
            this.gbList.Controls.Add(this.lblProcessCount);
            this.gbList.Controls.Add(this.lblSuccessCount);
            this.gbList.Controls.Add(this.label6);
            this.gbList.Controls.Add(this.label5);
            this.gbList.Controls.Add(this.label4);
            this.gbList.Controls.Add(this.lblCount);
            this.gbList.Controls.Add(this.lblFirstWeightCount);
            this.gbList.Controls.Add(this.dgv);
            this.gbList.Location = new System.Drawing.Point(9, 129);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(1259, 694);
            this.gbList.TabIndex = 1;
            this.gbList.TabStop = false;
            this.gbList.Text = "ข้อมูลรถค้างชั่ง";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(887, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(268, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblCancelCount
            // 
            this.lblCancelCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCancelCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelCount.ForeColor = System.Drawing.Color.Red;
            this.lblCancelCount.Location = new System.Drawing.Point(942, 46);
            this.lblCancelCount.Name = "lblCancelCount";
            this.lblCancelCount.Size = new System.Drawing.Size(99, 32);
            this.lblCancelCount.TabIndex = 5;
            this.lblCancelCount.Text = "0";
            this.lblCancelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcessCount
            // 
            this.lblProcessCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProcessCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProcessCount.Location = new System.Drawing.Point(646, 46);
            this.lblProcessCount.Name = "lblProcessCount";
            this.lblProcessCount.Size = new System.Drawing.Size(98, 32);
            this.lblProcessCount.TabIndex = 5;
            this.lblProcessCount.Text = "0";
            this.lblProcessCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSuccessCount
            // 
            this.lblSuccessCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSuccessCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessCount.ForeColor = System.Drawing.Color.Green;
            this.lblSuccessCount.Location = new System.Drawing.Point(330, 46);
            this.lblSuccessCount.Name = "lblSuccessCount";
            this.lblSuccessCount.Size = new System.Drawing.Size(111, 32);
            this.lblSuccessCount.TabIndex = 5;
            this.lblSuccessCount.Text = "0";
            this.lblSuccessCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(938, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "รายการที่ยกเลิก";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "รายการกำลังชั่ง";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "รายการที่ชั่งสำเร็จ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(7, 46);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(28, 32);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            // 
            // lblFirstWeightCount
            // 
            this.lblFirstWeightCount.AutoSize = true;
            this.lblFirstWeightCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstWeightCount.Location = new System.Drawing.Point(9, 25);
            this.lblFirstWeightCount.Name = "lblFirstWeightCount";
            this.lblFirstWeightCount.Size = new System.Drawing.Size(94, 21);
            this.lblFirstWeightCount.TabIndex = 1;
            this.lblFirstWeightCount.Text = "จำนวนทั้งหมด";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeight = 50;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_print,
            this.cl_detail,
            this.cl_id,
            this.cl_ordernumber,
            this.cl_date,
            this.cl_licensePlate,
            this.cl_netWeight,
            this.cl_type,
            this.cl_product,
            this.cl_customer,
            this.cl_status});
            this.dgv.Location = new System.Drawing.Point(9, 97);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 50;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 50;
            this.dgv.Size = new System.Drawing.Size(1244, 594);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbbStatus);
            this.groupBox1.Controls.Add(this.txtLicense);
            this.groupBox1.Controls.Add(this.txtOrder);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpStop);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1265, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายละเอียดการค้นหา";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1149, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 37);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "-- ไม่เลือกรายการ --",
            "Success",
            "Process",
            "Cancel"});
            this.cbbStatus.Location = new System.Drawing.Point(955, 68);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(188, 29);
            this.cbbStatus.TabIndex = 8;
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(735, 68);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(206, 29);
            this.txtLicense.TabIndex = 7;
            this.txtLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(517, 68);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(206, 29);
            this.txtOrder.TabIndex = 6;
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(955, 42);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 25);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Tag = "STATUS";
            this.checkBox3.Text = "สถานะชั่ง";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.selectConditionSearch);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(735, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(210, 25);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Tag = "LICENSE";
            this.checkBox2.Text = "ทะเบียนรถ(ทะเบียนรถใกล้เคียง)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.selectConditionSearch);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(517, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 25);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Tag = "ORDER";
            this.checkBox1.Text = "เลขที่ชั่ง";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.selectConditionSearch);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ถึง";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "วันที่สิ้นสุด";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "วันที่เริ่มต้น";
            // 
            // dtpStop
            // 
            this.dtpStop.Location = new System.Drawing.Point(288, 70);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(204, 29);
            this.dtpStop.TabIndex = 1;
            this.dtpStop.ValueChanged += new System.EventHandler(this.dtpStop_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(15, 70);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(204, 29);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // cl_print
            // 
            this.cl_print.HeaderText = "";
            this.cl_print.Name = "cl_print";
            this.cl_print.ReadOnly = true;
            this.cl_print.Text = "พิมพ์ตั๋ว";
            this.cl_print.UseColumnTextForButtonValue = true;
            this.cl_print.Width = 90;
            // 
            // cl_detail
            // 
            this.cl_detail.HeaderText = "";
            this.cl_detail.Name = "cl_detail";
            this.cl_detail.ReadOnly = true;
            this.cl_detail.Text = "รายละเอียดการชั่ง";
            this.cl_detail.UseColumnTextForButtonValue = true;
            this.cl_detail.Visible = false;
            this.cl_detail.Width = 140;
            // 
            // cl_id
            // 
            this.cl_id.HeaderText = "Id";
            this.cl_id.Name = "cl_id";
            this.cl_id.ReadOnly = true;
            this.cl_id.Visible = false;
            // 
            // cl_ordernumber
            // 
            this.cl_ordernumber.HeaderText = "เลขที่ชั่ง";
            this.cl_ordernumber.Name = "cl_ordernumber";
            this.cl_ordernumber.ReadOnly = true;
            this.cl_ordernumber.Width = 150;
            // 
            // cl_date
            // 
            this.cl_date.HeaderText = "วัน/เวลา ชั่งเข้า";
            this.cl_date.Name = "cl_date";
            this.cl_date.ReadOnly = true;
            this.cl_date.Width = 200;
            // 
            // cl_licensePlate
            // 
            this.cl_licensePlate.HeaderText = "ทะเบียนรถ";
            this.cl_licensePlate.Name = "cl_licensePlate";
            this.cl_licensePlate.ReadOnly = true;
            this.cl_licensePlate.Width = 150;
            // 
            // cl_netWeight
            // 
            this.cl_netWeight.HeaderText = "น้ำหนักสุทธิ";
            this.cl_netWeight.Name = "cl_netWeight";
            this.cl_netWeight.ReadOnly = true;
            this.cl_netWeight.Width = 120;
            // 
            // cl_type
            // 
            this.cl_type.HeaderText = "ประเภท";
            this.cl_type.Name = "cl_type";
            this.cl_type.ReadOnly = true;
            this.cl_type.Width = 300;
            // 
            // cl_product
            // 
            this.cl_product.HeaderText = "สินค้า";
            this.cl_product.Name = "cl_product";
            this.cl_product.ReadOnly = true;
            this.cl_product.Width = 300;
            // 
            // cl_customer
            // 
            this.cl_customer.HeaderText = "ลูกค้า";
            this.cl_customer.Name = "cl_customer";
            this.cl_customer.ReadOnly = true;
            this.cl_customer.Width = 300;
            // 
            // cl_status
            // 
            this.cl_status.HeaderText = "สถานะชั่ง";
            this.cl_status.Name = "cl_status";
            this.cl_status.ReadOnly = true;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 835);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbList);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ประวัติการชั่ง";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHistory_Load);
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Label lblFirstWeightCount;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCancelCount;
        private System.Windows.Forms.Label lblProcessCount;
        private System.Windows.Forms.Label lblSuccessCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewButtonColumn cl_print;
        private System.Windows.Forms.DataGridViewButtonColumn cl_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ordernumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_licensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_netWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_status;
    }
}