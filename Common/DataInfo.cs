using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common
{
    public  class DataInfo
    {
        /// <summary>
        /// Tên máy chủ SQL
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// Chế độ đăng nhập SQL
        /// </summary>
        public string Auth { get; set; }
        /// <summary>
        /// Tài khoản truy cập SQL
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Mật khẩu truy cập SQL
        /// </summary>
        public string Pass { get; set; }
        /// <summary>
        /// Tên DataBase
        /// </summary>
        public string Database { get; set; }
        /// <summary>
        /// Chuỗi kết nối
        /// </summary>
        public string ConnectStr { get; set; }
    }

}