using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Common
{
    public class AccountXml
    {
        #region Lưu thông tin tài khoản
        static AccountInfo info;
        #endregion

        #region Đường dẫn lưu file Info
        static string filename = "AccountInfo.xml";
        //static string filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\HRM-HITU\\AccountInfo.xml";


        #endregion
        /// <summary>
        /// Đọc file Xml
        /// </summary>
        /// <param name="filename">Đường dẫn file xml</param>
        /// <returns>Accountnfo</returns>
        public static AccountInfo ReadXmlFile()
        {
            KiemTraXml();
            List<AccountInfo> data = new List<AccountInfo>();
            if (File.Exists(filename))
            {
                XElement xDoc = XElement.Load(filename);
                data = (from q in xDoc.Elements("ACCOUNT")
                        select new AccountInfo
                        {
                            Account = MaHoa.GiaiMaDES("ktx@hitu", q.Element("Account").Value),
                            Pass = MaHoa.GiaiMaDES("ktx@hitu", q.Element("Pass").Value),
                            Skin = MaHoa.GiaiMaDES("ktx@hitu", q.Element("Skin").Value),
                            Stt=bool.Parse(MaHoa.GiaiMaDES("ktx@hitu", q.Element("Stt").Value))
                        }).ToList();
                info = data[0];
                return data[0];
            }
            else
            {
                info = new AccountInfo();
                return new AccountInfo();
            }
        }

        private static void KiemTraXml()
        {
            if (!File.Exists(filename))
            {
                WriterToXml(new AccountInfo {Stt=true, Account = "admin", Pass = "admin", Skin = "Blue" });
                return;
            }
            #region Tạo đường dẫn lưu file Info
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\HRM-HITU";
            //if (!System.IO.Directory.Exists(path))
            //{
            //    System.IO.Directory.CreateDirectory(path);
            //} 
            #endregion

           
        }
        /// <summary>
        /// Lưu file Xml
        /// </summary>
        /// <param name="filename">Đường dẫn file Xml</param>
        /// <param name="data">Accountnfo</param>
        public static bool WriterToXml(AccountInfo data)
        {
           
            try
            {
                XDocument xdoc = new XDocument(
                    new XElement("ACCOUNTINFO",
                    new XElement("ACCOUNT",
                        new XElement("Stt", MaHoa.MaHoaDES("ktx@hitu", data.Stt.ToString())),
                        new XElement("Account", MaHoa.MaHoaDES("ktx@hitu", data.Account)),
                        new XElement("Pass", MaHoa.MaHoaDES("ktx@hitu", data.Pass)),
                        new XElement("Skin", MaHoa.MaHoaDES("ktx@hitu", ""+data.Skin))
                        )
                        )
                     );
                xdoc.Save(filename);
                return true;
            }
            catch { return false; }
        }

        public static AccountInfo Info
        {
            get { return info; }
            set { info = value; }
        }

   
    }
}
