namespace QLNT.Form.DienNuoc
{
    partial class frmDienNuocUcl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDienNuocUcl));
            this.gridDienNuoc = new DevExpress.XtraGrid.GridControl();
            this.gridViewDienNuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPhong = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoDienCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienMoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoNuocCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoNuocMoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTienDien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTienNuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridKhu = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLuuLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ssWait = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::QLNT.Form.frmWait), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gridDienNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDienNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDienNuoc
            // 
            this.gridDienNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDienNuoc.Location = new System.Drawing.Point(0, 31);
            this.gridDienNuoc.MainView = this.gridViewDienNuoc;
            this.gridDienNuoc.Name = "gridDienNuoc";
            this.gridDienNuoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.gridKhu,
            this.gridPhong});
            this.gridDienNuoc.Size = new System.Drawing.Size(968, 433);
            this.gridDienNuoc.TabIndex = 5;
            this.gridDienNuoc.UseEmbeddedNavigator = true;
            this.gridDienNuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDienNuoc});
            // 
            // gridViewDienNuoc
            // 
            this.gridViewDienNuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThang,
            this.colNam,
            this.gridColumn17,
            this.colSoDienCu,
            this.colSoDienMoi,
            this.colSoNuocCu,
            this.colSoNuocMoi,
            this.colGiaTienDien,
            this.colGiaTienNuoc});
            this.gridViewDienNuoc.GridControl = this.gridDienNuoc;
            this.gridViewDienNuoc.Name = "gridViewDienNuoc";
            this.gridViewDienNuoc.OptionsSelection.MultiSelect = true;
            this.gridViewDienNuoc.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridViewDienNuoc.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDienNuoc.OptionsView.ShowFooter = true;
            this.gridViewDienNuoc.OptionsView.ShowGroupPanel = false;
            this.gridViewDienNuoc.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDienNuoc_CellValueChanged);
            // 
            // colThang
            // 
            this.colThang.Caption = "Tháng";
            this.colThang.ColumnEdit = this.repositoryItemComboBox1;
            this.colThang.FieldName = "Thang";
            this.colThang.Name = "colThang";
            this.colThang.Visible = true;
            this.colThang.VisibleIndex = 0;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colNam
            // 
            this.colNam.Caption = "Năm";
            this.colNam.ColumnEdit = this.repositoryItemComboBox2;
            this.colNam.FieldName = "Nam";
            this.colNam.Name = "colNam";
            this.colNam.Visible = true;
            this.colNam.VisibleIndex = 1;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "0",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Phòng";
            this.gridColumn17.ColumnEdit = this.gridPhong;
            this.gridColumn17.FieldName = "MaPhong";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.ReadOnly = true;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 2;
            // 
            // gridPhong
            // 
            this.gridPhong.AutoHeight = false;
            this.gridPhong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridPhong.DisplayMember = "TenPhong";
            this.gridPhong.Name = "gridPhong";
            this.gridPhong.NullText = "Trống";
            this.gridPhong.ValueMember = "MaPhong";
            this.gridPhong.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSoDienCu
            // 
            this.colSoDienCu.Caption = "Chỉ số điện cũ";
            this.colSoDienCu.FieldName = "SoDienCu";
            this.colSoDienCu.Name = "colSoDienCu";
            this.colSoDienCu.Visible = true;
            this.colSoDienCu.VisibleIndex = 3;
            this.colSoDienCu.Width = 114;
            // 
            // colSoDienMoi
            // 
            this.colSoDienMoi.Caption = "Chỉ số điện mới";
            this.colSoDienMoi.FieldName = "SoDienMoi";
            this.colSoDienMoi.Name = "colSoDienMoi";
            this.colSoDienMoi.Visible = true;
            this.colSoDienMoi.VisibleIndex = 4;
            this.colSoDienMoi.Width = 90;
            // 
            // colSoNuocCu
            // 
            this.colSoNuocCu.Caption = "Chỉ số nước cũ";
            this.colSoNuocCu.FieldName = "SoNuocCu";
            this.colSoNuocCu.Name = "colSoNuocCu";
            this.colSoNuocCu.Visible = true;
            this.colSoNuocCu.VisibleIndex = 5;
            this.colSoNuocCu.Width = 98;
            // 
            // colSoNuocMoi
            // 
            this.colSoNuocMoi.Caption = "Chỉ số nước mới";
            this.colSoNuocMoi.FieldName = "SoNuocMoi";
            this.colSoNuocMoi.Name = "colSoNuocMoi";
            this.colSoNuocMoi.Visible = true;
            this.colSoNuocMoi.VisibleIndex = 6;
            this.colSoNuocMoi.Width = 98;
            // 
            // colGiaTienDien
            // 
            this.colGiaTienDien.Caption = "Giá tiền điện";
            this.colGiaTienDien.FieldName = "GiaTienDien";
            this.colGiaTienDien.Name = "colGiaTienDien";
            this.colGiaTienDien.Visible = true;
            this.colGiaTienDien.VisibleIndex = 7;
            this.colGiaTienDien.Width = 180;
            // 
            // colGiaTienNuoc
            // 
            this.colGiaTienNuoc.Caption = "Giá tiền nước";
            this.colGiaTienNuoc.FieldName = "GiaTienNuoc";
            this.colGiaTienNuoc.Name = "colGiaTienNuoc";
            this.colGiaTienNuoc.Visible = true;
            this.colGiaTienNuoc.VisibleIndex = 8;
            this.colGiaTienNuoc.Width = 180;
            // 
            // gridKhu
            // 
            this.gridKhu.AutoHeight = false;
            this.gridKhu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridKhu.Name = "gridKhu";
            this.gridKhu.NullText = "Trống";
            this.gridKhu.ReadOnly = true;
            this.gridKhu.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLuuLai,
            this.btnXoa});
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 5;
            this.bar1.Text = "Tools";
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnLuuLai.Caption = "Lưu lại";
            this.btnLuuLai.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLuuLai.Glyph")));
            this.btnLuuLai.Id = 0;
            this.btnLuuLai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLuuLai.LargeGlyph")));
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuLai_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 2;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(968, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 464);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(968, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 433);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(968, 31);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 433);
            // 
            // frmDienNuocUcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 464);
            this.Controls.Add(this.gridDienNuoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDienNuocUcl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập danh sách tiền điện- nước";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridDienNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDienNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridDienNuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDienNuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colThang;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colNam;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienCu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienMoi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoNuocCu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoNuocMoi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTienDien;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTienNuoc;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnLuuLai;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gridPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gridKhu;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssWait;
    }
}