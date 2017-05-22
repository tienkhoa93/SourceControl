using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
    public class DanTocBus
    {
        QLNTDataContext dtcontent = new QLNTDataContext();
        Log_Bus lb = new Log_Bus();
        public List<DanToc> ListDanToc()
        {
            var c = from dt in dtcontent.DanTocs
                    select dt;
            return c.ToList<DanToc>();
        }
        public bool InsertDanToc(DanToc dt)
        {
            try
            {
                DanToc dantoc = new DanToc()
                {
                    TenDanToc = dt.TenDanToc == null ? String.Empty : dt.TenDanToc,
                    GhiChu = dt.GhiChu == null ? String.Empty : dt.GhiChu,
                };
                dtcontent.DanTocs.InsertOnSubmit(dantoc);
                dtcontent.SubmitChanges();
                lb.InsertLog("Thêm dân tộc " + dt.TenDanToc, "Thêm dân tộc");
                return true;
            }
            catch { return false; }
        }
        public bool UpdateDanToc(DanToc dt)
        {
            try
            {
                DanToc dantoc = dtcontent.DanTocs.Single(p => p.MaDanToc == dt.MaDanToc);
                dantoc.TenDanToc = dt.TenDanToc;
 
                lb.InsertLog("Sửa dân tộc " + dt.TenDanToc, "Sửa dân tộc");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteDanToc(long MaDanToc)
        {
            try
            {
                var query = (from khu in dtcontent.DanTocs
                             where khu.MaDanToc == MaDanToc
                             select khu);
                dtcontent.DanTocs.DeleteAllOnSubmit(query);
                dtcontent.SubmitChanges();
                lb.InsertLog("Xóa dân tộc ", "Xóa dân tộc");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int KiemTraTonTaiDanToc(long kh)
        {
            return (from sv in dtcontent.KhachTros where sv.MaDanToc == kh select sv).Count();
        }
        public bool KiemTraDanToc(string tdt)
        {

            if ((from pb in dtcontent.DanTocs where pb.TenDanToc == tdt select pb).Count() > 0)
                return true;
            return false;
        }

    }
}
