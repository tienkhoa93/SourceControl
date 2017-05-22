using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNT.Business;

namespace QLNT.Form.Khu
{
    public partial class frmKhu : DevExpress.XtraEditors.XtraForm
    {
        private Khu_Bus khb = new Khu_Bus();
        private LinQToSQL.Khu khu = new LinQToSQL.Khu();
        private Common.ChucNang cn;

        private bool err = false;

        public frmKhu()
        {
            InitializeComponent();
        }

        public frmKhu(Common.ChucNang cn, LinQToSQL.Khu khu)
        {
            InitializeComponent();
            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                Text = "Thêm Khu";
                txtMaKhu.Properties.ReadOnly = false;
            }
            else
            {
                Text = "Sửa Khu";
                txtMaKhu.Properties.ReadOnly = true;
                GVupForm(khu);
            }
        }
        public void checknull()
        {
            var st = string.Empty;
            if (txtMaKhu.Text.Length == 0)
            {
                st = st + "Nhập Mã khu\n";
            }
            if (txtTenKhu.Text.Length == 0)
            {
                st = st + "Nhập Tên khu\n";
            }
            if (st != string.Empty)
            {
                XtraMessageBox.Show(st, "Lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValueItems();
            checknull();
            if (cn == Common.ChucNang.Them)
            {
                if (khb.KiemTraKhu(khu.MaKhu, khu.TenKhu))
                {
                    XtraMessageBox.Show("Khu đã tồn tại, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    khb.InsertKhu(khu);
                    Common.Delegates.GetList(khb.GetAllKhu_Count());
                    Close();
                }
            }
            else
            {
                GVupForm(khu);
                khb.UpdateKhu(khu);
                Common.Delegates.GetList(khb.GetAllKhu_Count());
                Close();
            }
        }
        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (khb.KiemTraKhu(khu.MaKhu, khu.TenKhu))
                {
                    XtraMessageBox.Show("Khu đã tồn tại, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    khb.InsertKhu(khu);
                    Common.Delegates.GetList(khb.GetAllKhu_Count());
                    ResetItems();
                }
            }
            else
            {
                GVupForm(khu);
                khb.UpdateKhu(khu);
                Common.Delegates.GetList(khb.GetAllKhu_Count());
                txtMaKhu.Properties.ReadOnly = false;
                txtMaKhu.Select();
                ResetItems();
            }
        }

        public void ResetItems()
        {
            txtTenKhu.Text = string.Empty;
            txtMaKhu.Focus();
            txtMaKhu.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }
        public void GetValueItems()
        {
            khu.TenKhu = txtTenKhu.Text;
            khu.MaKhu = txtMaKhu.Text;
            khu.GhiChu = txtGhiChu.Text;
        }
        public void GVupForm(LinQToSQL.Khu khu)
        {
            txtMaKhu.Text = khu.MaKhu;
            txtTenKhu.Focus();
            txtTenKhu.Text = khu.TenKhu;
            txtGhiChu.Text = khu.GhiChu;
        }

        private void txtKhu_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKhu.Text.Length == 0 && err == false)
            {
                errorProviderMa.SetIconAlignment(txtMaKhu, ErrorIconAlignment.MiddleLeft);
                errorProviderMa.SetError(txtMaKhu, "Nhập mã khu");
            }
            else
            {
                errorProviderMa.SetError(txtMaKhu, string.Empty);
            }
        }

        private void txtTenKhu_TextChanged(object sender, EventArgs e)
        {
            if (err != true)
            {
                if (txtTenKhu.Text.Length == 0)
                {
                    errorProviderTen.SetIconAlignment(txtTenKhu, ErrorIconAlignment.MiddleLeft);
                    errorProviderTen.SetError(txtTenKhu, "Nhập tên khu");
                }
                else
                {
                    errorProviderTen.SetError(txtTenKhu, string.Empty);
                }
            }
        }
    }
}
