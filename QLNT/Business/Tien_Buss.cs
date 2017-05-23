using System;
using System.Collections.Generic;
using System.Linq;
using QLNT.LinQToSQL;
using System.Data;

namespace QLNT.Business
{
    public class _Tien : Tien
    {
        public string TenLoaiTien { get; set; }
        public float SoTien { get; set; }
        public string HoTenSV { get; set; }
        public string TenKhu { get; set; }
        public string TenPhong { get; set; }
    }

    public class Tien_Buss
    {
        private QLNTDataContext dtcontent = new QLNTDataContext();
        private Log_Bus lb = new Log_Bus();


        public string TenTien(string[] list)
        {
            var s = string.Empty;
            foreach (string c in list)
            {
                if (TenLoaiTien(c) == string.Empty)
                {
                    s += string.Empty;
                }
                else
                {
                    s += TenLoaiTien(c).ToString() + ",";
                }
            }
            s = s.Substring(0, s.Length - 1);
            return s;
        }
        public string TenLoaiTien(string i)
        {
            try
            {
                var c = (from lt in dtcontent.ThongTinDongTiens
                          where lt.MaLoaiTien == i
                          select lt.TenLoaiTien).First();
                return c.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// DanhSachTienDong
        /// </summary>
        /// <returns></returns>
        public DataTable ListTien()
        {
            var qr = (
                           from t in dtcontent.Tiens
                           join tt in dtcontent.ThongTinDongTiens on t.MaLoaiTien equals tt.MaLoaiTien into CMD
                       from CC in CMD.DefaultIfEmpty()
                           join sv in dtcontent.Phongs on t.MaPhong equals sv.MaPhong  into  compList
                       from resList in compList.DefaultIfEmpty()
                           join khu in dtcontent.Khus on resList.MaKhu equals khu.MaKhu into compList11
                       from compList1 in compList11.DefaultIfEmpty()

                           select new _Tien
                           {
                               ID = t.ID,
                               Thang = t.Thang,
                               Nam = t.Nam,
                               MaPhong = resList.MaPhong,
                               TenLoaiTien = CC.TenLoaiTien,
                               NgayDong = t.NgayDong,
                               MaLoaiTien = t.MaLoaiTien,
                               GhiChu = t.GhiChu,
                               TongTien = t.TongTien == null ? 0 : t.TongTien,
                               TenKhu =  compList1.TenKhu,
                               TenPhong = resList.TenPhong
                           }

                       ).ToList<_Tien>();
            return Common.List_to_Table.ToDataTable((List<_Tien>)qr);
        }
        public DataTable ListTien_TheoMaPhong(string mp)
        {
            var qr = (
                           from t in dtcontent.Tiens
                           join tt in dtcontent.ThongTinDongTiens on t.MaLoaiTien equals tt.MaLoaiTien into CMD
                           from CC in CMD.DefaultIfEmpty()
                           join sv in dtcontent.Phongs on t.MaPhong equals sv.MaPhong into compList
                           from resList in compList.DefaultIfEmpty()
                           where t.MaPhong == mp
                           select new _Tien
                           {
                               ID = t.ID,
                               MaPhong = resList.MaPhong,
                               TenLoaiTien = CC.TenLoaiTien,
                               NgayDong = t.NgayDong,
                               MaLoaiTien = t.MaLoaiTien,
                               GhiChu = t.GhiChu,
                               TongTien = t.TongTien == null ? 0 : t.TongTien,
                               TenPhong = resList.TenPhong
                           }

                       ).ToList<_Tien>();
            return Common.List_to_Table.ToDataTable((List<_Tien>)qr);
        }





        public List<LinQToSQL.ThongTinDongTien> ListThongTinTien()
        {
            return (
                        (from tt in dtcontent.ThongTinDongTiens
                          select tt).ToList<ThongTinDongTien>()
                );
        }




        /// <summary>
        /// Insert thong tin dong tien
        /// </summary>
        /// <param name="tt"></param>
        /// <returns></returns>
        public bool InsertThongTinTien(LinQToSQL.ThongTinDongTien tt)
        {
            try
            {
                dtcontent.ThongTinDongTiens.InsertOnSubmit(tt);
                dtcontent.SubmitChanges();
                lb.InsertLog("Thêm " + tt.TenLoaiTien, "thực hiện thao tác thêm trong bảng loại tiền đóng.");

                return true;
            }
            catch
            {
                return false;
            }
        }




        public bool UpdateThongTinTien(LinQToSQL.ThongTinDongTien tt)
        {
            try
            {
                var ttt = dtcontent.ThongTinDongTiens.Single(ttd => ttd.MaLoaiTien == tt.MaLoaiTien);
                ttt.TenLoaiTien = tt.TenLoaiTien;
                ttt.SoTienDong = tt.SoTienDong;
                ttt.GhiChu = tt.GhiChu;
                dtcontent.SubmitChanges();
                lb.InsertLog("Sửa " + tt.TenLoaiTien, "thực hiện thao tác sửa trong bảng loại tiền đóng.");

                return true;
            }
            catch
            {
                return false;
            }
        }



        public bool DeleteThongTinTien(string ma)
        {
            try
            {
                var c = dtcontent.ThongTinDongTiens.SingleOrDefault(p => p.MaLoaiTien == ma);
                dtcontent.ThongTinDongTiens.DeleteOnSubmit(c);
                dtcontent.SubmitChanges();
                lb.InsertLog("Xóa " + ma, "thực hiện thao tác xóa trong bảng loại tiền đóng.");

                return true;
            }
            catch
            {
                return false;
            }
        }






        public List<int> InsertListTien(List<int> li, DataTable dt)
        {
            LinQToSQL.Tien tien;

            foreach (int i in li)
            {
                tien = new Tien();
                if (dt.Rows[i]["ID"].ToString().Length > 0)
                {
                    try
                    {
                        tien = dtcontent.Tiens.Single(t => t.ID == int.Parse(dt.Rows[i]["ID"].ToString()));
                    }
                    catch
                    {
                    }
                }
                try
                {
                    tien.Thang = int.Parse(dt.Rows[i]["Thang"].ToString());
                }
                catch
                {
                }


                try
                {
                    tien.Nam = int.Parse(dt.Rows[i]["Nam"].ToString());
                }
                catch
                {
                }

                tien.MaLoaiTien = dt.Rows[i]["MaLoaiTien"].ToString() == null ? string.Empty : dt.Rows[i]["MaLoaiTien"].ToString();
                tien.MaPhong = dt.Rows[i]["MaPhong"].ToString() == null ? string.Empty : dt.Rows[i]["MaPhong"].ToString();

                try
                {
                    tien.TongTien = dt.Rows[i]["TongTien"].ToString() == null ? 0 : float.Parse(dt.Rows[i]["TongTien"].ToString());
                }
                catch
                {
                    tien.TongTien = 0;
                }
                try
                {
                    tien.NgayDong = DateTime.Parse(dt.Rows[i]["NgayDong"].ToString());
                }
                catch
                {
                }
                tien.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                try
                {
                    if (dt.Rows[i]["ID"].ToString().Length <= 0)
                    {
                        dtcontent.Tiens.InsertOnSubmit(tien);
                        dtcontent.SubmitChanges();
                    }
                    else
                    {
                        dtcontent.SubmitChanges();
                    }
                    lb.InsertLog("Thêm " + tien.MaPhong + tien.NgayDong, "thực hiện thao tác thêm trong bảng đóng tiền.");
                }
                catch
                {
                }
            }
            return li;
        }


        public void DeleteMaTien(List<int> str)
        {
            foreach (int tem in str)
            {
                try
                {
                    dtcontent.Tiens.DeleteOnSubmit((from t in dtcontent.Tiens
                                                     where t.ID == tem
                                                     select t).First());
                    dtcontent.SubmitChanges();
                    lb.InsertLog("Xóa ", "thực hiện thao tác Xóa trong bảng đóng tiền.");
                }
                catch
                {
                }
            }
        }
    }
}
