using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLNT.Report
{
    public partial class ThongKeDienNuoc : DevExpress.XtraReports.UI.XtraReport
    {
        private object dt;
        private int loai;
        private int khoangthoigian;
        private ThongKeDienNuoc rp;

        public ThongKeDienNuoc(object dt, int loai, int khoang, int quynam)
        {
            InitializeComponent();
            DuLieu(dt, loai, khoang, quynam);
        }       

        public void DuLieu(object datasoucre, int loai, int khoang, int quynam) 
        {
            if (loai==1)
            {
                labTieuDe1.Text = " ĐIỆN NƯỚC TIÊU THỤ";
            }
            else labTieuDe1.Text = " TIỀN PHÒNG";
            if (khoang==1)
            {
                 labTieuDe2.Text = " THÁNG "+quynam + " - NĂM " + DateTime.Today.Year;
            }
            else
            {
                if (khoang == 2)
                {
                    labTieuDe2.Text = "QÚY "+quynam + " - NĂM " + DateTime.Today.Year;
                }
                else labTieuDe2.Text = "NĂM " + quynam;

            }

            cellThang.DataBindings.Add("Text", datasoucre, "Thang");
            cellTongDienTieuThu.DataBindings.Add("Text", datasoucre, "TongDienTieuThu");
            cellTongNuocTieuThu.DataBindings.Add("Text", datasoucre, "TongNuocTieuThu");
            cellTongTienDien.DataBindings.Add("Text", datasoucre, "TongTienDien");
            cellTongTienNuoc.DataBindings.Add("Text", datasoucre, "TongTienNuoc");
            cellTongTien.DataBindings.Add("Text", datasoucre, "TongTien");
        }
    }
}
