using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLNT.Business
{
    public class QuanLiVatTu_B
    {
        public long ID { get; set; }
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string TenVatTu { get; set; }
        public int? SoLuong { get; set; }
        public DateTime? NgaySuaChua { get; set; }
        public bool? ThayThe { get; set; }
        public bool? SuaChua { get; set; }
        public string GhiChu { get; set; }
    }
    public class QuanLyVatTuBus
    {
        private QLNTDataContext dtcontent = new QLNTDataContext();
        private Log_Bus lb = new Log_Bus();
        public List<QuanLiVatTu_B> ListQuanLyVatTu()
        {
            var c = from qlvt in dtcontent.QuanLyVatTus
                    join ph in dtcontent.Phongs on qlvt.MaPhong equals ph.MaPhong
                    select new QLNT.Business.QuanLiVatTu_B
                    {
                        ID = qlvt.ID,
                        MaPhong = qlvt.MaPhong,
                        TenPhong = "Phòng " + ph.TenPhong,
                        TenVatTu = qlvt.TenVatTu,
                        SoLuong = qlvt.SoLuong,
                        NgaySuaChua = qlvt.NgaySuaChua,
                    };
            lb.InsertLog("Xem danh sách quản lý vật tư.", string.Empty);
            return c.ToList<QuanLiVatTu_B>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="qlvt"></param>
        /// <returns></returns>
        public bool InsertQuanLyVatTu(QuanLiVatTu_B qlvt)
        {
            try
            {
                var quanlyvattu = new QuanLyVatTu()
               {
                    MaPhong = qlvt.MaPhong == null ? String.Empty : qlvt.MaPhong,
                    TenVatTu = qlvt.TenVatTu == null ? String.Empty : qlvt.TenVatTu,
                    SoLuong = qlvt.SoLuong,
                    NgaySuaChua = qlvt.NgaySuaChua == null ? DateTime.Today : qlvt.NgaySuaChua,
                    SuaChua = qlvt.SuaChua == null ? true : qlvt.SuaChua,
                    ThayThe = qlvt.ThayThe == qlvt.ThayThe,
                    GhiChu = qlvt.GhiChu == null ? String.Empty : qlvt.GhiChu,
                };
                dtcontent.QuanLyVatTus.InsertOnSubmit(quanlyvattu);
                dtcontent.SubmitChanges();
                lb.InsertLog("Thêm " + qlvt.TenPhong + qlvt.TenVatTu, "thực hiện thao tác thêm trong quản lý vật tư.");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void UpdateQuanLyVatTu(QuanLiVatTu_B quanlyvattu)
        {
            try
            {
                var qlvt = dtcontent.QuanLyVatTus.Single(p => p.MaPhong == quanlyvattu.MaPhong);
                qlvt.MaPhong = quanlyvattu.MaPhong;
                qlvt.TenVatTu = quanlyvattu.TenVatTu;
                qlvt.NgaySuaChua = quanlyvattu.NgaySuaChua;
                qlvt.ThayThe = quanlyvattu.ThayThe;
                qlvt.SuaChua = quanlyvattu.SuaChua;
                qlvt.GhiChu = quanlyvattu.GhiChu;
                dtcontent.SubmitChanges();
                qlvt.SoLuong = quanlyvattu.SoLuong;
                lb.InsertLog("Sửa ", "...");

                lb.InsertLog("Sửa ", "thực hiện thao tác sửa trong quản lý vật tư.");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        public void DeleteQuanLyVatTu(long ID)
        {
            var getData = (from example in dtcontent.QuanLyVatTus
                                       where example.ID == ID
                                       select example).Single();
            dtcontent.QuanLyVatTus.DeleteOnSubmit(getData);
            dtcontent.SubmitChanges();
        }
    }
}
