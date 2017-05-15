using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Common;
using System.Diagnostics;
using QLNT.Report;
using DevExpress.XtraReports.UI;
using QLNT.Business;
using QLNT.LinQToSQL;

namespace QLNT.Form.UserControl
{
    public partial class uclThungRac : DevExpress.XtraEditors.XtraUserControl
    {
        Business.KhachTro_Bus ktb = new Business.KhachTro_Bus();
        Business.Khu_Bus kb = new Business.Khu_Bus();
        Business.Phong_Bus pb = new Business.Phong_Bus();
        Business.TinhTrangBus ttb = new Business.TinhTrangBus();
        int s;
        public uclThungRac()
        {
            InitializeComponent();
            gridDSKhachTro.DataSource = ktb.ListDanhSachKhachTroDaXoa();
            colMa.Fixed = FixedStyle.Left;
            colHoLot.Fixed = FixedStyle.Left;
            colTen.Fixed = FixedStyle.Left;
            colNgaySinh.Fixed = FixedStyle.Left;
            colGioiTinh.Fixed = FixedStyle.Left;
            LoadDaTa();
            rpKhu.DataSource = kb.GetAllKhu();
            rpPhong.DataSource = pb.ListPhong();
            rpTrangThai.DataSource = ttb.ListTinhTrang();
            
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            SysNguoiDung_Bus ndb = new SysNguoiDung_Bus();
            SysQuyenSuDung_Bus qsdb = new SysQuyenSuDung_Bus();
            List<SysUser> listuser = ndb.SelectNguoiDung(UserInfo.Account);
            string manhom = "";
            foreach (var a in listuser)
            {
                manhom = a.MaNhom;
            }
            List<SysQuyenSuDung> listquyen = qsdb.SelectQuyenSuDung(manhom, "14");
            foreach (var b in listquyen)
            {
                if (b.Xoa == false)
                    btnXoa.Enabled = false;
                if (b.Sua == false)
                    btnSua.Enabled = false;
                if (b.XuatDuLieu == false)
                {
                    btnXuat.Enabled = false;
                }              
               
            }

        }

        #region Load Data
        public void LoadDaTa()
        {

            rpKhu.DataSource = kb.GetAllKhu();
            rpKhu.DisplayMember = "TenKhu";
            rpKhu.ValueMember = "MaKhu";


            rpPhong.DataSource = pb.ListPhong();
            rpPhong.DisplayMember = "TenPhong";
            rpPhong.ValueMember = "MaPhong";


            rpTrangThai.DataSource = ttb.ListTinhTrang();
            rpTrangThai.DisplayMember = "TenTrangThai";
            rpTrangThai.ValueMember = "MaTrangThai";
        }
   

        void RefeshG(object ob)
        {
            gridDSKhachTro.DataSource = ob;
        }

        private void gridDSKhachTro_Load(object sender, EventArgs e)
        {
            gridDSKhachTro.DataSource = ktb.ListDanhSachKhachTroDaXoa();
        } 
        #endregion
        #region Event Button
        private void gridViewDSKhachTro_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            KhachTro.frmDSKhachTro kt = new KhachTro.frmDSKhachTro(ChucNang.Them, null);
            Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            kt.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            s = gridViewDSKhachTro.GetDataSourceRowIndex(gridViewDSKhachTro.FocusedRowHandle);
            try
            {
                if (gridViewDSKhachTro.IsRowSelected(gridViewDSKhachTro.FocusedRowHandle) == false)
                {
                    XtraMessageBox.Show("Không có dữ liệu để phục hồi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult x = XtraMessageBox.Show("Bạn có muốn phục hồi không ?", "Phục hồi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (x == DialogResult.Yes)
                    {
                        for (int i = 0; i < gridViewDSKhachTro.RowCount; i++)
                        {
                            if (gridViewDSKhachTro.IsRowSelected(i) == true)
                            {
                                string ID = gridViewDSKhachTro.GetRowCellValue(i, "MaKhachTro").ToString();
                                ktb.UndoKhachTro(ID);
                            }
                        }
                        gridViewDSKhachTro.DeleteSelectedRows();
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("Không có dữ liệu để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gridViewDSKhachTro.MoveBy(s - 1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            s = gridViewDSKhachTro.GetDataSourceRowIndex(gridViewDSKhachTro.FocusedRowHandle);
            try
            {
                if (gridViewDSKhachTro.IsRowSelected(gridViewDSKhachTro.FocusedRowHandle) == false)
                {
                    XtraMessageBox.Show("Không có dữ liệu để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult x = XtraMessageBox.Show("Bạn có muốn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (x == DialogResult.Yes)
                    {
                        for (int i = 0; i < gridViewDSKhachTro.RowCount; i++)
                        {
                            if (gridViewDSKhachTro.IsRowSelected(i) == true)
                            {
                                string ID = gridViewDSKhachTro.GetRowCellValue(i, "MaKhachTro").ToString();
                                ktb.DeleteKhachTroLuon(ID);
                            }
                        }
                        gridViewDSKhachTro.DeleteSelectedRows();
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("Không có dữ liệu để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gridViewDSKhachTro.MoveBy(s - 1);
            this.Cursor = System.Windows.Forms.Cursors.Default;

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            gridDSKhachTro.DataSource = ktb.ListDanhSachKhachTroDaXoa();
            this.Cursor = Cursors.Default;
        }

        private void gridViewDSKhachTro_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                s = gridViewDSKhachTro.GetDataSourceRowIndex(gridViewDSKhachTro.FocusedRowHandle);
                LinQToSQL.KhachTro item = (LinQToSQL.KhachTro)gridViewDSKhachTro.GetRow(gridViewDSKhachTro.FocusedRowHandle);
                KhachTro.frmDSKhachTro kt = new KhachTro.frmDSKhachTro(ChucNang.Sua, item);
                Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
                kt.ShowDialog();
                gridViewDSKhachTro.MoveBy(s);
            }
            catch { XtraMessageBox.Show("Không có dữ liệu để sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            this.Cursor = Cursors.Default;
        } 
        

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (gridViewDSKhachTro.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để xuất file !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DevExpress.XtraGrid.Views.Grid.GridView grid = gridDSKhachTro.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (grid != null)
            {
                SaveFileDialog saveExcel = new SaveFileDialog();
                saveExcel.Filter = "Excel Workbook|*.xlsx|Excel Macro-Enabled Workbook|*.xlsm|Excel 97-2003 Workbook|*.xls";
                saveExcel.Title = "Save an Excel File";
                saveExcel.InitialDirectory = @"C:\";
                if (saveExcel.ShowDialog() == DialogResult.OK)
                {
                    grid.ExportToXlsx(saveExcel.FileName);
                    XtraMessageBox.Show("Export File thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (XtraMessageBox.Show("Bạn có muốn xem file ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Process exportXlsx = new Process();
                        exportXlsx.StartInfo.FileName = "EXCEL.exe";
                        exportXlsx.StartInfo.Arguments = saveExcel.FileName;
                        exportXlsx.Start();
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }
        #endregion

      

        private void btnDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var dt = ktb.ListDanhSachKhachTro();
            DanhSachKhachTro rp = new DanhSachKhachTro(dt);
            rp.DataSource = dt;
            rp.ShowPreview();
            this.Cursor = Cursors.Default;
        }

        private void btnHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<QLNT.LinQToSQL.KhachTro> list = new List<QLNT.LinQToSQL.KhachTro>();
            try
            {
                for (int i = 0; i < gridViewDSKhachTro.RowCount; i++)
                {
                    if (gridViewDSKhachTro.IsRowSelected(i) == true)
                    {
                        QLNT.LinQToSQL.KhachTro sv = (QLNT.LinQToSQL.KhachTro)ktb.SelectTheoMaKhachTro(gridViewDSKhachTro.GetRowCellValue(i, "MaKhachTro").ToString());
                        list.Add(sv);
                    }
                }
            }
            catch { }

            HopDong rp = new Report.HopDong(list);
            rp.DataSource = list;
            rp.ShowPreview();
        }

    }
}
