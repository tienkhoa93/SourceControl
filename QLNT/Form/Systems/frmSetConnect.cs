using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Sql;
using System.Threading;
using Common;
using DevExpress.XtraEditors.Controls;

namespace QLNT.Form.Systems
{
    public partial class frmSetConnect : DevExpress.XtraEditors.XtraForm
    {
        private int ii = 0;

        private Thread findServer = null;
        private Thread findData = null;
        private System.Data.Linq.DataContext db;


        /// <summary>
        /// Contructor khởi tạo
        /// </summary>
        public frmSetConnect()
        {
            InitializeComponent();


            FormBorderStyle = FormBorderStyle.FixedSingle;


            CheckForIllegalCrossThreadCalls = false;
            findServer = new Thread(new ThreadStart(TimMayChu));
            findServer.IsBackground = true;
            findServer.Start();

            findData = new Thread(new ThreadStart(LoadComboData));
            findData.IsBackground = true;
            findData.Start();

            var info = new DataInfo();
            info = DataXml.ReadXmlFile();
            try
            {
                cboServerName.Properties.Items.Add(info.Server);
            }
            catch
            {
            }
            if (info.User != null || info.User == string.Empty)
            {
                rdoTypeConnect.SelectedIndex = 1;
                txtTaiKhoan.Text = info.User;
            }
        }



        private void rdoTypeConnect_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// code changed txttaikhoan va txtmatkhau
            if (rdoTypeConnect.SelectedIndex == 0)
            {
                txtMatKhau.Properties.ReadOnly = true;
                txtTaiKhoan.Properties.ReadOnly = true;
                txtMatKhau.Text = String.Empty;
                txtTaiKhoan.Text = String.Empty;
            }
            else
            {
                txtMatKhau.Properties.ReadOnly = false;
                txtTaiKhoan.Properties.ReadOnly = false;
            }
        }


        /// <summary>
        /// Lưu chuỗi kết nối vào file app.config
        /// </summary>
        private void LuuKetNoi()
        {
            var info = new DataInfo();
            info.Database = cbDataName.Text;
            info.Pass = txtMatKhau.Text;
            info.Server = cboServerName.Text;
            info.Auth = rdoTypeConnect.SelectedIndex.ToString();
            info.User = txtTaiKhoan.Text;
            info.ConnectStr = db.Connection.ConnectionString;




















            try
            {
                DataXml.WriterToXml(info);
            }
            catch
            {
                XtraMessageBox.Show("Lưu cấu hình kết nối không thành công!", "Lỗi Lưu Cấu Hình");
            }
        }



        /// <summary>
        /// Kiểm tra thông tin với sql
        /// </summary>
        /// <returns></returns>
        private bool KiemTraSQL()
        {
            if (rdoTypeConnect.SelectedIndex == 0)
            {
                db = new System.Data.Linq.DataContext("Data Source=" + cboServerName.Text + ";Initial Catalog=" + cbDataName.Text + ";Integrated Security=SSPI");
            }
            else
            {
                db = new System.Data.Linq.DataContext("Data Source=" + cboServerName.Text + ";Initial Catalog=" + cbDataName.Text + ";Persist Security Info=True; User ID=" + txtTaiKhoan.Text + ";Password=" + txtMatKhau.Text + ";");
            }
            try
            {
                db.Connection.Open();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi \n" + e.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            db.Connection.Close();
            return true;
        }
        /// <summary>
        /// Load tên cơ sở dữ liệu lên combobox
        /// </summary>
        private void LoadComboData()
        {
            string serverName;

            lock (cboServerName)
            {
                serverName = cboServerName.Text;
            }

            if (rdoTypeConnect.SelectedIndex == 0)
            {
                if (serverName.Length < 1)
                {
                    db = new System.Data.Linq.DataContext("Data Source=" + serverName + ";Initial Catalog=master;Integrated Security=SSPI");
                }
                else
                {
                    db = new System.Data.Linq.DataContext("Data Source=" + serverName + ";Initial Catalog=master;Integrated Security=SSPI");
                }
            }
            else
            {
                db = new System.Data.Linq.DataContext("Data Source=" + serverName + ";Initial Catalog=master;Persist Security Info=True; User ID=" + txtTaiKhoan.Text + ";Password=" + txtMatKhau.Text + ";");
            }

            try
            {
                db.Connection.Open();
                var dbName = db.ExecuteQuery<DataBase>("select * from sys.databases where database_id > 4").AsEnumerable();
                cbDataName.Properties.Items.Clear();
                foreach (var item in dbName)
                {
                    cbDataName.Properties.Items.Add(item.Name);
                }
                db.Connection.Close();
            }
            catch (Exception e)
            {
                if (ii == 0)
                {
                    ++ii;
                    return;
                }
                XtraMessageBox.Show("Lỗi LoadComboData Kết nối không thành công Hãy kiểm tra lại tài khoản và mật khẩu  !!!\n" + e.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        /// <summary>
        /// Kiểm tra dữ liệu nhập vào
        /// </summary>
        /// <returns></returns>
        private bool CheckInfor_Data()
        {
            if (rdoTypeConnect.SelectedIndex == 0)
            {
                if (cboServerName.Text.Length < 1 || cbDataName.Text.Length < 1)
                {
                    XtraMessageBox.Show("Thông Tin Dữ Liệu Không Chính Xác!!!");
                    return false;
                }
            }
            else
            {
                if (cboServerName.Text.Length < 1 || cbDataName.Text.Length < 1 || txtTaiKhoan.Text.Length < 1 || txtMatKhau.Text.Length < 1)
                {
                    XtraMessageBox.Show("Thông Tin Dữ Liệu Không Chính Xác!!!");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Tìm Server Name Trong mạng LAN
        /// </summary>
        private void TimMayChu()
        {
            lock (cboServerName)
            {
                try
                {
                    cboServerName.Properties.Items.Clear();
                    cboServerName.Properties.Items.Add(@"(local)");
                    cboServerName.SelectedIndex = 0;
                }
                catch
                {
                }
            }
            var dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            string temp;
            foreach (DataRow dr in dt.Rows)
            {
                temp = dr["ServerName"].ToString();
                if (dr["InstanceName"].ToString().Length > 0)
                {
                    temp += "\\" + dr["InstanceName"].ToString();
                }
                lock (cboServerName)
                {
                    cboServerName.Properties.Items.Add(temp);
                }
            }
        }




        /// <summary>
        /// Sự kiện thực hiện kết nối tới sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            findServer.Join();
            findData.Join();
            if (CheckInfor_Data())
            {
                if (KiemTraSQL())
                {
                    LuuKetNoi();

                    XtraMessageBox.Show("Lưu kết nối thành công");

                    Close();
                }
                else
                {
                    XtraMessageBox.Show("Kết nối không thành công");
                }
            }
        }




        /// <summary>
        /// Object the hien doi tuong.
        /// </summary>
        public class DataBase
        {
            public string Name { get; set; }
            public int DatabaseId { get; set; }
        }




        /// <summary>
        /// tìm kiếm server trong mạng Lan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboServerName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                findServer.Join();
            }
        }
        /// <summary>
        /// Tìm kiếm cơ sở dữ liệu của server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDataName_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                LoadComboData();
            }
        }




        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
