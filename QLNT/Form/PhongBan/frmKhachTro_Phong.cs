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
using DevExpress.XtraBars;
using System.Threading;
using System.IO;
using DevExpress.XtraTreeList.Nodes;
using QLNT.Business;
using QLNT.LinQToSQL;
using Common;

namespace QLNT.Form.PhongBan
{
    public partial class frmKhachTro_Phong : DevExpress.XtraEditors.XtraForm
    {
        string maphong = String.Empty;
        string makhachtro = string.Empty;
        string mp = string.Empty;
        bool them = false;
        Business.KhachTro_Bus ktb = new Business.KhachTro_Bus();
        Business.DanTocBus dtb = new Business.DanTocBus();
        Business.TinhTrangBus ttb = new Business.TinhTrangBus();
        Business.TonGiaoBus tgb = new Business.TonGiaoBus();
        Business.Phong_Bus pb = new Business.Phong_Bus();
        Business.Khu_Bus kb = new Business.Khu_Bus();
        List<string> list = new List<string>();
       
        LinQToSQL.Phong phong;


        public frmKhachTro_Phong(string mp)
        {
            InitializeComponent();
            this.mp = mp;
            Refetch();
            
        }

        private void PhanQuyenKhachTro()
        {
            btnXoaKhach.Enabled = true;
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
                if (b.Them == false)
                    btnThemKhachTro.Enabled = false;
                //if (b.Sua == false)
                //    btnSua.Enabled = false;
                if (b.Xoa == false)
                    btnXoaKhach.Enabled = false;
                //if (b.XuatDuLieu == false)
                //    btnXuat.Enabled = false;
                //if (b.NhapDuLieu == false)
                //    btnNhap.Enabled = false;
                //if (b.InAn == false)
                //    btnIn.Enabled = false;
            }

        }
        private void PhanQuyenPhong()
        {
            btnXoaKhach.Enabled = true;
            SysNguoiDung_Bus ndb = new SysNguoiDung_Bus();
            SysQuyenSuDung_Bus qsdb = new SysQuyenSuDung_Bus();
            List<SysUser> listuser = ndb.SelectNguoiDung(UserInfo.Account);
            string manhom = "";
            foreach (var a in listuser)
            {
                manhom = a.MaNhom;
            }
            List<SysQuyenSuDung> listquyen = qsdb.SelectQuyenSuDung(manhom, "17");
            foreach (var b in listquyen)
            {
                //if (b.Them == false)
                //    btnThemKhachTro.Enabled = false;
                //if (b.Sua == false)
                //    btnSua.Enabled = false;
                if (b.Xoa == false)
                    btnXoaKhach.Enabled = false;
                //if (b.XuatDuLieu == false)
                //    btnXuat.Enabled = false;
                //if (b.NhapDuLieu == false)
                //    btnNhap.Enabled = false;
                //if (b.InAn == false)
                //    btnIn.Enabled = false;
            }

        }
        bool LayThongTinPhong()
        {
            String c = string.Empty;
            phong.MaPhong = txtMaPhong.Text;
            phong.TenPhong = txtTenPhong.Text;
            phong.MaKhu = gluKhu.EditValue.ToString();
            phong.SoNguoi = int.Parse(calSoNguoi.EditValue.ToString());
            phong.GiaPhong = float.Parse(calGiaPhong.EditValue.ToString());
            phong.GhiChu = mmGhiChu.Text;
            phong.HoatDong = bool.Parse(chckQuanLy.EditValue.ToString());
            if (phong.MaPhong == null || phong.MaPhong.Length < 3)
                c += "Xin hãy nhập mã phòng có độ dài >3 ký tự.\n";
            if (phong.SoNguoi < 0)
                c += "Số người trong phòng không thể < 0.\n";
            if (phong.GiaPhong < 0)
                c += "Giá tiền phòng phải là số dương >= 0";
            if (c != "")
            {
                XtraMessageBox.Show(c);
                return false;
            }
            return true;

        }
        void Refetch1()
        {
            phong = pb.PhongTheoMa(this.mp);
            if (phong != null)
            {
                ///tab1
                txtMaPhong.Text = phong.MaPhong == null ? null : phong.MaPhong;
                txtTenPhong.Text = phong.TenPhong;
                gluKhu.EditValue = phong.MaKhu;
                calSoNguoi.EditValue = phong.SoNguoi;
                calGiaPhong.EditValue = phong.GiaPhong;
                chckQuanLy.Checked = (bool)phong.HoatDong;
                mmGhiChu.Text = phong.GhiChu;
            }
        }
        void Refetch()
        {
            Thread a = new Thread(new ThreadStart(Refetch1));
            a.IsBackground = true;
            a.Start();

            gridKhachTro.DataSource = ktb.ListDanhSachKhachTro_TheoMaPhong(this.mp);
         
            gluTrangThai.Properties.DataSource = ttb.ListTinhTrang();
            gluTonGiao.Properties.DataSource = tgb.ListTonGiao();
            gluDanToc.Properties.DataSource = dtb.ListDanToc();
            gluPhong.Properties.DataSource = pb.ListPhong();
            gluPhong.EditValue = this.mp;
            gluKhu.Properties.DataSource = kb.GetAllKhu();
            btnNap.Visibility = BarItemVisibility.Never;
            btnThemKhachTro.Visibility = BarItemVisibility.Never;
            btnChuyenPhong.Visibility = BarItemVisibility.Never;
            a.Join();
        }
        /// <summary>
        /// Số tự động tăng trong grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvKhachTro_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
     

        private void gvKhachTro_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            if (e.FocusedRowHandle != -999997)
            {
                var c = gvKhachTro.GetFocusedRowCellValue("MaKhachTro");
              if(c!=null)
              {
                  txtMaKhachTro.Properties.ReadOnly = true;
                  txtMaKhachTro.Text = gvKhachTro.GetFocusedRowCellValue("MaKhachTro").ToString();
                  txtHoLot.Text = gvKhachTro.GetFocusedRowCellValue("HoLot").ToString();
                  txtTen.Text = gvKhachTro.GetFocusedRowCellValue("Ten").ToString();
                  dateNgaySinh.EditValue = gvKhachTro.GetFocusedRowCellValue("NgaySinh");
                  gluPhong.EditValue = gvKhachTro.GetFocusedRowCellValue("MaPhong").ToString();
                  txtCMND.Text = gvKhachTro.GetFocusedRowCellValue("CMND").ToString();
                  dateNgayCapCMND.EditValue = gvKhachTro.GetFocusedRowCellValue("NgayCap");
                  txtNoiCapCMND.Text = gvKhachTro.GetFocusedRowCellValue("NoiCap").ToString();
                  txtPhongCu.Text = gvKhachTro.GetFocusedRowCellValue("MaPhongCu").ToString();
                  txtSDT.Text = gvKhachTro.GetFocusedRowCellValue("SDT").ToString();
                  txtSDTLienHe.Text = gvKhachTro.GetFocusedRowCellValue("SDTLienHe").ToString();
                  dateNgayVao.EditValue = gvKhachTro.GetFocusedRowCellValue("NgayVao");
                  try
                  {
                      dateNgayRa.EditValue = gvKhachTro.GetFocusedRowCellValue("NgayRa");
                  }
                  catch { }
                  txtThuongTru.Text = gvKhachTro.GetFocusedRowCellValue("ThuongTru").ToString();
                  txtTamTru.Text = gvKhachTro.GetFocusedRowCellValue("TamTru").ToString();
                  txtGhiChu.Text = gvKhachTro.GetFocusedRowCellValue("GhiChu").ToString();
                  chckConQuanLy.Checked = bool.Parse(gvKhachTro.GetFocusedRowCellValue("HoatDong").ToString());
                  chckTruongPhong.Checked = bool.Parse(gvKhachTro.GetFocusedRowCellValue("TruongPhong").ToString());
                 
                  try { gluDanToc.EditValue = gvKhachTro.GetFocusedRowCellValue("MaDanToc").ToString(); }
                  catch { }

                  try { gluTrangThai.EditValue = gvKhachTro.GetFocusedRowCellValue("MaTrangThai").ToString(); }
                  catch { }

                  try { gluTonGiao.EditValue = gvKhachTro.GetFocusedRowCellValue("MaTonGiao").ToString(); }
                  catch { }

                  cboGioiTinh.EditValue = gvKhachTro.GetFocusedRowCellValue("GioiTinh").ToString();
              }
               
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (LayThongTinPhong())
            {
               
                    if (pb.UpdatePhong(phong))
                    {
                        gluPhong.Properties.DataSource = pb.ListPhong();
                        gridKhachTro.DataSource = ktb.ListDanhSachKhachTro_TheoMaPhong(phong.MaPhong);
                        this.mp = phong.MaPhong;
                        XtraMessageBox.Show("Sửa thông tin phòng thành công.");
                    }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtMaKhachTro.Text = null;
            txtHoLot.Text = null;
            txtTen.Text = null;
            dateNgaySinh.EditValue = null;
            txtCMND.Text = null;
            dateNgayCapCMND.EditValue = null;
            txtNoiCapCMND.Text = null;
            txtPhongCu.Text = null;
            txtSDT.Text = null;
            txtSDTLienHe.Text = null;
            dateNgayVao.EditValue = null;
            dateNgayRa.EditValue = null;
            txtThuongTru.Text = null;
            txtTamTru.Text = null;
            txtGhiChu.Text = null;
            chckQuanLy.Checked = false;
            chckTruongPhong.Checked = false;
            gluDanToc.EditValue = null;
            gluTrangThai.EditValue = null;
            gluTonGiao.EditValue = null;
            cboGioiTinh.EditValue = "Nam";
            txtMaKhachTro.Properties.ReadOnly = false;
            them = true;
        }

        private void btnThemKhachTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Business.KhachTro_Bus ktb = new Business.KhachTro_Bus();

            if(!ktb.KiemTraSoNguoi(gluPhong.EditValue.ToString()))
            {
                XtraMessageBox.Show("Không thể thêm người vào phòng vì số người đã đủ.");
                return ;
            }
            if (them == true)
            {
                LinQToSQL.KhachTro k = new LinQToSQL.KhachTro();
               
                k.MaKhachTro = txtMaKhachTro.Text;
                k.GioiTinh = cboGioiTinh.Text;
                k.HoLot = txtHoLot.Text;
                k.Ten = txtTen.Text;
                try { 
                    k.NgaySinh = DateTime.Parse(dateNgaySinh.EditValue.ToString());
                    if (k.NgaySinh > DateTime.Today)
                    {
                        XtraMessageBox.Show("Ngày sinh không thể lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch { }
                
              
                k.MaPhong = gluPhong.EditValue.ToString();
                k.CMND = txtCMND.Text;
                try    {
                    k.NgayCap = DateTime.Parse(dateNgayCapCMND.EditValue.ToString());
                    if (k.NgayCap > DateTime.Today)
                    {
                        XtraMessageBox.Show("Ngày cấp CMND thể lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch { }
             
                k.NoiCap = txtNoiCapCMND.Text;
                k.MaPhongCu = txtPhongCu.Text;
                k.SDTLienHe = txtSDTLienHe.Text;
                k.SDT = txtSDT.Text;

                try
                {
                    k.NgayVao = DateTime.Parse(dateNgayVao.EditValue.ToString());
                }
                catch { }

                try
                {
                    k.NgayRa = DateTime.Parse(dateNgayRa.EditValue.ToString());
                }
                catch { }
                k.ThuongTru = txtThuongTru.Text;
                k.TamTru = txtTamTru.Text;
                k.GhiChu = txtGhiChu.Text;
               if(gluDanToc.EditValue!=null)
                k.MaDanToc = int.Parse(gluDanToc.EditValue.ToString());

               if (gluTonGiao.EditValue != null)
                k.MaTonGiao = int.Parse(gluTonGiao.EditValue.ToString());

               if (gluTrangThai.EditValue != null)
                k.MaTrangThai = int.Parse(gluTrangThai.EditValue.ToString());
                if (chckConQuanLy.Checked == true)
                    k.HoatDong = true;
                else k.HoatDong = false;
                if (chckTruongPhong.Checked == true)
                    k.TruongPhong = true;
                else k.TruongPhong = false;
               
                if (ktb.KiemTraKhachTro(k.MaKhachTro))
                {
                    String er = CheckInfor();
                    if(er=="")
                    {
                        if (ktb.InsertKhachTro(k))
                        {
                            gridKhachTro.DataSource = ktb.ListDanhSachKhachTro_TheoMaPhong(mp);
                            Refetch1();
                            them = false;
                            XtraMessageBox.Show("Thêm người thành công !");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(er);
                    }
                   
                }
                else
                {
                    XtraMessageBox.Show("Mã khách trọ đã tồn tại. Nhập mã khác.");
                }
            }
            else
            {
                XtraMessageBox.Show("Click vào button Xóa Trắng để nhập thông tin cho người mới.");
            }
          
          
        }
       
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
           

            if (tabPhong.PageVisible==true && e.Page.Name == "tabPhong")
            {
                PhanQuyenPhong();
                btnNap.Visibility = BarItemVisibility.Never;
                btnThemKhachTro.Visibility = BarItemVisibility.Never;
                btnChuyenPhong.Visibility = BarItemVisibility.Never;
                btnXoaKhach.Visibility = BarItemVisibility.Always;
                
            }
            else
            {
                PhanQuyenKhachTro();
                btnNap.Visibility = BarItemVisibility.Always;
                btnThemKhachTro.Visibility = BarItemVisibility.Always;             
                btnChuyenPhong.Visibility = BarItemVisibility.Always;
                btnXoaKhach.Visibility = BarItemVisibility.Always;
            }
            if(tabChuyenPhong.PageVisible==true)
            {
                btnNap.Visibility = BarItemVisibility.Never;
                btnThemKhachTro.Visibility = BarItemVisibility.Never;
                btnXoaKhach.Visibility = BarItemVisibility.Never;
                btnChuyenPhong.Visibility = BarItemVisibility.Never;
                
                VeCayChucNang();
            }

        }
        #region Ve cay
        private void VeCayChucNang()
        {
          
            
            TreeListNode rootNode = null;
            TreeListNode childnode0 = null;
            TreeListNode childNode = null;
            TreeListNode childNode1 = null;
            
            rootNode = tlDanhSachPhong.AppendNode(null, null);
            rootNode.SetValue("ChucNang", "Trường Cao Đẳng Công Thương");
            rootNode.StateImageIndex = 0;

            List<LinQToSQL.Khu> khu = kb.GetAllKhu();
            foreach(var a in khu){
                childnode0 = tlDanhSachPhong.AppendNode(null, rootNode);
                childnode0.SetValue("MaPhong",a.TenKhu);
                childnode0.StateImageIndex = 1;
                childnode0.Tag = a.MaKhu;

                List<LinQToSQL.Phong> chucnang1 = pb.ListPhong_TheoMaKhu(a.MaKhu);
                foreach (var c in chucnang1)
                {
                    childNode = tlDanhSachPhong.AppendNode(null, childnode0);
                    childNode.SetValue("MaPhong", c.TenPhong);
                    childNode.ParentNode.Tag = c.MaPhong;
                    childNode.Tag = c.MaPhong;
                    childNode.StateImageIndex = 2;
                }

            }
            tlDanhSachPhong.ExpandAll();


        }
        #endregion
        #region Kiểm tra giữ liệu
        String CheckInfor()
        {
            String er = String.Empty;
            if (txtMaKhachTro.Text == "")
                er += "Nhập mã cho khách trọ\n";
            if (txtHoLot.Text == "")
                er += "Nhập họ cho khách trọ.\n";
            if(txtTen.Text=="")
                er += "Nhập tên cho khách trọ.\n";
            if (cboGioiTinh.Text == "")
                er += "Chọn giới tính cho khách trọ.\n";
                return er;
        }

        #endregion
        private void btnNap_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cc =string.Empty;
            try { cc = txtMaKhachTro.Text; }
            catch { }
           
            LinQToSQL.KhachTro k = new LinQToSQL.KhachTro();
           
            k.MaKhachTro = txtMaKhachTro.Text;
            k.GioiTinh = cboGioiTinh.Text;
            k.HoLot = txtHoLot.Text;
            k.Ten = txtTen.Text;
            k.NgaySinh = DateTime.Parse(dateNgaySinh.EditValue.ToString());
            k.MaPhong = gluPhong.EditValue.ToString();
            k.CMND = txtCMND.Text;
            k.NgayCap = DateTime.Parse(dateNgayCapCMND.EditValue.ToString());
            k.NoiCap = txtNoiCapCMND.Text;
            k.MaPhongCu = txtPhongCu.Text;
            k.SDTLienHe = txtSDTLienHe.Text;
            k.SDT = txtSDT.Text;

            try
            {
                k.NgayVao = DateTime.Parse(dateNgayVao.EditValue.ToString());
            }
            catch { }

            try
            {
                k.NgayRa = DateTime.Parse(dateNgayRa.EditValue.ToString());
            }
            catch { }
            k.ThuongTru = txtThuongTru.Text;
            k.TamTru = txtTamTru.Text;
            k.GhiChu = txtGhiChu.Text;
            k.MaDanToc = int.Parse(gluDanToc.EditValue.ToString());
            k.MaTonGiao = int.Parse(gluTonGiao.EditValue.ToString());
            k.MaTrangThai = int.Parse(gluTrangThai.EditValue.ToString());
            if (chckConQuanLy.Checked == true)
                k.HoatDong = true;
            else k.HoatDong = false;
            if (chckTruongPhong.Checked == true)
                k.TruongPhong = true;
            else k.TruongPhong = false;
            Business.KhachTro_Bus ktb = new Business.KhachTro_Bus();
            String er = CheckInfor();
            if(er=="")
            {
                if (ktb.UpdateKhachTroTheoMaCu(cc,k))
                {
                    XtraMessageBox.Show("Cập nhật thông tin thành công.");
                    gridKhachTro.DataSource = ktb.ListDanhSachKhachTro_TheoMaPhong(k.MaPhong);
                }
                else
                {
                    XtraMessageBox.Show("Lỗi trong quá trình cập nhật giữ liệu.");
                }
            }
            else
            {
                XtraMessageBox.Show(er);
                return;
            }
            Refetch1();
        }

        private void btnChuyenPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            tabChuyenPhong.PageVisible = true;
            tabPhong.PageVisible = false;
            tabKhachTro.PageVisible = false;
            tabMain.SelectedTabPage = tabChuyenPhong;
           
            for (int i = 0; i < gvKhachTro.RowCount; i++)
            {
                if (gvKhachTro.IsRowSelected(i) == true)
                    list.Add(gvKhachTro.GetRowCellValue(i,"MaKhachTro").ToString());
            }
            Refetch1();
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabChuyenPhong.PageVisible = false;
            tabPhong.PageVisible = true;
            tabKhachTro.PageVisible = true;
            tabMain.SelectedTabPage = tabKhachTro;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!maphong.Equals(""))
            {
                ktb.ChuyenPhong(list,maphong);
                gridKhachTro.DataSource = ktb.ListDanhSachKhachTro_TheoMaPhong(mp);
                XtraMessageBox.Show("Chuyển phòng thành công.");
              
                tabChuyenPhong.PageVisible = false;
                tabPhong.PageVisible = true;
                tabKhachTro.PageVisible = true;
                tabMain.SelectedTabPage = tabPhong;
                list.Clear();
                maphong = string.Empty;
                Refetch1();
            }
            else XtraMessageBox.Show("Hãy chọn phòng để chuyển người tới.");
        }

        private void tlDanhSachPhong_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                if(e.Node.Level==2)
                    maphong = e.Node.Tag.ToString();
            }
            catch {
            }
        }

        private void btnXoaKhach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tabMain.SelectedTabPage == tabPhong)
            {
                MessageBox.Show("Phong");
            }
            else if(tabMain.SelectedTabPage==tabKhachTro)
            {

                    List<string> xoa = new List<string>();
                    for (int i = 0; i < gvKhachTro.RowCount; i++)
                    {
                        if (gvKhachTro.IsRowSelected(i) == true)
                            xoa.Add(gvKhachTro.GetRowCellValue(i, "MaKhachTro").ToString());
                    }
                    if(XtraMessageBox.Show("Bạn muốn thực hiện thao tác xóa không?","Xác thực",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                    {
                        foreach (string t in xoa)
                        {
                            ktb.DeleteKhachTro(t);

                        }
                        gvKhachTro.DeleteSelectedRows();
                        XtraMessageBox.Show("Xoá thành công.");
                        Refetch1();
                    }

                    }
        }


    }
}