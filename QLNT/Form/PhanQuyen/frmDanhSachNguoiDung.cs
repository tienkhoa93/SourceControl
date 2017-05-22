using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Common;
using QLNT.Business;

namespace QLNT.Form.PhanQuyen
{
    public partial class frmDanhSachNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        private int curr;
        private SysNguoiDung_Bus ndb = new SysNguoiDung_Bus();
        public frmDanhSachNguoiDung()
        {
            InitializeComponent();
            gridDanhSachNguoiDUng.DataSource = ndb.ListNguoiDung();
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            var ndb = new SysNguoiDung_Bus();
            var qsdb = new SysQuyenSuDung_Bus();
            var listuser = ndb.SelectNguoiDung(UserInfo.Account);
            var manhom = string.Empty;
            foreach (var a in listuser)
            {
                manhom = a.MaNhom;
            }
            var listquyen = qsdb.SelectQuyenSuDung(manhom, "12");
            foreach (var b in listquyen)
            {
                if (b.Xoa == false)
                {
                    btnXoa.Enabled = false;
                }
                if (b.Sua == false)
                {
                    barButtonItem1.Enabled = false;
                }
                if (b.Them == false)
                {
                    btnThem.Enabled = false;
                }
            }
        }
        public void RefeshG(object ob)
        {
            gridDanhSachNguoiDUng.DataSource = ob;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new frmThemNguoiDung(ChucNang.Them, null);
            Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            f.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            curr = gridView1.GetDataSourceRowIndex(gridView1.FocusedRowHandle);
            if (gridView1.RowCount < 0)
            {
                XtraMessageBox.Show("Chưa có dữ liệu để sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var sv = (LinQToSQL.SysUser)gridView1.GetRow(gridView1.FocusedRowHandle);
                var f = new frmThemNguoiDung(ChucNang.Sua, sv);
                Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
                f.ShowDialog();
            }
            gridView1.MoveBy(curr);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            curr = gridView1.GetDataSourceRowIndex(gridView1.FocusedRowHandle);
            if (gridView1.RowCount < 0)
            {
                XtraMessageBox.Show("Chưa có dữ liệu để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var x = XtraMessageBox.Show("Bạn có muốn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    for (var i = 0; i < gridView1.RowCount; i++)
                    {
                        if (gridView1.IsRowSelected(i) == true)
                        {
                            if (gridView1.GetRowCellValue(i, "TaiKhoan").ToString().ToUpper() == "ADMIN")
                            {
                                MessageBox.Show("Không thể xóa tài khoản admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            var ID = gridView1.GetRowCellValue(i, "ID").ToString();
                            ndb.DeleteNguoiDung(ID);
                        }
                    }
                    gridView1.DeleteSelectedRows();
                }
            }

            gridDanhSachNguoiDUng.DataSource = ndb.ListNguoiDung();
            gridView1.MoveBy(curr - 1);
        }

        private void frmDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
        }
    }
}
