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

namespace QLNT.Form.DanhMuc
{
    public partial class frmDanToc : DevExpress.XtraEditors.XtraForm
    {
        bool err = false;
        DanToc dantoc = new DanToc();
        Business.DanTocBus dantocbus = new Business.DanTocBus();
        Common.ChucNang cn;
        public frmDanToc()
        {
            InitializeComponent();
        }
        public frmDanToc(Common.ChucNang cn, DanToc dantoc)
        {
            InitializeComponent();
            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                this.Text = "Thêm Dân tộc";
            }
            else
            {
                this.Text = "Sửa Dân tộc";
                this.dantoc = dantoc;
                GVupForm(this.dantoc);
            }
        }
        private void GVupForm(DanToc name)
        {
            txtTenDanToc.Text = name.TenDanToc;
            txtGhiChu.Text = name.GhiChu;
        }
        private void ResetItems()
        {
            txtTenDanToc.Text = "";
            txtGhiChu.Text = "";
            txtTenDanToc.Focus();
          
        }
        private void GetValueItems()
        {
            this.dantoc.TenDanToc = txtTenDanToc.Text;
            this.dantoc.GhiChu = txtGhiChu.Text;
        }

        private void txtTenDanToc_TextChanged(object sender, EventArgs e)
        {
            if (err != true)
            {
                if (txtTenDanToc.Text.Length == 0)
                {
                    errorProviderTen.SetIconAlignment(txtTenDanToc, ErrorIconAlignment.MiddleLeft);
                    errorProviderTen.SetError(txtTenDanToc, "Nhập tên dân tộc");
                }
                else
                {
                    errorProviderTen.SetError(txtTenDanToc, "");
                }
            }
        }

        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (dantocbus.KiemTraDanToc(dantoc.TenDanToc))
                {
                    XtraMessageBox.Show("Dân tộc này đã tồn tại, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dantocbus.InsertDanToc(dantoc))
                {
                    Common.Delegates.GetList(dantocbus.ListDanToc());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dantocbus.UpdateDanToc(this.dantoc))
                {
                    Common.Delegates.GetList(dantocbus.ListDanToc());
                    this.Close();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (dantocbus.KiemTraDanToc(dantoc.TenDanToc))
                {
                    XtraMessageBox.Show("Dân tộc này đã tồn tại, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dantocbus.InsertDanToc(dantoc))
                {
                    Common.Delegates.GetList(dantocbus.ListDanToc());
                    ResetItems();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dantocbus.UpdateDanToc(this.dantoc))
                {
                    Common.Delegates.GetList(dantocbus.ListDanToc());
                    ResetItems();
                }
                else XtraMessageBox.Show("Lưu không thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}