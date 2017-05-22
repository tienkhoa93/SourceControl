using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNT.Business;
using Common;
using System.IO;

namespace QLNT.Form.KhachTro
{
    public partial class frmDSKhachTro : DevExpress.XtraEditors.XtraForm
    {
        private LinQToSQL.KhachTro kt = new LinQToSQL.KhachTro();
        private KhachTro_Bus ktb = new Business.KhachTro_Bus();
        private ChucNang cn = new ChucNang();

        public frmDSKhachTro()
        {
            InitializeComponent();
        }

        public frmDSKhachTro(ChucNang cn, LinQToSQL.KhachTro kt)
        {
            InitializeComponent();
            LoadDataToGrid();
            dateNgayCap.EditValue = DateTime.Today.ToShortDateString();
            dateNgayVao.EditValue = DateTime.Today.ToShortDateString();
            dateNgayRa.EditValue = DateTime.Today.ToShortDateString();
            dateNgaySinh.EditValue = DateTime.Today.ToShortDateString();
            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                Text = "Thêm Khách Trọ";
                txtMaKhachTro.Select();
            }
            else
            {
                Text = "Sửa Khách Trọ";
                txtMaKhachTro.Properties.ReadOnly = true;
                GVupForm(kt);
            }
        }


        public void LoadDataToGrid()
        {
            var pb = new Phong_Bus();
            glkPhongCu.Properties.DisplayMember = "TenPhong";
            glkPhongCu.Properties.ValueMember = "MaPhong";
            glkPhongCu.Properties.DataSource = pb.ListPhong();

            glkPhongMoi.Properties.DisplayMember = "TenPhong";
            glkPhongMoi.Properties.ValueMember = "MaPhong";
            glkPhongMoi.Properties.DataSource = pb.ListPhong();

            var dtb = new DanTocBus();
            glkDanToc.Properties.DisplayMember = "TenDanToc";
            glkDanToc.Properties.ValueMember = "MaDanToc";
            glkDanToc.Properties.DataSource = dtb.ListDanToc();
            glkDanToc.EditValue = glkDanToc.Properties.GetKeyValue(0);

            var tgb = new TonGiaoBus();
            glkTonGiao.Properties.DisplayMember = "TenTonGiao";
            glkTonGiao.Properties.ValueMember = "MaTonGiao";
            glkTonGiao.Properties.DataSource = tgb.ListTonGiao();
            glkTonGiao.EditValue = glkTonGiao.Properties.GetKeyValue(0);

            var ttb = new TinhTrangBus();
            glkTrangThai.Properties.DisplayMember = "TenTrangThai";
            glkTrangThai.Properties.ValueMember = "MaTrangThai";
            glkTrangThai.Properties.DataSource = ttb.ListTinhTrang();
            glkTrangThai.EditValue = glkTrangThai.Properties.GetKeyValue(1);
        }

        public void GetValue()
        {
            kt.MaKhachTro = txtMaKhachTro.Text;

            try
            {
                var a = picAnh.Image;
                var ms = new MemoryStream();
                a.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                var img = ms.ToArray();
                kt.Anh = img;
            }
            catch
            {
                kt.Anh = null;
            }

            kt.HoLot = txtHoLot.Text;
            kt.Ten = txtTen.Text;
            kt.NgaySinh = DateTime.Parse(dateNgaySinh.EditValue.ToString());
            kt.GioiTinh = cboGioiTinh.EditValue.ToString();
            try {
                kt.MaDanToc = long.Parse(glkDanToc.EditValue.ToString());
            }
            catch { }
            try
            {
                kt.MaTonGiao = long.Parse(glkTonGiao.EditValue.ToString());
            }
            catch
            {

            }
            
            try
            {
                kt.MaPhong = glkPhongMoi.EditValue.ToString();
            }
            catch
            {
                kt.MaPhong = String.Empty;
            }
            try
            {
                kt.MaPhongCu = glkPhongCu.EditValue.ToString();
            }
            catch
            {
                kt.MaPhongCu = String.Empty;
            }
            kt.CMND = txtCMND.Text;
            try
            {
                kt.NgayCap = DateTime.Parse(dateNgayCap.EditValue.ToString());
            }
            catch
            {
                kt.NgayCap = DateTime.Parse("01-01-1990");
            }
            kt.ThuongTru = txtThuongTru.Text;
            kt.TamTru = txtTamTru.Text;
            kt.SDT = txtSDT.Text;
            kt.SDTLienHe = txtSDTLienHe.Text;
            kt.NgayVao = DateTime.Parse(dateNgayVao.EditValue.ToString());
            kt.NgayRa = DateTime.Parse(dateNgayRa.EditValue.ToString());
            try { kt.MaTrangThai = long.Parse(glkTrangThai.EditValue.ToString()); }
            catch { }
            
            kt.GhiChu = txtGhiChu.Text;
            if (chkTruongPhong.Checked)
            {
                kt.TruongPhong = true;
            }
            else
            {
                kt.TruongPhong = false;
            }
            if (chkQuanLy.Checked)
            {
                kt.HoatDong = true;
            }
            else
            {
                kt.HoatDong = false;
            }
            kt.NoiCap = txtNoiCap.Text;
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        public void GVupForm(LinQToSQL.KhachTro name)
        {
            txtMaKhachTro.Text = name.MaKhachTro;
            try
            {
                picAnh.Image = ByteArrayToImage(name.Anh.ToArray());
            }
            catch
            {
                picAnh.Image = null;
            }
            txtHoLot.Text = name.HoLot;
            txtTen.Text = name.Ten;
            dateNgaySinh.EditValue = name.NgaySinh;
            cboGioiTinh.EditValue = name.GioiTinh;
            txtCMND.Text = name.CMND;
            dateNgayCap.EditValue = name.NgayCap;
            glkPhongCu.EditValue = name.MaPhongCu;
            glkPhongMoi.EditValue = name.MaPhong;
            txtTamTru.Text = name.TamTru;
            txtThuongTru.Text = name.ThuongTru;
            txtSDT.Text = name.SDT;
            txtSDTLienHe.Text = name.SDTLienHe;
            glkDanToc.EditValue = name.MaDanToc;
            glkTonGiao.EditValue = name.MaTonGiao;
            dateNgayVao.EditValue = name.NgayVao;
            dateNgayRa.EditValue = name.NgayRa;
            glkTrangThai.EditValue = name.MaTrangThai;
            txtGhiChu.Text = name.GhiChu;
            chkTruongPhong.EditValue = name.TruongPhong;
            chkQuanLy.EditValue = name.HoatDong;
            txtNoiCap.Text = name.NoiCap;
        }

        public void Reset()
        {
            txtMaKhachTro.Text = string.Empty;
            txtHoLot.Text = string.Empty;
            picAnh.Image = null;
            txtTen.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtSDTLienHe.Text = string.Empty;
            txtTamTru.Text = string.Empty;
            txtThuongTru.Text = string.Empty;
            glkDanToc.EditValue = string.Empty;
            glkPhongCu.EditValue = string.Empty;
            glkPhongMoi.EditValue = string.Empty;
            glkTonGiao.EditValue = string.Empty;
            glkTrangThai.EditValue = string.Empty;
            cboGioiTinh.EditValue = string.Empty;
            dateNgayCap.EditValue = DateTime.Today.ToShortDateString();
            dateNgayVao.EditValue = DateTime.Today.ToShortDateString();
            dateNgayRa.EditValue = DateTime.Today.ToShortDateString();
            dateNgaySinh.EditValue = DateTime.Today.ToShortDateString();
            chkTruongPhong.Checked = false;
            chkQuanLy.Checked = false;
            txtNoiCap.Text = string.Empty;
        }

        public bool CheckInError()
        {
            var s = string.Empty;
            if (txtMaKhachTro.Text.Equals(string.Empty))
            {
                s = "Nhập vào mã khách trọ\n";
            }
            if (txtHoLot.Text.Equals(string.Empty))
            {
                s += "Nhập vào họ lót khách trọ\n";
            }
            if (txtTen.Text.Equals(string.Empty))
            {
                s += "Nhập vào tên khách trọ\n";
            }
            if (dateNgaySinh.EditValue.Equals(string.Empty))
            {
                s += "Nhập vào ngày sinh\n";
            }
            if (glkPhongCu.EditValue == null)
            {
                s += "Chọn phòng cũ\n";
            }
            if (glkPhongMoi.EditValue == null)
            {
                s += "Chọn phòng mới\n";
            }
            if (txtNoiCap.Text.Equals(string.Empty))
            {
                s += "Nhập vào nơi cấp CMND\n";
            }

            if (txtThuongTru.Text.Equals(string.Empty))
            {
                s += "Nhập vào thường trú\n";
            }
            if (txtTamTru.Text.Equals(string.Empty))
            {
                s += "Nhập vào tạm trú\n";
            }
            if (dateNgayVao.EditValue.Equals(string.Empty))
            {
                s += "Nhập vào ngày vào\n";
            }
            if (dateNgayRa.EditValue.Equals(string.Empty))
            {
                s += "Nhập vào ngày ra\n";
            }
            try
            {
                if (DateTime.Parse(dateNgayRa.EditValue.ToString()) < DateTime.Parse(dateNgayVao.EditValue.ToString()))
                {
                    s += "Ngày ra khỏi phải lớn hơn ngày vào\n";
                }
            }
            catch
            {
            }

            if (DateTime.Parse( dateNgaySinh.EditValue.ToString()) > DateTime.Today)
            {
                s += "Ngày sinh không thể lớn hơn ngày hiện tại\n";
            }
            try {
                if ((DateTime)dateNgayCap.EditValue > DateTime.Today)
                {
                    s += "Ngày cấp CMND không thể lớn hơn ngày hiện tại\n";
                }
            }
            catch{}
            try{
                if (DateTime.Parse(dateNgaySinh.EditValue.ToString())> DateTime.Today)
                {
                    s += "Ngày sinh không thể lớn hơn ngày hiện tại\n";
                }
            }
            catch{}
            try
            {
                if (DateTime.Parse(dateNgayCap.EditValue.ToString()) > DateTime.Today)
                {
                    s += "Ngày cấp CMND không thể lớn hơn ngày hiện tại\n";
                }
            }
            catch { }
            
            if (s != string.Empty)
            {
                XtraMessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValue();
            if (CheckInError() == false)
            {
                return;
            }

            if (cn == ChucNang.Them)
            {
                if (!ktb.KiemTraKhachTro(kt.MaKhachTro))
                {
                    XtraMessageBox.Show("Mã khách trọ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ktb.KiemTraSoNguoi(kt.MaPhong))
                {
                    XtraMessageBox.Show("Thêm không thành công. \nHãy chọn lại phòng vì phòng này đã đủ người.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (ktb.InsertKhachTro(kt))
                    {
                        XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Common.Delegates.GetList(ktb.ListDanhSachKhachTro());
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (ktb.UpdateKhachTro(kt))
                {
                    XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Common.Delegates.GetList(ktb.ListDanhSachKhachTro());
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("Sửa không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            GetValue();
            if (CheckInError() == false)
            {
                return;
            }
            if (cn == ChucNang.Them)
            {
                if (!ktb.KiemTraKhachTro(kt.MaKhachTro))
                {
                    XtraMessageBox.Show("Mã khách trọ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ktb.KiemTraSoNguoi(kt.MaPhong))
                {
                    XtraMessageBox.Show("Thêm không thành công. \nHãy chọn lại phòng vì phòng này đã đủ người.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (ktb.InsertKhachTro(kt))
                    {
                        XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Common.Delegates.GetList(ktb.ListDanhSachKhachTro());
                        Reset();
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (ktb.UpdateKhachTro(kt))
                {
                    XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Common.Delegates.GetList(ktb.ListDanhSachKhachTro());
                    Reset();
                    txtMaKhachTro.Properties.ReadOnly = false;
                    cn = ChucNang.Them;
                    Text = "Thêm Khách Trọ";
                }
                else
                {
                    XtraMessageBox.Show("Sửa không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            var re = XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
