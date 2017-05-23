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

namespace QLNT.Form.DanhMuc.VatTu
{
    public partial class frmQuanLyVatTu : DevExpress.XtraEditors.XtraForm
    {
        QLNTDataContext db = new QLNTDataContext();
        QuanLiVatTu_B quanlyvattu = new QuanLiVatTu_B();
        QuanLyVatTuBus qlvtb = new QuanLyVatTuBus();
        Common.ChucNang cn;
        public frmQuanLyVatTu()
        {
            InitializeComponent();
        }

        public frmQuanLyVatTu(Common.ChucNang cn, QuanLiVatTu_B quanlyvattu)
        {
            InitializeComponent();
            this.cn = cn;
            dateNgaySuaChua.EditValue = DateTime.Today;
            if (cn == Common.ChucNang.Them)
            {
                this.Text = "Thêm Quản lý";
                glkPhong.Properties.ReadOnly = false;

            }
            else
            {
                this.Text = "Sửa Quản lý";
                glkPhong.Properties.ReadOnly = true;
                GVupForm(quanlyvattu);
            }
        }
        public void GVupForm(QuanLiVatTu_B quanlyvattu)
        {
           //quanlyvattu = _quanlyvattu;
            glkPhong.EditValue = quanlyvattu.MaPhong;
            glkVatTu.EditValue = quanlyvattu.TenVatTu;
            calcSoLuong.Text =  Convert.ToString(quanlyvattu.SoLuong);
            dateNgaySuaChua.EditValue = Convert.ToDateTime( quanlyvattu.NgaySuaChua);
            if (checkSuaChua.Checked == true )
                quanlyvattu.SuaChua=true;
            else checkSuaChua.Checked = false;
            if (checkThayThe.Checked == true)
                quanlyvattu.ThayThe = true;
            else checkThayThe.Checked = false;
            memoEdit1.Text = quanlyvattu.GhiChu;
        }

        private void frmQuanLyVatTu_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
        private void LoadDataToGrid()
        {
            Table<Phong> phong = db.GetTable<Phong>();
            glkPhong.Properties.DisplayMember = "TenPhong";//.text
            glkPhong.Properties.ValueMember = "MaPhong";//value
            glkPhong.Properties.DataSource = phong;

            Table<LinQToSQL.VatTu> vattu = db.GetTable<LinQToSQL.VatTu>();
            glkVatTu.Properties.ValueMember = "TenVatTu";
            glkVatTu.Properties.DisplayMember = "TenVatTu";           
            glkVatTu.Properties.DataSource = vattu;
        }
        public void GetValueItems()
        {
            quanlyvattu.MaPhong = glkPhong.EditValue.ToString();
            quanlyvattu.TenVatTu = glkVatTu.EditValue.ToString();
            try
            {
                quanlyvattu.SoLuong = Convert.ToInt16(calcSoLuong.Text);
               
            }
            catch
            {
                quanlyvattu.NgaySuaChua = Convert.ToDateTime(dateNgaySuaChua.Text);
            }
            try { }
            catch
            {

            }
        
            if (checkThayThe.Checked)
            {
                quanlyvattu.ThayThe = true;
            }
            else
            {
                quanlyvattu.ThayThe = false;
            }

            if (checkSuaChua.Checked)
            {
                quanlyvattu.SuaChua = true;
            }
            else
            {
                quanlyvattu.SuaChua = false;
            }

            quanlyvattu.GhiChu = memoEdit1.Text;
        }
        public void ResetItems()
        {
            glkPhong.Text = string.Empty;
            glkPhong.Focus();
            glkVatTu.Text = string.Empty;
            calcSoLuong.EditValue = 0;
            dateNgaySuaChua.EditValue = DateTime.Today;
            checkThayThe.Checked = false;
            checkSuaChua.Checked = false;
        }
        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            GetValueItems();
            GVupForm(quanlyvattu);
            if (cn == Common.ChucNang.Them)
            {
                qlvtb.InsertQuanLyVatTu(quanlyvattu);
                Common.Delegates.GetList(qlvtb.ListQuanLyVatTu());
                this.Close();
            }
            else
            {                
                qlvtb.UpdateQuanLyVatTu(quanlyvattu);
                Common.Delegates.GetList(qlvtb.ListQuanLyVatTu());
                this.Close();              
            }                      
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            GetValueItems();
            GVupForm(quanlyvattu);
            if (cn == Common.ChucNang.Them)
            {
                qlvtb.InsertQuanLyVatTu(quanlyvattu);
                Common.Delegates.GetList(qlvtb.ListQuanLyVatTu());
                ResetItems();
            }
            else
            {
                qlvtb.UpdateQuanLyVatTu(quanlyvattu);
                glkPhong.Properties.ReadOnly = false; 
                Common.Delegates.GetList(qlvtb.ListQuanLyVatTu());
                ResetItems();
            }        
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}