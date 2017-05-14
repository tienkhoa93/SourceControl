using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
    public class SySNhomQuyen_Bus
    {
        QLNTDataContext dtcontent = new QLNTDataContext();
        public List<SysNhomQuyen> ListNhomQuyen()
        {
            var dt = from nq in dtcontent.SysNhomQuyens
                     select nq;
            return dt.ToList<SysNhomQuyen>();
        }
        public List<SysNhomQuyen> SelectNhomQuyen(string manhom)
        {
            var dt = from nq in dtcontent.SysNhomQuyens
                     where nq.MaNhom == manhom
                     select nq;
            return dt.ToList<SysNhomQuyen>();
        }
        public bool InsertNhomQuyen(SysNhomQuyen nq)
        {
            try
            {
                SysNhomQuyen nhomquyen = new SysNhomQuyen()
                {
                    MaNhom = nq.MaNhom == null ? string.Empty : nq.MaNhom,
                    TenNhom = nq.TenNhom == null ? string.Empty : nq.TenNhom,
                    DienGiai = nq.DienGiai == null ? string.Empty : nq.DienGiai,
                    HoatDong = nq.HoatDong
                };
                dtcontent.SysNhomQuyens.InsertOnSubmit(nhomquyen);
                dtcontent.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateNhomQuyen(SysNhomQuyen nq)
        {
            try
            {
                SysNhomQuyen nhomquyen = dtcontent.SysNhomQuyens.Single(p => p.MaNhom == nq.MaNhom);
                nhomquyen.TenNhom = nq.TenNhom == null ? string.Empty : nq.TenNhom;
                nhomquyen.DienGiai = nq.DienGiai == null ? string.Empty : nq.DienGiai;
                nhomquyen.HoatDong = nq.HoatDong;
                dtcontent.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteNhomQuyen(string manhomquyen)
        {
            try
            {
                var query = (from nq in dtcontent.SysNhomQuyens
                             where nq.MaNhom == manhomquyen
                             select nq
                    );
                dtcontent.SysNhomQuyens.DeleteAllOnSubmit(query);
                dtcontent.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}