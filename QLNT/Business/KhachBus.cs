using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Form Khach
namespace QLNT.Business
{
    public class _Khach : Khach
    {
        public string TenPhong { get; set; }
        public string TenKhachTro { get; set; }
    }
   public class KhachBus
    {
        QLNTDataContext datacontext = new QLNTDataContext();
        Log_Bus lb = new Log_Bus();
        public List<_Khach> DanhSachKhach()
        {
            try
            {
                var list_khach = from khach in datacontext.Khaches
                                 join phong in datacontext.Phongs on khach.MaPhong equals phong.MaPhong
                                 join khachtro in datacontext.KhachTros on khach.MaKhachTro equals khachtro.MaKhachTro
                                 where khach.HoatDong == true
                    select new _Khach
                    {
                        MaKhach = khach.MaKhach,
                        HoLot = khach.HoLot,
                        Ten = khach.Ten,
                        Anh = khach.Anh == null ? null : khach.Anh.ToArray(),
                        NgaySinh = khach.NgaySinh,   
                        NoiSinh = khach.NoiSinh,
                        CMND = khach.CMND,
                        NgayCap=khach.NgayCap,
                        NoiCap = khach.NoiCap,
                        GioRa = khach.GioRa,
                        GioVao = khach.GioRa,
                        NgayVao = khach.NgayVao,
                        NgayRa = khach.NgayRa,
                        MaKhachTro = khach.MaKhachTro,
                        TenKhachTro = khachtro.HoLot+" "+ khachtro.Ten,
                        MaPhong = khach.MaPhong,
                        TenPhong = phong.TenPhong,
                        GhiChu = khach.GhiChu,                      
                        HoatDong = khach.HoatDong,
                    };

                return list_khach.ToList<_Khach>();
            }
            catch { return null; }
        }

        public List<_Khach> DanhSachKhach_DaXoa()
        {
            try
            {
                var list_khach = from khach in datacontext.Khaches
                                 join phong in datacontext.Phongs on khach.MaPhong equals phong.MaPhong
                                 join khachtro in datacontext.KhachTros on khach.MaKhachTro equals khachtro.MaKhachTro
                                 where khach.HoatDong == false
                                 select new _Khach
                                 {
                                     MaKhach = khach.MaKhach,
                                     HoLot = khach.HoLot,
                                     Ten = khach.Ten,
                                     Anh = khach.Anh == null ? null : khach.Anh.ToArray(),
                                     NgaySinh = khach.NgaySinh,
                                     NoiSinh = khach.NoiSinh,
                                     CMND = khach.CMND,
                                     NgayCap = khach.NgayCap,
                                     NoiCap = khach.NoiCap,
                                     GioRa = khach.GioRa,
                                     GioVao = khach.GioRa,
                                     NgayVao = khach.NgayVao,
                                     NgayRa = khach.NgayRa,
                                     MaKhachTro = khach.MaKhachTro,
                                     TenKhachTro = khachtro.HoLot + " " + khachtro.Ten,
                                     MaPhong = khach.MaPhong,
                                     TenPhong = phong.TenPhong,
                                     GhiChu = khach.GhiChu,
                                     HoatDong = khach.HoatDong,
                                 };

                return list_khach.ToList<_Khach>();
            }
            catch { return null; }
        }
        public List<_Khach> DanhSachKhach_TacCa()
        {
            try
            {
                var list_khach = from khach in datacontext.Khaches
                                 join phong in datacontext.Phongs on khach.MaPhong equals phong.MaPhong
                                 join khachtro in datacontext.KhachTros on khach.MaKhachTro equals khachtro.MaKhachTro
                                 
                                 select new _Khach
                                 {
                                     MaKhach = khach.MaKhach,
                                     HoLot = khach.HoLot,
                                     Ten = khach.Ten,
                                     Anh = khach.Anh == null ? null : khach.Anh.ToArray(),
                                     NgaySinh = khach.NgaySinh,
                                     NoiSinh = khach.NoiSinh,
                                     CMND = khach.CMND,
                                     NgayCap = khach.NgayCap,
                                     NoiCap = khach.NoiCap,
                                     GioRa = khach.GioRa,
                                     GioVao = khach.GioRa,
                                     NgayVao = khach.NgayVao,
                                     NgayRa = khach.NgayRa,
                                     MaKhachTro = khach.MaKhachTro,
                                     TenKhachTro = khachtro.HoLot + " " + khachtro.Ten,
                                     MaPhong = khach.MaPhong,
                                     TenPhong = phong.TenPhong,
                                     GhiChu = khach.GhiChu,
                                     HoatDong = khach.HoatDong,
                                 };

                return list_khach.ToList<_Khach>();
            }
            catch { return null; }
        }

        public bool InsertKhach(Khach khach)
        {
            try
            {
                Khach dantoc = new Khach()
                {
                    MaKhach = khach.MaKhach,
                    HoLot = khach.HoLot,
                    Ten = khach.Ten,
                    Anh = khach.Anh == null ? null : khach.Anh.ToArray(),
                    NgaySinh = khach.NgaySinh == null ?null:khach.NgaySinh,
                    NoiSinh = khach.NoiSinh == null ? null : khach.NoiSinh,
                    CMND = khach.CMND ,
                    NgayCap = khach.NgayCap  == null ? null : khach.NgayCap ,
                    NoiCap = khach.NoiCap == null ? null : khach.NoiCap,
                    GioRa = khach.GioRa==null ? null:khach.GioRa,
                    GioVao = khach.GioVao == null ? null : khach.GioVao,
                    NgayVao = khach.NgayVao==null ? null:khach.NgayVao,
                    NgayRa = khach.NgayRa==null ? null:khach.NgayRa,
                    MaKhachTro = khach.MaKhachTro==null ? null:khach.MaKhachTro,
                    MaPhong = khach.MaPhong==null ? null:khach.MaPhong,
                    GhiChu = khach.GhiChu==null ? null:khach.GhiChu,
                    HoatDong = true,

                };
                datacontext.Khaches.InsertOnSubmit(khach);
                datacontext.SubmitChanges();
                lb.InsertLog("Thêm khách " + khach.MaKhach, "Thêm khách");
                return true;
            }
            catch { return false; }
        }
        public bool UpdateKhach(Khach kh)
        {
            Khach khach = datacontext.Khaches.Single(p => p.MaKhach == kh.MaKhach);
            khach.MaKhachTro = kh.MaKhachTro;
            khach.HoLot = kh.HoLot;
            khach.Ten = kh.Ten;
            khach.Anh = kh.Anh == null ? null : kh.Anh.ToArray();
            khach.NoiSinh = kh.NoiSinh;
            khach.NgaySinh = kh.NgaySinh;
            khach.CMND = kh.CMND;
            khach.NoiCap = kh.NoiCap;
            khach.NgayCap = kh.NgayCap;
            khach.GioVao = kh.GioVao;
            khach.GioRa = kh.GioRa;
            khach.NgayRa = kh.NgayRa;
            khach.NgayVao = kh.NgayVao;
            khach.MaKhachTro = kh.MaKhachTro;
            khach.MaPhong = kh.MaPhong;
            khach.GhiChu = kh.GhiChu;
            khach.HoatDong = true;

            try
            {
                datacontext.SubmitChanges();               
                return true;
            }
            catch { return false; }
        }
        public void DeleteKhach(string MaKhach)
        {
            var query1 = (from sv in datacontext.Khaches
                          where sv.MaKhach == MaKhach
                          select sv).Single();
            query1.HoatDong = false;
            datacontext.SubmitChanges();
            lb.InsertLog("Xóa khách (Thùng rác) " + MaKhach, "Xóa khách");
        }

        public string LayMaPhongTuMaKhachTro(string makhachtro)
        {
            var q = (from khachtro in datacontext.KhachTros
                     where khachtro.MaKhachTro == makhachtro
                     select new
                     {
                         MaPhong = khachtro.MaPhong,
                     }).First();
            //  q.FirstOrDefault();
            return q.ToString();

            //return "";
        }
    }
}
