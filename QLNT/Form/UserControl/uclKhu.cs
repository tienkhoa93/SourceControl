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
using Common;
using QLNT.Business;
using QLNT.LinQToSQL;

namespace QLNT.Form.UserControl
{
    public partial class uclKhu : DevExpress.XtraEditors.XtraUserControl
    {
        Business.Khu_Bus khub = new Business.Khu_Bus();
        int curr;

        public uclKhu()
        {
            InitializeComponent();
            PhanQuyen();
        }
        private void PhanQuyen()
        {


        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Form.Khu.frmKhu frm = new Khu.frmKhu();
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            frm.Show();
            this.Cursor = Cursors.Default;
        }


        private void gridViewKhu_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
