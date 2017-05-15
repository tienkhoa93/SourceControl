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
using System.IO;
using System.Data.SqlClient;
using QLNT.LinQToSQL;
namespace QLNT.Form.Systems
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
       
            OpenFileDialog fileChooser = new OpenFileDialog();
            string addressfile = String.Empty, Namefile = String.Empty;
            LinQToSQL.Backupss bk = new LinQToSQL.Backupss();
            Business.Backups_Bus bkb = new Business.Backups_Bus();
            QLNTDataContext db = new QLNTDataContext();
        public frmBackup()
        {
            InitializeComponent();
            ///Khong cho thay doi kich thuoc
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
          
                Business.Options_Bus opb = new Business.Options_Bus();
                LinQToSQL.Option op = opb.GetOp();

                addressfile  = op.LuufileBackup;
                Namefile = op.TenFileBackup;
                txt_foldername.Text = op.LuufileBackup;
                txtName.Text = op.TenFileBackup;
            bk = bkb.GetListBackups();
            if(bk.Onn==true)
            {
                chkBackupAuto.Checked = true;
                switch(bk.Ngay)
                {     
                    case "Monday":
                        rdoThu2.Checked = true;
                        return;
                    case "Tuesday":
                        rdoThu3.Checked = true;
                        return;
                       
                    case "Wedesday":
                        rdoThu4.Checked = true;
                        return;
                     
                    case "Thursday":
                        rdoThu5.Checked = true;
                        return;
                      
                    case "Friday":
                        rdoThu6.Checked = true;
                        return;
                     
                    case "Saturday":
                        rdoThu7.Checked = true;
                        return;      
                }

            }
        }
      
        /// <summary>
        /// Tìm địa chỉ lưu file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            lb_loi.Text = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txt_foldername.Text = folderBrowserDialog1.SelectedPath;
                addressfile = folderBrowserDialog1.SelectedPath;
            }
        }
        
        /// <summary>
        /// Thuc hien backup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThucThi_Click(object sender, EventArgs e)
        {
            bool bBackUpStatus = true;

            Namefile = txtName.Text;
            if (Directory.Exists(addressfile))
            {
                if (File.Exists(addressfile + @"\" + Namefile + ".bak"))
                {
                    if (MessageBox.Show(@"File đã tồn tại bạn có muốn thay thế nó không?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(addressfile + @"\" + Namefile + ".bak");
                    }
                    else
                        bBackUpStatus = false;
                }
            }
            else
            {
                XtraMessageBox.Show("Chọn đường dẫn lưu file!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bBackUpStatus = false;
            }
            if (bBackUpStatus)
            {
                splashScreenManager1.ShowWaitForm();
                //Connect to DB
                SqlConnection connect;
                string con = db.Connection.ConnectionString.ToString() ;
                connect = new SqlConnection(con);
                connect.Open();
                //----------------------------------------------------------------------------------------------------
                //Execute SQL---------------
                SqlCommand command;
                command = new SqlCommand(@"backup database QLNT to disk ='" + addressfile + @"\" + Namefile + ".bak' with init,stats=10", connect);
                command.ExecuteNonQuery();
                //-------------------------------------------------------------------------------------------------------------------------------
                connect.Close();
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Sao lưu dữ liệu thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        void Getvalue(string a,bool b)
        {           
                        bk.Onn = b;
                        bk.TrangThai = false;
                        bk.Ngay = a;
                        bk.Id = 0;
        }       
        private void frmBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
         

            if (chkBackupAuto.Checked == true)
            {
                if (rdoThu2.Checked == true)
                {
                    Getvalue("Monday", true);
                    bkb.UpdateBackup(bk);
                    return;
                }
                if (rdoThu3.Checked == true)
                {
                    Getvalue("Tuesday", true);
                    bkb.UpdateBackup(bk);
                    return;
                }
                if (rdoThu4.Checked == true)
                {
                    Getvalue("Wedesday", true);
                    bkb.UpdateBackup(bk);
                    return;
                }
                if (rdoThu5.Checked == true)
                {
                    Getvalue("Thursday", true);
                    bkb.UpdateBackup(bk);
                    return;
                }
                if (rdoThu6.Checked == true)
                {
                    Getvalue("Friday", true);
                    bkb.UpdateBackup(bk);
                    return;
                }
                if (rdoThu7.Checked == true)
                {
                    Getvalue("Saturday", true);
                    bkb.UpdateBackup(bk);
                    return;
                }
            }
            else
            {
                Getvalue("Sunday", false);
                bkb.UpdateBackup(bk);
                return;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          
    }
}                        