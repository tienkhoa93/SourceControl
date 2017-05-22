using System;

namespace QLNT.Report
{
    public partial class HoaDonTienPhong : DevExpress.XtraReports.UI.XtraReport
    {
        public HoaDonTienPhong(object soucre)
        {
            InitializeComponent();
            GanDuLieu(soucre);
        }

        public void GanDuLieu(object datasource)
        {
            cellThangNam.DataBindings.Add("Text", datasource, "ThangNam");
            cellPhong.DataBindings.Add("Text", datasource, "TenPhong");

            cellNgayDong.DataBindings.Add("Text", datasource, "NgayDong", "{0:dd/MM/yyyy}");
            cellNguoiDong.DataBindings.Add("Text", datasource, "NguoiDong");

            cellChiSoCuDien.DataBindings.Add("Text", datasource, "SoDienCu");
            cellChiSoMoiDien.DataBindings.Add("Text", datasource, "SoDienMoi");
            cellDienTieuThu.DataBindings.Add("Text", datasource, "SoDienTieuThu");
            cellDonGiaDien.DataBindings.Add("Text", datasource, "GiaTienDien");
            cellThanhTienDien.DataBindings.Add("Text", datasource, "SoTienDien");
            cellTongCongDien.DataBindings.Add("Text", datasource, "SoTienDien");

            cellChiSoCuNuoc.DataBindings.Add("Text", datasource, "SoNuocCu");
            cellChiSoMoiNuoc.DataBindings.Add("Text", datasource, "SoNuocMoi");
            cellTieuThuNuoc.DataBindings.Add("Text", datasource, "SoNuocTieuThu");
            cellDonGiaNuoc.DataBindings.Add("Text", datasource, "GiaTienNuoc");
            cellThanhTienNuoc.DataBindings.Add("Text", datasource, "SoTienNuoc");
            cellTongCongNuoc.DataBindings.Add("Text", datasource, "SoTienNuoc");

            cellTienPhong.DataBindings.Add("Text", datasource, "TienPhong");
            cellTongThanhTien.DataBindings.Add("Text", datasource, "TongTien");
        }
    }
}
