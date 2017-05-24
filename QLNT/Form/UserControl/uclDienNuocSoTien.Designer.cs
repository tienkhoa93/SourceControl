namespace QLNT.Form.UserControl
{
    partial class uclDienNuocSoTien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uclDienNuocSoTien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grcDienNuoc = new DevExpress.XtraGrid.GridControl();
            this.gvDienNuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboThang = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboNam = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPhong = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTienDien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.calTienDien = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colTienNuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.calTienNuoc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDienNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDienNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calTienDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calTienNuoc)).BeginInit();
            this.SuspendLayout();
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
            this.btnThem,
            this.btnXoa,
            this.btnNapLai,
            this.btnIn,
            this.btnNhap,
            this.btnXuat});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNapLai, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNhap, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 5;
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnThem.Caption = "Lưu lại";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
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
            // btnNapLai
            // 
            this.btnNapLai.Caption = "Nạp lại";
            this.btnNapLai.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNapLai.Glyph")));
            this.btnNapLai.Id = 3;
            this.btnNapLai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNapLai.LargeGlyph")));
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNapLai_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIn.Glyph")));
            this.btnIn.Id = 5;
            this.btnIn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnIn.LargeGlyph")));
            this.btnIn.Name = "btnIn";
            // 
            // btnNhap
            // 
            this.btnNhap.Caption = "Nhập";
            this.btnNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhap.Glyph")));
            this.btnNhap.Id = 6;
            this.btnNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhap.LargeGlyph")));
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhap_ItemClick);
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "Xuất";
            this.btnXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.Glyph")));
            this.btnXuat.Id = 7;
            this.btnXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.LargeGlyph")));
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(528, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 381);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(528, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 350);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(528, 31);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 350);
            // 
            // grcDienNuoc
            // 
            this.grcDienNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDienNuoc.Location = new System.Drawing.Point(0, 31);
            this.grcDienNuoc.MainView = this.gvDienNuoc;
            this.grcDienNuoc.MenuManager = this.barManager1;
            this.grcDienNuoc.Name = "grcDienNuoc";
            this.grcDienNuoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboThang,
            this.cboNam,
            this.calTienDien,
            this.calTienNuoc,
            this.gridPhong});
            this.grcDienNuoc.Size = new System.Drawing.Size(528, 350);
            this.grcDienNuoc.TabIndex = 4;
            this.grcDienNuoc.UseEmbeddedNavigator = true;
            this.grcDienNuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDienNuoc});
            // 
            // gvDienNuoc
            // 
            this.gvDienNuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colTienDien,
            this.colTienNuoc,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn4});
            this.gvDienNuoc.GridControl = this.grcDienNuoc;
            this.gvDienNuoc.Name = "gvDienNuoc";
            this.gvDienNuoc.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDienNuoc.OptionsNavigation.AutoFocusNewRow = true;
            this.gvDienNuoc.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvDienNuoc.OptionsSelection.MultiSelect = true;
            this.gvDienNuoc.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDienNuoc.OptionsView.ShowAutoFilterRow = true;
            this.gvDienNuoc.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.gvDienNuoc.OptionsView.ShowGroupPanel = false;
            this.gvDienNuoc.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDienNuoc_CellValueChanged);
            this.gvDienNuoc.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDienNuoc_CellValueChanging);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tháng";
            this.gridColumn1.ColumnEdit = this.cboThang;
            this.gridColumn1.FieldName = "Thang";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 63;
            // 
            // cboThang
            // 
            this.cboThang.AutoHeight = false;
            this.cboThang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboThang.Items.AddRange(new object[] {
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
            this.cboThang.Name = "cboThang";
            this.cboThang.NullText = "0";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Năm";
            this.gridColumn2.ColumnEdit = this.cboNam;
            this.gridColumn2.FieldName = "Nam";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 63;
            // 
            // cboNam
            // 
            this.cboNam.AutoHeight = false;
            this.cboNam.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNam.Items.AddRange(new object[] {
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
            this.cboNam.Name = "cboNam";
            this.cboNam.NullText = "0";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Phòng";
            this.gridColumn3.ColumnEdit = this.gridPhong;
            this.gridColumn3.FieldName = "MaPhong";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 63;
            // 
            // gridPhong
            // 
            this.gridPhong.AutoHeight = false;
            this.gridPhong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridPhong.Name = "gridPhong";
            this.gridPhong.NullText = "[Chọn phòng]";
            this.gridPhong.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colTienDien
            // 
            this.colTienDien.Caption = "Tiền điện";
            this.colTienDien.ColumnEdit = this.calTienDien;
            this.colTienDien.FieldName = "TienDien";
            this.colTienDien.Name = "colTienDien";
            this.colTienDien.Visible = true;
            this.colTienDien.VisibleIndex = 3;
            this.colTienDien.Width = 63;
            // 
            // calTienDien
            // 
            this.calTienDien.AutoHeight = false;
            this.calTienDien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calTienDien.Name = "calTienDien";
            this.calTienDien.NullText = "0";
            // 
            // colTienNuoc
            // 
            this.colTienNuoc.Caption = "Tiền nước";
            this.colTienNuoc.ColumnEdit = this.calTienNuoc;
            this.colTienNuoc.FieldName = "TienNuoc";
            this.colTienNuoc.Name = "colTienNuoc";
            this.colTienNuoc.Visible = true;
            this.colTienNuoc.VisibleIndex = 4;
            this.colTienNuoc.Width = 63;
            // 
            // calTienNuoc
            // 
            this.calTienNuoc.AutoHeight = false;
            this.calTienNuoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calTienNuoc.Name = "calTienNuoc";
            this.calTienNuoc.NullText = "0";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tổng Tiền";
            this.gridColumn6.FieldName = "TongTien";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 63;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đã thu";
            this.gridColumn7.FieldName = "DaThu";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 63;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "Id";
            this.gridColumn4.MinWidth = 10;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowShowHide = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 20;
            // 
            // uclDienNuocSoTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcDienNuoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uclDienNuocSoTien";
            this.Size = new System.Drawing.Size(528, 381);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDienNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDienNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calTienDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calTienNuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnNapLai;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnNhap;
        private DevExpress.XtraBars.BarButtonItem btnXuat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grcDienNuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDienNuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cboThang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cboNam;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colTienDien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit calTienDien;
        private DevExpress.XtraGrid.Columns.GridColumn colTienNuoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit calTienNuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gridPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
