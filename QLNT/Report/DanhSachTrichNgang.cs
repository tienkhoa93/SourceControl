using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;

namespace QLNT.Report
{
    public partial class DanhSachTrichNgang : DevExpress.XtraReports.UI.XtraReport
    {
        public DanhSachTrichNgang(object _source)
        {
            InitializeComponent();
            LayDuLieu(_source);
        }

        private void LayDuLieu(object _source)
        {

            cellHoTen.DataBindings.Add("Text", _source, "HoTen");
            cellNgaySinh.DataBindings.Add("Text", _source, "NgaySinh", "{0: dd/MM/yyyy}");
            cellHKTT.DataBindings.Add("Text", _source, "TenHoKhau");
            cellDanToc.DataBindings.Add("Text", _source, "TenDanToc");
            cellTonGiao.DataBindings.Add("Text", _source, "TenTonGiao");
            cellLop.DataBindings.Add("Text", _source, "TenLop");
            cellKhoa.DataBindings.Add("Text", _source, "TenKhoaHoc");
            cellPhongCu.DataBindings.Add("Text", _source, "TenPhongCu");
            cellGhiChu.DataBindings.Add("Text", _source, "GhiChu");
            cellPhong.DataBindings.Add("Text", _source, "TenPhong");
            GroupHeader1.GroupFields.Add(new GroupField("TenPhong"));
        }



    }
}
