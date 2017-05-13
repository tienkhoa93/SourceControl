using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
   public  class SysChucNang_Bus
    {
       QLNTDataContext dtcontent = new QLNTDataContext();
        public List<SysChucNang> SelectSysChucNang_Cap(string capcha, int cap)
        {
            var dt = from cn in dtcontent.SysChucNangs
                     where cn.Cap == cap && cn.CapCha == capcha
                     select cn;
            return dt.ToList<SysChucNang>();
        }
    }
}
