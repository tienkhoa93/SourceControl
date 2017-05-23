using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
    public class SysNguoiDung_Bus
    {
        QLNTDataContext dtcontent = new QLNTDataContext();
        public List<SysUser> ListNguoiDung()
        {
            var c = from dt in dtcontent.SysUsers
                    select dt;
            return c.ToList<SysUser>();
        }

        public List<SysUser> SelectNguoiDung_MaTKhau(string mk)
        {
            var c = from dt in dtcontent.SysUsers
                    where dt.TaiKhoan == mk
                    select dt;
            return c.ToList<SysUser>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UpdateNguoiDung(SysUser user)
        {
            try
            {
                SysUser nguoidung = dtcontent.SysUsers.Single(p => p.ID == user.ID);

                nguoidung.TaiKhoan = user.TaiKhoan;
                nguoidung.MatKhau = user.MatKhau == null ? string.Empty : user.MatKhau;
                nguoidung.HoTen = user.HoTen == null ? string.Empty : user.HoTen;
                nguoidung.MaNhom = user.MaNhom == null ? string.Empty : user.MaNhom;
                nguoidung.Email = user.Email == null ? string.Empty : user.Email;
                nguoidung.DienGiai = user.DienGiai == null ? string.Empty : user.DienGiai;
                nguoidung.HoatDong = user.HoatDong;

                dtcontent.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
		        public bool insertNguoiDung(SysUser user)
        {
            try
            {
                SysUser nguoidung = new SysUser()
                {
                    ID = user.ID == null ? string.Empty : user.ID,
                    TaiKhoan = user.TaiKhoan == null ? string.Empty : user.TaiKhoan,
                    MatKhau = user.MatKhau == null ? string.Empty : user.MatKhau,
                    HoTen = user.HoTen == null ? string.Empty : user.HoTen,
                    MaNhom = user.MaNhom == null ? string.Empty : user.MaNhom,
                    Email = user.Email == null ? string.Empty : user.Email,
                    DienGiai = user.DienGiai == null ? string.Empty : user.DienGiai,
                    HoatDong = user.HoatDong,
                };
                dtcontent.SysUsers.InsertOnSubmit(nguoidung);
                dtcontent.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteNguoiDung(string manguoidung)
        {
            try
            {
                var query = (from nguoidung in dtcontent.SysUsers
                             where nguoidung.ID == manguoidung
                             select nguoidung);
                dtcontent.SysUsers.DeleteAllOnSubmit(query);
                dtcontent.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
