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

namespace QLNT.Form.Systems
{
    public partial class Options : DevExpress.XtraEditors.XtraForm
    {
        Business.Options_Bus opb = new Business.Options_Bus();
        LinQToSQL.Option op = new LinQToSQL.Option();
        public Options()
        {
            InitializeComponent();
            // code Don't resize form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            LinQToSQL.Option op = opb.GetOp();
            txtHoTenChuTro.Text = op.HoTenChuTro; 
            dateNgaySinh.EditValue = op.NgaySinh; 
            txtCMND.Text = op.CMND; 
            txtNoiCap.Text = op.NoiCap;
            txtDiaChiThuongTru.Text = op.ThuongTru; 
            calTienPhong.EditValue = op.GiaTienPhong;
            calGiaTienDien.Text = op.GiaTienDien.ToString(); 
            calGiaTienNuoc.Text = op.GiaTienNuoc.ToString(); 
            txtNameBackup.Text = op.TenFileBackup; 
            cboDuongDanBackup.Text = op.LuufileBackup; 
            cboDuongDanRestore.Text = op.LuufileRestore;
            dateNgayCap.EditValue = op.NgayCap;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void GetValue()
        {
            op.HoTenChuTro = txtHoTenChuTro.Text == null ? "" : txtHoTenChuTro.Text;
            op.NgaySinh = DateTime.Parse(dateNgaySinh.EditValue.ToString());
            op.CMND = txtCMND.Text;
            op.NoiCap = txtNoiCap.Text;
            op.NgayCap = DateTime.Parse(dateNgayCap.EditValue.ToString());
            op.ThuongTru = txtDiaChiThuongTru.Text;
            op.GiaTienPhong = calTienPhong.EditValue == null ? 0 : double.Parse(calTienPhong.EditValue.ToString());
            op.GiaTienDien = calGiaTienDien.Text == null ? 0 : double.Parse(calGiaTienDien.Text);
            op.GiaTienNuoc = calGiaTienNuoc.EditValue.ToString() == null ? 0 : double.Parse(calGiaTienNuoc.EditValue.ToString());
            op.TenFileBackup = txtNameBackup.Text == null ? "QLNT.bak" : txtNameBackup.Text;
            op.LuufileBackup = cboDuongDanBackup.Text == null ? "D:" : cboDuongDanBackup.Text;
            op.LuufileRestore = cboDuongDanRestore.Text == null ? "D:" : cboDuongDanRestore.Text;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thiết lập giá trị này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                GetValue();
                if (opb.UpdateOption(op))
                {
                    XtraMessageBox.Show("Thiết lập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close();
                }
                else XtraMessageBox.Show("Thiết lập không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}