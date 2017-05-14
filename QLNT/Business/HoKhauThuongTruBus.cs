using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
   public class HoKhauThuongTruBus
    {
        QLNTDataContext dtcontent = new QLNTDataContext(); 
       Log_Bus lb = new Log_Bus();
        public List<HoKhauThuongTru> ListHoKhauThuongTru()
        {
            var c = from dt in dtcontent.HoKhauThuongTrus
                    select dt;
            return c.ToList<HoKhauThuongTru>();
        }
        //public List<HoKhauThuongTru> ListHoKhauThuongTru()
        //{
        //    var c = from dt in dtcontent.HoKhauThuongTrus
        //            select dt;
        //    return c.ToList<HoKhauThuongTru>();
        //}
        public bool InsertHoKhau(HoKhauThuongTru hktt)
        {
            try
            {
                HoKhauThuongTru hokhauthuongtru = new HoKhauThuongTru()
                {
                    TenHoKhau = hktt.TenHoKhau == null ? String.Empty : hktt.TenHoKhau,
                    GhiChu = hktt.GhiChu == null ? String.Empty : hktt.GhiChu,
                };
                dtcontent.HoKhauThuongTrus.InsertOnSubmit(hokhauthuongtru);
                dtcontent.SubmitChanges();
                lb.InsertLog("Thêm hộ khẩu thường trú " + hktt.TenHoKhau, "Thêm hộ khẩu thường trú");
                return true;
            }
            catch { return false; }
        }
        public bool UpdateHoKhau(HoKhauThuongTru hktt)
        {
            try
            {
                HoKhauThuongTru hokhau = dtcontent.HoKhauThuongTrus.Single(p => p.MaHoKhau == hktt.MaHoKhau);
                hokhau.TenHoKhau = hktt.TenHoKhau;
                hokhau.GhiChu = hktt.GhiChu;
                dtcontent.SubmitChanges();
                lb.InsertLog("Sửa hộ khẩu thường trú " + hktt.TenHoKhau, "Sửa hộ khẩu thường trú");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteHoKhau(long MaHoKhau)
        {
            try
            {
                var query = (from khu in dtcontent.HoKhauThuongTrus
                             where khu.MaHoKhau == MaHoKhau
                             select khu);
                dtcontent.HoKhauThuongTrus.DeleteAllOnSubmit(query);
                dtcontent.SubmitChanges();
                lb.InsertLog("Xóa hộ khẩu thường trú ", "Thêm hộ khẩu thường trú");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int KiemTraTonTaiHoKhau(long kh)
        {
           // return (from sv in dtcontent.KhachTros where sv.MaHoKhau == kh select sv).Count();
            return 1;
        }

        public bool KiemTraHoKhau(string thk)
        {

            if ((from pb in dtcontent.HoKhauThuongTrus where pb.TenHoKhau == thk select pb).Count() > 0)
                return true;
            return false;
        }
    }
}
