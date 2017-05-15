namespace QLNT.Form.Systems
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtPassWord = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.chkGhiNhoMK = new DevExpress.XtraEditors.CheckEdit();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGhiNhoMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(294, 74);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Properties.Appearance.BackColor = System.Drawing.Color.Ivory;
            this.txtTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTaiKhoan.Properties.Appearance.Options.UseBackColor = true;
            this.txtTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(214, 22);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtTaiKhoan_PreviewKeyDown);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(294, 106);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Properties.Appearance.BackColor = System.Drawing.Color.Ivory;
            this.txtPassWord.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassWord.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassWord.Properties.Appearance.Options.UseFont = true;
            this.txtPassWord.Properties.UseSystemPasswordChar = true;
            this.txtPassWord.Size = new System.Drawing.Size(214, 22);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPassWord_PreviewKeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(213, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(213, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(390, 161);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 25);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(294, 161);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(90, 25);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chkGhiNhoMK
            // 
            this.chkGhiNhoMK.EditValue = true;
            this.chkGhiNhoMK.Location = new System.Drawing.Point(292, 136);
            this.chkGhiNhoMK.Name = "chkGhiNhoMK";
            this.chkGhiNhoMK.Properties.Caption = "Ghi nhớ tài khoản";
            this.chkGhiNhoMK.Size = new System.Drawing.Size(120, 19);
            this.chkGhiNhoMK.TabIndex = 9;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "Thiết Lập";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(213, 167);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.hyperLinkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.hyperLinkEdit1.Properties.Appearance.Options.UseFont = true;
            this.hyperLinkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.hyperLinkEdit1.Size = new System.Drawing.Size(70, 18);
            this.hyperLinkEdit1.TabIndex = 10;
            this.hyperLinkEdit1.Click += new System.EventHandler(this.hyperLinkEdit1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::QLNT.Properties.Resources.Login;
            this.ClientSize = new System.Drawing.Size(528, 238);
            this.Controls.Add(this.hyperLinkEdit1);
            this.Controls.Add(this.chkGhiNhoMK);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtTaiKhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGhiNhoMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtPassWord;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.CheckEdit chkGhiNhoMK;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
    }
}