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
using QLNT.Business;
using QLNT.LinQToSQL;
namespace QLNT.Form.PhanQuyen
{
    public partial class frmThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        Common.ChucNang cn;
        
        SySNhomQuyen_Bus nqb = new SySNhomQuyen_Bus();
        SysNguoiDung_Bus ndb = new SysNguoiDung_Bus();
        SysUser user = new SysUser();
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }
        public frmThemNguoiDung(Common.ChucNang cn, LinQToSQL.SysUser user)
        {
            InitializeComponent();
            chkHoatDong.Checked = true;
            gridNhomQuyen.Properties.DisplayMember = "TenNhom";
            gridNhomQuyen.Properties.ValueMember = "MaNhom";
            gridNhomQuyen.Properties.DataSource =nqb.ListNhomQuyen();
            gridNhomQuyen.EditValue = gridNhomQuyen.Properties.GetKeyValue(0);
            chkHoatDong.Checked = true;
            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                this.Text = "Thêm người dùng";

            }
            else
            {
                this.Text = "Sửa người dùng";
                txtMaNguoiDung.Properties.ReadOnly = true;
                txtTaiKhoan.Properties.ReadOnly = true;
                this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                this.layoutControlItem2.Text = "Mật khẩu cũ";
                this.layoutControlItem2.Text = "Mật khẩu mới";
                GVupForm(user);
            }

        }
        private void ResetTextss()
        {
            txtMaNguoiDung.Text = "";
            txtTaiKhoan.Text = "";
            txtTenNguoiDung.Text = "";
            txtMatKhau.Text = "";
            txtMKNhapLai.Text = "";
            txtDienGiai.Text = "";
            gridNhomQuyen.EditValue = "";
            txtEmail.Text = "";
            chkHoatDong.Checked = true;
           
        }
        private void GVupForm(LinQToSQL.SysUser user)
        {
            txtMaNguoiDung.Text = user.ID.ToString();
            txtTaiKhoan.Text = user.TaiKhoan;
            txtTenNguoiDung.Text = user.HoTen;
            txtMatKhau.Text = "";
            txtMKNhapLai.Text = "";
            txtDienGiai.Text = user.DienGiai;
            gridNhomQuyen.EditValue = user.MaNhom;
            txtEmail.Text = user.Email;
            chkHoatDong.Checked = (bool)user.HoatDong;
        }
        public void GetValues()
        {
            user.ID = txtMaNguoiDung.Text;
            user.HoTen = txtTenNguoiDung.Text;
            user.TaiKhoan = txtTaiKhoan.Text;
            if(cn==Common.ChucNang.Them)
                user.MatKhau =Common.MaHoa.MaHoaMD5( txtMatKhau.Text);
            else
                user.MatKhau = Common.MaHoa.MaHoaMD5(txtMKNhapLai.Text);
            try{user.MaNhom = gridNhomQuyen.EditValue.ToString();}
            catch { user.MaNhom = string.Empty; }
            user.DienGiai = txtDienGiai.Text;
            user.Email = txtEmail.Text;
            user.HoatDong = (bool)chkHoatDong.Checked;
        }
        public bool KiemTraThongTin()
        {
            string s = "";
            if (txtMaNguoiDung.Text == string.Empty)
                s += "\nNhập mã người dùng";
            if (txtTaiKhoan.Text == string.Empty)
                s += "\nNhập tên tài khoản";
            if (cn == Common.ChucNang.Them)
            {
                if (txtMatKhau.Text == string.Empty)
                    s += "\nNhập mật khẩu";
                if (txtMKNhapLai.Text == string.Empty)
                    s += "\nNhập xác nhận mật khẩu";
            }
            else
            {
                if (txtMatKhau.Text == string.Empty)
                    s += "\nNhập vào mật khẩu cũ";
                if (txtMKNhapLai.Text == string.Empty)
                    s += "\nNhập vào mật khẩu mới";
                if (txtXacNhanMK.Text == string.Empty)
                    s += "\nXác nhận mật khẩu";
            }
            if(s!=string.Empty)
            {
                MessageBox.Show(s,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
           
            if (cn == Common.ChucNang.Sua)
            {

                if (ndb.SelectNguoiDung_MaTKhau(txtMatKhau.Text).Count == 0)
                {
                    MessageBox.Show("Mật khẩu cũ không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (txtXacNhanMK.Text != txtMKNhapLai.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (txtMatKhau.Text != txtMKNhapLai.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //else if (ndb.SelectNguoiDung(txtTaiKhoan.Text).Count > 0)
            //{
            //    MessageBox.Show("Tên tài khoản đã có người sử dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            return true;
            

        }

        private void btnLuuVaThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin() == false)
                return;
            GetValues();
            if (cn == Common.ChucNang.Them)
            {
                if (ndb.SelectNguoiDung(user.TaiKhoan).Count > 0)
                {
                    XtraMessageBox.Show("Tài khoản đã tồn tại, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                if (ndb.insertNguoiDung(user))
                {
                    Common.Delegates.GetList(ndb.ListNguoiDung());
                }

            }
            else
            {
                if (ndb.UpdateNguoiDung(user))
                {
                    Common.Delegates.GetList(ndb.ListNguoiDung());
                    this.Text = "Thêm người dùng";
                    this.layoutControlItem2.Text = "Mật khẩu";
                    this.layoutControlItem2.Text = "Xác nhận mật khẩu";
                    this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    ResetTextss();
                    txtXacNhanMK.Visible = false;
                    txtMaNguoiDung.Properties.ReadOnly = false;
                    txtTaiKhoan.Properties.ReadOnly = false;
                    this.cn = Common.ChucNang.Them;
                }
            }
        }

        private void btnLuuVaDong_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin() == false)
                return;
            GetValues();
            if (cn == Common.ChucNang.Them)
            {
                if (ndb.SelectNguoiDung(user.TaiKhoan).Count > 0)
                {
                    XtraMessageBox.Show("Tài khoản đã tồn tại, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                if (ndb.insertNguoiDung(user))
                {
                    Common.Delegates.GetList(ndb.ListNguoiDung());
                    this.Close();
                }

            }
            else
            {
                if (ndb.UpdateNguoiDung(user))
                {
                    Common.Delegates.GetList(ndb.ListNguoiDung());
                    this.Close();
                }
            }
            
        }
    }
}