using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.LinQToSQL;
// From ky luat 
namespace QLNT.Business
{
   public class KyLuat_Bus
    {
       QLNTDataContext dtcontent = new QLNTDataContext();
       Log_Bus lb = new Log_Bus();
       #region Kỷ luật
   
       //-------------------------------------Kỷ Luật----------------------------------------
       public List<LinQToSQL.KyLuat> ListKyLuat()
       {
           return (
                        (from ht in dtcontent.KyLuats select ht).ToList<LinQToSQL.KyLuat>()
               );
       }
       public bool InsertKyLuat(KyLuat kl)
       {
           try {
               dtcontent.KyLuats.InsertOnSubmit(kl);
               dtcontent.SubmitChanges();
               lb.InsertLog("Thêm kỷ luật ","");
               return true;
           }
           catch
           {
               return false;
           }
       }

       public bool DeleteKyLuat(int id)
       {
           try {
               dtcontent.KyLuats.DeleteOnSubmit((from k in dtcontent.KyLuats where k.id == id select k).First());
               dtcontent.SubmitChanges();
               lb.InsertLog("Xóa kỷ luật ", "");
               return true;
           }
           catch { return false; }
           
       }
       public bool CheckSuaKyLuat(int id)
       {
           try
           {
               var c = (from kl in dtcontent.KyLuats where  kl.id!=id select kl).First();
               if (c.id == null)
                   return true;
           }
           catch { return true; }
           return false;
       }

       public bool UpdateKyLuat(KyLuat k)
       {
           
                   LinQToSQL.KyLuat kyluat = (from kl in dtcontent.KyLuats where kl.id == k.id select kl).First();
                   kyluat.MaPhong = k.MaPhong;
                   kyluat.MaHinhThucKyLuat = k.MaHinhThucKyLuat;
                   kyluat.GhiChu = k.GhiChu;
                   kyluat.NgayKyLuat = k.NgayKyLuat;
                   try
                   {
                   dtcontent.SubmitChanges();
                   lb.InsertLog("Sửa kỷ luật ", "");
                   return true;
           }
           catch { return false; }
           

       }
      #endregion
       //-----------------------------Hinh Thức kỷ luật-------------------------------------
       #region Hình thức kỷ luật
       
       public List<LinQToSQL.HinhThucKyLuat> ListHinhThucKyLuat()
       {
           return(
                  (from ht in dtcontent.HinhThucKyLuats select ht).ToList<LinQToSQL.HinhThucKyLuat>()
               );
       }
       public bool CheckSuaHTKL(int id,string m)
       {
           try
           {
               var c = (from ht in dtcontent.HinhThucKyLuats where ht.MaHinhThucKyLuat == m && ht.id!=id select ht).First();
               if (c.MaHinhThucKyLuat == null)
                   return true;
           }
           catch { return true; }

           return false;
       }

       public bool CheckHTKL(string m)
       {
           try {
               var c = (from ht in dtcontent.HinhThucKyLuats where ht.MaHinhThucKyLuat==m select ht).First();
               if (c.MaHinhThucKyLuat == null)
                   return true;
           }
           catch { return true; }

           return false;
       }
       public bool InsertHTKL(LinQToSQL.HinhThucKyLuat htkl)
       {
           try
           {
               dtcontent.HinhThucKyLuats.InsertOnSubmit(htkl);
               dtcontent.SubmitChanges();
               lb.InsertLog("Thêm hình thức kỷ luật ", "");
               return true;
           }
           catch { return false; }
       }
       public bool UpdateHTKL(LinQToSQL.HinhThucKyLuat htkl)
       {
           try
           {
               LinQToSQL.HinhThucKyLuat ht = dtcontent.HinhThucKyLuats.Single(t => t.id == htkl.id);
               ht.GhiChu = htkl.GhiChu;
               ht.MaHinhThucKyLuat = htkl.MaHinhThucKyLuat;
               ht.TenHinhThucKyLuat = htkl.TenHinhThucKyLuat;
               dtcontent.SubmitChanges();
               lb.InsertLog("Sửa hình thức kỷ luật ", "");
               return true;
           }
           catch { return false; }
       }
       public bool DeleteHinhThucKyLuat(int ma)
       {
           try
           {
               dtcontent.HinhThucKyLuats.DeleteOnSubmit((from h in dtcontent.HinhThucKyLuats where h.id == ma select h).First());
               dtcontent.SubmitChanges();
               lb.InsertLog("Xóa hình thức kỷ luật ", "");
               return true;
           }
           catch { return false; }

       }

       #endregion

    }
}
