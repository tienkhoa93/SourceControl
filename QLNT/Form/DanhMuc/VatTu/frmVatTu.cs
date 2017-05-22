using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLNT.Form.DanhMuc.VatTu
{
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        private Business.VatTuBus vtb = new Business.VatTuBus();
        private QLNT.LinQToSQL.VatTu vattu = new QLNT.LinQToSQL.VatTu();
        private Common.ChucNang cn;
        public frmVatTu()
        {
            InitializeComponent();
        }
        public frmVatTu(Common.ChucNang cn, QLNT.LinQToSQL.VatTu vattu)
        {
            InitializeComponent();
            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                Text = "Thêm Vật tư";
            }
            else
            {
                Text = "Sửa Vật tư";
                this.vattu = vattu;
                GVupForm(this.vattu);
            }
        }
        private void GVupForm(QLNT.LinQToSQL.VatTu name)
        {
            txtTenVatTu.Text = name.TenVatTu;
            txtGhiChu.Text = name.GhiChu;
        }
        private void ResetItems()
        {
            txtTenVatTu.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }
        private void GetValueItems()
        {
            vattu.TenVatTu = txtTenVatTu.Text;
            vattu.GhiChu = txtGhiChu.Text;
        }

        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (vtb.KiemTraVatTu(vattu.TenVatTu))
                {
                    XtraMessageBox.Show("Vật tư này đã tồn tại, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (vtb.InsertVatTu(vattu))
                {
                    Common.Delegates.GetList(vtb.ListVatTu());
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (vtb.UpdateVatTu(vattu))
                {
                    Common.Delegates.GetList(vtb.ListVatTu());
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (vtb.KiemTraVatTu(vattu.TenVatTu))
                {
                    XtraMessageBox.Show("Vật tư này đã tồn tại, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (vtb.InsertVatTu(vattu))
                {
                    Common.Delegates.GetList(vtb.ListVatTu());
                    ResetItems();
                }
                else
                {
                    XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (vtb.UpdateVatTu(vattu))
                {
                    Common.Delegates.GetList(vtb.ListVatTu());
                    ResetItems();
                }
                else
                {
                    XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
