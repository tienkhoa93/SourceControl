namespace QLNT.Form.Khu
{
    partial class frmKhu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhu));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTenKhu = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhu = new DevExpress.XtraEditors.TextEdit();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLuuDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuThem = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.errorProviderMa = new System.Windows.Forms.ErrorProvider();
            this.errorProviderTen = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(413, 142);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin bắt buộc";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTenKhu);
            this.layoutControl1.Controls.Add(this.txtMaKhu);
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(409, 119);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTenKhu
            // 
            this.txtTenKhu.Location = new System.Drawing.Point(57, 36);
            this.txtTenKhu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenKhu.Name = "txtTenKhu";
            this.txtTenKhu.Size = new System.Drawing.Size(340, 20);
            this.txtTenKhu.StyleController = this.layoutControl1;
            this.txtTenKhu.TabIndex = 5;
            this.txtTenKhu.TextChanged += new System.EventHandler(this.txtTenKhu_TextChanged);
            // 
            // txtMaKhu
            // 
            this.txtMaKhu.Location = new System.Drawing.Point(57, 12);
            this.txtMaKhu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaKhu.Name = "txtMaKhu";
            this.txtMaKhu.Size = new System.Drawing.Size(340, 20);
            this.txtMaKhu.StyleController = this.layoutControl1;
            this.txtMaKhu.TabIndex = 4;
            this.txtMaKhu.TextChanged += new System.EventHandler(this.txtKhu_TextChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(57, 60);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(340, 47);
            this.txtGhiChu.StyleController = this.layoutControl1;
            this.txtGhiChu.TabIndex = 6;
            this.txtGhiChu.UseOptimizedRendering = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(409, 119);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaKhu;
            this.layoutControlItem1.CustomizationFormText = "Mã Khu :";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(389, 24);
            this.layoutControlItem1.Text = "Mã khu:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTenKhu;
            this.layoutControlItem2.CustomizationFormText = "Tên Khu :";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(389, 24);
            this.layoutControlItem2.Text = "Tên khu:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtGhiChu;
            this.layoutControlItem3.CustomizationFormText = "Ghi Chú :";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(389, 51);
            this.layoutControlItem3.Text = "Ghi chú:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnLuuDong);
            this.layoutControl2.Controls.Add(this.btnHuy);
            this.layoutControl2.Controls.Add(this.btnLuuThem);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl2.Location = new System.Drawing.Point(0, 131);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(413, 54);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnLuuDong
            // 
            this.btnLuuDong.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDong.Image")));
            this.btnLuuDong.Location = new System.Drawing.Point(105, 12);
            this.btnLuuDong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLuuDong.Name = "btnLuuDong";
            this.btnLuuDong.Size = new System.Drawing.Size(96, 26);
            this.btnLuuDong.StyleController = this.layoutControl2;
            this.btnLuuDong.TabIndex = 6;
            this.btnLuuDong.Text = "&Lưu và Đóng";
            this.btnLuuDong.Click += new System.EventHandler(this.btnLuuDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(305, 12);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 26);
            this.btnHuy.StyleController = this.layoutControl2;
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuThem
            // 
            this.btnLuuThem.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuThem.Image")));
            this.btnLuuThem.Location = new System.Drawing.Point(205, 12);
            this.btnLuuThem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLuuThem.Name = "btnLuuThem";
            this.btnLuuThem.Size = new System.Drawing.Size(96, 26);
            this.btnLuuThem.StyleController = this.layoutControl2;
            this.btnLuuThem.TabIndex = 4;
            this.btnLuuThem.Text = "Lưu và &Thêm";
            this.btnLuuThem.Click += new System.EventHandler(this.btnLuuThem_Click);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(413, 54);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnLuuThem;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(193, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(100, 30);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(100, 30);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(100, 34);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnHuy;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(293, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(100, 30);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(100, 30);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(100, 34);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnLuuDong;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(93, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(100, 30);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(100, 30);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(100, 34);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(93, 34);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // errorProviderMa
            // 
            this.errorProviderMa.ContainerControl = this;
            // 
            // errorProviderTen
            // 
            this.errorProviderTen.ContainerControl = this;
            // 
            // frmKhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 185);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtTenKhu;
        private DevExpress.XtraEditors.TextEdit txtMaKhu;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton btnLuuDong;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuuThem;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.ErrorProvider errorProviderMa;
        private System.Windows.Forms.ErrorProvider errorProviderTen;

    }
}