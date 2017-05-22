using System;

namespace QLNT.Report
{
    public partial class reportDienNuoc : DevExpress.XtraReports.UI.XtraReport
    {
        public reportDienNuoc(object data)
        {
            InitializeComponent();
            DuLieu(data);
        }

        public void DuLieu(object data)
        {
            cellThang.DataBindings.Add("Text", data, "Thang");
            cellNam.DataBindings.Add("Text", data, "Nam");
            cellKhu.DataBindings.Add("Text", data, "TenKhu");
            cellPhong.DataBindings.Add("Text", data, "TenPhong");
            cellDienChiSoCu.DataBindings.Add("Text", data, "SoDienCu", "{0:#,#}");
            cellDienChiSoMoi.DataBindings.Add("Text", data, "SoDienMoi", "{0:#,#}");
            cellSoDien.DataBindings.Add("Text", data, "SoDienTieuThu", "{0:#,#}");
            cellNuocChiSoCu.DataBindings.Add("Text", data, "SoNuocCu", "{0:#,#}");
            cellNuocChiSoMoi.DataBindings.Add("Text", data, "SoNuocMoi", "{0:#,#}");
            cellSoNuoc.DataBindings.Add("Text", data, "SoNuocTieuThu", "{0:#,#}");
            cellGiaTienDien.DataBindings.Add("Text", data, "GiaTienDien", "{0:#,#} đồng");
            cellGiaTienNuoc.DataBindings.Add("Text", data, "GiaTienNuoc", "{0:#,#} đồng");
            cellTongTien.DataBindings.Add("Text", data, "TongTien", "{0:#,#} đồng");
        }
    }
}
