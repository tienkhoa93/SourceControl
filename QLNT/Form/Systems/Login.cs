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
using Common;
using QLNT.LinQToSQL;
using System.Data.Linq;
using QLNT.Business;
using DevExpress.XtraSplashScreen;
using System.Threading;
using System.Net.NetworkInformation;
namespace QLNT.Form.Systems
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {

        DataInfo dtinfo;
        public bool login = false;

        int temp = 0;
        public Login()
        {
            InitializeComponent();
            // code Don't resize form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #region form loaded

        /// <summary>
        /// Sự kiện form loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            RegistryFile.ReadRegistry();
            if (UserInfo.Stt == true)
            {
                txtTaiKhoan.Text = UserInfo.Account;
                txtPassWord.Text = UserInfo.Pass;
            }
        }
        #endregion
        #region Luu tai khoan mk
        void LuuTkMK()
        {
            RegistryFile.GhiUser((chkGhiNhoMK.Checked == true) ? true : false, txtTaiKhoan.Text, txtPassWord.Text, null);
        }
        #endregion
        #region Kiem tra tai khoan nhap vao
        bool TestAcc()
        {
            if (txtTaiKhoan.Text.Length < 3 || txtPassWord.Text.Length < 3)
            {
                XtraMessageBox.Show("Tài khoản và mật khẩu nhập vào phải có độ dài lớn hơn 3.");
                return false;
            }
            Systems_Bus Users = new Systems_Bus();
            // Ham KiemTraUser tra ve true neu ton tai user. va nguoc lai    
            if (!Users.KiemTraUser(txtTaiKhoan.Text, txtPassWord.Text))
            {
                XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng vui lòng thử lại.");
                ++temp;
                if (temp == 5)
                {
                    XtraMessageBox.Show("Bạn đã đăng nhập quá nhiều vui lòng thử lại sau.");
                    Application.Exit();
                }
                return false;
            }
            temp = 0;
            return true;
        }
        #endregion
        #region Event some button
        #region Event button thiet lap


        private void btnThietLap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetConnect scn = new frmSetConnect();
            scn.ShowDialog();
            this.Show();
        }
        #endregion
        #region event button close
        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region event button login
        void LoginClick()
        {

            try
            {
                dtinfo = DataXml.ReadXmlFile();
                System.Data.Linq.DataContext db = new System.Data.Linq.DataContext(dtinfo.ConnectStr);
                db.Connection.Open();
            }
            catch
            {

                this.Hide();
                frmSetConnect scn = new frmSetConnect();
                scn.ShowDialog();
                this.Show();
                return;
            }
            if (!TestAcc())
            {
                return;
            }
            else
            {
                LuuTkMK();
                UserInfo.Account = txtTaiKhoan.Text;
                UserInfo.Pass = txtPassWord.Text;
                NetworkInterface[] DanhSachCardMang = NetworkInterface.GetAllNetworkInterfaces();

                for (int i = 0; i < DanhSachCardMang.Length; i++)
                    UserInfo.MacAdd = DanhSachCardMang[i].GetPhysicalAddress().ToString();
                UserInfo.NameComputer = Environment.MachineName;
                UserInfo.MacAdd =
                     (
                         from nic in NetworkInterface.GetAllNetworkInterfaces()
                         where nic.OperationalStatus == OperationalStatus.Up
                         select nic.GetPhysicalAddress().ToString()
                     ).FirstOrDefault();
                Log_Bus lb = new Log_Bus();
                lb.InsertLog("Tài khoản " + UserInfo.Account + " đăng nhập vào hệ thống.", "Máy tính " + UserInfo.NameComputer);

                login = true;
                this.Close();
            }


        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            LoginClick();

        }
        #endregion

        private void txtTaiKhoan_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginClick();
            }
        }
        private void txtPassWord_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginClick();
            }
        }


        #endregion
        private void hyperLinkEdit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetConnect scn = new frmSetConnect();
            scn.ShowDialog();
            this.Show();
        }

    }
}