using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.LinQToSQL;
using System.Windows.Forms;

namespace QLNT.Business
{
    public class Khu_Bus
    {
        QLNTDataContext datacontent = new QLNTDataContext();
        Log_Bus lb = new Log_Bus();
        public List<Khu> KhuTheoMa(List<String> mk)
        {
            List<Khu> t = new List<Khu>();
            try
            {
                foreach (string m in mk)
                    t.AddRange(
                              (from khu in datacontent.Khus
                               where khu.MaKhu == m
                               select khu).ToList<Khu>());
            }
            catch { return t; }
            return t;
        }
        public List<Khu> GetAllKhu()
        {
            try
            {
                var list_k = from khu in datacontent.Khus where khu.HoatDong == true select khu;
                return list_k.ToList<Khu>();
            }
            catch { return null; }

        }

        public class Khu_Count : Khu
        {
            public int SoPhong { get; set; }
        }
        public List<Khu_Count> GetAllKhu_Count()
        {
            //var query = (from khu in datacontent.Khus
            //             join phong in datacontent.Phongs on khu.MaKhu equals phong.MaKhu
            //             where khu.HoatDong == true
            //             group khu by khu.MaKhu into c
            //             select new Khu_Count
            //             {
            //                 MaKhu = c.Key,
            //                 SoPhong = c.Count() == null ? 0 : c.Count()
            //                 //SoPhong = c.Count(),                            
            //             });

            //var qr = (from k in query.ToList<Khu_Count>()
            //          join kh in datacontent.Khus on k.MaKhu equals kh.MaKhu

            //          select new Khu_Count
            //          {
            //              MaKhu = k.MaKhu,
            //              TenKhu = kh.TenKhu,
            //              SoPhong = k.SoPhong == null ? (int)0 : k.SoPhong,
            //              GhiChu = kh.GhiChu
            //          });
            //return qr.ToList<Khu_Count>();

            var query1 = (from khu in datacontent.Khus
                          where khu.HoatDong == true
                          select new Khu_Count
                          {
                              MaKhu = khu.MaKhu,
                              SoPhong = 0,
                              TenKhu = khu.TenKhu,
                              GhiChu = khu.GhiChu
                              //SoPhong = c.Count(),                            
                          });
            return query1.ToList<Khu_Count>();

            //var q =
            //from c in datacontent.Khus
            //join p in datacontent.Phongs on c.MaKhu equals p.MaKhu into ps
            //from p in ps.DefaultIfEmpty()
            //select new Khu_Count { MaKhu = c.MaKhu, TenKhu = c.TenKhu, SoPhong = p.TenPhong.Count() == null ? 0 : p.TenPhong.Count() };
            //return q.ToList<Khu_Count>();
        }

        public bool InsertKhu(Khu kh)
        {
            try
            {
                Khu khu = new Khu()
                {
                    MaKhu = kh.MaKhu == null ? String.Empty : kh.MaKhu,
                    TenKhu = kh.TenKhu == null ? String.Empty : kh.TenKhu,
                    GhiChu = kh.GhiChu == null ? String.Empty : kh.GhiChu,
                    HoatDong = true
                };
                datacontent.Khus.InsertOnSubmit(khu);
                datacontent.SubmitChanges();
                lb.InsertLog("Thêm khu " + khu.TenKhu, "thêm khu");
                return true;
            }
            catch { return false; }
        }

        public void DeleteKhu_Rac(string MaKhu)
        {
            var query = (from khu in datacontent.Khus
                         where khu.MaKhu == MaKhu
                         select khu).Single();
            query.HoatDong = false;
            datacontent.SubmitChanges();
            lb.InsertLog("Xóa khu ", "Xóa khu");
        }

        public bool Delete_to_Rac(List<String> mp)
        {
            try
            {
                foreach (string tem in mp)
                {
                    var query = (from khu in datacontent.Khus
                                 where khu.MaKhu == tem
                                 select khu).Single();
                    query.HoatDong = false;
                    datacontent.SubmitChanges();
                    lb.InsertLog("Xóa khu ", "Xóa khu");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public bool UpdateKhu(Khu kh)
        {
            try
            {
                Khu khu = datacontent.Khus.Single(p => p.MaKhu == kh.MaKhu);
                khu.MaKhu = kh.MaKhu;
                khu.TenKhu = kh.TenKhu;
                khu.GhiChu = kh.GhiChu;
                datacontent.SubmitChanges();
                lb.InsertLog("Sửa khu " + kh.TenKhu, "Sửa khu");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool KiemTraKhu(string mk, string tk)
        {

            if ((from kh in datacontent.Khus where kh.MaKhu == mk || kh.TenKhu == tk select kh).Count() > 0)
                return true;
            return false;
        }

        public int KiemTraTonTaiPhong(string mk)
        {
            return (from kh in datacontent.Phongs where kh.MaKhu == mk select kh).Count();
        }
    }
}
