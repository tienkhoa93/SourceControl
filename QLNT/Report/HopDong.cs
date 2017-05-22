using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLNT.Report
{
    public partial class HopDong : DevExpress.XtraReports.UI.XtraReport
    {
        public HopDong(object dt)
        {
            InitializeComponent();
            DuLieu(dt);
        }

        public void DuLieu(object data)
        {
            cellTenBenA.DataBindings.Add("Text", data, "HoTenChuTro");
            cellNgaySinhBenA.DataBindings.Add("Text", data, "NgaySinhChuTro", "{0:dd/MM/yyyy}");
            cellCMNDBenA.DataBindings.Add("Text", data, "CMNDChuTro");
            cellNgayCapBenA.DataBindings.Add("Text", data, "NgayCapCMNDChuTro", "{0:dd/MM/yyyy}");
            cellNoiCapBenA.DataBindings.Add("Text", data, "NoiCapCMNDChuTro");
            cellThuongTruBenA.DataBindings.Add("Text", data, "ThuongTruChuTro");
            cellHoTenBenB.DataBindings.Add("Text", data, "HoTen");
            cellNgaySinhBenB.DataBindings.Add("Text", data, "NgaySinh", "{0:dd/MM/yyyy}");
            cellCMNDBenB.DataBindings.Add("Text", data, "CMND");
            cellNgayCapBenB.DataBindings.Add("Text", data, "NgayCap", "{0:dd/MM/yyyy}");
            cellNoiCapBenB.DataBindings.Add("Text", data, "NoiCap");
            cellThuongTruBenB.DataBindings.Add("Text", data, "ThuongTru");
            cellSDTBenB.DataBindings.Add("Text", data, "SDTLienHe");
            cellGiaTien.DataBindings.Add("Text", data, "TienPhong", "{0:#,#} đồng");
            cellTienDien.DataBindings.Add("Text", data, "GiaTienDien", "{0:#,#} đ/kW");
            cellTienNuoc.DataBindings.Add("Text", data, "GiaTienNuoc", "{0:#,#} đ/M3 ");
        }
    }
}
