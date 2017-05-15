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
using System.Data.SqlClient;
using System.IO;

namespace QLNT.Form.Systems
{
    public partial class frmRestore : DevExpress.XtraEditors.XtraForm
    {
        int a = 0;

        //public delegate void Reload();
      //  public Reload reload;
        OpenFileDialog fileChooser = new OpenFileDialog();
        string foldename = String.Empty;
        public frmRestore()
        {
            InitializeComponent();
            ///Khong cho thay doi kich thuoc
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            labelControl1.Text = "TẠO CƠ SỞ DỮ LIỆU";
            Task task = new Task(() => {
                Business.Options_Bus opb = new Business.Options_Bus();
                LinQToSQL.Option o = opb.GetOp();
                txtFolderName.Text = o.LuufileRestore + o.TenFileBackup;
            });
            task.Start();
        }
        //public frmRestore(int a)
        //{
        //    InitializeComponent();
        //    ///Khong cho thay doi kich thuoc
        //    this.FormBorderStyle = FormBorderStyle.FixedSingle;
        //    this.a = a;
        //    labelControl1.Text = "TẠO CƠ SỞ DỮ LIỆU";
        //    Business.Options_Bus opb = new Business.Options_Bus();
        //    txtFolderName.Text= opb.GetOp().LuufileRestore;
        //}
        #region buttion browse
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            fileChooser.Filter = "bak file|*.bak";
            fileChooser.InitialDirectory = "C:\\";
            fileChooser.Title = "Chọn file *.bak để phục hồi";
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                txtFolderName.Text = fileChooser.FileName;
            }
        }
        #endregion
        #region close
        private void btnDong_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }
        #endregion

        private void btnThucThi_Click(object sender, EventArgs e)
        {
          
            if (txtFolderName.Text == string.Empty)
                XtraMessageBox.Show("Chọn file dữ liệu để thực hiện thao tác !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else { 
            try
            {
                if (File.Exists(fileChooser.FileName))
                {
                    if (XtraMessageBox.Show("Bạn có muốn thực hiện khôi phục dữ liệu", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        splashScreenManager1.ShowWaitForm();
                        //Connect SQL-----------
                        SqlConnection connect;
                        string con = "Data Source = .; Initial Catalog=master ;Integrated Security = True;";
                        connect = new SqlConnection(con);
                        connect.Open();
                        //-----------------------------------------------------------------------------------------

                        //Excute SQL Restore database----------------
                        SqlCommand command;
                        command = new SqlCommand("use master;", connect);
                        command.ExecuteNonQuery();
                      
                        // Excute SQL Drop database-
                        command = new SqlCommand("EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'QLNT' ;USE [master] ;ALTER DATABASE QLNT SET SINGLE_USER WITH ROLLBACK IMMEDIATE ; DROP DATABASE QLNT ;", connect);                     
                        command.ExecuteNonQuery();                     
                        //restore database
                        command = new SqlCommand("use master;RESTORE DATABASE QLNT FROM DISK ='" + fileChooser.FileName + "'", connect);                 
                        command.ExecuteNonQuery();
                        //--------------------------------------------------------------------------------------------------------
                        splashScreenManager1.CloseWaitForm();
                        connect.Close();
                        XtraMessageBox.Show("Khôi phục dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    XtraMessageBox.Show("Không thể khôi phục dữ liệu từ file đã chọn (hoặc đường dẫn không đúng).\n Vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show("Lỗi\n"+exp.Message);
            }
            
            this.Close();
            
            
            }
        }


    }
}