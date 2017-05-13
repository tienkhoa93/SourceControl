using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
    public class VatTuBus
    {
        QLNTDataContext dtcontent = new QLNTDataContext();
        Log_Bus lb = new Log_Bus();
        public List<VatTu> ListVatTu()
        {
            var c = from vt in dtcontent.VatTus
                    select vt;
            return c.ToList<VatTu>();
        }
        public bool XoaVatTu(long mavattu)
        {
            try
            {
                var getData = (from vt in dtcontent.VatTus
                               where vt.MaVatTu == mavattu
                               select vt).Single();
                dtcontent.VatTus.DeleteOnSubmit(getData);
                dtcontent.SubmitChanges();
                lb.InsertLog("Xóa " + getData.TenVatTu, "thực hiện thao tác xóa trong quản lý vật tư.");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertVatTu(VatTu vt)
        {
            try
            {
                VatTu vattu = new VatTu()
                {
                    TenVatTu = vt.TenVatTu == null ? String.Empty : vt.TenVatTu,
                    GhiChu = vt.GhiChu == null ? String.Empty : vt.GhiChu,
                };
                dtcontent.VatTus.InsertOnSubmit(vattu);
                dtcontent.SubmitChanges();
                lb.InsertLog("Thêm " + vt.TenVatTu, "thực hiện thao tác thêm trong quản lý vật tư.");
                return true;
            }
            catch { return false; }
        }
        public bool UpdateVatTu(VatTu vt)
        {
            try
            {
                VatTu vattu = dtcontent.VatTus.Single(p => p.MaVatTu == vt.MaVatTu);
                vattu.TenVatTu = vt.TenVatTu;
                vattu.GhiChu = vt.GhiChu;
                dtcontent.SubmitChanges();
                lb.InsertLog("Sửa " + vt.TenVatTu, "thực hiện thao tác sửa trong quản lý vật tư.");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool KiemTraVatTu(string vt)
        {
            if ((from pb in dtcontent.VatTus where pb.TenVatTu == vt select pb).Count() > 0)
                return true;
            return false;
        }

    }

}
