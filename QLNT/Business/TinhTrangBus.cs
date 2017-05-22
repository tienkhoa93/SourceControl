using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
    public class TinhTrangBus
    {
        QLNTDataContext dtcontent = new QLNTDataContext();
        Log_Bus lb = new Log_Bus();
        public List<TrangThai> ListTinhTrang()
        {
            var c = from dt in dtcontent.TrangThais
                    select dt;
            return c.ToList<TrangThai>();
        }
        public bool InsertTinhTrang(TrangThai tt)
        {
            try
            {
                TrangThai trangthai = new TrangThai()
                {
                    TenTrangThai = tt.TenTrangThai == null ? String.Empty : tt.TenTrangThai,
                    GhiChu = tt.GhiChu == null ? String.Empty : tt.GhiChu,
                };
                dtcontent.TrangThais.InsertOnSubmit(trangthai);
                dtcontent.SubmitChanges();
                lb.InsertLog("Thêm " + trangthai.TenTrangThai, "thực hiện thao tác thêm trong bảng trạng thái.");
                return true;
            }
            catch { return false; }
        }

        public bool UpdateTinhTrang(TrangThai tt)
        {
            try
            {
                TrangThai trangthai = dtcontent.TrangThais.Single(p => p.MaTrangThai == tt.MaTrangThai);
                trangthai.TenTrangThai = tt.TenTrangThai;
                trangthai.GhiChu = tt.GhiChu;
                dtcontent.SubmitChanges();
                lb.InsertLog("Sửa " + trangthai.TenTrangThai, "thực hiện thao tác sửa trong bảng trạng thái.");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteTrangThai(long MaTrangThai)
        {
            try
            {
                var query = (from khu in dtcontent.TrangThais
                             where khu.MaTrangThai == MaTrangThai
                             select khu);
                dtcontent.TrangThais.DeleteAllOnSubmit(query);
                dtcontent.SubmitChanges();
                lb.InsertLog("Xóa " + MaTrangThai, "thực hiện thao tác xóa trong bảng trạng thái.");

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int KiemTraTonTaiTrangThai(long kh)
        {
            return (from sv in dtcontent.KhachTros where sv.MaTrangThai == kh select sv).Count();
        }

        public bool KiemTraTinhTarang(string thk) //Để thêm
        {
            if ((from pb in dtcontent.TrangThais where pb.TenTrangThai == thk select pb).Count() > 0)
                return true;
            return false;
        }
    }
}
