using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;

namespace QLNT.Report
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
    {
        public Report(object _source)
        {
            InitializeComponent();
            LayDuLieu(_source);
        }
    
        private void LayDuLieu(object _source)
        {
            cellHoTen.DataBindings.Add("Text", _source, "HoTen");
            cellNgaySinh.DataBindings.Add("Text", _source, "NgaySinh","{0: dd/MM/yyyy}");
            cellLop.DataBindings.Add("Text", _source, "TenLop");
            cellKhoa.DataBindings.Add("Text", _source, "TenKhoaHoc");
            cellHKTT.DataBindings.Add("Text", _source, "TenHoKhau");
            cellDanToc.DataBindings.Add("Text", _source, "TenDanToc");
            cellTonGiao.DataBindings.Add("Text", _source, "TenTonGiao");
            cellDT.DataBindings.Add("Text", _source, "SDT");
            cellPhong.DataBindings.Add("Text", _source, "TenPhong");
            if ( xrPicture.DataBindings.Add("Image", _source, "Anh")!=null)
            {
                xrPicture.DataBindings.Add("Image", _source, "Anh");
            }
            else
            {
                xrPicture.Image = Image.FromFile("\\..\\Resource\\Graduate-male.png");
            }
           
            
        }

       

    }
}
