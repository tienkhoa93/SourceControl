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
using Common;
using QLNT.Business;

namespace QLNT.Form.DanhMuc
{
    public partial class frmTrangThai : DevExpress.XtraEditors.XtraForm
    {
        TrangThai trangthai = new TrangThai();
        TinhTrangBus trangthaibus = new TinhTrangBus();
        bool err = false;
        ChucNang cn;

        #region CONTRUCTOR
        public frmTrangThai()
        {
            InitializeComponent();
        }
        public frmTrangThai(ChucNang cn, TrangThai tt)
        {
            InitializeComponent();
            this.cn = cn;
            if (cn == ChucNang.Them)
            {
                this.Text = "Thêm Trạng thái";
            }
            else
            {
                this.Text = "Sửa Trạng thái";
                this.trangthai = tt;
                GVupForm(this.trangthai);
            }
        }
        #endregion
        #region Get dữ liệu các form
        private void GetValueItems()
        {
            this.trangthai.TenTrangThai = txtTenTrangThai.Text;
            this.trangthai.GhiChu = txtGhiChu.Text;
        }

        private void GVupForm(TrangThai name)
        {
            txtTenTrangThai.Text = name.TenTrangThai;
            txtGhiChu.Text = name.GhiChu;
        }

        private void ResetItems()
        {
            txtTenTrangThai.Text = "";
            txtGhiChu.Text = "";
            txtTenTrangThai.Focus();
        }
        #endregion
        #region Bắt lỗi trên các form

        private void txtTenTrangThai_TextChanged(object sender, EventArgs e)
        {
            if (err != true)
            {
                if (txtTenTrangThai.Text.Length == 0)
                {
                    errorProviderTen.SetIconAlignment(txtTenTrangThai, ErrorIconAlignment.MiddleLeft);
                    errorProviderTen.SetError(txtTenTrangThai, "Nhập tên trạng thái");
                }
                else
                {
                    errorProviderTen.SetError(txtTenTrangThai, "");
                }
            }
        }
        #endregion
        #region Sự kiện các nút
        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == ChucNang.Them)
            {
                if (trangthaibus.KiemTraTinhTarang(trangthai.TenTrangThai))
                {
                    XtraMessageBox.Show("Trạng thái đã tồn tại hãy chọn trạng thái khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (trangthaibus.InsertTinhTrang(trangthai))
                {
                    Delegates.GetList(trangthaibus.ListTinhTrang());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (trangthaibus.UpdateTinhTrang(this.trangthai))
                {
                    Delegates.GetList(trangthaibus.ListTinhTrang());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == ChucNang.Them)
            {
                if (trangthaibus.KiemTraTinhTarang(trangthai.TenTrangThai))
                {
                    XtraMessageBox.Show("Trạng thái đã tồn tại hãy chọn trạng thái khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (trangthaibus.InsertTinhTrang(trangthai))
                {
                    Delegates.GetList(trangthaibus.ListTinhTrang());
                    ResetItems();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (trangthaibus.UpdateTinhTrang(this.trangthai))
                {
                    Delegates.GetList(trangthaibus.ListTinhTrang());
                    ResetItems();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}