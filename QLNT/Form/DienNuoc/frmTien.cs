using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLNT.LinQToSQL;

namespace QLNT.Form.DienNuoc
{
    public partial class frmTien : DevExpress.XtraEditors.XtraForm
    {
        private Tien tien = new Tien();
        private bool err = false;

        public frmTien()
        {
            InitializeComponent();
        }


        private void GetValueItems()
        {
            tien.MaPhong = txtMaSinhVien.Text;
            tien.MaLoaiTien = txtMaLoaiTien.Text;
            tien.NgayDong = DateTime.Parse(dateNgayDong.EditValue.ToString());
            tien.GhiChu = txtGhiChu.Text;
        }

        private void GVupForm(Tien name)
        {
            txtMaSinhVien.Text = name.MaPhong;
            txtMaLoaiTien.Text = name.MaLoaiTien;
            dateNgayDong.EditValue = name.NgayDong;
            txtGhiChu.Text = name.GhiChu;
        }

        private void ResetItems()
        {
            txtMaSinhVien.Text = string.Empty;
            txtMaLoaiTien.Text = string.Empty;
            dateNgayDong.EditValue = DateTime.Today;
            txtGhiChu.Text = string.Empty;
            txtMaLoaiTien.Focus();
        }



        private void txtMaSinhVien_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text.Length == 0 && err == false)
            {
                errorProviderMaSV.SetIconAlignment(txtMaSinhVien, ErrorIconAlignment.MiddleLeft);
                errorProviderMaSV.SetError(txtMaSinhVien, "Nhập mã sinh viên");
            }
            else
            {
                errorProviderMaSV.SetError(txtMaSinhVien, string.Empty);
            }
        }

        private void txtMaLoaiTien_TextChanged(object sender, EventArgs e)
        {
            if (txtMaLoaiTien.Text.Length == 0 && err == false)
            {
                errorProviderMaLoaiTien.SetIconAlignment(txtMaLoaiTien, ErrorIconAlignment.MiddleLeft);
                errorProviderMaLoaiTien.SetError(txtMaLoaiTien, "Nhập mã loại tiền");
            }
            else
            {
                errorProviderMaLoaiTien.SetError(txtMaLoaiTien, string.Empty);
            }
        }
    }
}
