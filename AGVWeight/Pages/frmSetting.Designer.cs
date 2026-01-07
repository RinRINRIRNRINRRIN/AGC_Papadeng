namespace AGVWeight.Pages
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbCom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnMET = new System.Windows.Forms.Panel();
            this.txtMet1 = new System.Windows.Forms.TextBox();
            this.txtMet2 = new System.Windows.Forms.TextBox();
            this.txtMet3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMet4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnTSC = new System.Windows.Forms.Panel();
            this.txtTsc1 = new System.Windows.Forms.TextBox();
            this.txtTsc2 = new System.Windows.Forms.TextBox();
            this.txtTsc3 = new System.Windows.Forms.TextBox();
            this.txtTsc4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnMET.SuspendLayout();
            this.pnTSC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตั้งค่าระบบ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cbbCom
            // 
            this.cbbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCom.FormattingEnabled = true;
            this.cbbCom.Location = new System.Drawing.Point(15, 52);
            this.cbbCom.Name = "cbbCom";
            this.cbbCom.Size = new System.Drawing.Size(469, 33);
            this.cbbCom.TabIndex = 17;
            this.cbbCom.DropDown += new System.EventHandler(this.cbbCom_DropDown);
            this.cbbCom.SelectedIndexChanged += new System.EventHandler(this.cbbCom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "COM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbCom);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 100);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modbus Server";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(329, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "ระบบไม่รองรับพอร์ตจำลอง";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnMET);
            this.groupBox2.Controls.Add(this.pnTSC);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 176);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pnMET
            // 
            this.pnMET.Controls.Add(this.txtMet1);
            this.pnMET.Controls.Add(this.txtMet2);
            this.pnMET.Controls.Add(this.txtMet3);
            this.pnMET.Controls.Add(this.label8);
            this.pnMET.Controls.Add(this.txtMet4);
            this.pnMET.Controls.Add(this.label9);
            this.pnMET.Controls.Add(this.label10);
            this.pnMET.Location = new System.Drawing.Point(25, 125);
            this.pnMET.Name = "pnMET";
            this.pnMET.Size = new System.Drawing.Size(315, 40);
            this.pnMET.TabIndex = 80;
            // 
            // txtMet1
            // 
            this.txtMet1.Location = new System.Drawing.Point(3, 4);
            this.txtMet1.Name = "txtMet1";
            this.txtMet1.Size = new System.Drawing.Size(60, 33);
            this.txtMet1.TabIndex = 74;
            this.txtMet1.Text = "XXX";
            this.txtMet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMet1.TextChanged += new System.EventHandler(this.checkLength);
            this.txtMet1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // txtMet2
            // 
            this.txtMet2.Location = new System.Drawing.Point(82, 4);
            this.txtMet2.Name = "txtMet2";
            this.txtMet2.Size = new System.Drawing.Size(60, 33);
            this.txtMet2.TabIndex = 75;
            this.txtMet2.Text = "XXX";
            this.txtMet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMet2.TextChanged += new System.EventHandler(this.checkLength);
            this.txtMet2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // txtMet3
            // 
            this.txtMet3.Location = new System.Drawing.Point(162, 4);
            this.txtMet3.Name = "txtMet3";
            this.txtMet3.Size = new System.Drawing.Size(60, 33);
            this.txtMet3.TabIndex = 76;
            this.txtMet3.Text = "XXX";
            this.txtMet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMet3.TextChanged += new System.EventHandler(this.checkLength);
            this.txtMet3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = ".";
            // 
            // txtMet4
            // 
            this.txtMet4.Location = new System.Drawing.Point(242, 4);
            this.txtMet4.Name = "txtMet4";
            this.txtMet4.Size = new System.Drawing.Size(60, 33);
            this.txtMet4.TabIndex = 77;
            this.txtMet4.Text = "XXX";
            this.txtMet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMet4.TextChanged += new System.EventHandler(this.checkLength);
            this.txtMet4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(146, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = ".";
            // 
            // pnTSC
            // 
            this.pnTSC.Controls.Add(this.txtTsc1);
            this.pnTSC.Controls.Add(this.txtTsc2);
            this.pnTSC.Controls.Add(this.txtTsc3);
            this.pnTSC.Controls.Add(this.txtTsc4);
            this.pnTSC.Controls.Add(this.label4);
            this.pnTSC.Controls.Add(this.label6);
            this.pnTSC.Controls.Add(this.label7);
            this.pnTSC.Location = new System.Drawing.Point(25, 58);
            this.pnTSC.Name = "pnTSC";
            this.pnTSC.Size = new System.Drawing.Size(315, 40);
            this.pnTSC.TabIndex = 79;
            // 
            // txtTsc1
            // 
            this.txtTsc1.Location = new System.Drawing.Point(3, 3);
            this.txtTsc1.Name = "txtTsc1";
            this.txtTsc1.Size = new System.Drawing.Size(60, 33);
            this.txtTsc1.TabIndex = 70;
            this.txtTsc1.Text = "XXX";
            this.txtTsc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTsc1.TextChanged += new System.EventHandler(this.checkLength);
            this.txtTsc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // txtTsc2
            // 
            this.txtTsc2.Location = new System.Drawing.Point(82, 3);
            this.txtTsc2.Name = "txtTsc2";
            this.txtTsc2.Size = new System.Drawing.Size(60, 33);
            this.txtTsc2.TabIndex = 71;
            this.txtTsc2.Text = "XXX";
            this.txtTsc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTsc2.TextChanged += new System.EventHandler(this.checkLength);
            this.txtTsc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // txtTsc3
            // 
            this.txtTsc3.Location = new System.Drawing.Point(162, 3);
            this.txtTsc3.Name = "txtTsc3";
            this.txtTsc3.Size = new System.Drawing.Size(60, 33);
            this.txtTsc3.TabIndex = 72;
            this.txtTsc3.Text = "XXX";
            this.txtTsc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTsc3.TextChanged += new System.EventHandler(this.checkLength);
            this.txtTsc3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // txtTsc4
            // 
            this.txtTsc4.Location = new System.Drawing.Point(242, 3);
            this.txtTsc4.Name = "txtTsc4";
            this.txtTsc4.Size = new System.Drawing.Size(60, 33);
            this.txtTsc4.TabIndex = 73;
            this.txtTsc4.Text = "XXX";
            this.txtTsc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTsc4.TextChanged += new System.EventHandler(this.checkLength);
            this.txtTsc4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = ".";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(363, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 78;
            this.button2.Tag = "MET";
            this.button2.Text = "ทดสอบ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.testConnect);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 30;
            this.button1.Tag = "TSC";
            this.button1.Text = "ทดสอบ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.testConnect);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "IP Address Mettler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "IP Address Thai Scale";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 43);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(375, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 43);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 443);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตั้งค่าระบบ";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnMET.ResumeLayout(false);
            this.pnMET.PerformLayout();
            this.pnTSC.ResumeLayout(false);
            this.pnTSC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbCom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTsc4;
        private System.Windows.Forms.TextBox txtTsc3;
        private System.Windows.Forms.TextBox txtTsc2;
        private System.Windows.Forms.TextBox txtTsc1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMet4;
        private System.Windows.Forms.TextBox txtMet3;
        private System.Windows.Forms.TextBox txtMet2;
        private System.Windows.Forms.TextBox txtMet1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnMET;
        private System.Windows.Forms.Panel pnTSC;
    }
}