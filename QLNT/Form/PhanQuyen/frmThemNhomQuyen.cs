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
using QLNT.Business;
using QLNT.LinQToSQL;

namespace QLNT.Form.PhanQuyen
{
    public partial class frmThemNhomQuyen : DevExpress.XtraEditors.XtraForm
    {
        SySNhomQuyen_Bus nqb = new SySNhomQuyen_Bus();
        SysNhomQuyen nq = new SysNhomQuyen();
        SysQuyenSuDung_Bus qsdb = new SysQuyenSuDung_Bus();
        Common.ChucNang cn =new  Common.ChucNang();
        public frmThemNhomQuyen()
        {
            InitializeComponent();
        }
        public frmThemNhomQuyen(Common.ChucNang cn,SysNhomQuyen nq)
        {
            InitializeComponent();
            this.cn = cn;
            if (cn == Common.ChucNang.Them)
            {
                this.Text = "Thêm nhóm quyền";
            }
            else
            {
                this.Text = "Sửa nhóm quyền";
                GVupForm(nq);
                txtMaNhomQuyen.Properties.ReadOnly = true;
            }

        }

        private void GVupForm(SysNhomQuyen nq)
        {
            txtMaNhomQuyen.Text = nq.MaNhom;
            txtTenNhomQuyen.Text = nq.TenNhom;
            txtDienGia.Text = nq.DienGiai;
            chkHoatDong.Checked = (bool)nq.HoatDong;
        }
        private void GetValues(){
            nq.MaNhom = txtMaNhomQuyen.Text;
            nq.TenNhom = txtTenNhomQuyen.Text;
            nq.DienGiai = txtDienGia.Text;
            nq.HoatDong = (bool)chkHoatDong.Checked;
        }
        private void ResetTexts()
        {
            txtMaNhomQuyen.Text = "";
            txtTenNhomQuyen.Text = "";
            txtDienGia.Text = "";
            chkHoatDong.Checked = true;
        }

        private void KiemTraThongTin()
        {
            string s="";
            if (txtMaNhomQuyen.Text == string.Empty)
                s += "Nhập vào mã nhóm quyền\n";
            if (txtTenNhomQuyen.Text == string.Empty)
                s += "Nhập vào tên nhóm quyền";
            if (s != string.Empty)
            {
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnLuuVaThem_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            GetValues();
            if (this.cn == Common.ChucNang.Them)
            {
                if (nqb.SelectNhomQuyen(nq.MaNhom).Count > 0)
                {
                    MessageBox.Show("Mã nhóm quyền đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (nqb.InsertNhomQuyen(nq))
                {

                    ResetTexts();
                    qsdb.insertQuyenSuDung(nq.MaNhom);
                    txtMaNhomQuyen.Properties.ReadOnly = false;
                    Common.Delegates.GetList(nqb.ListNhomQuyen());
                    
                }
            }
            else
            {
                if (nqb.UpdateNhomQuyen(nq))
                {
                    Common.Delegates.GetList(nqb.ListNhomQuyen());
                    this.cn = Common.ChucNang.Them;
                    txtMaNhomQuyen.Properties.ReadOnly = false;
                    ResetTexts();
                    this.Text = "Thêm nhóm quyền";

                }
            }
        }

        private void btnLuuVaDong_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            GetValues();
            if (this.cn == Common.ChucNang.Them)
            {
                if (nqb.SelectNhomQuyen(nq.MaNhom).Count > 0)
                {
                    MessageBox.Show("Mã nhóm quyền đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (nqb.InsertNhomQuyen(nq))
                {
                    qsdb.insertQuyenSuDung(nq.MaNhom);
                    Common.Delegates.GetList(nqb.ListNhomQuyen());
                    this.Close();

                }
            }
            else
            {
                if (nqb.UpdateNhomQuyen(nq))
                {
                    Common.Delegates.GetList(nqb.ListNhomQuyen());
                    this.Close();

                }
            }
        }
    }
}