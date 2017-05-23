using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Common
{
    class ToolString
    {
        /// <summary>
        /// Đổi ngày từ dd/mm/yyyy -> mm/dd/yyyy
        /// </summary>
        /// <param name="date">dd/mm/yyyy</param>
        /// <returns>mm/dd/yyyy</returns>
        static public string DoiNgay(string date)
        {
            try
            {
                string[] h = date.Split(' ');
                return h[0];
            }
            catch
            {
                date = DateTime.Parse(date).ToString("MM/dd/yyyy");
                return date;
            }

        }
        /// <summary>
        /// Đổi ngày sang kiểu mảng dd/mm/yy
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        static public int[] DoiNgayInt(string date)
        {
            string[] date_new ;
            int[] intdate = new int[3];
            try
            {
                date_new = date.Split('/');
                intdate[0] = int.Parse(date_new[0]);
                intdate[1] = int.Parse(date_new[1]);
                intdate[2] = int.Parse(date_new[2]);
            }
            catch
            {
                intdate[0] = int.Parse(DateTime.Now.Day.ToString());
                intdate[1] = int.Parse(DateTime.Now.Month.ToString());
                intdate[2] = int.Parse(DateTime.Now.Year.ToString());
            }
            return intdate;
        }
        /// <summary>
        /// Chuẩn hóa ngày sang dạng dd/mm/yy
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        static public string ChuanHoaNgay(string date)
        {
            try
            {
                string[] h = date.Split(' ');
                h = h[0].Split('/');
                return h[1] + "/" + h[0] + "/" + h[2];
                
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// Lấy giá trị cho Mã loại
        /// </summary>
        /// <param name="KHieu"></param>
        /// <returns></returns>
        static public string LayLoaiCV(string KHieu)
        {
            string[] str;
            string[] str2;
            try
            {
                str = KHieu.Split('/');
                KHieu = str[1];
                str2 = KHieu.Split('-');
                if (str2[0] == "QĐ")
                    str2[0] = "QD";
            }
            catch
            {
                return "KXD";
            }
            /////////////////
            DataTable dt = null;
            try
            {
                DataAccessObject dataconn = new DataAccessObject();
                String CmdString = @"SELECT count(*) as Counts  FROM LoaiCV  WHERE MaLoai='" + str2[0] + @"'";                
                //dt = dataconn.GetDataTable(CmdString);
                //dataconn.CloseConnect();
                if (int.Parse(dt.Rows[0]["Counts"].ToString()) == 1)
                    return str2[0];
            }
            catch (Exception ex)
            {
                return "KXD";
                throw ex;
            }
            ///////////////
            return "KXD";
        }
        /// <summary>
        /// Kiểm tra chuỗi nhập vào có là số không
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static public bool IsNumber(string value)
        {
            try
            {
                int a = Convert.ToInt32(value);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Kiểm tra dạng số của ngày
        /// </summary>
        /// <param name="ngay">ngay</param>
        /// <param name="thang">thang</param>
        /// <param name="nam"> nam</param>
        /// <returns></returns>
        static public bool KeimTraKieuSoCuaNNgay(string ngay, string thang, string nam)
        {
            if (!IsNumber(ngay))
                return false;
            if (!IsNumber(thang))
                return false;
            if (!IsNumber(nam))
                return false;
            return true;
        }
      
       
    }
}
