namespace QLNT.Form.Systems
{
    partial class frmRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestore));
            this.lblLoi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThucThi = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtFolderName = new DevExpress.XtraEditors.TextEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::QLNT.Form.frmWait), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.txtFolderName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoi
            // 
            this.lblLoi.Appearance.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoi.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblLoi.Location = new System.Drawing.Point(35, 51);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.Size = new System.Drawing.Size(0, 13);
            this.lblLoi.TabIndex = 30;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl3.Location = new System.Drawing.Point(15, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Chọn đường dẫn:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Location = new System.Drawing.Point(178, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(203, 26);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "PHỤC HỒI DỮ LIỆU";
            // 
            // btnDong
            // 
            this.btnDong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Appearance.Options.UseForeColor = true;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(283, 107);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(129, 27);
            this.btnDong.TabIndex = 26;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThucThi
            // 
            this.btnThucThi.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThucThi.Appearance.Options.UseForeColor = true;
            this.btnThucThi.Image = ((System.Drawing.Image)(resources.GetObject("btnThucThi.Image")));
            this.btnThucThi.Location = new System.Drawing.Point(119, 107);
            this.btnThucThi.Name = "btnThucThi";
            this.btnThucThi.Size = new System.Drawing.Size(139, 27);
            this.btnThucThi.TabIndex = 25;
            this.btnThucThi.Text = "Thực hiện";
            this.btnThucThi.Click += new System.EventHandler(this.btnThucThi_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnBrowse.Appearance.Options.UseForeColor = true;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(418, 73);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 27);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Duyệt";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Enabled = false;
            this.txtFolderName.Location = new System.Drawing.Point(119, 76);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtFolderName.Properties.Appearance.Options.UseForeColor = true;
            this.txtFolderName.Size = new System.Drawing.Size(293, 20);
            this.txtFolderName.TabIndex = 27;
            // 
            // frmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 148);
            this.Controls.Add(this.lblLoi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThucThi);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolderName);
            this.MaximizeBox = false;
            this.Name = "frmRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phục hồi dữ liệu";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.txtFolderName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblLoi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThucThi;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit txtFolderName;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;

    }
}