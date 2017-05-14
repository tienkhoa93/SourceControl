using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLNT.Business
{
    public class _DienNuoc : LinQToSQL.DienNuoc
    {
        Log_Bus lb = new Log_Bus();
        public String MaKhu { get; set; }
        public String TenPhong { get; set; }
        public String TenKhu { get; set; }
       
    }
    public class DienNuocCu
    {
        public string MaPhong { get; set; }
        public int SoDienMoi { get; set; }
        public int SoNuocMoi { get; set; }
    }
    public class DienNuoc_Bus
    {

        LinQToSQL.QLNTDataContext dtcontent = new LinQToSQL.QLNTDataContext();
        Log_Bus lb = new Log_Bus();
        #region ĐIỆN NƯỚC THEO CHỈ SỐ

        public List<DienNuocCu> DienNuocCu(int thang, int nam, string makhu)
        {

            var ob = dtcontent.ExecuteQuery<DienNuocCu>("exec [dbo].[sp_LayDienNuocCu] " + thang + "," + nam + ",'" + makhu + "'");
            return ob.ToList<DienNuocCu>();
        }

        //Xoa dien nuoc theo ma phong ban
        public bool Delete_DienNuoc_TheoMaP(string mp)
        {
            try
            {
                dtcontent.DienNuocs.DeleteOnSubmit((from dn in dtcontent.DienNuocs where dn.MaPhong == mp && dn.TrangThai == true select dn).First());
                dtcontent.SubmitChanges();
                lb.InsertLog("Xóa điện nước theo chỉ số", "Xóa điện nước theo chỉ số");
                return true;
            }
            catch
            {
                return false;
            }
        }
        // Dien nuoc theo ma phong
        public List<_DienNuoc> ListDienNuoc_TheoMaPhong(string mp)
        {
            try
            {
                return (
                (from dn in dtcontent.DienNuocs
                 join pg in dtcontent.Phongs on dn.MaPhong equals pg.MaPhong
                 join khu in dtcontent.Khus on pg.MaKhu equals khu.MaKhu
                 where dn.MaPhong == mp
                 select new _DienNuoc
                 {
                     Id = dn.Id,
                     MaKhu = khu.MaKhu,
                     MaPhong = dn.MaPhong,
                     SoTienDien = dn.SoTienDien,
                     SoTienNuoc = dn.SoTienNuoc,
                     SoDienCu = dn.SoDienCu,
                     SoDienMoi = dn.SoDienMoi,
                     SoNuocCu = dn.SoNuocCu,
                     SoNuocMoi = dn.SoNuocMoi,
                     GiaTienDien = dn.GiaTienDien,
                     GiaTienNuoc = dn.GiaTienNuoc,
                     TongTien = dn.TongTien,
                     TrangThai = dn.TrangThai,
                     SoDienTieuThu = dn.SoDienTieuThu,
                     SoNuocTieuThu = dn.SoNuocTieuThu,
                     NgayDongTien = dn.NgayDongTien,
                     Thang = dn.Thang,
                     Nam = dn.Nam,
                     TenPhong=pg.TenPhong,
                     GhiChu = dn.GhiChu,
                     TenKhu=khu.TenKhu
                 }).ToList<_DienNuoc>()
                              );
            }
            catch { }
            return null;
        }
        //tra ve danh sach dien nuoc 
        public List<_DienNuoc> ListDienNuoc()
        {
            try {
            return (
            (from dn in dtcontent.DienNuocs
             join pg in dtcontent.Phongs on dn.MaPhong equals pg.MaPhong
             join khu in dtcontent.Khus on pg.MaKhu equals khu.MaKhu
             select new _DienNuoc
             {
                 Id = dn.Id,
                 MaKhu=khu.MaKhu,
                 MaPhong = dn.MaPhong,
                 SoTienDien = dn.SoTienDien,
                 SoTienNuoc = dn.SoTienNuoc,
                 SoDienCu = dn.SoDienCu,
                 SoDienMoi = dn.SoDienMoi,
                 SoNuocCu = dn.SoNuocCu,
                 SoNuocMoi = dn.SoNuocMoi,
                 GiaTienDien = dn.GiaTienDien,
                 GiaTienNuoc = dn.GiaTienNuoc,
                 TongTien = dn.TongTien,
                 TrangThai = dn.TrangThai,
                 SoDienTieuThu = dn.SoDienTieuThu,
                 SoNuocTieuThu = dn.SoNuocTieuThu,
                 NgayDongTien = dn.NgayDongTien,
                 Thang = dn.Thang,
                 Nam = dn.Nam,
                 GhiChu = dn.GhiChu,
                 TenKhu=khu.TenKhu,
                 TenPhong=pg.TenPhong
             }).ToList<_DienNuoc>()
                          );
            }
            catch { }
            return null;
        }
        public void Delete_DienNuoc_TheoListMaP(List<int> mp)
        {
            try
            {
                foreach (int st in mp)
                {
                    dtcontent.DienNuocs.DeleteOnSubmit((from dn in dtcontent.DienNuocs where dn.Id == st select dn).First());
                    dtcontent.SubmitChanges();
                    lb.InsertLog("Xóa danh sách điện nước theo chỉ số", "Xóa danh sách điện nước theo chỉ số");

                }
            }
            catch
            {

            }

        }

        public string Find_MaPhong(String tenphong)
        {
            String a = string.Empty;
            try
            {
                a = (from map in dtcontent.Phongs where map.MaPhong == tenphong select map).First().MaPhong;
            }
            catch { }
            if (a == string.Empty)
                a = (from map in dtcontent.Phongs where map.TenPhong == tenphong select map).First().MaPhong;
            return a;
        }

        bool Check(int thang, int nam, string maphong)
        {
            try
            {
                string c = (from dn in dtcontent.DienNuocs where dn.Thang == thang && dn.Nam == nam && dn.MaPhong == maphong select new { dn.MaPhong }).First().ToString();
                if (c == null)
                    return false;
            }
            catch { return false; }
            return true;

        }
        public void UpdateTableDienNuoc(DataTable table, List<int> list)
        {
        
            LinQToSQL.DienNuoc dn ;
          
           foreach(int i in list)
           {
               dn = new LinQToSQL.DienNuoc();
               int c = 0;
               try { c = int.Parse(table.Rows[i]["Id"].ToString()); }
               catch { c = 0; }
               if(c!=0)
               {
                   dn = dtcontent.DienNuocs.Single(d=> d.Id==int.Parse(table.Rows[i]["Id"].ToString()));
               }
               dn.MaPhong = table.Rows[i]["MaPhong"].ToString();
               dn.SoDienCu = int.Parse(table.Rows[i]["SoDienCu"].ToString());
               dn.SoDienMoi = int.Parse(table.Rows[i]["SoDienMoi"].ToString());
               dn.SoNuocCu = int.Parse(table.Rows[i]["SoNuocCu"].ToString());
               dn.SoNuocMoi = int.Parse(table.Rows[i]["SoNuocMoi"].ToString());
               dn.SoDienTieuThu = dn.SoDienMoi-dn.SoDienCu;
               dn.SoNuocTieuThu = dn.SoNuocMoi-dn.SoNuocCu;
               dn.GiaTienDien = double.Parse(table.Rows[i]["GiaTienDien"].ToString());
               dn.GiaTienNuoc = double.Parse(table.Rows[i]["GiaTienNuoc"].ToString());

               try { dn.TrangThai = bool.Parse(table.Rows[i]["TrangThai"].ToString()); }
               catch { dn.TrangThai = false; }
             
             
               dn.Thang = int.Parse(table.Rows[i]["Thang"].ToString());
               dn.Nam = int.Parse(table.Rows[i]["Nam"].ToString());
              
               try { dn.NgayDongTien = DateTime.Parse(table.Rows[i]["NgayDongTien"].ToString()); }
               catch {
                   dn.NgayDongTien = null;
               }
               dn.SoTienDien = dn.GiaTienDien*dn.SoDienTieuThu;
               dn.SoTienNuoc = dn.GiaTienNuoc*dn.SoNuocTieuThu;
               dn.TongTien = dn.SoTienDien+dn.SoTienNuoc;
               dn.GhiChu = table.Rows[i]["GhiChu"].ToString();
               if (c != 0)
               {
                   try { dtcontent.SubmitChanges(); }
                   catch { }
               }
               else
               {
                   try
                   {
                       dtcontent.DienNuocs.InsertOnSubmit(dn);
                       dtcontent.SubmitChanges();
                       lb.InsertLog("Sửa điện nước theo chỉ số", "Sửa điện nước theo chỉ số");
                   }
                   catch { }
                  
               }
           }

        }
        public void SaveDienNuoc(DataTable dt)
        {
            //đảm bảo ko trùng ngay tháng và một mã phòng.

            LinQToSQL.DienNuoc diennuoc;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                diennuoc = new LinQToSQL.DienNuoc();
                diennuoc.GiaTienDien = float.Parse(dt.Rows[i]["GiaTienDien"].ToString());
                diennuoc.GiaTienNuoc = float.Parse(dt.Rows[i]["GiaTienNuoc"].ToString());

                diennuoc.MaPhong = dt.Rows[i]["MaPhong"].ToString();
                diennuoc.SoTienDien = float.Parse(dt.Rows[i]["SoTienDien"].ToString());
                diennuoc.SoTienNuoc = float.Parse(dt.Rows[i]["SoTienNuoc"].ToString());
                diennuoc.SoDienCu = int.Parse(dt.Rows[i]["SoDienCu"].ToString());
                diennuoc.SoDienMoi = int.Parse(dt.Rows[i]["SoDienMoi"].ToString());
                diennuoc.SoNuocCu = int.Parse(dt.Rows[i]["SoNuocCu"].ToString());
                diennuoc.SoNuocMoi = int.Parse(dt.Rows[i]["SoNuocMoi"].ToString());
                diennuoc.SoDienTieuThu = int.Parse(dt.Rows[i]["SoDienTieuThu"].ToString());
                diennuoc.SoNuocTieuThu = int.Parse(dt.Rows[i]["SoNuocTieuThu"].ToString());
                diennuoc.TongTien = float.Parse(dt.Rows[i]["TongTien"].ToString());
                try
                {
                    diennuoc.TrangThai = bool.Parse(dt.Rows[i]["TrangThai"].ToString());
                }
                catch { diennuoc.TrangThai = false; }
              
                diennuoc.Thang = int.Parse(dt.Rows[i]["Thang"].ToString());
                diennuoc.Nam = int.Parse(dt.Rows[i]["Nam"].ToString());
                try { diennuoc.NgayDongTien = DateTime.Parse(dt.Rows[i]["NgayDongTien"].ToString()); }
                catch { }

                diennuoc.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                try
                {
                    dtcontent.DienNuocs.InsertOnSubmit(diennuoc);
                    dtcontent.SubmitChanges();


                }
                catch
                {
                    continue;
                }
                lb.InsertLog("Thêm điện nước theo chỉ số", "Thêm điện nước theo chỉ số");
            }
            
        }
        #endregion
        #region ĐIỆN NƯỚC THeO SỐ TIỀN

        public List<LinQToSQL.DienNuocTheoSoTien> ListDienNuocSoTien()
        { 
                return(
                        (from dn in dtcontent.DienNuocTheoSoTiens select dn).ToList<LinQToSQL.DienNuocTheoSoTien>()
                    );
        }

        public List<LinQToSQL.DienNuocTheoSoTien> ListDienNuocSoTienTheoPhong(string mp)
        {
            return (
                    (from dn in dtcontent.DienNuocTheoSoTiens where dn.MaPhong == mp select dn).ToList<LinQToSQL.DienNuocTheoSoTien>()
                );
        }

        public void InsertDatatable(List<int> row,DataTable dt)
        {
            LinQToSQL.DienNuocTheoSoTien dn;
            foreach (int i in row)
            {
                string tt = dt.Rows[i]["id"].ToString();
                dn = new LinQToSQL.DienNuocTheoSoTien();
                if (tt != "" )
                    dn = dtcontent.DienNuocTheoSoTiens.Single(d => d.Id == int.Parse(dt.Rows[i]["id"].ToString()));

                dn.Thang = int.Parse(dt.Rows[i]["Thang"].ToString());
                dn.Nam = int.Parse(dt.Rows[i]["Nam"].ToString());
                dn.MaPhong = dt.Rows[i]["MaPhong"].ToString();
                dn.TienDien = float.Parse(dt.Rows[i]["TienDien"].ToString());
                dn.TienNuoc = float.Parse(dt.Rows[i]["TienNuoc"].ToString());
                dn.TongTien = dn.TienDien + dn.TienNuoc;
                try { dn.DaThu = bool.Parse(dt.Rows[i]["DaThu"].ToString()); }
                catch { }
                
                try
                {
                    if (dt.Rows[i]["id"].ToString() == "")
                    {
                        dtcontent.DienNuocTheoSoTiens.InsertOnSubmit(dn);
                        dtcontent.SubmitChanges();
                        lb.InsertLog("Sửa điện nước theo số tiền", "Sửa điện nước theo số tiền");
                    }
                    else
                    {
                        dtcontent.SubmitChanges();
                        lb.InsertLog("Thêm điện nước theo số tiền", "Thêm điện nước theo số tiền");
                    }
                      
                }
                catch { }  
            }        
        }
        public void DeleteDienNuocSoTien(List<int> list)
        {
                foreach(int i in list)
                    {
                        try {
                            dtcontent.DienNuocTheoSoTiens.DeleteOnSubmit((from dn in dtcontent.DienNuocTheoSoTiens where dn.Id == i select dn).First());
                            dtcontent.SubmitChanges();
                            lb.InsertLog("Xóa điện nước theo số tiền", "Sửa điện nước theo số tiền");
                        }
                        catch { }
                    }
        }
        public void InsertDataTable(DataTable dt)
        {
            LinQToSQL.DienNuocTheoSoTien dnt ;
            foreach (DataRow r in dt.Rows)
            {
               dnt = new LinQToSQL.DienNuocTheoSoTien();
               dnt.Thang =int.Parse( r["Thang"].ToString());
               dnt.Nam = int.Parse(r["Nam"].ToString());
               dnt.MaPhong = r["MaPhong"].ToString();
               dnt.TienDien = float.Parse(r["TienDien"].ToString());
               dnt.TienNuoc = float.Parse(r["TienNuoc"].ToString());
               dnt.TongTien = float.Parse(r["TongTien"].ToString());          
               dnt.DaThu = bool.Parse(r["DaThu"].ToString());
               dtcontent.DienNuocTheoSoTiens.InsertOnSubmit(dnt);
               dtcontent.SubmitChanges();
               lb.InsertLog("Thêm điện nước theo số tiền", "Thêm điện nước theo số tiền");
            }
        }
	    #endregion
        #region THỐNG KÊ ĐIỆN NƯỚC
        public class ThongKeDienNuoc
        {
            public int Thang { get; set; }
            public int TongDienTieuThu { get; set; }
            public int TongNuocTieuThu { get; set; }
            public double TongTienDien { get; set; }
            public double TongTienNuoc { get; set; }
            public double TongTien { get; set; }

        }
        public List<ThongKeDienNuoc> ThongKeDienNuocTheoThang(int thang, int nam)
        {
            if (thang == 0)
            {
                return (from o in dtcontent.DienNuocs
                        group o by o.Thang into OD
                        orderby OD.Key
                        select new ThongKeDienNuoc
                        {
                            Thang = (int)OD.Key,
                            TongDienTieuThu = (int)OD.Sum(m => m.SoDienTieuThu),
                            TongNuocTieuThu = (int)OD.Sum(m => m.SoNuocTieuThu),
                            TongTienDien = (double)OD.Sum(m => m.SoTienDien),
                            TongTienNuoc = (double)OD.Sum(m => m.SoTienNuoc),
                            TongTien = (double)OD.Sum(m => m.TongTien),
                        }).ToList<ThongKeDienNuoc>();
            }
            else
            {
                return (from o in dtcontent.DienNuocs
                        where o.Thang == thang && o.Nam == nam
                        group o by o.Thang into OD
                        orderby OD.Key
                        select new ThongKeDienNuoc
                        {
                            Thang = (int)OD.Key,
                            TongDienTieuThu = (int)OD.Sum(m => m.SoDienTieuThu),
                            TongNuocTieuThu = (int)OD.Sum(m => m.SoNuocTieuThu),
                            TongTienDien = (double)OD.Sum(m => m.SoTienDien),
                            TongTienNuoc = (double)OD.Sum(m => m.SoTienNuoc),
                            TongTien = (double)OD.Sum(m => m.TongTien),
                        }).ToList<ThongKeDienNuoc>();
            }

        }
        public List<ThongKeDienNuoc> ThongKeDienNuocTheoQuy(int quy, int nam)
        {
            int thangbd, thangkt;
            switch (quy)
            {
                case 1:
                    thangbd = 1; thangkt = 3;
                    //do some stuff
                    break;
                case 2:
                    thangbd = 4; thangkt = 6;
                    //do some stuff
                    break;
                case 3:
                    thangbd = 7; thangkt = 9;
                    //do some stuff
                    break;
                case 4:
                    thangbd = 10; thangkt = 12;
                    //do some stuff
                    break;
                default:
                    thangkt = 12; thangbd = 1;
                    break;
            }

            if (quy == 0)
            {
                return (from o in dtcontent.DienNuocs
                        group o by o.Thang into OD
                        orderby OD.Key
                        select new ThongKeDienNuoc
                        {
                            Thang = (int)OD.Key,
                            TongDienTieuThu = (int)OD.Sum(m => m.SoDienTieuThu),
                            TongNuocTieuThu = (int)OD.Sum(m => m.SoNuocTieuThu),
                            TongTienDien = (double)OD.Sum(m => m.SoTienDien),
                            TongTienNuoc = (double)OD.Sum(m => m.SoTienNuoc),
                            TongTien = (double)OD.Sum(m => m.TongTien),
                        }).ToList<ThongKeDienNuoc>();
            }
            else
            {
                return (from o in dtcontent.DienNuocs
                        where o.Thang >= thangbd && o.Thang <= thangkt && o.Nam == nam
                        group o by o.Thang into OD
                        orderby OD.Key
                        select new ThongKeDienNuoc
                        {
                            Thang = (int)OD.Key,
                            TongDienTieuThu = (int)OD.Sum(m => m.SoDienTieuThu),
                            TongNuocTieuThu = (int)OD.Sum(m => m.SoNuocTieuThu),
                            TongTienDien = (double)OD.Sum(m => m.SoTienDien),
                            TongTienNuoc = (double)OD.Sum(m => m.SoTienNuoc),
                            TongTien = (double)OD.Sum(m => m.TongTien),
                        }).ToList<ThongKeDienNuoc>();
            }

        }
        public List<ThongKeDienNuoc> ThongKeDienNuocTheoNam(int nam)
        {

            return (from o in dtcontent.DienNuocs
                    where o.Nam == nam
                    group o by o.Nam into OD
                    orderby OD.Key
                    select new ThongKeDienNuoc
                    {
                        Thang = (int)OD.Key,
                        TongDienTieuThu = (int)OD.Sum(m => m.SoDienTieuThu),
                        TongNuocTieuThu = (int)OD.Sum(m => m.SoNuocTieuThu),
                        TongTienDien = (double)OD.Sum(m => m.SoTienDien),
                        TongTienNuoc = (double)OD.Sum(m => m.SoTienNuoc),
                        TongTien = (double)OD.Sum(m => m.TongTien),
                    }).ToList<ThongKeDienNuoc>();


        }
        #endregion
    }
}

