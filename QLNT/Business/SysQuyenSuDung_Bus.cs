using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
    public class SysQuyenSuDung_Bus
    {
        QLNTDataContext dtcontext = new QLNTDataContext();
        public List<SysQuyenSuDung> SelectQuyenSuDung(string manhom, string machucnang)
        {
            var dt = from qsd in dtcontext.SysQuyenSuDungs
                     where qsd.MaNhom == manhom && qsd.MaChucNang == machucnang
                     select qsd;
            return dt.ToList<SysQuyenSuDung>();
        }

        public List<SysQuyenSuDung> SelectNhomQuyen(string manhom)
        {
            var dt = from qsd in dtcontext.SysQuyenSuDungs
                     where qsd.MaNhom == manhom
                     select qsd;
            return dt.ToList<SysQuyenSuDung>();
        }

        public void insertQuyenSuDung(string manhom)
        {
            try
            {
                for (int i = 1; i <= 22; i++)
                {
                    SysQuyenSuDung qsd = new SysQuyenSuDung()
                    {
                        MaNhom = manhom,
                        MaChucNang = i.ToString(),
                        MaThaoTac = 1,
                        TatCa = true,
                        Them = true,
                        Xoa = true,
                        Sua = true,
                        TruyCap = true,
                        InAn = true,
                        XuatDuLieu = true,
                        NhapDuLieu = true,
                        HoatDong = true
                    };
                    dtcontext.SysQuyenSuDungs.InsertOnSubmit(qsd);
                    dtcontext.SubmitChanges();
                }
            }
            catch
            {
            }
        }
        public bool UpdateQuyenSuDung(SysQuyenSuDung qsd)
        {
            try
            {
                SysQuyenSuDung qsds = dtcontext.SysQuyenSuDungs.Single(p => p.MaNhom == qsd.MaNhom && p.MaChucNang == qsd.MaChucNang);
                qsds.MaThaoTac = qsd.MaThaoTac;
                qsds.TatCa = qsd.TatCa;
                qsds.Them = qsd.Them;
                qsds.Xoa = qsd.Xoa;
                qsds.Sua = qsd.Sua;
                qsds.TruyCap = qsd.TruyCap;
                qsds.InAn = qsd.InAn;
                qsds.NhapDuLieu = qsd.NhapDuLieu;
                qsds.XuatDuLieu = qsd.XuatDuLieu;
                qsds.HoatDong = qsd.HoatDong;
                dtcontext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteQuyenSuDung(string manhom)
        {
            try
            {
                var query = (from nq in dtcontext.SysQuyenSuDungs
                             where nq.MaNhom == manhom
                             select nq
                    );
                dtcontext.SysQuyenSuDungs.DeleteAllOnSubmit(query);
                dtcontext.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
