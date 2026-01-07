namespace AGVWeight
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.จดการขอมลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลประเภทToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลลกคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลบรษทขนสงToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ชงสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ประวตการชงToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตงคาระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.จดการขอมลToolStripMenuItem,
            this.ชงสนคาToolStripMenuItem,
            this.ประวตการชงToolStripMenuItem,
            this.ตงคาระบบToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // จดการขอมลToolStripMenuItem
            // 
            this.จดการขอมลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลประเภทToolStripMenuItem,
            this.ขอมลสนคาToolStripMenuItem,
            this.ขอมลลกคาToolStripMenuItem,
            this.ขอมลบรษทขนสงToolStripMenuItem});
            this.จดการขอมลToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("จดการขอมลToolStripMenuItem.Image")));
            this.จดการขอมลToolStripMenuItem.Name = "จดการขอมลToolStripMenuItem";
            this.จดการขอมลToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.จดการขอมลToolStripMenuItem.Text = "จัดการข้อมูล";
            // 
            // ขอมลประเภทToolStripMenuItem
            // 
            this.ขอมลประเภทToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ขอมลประเภทToolStripMenuItem.Image")));
            this.ขอมลประเภทToolStripMenuItem.Name = "ขอมลประเภทToolStripMenuItem";
            this.ขอมลประเภทToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.ขอมลประเภทToolStripMenuItem.Tag = "TYPE";
            this.ขอมลประเภทToolStripMenuItem.Text = "ข้อมูลประเภท";
            this.ขอมลประเภทToolStripMenuItem.Click += new System.EventHandler(this.ขอมลประเภทToolStripMenuItem_Click);
            // 
            // ขอมลสนคาToolStripMenuItem
            // 
            this.ขอมลสนคาToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ขอมลสนคาToolStripMenuItem.Image")));
            this.ขอมลสนคาToolStripMenuItem.Name = "ขอมลสนคาToolStripMenuItem";
            this.ขอมลสนคาToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.ขอมลสนคาToolStripMenuItem.Tag = "PRODUCT";
            this.ขอมลสนคาToolStripMenuItem.Text = "ข้อมูลสินค้า";
            this.ขอมลสนคาToolStripMenuItem.Click += new System.EventHandler(this.ขอมลประเภทToolStripMenuItem_Click);
            // 
            // ขอมลลกคาToolStripMenuItem
            // 
            this.ขอมลลกคาToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ขอมลลกคาToolStripMenuItem.Image")));
            this.ขอมลลกคาToolStripMenuItem.Name = "ขอมลลกคาToolStripMenuItem";
            this.ขอมลลกคาToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.ขอมลลกคาToolStripMenuItem.Tag = "CUSTOMER";
            this.ขอมลลกคาToolStripMenuItem.Text = "ข้อมูลลูกค้า";
            this.ขอมลลกคาToolStripMenuItem.Click += new System.EventHandler(this.ขอมลประเภทToolStripMenuItem_Click);
            // 
            // ขอมลบรษทขนสงToolStripMenuItem
            // 
            this.ขอมลบรษทขนสงToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ขอมลบรษทขนสงToolStripMenuItem.Image")));
            this.ขอมลบรษทขนสงToolStripMenuItem.Name = "ขอมลบรษทขนสงToolStripMenuItem";
            this.ขอมลบรษทขนสงToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.ขอมลบรษทขนสงToolStripMenuItem.Tag = "TRANSPORT";
            this.ขอมลบรษทขนสงToolStripMenuItem.Text = "ข้อมูลบริษัทขนส่ง";
            this.ขอมลบรษทขนสงToolStripMenuItem.Click += new System.EventHandler(this.ขอมลประเภทToolStripMenuItem_Click);
            // 
            // ชงสนคาToolStripMenuItem
            // 
            this.ชงสนคาToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ชงสนคาToolStripMenuItem.Image")));
            this.ชงสนคาToolStripMenuItem.Name = "ชงสนคาToolStripMenuItem";
            this.ชงสนคาToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.ชงสนคาToolStripMenuItem.Text = "ชั่งสินค้า";
            this.ชงสนคาToolStripMenuItem.Click += new System.EventHandler(this.ชงสนคาToolStripMenuItem_Click);
            // 
            // ประวตการชงToolStripMenuItem
            // 
            this.ประวตการชงToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ประวตการชงToolStripMenuItem.Image")));
            this.ประวตการชงToolStripMenuItem.Name = "ประวตการชงToolStripMenuItem";
            this.ประวตการชงToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.ประวตการชงToolStripMenuItem.Text = "ประวัติการชั่ง";
            this.ประวตการชงToolStripMenuItem.Click += new System.EventHandler(this.ประวตการชงToolStripMenuItem_Click);
            // 
            // ตงคาระบบToolStripMenuItem
            // 
            this.ตงคาระบบToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ตงคาระบบToolStripMenuItem.Image")));
            this.ตงคาระบบToolStripMenuItem.Name = "ตงคาระบบToolStripMenuItem";
            this.ตงคาระบบToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.ตงคาระบบToolStripMenuItem.Tag = "SETTING";
            this.ตงคาระบบToolStripMenuItem.Text = "ตั้งค่าระบบ";
            this.ตงคาระบบToolStripMenuItem.Click += new System.EventHandler(this.ขอมลประเภทToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "โปรแกรมเครื่องชั่งรถบรรทุก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "บริษัท ไทยเครื่องชั่ง จำกัด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(651, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "V 1.0.0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมเครื่องชั่งรถบรรทุก";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem จดการขอมลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลประเภทToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลลกคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลบรษทขนสงToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ชงสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ประวตการชงToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตงคาระบบToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

