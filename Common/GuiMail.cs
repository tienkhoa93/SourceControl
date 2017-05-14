using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;

namespace Common
{
    class ToolGuiMail
    {
        private bool action = false;
        public ToolGuiMail()
        {
            
        }
        private bool DocLenhGui()
        {
            try
            {
                DataTable data = null;
                DataAccessObject dataconn = new DataAccessObject();
                String CmdString = @"SELECT Gui FROM GuiEMail WHERE STT=1";
                //dt = dataconn.GetDataTable(CmdString);
                if (data.Rows[0]["Gui"].ToString() == "True")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return true; }
        }
        public bool GuiThongTin(bool flag)
        {
            if (flag)
            {
                action = flag;
            }
            else
            {
                action = DocLenhGui();
            }
            //////////////
            if (action)
            {
                try
                {
                    string noidung = "";
                    string pathfile = "";
                    string tieude = "";
                    string mailnhan = "";
                    string mailgui = "";
                    string matkhau = "";
                    try
                    {
                        noidung = DocNoiDung();
                        pathfile = DocDuongDanFile();
                        tieude = DocTieuDe();
                        mailnhan = DocDiaChiMailNhan();
                        mailgui = DocDiaChiMailGui();
                        matkhau = DocMatKhau();
                        if (mailgui.Length < 4)
                        {
                            return false;
                        }
                        if (mailnhan.Length < 4)
                        {
                            return false;
                        }
                        if (matkhau.Length < 4)
                        {
                            return false;
                        }
                    }
                    catch { return false; }
                    ////////////
                    Attachment data = null;
                    try
                    {
                        if (pathfile.Length > 2)
                        {
                            if (File.Exists(pathfile))
                            {
                                data = new Attachment(pathfile);
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    catch { return false; }
                    ////////////////////////////////////////
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress(mailgui); // DiaChiMail Gửi
                    mail.To.Add(mailnhan); // DiaChiMail Nhận
                    mail.Subject = tieude; // Tiêu đề
                    mail.Body = noidung; // Nội dung
                    if (data != null)
                    {
   
                        mail.Attachments.Add(data); // Thêm tập tin vào mail
                    }
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(mailnhan, matkhau);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    return true;
                }
                catch { return false; }
            }
            else
            {
                return true;
            }
        }
        private string DocDiaChiMailGui()
        {
            try
            {
                DataTable dt = null;

                return dt.Rows[0][0].ToString();
            }
            catch
            {
                return ""; // lỗi kết nối
            }
        }
        private String DocNoiDung()
        {
            try
            {
                DataTable dt = null;
                DataAccessObject dataconn = new DataAccessObject();
                String CmdString = @"SELECT NoiDung FROM GuiEMail WHERE STT=1";
                //dt = dataconn.GetDataTable(CmdString);
                //dataconn.CloseConnect();
                return dt.Rows[0][0].ToString();
            }
            catch
            {
                return ""; // lỗi kết nối
            }
        }
        /// <summary>
        /// Lấy mật khau mail gửi
        /// </summary>
        /// <returns></returns>
        private String DocMatKhau()
        {
            try
            {
                DataTable dt = null;
                DataAccessObject dataconn = new DataAccessObject();
                String CmdString = @"SELECT MatKhau FROM GuiEMail WHERE STT=1";

                return MaHoa.MaHoaDES("chuoi ma hoa",dt.Rows[0][0].ToString());
				//dt = dataconn.GetDataTable(CmdString);
                //dataconn.CloseConnect();
            }
            catch
            {
                return ""; // lỗi kết nối
            }
        }
        private String DocDiaChiMailNhan()
        {
            try
            {
                DataTable dt = null;
                DataAccessObject dataconn = new DataAccessObject();
                String CmdString = @"SELECT MailNhan FROM GuiEMail WHERE STT=1";
                //dt = dataconn.GetDataTable (CmdString);
                //dataconn.CloseConnect();
                return dt.Rows[0][0].ToString();
            }
            catch
            {
                return ""; // lỗi kết nối
            }
        }
        private String DocTieuDe()
        {
            try
            {
                DataTable dt = null;
                DataAccessObject dataconn = new DataAccessObject();
                String CmdString = @"SELECT TieuDe FROM GuiEMail WHERE STT=1";
                //dt = dataconn.GetDataTable(CmdString);
                //dataconn.CloseConnect();
                return dt.Rows[0][0].ToString();
            }
            catch
            {
                return ""; // lỗi kết nối
            }
        }
        private String DocDuongDanFile()
        {
            try
            {
                DataTable dt = null;
                DataAccessObject dataconn = new DataAccessObject();
                String CmdString = @"SELECT FileBackup FROM GuiEMail WHERE STT=1";
                //dt = dataconn.GetDataTable(CmdString);
                //dataconn.CloseConnect();
                return dt.Rows[0][0].ToString();
            }
            catch
            {
                return ""; // lỗi kết nối
            }
        }
    }
}
