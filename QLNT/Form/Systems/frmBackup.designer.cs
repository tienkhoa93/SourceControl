namespace QLNT.Form.Systems
{
    partial class frmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.lb_loi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBackupAuto = new DevExpress.XtraEditors.CheckEdit();
            this.rdoThu7 = new System.Windows.Forms.RadioButton();
            this.rdoThu6 = new System.Windows.Forms.RadioButton();
            this.rdoThu5 = new System.Windows.Forms.RadioButton();
            this.rdoThu4 = new System.Windows.Forms.RadioButton();
            this.rdoThu3 = new System.Windows.Forms.RadioButton();
            this.rdoThu2 = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThucThi = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txt_foldername = new DevExpress.XtraEditors.TextEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::QLNT.Form.frmWait), true, true);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkBackupAuto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_foldername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_loi
            // 
            this.lb_loi.Appearance.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loi.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_loi.Location = new System.Drawing.Point(56, 53);
            this.lb_loi.Name = "lb_loi";
            this.lb_loi.Size = new System.Drawing.Size(0, 13);
            this.lb_loi.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl3.Location = new System.Drawing.Point(55, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 15);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Chọn nơi lưu tệp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBackupAuto);
            this.groupBox1.Controls.Add(this.rdoThu7);
            this.groupBox1.Controls.Add(this.rdoThu6);
            this.groupBox1.Controls.Add(this.rdoThu5);
            this.groupBox1.Controls.Add(this.rdoThu4);
            this.groupBox1.Controls.Add(this.rdoThu3);
            this.groupBox1.Controls.Add(this.rdoThu2);
            this.groupBox1.Location = new System.Drawing.Point(16, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 99);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sao lưu tự động trong tuần";
            // 
            // chkBackupAuto
            // 
            this.chkBackupAuto.Location = new System.Drawing.Point(284, 62);
            this.chkBackupAuto.Name = "chkBackupAuto";
            this.chkBackupAuto.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.chkBackupAuto.Properties.Appearance.Options.UseForeColor = true;
            this.chkBackupAuto.Properties.Caption = "Sao lưu tự động";
            this.chkBackupAuto.Size = new System.Drawing.Size(107, 19);
            this.chkBackupAuto.TabIndex = 6;
            // 
            // rdoThu7
            // 
            this.rdoThu7.AutoSize = true;
            this.rdoThu7.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.rdoThu7.Location = new System.Drawing.Point(161, 62);
            this.rdoThu7.Name = "rdoThu7";
            this.rdoThu7.Size = new System.Drawing.Size(67, 19);
            this.rdoThu7.TabIndex = 5;
            this.rdoThu7.TabStop = true;
            this.rdoThu7.Text = "Thứ bảy";
            this.rdoThu7.UseVisualStyleBackColor = true;
            // 
            // rdoThu6
            // 
            this.rdoThu6.AutoSize = true;
            this.rdoThu6.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.rdoThu6.Location = new System.Drawing.Point(13, 62);
            this.rdoThu6.Name = "rdoThu6";
            this.rdoThu6.Size = new System.Drawing.Size(68, 19);
            this.rdoThu6.TabIndex = 4;
            this.rdoThu6.TabStop = true;
            this.rdoThu6.Text = "Thứ  sáu";
            this.rdoThu6.UseVisualStyleBackColor = true;
            // 
            // rdoThu5
            // 
            this.rdoThu5.AutoSize = true;
            this.rdoThu5.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.rdoThu5.Location = new System.Drawing.Point(409, 29);
            this.rdoThu5.Name = "rdoThu5";
            this.rdoThu5.Size = new System.Drawing.Size(69, 19);
            this.rdoThu5.TabIndex = 3;
            this.rdoThu5.TabStop = true;
            this.rdoThu5.Text = "Thứ năm";
            this.rdoThu5.UseVisualStyleBackColor = true;
            // 
            // rdoThu4
            // 
            this.rdoThu4.AutoSize = true;
            this.rdoThu4.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.rdoThu4.Location = new System.Drawing.Point(286, 29);
            this.rdoThu4.Name = "rdoThu4";
            this.rdoThu4.Size = new System.Drawing.Size(60, 19);
            this.rdoThu4.TabIndex = 2;
            this.rdoThu4.TabStop = true;
            this.rdoThu4.Text = "Thứ tư";
            this.rdoThu4.UseVisualStyleBackColor = true;
            // 
            // rdoThu3
            // 
            this.rdoThu3.AutoSize = true;
            this.rdoThu3.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.rdoThu3.Location = new System.Drawing.Point(161, 29);
            this.rdoThu3.Name = "rdoThu3";
            this.rdoThu3.Size = new System.Drawing.Size(60, 19);
            this.rdoThu3.TabIndex = 1;
            this.rdoThu3.TabStop = true;
            this.rdoThu3.Text = "Thứ ba";
            this.rdoThu3.UseVisualStyleBackColor = true;
            // 
            // rdoThu2
            // 
            this.rdoThu2.AutoSize = true;
            this.rdoThu2.Checked = true;
            this.rdoThu2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThu2.Location = new System.Drawing.Point(13, 23);
            this.rdoThu2.Name = "rdoThu2";
            this.rdoThu2.Size = new System.Drawing.Size(63, 19);
            this.rdoThu2.TabIndex = 0;
            this.rdoThu2.TabStop = true;
            this.rdoThu2.Text = "Thứ hai";
            this.rdoThu2.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl2.Location = new System.Drawing.Point(56, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 15);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Nhập tên dữ liệu:";
            // 
            // txtName
            // 
            this.txtName.EditValue = "QLNT";
            this.txtName.Location = new System.Drawing.Point(159, 75);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtName.Properties.Appearance.Options.UseForeColor = true;
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Location = new System.Drawing.Point(159, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 26);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "SAO LƯU DỮ LIỆU";
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnDong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Appearance.Options.UseForeColor = true;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(266, 141);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(139, 27);
            this.btnDong.TabIndex = 22;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThucThi
            // 
            this.btnThucThi.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnThucThi.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThucThi.Appearance.Options.UseFont = true;
            this.btnThucThi.Appearance.Options.UseForeColor = true;
            this.btnThucThi.Image = ((System.Drawing.Image)(resources.GetObject("btnThucThi.Image")));
            this.btnThucThi.Location = new System.Drawing.Point(103, 141);
            this.btnThucThi.Name = "btnThucThi";
            this.btnThucThi.Size = new System.Drawing.Size(139, 27);
            this.btnThucThi.TabIndex = 21;
            this.btnThucThi.Text = "Thực hiện";
            this.btnThucThi.Click += new System.EventHandler(this.btnThucThi_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btnBrowse.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Appearance.Options.UseForeColor = true;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(358, 104);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(143, 20);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Duyệt";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txt_foldername
            // 
            this.txt_foldername.Enabled = false;
            this.txt_foldername.Location = new System.Drawing.Point(159, 105);
            this.txt_foldername.Name = "txt_foldername";
            this.txt_foldername.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_foldername.Properties.Appearance.Options.UseForeColor = true;
            this.txt_foldername.Size = new System.Drawing.Size(192, 20);
            this.txt_foldername.TabIndex = 23;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 291);
            this.Controls.Add(this.lb_loi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThucThi);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txt_foldername);
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu Cơ sở dữ liệu";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackup_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkBackupAuto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_foldername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lb_loi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoThu7;
        private System.Windows.Forms.RadioButton rdoThu6;
        private System.Windows.Forms.RadioButton rdoThu5;
        private System.Windows.Forms.RadioButton rdoThu4;
        private System.Windows.Forms.RadioButton rdoThu3;
        private System.Windows.Forms.RadioButton rdoThu2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThucThi;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit txt_foldername;
        private DevExpress.XtraEditors.CheckEdit chkBackupAuto;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;

    }
}