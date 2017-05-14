using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Configuration;
using System.Xml;

namespace QLNT.Common
{
    public class DataXml
    {
        #region Đường dẫn lưu file Info
        static string filename = "DataInfo.xml";
        //static string filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\HRM-HITU\\DataInfo.xml";
        #endregion

        #region Lưu thông tin SQL Server
        static DataInfo info;
        #endregion


        /// <summary>
        /// Đọc file Xml
        /// </summary>
        /// <param name="filename">Đường dẫn file xml</param>
        /// <returns>Accountnfo</returns>
        public static DataInfo ReadXmlFile()
        {
            
            KiemTraXml();
            List<DataInfo> data = new List<DataInfo>();
            if (File.Exists(filename))
            {
                XElement xDoc = XElement.Load(filename);
                data = (from q in xDoc.Elements("SERVER")
                        select new DataInfo
                        {
                            Server = MaHoa.GiaiMaDES("ktx@hitu", q.Element("server").Value),
                            Auth = MaHoa.GiaiMaDES("ktx@hitu", q.Element("auth").Value),
                            User = MaHoa.GiaiMaDES("ktx@hitu", q.Element("user").Value),
                            Pass = MaHoa.GiaiMaDES("ktx@hitu", q.Element("pass").Value),
                            Database = MaHoa.GiaiMaDES("ktx@hitu", q.Element("database").Value),
                            ConnectStr = MaHoa.GiaiMaDES("ktx@hitu", q.Element("ConnectString").Value)
                        }).ToList();
                info = data[0];
                return data[0];
            }
            else
            {
                info = new DataInfo();
                return new DataInfo();
            }
        }

        private static void KiemTraXml()
        {
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
        public static bool WriterToXml(DataInfo data)
        {
            try
            {
                XDocument xdoc = new XDocument(
                        new XElement("SERVERINFO",
                        new XElement("SERVER",
                        new XElement("server", MaHoa.MaHoaDES("ktx@hitu", data.Server)),
                        new XElement("auth", MaHoa.MaHoaDES("ktx@hitu", data.Auth)),
                        new XElement("user", MaHoa.MaHoaDES("ktx@hitu", data.User)),
                        new XElement("pass", MaHoa.MaHoaDES("ktx@hitu", data.Pass)),
                        new XElement("database", MaHoa.MaHoaDES("ktx@hitu", data.Database)),
                        new XElement("ConnectString", MaHoa.MaHoaDES("ktx@hitu", data.ConnectStr))
                        )
                        )
                     );
                xdoc.Save(filename);

                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Trả về thông tin SQL Server
        /// </summary>
        public static DataInfo Info
        {
            get { return info; }
            set { info = value; }
        }
        
    }
}
