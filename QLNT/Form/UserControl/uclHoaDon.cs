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
using System.Diagnostics;
using QLNT.Report;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
using QLNT.LinQToSQL;
using QLNT.Business;

namespace QLNT.Form.UserControl
{
    public partial class uclHoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        Business.HoaDon_Buss hdb = new Business.HoaDon_Buss();
        Business.DienNuoc_Bus dnb = new Business.DienNuoc_Bus();
        Business.Phong_Bus pb = new Business.Phong_Bus();
        Business.Tien_Buss tb = new Business.Tien_Buss();
        List<int> list = new List<int>();

        public uclHoaDon()
        {



        }

        private void gvHoaDon_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gvHoaDon_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            float c = 0, d = 0;
            if (e.Column.Name == "colTienPhong")
            {
                try { c = float.Parse(gvHoaDon.GetFocusedRowCellDisplayText(gvHoaDon.Columns["DienNuocId"]).ToString()); ; }
                catch { }

                try { d = float.Parse(gvHoaDon.GetFocusedRowCellDisplayText(gvHoaDon.Columns["TienID"]).ToString()); ; }
                catch { }
                gvHoaDon.SetFocusedRowCellValue(gvHoaDon.Columns["TongTien"], d + c);
                return;
            }

        }

        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int fc = gvHoaDon.FocusedRowHandle;


        }

        private void gvHoaDon_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle == -2147483647)
            {
                list.Add(gvHoaDon.DataRowCount);
            }

        }

        private void btnXoaHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

      

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvHoaDon.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để xuất file !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DevExpress.XtraGrid.Views.Grid.GridView grid = gcHoaDon.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (grid != null)
            {
                SaveFileDialog saveExcel = new SaveFileDialog();
                saveExcel.Filter = "Excel Workbook|*.xlsx|Excel Macro-Enabled Workbook|*.xlsm|Excel 97-2003 Workbook|*.xls";
                saveExcel.Title = "Save an Excel File";
                saveExcel.InitialDirectory = @"C:\";

            }
        }


       
        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpPhong.DataSource = pb.ListPhong();

            gcHoaDon.DataSource = Common.List_to_Table.ToDataTable(hdb.ListHoaDon());
            rpcboTienDong.DataSource = tb.ListThongTinTien();

            rpTienPhong.DataSource = tb.ListTien();
         
            rpDienNuoc.DataSource = dnb.ListDienNuoc();
        }

    }
}
