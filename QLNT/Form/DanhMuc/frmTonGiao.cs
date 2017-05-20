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
    public partial class frmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        bool err = false;
        TonGiao tongiao = new TonGiao();
        TonGiaoBus tongiaobus = new TonGiaoBus();
        ChucNang cn;

        #region CONTRUCTOR
        public frmTonGiao()
        {
            InitializeComponent();
        }

        public frmTonGiao(ChucNang cn, TonGiao tg)
        {
            InitializeComponent();
            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                this.Text = "Thêm Tôn giáo";
            }
            else
            {
                this.Text = "Sửa Tôn giáo";
                this.tongiao = tg;
                GVupForm(this.tongiao);
            }
        }
        #endregion
        #region Get dữ liệu lên form
        private void GetValueItems()
        {
            this.tongiao.TenTonGiao = txtTenTonGiao.Text;
            this.tongiao.GhiChu = txtGhiChu.Text;
        }

        private void GVupForm(TonGiao name)
        {
            txtTenTonGiao.Text = name.TenTonGiao;
            txtGhiChu.Text = name.GhiChu;
        }

        private void ResetItems()
        {
            txtTenTonGiao.Text = "";
            txtGhiChu.Text = "";
            txtTenTonGiao.Focus();
        }
        #endregion
        #region Bắt lỗi trên form

        private void txtTenTonGiao_TextChanged(object sender, EventArgs e)
        {
            if (err != true)
            {
                if (txtTenTonGiao.Text.Length == 0)
                {
                    errorProviderTen.SetIconAlignment(txtTenTonGiao, ErrorIconAlignment.MiddleLeft);
                    errorProviderTen.SetError(txtTenTonGiao, "Nhập tên tôn giáo");
                }
                else
                {
                    errorProviderTen.SetError(txtTenTonGiao, "");
                }
            }
        }
        #endregion
        #region Sự kiện các nút
        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (tongiaobus.KiemTraTonGiao(tongiao.TenTonGiao))
                {
                    XtraMessageBox.Show("Tôn giáo đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (tongiaobus.InsertTongGiao(tongiao))
                {
                    Common.Delegates.GetList(tongiaobus.ListTonGiao());
                    ResetItems();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tongiaobus.UpdateTonGiao(this.tongiao))
                {
                    Common.Delegates.GetList(tongiaobus.ListTonGiao());
                    ResetItems();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == ChucNang.Them)
            {
                if (tongiaobus.KiemTraTonGiao(tongiao.TenTonGiao))
                {
                    XtraMessageBox.Show("Tôn giáo đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (tongiaobus.InsertTongGiao(tongiao))
                {
                    Common.Delegates.GetList(tongiaobus.ListTonGiao());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tongiaobus.UpdateTonGiao(this.tongiao))
                {
                    Common.Delegates.GetList(tongiaobus.ListTonGiao());
                    this.Close();
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