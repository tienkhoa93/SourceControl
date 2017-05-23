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
using Common;
using QLNT.Business;
using QLNT.LinQToSQL;

namespace QLNT.Form.UserControl
{
    public partial class uclKhu : DevExpress.XtraEditors.XtraUserControl
    {
        Business.Khu_Bus khub = new Business.Khu_Bus();
        int curr;

        public uclKhu()
        {
            InitializeComponent();
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
            List<SysQuyenSuDung> listquyen = qsdb.SelectQuyenSuDung(manhom, "18");
            foreach (var b in listquyen)
            {
                if (b.Them == false)
                    barButtonItem1.Enabled = false;
                if (b.Sua == false)
                    barButtonItem2.Enabled = false;
                if (b.Xoa == false)
                    barButtonItem3.Enabled = false;
                //if (b.XuatDuLieu == false)
                //    btnXuat.Enabled = false;
                //if (b.NhapDuLieu == false)
                //    btnNhap.Enabled = false;
                //if (b.InAn == false)
                //    btnIn.Enabled = false;
            }

        }
        void RefeshG(object ob)
        {
            gridKhu.DataSource = ob;
        }
        private void gridKhu_Load(object sender, EventArgs e)
        {
            gridKhu.DataSource = khub.GetAllKhu_Count();
            this.gridViewKhu.OptionsBehavior.Editable = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Form.Khu.frmKhu frm = new Khu.frmKhu();
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            frm.Show();
            this.Cursor = Cursors.Default;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridKhu.DataSource = khub.GetAllKhu_Count();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            curr = gridViewKhu.GetDataSourceRowIndex(gridViewKhu.FocusedRowHandle);
            DialogResult x = XtraMessageBox.Show("Bạn có muốn thực hiện thao tác?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < gridViewKhu.RowCount; i++)
                {
                    if (gridViewKhu.IsRowSelected(i) == true)
                        list.Add(gridViewKhu.GetRowCellValue(i, "MaKhu").ToString());
                }
                List<LinQToSQL.Khu> khuk = khub.KhuTheoMa(list);
                if (khuk.Count > 0)
                {
                    XtraMessageBox.Show("Khu này có phòng còn Sinh viên, vui lòng xóa hết phòng trong khu", "Thông báo");
                    return;
                }

                else
                {
                    khub.Delete_to_Rac(list);
                    gridKhu.DataSource = khub.GetAllKhu_Count();
                }
            }
            
            List<Business.Khu_Bus.Khu_Count> sinhvien = (List<Business.Khu_Bus.Khu_Count>)gridViewKhu.DataSource;
            Business.Khu_Bus.Khu_Count khu = (Business.Khu_Bus.Khu_Count)sinhvien[gridViewKhu.FocusedRowHandle];
            if (khub.KiemTraTonTaiPhong(khu.MaKhu) == 0)
            {
                khub.DeleteKhu_Rac(khu.MaKhu);
                XtraMessageBox.Show("Xóa " + khu.TenKhu + " thành công");
            }
            else
            {
                XtraMessageBox.Show("Khu này có phòng còn Sinh viên, vui lòng xóa hết phòng trong " + khu.TenKhu, "Thông báo");
            }
            gridKhu.DataSource = khub.GetAllKhu_Count();
            gridViewKhu.MoveBy(--curr);
            this.Cursor = Cursors.Default;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            curr = gridViewKhu.GetDataSourceRowIndex(gridViewKhu.FocusedRowHandle);
            List<Business.Khu_Bus.Khu_Count> kh = (List<Business.Khu_Bus.Khu_Count>)gridViewKhu.DataSource;
            Business.Khu_Bus.Khu_Count item = (Business.Khu_Bus.Khu_Count)kh[gridViewKhu.FocusedRowHandle];
            Khu.frmKhu pb = new Khu.frmKhu(Common.ChucNang.Sua, item);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            pb.ShowDialog();
            gridViewKhu.MoveBy(curr);
            this.Cursor = Cursors.Default;
        }

        private void gridViewKhu_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
