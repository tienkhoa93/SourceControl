using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

using System.Data;

namespace Common
{
    public class AccountInfo
    {
        public  bool Stt { get; set; }
        /// <summary>
        /// Tên đăng nhập hệ thống
        /// </summary>
        public  string Account { get; set; }
        /// <summary>
        /// Mật khẩu đă đăng nhập hệ thống
        /// </summary>
        public  string Pass { get; set; }
        /// <summary>
        /// Tên giao diện của người dùng
        /// </summary>
        public  string Skin { get; set; }
    }
      
   
}
