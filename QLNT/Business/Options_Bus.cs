using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using QLNT.LinQToSQL;

namespace QLNT.Business
{
   public class Options_Bus
    {
       LinQToSQL.QLNTDataContext datacontext = new LinQToSQL.QLNTDataContext();
       Log_Bus lb = new Log_Bus();
       /// <summary>
       /// Lay len bang Option tu csdl
       /// </summary>
       /// <returns></returns>
       public Option GetOp()
       {
           try
           {
               var op = (from o in datacontext.Options select o).First();
               return (Option)op;
           }
           catch
           {
               return null;
           }
       }

       public List<Option> ListOption()
       {
           var op = (from o in datacontext.Options select o);
           return op.ToList<Option>();
       }
       public bool UpdateOption(Option opp)
       {
           try {
           Option op = datacontext.Options.Single(p=> p.Id==1);
           op.HoTenChuTro = opp.HoTenChuTro;
           op.NgaySinh = opp.NgaySinh;
           op.CMND = opp.CMND;
           op.NgayCap = opp.NgayCap;
           op.NoiCap = opp.NoiCap;
           op.ThuongTru = opp.ThuongTru;
           op.GiaTienPhong = opp.GiaTienPhong;
           op.GiaTienDien = opp.GiaTienDien;
           op.GiaTienNuoc = opp.GiaTienNuoc;
           op.TenFileBackup =opp.TenFileBackup;
           op.LuufileBackup = opp.LuufileBackup;
           op.LuufileRestore = opp.LuufileRestore;
           datacontext.SubmitChanges();
           lb.InsertLog("Thay đổi bảng tùy chọn."," Đã thay đổi bảng tùy chọn trong phần mềm");
           return true;
           }
           catch { return false; }
           
       }

    }
}
