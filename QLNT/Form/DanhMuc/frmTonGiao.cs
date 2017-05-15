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

namespace QLNT.Form.DanhMuc
{
    public partial class frmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public frmTonGiao()
        {
            InitializeComponent();
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLuuThem_Click(object sender, EventArgs e)
        {
        }
        private void btnLuuDong_Click(object sender, EventArgs e)
        {
        }
        private void txtTenTonGiao_TextChanged(object sender, EventArgs e)
        {
        }
    }
}