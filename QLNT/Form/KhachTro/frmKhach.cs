using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNT.LinQToSQL;
using QLNT.Business;
using System.IO;

namespace QLNT.Form.KhachTro
{
    public partial class frmKhach : DevExpress.XtraEditors.XtraForm
    {
        //bool err = false;
        Khach khachk = new Khach();
        QLNTDataContext db = new QLNTDataContext();
        KhachTro_Bus ktb = new KhachTro_Bus();
        Business.KhachBus khachbus = new Business.KhachBus();
        Common.ChucNang cn;
        public frmKhach()
        {
            InitializeComponent();
            LoadDataToGrid();

        }
        public frmKhach(Common.ChucNang cn, Khach khach)
        {
            InitializeComponent();

            LoadDataToGrid();

            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                this.Text = "Thêm Khách qua đêm";
            }
            else
            {
                this.Text = "Sửa Khách qua đêm";
                this.khachk = khach;
                GVupForm(this.khachk);
            }
        }

        private void LoadDataToGrid()
        {
            Phong_Bus pb = new Phong_Bus();
            glkPhong.Properties.DisplayMember = "TenPhong";
            glkPhong.Properties.ValueMember = "MaPhong";
            glkPhong.Properties.DataSource = pb.ListPhong();


            glkKhachTro.Properties.DisplayMember = "HoTen";
            glkKhachTro.Properties.ValueMember = "MaKhachTro";
            glkKhachTro.Properties.DataSource = ktb.ListDanhSachKhachTro();
            if (cn == Common.ChucNang.Them)
            {
                glkKhachTro.EditValue = glkKhachTro.Properties.GetKeyValue(0);
            }

            txtNgaySinh.EditValue = DateTime.Today;
            txtNgayCap.EditValue = DateTime.Today;
            txtNgayVao.EditValue = DateTime.Today;
            txtNgayRa.EditValue = DateTime.Today.AddDays(1);
            txtGioVao.EditValue = DateTime.Now;
            txtGioRa.EditValue = DateTime.Now.AddHours(24);
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void GVupForm(Khach name)
        {
            txtMaKhach.Text = name.MaKhach;
            txtHoLot.Text = name.HoLot;
            txtTen.Text = name.Ten;
            try
            {
                var img = (from image in db.Khaches
                           where image.MaKhach == name.MaKhach
                           select image).Single();
                picAnh.Image = ByteArrayToImage(img.Anh.ToArray());
            }
            catch
            {
                picAnh.Image = null;
            }

            glkKhachTro.EditValue = name.MaKhachTro;
            glkPhong.EditValue = name.MaPhong;
            txtNgaySinh.EditValue = name.NgaySinh;
            txtNoiSinh.Text = name.NoiSinh;
            txtCMND.Text = name.CMND;
            txtNoiCap.Text = name.NoiCap;
            txtNgayCap.EditValue = name.NgayCap;
            txtNgayVao.EditValue = name.NgayVao;
            txtGioVao.EditValue = name.GioVao;
            txtNgayRa.EditValue = name.NgayRa;
            txtGioRa.EditValue = name.GioRa;
            txtGhiChu.Text = name.GhiChu;
        }
        private void ResetItems()
        {
            txtMaKhach.Text = string.Empty;
            txtHoLot.Text = string.Empty;
            txtTen.Text = string.Empty;
            picAnh.Image = null;
            txtNoiCap.Text = string.Empty;
            txtNoiSinh.Text = string.Empty;
            glkKhachTro.Properties.DataSource = ktb.ListDanhSachKhachTro();

            txtGhiChu.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtNgaySinh.EditValue = DateTime.Today;
            txtNgayCap.EditValue = DateTime.Today;
            txtNgayVao.EditValue = DateTime.Today;
            txtNgayRa.EditValue = DateTime.Today.AddDays(1);
            txtGioVao.EditValue = DateTime.Now;
            txtGioRa.EditValue = DateTime.Now.AddHours(24);

        }
        private void GetValueItems()
        {
            this.khachk.MaKhach = txtMaKhach.Text;
            this.khachk.HoLot = txtHoLot.Text;
            this.khachk.Ten = txtTen.Text;

            try
            {
                Image a = picAnh.Image;
                MemoryStream ms = new MemoryStream();
                a.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img = ms.ToArray();
                this.khachk.Anh = img;
            }
            catch { this.khachk.Anh = null; }

            this.khachk.MaKhachTro = glkKhachTro.EditValue.ToString();
            this.khachk.MaPhong = glkPhong.EditValue.ToString();
            this.khachk.NgaySinh = Convert.ToDateTime(txtNgaySinh.EditValue);
            this.khachk.NgayCap = Convert.ToDateTime(txtNgayCap.EditValue);
            //  this.khachk. = Convert.ToDateTime(txtNgayCap.EditValue);
            this.khachk.NoiSinh = txtNoiSinh.Text;
            this.khachk.NoiCap = txtNoiCap.Text;
            this.khachk.CMND = txtNoiCap.Text;
            this.khachk.NgayVao = Convert.ToDateTime(txtNgayVao.EditValue);
            this.khachk.NgayRa = Convert.ToDateTime(txtNgayRa.EditValue);

            this.khachk.GioVao = Convert.ToDateTime(txtGioVao.EditValue);
            this.khachk.GioRa = Convert.ToDateTime(txtGioRa.EditValue);
            this.khachk.GhiChu = txtGhiChu.Text;
            this.khachk.HoatDong = true;

        }


        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                //if (khachbus.KiemTraDanToc(khachk.TenDanToc))
                //{
                //    XtraMessageBox.Show("Khách này đã tồn tại, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                if (khachbus.InsertKhach(khachk))
                {
                    Common.Delegates.GetList(khachbus.DanhSachKhach());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (khachbus.UpdateKhach(this.khachk))
                {
                    Common.Delegates.GetList(khachbus.DanhSachKhach());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            //GetValueItems();
            //if (cn == Common.ChucNang.Them)
            //{
            //    if (dantocbus.KiemTraDanToc(khachk.TenDanToc))
            //    {
            //        XtraMessageBox.Show("Dân tộc này đã tồn tại, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    if (dantocbus.InsertDanToc(khachk))
            //    {
            //        Common.Delegates.GetList(dantocbus.ListDanToc());
            //        ResetItems();
            //    }
            //    else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    if (dantocbus.UpdateDanToc(this.khachk))
            //    {
            //        Common.Delegates.GetList(dantocbus.ListDanToc());
            //        ResetItems();
            //    }
            //    else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void glkKhachTro_EditValueChanged(object sender, EventArgs e)
        {
            if (cn == Common.ChucNang.Them)
            {
                // string makhachtro=  (glkKhachTro.EditValue.ToString());
                List<Business._KhachTro> l = (List<Business._KhachTro>)glkKhachTro.Properties.DataSource;
                glkPhong.EditValue = l.Find(item => item.MaKhachTro == glkKhachTro.EditValue.ToString()).MaPhong;

            }
        }
    }
}