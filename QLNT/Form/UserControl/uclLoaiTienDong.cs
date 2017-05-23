using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNT.Business;
using Common;

namespace QLNT.Form.UserControl
{
    public partial class uclLoaiTienDong : DevExpress.XtraEditors.XtraUserControl
    {
        Tien_Buss tb = new Tien_Buss();
        public uclLoaiTienDong()
        {
            InitializeComponent();
            gridThongTinTien.DataSource = tb.ListThongTinTien();
        }
        void RefeshG(object b)
        {
            gridThongTinTien.DataSource = b;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form.DienNuoc.frmThongTinDongTien tt = new DienNuoc.frmThongTinDongTien(Common.ChucNang.Them,null);
            Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            tt.ShowDialog();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<LinQToSQL.ThongTinDongTien> listtttd = (List<LinQToSQL.ThongTinDongTien>)gridView1.DataSource;
            LinQToSQL.ThongTinDongTien tttd = listtttd[gridView1.FocusedRowHandle];
            Form.DienNuoc.frmThongTinDongTien tt = new DienNuoc.frmThongTinDongTien(Common.ChucNang.Sua, tttd);
            Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            tt.ShowDialog();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<LinQToSQL.ThongTinDongTien> listtttd = (List<LinQToSQL.ThongTinDongTien>)gridView1.DataSource;
            LinQToSQL.ThongTinDongTien tttd = listtttd[gridView1.FocusedRowHandle];
           
            if(tb.DeleteThongTinTien(tttd.MaLoaiTien))
                 gridView1.DeleteSelectedRows();
        }
        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // gridThongTinTien.DataSource = tb.ListThonglatheTinTien();
        }
    }
}
