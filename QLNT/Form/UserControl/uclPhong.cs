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
using QLNT.LinQToSQL;
using QLNT.Business;
namespace QLNT.Form.UserControl
{
    public partial class uclPhong : DevExpress.XtraEditors.XtraUserControl
    {
        Business.Phong_Bus pbb = new Business.Phong_Bus();
        int s;
        public uclPhong()
        {
            InitializeComponent();
            gridPhong.DataSource = pbb.ListPhong();
            PhanQuyen();
        }
        private void PhanQuyen()
        {

        }
        void RefeshG(object ob)
        {
            gridPhong.DataSource = ob;//
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Business.Log_Bus lb = new Business.Log_Bus();
            lb.InsertLog("Thêm phòng ban", "thêm phòng ban");
            PhongBan.frmPhongBan pb = new PhongBan.frmPhongBan(ChucNang.Them, null);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            pb.ShowDialog();

            this.Cursor = Cursors.Default;
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DialogResult x = XtraMessageBox.Show("Bạn có muốn thực hiện thao tác?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (x == DialogResult.Yes)
            //{
            //    Business.Phong_Bus phongb = new Business.Phong_Bus();
            //    List<string> list = new List<string>();

            //    try
            //    {                    
            //        for (int i = 0; i < gridViewPhong.RowCount; i++) {                         
            //            if (gridViewPhong.IsRowSelected(i) == true)
            //                list.Add(gridViewPhong.GetRowCellValue(i, "MaPhong").ToString());                      
            //          }
            //        Business.SinhVienBus svb = new Business.SinhVienBus();
            //        List<Business.SinhVienBus.DanhSach> sinhvien = svb.DanhSachTheoMaPhong(list);
            //        if(sinhvien.Count>0)
            //        {
            //           XtraMessageBox.Show("Đang tồn tại " + sinhvien.Count + " sinh viên trong danh sách phòng muốn xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            PhongBan.frmSinhVien_Delete phongo = new PhongBan.frmSinhVien_Delete(sinhvien);
            //            phongo.ShowDialog();                        
            //        }
            //        sinhvien = svb.DanhSachTheoMaPhong(list);
            //        if(sinhvien.Count > 0)
            //        {
            //            string t = string.Empty;
            //            foreach (string l in list)
            //                t += l + "\n";
            //            XtraMessageBox.Show("Không thể xóa các phòng ban:\n" + t+"Hãy xóa tất cả các sinh viên hoặc chuyển phòng cho họ để xóa phòng ban.");
            //            return;
            //        }
            //        else
            //        {

            //           gridViewPhong.DeleteSelectedRows();                       
            //           phongb.Delete_to_Rac(list);
            //        }
            //    }
            //    catch (Exception ee)
            //    {
            //        XtraMessageBox.Show("Không thể xóa phòng ở.\nLỗi: "+ee, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            // }

        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            gridPhong.DataSource = pbb.ListPhong();
            this.Cursor = Cursors.Default;
        }



    }
}
