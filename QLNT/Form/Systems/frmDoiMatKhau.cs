using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Common;
using QLNT.Business;
namespace SystemOption.Dialog
{
    public partial class ThayDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
     
        public ThayDoiMatKhau()
        {
            InitializeComponent();
            ///Khong cho thay doi kich thuoc
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
      
        void check_Info()
        {
          
            string mkc = txtMatKhauCu.Text, mkm = txtMatKhauMoi.Text;
            if(!mkm.Equals(txtNhapLaiMatKhau.Text))
            {
                XtraMessageBox.Show("Mật khẩu mới không trùng khớp");
                return ;
            }
            if(txtMatKhauMoi.Text.Length<=3)
            {
                XtraMessageBox.Show("Mật khẩu mới có độ dài phải lớn hơn 3 kí tự.");
                return;
            }
            // khai bao lay thong tin user len để so sánh
          
            RegistryFile.ReadRegistry();

            Systems_Bus users = new Systems_Bus();
            QLNT.LinQToSQL.SysUser us = users.GetUser(UserInfo.Account);

            if(users.KiemTraUser(us.TaiKhoan,mkc))
            {
                try {
                    // ham thay doi mk 
                    users.DoiMatKhauUser(us.TaiKhoan, mkm);                    
                    XtraMessageBox.Show("Thay đổi mật khẩu thành công.");
                   
                    // luu lại mk để cho lần đăng nhập sau này.                  
                    try
                    {
                       RegistryFile.GhiUser(UserInfo.Stt, UserInfo.Account,mkm, UserInfo.Skin);
                    }
                    catch { }
                    this.Close();
                }
                catch {
                    XtraMessageBox.Show("Có lỗi trong quá trình thực hiện thao tác.\nVui lòng thử lại sau.");
                }
            }
            else
            {
                XtraMessageBox.Show("Mật khẩu cũ không hợp lệ!\nVui lòng kiểm tra lại.");
                return;
            }

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            check_Info();
        }

        private void txtMatKhauCu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
                check_Info();
        }

        
           
    }
}