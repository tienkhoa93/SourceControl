using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.LinQToSQL;
using System.Data;
using System.Data.Linq;
namespace QLNT.Business
{
    public class Phong_B : QLNT.LinQToSQL.Phong
    {
        public string TenKhu { get; set; }
    
    }
    public class Phong_Bus
    {
        QLNTDataContext dtcontent = new QLNTDataContext();
        Log_Bus lb = new Log_Bus();

        public List<Phong> ListPhong_TheoMaKhu(string mk)
        {
            var phong = (from p in dtcontent.Phongs where p.MaKhu == mk select p);
            return phong.ToList<Phong>();
        }
        public Phong SoNguoi(string mp)
        {
            var list_khachtro = (from nt in dtcontent.Phongs where nt.MaPhong == mp select nt).First();
            return list_khachtro;
        }
        public List<Phong_B> PhongXapHetHan(DateTime tn,DateTime ttn)
        {
            try
            {
                var list_phong =
                    from ph in dtcontent.Phongs
                    join khu in dtcontent.Khus on ph.MaKhu equals khu.MaKhu
                    where ph.HoatDong == true && (ph.TuNgay>=tn && ph.ToiNgay<=ttn)
                    select new Phong_B
                    {
                        MaPhong = ph.MaPhong,
                        MaKhu = ph.MaKhu,
                        TenPhong = ph.TenPhong,
                        TenKhu = khu.TenKhu,
                        GiaPhong = ph.GiaPhong,
                        SoNguoi = ph.SoNguoi,
                        HoatDong = ph.HoatDong,
                        GhiChu = ph.GhiChu,
                        TongNguoi = ph.TongNguoi,
                        TuNgay = ph.TuNgay,
                        ToiNgay = ph.ToiNgay
                    };

                return list_phong.ToList<Phong_B>();
            }
            catch { return null; }
        }
        public List<Phong_B> ListPhongConTrong()
        {
            try
            {
                var list_phong =
                    from ph in dtcontent.Phongs
                    join khu in dtcontent.Khus on ph.MaKhu equals khu.MaKhu
                    where ph.HoatDong == true && (ph.SoNguoi ==null||ph.SoNguoi==0)
                    select new Phong_B
                    {
                        MaPhong = ph.MaPhong,
                        MaKhu = ph.MaKhu,
                        TenPhong = ph.TenPhong,
                        TenKhu = khu.TenKhu,
                        GiaPhong = ph.GiaPhong,
                        SoNguoi = ph.SoNguoi,
                        HoatDong = ph.HoatDong,
                        GhiChu = ph.GhiChu,
                        TongNguoi = ph.TongNguoi,
                        TuNgay = ph.TuNgay,
                        ToiNgay = ph.ToiNgay
                    };

                return list_phong.ToList<Phong_B>();
            }
            catch { return null; }
        }
        public List<Phong_B> ListPhong()
        {
            try
            {
                var list_phong =
                    from ph in dtcontent.Phongs
                    join khu in dtcontent.Khus on ph.MaKhu equals khu.MaKhu
                    where ph.HoatDong == true
                    select new Phong_B
                    {
                       MaPhong=ph.MaPhong,
                       MaKhu=ph.MaKhu,
                       TenPhong=ph.TenPhong,
                       TenKhu = khu.TenKhu,
                       GiaPhong=ph.GiaPhong,
                       SoNguoi=ph.SoNguoi,
                       HoatDong=ph.HoatDong,
                       GhiChu=ph.GhiChu,
                       TongNguoi=ph.TongNguoi,
                       TuNgay = ph.TuNgay,
                       ToiNgay = ph.ToiNgay
                    };

                return list_phong.ToList<Phong_B>();
            }
            catch { return null; }
        }

        public bool InsertPhong(Phong ph)
        {
            try
            {
                dtcontent.Phongs.InsertOnSubmit(ph);
                dtcontent.SubmitChanges();
                return true;
            }
            catch { return false; }

        }

        public void DeletePhong(string MaPhong)
        {
            var query = (from h in dtcontent.Phongs where h.MaPhong == MaPhong select h).First();
            dtcontent.Phongs.DeleteOnSubmit(query);
            dtcontent.SubmitChanges();
            query.HoatDong = false;
        }
        public Phong PhongTheoMa(string mp)
        {
            var phong = (from p in dtcontent.Phongs where p.MaPhong == mp select p).First();
            return (Phong)phong;
        }
        public bool UpdatePhong(Phong ph)
        {
            Phong phong = dtcontent.Phongs.Single(p => p.MaPhong == ph.MaPhong);
            phong.MaKhu = ph.MaKhu;
            phong.SoNguoi = ph.SoNguoi;
            phong.TenPhong = ph.TenPhong;
            phong.GhiChu = ph.GhiChu;
            phong.GiaPhong = ph.GiaPhong;
            phong.HoatDong = ph.HoatDong;
            try
            {
                dtcontent.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool KiemTraPhong(string maphong)
        {
            if ((from kt in dtcontent.Phongs where kt.MaPhong == maphong select kt).Count() > 0)
                return true;
            return false;
        }

        public List<Phong> ListPhong1()
        {
            try
            {
                var list_phong =
                    from ph in dtcontent.Phongs
                    select ph;
                return list_phong.ToList<Phong>();
            }
            catch { return null; }
        }
    }

}
