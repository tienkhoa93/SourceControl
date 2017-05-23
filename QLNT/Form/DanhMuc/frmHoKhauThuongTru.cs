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
using System.Data.Linq;
using Common;
using QLNT.Business;

namespace QLNT.Form.DanhMuc
{
    public partial class frmHoKhauThuongTru : DevExpress.XtraEditors.XtraForm
    {
        QLNTDataContext db = new QLNTDataContext();
        HoKhauThuongTru hktt = new HoKhauThuongTru();
        HoKhauThuongTruBus hkttb = new HoKhauThuongTruBus();
        bool err = false;
        ChucNang cn;

        public frmHoKhauThuongTru()
        {
            InitializeComponent();
        }

        public frmHoKhauThuongTru(ChucNang cn, HoKhauThuongTru hktt)
        {
            InitializeComponent();
            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                this.Text = "Thêm Hộ khẩu thường trú";
            }
            else
            {
                this.Text = "Sửa Hộ khẩu thường trú";
                this.hktt = hktt;
                GVupForm(this.hktt);
            }
        }

        #region Get dữ  liệu lên form
        private void GetValueItems()
        {
            this.hktt.TenHoKhau = txtTenHoKhau.Text;
            this.hktt.GhiChu = txtGhiChu.Text;
        }

        private void GVupForm(HoKhauThuongTru name)
        {
            txtTenHoKhau.Text = name.TenHoKhau;
            txtGhiChu.Text = name.GhiChu;
        }

        private void ResetItems()
        {
            txtTenHoKhau.Text = "";
            txtGhiChu.Text = "";
            txtTenHoKhau.Focus();
        } 
        #endregion
        #region Bắt lỗi trên form

        private void txtTenHoKhau_TextChanged(object sender, EventArgs e)
        {
            if (err != true)
            {
                if (txtTenHoKhau.Text.Length == 0)
                {
                    errorProviderTen.SetIconAlignment(txtTenHoKhau, ErrorIconAlignment.MiddleLeft);
                    errorProviderTen.SetError(txtTenHoKhau, "Nhập tên hộ khẩu");
                }
                else
                {
                    errorProviderTen.SetError(txtTenHoKhau, "");
                }
            }
        } 
        #endregion

        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == ChucNang.Them)
            {
                if (hkttb.KiemTraHoKhau(hktt.TenHoKhau))
                {
                    XtraMessageBox.Show("Hộ khẩu thường trú đã tồn tại hãy chọn hộ khẩu thường trú khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (hkttb.InsertHoKhau(hktt))
                {
                    Common.Delegates.GetList(hkttb.ListHoKhauThuongTru());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hkttb.UpdateHoKhau(this.hktt))
                {
                    Common.Delegates.GetList(hkttb.ListHoKhauThuongTru());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (hkttb.KiemTraHoKhau(hktt.TenHoKhau))
                {
                    XtraMessageBox.Show("Hộ khẩu thường trú đã tồn tại hãy chọn hộ khẩu thường trú khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (hkttb.InsertHoKhau(hktt))
                {
                    Common.Delegates.GetList(hkttb.ListHoKhauThuongTru());
                    ResetItems();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hkttb.UpdateHoKhau(this.hktt))
                {
                    Common.Delegates.GetList(hkttb.ListHoKhauThuongTru());
                    ResetItems();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}