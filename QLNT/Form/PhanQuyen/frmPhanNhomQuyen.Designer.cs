namespace QLNT.Form.PhanQuyen
{
    partial class frmPhanNhomQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanNhomQuyen));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeListPhanQuyen = new DevExpress.XtraTreeList.TreeList();
            this.treelistDanhSachChucNang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gridQuyenSuDung = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTatCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTruyCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatDuLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapDuLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tatca = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuyenSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tatca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDongY);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl1.Location = new System.Drawing.Point(0, 337);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(732, 89);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDongY
            // 
            this.btnDongY.Image = ((System.Drawing.Image)(resources.GetObject("btnDongY.Image")));
            this.btnDongY.Location = new System.Drawing.Point(368, 12);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(174, 31);
            this.btnDongY.StyleController = this.layoutControl1;
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đóng";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(732, 89);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnDongY;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(356, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 35);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(50, 35);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(178, 69);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(356, 69);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(534, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(178, 69);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.splitContainerControl1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(732, 337);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 12);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeListPhanQuyen);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridQuyenSuDung);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(708, 313);
            this.splitContainerControl1.SplitterPosition = 321;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeListPhanQuyen
            // 
            this.treeListPhanQuyen.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treelistDanhSachChucNang});
            this.treeListPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListPhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.treeListPhanQuyen.Name = "treeListPhanQuyen";
            this.treeListPhanQuyen.Size = new System.Drawing.Size(321, 313);
            this.treeListPhanQuyen.TabIndex = 0;
            this.treeListPhanQuyen.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListPhanQuyen_FocusedNodeChanged);
            this.treeListPhanQuyen.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeListPhanQuyen_CustomDrawNodeCell);
            // 
            // treelistDanhSachChucNang
            // 
            this.treelistDanhSachChucNang.Caption = "Danh sách chức năng";
            this.treelistDanhSachChucNang.FieldName = "ChucNang";
            this.treelistDanhSachChucNang.Name = "treelistDanhSachChucNang";
            this.treelistDanhSachChucNang.Visible = true;
            this.treelistDanhSachChucNang.VisibleIndex = 0;
            // 
            // gridQuyenSuDung
            // 
            this.gridQuyenSuDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridQuyenSuDung.Location = new System.Drawing.Point(0, 0);
            this.gridQuyenSuDung.MainView = this.gridView2;
            this.gridQuyenSuDung.Name = "gridQuyenSuDung";
            this.gridQuyenSuDung.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tatca});
            this.gridQuyenSuDung.Size = new System.Drawing.Size(382, 313);
            this.gridQuyenSuDung.TabIndex = 1;
            this.gridQuyenSuDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTatCa,
            this.colThem,
            this.colXoa,
            this.colSua,
            this.colTruyCap,
            this.colInAn,
            this.colXuatDuLieu,
            this.colNhapDuLieu});
            this.gridView2.GridControl = this.gridQuyenSuDung;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            // 
            // colTatCa
            // 
            this.colTatCa.Caption = "Tất cả";
            this.colTatCa.FieldName = "TatCa";
            this.colTatCa.Name = "colTatCa";
            this.colTatCa.Visible = true;
            this.colTatCa.VisibleIndex = 0;
            // 
            // colThem
            // 
            this.colThem.Caption = "Thêm";
            this.colThem.FieldName = "Them";
            this.colThem.Name = "colThem";
            this.colThem.Visible = true;
            this.colThem.VisibleIndex = 1;
            this.colThem.Width = 49;
            // 
            // colXoa
            // 
            this.colXoa.Caption = "Xóa";
            this.colXoa.FieldName = "Xoa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 2;
            this.colXoa.Width = 48;
            // 
            // colSua
            // 
            this.colSua.Caption = "Sửa";
            this.colSua.FieldName = "Sua";
            this.colSua.Name = "colSua";
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 3;
            this.colSua.Width = 43;
            // 
            // colTruyCap
            // 
            this.colTruyCap.Caption = "Truy Cập";
            this.colTruyCap.FieldName = "TruyCap";
            this.colTruyCap.Name = "colTruyCap";
            this.colTruyCap.Visible = true;
            this.colTruyCap.VisibleIndex = 4;
            this.colTruyCap.Width = 71;
            // 
            // colInAn
            // 
            this.colInAn.Caption = "In";
            this.colInAn.FieldName = "InAn";
            this.colInAn.Name = "colInAn";
            this.colInAn.Visible = true;
            this.colInAn.VisibleIndex = 5;
            this.colInAn.Width = 56;
            // 
            // colXuatDuLieu
            // 
            this.colXuatDuLieu.Caption = "Xuất Dữ Liệu";
            this.colXuatDuLieu.FieldName = "XuatDuLieu";
            this.colXuatDuLieu.Name = "colXuatDuLieu";
            this.colXuatDuLieu.Visible = true;
            this.colXuatDuLieu.VisibleIndex = 6;
            this.colXuatDuLieu.Width = 77;
            // 
            // colNhapDuLieu
            // 
            this.colNhapDuLieu.Caption = "Nạp Dữ Liệu";
            this.colNhapDuLieu.FieldName = "NhapDuLieu";
            this.colNhapDuLieu.Name = "colNhapDuLieu";
            this.colNhapDuLieu.Visible = true;
            this.colNhapDuLieu.VisibleIndex = 7;
            this.colNhapDuLieu.Width = 94;
            // 
            // tatca
            // 
            this.tatca.AutoHeight = false;
            this.tatca.Caption = "Check";
            this.tatca.Name = "tatca";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(732, 337);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.splitContainerControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(712, 317);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmPhanNhomQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 426);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPhanNhomQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuyenSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tatca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeListPhanQuyen;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treelistDanhSachChucNang;
        private DevExpress.XtraGrid.GridControl gridQuyenSuDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTatCa;
        private DevExpress.XtraGrid.Columns.GridColumn colThem;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraGrid.Columns.GridColumn colTruyCap;
        private DevExpress.XtraGrid.Columns.GridColumn colInAn;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapDuLieu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit tatca;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;

    }
}