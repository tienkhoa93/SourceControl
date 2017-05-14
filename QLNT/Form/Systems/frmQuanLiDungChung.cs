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
using Common;
using QLNT.Business;
using QLNT.LinQToSQL;

namespace QLNT.Form.Systems
{
    public partial class frmQuanLiDungChung : DevExpress.XtraEditors.XtraForm
    {
        Business.DanTocBus dtb = new Business.DanTocBus();
        Business.HoKhauThuongTruBus hkttb = new Business.HoKhauThuongTruBus();
       
        Business.TonGiaoBus tgb = new Business.TonGiaoBus();
        Business.TinhTrangBus ttb = new Business.TinhTrangBus();
        Business.VatTuBus vtb = new Business.VatTuBus();
        public frmQuanLiDungChung()
        {
            InitializeComponent();
            gridDanToc.OptionsBehavior.ReadOnly = true;
            gridHoKhauThuongTru.OptionsBehavior.ReadOnly = true;
         
            gridTonGiao.OptionsBehavior.ReadOnly = true;
            gridTinhTrang.OptionsBehavior.ReadOnly = true;
            gridVatTu.OptionsBehavior.ReadOnly = true;
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
            List<SysQuyenSuDung> listquyen = qsdb.SelectQuyenSuDung(manhom, "16");
            foreach (var b in listquyen)
            {
                if (b.Xoa == false)
                {
                    btnXoaDanToc.Enabled = false;
                    btnXoaHoKhauThuongTru.Enabled = false;
                  
                    btnXoaTonGiao.Enabled = false;
                    btnXoaVatTu.Enabled = false;
                }
                if (b.Sua == false)
                {
                    btnSuaDanToc.Enabled = false;
                    btnSuaHoKhauThuongTru.Enabled = false;
                   
                    btnSuaTonGiao.Enabled = false;
                    btnSuaVatTu.Enabled = false;
                }
                if (b.Them == false)
                {
                    btnThemDanToc.Enabled = false;
                    btnThemHoKhauThuongTru.Enabled = false;
                  
                    btnThemTonGiao.Enabled = false;
                    btnThemVatTu.Enabled = false;
                }
            }

        }

        #region delegate
        void RefeshGKhoaHoc(object ob)
        {
            
        }
        void RefeshGVatTu(object ob)
        {
            gridControlVatTu.DataSource = ob;
        }
        void RefeshGDanToc(object ob)
        {
            gridControlDanToc.DataSource = ob;
        }

        void RefeshGHoKhau(object ob)
        {
            gridControlHoKhauThuongTu.DataSource = ob;
        }

        void RefeshGLop(object ob)
        {
            
        }

        void RefeshGTonGiao(object ob)
        {
            gridControlTonGiao.DataSource = ob;
        }

        void RefeshGTinhTrang(object ob)
        {
            gridControlTinhTrang.DataSource = ob;
        } 
        #endregion       

        #region loaddatatogrid
       

        private void xtraTabPageDanToc_Paint(object sender, PaintEventArgs e)
        {
            //gridControlDanToc.DataSource = dtb.ListDanToc(); 
        }

        private void gridControlHoKhauThuongTu_Paint(object sender, PaintEventArgs e)
        {
            //gridControlHoKhauThuongTu.DataSource =hkttb.ListHoKhauThuongTru();
        }

        private void gridControlKhoaHoc_Paint(object sender, PaintEventArgs e)
        {
            //gridControlKhoaHoc.DataSource = khb.ListKhoaHoc();
        }

        private void gridControlLop_Paint(object sender, PaintEventArgs e)
        {
            //gridControlLop.DataSource = lb.ListLop();
        }

        private void gridControlTonGiao_Paint(object sender, PaintEventArgs e)
        {
            //gridControlTonGiao.DataSource = tgb.ListTonGiao();
        }

        private void xtraTabPageTinhTrang_Paint(object sender, PaintEventArgs e)
        {
            //gridControlTinhTrang.DataSource = ttb.ListTinhTrang();
        }

        private void frmQuanLiDungChung_Load(object sender, EventArgs e)
        {
            gridControlTinhTrang.DataSource = ttb.ListTinhTrang();
            gridControlTonGiao.DataSource = tgb.ListTonGiao();
           
            gridControlHoKhauThuongTu.DataSource = hkttb.ListHoKhauThuongTru();
            gridControlDanToc.DataSource = dtb.ListDanToc();
            gridControlVatTu.DataSource = vtb.ListVatTu();
        }
        #endregion

        #region frmDanToc
        private void btnTaiLaiDanToc_Click(object sender, EventArgs e)
        {
            gridControlDanToc.DataSource = dtb.ListDanToc();
        }
        private void btnThemDanToc_Click(object sender, EventArgs e)
        {
            Form.DanhMuc.frmDanToc frm = new DanhMuc.frmDanToc(ChucNang.Them, null);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGDanToc);
            frm.ShowDialog();
        }

        private void btnXoaDanToc_Click(object sender, EventArgs e)
        {
            LinQToSQL.DanToc dantoc = (LinQToSQL.DanToc)gridDanToc.GetRow(gridDanToc.FocusedRowHandle);
            if (dtb.KiemTraTonTaiDanToc(dantoc.MaDanToc) == 0)
            {
                dtb.DeleteDanToc(dantoc.MaDanToc);
                XtraMessageBox.Show("Xóa " + dantoc.TenDanToc + " thành công");
                gridControlDanToc.DataSource = dtb.ListDanToc();
            }

            else
                XtraMessageBox.Show("Dân tộc này còn tồn tại Sinh viên, vui lòng Sinh viên hoặc chuyển Dân tộc " + dantoc.TenDanToc, "Thông báo");
        }

        private void btnSuaDanToc_Click(object sender, EventArgs e)
        {
            LinQToSQL.DanToc dantoc = (LinQToSQL.DanToc)gridDanToc.GetRow(gridDanToc.FocusedRowHandle);
            Form.DanhMuc.frmDanToc frm = new DanhMuc.frmDanToc(Common.ChucNang.Sua, dantoc);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGDanToc);
            frm.ShowDialog();
        }
        #endregion            

        #region frmKhoaHoc
        
        #endregion

        #region Hộ khẩu thường trú
        private void btnThemHoKhauThuongTru_Click(object sender, EventArgs e)
        {
            Form.DanhMuc.frmHoKhauThuongTru frm = new DanhMuc.frmHoKhauThuongTru();
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGHoKhau);
            frm.ShowDialog();
        }

        private void btnXoaHoKhauThuongTru_Click(object sender, EventArgs e)
        {
            LinQToSQL.HoKhauThuongTru hokhauthuongtru = (LinQToSQL.HoKhauThuongTru)gridHoKhauThuongTru.GetRow(gridHoKhauThuongTru.FocusedRowHandle);
            if (hkttb.KiemTraTonTaiHoKhau(hokhauthuongtru.MaHoKhau) == 0)
            {
                hkttb.DeleteHoKhau(hokhauthuongtru.MaHoKhau);
                XtraMessageBox.Show("Xóa " + hokhauthuongtru.TenHoKhau + " thành công");
                gridControlHoKhauThuongTu.DataSource = hkttb.ListHoKhauThuongTru();
            }

            else
                XtraMessageBox.Show("Hộ khẩu thường trú này còn tồn tại Sinh viên, vui lòng Sinh viên hoặc chuyển Hộ khẩu hường trú " + hokhauthuongtru.TenHoKhau, "Thông báo");
        }

        private void btnSuaHoKhauThuongTru_Click(object sender, EventArgs e)
        {
            LinQToSQL.HoKhauThuongTru hokhauthuongtru = (LinQToSQL.HoKhauThuongTru)gridHoKhauThuongTru.GetRow(gridHoKhauThuongTru.FocusedRowHandle);
            Form.DanhMuc.frmHoKhauThuongTru frm = new DanhMuc.frmHoKhauThuongTru(Common.ChucNang.Sua, hokhauthuongtru);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGHoKhau);
            frm.ShowDialog();
        }

        private void btnTaiLaiHoKhauThuongTru_Click(object sender, EventArgs e)
        {
            gridControlHoKhauThuongTu.DataSource = hkttb.ListHoKhauThuongTru();
        } 
        #endregion

        #region Tôn giáo
        private void btnThemTonGiao_Click(object sender, EventArgs e)
        {
            Form.DanhMuc.frmTonGiao frm = new DanhMuc.frmTonGiao();
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGTonGiao);
            frm.ShowDialog();
        }

        private void btnXoaTonGiao_Click(object sender, EventArgs e)
        {
            LinQToSQL.TonGiao tongiao = (LinQToSQL.TonGiao)gridTonGiao.GetRow(gridTonGiao.FocusedRowHandle);
            if (tgb.KiemTraTonTaiTonGiao(tongiao.MaTonGiao) == 0)
            {
                tgb.DeleteTonGiao(tongiao.MaTonGiao);
                XtraMessageBox.Show("Xóa " + tongiao.TenTonGiao + " thành công");
                gridControlTonGiao.DataSource = tgb.ListTonGiao();
            }

            else
                XtraMessageBox.Show("Tôn giáo này còn tồn tại Sinh viên, vui lòng Sinh viên hoặc chuyển Tôn giáo " + tongiao.TenTonGiao, "Thông báo");
        }

        private void btnSuaTonGiao_Click(object sender, EventArgs e)
        {
            LinQToSQL.TonGiao tongiao = (LinQToSQL.TonGiao)gridTonGiao.GetRow(gridTonGiao.FocusedRowHandle);
            Form.DanhMuc.frmTonGiao frm = new DanhMuc.frmTonGiao(Common.ChucNang.Sua, tongiao);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGTonGiao);
            frm.ShowDialog();
        }

        private void btnTaiLaiTonGiao_Click(object sender, EventArgs e)
        {
            gridControlTonGiao.DataSource = tgb.ListTonGiao();
        } 
        #endregion

        #region frmTinhTrang
        private void btnThemTinhTrang_Click(object sender, EventArgs e)
        {
            Form.DanhMuc.frmTrangThai frm = new DanhMuc.frmTrangThai(ChucNang.Them,null);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGTinhTrang);
            frm.ShowDialog();
        }

        private void btnXoaTinhTrang_Click(object sender, EventArgs e)
        {
            LinQToSQL.TrangThai trangthai = (LinQToSQL.TrangThai)gridTinhTrang.GetRow(gridTinhTrang.FocusedRowHandle);
            if (trangthai.MaTrangThai==6 ||trangthai.MaTrangThai==7 ||trangthai.MaTrangThai==9 )
            {
                XtraMessageBox.Show("Không thể xóa");
            }
            else
            if (ttb.KiemTraTonTaiTrangThai(trangthai.MaTrangThai) == 0)
            {
                ttb.DeleteTrangThai(trangthai.MaTrangThai);
                XtraMessageBox.Show("Xóa " + trangthai.TenTrangThai + " thành công");
                gridControlTinhTrang.DataSource = ttb.ListTinhTrang();
            }

            else
                XtraMessageBox.Show("Trạng thái này còn tồn tại Sinh viên, vui lòng Sinh viên hoặc chuyển trạng thái " + trangthai.TenTrangThai, "Thông báo");
        }

        private void btnSuaTinhTrang_Click(object sender, EventArgs e)
        {
            LinQToSQL.TrangThai trangthai = (LinQToSQL.TrangThai)gridTinhTrang.GetRow(gridTinhTrang.FocusedRowHandle);
            Form.DanhMuc.frmTrangThai frm = new DanhMuc.frmTrangThai(Common.ChucNang.Sua, trangthai);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGTinhTrang);
            frm.ShowDialog();
        }

        private void btnTaiLaiTinhTrang_Click(object sender, EventArgs e)
        {
            gridControlTinhTrang.DataSource = ttb.ListTinhTrang();
        }
        
        #endregion

   

        #region frmVatTu
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            gridControlVatTu.DataSource = vtb.ListVatTu();
        }

        private void btnSuaVatTu_Click(object sender, EventArgs e)
        {
            LinQToSQL.VatTu vattu = (LinQToSQL.VatTu)gridVatTu.GetRow(gridVatTu.FocusedRowHandle);
            Form.DanhMuc.VatTu.frmVatTu frm = new Form.DanhMuc.VatTu.frmVatTu(Common.ChucNang.Sua, vattu);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGVatTu);
            frm.ShowDialog();
        }

        private void btnXoaVatTu_Click(object sender, EventArgs e)
        {
            LinQToSQL.VatTu vattu = (LinQToSQL.VatTu)gridVatTu.GetRow(gridVatTu.FocusedRowHandle);
            try
            {
                vtb.XoaVatTu(vattu.MaVatTu);
                XtraMessageBox.Show("Xóa " + vattu.TenVatTu + " thành công");
                gridControlVatTu.DataSource = vtb.ListVatTu();
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xãy ra.", "Thông báo");
            }
        }

        private void btnThemVatTu_Click(object sender, EventArgs e)
        {
            Form.DanhMuc.VatTu.frmVatTu frm = new Form.DanhMuc.VatTu.frmVatTu(Common.ChucNang.Them, null);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshGVatTu);
            frm.ShowDialog();
        } 
        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        
    }
}