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

namespace QLNT.Form.DanhMuc
{
    public partial class frmHinhThucKyLuat : DevExpress.XtraEditors.XtraForm
    {

        HinhThucKyLuat htkl = new HinhThucKyLuat();
        Business.KyLuat_Bus klb = new Business.KyLuat_Bus();
        bool err = false;
        Common.ChucNang cn;
        public frmHinhThucKyLuat()
        {
            InitializeComponent();
        }
        public frmHinhThucKyLuat(Common.ChucNang cn, HinhThucKyLuat htkl)
        {
            InitializeComponent();
            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                this.Text = "Thêm Hình Thức Kỷ Luật";
            }
            else
            {
                this.htkl.id = htkl.id;
                this.Text = "Sửa Hình Thức Kỷ Luật";
                GVupForm(htkl);
            }
        }

        #region Get dữ liệu cho form
        private void GetValueItems()
        {
            htkl.MaHinhThucKyLuat = txtMaHinhThucKyLuat.Text;
            htkl.TenHinhThucKyLuat = txtTenHinhThucKyLuat.Text;
            htkl.GhiChu = txtGhiChu.Text;
        }

        private void GVupForm(HinhThucKyLuat name)
        {
            txtMaHinhThucKyLuat.Text = name.MaHinhThucKyLuat;
            txtTenHinhThucKyLuat.Text = name.TenHinhThucKyLuat;
            txtGhiChu.Text = name.GhiChu;
        }

        private void ResetItems()
        {
            txtMaHinhThucKyLuat.Text = "";
            txtTenHinhThucKyLuat.Text = "";
            txtGhiChu.Text = "";
            txtMaHinhThucKyLuat.Focus();
            this.Text = "Thêm Hình Thức Kỷ Luật";
            this.cn = Common.ChucNang.Them;
        }
        #endregion
        #region bắt lỗi


        private void txtMaHinhThucKyLuat_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHinhThucKyLuat.Text.Length == 0 && err == false)
            {
                errorProviderMa.SetIconAlignment(txtMaHinhThucKyLuat, ErrorIconAlignment.MiddleLeft);
                errorProviderMa.SetError(txtMaHinhThucKyLuat, "Nhập mã hình thức kỷ luật");
            }
            else
            {
                errorProviderMa.SetError(txtMaHinhThucKyLuat, "");
            }
        }

        private void txtTenHinhThucKyLuat_TextChanged(object sender, EventArgs e)
        {
            if (err != true)
            {
                if (txtTenHinhThucKyLuat.Text.Length == 0)
                {
                    errorProviderTen.SetIconAlignment(txtTenHinhThucKyLuat, ErrorIconAlignment.MiddleLeft);
                    errorProviderTen.SetError(txtTenHinhThucKyLuat, "Nhập tên hình thức kỷ luật");
                }
                else
                {
                    errorProviderTen.SetError(txtTenHinhThucKyLuat, "");
                }
            }
        }
        #endregion
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (klb.CheckHTKL(htkl.MaHinhThucKyLuat))
                {
                    if (klb.InsertHTKL(htkl))
                        XtraMessageBox.Show("Thêm thành công.");
                    Common.Delegates.GetList(klb.ListHinhThucKyLuat());
                    this.Close();
                }
                else XtraMessageBox.Show("Mã hình thức kỷ luật đã tồn tại.");

            }
            else
            {
                if (klb.CheckSuaHTKL(htkl.id, htkl.MaHinhThucKyLuat))
                {
                    if (klb.UpdateHTKL(htkl))
                    {

                        XtraMessageBox.Show("Sửa thành công thành công.");
                        Common.Delegates.GetList(klb.ListHinhThucKyLuat());
                        this.Close();
                    }
                }
                else XtraMessageBox.Show("Mã hình thức kỷ luật đã tồn tại.");
            }



        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            GetValueItems();
            if (cn == Common.ChucNang.Them)
            {
                if (klb.CheckHTKL(htkl.MaHinhThucKyLuat))
                {
                    if (klb.InsertHTKL(htkl))
                        XtraMessageBox.Show("Thêm thành công.");
                    Common.Delegates.GetList(klb.ListHinhThucKyLuat());

                }
                else XtraMessageBox.Show("Mã hình thức kỷ luật đã tồn tại.");

            }
            else
            {
                if (klb.CheckSuaHTKL(htkl.id, htkl.MaHinhThucKyLuat))
                {
                    if (klb.UpdateHTKL(htkl))
                    {

                        XtraMessageBox.Show("Sửa thành công thành công.");
                        Common.Delegates.GetList(klb.ListHinhThucKyLuat());
                        this.Close();
                    }
                }
                else XtraMessageBox.Show("Mã hình thức kỷ luật đã tồn tại.");
            }
            ResetItems();
        }



    }
}