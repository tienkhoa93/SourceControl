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

namespace QLNT.Form.DienNuoc
{
    public partial class frmTaoHoaDon : DevExpress.XtraEditors.XtraForm
    {
        QLNT.Business.Khu_Bus kb = new Business.Khu_Bus();
        QLNT.Business.Phong_Bus pb = new Business.Phong_Bus();
        Business.Options_Bus opb = new Business.Options_Bus();
        bool b = false;
        public frmTaoHoaDon()
        {
            InitializeComponent();
            gldKhu.Properties.DataSource = kb.GetAllKhu();
            for(int i=1;i<=DateTime.Today.Month;i++)
            {
                cboThang.Properties.Items.Add(i);
                cboThang.SelectedIndex = i-1;
            }
            cboNam.Properties.Items.Add(DateTime.Today.Year);
            cboNam.SelectedIndex = 0;
            
        }
        public frmTaoHoaDon(bool b)
        {
            InitializeComponent();
            for (int i = 1; i <= DateTime.Today.Month; i++)
            {
                cboThang.Properties.Items.Add(i);
                cboThang.SelectedIndex = i - 1;
            }
            cboNam.Properties.Items.Add(DateTime.Today.Year);
            cboNam.SelectedIndex = 0;
            gldKhu.Properties.DataSource = kb.GetAllKhu();
            this.b = b;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string a = string.Empty;
            LinQToSQL.Option op = opb.GetOp();
            if (cboThang.Text.Equals(""))
            {
                a += "Nhập tháng.\n";

            }
            if (cboNam.Text.Equals(""))
            {
                a += "Nhập năm.\n";

            }
            if (gldKhu.EditValue == null)
            {
                a += "Chọn khu để tạo hóa đơn";
            }
            if (a != string.Empty)
            {
                XtraMessageBox.Show(a + "");
                return;
            }


            if(b==true)// su dung cho form HoaDon
            {
               if( XtraMessageBox.Show("Tạo hóa đơn cho khu " + gldKhu.EditValue.ToString() +" vào tháng "+ cboThang.Text + "/" + cboNam.Text,"Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
               {

                   Business.HoaDon_Buss hdb = new Business.HoaDon_Buss();
                   hdb.TaoHoaDon(int.Parse(cboThang.Text), int.Parse(cboNam.Text), gldKhu.EditValue.ToString());
                   Common.Delegates.GetList(Common.List_to_Table.ToDataTable( hdb.ListHoaDon()));
                   this.Close();
               }
            }
            else// SU DUng Cho dien nuoc
            {

                int thang = int.Parse(cboThang.Text), nam = int.Parse(cboNam.Text);
                List<LinQToSQL.Phong> phong = pb.ListPhong_TheoMaKhu(gldKhu.EditValue.ToString());
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(long));
                dt.Columns.Add("MaKhu", typeof(string));
                dt.Columns.Add("TenPhong", typeof(string));
                dt.Columns.Add("MaPhong", typeof(string));
                dt.Columns.Add("SoTienDien", typeof(float));
                dt.Columns.Add("SoTienNuoc", typeof(float));
                dt.Columns.Add("SoDienCu", typeof(int));
                dt.Columns.Add("SoDienMoi", typeof(int));
                dt.Columns.Add("SoNuocCu", typeof(int));
                dt.Columns.Add("SoNuocMoi", typeof(int));
                dt.Columns.Add("GiaTienDien", typeof(float));
                dt.Columns.Add("GiaTienNuoc", typeof(float));
                dt.Columns.Add("TongTien", typeof(float));
                dt.Columns.Add("TrangThai", typeof(bool));
                dt.Columns.Add("SoDienTieuThu", typeof(int));
                dt.Columns.Add("SoNuocTieuThu", typeof(int));
                dt.Columns.Add("NgayDongTien", typeof(DateTime));
                dt.Columns.Add("Thang", typeof(int));
                dt.Columns.Add("Nam", typeof(int));
                dt.Columns.Add("GhiChu", typeof(string));
                DataRow row;
                Business.DienNuoc_Bus dn = new Business.DienNuoc_Bus();
                List<Business.DienNuocCu> dnc = dn.DienNuocCu(thang, nam, gldKhu.EditValue.ToString());
           
                for (int i = 0; i < phong.Count; i++)
                {
                    row = dt.NewRow();
                    row["MaPhong"] = phong[i].MaPhong;
                    row["MaKhu"] = phong[i].MaKhu;
                    row["Thang"] = thang;
                    row["Nam"] = nam;
                    row["SoDienMoi"] = 0;
                    row["SoNuocMoi"] = 0;
                    try { row["SoNuocCu"] = dnc.Find(item => item.MaPhong == phong[i].MaPhong).SoNuocMoi; }
                    catch { row["SoNuocCu"] = 0; }

                    try { row["SoDienCu"] = dnc.Find(item => item.MaPhong == phong[i].MaPhong).SoDienMoi; }
                    catch { row["SoDienCu"] = 0; }
               
                    row["GiaTienDien"] = op.GiaTienDien;
                    row["GiaTienNuoc"] = op.GiaTienNuoc;
                    dt.Rows.Add(row);
                }
            
                this.Hide();
                Form.DienNuoc.frmDienNuocUcl dnb = new frmDienNuocUcl(dt);
                dnb.ShowDialog();
                this.Close();

            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}