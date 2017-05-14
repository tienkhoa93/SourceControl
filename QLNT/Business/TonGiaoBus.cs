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
           var c;
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

               return true;
           }
           catch { return false; }
       }

       public bool UpdateTonGiao(TonGiao tg)
       {
           try
           {

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

           }
           catch (Exception)
           {
               return false;
           }
       }
       public int KiemTraTonTaiTonGiao(long tg) //Để xóa
       {
           return (from sv in dtcontent.KhachTros where sv.MaTonGiao == tg select sv).Count();
       }

       public bool KiemTraTonGiao(string mhk) //Để thêm
       {
           if ((from pb in dtcontent.TonGiaos where pb.TenTonGiao == mhk select pb).Count() > 0)
               return true;
           return false;
       }
    
    }
}
