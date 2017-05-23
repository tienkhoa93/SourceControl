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
            InitializeComponent();

            rpPhong.DataSource = pb.ListPhong();

            gcHoaDon.DataSource = Common.List_to_Table.ToDataTable(hdb.ListHoaDon());
            rpcboTienDong.DataSource = tb.ListThongTinTien();

            rpTienPhong.DataSource = tb.ListTien();
        //    rpvDienNuoc.FixedLineWidth = 900;
            rpDienNuoc.DataSource = dnb.ListDienNuoc();

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
            if (e.Column.Name == "colDienNuoc")
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

            List<int> row = list.Distinct().ToList();
            row.RemoveAll(s => s == -2147483647);
            row.RemoveAll(s => s == -999997);

            if (row.Count > 0)
            {
                DataView view = (DataView)gvHoaDon.DataSource;
                DataTable dt = view.ToTable();
                int c = dt.Rows.Count;
                hdb.InsertHoaDon(row, dt);
                gcHoaDon.DataSource = Common.List_to_Table.ToDataTable(hdb.ListHoaDon());
                XtraMessageBox.Show("Thay đổi thành công thành công.");
                list.Clear();
            }
        }

        private void gvHoaDon_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle == -2147483647)
            {
                list.Add(gvHoaDon.DataRowCount);
            }
            else
            {
                list.Add(e.RowHandle);
                gvHoaDon.OptionsView.ShowGroupedColumns = false;
            }
        }

        private void btnXoaHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn chắc chắn muốn thực hiện thao tác.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<int> Xoa = new List<int>();
                for (int i = 0; i < gvHoaDon.DataRowCount; i++)
                    if (gvHoaDon.IsRowSelected(i) == true)//kiem tra xem dòng i này có select hay k, neu có sẽ get madot
                    {
                        list.Add(int.Parse(gvHoaDon.GetRowCellValue(i, "Id").ToString()));
                    }

                list.RemoveAll(s => s == -2147483647);
                list.RemoveAll(s => s == -999997);
                hdb.XoaHoaDon(list);
                gvHoaDon.DeleteSelectedRows();
                XtraMessageBox.Show("Xoá thành công.");
            }

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
                if (saveExcel.ShowDialog() == DialogResult.OK)
                {
                    grid.ExportToXlsx(saveExcel.FileName);
                    XtraMessageBox.Show("Export File thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (XtraMessageBox.Show("Bạn có muốn xem file ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Process exportXlsx = new Process();
                        exportXlsx.StartInfo.FileName = "EXCEL.exe";
                        exportXlsx.StartInfo.Arguments = saveExcel.FileName;
                        exportXlsx.Start();
                    }
                }
            }
        }
     void   RefeshG (object b)
        {
            gcHoaDon.DataSource = b;
            }
        private void btnTaoHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DienNuoc.frmTaoHoaDon thd = new DienNuoc.frmTaoHoaDon(true);
            Common.Delegates.Regrib = new Common.Delegates.RefeshGrid(RefeshG);
            thd.ShowDialog();
        }

       
        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpPhong.DataSource = pb.ListPhong();

            gcHoaDon.DataSource = Common.List_to_Table.ToDataTable(hdb.ListHoaDon());
            rpcboTienDong.DataSource = tb.ListThongTinTien();

            rpTienPhong.DataSource = tb.ListTien();
         
            rpDienNuoc.DataSource = dnb.ListDienNuoc();
        }

        private void btnIn_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<HoaDon> list = new List<HoaDon>();
            try
            {
                for (int i = 0; i < gvHoaDon.RowCount; i++)
                {
                    if (gvHoaDon.IsRowSelected(i) == true)
                    {
                        _HoaDon sv = (_HoaDon)hdb.GetHoaDonTheoPhong(long.Parse(gvHoaDon.GetRowCellValue(i, "Id").ToString()));
                        list.Add(sv);
                    }
                }
            }
            catch { }

            HoaDonTienPhong rp = new Report.HoaDonTienPhong(list);
            rp.DataSource = list;
            rp.ShowPreview();
        }
    }
}
