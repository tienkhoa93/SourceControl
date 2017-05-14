using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public class UserInfo
    {

        public static bool Stt { get; set; }
        /// <summary>
        /// Tên đăng nhập hệ thống
        /// </summary>
        public static string Account { get; set; }
        /// <summary>
        /// Mật khẩu đă đăng nhập hệ thống
        /// </summary>
        public static string Pass { get; set; }
        /// <summary>
        /// Tên giao diện của người dùng
        /// </summary>
        public static string Skin { get; set; }

        /// <summary>
        /// địa chỉ mác của máy tính
        /// </summary>
        public static string MacAdd
        {
            get;
            set;
        }
        // tên máy tính sử dụng phần mềm.
        public static string NameComputer { get; set; }
    }
}
