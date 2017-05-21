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

namespace QLNT.Form.UserControl
{
    public partial class uclLichSuTruyCap : DevExpress.XtraEditors.XtraUserControl
    {
        Business.Log_Bus lb = new Business.Log_Bus();
        public uclLichSuTruyCap()
        {
            InitializeComponent();
            gridNhatKy.DataSource = lb.ListNhatKy();
        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridNhatKy.DataSource = lb.ListNhatKy();
        }
        /// <summary>
        /// Xoa tat ca.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if( XtraMessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                lb.DeleteAll();
                gridNhatKy.DataSource = lb.ListNhatKy();
            }
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < gridViewLS.RowCount; i++)
            {
                if (gridViewLS.IsRowSelected(i) == true)
                    list.Add(int.Parse(gridViewLS.GetRowCellValue(i, "STT").ToString()));
            }
            if (list.Count > 0)
                lb.DeleteList(list);
            gridViewLS.DeleteSelectedRows();
        }
    }
}
