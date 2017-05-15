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
    public partial class frmDienNuoc : DevExpress.XtraEditors.XtraForm
    {
        bool err = false;
        public frmDienNuoc()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Length == 0 && err == false)
            {
                errorProviderMa.SetIconAlignment(txtMaPhong, ErrorIconAlignment.MiddleLeft);
                errorProviderMa.SetError(txtMaPhong, "Nhập mã phòng");
            }
            else
            {
                errorProviderMa.SetError(txtMaPhong, "");
            }
        }
    }
}