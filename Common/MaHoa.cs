using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class MaHoa
    {
        /// <summary>
        /// Mã hóa ký tự với kiểu mã hõa TripleDes - MD5
        /// </summary>
        /// <param name="key">là pass mã hóa</param>
        /// <param name="content">nội dung cần mã hóa</param>
        /// <returns></returns>
        public static string MaHoaDES(string key, string content)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(content);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            TripleDESCryptoServiceProvider tdes =new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// Giải mã dữ liệu đã mã hóa
        /// </summary>
        /// <param name="key">là pass giải mã</param>
        /// <param name="content">là nội dung cần giải mã</param>
        /// <returns></returns>
        public static string GiaiMaDES(string key, string content)
        {
            try
            {
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(content);
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch
            { }
            return "";
        }
        /// <summary>
        /// Mã hóa chuẩnM  MD5
        /// </summary>
        /// <param name="text">nội dung</param>
        /// <returns>chuỗi mã hóa</returns>
        public static string MaHoaMD5(string text)
        {
            try
            {
                MD5CryptoServiceProvider _md5Hasher = new MD5CryptoServiceProvider();
                byte[] bs = Encoding.UTF8.GetBytes(text);
                bs = _md5Hasher.ComputeHash(bs);
                StringBuilder s = new StringBuilder();
                foreach (byte b in bs)
                {
                    s.Append(b.ToString("x2"));
                }
                return s.ToString();
            }
            catch
            { }
            return "";
        }
       
    }
}
