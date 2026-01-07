namespace AGVWeight.Pages
{
    partial class frmWeighing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeighing));
            this.lblTsc = new System.Windows.Forms.Label();
            this.lblMet = new System.Windows.Forms.Label();
            this.lblIpTsc = new System.Windows.Forms.Label();
            this.lblIpMet = new System.Windows.Forms.Label();
            this.rdbTsc = new System.Windows.Forms.RadioButton();
            this.rdbMet = new System.Windows.Forms.RadioButton();
            this.pnTsc = new System.Windows.Forms.Panel();
            this.pnMet = new System.Windows.Forms.Panel();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtContainer = new System.Windows.Forms.TextBox();
            this.txtShipment = new System.Windows.Forms.TextBox();
            this.txtSealNo = new System.Windows.Forms.TextBox();
            this.txtDn = new System.Windows.Forms.TextBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.cbbTransport = new System.Windows.Forms.ComboBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.lblFirstWeightCount = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cl_select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_ordernumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_licensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_weightIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_indicator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSystem = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSlaveId = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblComDevice = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tmStableCheck = new System.Windows.Forms.Timer(this.components);
            this.tmUpdateModbusServer = new System.Windows.Forms.Timer(this.components);
            this.gbInformation.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTsc
            // 
            this.lblTsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTsc.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTsc.Location = new System.Drawing.Point(122, 77);
            this.lblTsc.Name = "lblTsc";
            this.lblTsc.Size = new System.Drawing.Size(333, 134);
            this.lblTsc.TabIndex = 0;
            this.lblTsc.Tag = "TSC";
            this.lblTsc.Text = "00000";
            this.lblTsc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTsc.Click += new System.EventHandler(this.selectIndicator2);
            // 
            // lblMet
            // 
            this.lblMet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMet.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMet.Location = new System.Drawing.Point(122, 243);
            this.lblMet.Name = "lblMet";
            this.lblMet.Size = new System.Drawing.Size(333, 134);
            this.lblMet.TabIndex = 0;
            this.lblMet.Tag = "MET";
            this.lblMet.Text = "00000";
            this.lblMet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMet.Click += new System.EventHandler(this.selectIndicator2);
            // 
            // lblIpTsc
            // 
            this.lblIpTsc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpTsc.Location = new System.Drawing.Point(207, 56);
            this.lblIpTsc.Name = "lblIpTsc";
            this.lblIpTsc.Size = new System.Drawing.Size(248, 21);
            this.lblIpTsc.TabIndex = 0;
            this.lblIpTsc.Text = "XXX.XXX.XXX.XXX";
            this.lblIpTsc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIpMet
            // 
            this.lblIpMet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpMet.Location = new System.Drawing.Point(207, 222);
            this.lblIpMet.Name = "lblIpMet";
            this.lblIpMet.Size = new System.Drawing.Size(248, 21);
            this.lblIpMet.TabIndex = 0;
            this.lblIpMet.Text = "XXX.XXX.XXX.XXX";
            this.lblIpMet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdbTsc
            // 
            this.rdbTsc.AutoSize = true;
            this.rdbTsc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTsc.Location = new System.Drawing.Point(99, 52);
            this.rdbTsc.Name = "rdbTsc";
            this.rdbTsc.Size = new System.Drawing.Size(111, 25);
            this.rdbTsc.TabIndex = 5;
            this.rdbTsc.TabStop = true;
            this.rdbTsc.Tag = "TSC";
            this.rdbTsc.Text = "THAISCALE";
            this.rdbTsc.UseVisualStyleBackColor = true;
            this.rdbTsc.CheckedChanged += new System.EventHandler(this.selectIndicator);
            // 
            // rdbMet
            // 
            this.rdbMet.AutoSize = true;
            this.rdbMet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMet.Location = new System.Drawing.Point(99, 218);
            this.rdbMet.Name = "rdbMet";
            this.rdbMet.Size = new System.Drawing.Size(95, 25);
            this.rdbMet.TabIndex = 6;
            this.rdbMet.TabStop = true;
            this.rdbMet.Tag = "MET";
            this.rdbMet.Text = "METTLER";
            this.rdbMet.UseVisualStyleBackColor = true;
            this.rdbMet.CheckedChanged += new System.EventHandler(this.selectIndicator);
            // 
            // pnTsc
            // 
            this.pnTsc.BackColor = System.Drawing.Color.Green;
            this.pnTsc.Location = new System.Drawing.Point(99, 77);
            this.pnTsc.Name = "pnTsc";
            this.pnTsc.Size = new System.Drawing.Size(22, 134);
            this.pnTsc.TabIndex = 0;
            this.pnTsc.Visible = false;
            // 
            // pnMet
            // 
            this.pnMet.BackColor = System.Drawing.Color.Green;
            this.pnMet.Location = new System.Drawing.Point(99, 243);
            this.pnMet.Name = "pnMet";
            this.pnMet.Size = new System.Drawing.Size(22, 134);
            this.pnMet.TabIndex = 0;
            this.pnMet.Visible = false;
            // 
            // gbInformation
            // 
            this.gbInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbInformation.Controls.Add(this.label22);
            this.gbInformation.Controls.Add(this.label21);
            this.gbInformation.Controls.Add(this.label20);
            this.gbInformation.Controls.Add(this.label19);
            this.gbInformation.Controls.Add(this.label18);
            this.gbInformation.Controls.Add(this.label17);
            this.gbInformation.Controls.Add(this.label16);
            this.gbInformation.Controls.Add(this.txtContainer);
            this.gbInformation.Controls.Add(this.txtShipment);
            this.gbInformation.Controls.Add(this.txtSealNo);
            this.gbInformation.Controls.Add(this.txtDn);
            this.gbInformation.Controls.Add(this.txtSo);
            this.gbInformation.Controls.Add(this.label10);
            this.gbInformation.Controls.Add(this.label9);
            this.gbInformation.Controls.Add(this.label8);
            this.gbInformation.Controls.Add(this.label7);
            this.gbInformation.Controls.Add(this.label6);
            this.gbInformation.Controls.Add(this.cbbProduct);
            this.gbInformation.Controls.Add(this.cbbCustomer);
            this.gbInformation.Controls.Add(this.cbbTransport);
            this.gbInformation.Controls.Add(this.cbbType);
            this.gbInformation.Controls.Add(this.txtLicensePlate);
            this.gbInformation.Controls.Add(this.label5);
            this.gbInformation.Controls.Add(this.label4);
            this.gbInformation.Controls.Add(this.label3);
            this.gbInformation.Controls.Add(this.label2);
            this.gbInformation.Controls.Add(this.label1);
            this.gbInformation.Location = new System.Drawing.Point(79, 12);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(544, 650);
            this.gbInformation.TabIndex = 0;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "รายละเอียดรถ";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Red;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(6, 368);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(529, 21);
            this.label22.TabIndex = 12;
            this.label22.Text = "SO,DN,Seal,Shipment,Container หากไม่ใช่ระบบจะเติมค่า - ให้อัตโนมัติ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Red;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(6, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(529, 21);
            this.label21.TabIndex = 11;
            this.label21.Text = "* = จำเป็นต้องใส่ค่า";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(5, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(9, 337);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(6, 272);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(6, 206);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(6, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "*";
            // 
            // txtContainer
            // 
            this.txtContainer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainer.Location = new System.Drawing.Point(6, 607);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(529, 35);
            this.txtContainer.TabIndex = 10;
            // 
            // txtShipment
            // 
            this.txtShipment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipment.Location = new System.Drawing.Point(6, 545);
            this.txtShipment.Name = "txtShipment";
            this.txtShipment.Size = new System.Drawing.Size(529, 35);
            this.txtShipment.TabIndex = 9;
            // 
            // txtSealNo
            // 
            this.txtSealNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSealNo.Location = new System.Drawing.Point(6, 479);
            this.txtSealNo.Name = "txtSealNo";
            this.txtSealNo.Size = new System.Drawing.Size(529, 35);
            this.txtSealNo.TabIndex = 8;
            // 
            // txtDn
            // 
            this.txtDn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDn.Location = new System.Drawing.Point(280, 413);
            this.txtDn.Name = "txtDn";
            this.txtDn.Size = new System.Drawing.Size(255, 35);
            this.txtDn.TabIndex = 7;
            // 
            // txtSo
            // 
            this.txtSo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo.Location = new System.Drawing.Point(6, 413);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(268, 35);
            this.txtSo.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Container No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "DN No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Shipment No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seal No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "SO No.";
            // 
            // cbbProduct
            // 
            this.cbbProduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(28, 327);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(507, 38);
            this.cbbProduct.TabIndex = 5;
            this.cbbProduct.Tag = "PRODUCT";
            this.cbbProduct.DropDown += new System.EventHandler(this.selectCombobox);
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(28, 262);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(507, 38);
            this.cbbCustomer.TabIndex = 4;
            this.cbbCustomer.Tag = "CUSTOMER";
            this.cbbCustomer.DropDown += new System.EventHandler(this.selectCombobox);
            // 
            // cbbTransport
            // 
            this.cbbTransport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTransport.FormattingEnabled = true;
            this.cbbTransport.Location = new System.Drawing.Point(28, 197);
            this.cbbTransport.Name = "cbbTransport";
            this.cbbTransport.Size = new System.Drawing.Size(507, 38);
            this.cbbTransport.TabIndex = 3;
            this.cbbTransport.Tag = "TRANSPORT";
            this.cbbTransport.DropDown += new System.EventHandler(this.selectCombobox);
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(28, 130);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(507, 38);
            this.cbbType.TabIndex = 2;
            this.cbbType.Tag = "TYPE";
            this.cbbType.DropDown += new System.EventHandler(this.selectCombobox);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensePlate.Location = new System.Drawing.Point(28, 49);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(295, 54);
            this.txtLicensePlate.TabIndex = 1;
            this.txtLicensePlate.Tag = "REQUIRE";
            this.txtLicensePlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(329, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 54);
            this.label5.TabIndex = 0;
            this.label5.Text = "ทะเบียนรถ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "ลูกค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "สินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "บริษัทขนส่ง";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ประเภท";
            // 
            // gbList
            // 
            this.gbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbList.Controls.Add(this.lblFirstWeightCount);
            this.gbList.Controls.Add(this.dgv);
            this.gbList.Location = new System.Drawing.Point(3, 668);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(1246, 271);
            this.gbList.TabIndex = 0;
            this.gbList.TabStop = false;
            this.gbList.Text = "ข้อมูลรถค้างชั่ง";
            // 
            // lblFirstWeightCount
            // 
            this.lblFirstWeightCount.AutoSize = true;
            this.lblFirstWeightCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstWeightCount.Location = new System.Drawing.Point(9, 38);
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
            this.cl_select,
            this.cl_delete,
            this.cl_id,
            this.cl_ordernumber,
            this.cl_date,
            this.cl_licensePlate,
            this.cl_weightIn,
            this.cl_type,
            this.cl_product,
            this.cl_customer,
            this.cl_indicator});
            this.dgv.Location = new System.Drawing.Point(9, 71);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 50;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 50;
            this.dgv.Size = new System.Drawing.Size(1231, 197);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // cl_select
            // 
            this.cl_select.HeaderText = "";
            this.cl_select.Name = "cl_select";
            this.cl_select.ReadOnly = true;
            this.cl_select.Text = "ชั่งรอบสอง";
            this.cl_select.UseColumnTextForButtonValue = true;
            this.cl_select.Width = 160;
            // 
            // cl_delete
            // 
            this.cl_delete.HeaderText = "";
            this.cl_delete.Name = "cl_delete";
            this.cl_delete.ReadOnly = true;
            this.cl_delete.Text = "ยกเลิกรายการชั่ง";
            this.cl_delete.UseColumnTextForButtonValue = true;
            this.cl_delete.Width = 160;
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
            // cl_weightIn
            // 
            this.cl_weightIn.HeaderText = "น้ำหนักชั่งเข้า";
            this.cl_weightIn.Name = "cl_weightIn";
            this.cl_weightIn.ReadOnly = true;
            this.cl_weightIn.Width = 120;
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
            // cl_indicator
            // 
            this.cl_indicator.HeaderText = "เครื่องชั่ง";
            this.cl_indicator.Name = "cl_indicator";
            this.cl_indicator.ReadOnly = true;
            this.cl_indicator.Width = 200;
            // 
            // gbSystem
            // 
            this.gbSystem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSystem.Controls.Add(this.btnCancel);
            this.gbSystem.Controls.Add(this.btnSave);
            this.gbSystem.Controls.Add(this.lblSlaveId);
            this.gbSystem.Controls.Add(this.lblPort);
            this.gbSystem.Controls.Add(this.lblComDevice);
            this.gbSystem.Controls.Add(this.label15);
            this.gbSystem.Controls.Add(this.label14);
            this.gbSystem.Controls.Add(this.label13);
            this.gbSystem.Controls.Add(this.label12);
            this.gbSystem.Controls.Add(this.label11);
            this.gbSystem.Controls.Add(this.rdbMet);
            this.gbSystem.Controls.Add(this.lblTsc);
            this.gbSystem.Controls.Add(this.lblMet);
            this.gbSystem.Controls.Add(this.pnMet);
            this.gbSystem.Controls.Add(this.lblIpTsc);
            this.gbSystem.Controls.Add(this.pnTsc);
            this.gbSystem.Controls.Add(this.lblIpMet);
            this.gbSystem.Controls.Add(this.rdbTsc);
            this.gbSystem.Location = new System.Drawing.Point(629, 9);
            this.gbSystem.Name = "gbSystem";
            this.gbSystem.Size = new System.Drawing.Size(544, 650);
            this.gbSystem.TabIndex = 0;
            this.gbSystem.TabStop = false;
            this.gbSystem.Text = "ข้อมูลระบบ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(6, 574);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(259, 70);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(284, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(254, 70);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSlaveId
            // 
            this.lblSlaveId.AutoSize = true;
            this.lblSlaveId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlaveId.Location = new System.Drawing.Point(84, 537);
            this.lblSlaveId.Name = "lblSlaveId";
            this.lblSlaveId.Size = new System.Drawing.Size(77, 21);
            this.lblSlaveId.TabIndex = 0;
            this.lblSlaveId.Text = "lblSlaveId";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(84, 487);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(55, 21);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "lblPort";
            // 
            // lblComDevice
            // 
            this.lblComDevice.AutoSize = true;
            this.lblComDevice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComDevice.Location = new System.Drawing.Point(83, 436);
            this.lblComDevice.Name = "lblComDevice";
            this.lblComDevice.Size = new System.Drawing.Size(106, 21);
            this.lblComDevice.TabIndex = 0;
            this.lblComDevice.Text = "lblComDevice";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Slave Id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "COM Device";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "COM Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Modbus Server";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "เครื่องชั่ง";
            // 
            // tmStableCheck
            // 
            this.tmStableCheck.Enabled = true;
            this.tmStableCheck.Tick += new System.EventHandler(this.tmStableCheck_Tick);
            // 
            // tmUpdateModbusServer
            // 
            this.tmUpdateModbusServer.Interval = 1000;
            this.tmUpdateModbusServer.Tick += new System.EventHandler(this.tmUpdateModbusServer_Tick);
            // 
            // frmWeighing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 951);
            this.Controls.Add(this.gbSystem);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmWeighing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ชั่งสินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWeighing_FormClosing);
            this.Load += new System.EventHandler(this.frmWeighing_Load);
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbSystem.ResumeLayout(false);
            this.gbSystem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTsc;
        private System.Windows.Forms.Label lblMet;
        private System.Windows.Forms.Label lblIpTsc;
        private System.Windows.Forms.Label lblIpMet;
        private System.Windows.Forms.RadioButton rdbTsc;
        private System.Windows.Forms.RadioButton rdbMet;
        private System.Windows.Forms.Panel pnTsc;
        private System.Windows.Forms.Panel pnMet;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.GroupBox gbSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.ComboBox cbbTransport;
        private System.Windows.Forms.TextBox txtContainer;
        private System.Windows.Forms.TextBox txtShipment;
        private System.Windows.Forms.TextBox txtSealNo;
        private System.Windows.Forms.TextBox txtDn;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblComDevice;
        private System.Windows.Forms.Label lblSlaveId;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblFirstWeightCount;
        private System.Windows.Forms.Timer tmStableCheck;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Timer tmUpdateModbusServer;
        private System.Windows.Forms.DataGridViewButtonColumn cl_select;
        private System.Windows.Forms.DataGridViewButtonColumn cl_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ordernumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_licensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_weightIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_indicator;
    }
}