using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.LinQToSQL;

namespace QLNT.Business
{
    public class _KhachTro : KhachTro
    {
        public string TenPhong { get; set; }
        public string TenPhongCu { get; set; }
        public string TenDanToc { get; set; }
        public string TenTonGiao { get; set; }
        public string TenTrangThai { get; set; }
        public double TienPhong { get; set; }
        public double GiaTienDien { get; set; }
        public double GiaTienNuoc { get; set; }
        public string HoTen { get; set; }
        public string HoTenChuTro { get; set; }
        public DateTime NgaySinhChuTro { get; set; }
        public string CMNDChuTro { get; set; }
        public string NoiCapCMNDChuTro { get; set; }
        public string ThuongTruChuTro { get; set; }
        public DateTime NgayCapCMNDChuTro { get; set; }
    }

    public class KhachTro_Bus
    {
        QLNTDataContext datacontext = new QLNTDataContext();
        Log_Bus lb = new Log_Bus();

        public List<_KhachTro> ListDanhSachKhachTro()
        {
            try
            {
                var list_khachtro =
                    from khachtro in datacontext.KhachTros
                    join phong in datacontext.Phongs on khachtro.MaPhong equals phong.MaPhong into pg
                    from phg in pg.DefaultIfEmpty()
                    join phongcu in datacontext.Phongs on khachtro.MaPhongCu equals phongcu.MaPhong into phc
                    from phogc in phc.DefaultIfEmpty()
                    join dantoc in datacontext.DanTocs on khachtro.MaDanToc equals dantoc.MaDanToc
                    join tongiao in datacontext.TonGiaos on khachtro.MaTonGiao equals tongiao.MaTonGiao
                    join trangthai in datacontext.TrangThais on khachtro.MaTrangThai equals trangthai.MaTrangThai
                    where khachtro.HoatDong == true
                    select new _KhachTro
                    {
                        MaKhachTro = khachtro.MaKhachTro,
                        HoLot = khachtro.HoLot,
                        Ten = khachtro.Ten,
                        HoTen = khachtro.HoLot + " " + khachtro.Ten,
                        Anh = khachtro.Anh == null ? null : khachtro.Anh.ToArray(),
                        NgaySinh = khachtro.NgaySinh,
                        GioiTinh = khachtro.GioiTinh,
                        MaPhong = khachtro.MaPhong,
                        MaPhongCu = khachtro.MaPhongCu,
                        CMND = khachtro.CMND,
                        NoiCap = khachtro.NoiCap,
                        ThuongTru = khachtro.ThuongTru,
                        TamTru = khachtro.TamTru,
                        SDTLienHe = khachtro.SDTLienHe,
                        SDT = khachtro.SDT,
                        NgayVao = khachtro.NgayVao,
                        NgayRa = khachtro.NgayRa,
                        MaDanToc = khachtro.MaDanToc,
                        MaTonGiao = khachtro.MaTonGiao,
                        HoatDong = khachtro.HoatDong,
                        MaTrangThai = khachtro.MaTrangThai,
                        TruongPhong = khachtro.TruongPhong,
                        GhiChu = khachtro.GhiChu,
                        TenDanToc = dantoc.TenDanToc,
                        TenTonGiao = tongiao.TenTonGiao,
                        TenPhong = phg.TenPhong,
                        TenPhongCu = phogc.TenPhong,
                        TenTrangThai = trangthai.TenTrangThai
                    };

                return list_khachtro.ToList<_KhachTro>();
            }
            catch { return null; }
        }

        public _KhachTro SelectTheoMaKhachTro(string makhachtro)
        {
            Options_Bus optionbus = new Options_Bus();
            Option option = optionbus.ListOption()[0];
            try
            {
                var list_khachtro = (
                    from khachtro in datacontext.KhachTros
                    join phong in datacontext.Phongs on khachtro.MaPhong equals phong.MaPhong
                    join diennuoc in datacontext.DienNuocs on khachtro.MaPhong equals diennuoc.MaPhong into dnn
                    from diennuoct in dnn.DefaultIfEmpty()
                    join tien in datacontext.Tiens on khachtro.MaPhong equals tien.MaPhong into tienn
                    from tient in tienn.DefaultIfEmpty()
                    where khachtro.HoatDong == true && khachtro.MaKhachTro == makhachtro
                    select new _KhachTro
                    {
                        HoTenChuTro = option.HoTenChuTro,
                        NgaySinhChuTro = (DateTime)option.NgaySinh,
                        NgayCapCMNDChuTro = option.NgayCap == null ? DateTime.Parse("2-2-1000") : (DateTime)option.NgayCap,
                        CMNDChuTro = option.CMND,
                        NoiCapCMNDChuTro = option.NoiCap,
                        ThuongTruChuTro = option.ThuongTru,
                        HoTen = khachtro.HoLot + khachtro.Ten,
                        NgaySinh = khachtro.NgaySinh,
                        GioiTinh = khachtro.GioiTinh,
                        MaPhong = khachtro.MaPhong,
                        CMND = khachtro.CMND,
                        NoiCap = khachtro.NoiCap,
                        NgayCap = khachtro.NgayCap,
                        ThuongTru = khachtro.ThuongTru,
                        SDTLienHe = khachtro.SDTLienHe,
                        //GiaTienDien = diennuoct.GiaTienDien==null?0: double.Parse(diennuoct.GiaTienDien.ToString()),
                        //GiaTienNuoc = diennuoct.GiaTienNuoc==null?0:double.Parse(diennuoct.GiaTienNuoc.ToString()),
                        //TienPhong = tient.TongTien==null?0:double.Parse(tient.TongTien.ToString()),
                        GiaTienDien = option.GiaTienDien == null ? 0 : double.Parse(option.GiaTienDien.ToString()),
                        GiaTienNuoc = option.GiaTienNuoc == null ? 0 : double.Parse(option.GiaTienNuoc.ToString()),
                        TienPhong = option.GiaTienPhong == null ? 0 : double.Parse(option.GiaTienPhong.ToString())
                    }).First();

                return (_KhachTro)list_khachtro;
            }
            catch { return null; }
        }

        public List<_KhachTro> ListDanhSachKhachTro_TheoMaPhong(string map)
        {
            try
            {
                var list_khachtro =
                    from khachtro in datacontext.KhachTros
                    join phong in datacontext.Phongs on khachtro.MaPhong equals phong.MaPhong into compList
                    from resList in compList.DefaultIfEmpty()
                    join phongcu in datacontext.Phongs on khachtro.MaPhongCu equals phongcu.MaPhong into compList1
                    from pc in compList1.DefaultIfEmpty()
                    join dantoc in datacontext.DanTocs on khachtro.MaDanToc equals dantoc.MaDanToc into compList2
                    from dt in compList2.DefaultIfEmpty()
                    join tongiao in datacontext.TonGiaos on khachtro.MaTonGiao equals tongiao.MaTonGiao into compList3
                    from tg in compList3.DefaultIfEmpty()
                    join trangthai in datacontext.TrangThais on khachtro.MaTrangThai equals trangthai.MaTrangThai into compList4
                    from tt in compList4.DefaultIfEmpty()
                    where khachtro.HoatDong == true && khachtro.MaPhong == map
                    select new _KhachTro
                    {
                        MaKhachTro = khachtro.MaKhachTro,
                        HoLot = khachtro.HoLot,
                        Ten = khachtro.Ten,
                        NgaySinh = khachtro.NgaySinh,
                        GioiTinh = khachtro.GioiTinh,
                        MaPhong = khachtro.MaPhong,
                        MaPhongCu = khachtro.MaPhongCu,
                        CMND = khachtro.CMND,
                        NgayCap = khachtro.NgayCap,
                        NoiCap = khachtro.NoiCap,
                        ThuongTru = khachtro.ThuongTru,
                        TamTru = khachtro.TamTru,
                        SDTLienHe = khachtro.SDTLienHe,
                        SDT = khachtro.SDT,
                        NgayVao = khachtro.NgayVao,
                        NgayRa = khachtro.NgayRa,
                        MaDanToc = khachtro.MaDanToc,
                        MaTonGiao = khachtro.MaTonGiao,
                        HoatDong = khachtro.HoatDong,
                        MaTrangThai = khachtro.MaTrangThai,
                        TruongPhong = khachtro.TruongPhong,
                        GhiChu = khachtro.GhiChu == null ? " " : khachtro.GhiChu,
                        TenDanToc = dt.TenDanToc,
                        TenTonGiao = tg.TenTonGiao,
                        TenPhong = resList.TenPhong,
                        TenPhongCu = pc.TenPhong,
                        TenTrangThai = tt.TenTrangThai,
                        Anh = khachtro.Anh == null ? null : khachtro.Anh
                    };

                return list_khachtro.ToList<_KhachTro>();
            }
            catch { return null; }
        }

        public object ThongKeKhachTro(string mp, string mk, string gioitinh, short trangthai, DateTime t1, DateTime t2)
        {
            var ob = from khachtro in datacontext.NT_SP_THONGKE_KHACHTRO(mp, mk, gioitinh, trangthai, t1, t2)

                     select new _KhachTro
                     {
                         MaKhachTro = khachtro.MaKhachTro,
                         HoLot = khachtro.HoLot,
                         Ten = khachtro.Ten,
                         Anh = khachtro.Anh == null ? null : khachtro.Anh.ToArray(),
                         NgaySinh = khachtro.NgaySinh,
                         GioiTinh = khachtro.GioiTinh,
                         MaPhong = khachtro.MaPhong,
                         MaPhongCu = khachtro.MaPhongCu,
                         CMND = khachtro.CMND,
                         NoiCap = khachtro.NoiCap,
                         ThuongTru = khachtro.ThuongTru,
                         TamTru = khachtro.TamTru,
                         SDTLienHe = khachtro.SDTLienHe,
                         SDT = khachtro.SDT,
                         NgayVao = khachtro.NgayVao,
                         NgayRa = khachtro.NgayRa,
                         MaDanToc = khachtro.MaDanToc,
                         MaTonGiao = khachtro.MaTonGiao,
                         HoatDong = khachtro.HoatDong,
                         MaTrangThai = khachtro.MaTrangThai,
                         TruongPhong = khachtro.TruongPhong,
                         GhiChu = khachtro.GhiChu,
                         TenDanToc = khachtro.TenDanToc,
                         TenTonGiao = khachtro.TenTonGiao,
                         TenPhong = khachtro.TenPhong,
                         TenPhongCu = khachtro.TenPhongCu,
                         TenTrangThai = khachtro.TenTrangThai
                     };
            return ob.ToList<_KhachTro>();
        }
        public bool InsertKhachTro(KhachTro kh)
        {
            try
            {
                datacontext.KhachTros.InsertOnSubmit(kh);
                datacontext.SubmitChanges();

                datacontext.NT_sp_DemSoNguoi(kh.MaPhong);
                datacontext.SubmitChanges();
                lb.InsertLog("Thêm một khách trọ", "");
                return true;
            }
            catch { return false; }

        }


        public List<_KhachTro> ListDanhSachKhachTroDaXoa()
        {
            try
            {
                var list_khachtro =
                    from khachtro in datacontext.KhachTros
                    join phong in datacontext.Phongs on khachtro.MaPhong equals phong.MaPhong into compList
                    from resList in compList.DefaultIfEmpty()
                    join phongcu in datacontext.Phongs on khachtro.MaPhongCu equals phongcu.MaPhong into compList1
                    from pc in compList1.DefaultIfEmpty()
                    join dantoc in datacontext.DanTocs on khachtro.MaDanToc equals dantoc.MaDanToc into compList2
                    from dt in compList2.DefaultIfEmpty()
                    join tongiao in datacontext.TonGiaos on khachtro.MaTonGiao equals tongiao.MaTonGiao into compList3
                    from tg in compList3.DefaultIfEmpty()
                    join trangthai in datacontext.TrangThais on khachtro.MaTrangThai equals trangthai.MaTrangThai into compList4
                    from tt in compList4.DefaultIfEmpty()
                    where khachtro.HoatDong == false
                    select new _KhachTro
                    {
                        MaKhachTro = khachtro.MaKhachTro,
                        HoLot = khachtro.HoLot,
                        Ten = khachtro.Ten,
                        NgaySinh = khachtro.NgaySinh,
                        GioiTinh = khachtro.GioiTinh,
                        MaPhong = khachtro.MaPhong,
                        MaPhongCu = khachtro.MaPhongCu,
                        CMND = khachtro.CMND,
                        NgayCap = khachtro.NgayCap,
                        NoiCap = khachtro.NoiCap,
                        ThuongTru = khachtro.ThuongTru,
                        TamTru = khachtro.TamTru,
                        SDTLienHe = khachtro.SDTLienHe,
                        SDT = khachtro.SDT,
                        NgayVao = khachtro.NgayVao,
                        NgayRa = khachtro.NgayRa,
                        MaDanToc = khachtro.MaDanToc,
                        MaTonGiao = khachtro.MaTonGiao,
                        HoatDong = khachtro.HoatDong,
                        MaTrangThai = khachtro.MaTrangThai,
                        TruongPhong = khachtro.TruongPhong,
                        GhiChu = khachtro.GhiChu == null ? " " : khachtro.GhiChu,
                        TenDanToc = dt.TenDanToc,
                        TenTonGiao = tg.TenTonGiao,
                        TenPhong = resList.TenPhong,
                        TenPhongCu = pc.TenPhong,
                        TenTrangThai = tt.TenTrangThai,
                        Anh = khachtro.Anh == null ? null : khachtro.Anh
                    };

                return list_khachtro.ToList<_KhachTro>();
            }
            catch { return null; }
        }
        public void DeleteKhachTro(string MaKhachTro)
        {
            var query1 = (from sv in datacontext.KhachTros
                          where sv.MaKhachTro == MaKhachTro
                          select sv).Single();
            query1.HoatDong = false;
            datacontext.SubmitChanges();

            datacontext.NT_sp_DemSoNguoi(query1.MaPhong);
            datacontext.SubmitChanges();

            lb.InsertLog("Xóa khách trọ (Thùng rác) " + MaKhachTro, "Xóa khách trọ");
        }
        public void DeleteKhachTroLuon(string MaKhachTro)
        {
            var query = (from h in datacontext.KhachTros where h.MaKhachTro == MaKhachTro select h).First();
            datacontext.KhachTros.DeleteOnSubmit(query);
            datacontext.SubmitChanges();

            datacontext.NT_sp_DemSoNguoi(query.MaPhong);
            datacontext.SubmitChanges();

            lb.InsertLog("Xóa khách trọ (Xóa luôn) " + MaKhachTro, "Xóa khách trọ");

        }

        public void UndoKhachTro(string MaKhachTro)
        {
            var query1 = (from sv in datacontext.KhachTros
                          where sv.MaKhachTro == MaKhachTro
                          select sv).Single();
            query1.HoatDong = true;
            datacontext.SubmitChanges();

            datacontext.NT_sp_DemSoNguoi(query1.MaPhong);
            datacontext.SubmitChanges();

            lb.InsertLog("Khôi phục khách trọ " + MaKhachTro, "Khôi phục khách trọ");
        }
        public bool UpdateKhachTroTheoMaCu(string mc, KhachTro kh)
        {
            try
            {
                KhachTro khachtro = datacontext.KhachTros.Single(p => p.MaKhachTro == mc);

                khachtro.MaKhachTro = kh.MaKhachTro;
                khachtro.HoLot = kh.HoLot;
                khachtro.Ten = kh.Ten;
                khachtro.NgaySinh = kh.NgaySinh;
                khachtro.GioiTinh = kh.GioiTinh;
                khachtro.Anh = kh.Anh == null ? null : kh.Anh.ToArray();
                khachtro.MaPhong = kh.MaPhong;
                khachtro.MaPhongCu = kh.MaPhongCu;
                khachtro.MaDanToc = kh.MaDanToc;
                khachtro.MaTonGiao = kh.MaTonGiao;
                khachtro.MaTrangThai = kh.MaTrangThai;
                khachtro.CMND = kh.CMND;
                khachtro.NoiCap = kh.NoiCap;
                khachtro.NgayCap = kh.NgayCap;
                khachtro.SDTLienHe = kh.SDTLienHe;
                khachtro.SDT = kh.SDT;
                khachtro.NgayRa = kh.NgayRa;
                khachtro.NgayVao = kh.NgayVao;
                khachtro.TruongPhong = kh.TruongPhong;
                khachtro.GhiChu = kh.GhiChu;
                khachtro.ThuongTru = kh.ThuongTru;
                khachtro.TamTru = kh.TamTru;
                khachtro.HoatDong = kh.HoatDong;

                datacontext.SubmitChanges();
                datacontext.NT_sp_DemSoNguoi(khachtro.MaPhong);
                datacontext.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool UpdateKhachTro(KhachTro kh)
        {
            KhachTro khachtro = datacontext.KhachTros.Single(p => p.MaKhachTro == kh.MaKhachTro);
            khachtro.MaKhachTro = kh.MaKhachTro;
            khachtro.HoLot = kh.HoLot;
            khachtro.Ten = kh.Ten;
            khachtro.NgaySinh = kh.NgaySinh;
            khachtro.GioiTinh = kh.GioiTinh;
            khachtro.Anh = kh.Anh == null ? null : kh.Anh.ToArray();
            khachtro.MaPhong = kh.MaPhong;
            khachtro.MaPhongCu = kh.MaPhongCu;
            khachtro.MaDanToc = kh.MaDanToc;
            khachtro.MaTonGiao = kh.MaTonGiao;
            khachtro.MaTrangThai = kh.MaTrangThai;
            khachtro.CMND = kh.CMND;
            khachtro.NoiCap = kh.NoiCap;
            khachtro.NgayCap = kh.NgayCap;
            khachtro.SDTLienHe = kh.SDTLienHe;
            khachtro.SDT = kh.SDT;
            khachtro.NgayRa = kh.NgayRa;
            khachtro.NgayVao = kh.NgayVao;
            khachtro.TruongPhong = kh.TruongPhong;
            khachtro.GhiChu = kh.GhiChu;
            khachtro.ThuongTru = kh.ThuongTru;
            khachtro.TamTru = kh.TamTru;
            khachtro.HoatDong = kh.HoatDong;
            try
            {
                datacontext.SubmitChanges();
                datacontext.NT_sp_DemSoNguoi(khachtro.MaPhong);
                datacontext.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool KiemTraSoNguoi(string mp)
        {
            var d = (from phong in datacontext.Phongs where phong.MaPhong == mp select phong).First();
            var c = (from khach in datacontext.KhachTros where khach.MaPhong == mp where khach.HoatDong == true select khach);

            if (c.Count() >= d.TongNguoi)
                return false;

            return true;
        }
        public bool KiemTraKhachTro(string mkt)
        {
            try
            {
                if ((from kt in datacontext.KhachTros where kt.MaKhachTro == mkt select kt).Count() > 0)
                    return false;
                else return true;
            }
            catch
            {
                return true;
            }
        }
        public void ChuyenPhong(List<string> list, string mp)
        {
            string m = string.Empty;
            foreach (string l in list)
            {
                LinQToSQL.KhachTro kt = datacontext.KhachTros.Single(t => t.MaKhachTro == l);
                kt.MaPhongCu = kt.MaPhong;
                m = kt.MaPhong;
                kt.MaPhong = mp;

                try
                {
                    datacontext.SubmitChanges();
                    lb.InsertLog("Chuyển phòng cho khách trọ ", "Chuyển phòng thành công.");
                }
                catch { }
            }

            datacontext.NT_sp_DemSoNguoi(m);
            datacontext.SubmitChanges();

            datacontext.NT_sp_DemSoNguoi(mp);
            datacontext.SubmitChanges();
        }
    }
}
