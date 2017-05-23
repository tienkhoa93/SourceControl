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
using System.Data.Linq;
using QLNT.LinQToSQL;
using QLNT.Business;
namespace QLNT.Form.PhongBan
{
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        Phong phong = new Phong();
        Common.ChucNang cn;
        Options_Bus op = new Options_Bus();
        Phong_Bus phongbus = new Phong_Bus();
        bool err = false;
        string mpc = string.Empty;
        #region Contructor
        public frmPhongBan(Common.ChucNang cn, Phong pg)
        {
            InitializeComponent();
            this.cn = cn;
            try
            {  // đổ giữ liệu lên grid khu
                Khu_Bus khu = new Khu_Bus();
                gluKhu.Properties.DataSource = khu.GetAllKhu();
            }
            catch { }

            if (cn == Common.ChucNang.Them)
            {
                this.Text = "Thêm Phòng Ban";
                txtMaPhong.Properties.ReadOnly = false;
                txtMaPhong.Select();
            }
            else
            {
                this.Text = "Sửa Phòng Ban";
                mpc = pg.MaPhong;
                txtMaPhong.Properties.ReadOnly = true;
                phong = pg;
                GVupForm(pg);
            }

        }
        #endregion
        #region Get dữ liệu các form
        private void GetValueItems()
        {
            phong.MaPhong = txtMaPhong.Text == null ? null : txtMaPhong.Text;
            phong.MaKhu = gluKhu.EditValue.ToString() == null ? null : gluKhu.EditValue.ToString();
            try { phong.GiaPhong = double.Parse(calGiaPhong.EditValue.ToString()); }
            catch { phong.GiaPhong = 0; }
            phong.TenPhong = txtTenPhong.Text == null ? null : txtTenPhong.Text;
            try { phong.SoNguoi = int.Parse(calSoNguoi.EditValue.ToString()); }
            catch { phong.SoNguoi = 0; }
            phong.GhiChu = txtGhiChu.Text == null ? String.Empty : txtGhiChu.Text;
            if (chkQuanLy.Checked == true)
            {
                phong.HoatDong = true;
            }
            else { phong.HoatDong = false; }
            try
            {
                phong.TongNguoi = int.Parse(calTongSoNguoi.EditValue.ToString());
            }
            catch { }
            try {
            phong.TuNgay = (DateTime)dateTuNgay.EditValue;
            phong.ToiNgay = (DateTime)dateToiNgay.EditValue;
            }
            catch { }
        }

        private void GVupForm(Phong name)
        {
            txtMaPhong.Text = name.MaPhong;
            gluKhu.EditValue = name.MaKhu;
            txtTenPhong.Text = name.TenPhong;
            calSoNguoi.EditValue = name.SoNguoi;
            calGiaPhong.EditValue = name.GiaPhong;
            if (name.HoatDong == true)
            {
                chkQuanLy.Checked = true;
            }
            else { chkQuanLy.Checked = false; }
            txtGhiChu.Text = name.GhiChu;
            calTongSoNguoi.EditValue = name.TongNguoi;
            dateTuNgay.EditValue = name.TuNgay;
            dateToiNgay.EditValue = name.ToiNgay;
        }
        private void ResetItems()
        {
            txtMaPhong.Properties.ReadOnly = false;
            this.Text = "Thêm Phòng Ban";
            txtMaPhong.Text = String.Empty;
            gluKhu.EditValue = String.Empty;
            txtTenPhong.Text = String.Empty;
            txtGhiChu.Text = String.Empty;
            calGiaPhong.EditValue = "";
            calSoNguoi.EditValue = "";
            chkQuanLy.Checked = false;
            calTongSoNguoi.EditValue = null;
            dateTuNgay.EditValue = null;
            dateToiNgay.EditValue = null;
            txtMaPhong.Focus();
        }
        #endregion
        #region Kiểm tra giữ liệu trên form


        /// <summary>
        /// Kiểm tra thông tin nhập trên form
        /// </summary>
        /// <returns></returns>
        bool CheckInfor()
        {
            string s = "";
            float tmp=0;
            if (txtMaPhong.Text.Equals("") || txtTenPhong.Text.Equals(""))
            {
                s = "Nhập đầy đủ mã phòng và tên phòng\n";
            }
            if (gluKhu.EditValue == null)
            {
                s += "Chọn Khu cho phòng\n";
            }
            try
            {
                tmp =float.Parse( calGiaPhong.EditValue.ToString());
                if (tmp < 0)
                    s += "Giá phòng phải > 0\n";
                tmp = float.Parse(calSoNguoi.EditValue.ToString());
                if (tmp < 0)
                    s += "Số người phải > 0\n";
                tmp = float.Parse(calSoNguoi.EditValue.ToString());
                if (tmp < 0)
                    s += "Tổng số người phải > 0\n";
                
            }catch{}
            if (s != "")
            {
                XtraMessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
        #region Bắt lỗi trên form
        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Length == 0 && err == false)
            {
                errorProviderMaPhong.SetIconAlignment(txtMaPhong, ErrorIconAlignment.MiddleLeft);
                errorProviderMaPhong.SetError(txtMaPhong, "Nhập mã phòng");
            }
            else
            {
                errorProviderMaPhong.SetError(txtMaPhong, "");
            }
        }

        private void txtMaKhu_TextChanged(object sender, EventArgs e)
        {
            if (gluKhu.Properties.DisplayMember.Length == 0 && err == false)
            {
                errorProviderMaKhu.SetIconAlignment(gluKhu, ErrorIconAlignment.MiddleLeft);
                errorProviderMaKhu.SetError(gluKhu, "Nhập mã khu");
            }
            else
            {
                errorProviderMaKhu.SetError(gluKhu, "");
            }
            err = false;
        }

        private void txtTenPhong_TextChanged(object sender, EventArgs e)
        {

            if (txtTenPhong.Text.Length == 0 && err == false)
            {
                errorProviderTenPhong.SetIconAlignment(txtTenPhong, ErrorIconAlignment.MiddleLeft);
                errorProviderTenPhong.SetError(txtTenPhong, "Nhập tên phòng");
            }
            else
            {
                errorProviderTenPhong.SetError(txtTenPhong, "");
            }
            err = false;
        }
        #endregion
        #region Su kien cac button
        #region Luu Dong
        /// <summary>
        /// Luu xong dong form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            if (!CheckInfor()) return;

            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (phongbus.KiemTraPhong(phong.MaPhong))
                {
                    XtraMessageBox.Show("Phòng ban đã tồn tại hãy chọn phòng ban khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (phongbus.InsertPhong(phong))
                {
                    Common.Delegates.GetList(phongbus.ListPhong());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (phongbus.UpdatePhong(phong))
                {
                    Common.Delegates.GetList(phongbus.ListPhong());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Luu và thêm


        /// <summary>
        /// Luu xong xoa thong tin tren form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuuVaThem_Click(object sender, EventArgs e)
        {
            err = true;
            if (!CheckInfor()) return;
            GetValueItems();

            if (cn == Common.ChucNang.Them)
            {
                if (phongbus.KiemTraPhong(phong.MaPhong))
                {
                    XtraMessageBox.Show("Phòng ban đã tồn tại hãy chọn phòng ban khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (phongbus.InsertPhong(phong))
                {
                    Common.Delegates.GetList(phongbus.ListPhong());
                    ResetItems();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (phongbus.UpdatePhong(phong))
                {
                    Common.Delegates.GetList(phongbus.ListPhong());
                    ResetItems();
                    txtMaPhong.Properties.ReadOnly = false;
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Đóng
        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            DialogResult re = XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
                this.Close();
        }
        #endregion

        private void gluKhu_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "btnKhu")
            {
                Form.Khu.frmKhu khu = new Khu.frmKhu();
                khu.ShowDialog();
            }

        }

        #endregion

    }
}