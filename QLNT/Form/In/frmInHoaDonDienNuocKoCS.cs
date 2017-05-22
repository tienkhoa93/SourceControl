using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Linq;
using QLNT.LinQToSQL;
using QLNT.Business;
using DevExpress.XtraReports.UI;

namespace QLNT.Form.In
{
    public partial class frmInHoaDonDienNuocKoCS : DevExpress.XtraEditors.XtraForm
    {
        QLNTDataContext db = new QLNTDataContext();
        //  SinhVienBus svb = new SinhVienBus();
        LinQToSQL.KhachTro sv = new QLNT.LinQToSQL.KhachTro();
        DienNuoc_Bus dnb = new DienNuoc_Bus();
        public frmInHoaDonDienNuocKoCS()
        {
            InitializeComponent();
            glkPhongBan.Select();
            Table<Phong> phong = db.GetTable<Phong>();
            glkPhongBan.Properties.DisplayMember = "TenPhong";
            glkPhongBan.Properties.ValueMember = "MaPhong";
            glkPhongBan.Properties.DataSource = phong;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dnb.ListDienNuocSoTienTheoPhong(glkPhongBan.EditValue.ToString()).Count != 0)
            {
                var dt = dnb.ListDienNuocSoTienTheoPhong(glkPhongBan.EditValue.ToString());
                Report.HoaDonDienNuoc_KoChiSo rp = new Report.HoaDonDienNuoc_KoChiSo(dt);
                rp.DataSource = dt;
                rp.ShowPreview();
            }
            else
            {
                XtraMessageBox.Show("Phòng này chưa có Hóa đơn!");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}