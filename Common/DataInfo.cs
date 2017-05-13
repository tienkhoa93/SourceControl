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
        /// Tên máy ch? SQL
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// Ch? d? dang nh?p SQL
        /// </summary>
        public string Auth { get; set; }
        /// <summary>
        /// Tài kho?n truy c?p SQL
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// M?t kh?u truy c?p SQL
        /// </summary>
        public string Pass { get; set; }
        /// <summary>
        /// Tên DataBase
        /// </summary>
        public string Database { get; set; }
        /// <summary>
        /// Chu?i k?t n?i
        /// </summary>
        public string ConnectStr { get; set; }
    }

}