using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLNT.Report
{
    public partial class HoaDonDienNuoc_KoChiSo : DevExpress.XtraReports.UI.XtraReport
    {
        public HoaDonDienNuoc_KoChiSo(object _source)
        {
            InitializeComponent();
            LayDuLieu(_source);
        }

        private void LayDuLieu(object _source)
        {
            cellNgayIn.Text = DateTime.Today.ToString();
            //cellCuDien.DataBindings.Add("Text", _source, "TenHoKhau");
            cellDien.DataBindings.Add("Text", _source, "TienDien");
            cellNuoc.DataBindings.Add("Text", _source, "TienNuoc");
            cellTong.DataBindings.Add("Text", _source, "TongTien");
            cellPhong.DataBindings.Add("Text", _source, "MaPhong");


        }

    }
}
