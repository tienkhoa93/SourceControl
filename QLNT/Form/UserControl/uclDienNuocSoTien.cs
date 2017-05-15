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
using DevExpress.XtraGrid.Columns;
using Common;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;
namespace QLNT.Form.UserControl
{
    public partial class uclDienNuocSoTien : DevExpress.XtraEditors.XtraUserControl
    {
        Business.DienNuoc_Bus dnb = new Business.DienNuoc_Bus();
        Business.Phong_Bus pb = new Business.Phong_Bus();
        List<int> rs = new List<int>();
        OpenFileDialog fileChooser = new OpenFileDialog();
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        int dem = 0;
        public uclDienNuocSoTien()
        {
            InitializeComponent();
            dem = gvDienNuoc.DataRowCount - 1;
            grcDienNuoc.DataSource = List_to_Table.ToDataTable(dnb.ListDienNuocSoTien());

            gridPhong.DisplayMember = "TenPhong";
            gridPhong.ValueMember = "MaPhong";
            GridColumn col1 = new GridColumn();
            col1.Caption = "Mã Phòng";
            col1.FieldName = "MaPhong";
            col1.VisibleIndex = 0;
            GridColumn col2 = new GridColumn();
            col2.Caption = "Tên Phòng";
            col2.FieldName = "TenPhong";
            col2.VisibleIndex = 1;
            gridPhong.View.Columns.Add(col1);
            gridPhong.View.Columns.Add(col2);
           
            dem = gvDienNuoc.DataRowCount - 1;

        }
        /// <summary>
        /// Giá trị thay đổi thì kiểm tra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvDienNuoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colTienDien")
            {
                if (float.Parse(gvDienNuoc.GetRowCellValue(e.RowHandle, "TienDien").ToString()) < 0)
                {
                    XtraMessageBox.Show("Không được nhập số âm.");
                    gvDienNuoc.SetRowCellValue(e.RowHandle, gvDienNuoc.Columns["TienDien"], 0);
                }
                float tem = 0;
                try
                {
                    tem = float.Parse(gvDienNuoc.GetRowCellValue(e.RowHandle, "TienDien").ToString()) + float.Parse(gvDienNuoc.GetRowCellValue(e.RowHandle, "TienNuoc").ToString());
                }
                catch { }
                gvDienNuoc.SetRowCellValue(e.RowHandle, gvDienNuoc.Columns["TongTien"], tem);
            }

            if (e.Column.Name == "colTienNuoc")
            {
                if (float.Parse(gvDienNuoc.GetRowCellValue(e.RowHandle, "TienNuoc").ToString()) < 0)
                {
                    XtraMessageBox.Show("Không được nhập số âm.");
                    gvDienNuoc.SetRowCellValue(e.RowHandle, gvDienNuoc.Columns["TienNuoc"], 0);
                }
                float tem = 0;
                try
                {
                    tem = float.Parse(gvDienNuoc.GetRowCellValue(e.RowHandle, "TienDien").ToString()) + float.Parse(gvDienNuoc.GetRowCellValue(e.RowHandle, "TienNuoc").ToString());
                }
                catch { }
                gvDienNuoc.SetRowCellValue(e.RowHandle, gvDienNuoc.Columns["TongTien"], tem);
            }

        }
       
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {        
            bool er =false;
            int c = rs.FindIndex(r => r == -2147483647);

            if (c != null) rs.Add(gvDienNuoc.DataRowCount - 1);

            List<int> row = rs.Distinct().ToList();
            row.RemoveAll(s => s == -2147483647);
            if (row.Count > 0)
            {
                try
                {
                    DataTable dt = (DataTable)grcDienNuoc.DataSource;
                    foreach (int i in row)
                    {
                        int thang=0, nam=0;
                        float tiendien=0, tiennuoc=0;
                        String map = string.Empty;

                        int.TryParse(dt.Rows[i]["Thang"].ToString(), out thang);
                        int.TryParse(dt.Rows[i]["Nam"].ToString(), out nam);

                        if (!float.TryParse(dt.Rows[i]["TienDien"].ToString(), out tiendien))
                            dt.Rows[i]["TienDien"] = 0;

                        if (!float.TryParse(dt.Rows[i]["TienNuoc"].ToString(), out tiennuoc))
                            dt.Rows[i]["TienNuoc"] = 0;

                        map = dt.Rows[i]["MaPhong"].ToString();

                        if(thang==0||nam==0||tiennuoc<0||tiendien<0||map=="")
                        {
                            gvDienNuoc.SelectRow(i);
                            gvDienNuoc.Appearance.SelectedRow.BackColor = Color.Red;
                            er = true;
                        }    

                    }
                    if(er==false)
                    {
                        dnb.InsertDatatable(row, dt);
                        grcDienNuoc.DataSource = List_to_Table.ToDataTable(dnb.ListDienNuocSoTien());
                        gvDienNuoc.SelectRow(row[0]);
                    }
                    else XtraMessageBox.Show("Tìm thấy lỗi trong quá trình tính toán.\nVui lòng kiểm tra lại các dòng được đánh dấu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                    
                }
                catch { }
                er = false;
            }
            rs.Clear();
            gvDienNuoc.RefreshData();
            dem = gvDienNuoc.DataRowCount - 1;
        }

        private void gvDienNuoc_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle == -2147483647)
            {
                Auto_addnewRow();
                rs.Add(gvDienNuoc.DataRowCount-1);
            }
            else
            rs.Add(e.RowHandle);
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int k = 0;
            if (XtraMessageBox.Show("Thực hiện thao tác?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<int> str = new List<int>();
                for (int i = 0; i < gvDienNuoc.RowCount; i++)
                {
                    if (gvDienNuoc.IsRowSelected(i) == true)
                        str.Add(int.Parse(gvDienNuoc.GetRowCellValue(i, "id").ToString()));
                }
                k = str[0];
                str.RemoveAll(s => s == null);
                if (str.Count > 0)
                {
                    dnb.DeleteDienNuocSoTien(str);
                    for (int i = 0; i < gvDienNuoc.RowCount; i++)
                        if (gvDienNuoc.IsRowSelected(i) == true)
                            gvDienNuoc.DeleteSelectedRows();
                }
            }
            gvDienNuoc.SelectRow(k);
        }
        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grcDienNuoc.DataSource = List_to_Table.ToDataTable(dnb.ListDienNuocSoTien());
           
            dem = gvDienNuoc.DataRowCount - 1;
        }
        #region lấy giữ liệu từ file excel
        private void btnNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fileChooser.Filter = "Excel file|*.xlsx||*.xls";
            fileChooser.InitialDirectory = "C:\\";
            fileChooser.Title = "Chọn file |*.xlsx||*.xls để import giữ liệu";
            fileChooser.ShowDialog();

            if (fileChooser.FileName.Equals(null))
                return;

            string filePath = fileChooser.FileName;
            string extension = Path.GetExtension(filePath);
            string header = "Yes";//rbHeaderYes.Checked ? "YES" : "NO";
            string conStr = string.Empty, sheetName = string.Empty;


            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    try
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Không thể thực hiện thao tác. file đang mở.");
                    }

                }
            }
            DataTable dt = new DataTable();
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {

                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        try { con.Open(); }
                        catch
                        {
                            XtraMessageBox.Show("Đóng file giữ liệu để thực hiện import dữ liệu!");
                            return;
                        }

                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["MaPhong"].ToString() == null || dt.Rows[i]["MaPhong"].ToString() == "")
                                dt.Rows.RemoveAt(i);

                            dt.Rows[i]["TongTien"] = float.Parse(dt.Rows[i]["TienDien"].ToString()) + float.Parse(dt.Rows[i]["TienNuoc"].ToString());
                        }
                        //Populate DataGridView.
                        // gridDienNuoc.DataSource = dt;
                        //Form.DienNuoc.frmDienNuocUcl dnucl = new DienNuoc.frmDienNuocUcl(dt);
                        //.dnucl.ShowDialog();
                     
                        Form.DienNuoc.frmDienNuocSoTien dnt = new DienNuoc.frmDienNuocSoTien(dt);
                        dnt.ShowDialog();
                        grcDienNuoc.DataSource = List_to_Table.ToDataTable(dnb.ListDienNuocSoTien());
                    }
                }
            }

        }
        #endregion

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView grid = grcDienNuoc.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (grid != null)
            {
                SaveFileDialog saveExcel = new SaveFileDialog();
                saveExcel.Filter = "Excel Workbook|*.xlsx|Excel Macro-Enabled Workbook|*.xlsm|Excel 97-2003 Workbook|*.xls";// định giạng file lưu
                saveExcel.Title = "Save an Excel File";
                saveExcel.InitialDirectory = @"C:\";
                if (saveExcel.ShowDialog() == DialogResult.OK)
                {

                    grid.ExportToXlsx(saveExcel.FileName);
                    MessageBox.Show("Export File thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Bạn có muốn xem file ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Process exportXlsx = new Process();
                        exportXlsx.StartInfo.FileName = "EXCEL.exe";
                        exportXlsx.StartInfo.Arguments = saveExcel.FileName; ;
                        exportXlsx.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không có", "Thông báo");
            }
        }

        void Auto_addnewRow()
        {
            int rowHandle = gvDienNuoc.GetDataRowHandleByGroupRowHandle(gvDienNuoc.FocusedRowHandle);
            //Store group column values 
            object[] groupValues = null;
            int groupColumnCount = gvDienNuoc.GroupedColumns.Count;
            if (groupColumnCount > 0)
            {
                groupValues = new object[groupColumnCount];
                for (int i = 0; i < groupColumnCount; i++)
                {
                    groupValues[i] = gvDienNuoc.GetRowCellValue(rowHandle, gvDienNuoc.GroupedColumns[i]);
                }
            }
            //Add a new row 
            gvDienNuoc.AddNewRow();
            //Get the handle of the new row 
            int newRowHandle = gvDienNuoc.FocusedRowHandle;
            object newRow = gvDienNuoc.GetRow(newRowHandle);
            //Set cell values corresponding to group columns 
            if (groupColumnCount > 0)
            {
                for (int i = 0; i < groupColumnCount; i++)
                {
                    gvDienNuoc.SetRowCellValue(newRowHandle, gvDienNuoc.GroupedColumns[i], groupValues[i]);
                }
            }
            //Accept the new row 
            //The row moves to a new position according to the current group settings 
            gvDienNuoc.UpdateCurrentRow();
        }

    }
}

