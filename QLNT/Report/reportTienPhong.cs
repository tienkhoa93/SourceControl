using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLNT.Report
{
    public partial class reportTienPhong : DevExpress.XtraReports.UI.XtraReport
    {
        public reportTienPhong(object dt)
        {
            InitializeComponent();
            DaTa(dt);
        }

        public void DaTa(object dt)
        {
            cellThang.DataBindings.Add("Text", dt, "Thang");
            cellNam.DataBindings.Add("Text", dt, "Nam");
            cellPhong.DataBindings.Add("Text", dt, "TenPhong");
            cellChiPhi.DataBindings.Add("Text", dt, "MaLoaiTien");
            cellSoTien.DataBindings.Add("Text", dt, "TongTien", "{0:#,#} đồng");
            cellNgayDong.DataBindings.Add("Text", dt, "NgayDong", "{0:dd/MM/yyyy}");
            cellGhiChu.DataBindings.Add("Text", dt, "GhiChu");
        }
    }
}
