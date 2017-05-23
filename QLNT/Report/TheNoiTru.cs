using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;

namespace QLNT.Report
{
    public partial class TheNoiTru : DevExpress.XtraReports.UI.XtraReport
    {
        public TheNoiTru(object _source)
        {
            InitializeComponent();
            LayDuLieu(_source);
        }
       
        private void LayDuLieu(object _source)
        {
            cellHoTen.DataBindings.Add("Text", _source, "HoTen");
            cellNgaySinh.DataBindings.Add("Text", _source, "NgaySinh","{0: dd/MM/yyyy}");
            cellLop.DataBindings.Add("Text", _source, "TenLop");
            cellHKTT.DataBindings.Add("Text", _source, "TenHoKhau");
            cellPhong.DataBindings.Add("Text", _source, "TenPhong");
            xrPicture.DataBindings.Add("Image", _source, "Anh");
        }

       

    }
}
