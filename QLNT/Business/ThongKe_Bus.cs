﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.LinQToSQL;
namespace QLNT.Business
{
  public  class ThongKe_Bus
  {
      QLNTDataContext dtcontent = new QLNTDataContext();
      public class ThongKeKhu
      {
           public String TenKhu { get; set; }
           public int SoNguoi { get; set; }
      }
      //public class ThongKeKhu
      //{
      //    public String TenKhu { get; set; }
      //    public int SoNguoi { get; set; }
      //}


      public class ThongKeNamNu_
      {
         public String GioiTinh { get; set; }
         public int TongSo { get; set; }
      }
       
    }
}
