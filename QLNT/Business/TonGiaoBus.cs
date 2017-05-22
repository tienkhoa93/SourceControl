using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
   public class TonGiaoBus
    {
       QLNTDataContext dtcontent = new QLNTDataContext();
       Log_Bus lb = new Log_Bus();
       public List<TonGiao> ListTonGiao()
       {
           var c = from dt in dtcontent.TonGiaos
                   select dt;
           return c.ToList<TonGiao>();
       }

       public bool InsertTongGiao(TonGiao hktt)
       {
           try
           {
               TonGiao tongiao = new TonGiao()
               {
                   TenTonGiao = hktt.TenTonGiao == null ? String.Empty : hktt.TenTonGiao,
                   GhiChu = hktt.GhiChu == null ? String.Empty : hktt.GhiChu,
               };
               dtcontent.TonGiaos.InsertOnSubmit(tongiao);
               dtcontent.SubmitChanges();
               lb.InsertLog("Thêm " + hktt.TenTonGiao, "thực hiện thao tác thêm trong bảng tôn giáo");
               return true;
           }
           catch { return false; }
       }

       public bool UpdateTonGiao(TonGiao tg)
       {
           try
           {
               TonGiao tongiao = dtcontent.TonGiaos.Single(p => p.MaTonGiao == tg.MaTonGiao);
               tongiao.TenTonGiao = tg.TenTonGiao;
               tongiao.GhiChu = tg.GhiChu;
               dtcontent.SubmitChanges();
               lb.InsertLog("Sửa " + tg.TenTonGiao, "thực hiện thao tác Sửa trong bảng tôn giáo");
               return true;
           }
           catch
           {
               return false;
           }
       }
       public bool DeleteTonGiao(long MaTonGiao)
       {
           try
           {
               var query = (from khu in dtcontent.TonGiaos
                            where khu.MaTonGiao == MaTonGiao
                            select khu);
               dtcontent.TonGiaos.DeleteAllOnSubmit(query);
               dtcontent.SubmitChanges();
               lb.InsertLog("Xóa " + MaTonGiao, "thực hiện thao tác xóa trong bảng tôn giáo");
               return true;
           }
           catch (Exception)
           {
               return false;
           }
       }
       public int KiemTraTonTaiTonGiao(long tg)
       {
           return (from sv in dtcontent.KhachTros where sv.MaTonGiao == tg select sv).Count();
       }

       public bool KiemTraTonGiao(string mhk) 
       {
           if ((from pb in dtcontent.TonGiaos where pb.TenTonGiao == mhk select pb).Count() > 0)
               return true;
           return false;
       }
    
    }
}
