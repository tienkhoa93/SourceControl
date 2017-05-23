using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace Common
{
    public class DataAccessObject
    {
           
        // Khai bao cac thuoc tinh cua lop     
        // ket noi co so du lieu theo Linq
        private static string strCon = String.Empty;      
        static System.Data.Linq.DataContext db;


        /// <summary>
        /// Tạo đối tượng để kết nối Database với chuỗi kết nối mặc định
        /// </summary>
        public DataAccessObject()
        {
           
            try
            {
                if(strCon==String.Empty)
                strCon = DataXml.Info.ConnectStr;
            }
            catch { 
            
            }
        }
        /// <summary>
        /// Khởi động lại chuỗi kết nối
        /// </summary>
        public void Refresh()
        {
            try
            {
                strCon = DataXml.Info.ConnectStr;
            }
            catch
            {

            }
        }
        /// <summary>
        /// Tạo đối tượng để kết nối Database với chuỗi kết được truyền vào
        /// </summary>
        public DataAccessObject(string value)
        {
            strCon = value;
        }

        /// <summary>
        /// set/get chuỗi kết nối SQL
        /// </summary>
        public  string StrConnect
        {
            get
            {
                return strCon;
            }
            set
            {
                strCon = value;
            }
        }
       
        /// <summary>
        /// Hàm trả về một chuôi kết nối
        /// </summary>
        /// <returns></returns>
        public static void Connected()
        {
            try
            {
                if (db.Connection.State == ConnectionState.Closed)
                {   
                    db = new System.Data.Linq.DataContext(strCon);
                    db.Connection.Open();
                }
            }
            catch
            {                
                return;
            }          
        }
        /// <summary>
        /// kiểm tra khả năng kết nối đến SQLServer
        /// </summary>
        /// <returns></returns>
        public bool KT_KetNoi()
        {
            try
            {
                db = new System.Data.Linq.DataContext(strCon);
                db.Connection.Open();
                return true;
            }
            catch
            {
                //MessageBox.Show("Lỗi kết nối CSDL, có thể lỗi do: \n - Có thể máy tính chưa được cài đặt SQL Server\n - Dịch vụ SQL Server đã bị ngắt\n - Tên cở sở dữ liệu không tồn tại\n - Tài khoản truy cập SQL Server không đúng" +
                //   "\n*******************************************************************\n", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.Connection.Close();
            }
        }
        /// <summary>
        /// STATIC : kiểm tra khả năng kết nối đến SQLServer
        /// </summary>
        /// <returns></returns>
        public static bool KT_KetNoi(string strconnect)
        {
            System.Data.Linq.DataContext temp = new System.Data.Linq.DataContext(strconnect);
          
            try
            {
                temp.Connection.Open();
                return true;
            }
            catch
            {
                //MessageBox.Show("Lỗi kết nối CSDL, có thể lỗi do: \n - Có thể máy tính chưa được cài đặt SQL Server\n - Dịch vụ SQL Server đã bị ngắt\n - Tên cở sở dữ liệu không tồn tại\n - Tài khoản truy cập SQL Server không đúng" +
                //   "\n*******************************************************************\n", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                temp.Connection.Close();
            }
        }
        /// <summary>
        /// Ngắt kết nối
        /// </summary>
        public void CloseConnect(System.Data.Linq.DataContext dtcontext)
        {
            try
            {
                if (dtcontext.Connection.State == ConnectionState.Open)
                    dtcontext.Connection.Close();
            }
            catch { } 
        }
    }

}
