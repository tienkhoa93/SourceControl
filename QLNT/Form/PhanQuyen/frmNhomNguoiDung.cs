using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNT.LinQToSQL;
using QLNT.Business;
using Common;
namespace QLNT.Form.PhanQuyen
{
    public partial class frmNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        int curr;
        SySNhomQuyen_Bus nqb = new SySNhomQuyen_Bus();
        SysNguoiDung_Bus ndb = new SysNguoiDung_Bus();
        SysQuyenSuDung_Bus qsdb = new SysQuyenSuDung_Bus();
        string manhom;
        public frmNhomNguoiDung()
        {
            InitializeComponent();
            gridNhomNguoiDung.DataSource = nqb.ListNhomQuyen();
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
            List<SysQuyenSuDung> listquyen = qsdb.SelectQuyenSuDung(manhom, "13");
            foreach (var b in listquyen)
            {
                if (b.Xoa == false)
                    btnXoa.Enabled = false;
                if (b.Sua == false)
                    btnSua.Enabled = false;
                if (b.Them == false)
                    btnThem.Enabled = false;
            }

        }
        private void Refesh(object ob)
        {
            gridNhomNguoiDung.DataSource = ob;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemNhomQuyen f = new frmThemNhomQuyen(ChucNang.Them, null);
            Delegates.Regrib = new Delegates.RefeshGrid(Refesh);
            f.ShowDialog();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            curr = gridView1.GetDataSourceRowIndex(gridView1.FocusedRowHandle);
            if (gridView1.RowCount < 0)
            {
                XtraMessageBox.Show("Chưa có dữ liệu để sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LinQToSQL.SysNhomQuyen sv = (LinQToSQL.SysNhomQuyen)gridView1.GetRow(gridView1.FocusedRowHandle);
                frmThemNhomQuyen f = new frmThemNhomQuyen(ChucNang.Sua, sv);
                Delegates.Regrib = new Delegates.RefeshGrid(Refesh);
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
                DialogResult x = XtraMessageBox.Show("Bạn có muốn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        if (gridView1.IsRowSelected(i) == true)
                        {
                            string ID = gridView1.GetRowCellValue(i, "MaNhom").ToString();
                            if (ID.ToUpper() == "NQ01")
                            {
                                MessageBox.Show("Không thể nhóm quyền hệ thông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            nqb.DeleteNhomQuyen(ID);
                            qsdb.DeleteQuyenSuDung(ID);

                        }
                    }
                    gridView1.DeleteSelectedRows();
                }
            }

            gridNhomNguoiDung.DataSource = nqb.ListNhomQuyen();
            gridView1.MoveBy(curr - 1);
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SysNhomQuyen item=(SysNhomQuyen)gridView1.GetRow(gridView1.FocusedRowHandle);
            if (item.MaNhom.ToUpper() == "NQ01")
            {
                MessageBox.Show("Không thể phân quyền nhóm quyền hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmPhanNhomQuyen frm = new frmPhanNhomQuyen( manhom);
            frm.ShowDialog();
        }
        private void frmNhomNguoiDung_Shown(object sender, EventArgs e)
        {
            SysNhomQuyen item = (SysNhomQuyen)gridView1.GetRow(gridView1.FocusedRowHandle);
            manhom = item.MaNhom;

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                SysNhomQuyen nq = (SysNhomQuyen)gridView1.GetRow(gridView1.FocusedRowHandle);
                manhom = nq.MaNhom;
                gridNguoiDung.DataSource = ndb.GetNguoiDung_MaNhom(nq.MaNhom);
            }
            catch
            {

            }
        }

        private void frmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.Editable = false;
        }

    }
}