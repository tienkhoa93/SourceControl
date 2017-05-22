using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class BackupData
    {

        public void Backup_click(string tenfile, string duongdan)
        {
            bool bBackUpStatus = true;
            if (Directory.Exists(duongdan))
            {
                if (File.Exists(duongdan + @"\" + tenfile + ".bak"))
                {
                    if (MessageBox.Show(@"File sao lưu đã tồn tại bạn có muốn thay thế nó không?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(duongdan + @"\" + tenfile + ".bak");
                    }
                    else
                        bBackUpStatus = false;
                }
            }
            else
            {
                MessageBox.Show("Không thể lưu file dữ liệu!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bBackUpStatus = false;

            }
            if (bBackUpStatus)
            {
                //Connect to DB
                SqlConnection connect;
                string con = "Data Source = .; Initial Catalog=QLNT ;Integrated Security = True;";
                connect = new SqlConnection(con);
                connect.Open();
                //----------------------------------------------------------------------------------------------------
                //Execute SQL---------------
                SqlCommand command;
                command = new SqlCommand(@"backup database QLNT to disk ='" + duongdan + @"\" + tenfile + ".bak' with init,stats=10", connect);
                try { command.ExecuteNonQuery(); }
                catch
                {
                    MessageBox.Show("Sao lưu dữ liệu không thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //-------------------------------------------------------------------------------------------------------------------------------
                connect.Close();
                MessageBox.Show("Sao lưu dữ liệu thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
