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

namespace QLNT.Form.DienNuoc
{
    public partial class frmThongTinDongTien : DevExpress.XtraEditors.XtraForm
    {
        ThongTinDongTien tttd = new ThongTinDongTien();
        bool err = false;
        Business.Tien_Buss tnb = new Business.Tien_Buss();
        Common.ChucNang cn;
        public frmThongTinDongTien()
        {
            InitializeComponent();
        }
        public frmThongTinDongTien(Common.ChucNang cn,LinQToSQL.ThongTinDongTien tt)
        {
            InitializeComponent();
            this.cn=cn;
            if (this.cn == Common.ChucNang.Them)
            {
                this.Text = "Thêm Khoản Phí";
            
            }
            else {
                    this.Text = "Sửa Khoản Phí";
                    txtMaLoaiTien.Properties.ReadOnly = true;
                    GVupForm(tt);
            }
        }

        #region Get dữ liệu các form
        private bool GetValueItems()
        {
            if (txtMaLoaiTien.Text.Equals(null) || txtMaLoaiTien.Text.Equals(""))
            {
                XtraMessageBox.Show("Nhập mã loại tiền đóng.");
                return false;
            }
            tttd.TenLoaiTien = txtTenTienDong.Text;
            tttd.MaLoaiTien = txtMaLoaiTien.Text;
            tttd.SoTienDong = double.Parse(calSoTienDong.EditValue.ToString());
            tttd.GhiChu = txtGhiChu.Text;
            return true;
        }

        private void GVupForm(ThongTinDongTien name)
        {
            txtTenTienDong.Text = name.TenLoaiTien;
            txtMaLoaiTien.Text = name.MaLoaiTien;
            calSoTienDong.EditValue = name.SoTienDong;
            txtGhiChu.Text = name.GhiChu;
        }

        private void ResetItems()
        {
            txtMaLoaiTien.Text = String.Empty;
            txtTenTienDong.Text = string.Empty;
            calSoTienDong.EditValue = String.Empty;
            txtGhiChu.Text = String.Empty;
            calSoTienDong.Focus();
            txtMaLoaiTien.Properties.ReadOnly = false;
            this.cn = Common.ChucNang.Them;
        } 
        #endregion

        #region Bắt lỗi các form
        private void txtMaLoaiTien_TextChanged(object sender, EventArgs e)
        {
            if (txtMaLoaiTien.Text.Length == 0 && err == false)
            {
                errorProviderMa.SetIconAlignment(txtMaLoaiTien, ErrorIconAlignment.MiddleLeft);
                errorProviderMa.SetError(txtMaLoaiTien, "Nhập mã loại tiền");
            }
            else
            {
                errorProviderMa.SetError(txtMaLoaiTien, "");
            }
        } 
        #endregion

        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            if(GetValueItems())
                if(this.cn==Common.ChucNang.Them)
                {
                    if (tnb.InsertThongTinTien(tttd))
                        {
                            Common.Delegates.GetList(tnb.ListThongTinTien());
                            this.Close();
                        }
                }
                else
                {

                    tnb.UpdateThongTinTien(tttd);
                    Common.Delegates.GetList(tnb.ListThongTinTien());
                    this.Close();

                }
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            if (GetValueItems())
                if (this.cn == Common.ChucNang.Them)
                {
                    if (tnb.InsertThongTinTien(tttd))
                    {
                        Common.Delegates.GetList(tnb.ListThongTinTien());
                        ResetItems();
                    }
                }
                else
                {

                   if( tnb.UpdateThongTinTien(tttd))
                   Common.Delegates.GetList(tnb.ListThongTinTien());
                    ResetItems();

                }

        }
    }
}