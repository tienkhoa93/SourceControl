namespace QLNT.Form.UserControl
{
    partial class uclQuanLyVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uclQuanLyVatTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridQuanLiVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridViewQuaLiVatTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glkVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.glkVatTuO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glkPhong = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.glkPhongO = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuanLiVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuaLiVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkVatTuO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkPhongO)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnNapLai,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNapLai, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = global::QLNT.Properties.Resources.delete;
            this.btnXoa.Id = 2;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnNapLai
            // 
            this.btnNapLai.Caption = "Nạp lại";
            this.btnNapLai.Id = 3;
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNapLai_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In danh sách";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(713, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 367);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(713, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 336);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(713, 31);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 336);
            // 
            // gridQuanLiVatTu
            // 
            this.gridQuanLiVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridQuanLiVatTu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.gridQuanLiVatTu.Location = new System.Drawing.Point(0, 31);
            this.gridQuanLiVatTu.MainView = this.gridViewQuaLiVatTu;
            this.gridQuanLiVatTu.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.gridQuanLiVatTu.MenuManager = this.barManager1;
            this.gridQuanLiVatTu.Name = "gridQuanLiVatTu";
            this.gridQuanLiVatTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.glkVatTu,
            this.glkPhong,
            this.repositoryItemCalcEdit1,
            this.repositoryItemDateEdit1});
            this.gridQuanLiVatTu.Size = new System.Drawing.Size(713, 336);
            this.gridQuanLiVatTu.TabIndex = 4;
            this.gridQuanLiVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQuaLiVatTu});
            this.gridQuanLiVatTu.Load += new System.EventHandler(this.gridQuanLiVatTu_Load);
            // 
            // gridViewQuaLiVatTu
            // 
            this.gridViewQuaLiVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn7});
            this.gridViewQuaLiVatTu.GridControl = this.gridQuanLiVatTu;
            this.gridViewQuaLiVatTu.GroupPanelText = "Kéo cột vào đây để gom nhóm giữ liệu";
            this.gridViewQuaLiVatTu.IndicatorWidth = 75;
            this.gridViewQuaLiVatTu.Name = "gridViewQuaLiVatTu";
            this.gridViewQuaLiVatTu.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewQuaLiVatTu.OptionsBehavior.ReadOnly = true;
            this.gridViewQuaLiVatTu.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridViewQuaLiVatTu.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridViewQuaLiVatTu.OptionsFind.AlwaysVisible = true;
            this.gridViewQuaLiVatTu.OptionsFind.SearchInPreview = true;
            this.gridViewQuaLiVatTu.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewQuaLiVatTu.OptionsPrint.AutoResetPrintDocument = false;
            this.gridViewQuaLiVatTu.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewQuaLiVatTu.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewQuaLiVatTu.OptionsPrint.ExpandAllDetails = true;
            this.gridViewQuaLiVatTu.OptionsPrint.PrintPreview = true;
            this.gridViewQuaLiVatTu.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridViewQuaLiVatTu.OptionsSelection.MultiSelect = true;
            this.gridViewQuaLiVatTu.OptionsView.ShowAutoFilterRow = true;
            this.gridViewQuaLiVatTu.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewQuaLiVatTu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuaLiVatTu_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Phòng";
            this.gridColumn1.FieldName = "TenPhong";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Vật tư";
            this.gridColumn2.FieldName = "TenVatTu";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số lượng";
            this.gridColumn4.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gridColumn4.FieldName = "SoLuong";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày Sửa / Thay";
            this.gridColumn3.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn3.FieldName = "NgaySuaChua";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Sửa chữa";
            this.gridColumn6.FieldName = "SuaChua";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Thay thế";
            this.gridColumn5.FieldName = "ThayThe";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ghi chú";
            this.gridColumn7.FieldName = "GhiChu";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // glkVatTu
            // 
            this.glkVatTu.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.glkVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glkVatTu.Name = "glkVatTu";
            this.glkVatTu.View = this.glkVatTuO;
            // 
            // glkVatTuO
            // 
            this.glkVatTuO.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glkVatTuO.Name = "glkVatTuO";
            this.glkVatTuO.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glkVatTuO.OptionsView.ShowGroupPanel = false;
            // 
            // glkPhong
            // 
            this.glkPhong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.glkPhong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glkPhong.Name = "glkPhong";
            this.glkPhong.View = this.glkPhongO;
            // 
            // glkPhongO
            // 
            this.glkPhongO.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glkPhongO.Name = "glkPhongO";
            this.glkPhongO.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glkPhongO.OptionsView.ShowGroupPanel = false;
            // 
            // uclQuanLyVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridQuanLiVatTu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "uclQuanLyVatTu";
            this.Size = new System.Drawing.Size(713, 390);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuanLiVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuaLiVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkVatTuO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkPhongO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnNapLai;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridQuanLiVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewQuaLiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit glkPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView glkPhongO;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit glkVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView glkVatTuO;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}
