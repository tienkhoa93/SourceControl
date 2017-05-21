using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLNT.Report
{
    public partial class DanhSachKhachTro : DevExpress.XtraReports.UI.XtraReport
    {
        public DanhSachKhachTro(object dt)
        {
            InitializeComponent();
            DuLieu(dt);
        }

        public void DuLieu(object datasoucre) 
        {
            cellSTT.DataBindings.Add("Text", datasoucre, "STT");
            cellHoLot.DataBindings.Add("Text", datasoucre, "HoLot");
            cellTen.DataBindings.Add("Text", datasoucre, "Ten");
            cellNgaySinh.DataBindings.Add("Text", datasoucre, "NgaySinh","{0:dd/MM/yyyy}");
            cellGioiTinh.DataBindings.Add("Text", datasoucre, "GioiTinh");
            cellThuongTru.DataBindings.Add("Text", datasoucre, "ThuongTru");
            cellPhong.DataBindings.Add("Text", datasoucre, "TenPhong");
            cellNgayVao.DataBindings.Add("Text", datasoucre, "NgayVao","{0:dd/MM/yyyy}");
            cellGhiChu.DataBindings.Add("Text", datasoucre, "GhiChu");
        }
    }
}
