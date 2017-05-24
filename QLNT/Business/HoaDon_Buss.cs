using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
    public class _HoaDon : HoaDon
    {
        public int SoDienCu { get; set; }
        public int SoDienMoi { get; set; }
        public int SoNuocCu { get; set; }
        public int SoNuocMoi { get; set; }
        public int SoNuocTieuThu { get; set; }
        public int SoDienTieuThu { get; set; }
        public double GiaTienDien { get; set; }
        public double GiaTienNuoc { get; set; }
        public double SoTienDien { get; set; }
        public double SoTienNuoc { get; set; }
        public string ThangNam { get; set; }
        public string TenPhong { get; set; }
    }
    public class HoaDon_Buss
    {
        QLNTDataContext dtcontent = new QLNTDataContext();
        Log_Bus lb = new Log_Bus();
        public void TaoHoaDon(int thang, int nam, string makhu)
        {
            try
            {
                dtcontent.NT_SP_TAOHOADON(thang, nam, makhu);
                dtcontent.SubmitChanges();
            }
            catch { }

        }
        public List<LinQToSQL.HoaDon> ListHoaDon()
        {
            var t = from dt in dtcontent.HoaDons select dt;
            return t.ToList<HoaDon>();
        }

        #region Demo Thống kê theo phòng
        //public object ListInHoaDon(List<int> ListId)
        //{
        //    List<_HoaDon> lhd = new List<_HoaDon>();
        //    foreach (int i in ListId)
        //    {
        //        var ob = (from hoadon in dtcontent.SPHOADONTIENPHONG(i)
        //                  select new _HoaDon
        //         {
        //             SoDienCu = int.Parse(hoadon.SoDienCu.ToString()) == null ? 0 : int.Parse(hoadon.SoDienCu.ToString()),
        //             SoDienMoi = int.Parse(hoadon.SoDienMoi.ToString()) == null ? 0 : int.Parse(hoadon.SoDienMoi.ToString()),
        //             SoDienTieuThu = int.Parse(hoadon.SoDienTieuThu.ToString()) == null ? 0 : int.Parse(hoadon.SoDienTieuThu.ToString()),
        //             GiaTienDien = double.Parse(hoadon.GiaTienDien.ToString()) == null ? 0 : double.Parse(hoadon.GiaTienDien.ToString()),
        //             SoTienDien = double.Parse(hoadon.SoTienDien.ToString()) == null ? 0 : double.Parse(hoadon.SoTienDien.ToString()),

        //             SoNuocCu = int.Parse(hoadon.SoNuocCu.ToString()) == null ? 0 : int.Parse(hoadon.SoNuocCu.ToString()),
        //             SoNuocMoi = int.Parse(hoadon.SoNuocMoi.ToString()) == null ? 0 : int.Parse(hoadon.SoNuocMoi.ToString()),
        //             SoNuocTieuThu = int.Parse(hoadon.SoNuocTieuThu.ToString()) == null ? 0 : int.Parse(hoadon.SoNuocTieuThu.ToString()),
        //             GiaTienNuoc = double.Parse(hoadon.GiaTienNuoc.ToString()) == null ? 0 : double.Parse(hoadon.GiaTienNuoc.ToString()),
        //             SoTienNuoc = double.Parse(hoadon.SoTienNuoc.ToString()) == null ? 0 : double.Parse(hoadon.SoTienNuoc.ToString()),

        //             TienPhong = double.Parse(hoadon.TienPhong.ToString()) == null ? 0 : double.Parse(hoadon.TienPhong.ToString()),
        //             ThangNam = hoadon.ThangNam,
        //             TenPhong = hoadon.TenPhong,
        //             TongTien = double.Parse(hoadon.TongTien.ToString()),
        //             NguoiDong = hoadon.NguoiDong,
        //             NgayDong = hoadon.NgayDong
        //         }).Single();
        //        lhd.Add((_HoaDon)ob);
        //    }

        //    return lhd;
        //} 
        #endregion

        public _HoaDon GetHoaDonTheoPhong(long id)
        {
            var ob = (from hoadon in dtcontent.NT_SP_HOADONTIENPHONG(id)
                      select new _HoaDon
                      {
                          SoDienCu = (int)hoadon.SoDienCu,
                          SoDienMoi = (int)hoadon.SoDienMoi,
                          SoDienTieuThu = (int)hoadon.SoDienTieuThu,
                          GiaTienDien = (double)hoadon.GiaTienDien,

                          SoTienDien = (double)hoadon.SoTienDien,

                          SoNuocCu = (int)hoadon.SoNuocCu,
                          SoNuocMoi = (int)hoadon.SoNuocMoi,
                          SoNuocTieuThu = (int)hoadon.SoNuocTieuThu,
                          GiaTienNuoc = (double)hoadon.GiaTienNuoc,
                          SoTienNuoc = (double)hoadon.SoTienNuoc,

                          TienPhong = (double)hoadon.TienPhong,
                          ThangNam = hoadon.ThangNam,
                          TenPhong = hoadon.TenPhong,
                          TongTien = (double)hoadon.TongTien,
                          NguoiDong = hoadon.NguoiDong,
                          NgayDong = (DateTime)hoadon.NgayDong
                      }).First();

            return (_HoaDon)ob;
        }

        public void XoaHoaDon(List<int> xoa)
        {
            foreach (int i in xoa)
            {
                try
                {
                    dtcontent.HoaDons.DeleteOnSubmit((from hd in dtcontent.HoaDons where hd.Id == i select hd).First());
                    dtcontent.SubmitChanges();
                }
                catch { }
            }
        }
        public void InsertHoaDon(List<int> list, DataTable dt)
        {
            HoaDon hd;
            foreach (int i in list)
            {
                hd = new HoaDon();
                int c = 0;
                try { c = int.Parse(dt.Rows[i]["Id"].ToString()); }
                catch { c = 0; }
                if (c != 0)
                {
                    hd = dtcontent.HoaDons.Single(d => d.Id == int.Parse(dt.Rows[i]["Id"].ToString()));
                }
                hd.MaPhong = dt.Rows[i]["MaPhong"].ToString();

                try { hd.DienNuocId = long.Parse(dt.Rows[i]["DienNuocId"].ToString()); }
                catch { }

                try { hd.TienID = long.Parse(dt.Rows[i]["TienID"].ToString()); }
                catch { }

                try { hd.TongTien = long.Parse(dt.Rows[i]["TongTien"].ToString()); }
                catch { }
                try
                {
                    hd.NgayDong = DateTime.Parse(dt.Rows[i]["NgayDong"].ToString());
                }
                catch
                { }
                hd.NguoiDong = dt.Rows[i]["NguoiDong"].ToString();
                try { hd.ThanhToan = bool.Parse(dt.Rows[i]["ThanhToan"].ToString()); }
                catch { hd.ThanhToan = false; }
                if (c == 0)
                {
                    try
                    {
                        dtcontent.HoaDons.InsertOnSubmit(hd);
                        dtcontent.SubmitChanges();
                    }
                    catch { }
                }
                else
                {
                    dtcontent.SubmitChanges();
                }

            }
        }
    }
}
