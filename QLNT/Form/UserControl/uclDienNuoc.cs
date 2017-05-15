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
using System.IO;
using System.Data.OleDb;
using DevExpress.XtraGrid.Columns;
using System.Diagnostics;
using QLNT.Business;
using QLNT.LinQToSQL;
using Common;
using DevExpress.XtraReports.UI;

namespace QLNT.Form.UserControl
{
    public partial class uclDienNuoc : DevExpress.XtraEditors.XtraUserControl
    {
        int rcount = 0;
        Business.DienNuoc_Bus dnb = new Business.DienNuoc_Bus();
        Business.Phong_Bus pbb = new Business.Phong_Bus();
        Business.Khu_Bus kb = new Business.Khu_Bus();
        Business.Options_Bus opb = new Business.Options_Bus();
        OpenFileDialog fileChooser = new OpenFileDialog();
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        List<int> list = new List<int>();
        List<Business.Phong_B> temp = new List<Business.Phong_B>();
        public uclDienNuoc()
        {
            InitializeComponent();
            for (int i = 1; i <= DateTime.Today.Month;i++ )
            {
                cboThang.Items.Add(i);
            }
            cboNam.Items.Add(DateTime.Today.Year);
                colThang.Fixed = FixedStyle.Left;
            colNam.Fixed = FixedStyle.Left;
            colKhu.Fixed = FixedStyle.Left;
            Refetch();
            LoadGiuLieutoGrid();
            CheckForIllegalCrossThreadCalls = false;
            cboThang.NullText = DateTime.Today.Month.ToString();
            cboNam.NullText = DateTime.Today.Year.ToString();
         
            rcount = gridViewDienNuoc.DataRowCount-1;
            cboNam.EditValueChanged += cboNam_EditValueChanged;
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            SysNguoiDung_Bus ndb = new SysNguoiDung_Bus();
            SysQuyenSuDung_Bus qsdb = new SysQuyenSuDung_Bus();
            List<SysUser> listuser = ndb.SelectNguoiDung(UserInfo.Account);
            string manhom = "";
            foreach (var a in listuser)
            {
                manhom = a.MaNhom;
            }
            List<SysQuyenSuDung> listquyen = qsdb.SelectQuyenSuDung(manhom, "20");
            foreach (var b in listquyen)
            {
                if (b.Xoa == false)
                    btnXoa.Enabled = false;
                if (b.XuatDuLieu == false)
                    btnXuat.Enabled = false;
                if (b.NhapDuLieu == false)
                    btnNhap.Enabled = false;
                if (b.InAn == false)
                    btnIn.Enabled = false;
                if (b.Them == false)
                    btnTaoHoaDon.Enabled = false;
            }

        }

        void cboNam_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        #region load giữ liệu lên grid
        void Refetch()
        {
            DataTable dts = Common.List_to_Table.ToDataTable(dnb.ListDienNuoc());
            dts.Columns["SoTienDien"].DefaultValue = 0;
            dts.Columns["SoTienNuoc"].DefaultValue = 0;
            dts.Columns["SoDienCu"].DefaultValue = 0;
            dts.Columns["SoNuocCu"].DefaultValue = 0;
            dts.Columns["SoDienMoi"].DefaultValue = 0;
            dts.Columns["SoNuocMoi"].DefaultValue = 0;
            dts.Columns["GiaTienDien"].DefaultValue = opb.GetOp().GiaTienDien;
            dts.Columns["GiaTienNuoc"].DefaultValue = opb.GetOp().GiaTienNuoc;           
            dts.Columns["SoDienTieuThu"].DefaultValue = 0;
            dts.Columns["SoNuocTieuThu"].DefaultValue = 0;
            dts.Columns["NgayDongTien"].DefaultValue = null;
            dts.Columns["Thang"].DefaultValue = DateTime.Today.Month;
            dts.Columns["Nam"].DefaultValue = DateTime.Today.Year;
            dts.Columns["TongTien"].DefaultValue = 0;
            dts.Columns["TrangThai"].DefaultValue = false;
            gridDienNuoc.DataSource = dts;
            int c = dts.Rows.Count;
        }
       
        void LoadGiuLieutoGrid()
        {
           
            LinQToSQL.Option op = opb.GetOp();
            CalGiaDien.NullText = op.GiaTienDien.ToString();
            CalGiaNuoc.NullText = op.GiaTienNuoc.ToString();
  
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
            gridPhong.DataSource = pbb.ListPhong();

            gridKhu.DataSource = kb.GetAllKhu();
            GridColumn col3 = new GridColumn();
            col3.Caption = "Mã Khu";
            col3.FieldName = "MaKhu";
            col3.VisibleIndex = 0;
            GridColumn col4 = new GridColumn();
            col4.Caption = "Tên Khu";
            col4.FieldName = "TenKhu";
            col4.VisibleIndex = 1;
            gridKhu.DisplayMember = "TenKhu";
            gridKhu.ValueMember = "MaKhu";
            gridKhu.View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            col3,
            col4
            });
        }
        #endregion
        #region Nhập số tiền điện nước bằng file excel


        /// <summary>
        /// sư kiện nhận giữ liệu từ file excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            string conStr = string.Empty, sheetName= string.Empty;
           

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

                        for (int i = 0; i < dt.Rows.Count;i++ )
                        {
                            if (dt.Rows[i]["MaPhong"].ToString() == null || dt.Rows[i]["MaPhong"].ToString() == "")
                                dt.Rows.RemoveAt(i);
                            else
                            {
                                dt.Rows[i]["GiaTienDien"] = opb.GetOp().GiaTienDien;
                                dt.Rows[i]["GiaTienNuoc"] = opb.GetOp().GiaTienPhong;
                            }
                           
                        }
                            //Populate DataGridView.
                           // gridDienNuoc.DataSource = dt;
                        Form.DienNuoc.frmDienNuocUcl dnucl = new DienNuoc.frmDienNuocUcl(dt);
                        dnucl.ShowDialog();
                        Refresh();
                    }
                }
            }
        }
        #endregion
        #region Xóa tiền điện nước
        
       
        /// <summary>
        /// Xóa tiền điện nước.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int t = 0;
            List<int> list=new List<int>();
             for (int i = 0; i < gridViewDienNuoc.DataRowCount; i++)
                 if (gridViewDienNuoc.IsRowSelected(i) == true)//kiem tra xem dòng i này có select hay k, neu có sẽ get madot
                 {
                     list.Add(int.Parse(gridViewDienNuoc.GetRowCellValue(i, "Id").ToString()));
                        if(!bool.Parse(gridViewDienNuoc.GetRowCellValue(i, "TrangThai").ToString()))
                        {
                            ++t;
                        }
                 }
             if (t > 0)
             {
                 if (XtraMessageBox.Show("Tồn tại " + t + " phòng chưa thu tiền điện nước.\n\tTiếp tục?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                 {
                    gridViewDienNuoc.DeleteSelectedRows();    
                     dnb.Delete_DienNuoc_TheoListMaP(list);
                 }
             }
             else
             { 
                gridViewDienNuoc.DeleteSelectedRows();
                 dnb.Delete_DienNuoc_TheoListMaP(list);
             }
                           
        }
        #endregion
        #region Nạp lại
        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refetch();
        }
        #endregion
        
        #region Lưu lại
            private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            { 
                int fc = gridViewDienNuoc.FocusedRowHandle;
              
                List<int> row = list.Distinct().ToList();
                row.RemoveAll(s => s == -2147483647);
                row.RemoveAll(s => s == -999997); 
                if(row.Count>0)
                { 
                        DataView view =(DataView) gridViewDienNuoc.DataSource ;              
                        DataTable dt = view.ToTable();
                        int c = dt.Rows.Count;
                        bool er = false;               
                        foreach (int i in row)
                        {
                            float dc = 0, dm = 0, nc = 0, nm = 0, td = 0, tn = 0,gd=0,gn=0;
                            int thang=0,nam=0;
                            if(!float.TryParse(dt.Rows[i]["SoDienCu"].ToString(), out dc))
                                dt.Rows[i]["SoDienCu"]= 0;
                            if (!float.TryParse(dt.Rows[i]["SoDienMoi"].ToString(), out dm))
                                dt.Rows[i]["SoDienMoi"] = 0;
                            if(!float.TryParse(dt.Rows[i]["SoNuocCu"].ToString(), out nc))
                                dt.Rows[i]["SoNuocCu"]= 0;
                            if(!float.TryParse(dt.Rows[i]["SoNuocMoi"].ToString(), out nm))
                               dt.Rows[i]["SoNuocMoi"] = 0;
                            if(!float.TryParse(dt.Rows[i]["GiaTienDien"].ToString(), out td))
                               dt.Rows[i]["GiaTienDien"] = 0;
                            if(!float.TryParse(dt.Rows[i]["GiaTienNuoc"].ToString(), out tn))
                                dt.Rows[i]["GiaTienNuoc"] = 0;
                            if (!int.TryParse(dt.Rows[i]["Thang"].ToString(), out thang))
                                dt.Rows[i]["Thang"] = DateTime.Today.Month.ToString();
                            if (!int.TryParse(dt.Rows[i]["Nam"].ToString(), out nam))
                                dt.Rows[i]["Nam"] = DateTime.Today.Year.ToString();
                    
                            if (!float.TryParse(dt.Rows[i]["GiaTienDien"].ToString(),out gd)||gd==0)
                                dt.Rows[i]["GiaTienDien"]=opb.GetOp().GiaTienDien;
                    
                            if (!float.TryParse(dt.Rows[i]["GiaTienNuoc"].ToString(), out gn)||gn==0)
                                dt.Rows[i]["GiaTienNuoc"] = opb.GetOp().GiaTienNuoc;

                            if (dc<0||dm<0||dc>dm||nc<0||nm<0||nc>nm||gd<0||gn<0)
                                {
                                    gridViewDienNuoc.SelectRow(i);
                                    gridViewDienNuoc.Appearance.SelectedRow.BackColor = Color.Red;
                                    er = true;
                                }
                        }
                        if (er)
                            XtraMessageBox.Show("Tìm thấy lỗi trong quá trình tính toán.\nVui lòng kiểm tra lại các dòng được đánh dấu.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        else
                        {
                            dnb.UpdateTableDienNuoc(dt,row);                
                            Refresh();
                            list.Clear();
                            Refetch();
                        }
                        dt.Clear();
                        gridViewDienNuoc.SelectRow(fc);
                }
            }
            
        #endregion
       
        #region Tinh Tien dien
        private void gridViewDienNuoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            
            if (e.Column.Name == "colPhong")
            { 
                foreach (LinQToSQL.Phong row in temp)
                 {
                       if(row.MaPhong.Equals(gridViewDienNuoc.GetFocusedRowCellValue("MaPhong").ToString()))
                       {
                           gridViewDienNuoc.SetRowCellValue(e.RowHandle, colKhu, row.MaKhu);
                           return;
                       }                  
                  }
            }
            if (e.Column.Name == "colDienCu" || e.Column.Name == "colDienMoi")
             {
                int dc=0,dm=0;                
                    int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoDienCu").ToString(),out dc);
                    int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoDienMoi").ToString(),out dm);

                    gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["SoDienTieuThu"],dm-dc);
                    return;
             }
            if(e.Column.Name == "ColNuocCu" || e.Column.Name == "ColNuocMoi")
            {
                int dc = 0, dm = 0;
                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoNuocCu").ToString(), out dc);
                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoNuocMoi").ToString(), out dm);

                gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["SoNuocTieuThu"], dm - dc);
                return;
            }
            if (e.Column.Name == "colGiaDien" || e.Column.Name == "colGiaNuoc")
            {
                double td = 0, tn = 0;
                int d=0, n = 0;
                double.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("GiaTienDien").ToString(), out td);
                double.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("GiaTienNuoc").ToString(), out tn);

                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoDienTieuThu").ToString(), out d);
                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoNuocTieuThu").ToString(), out n);

                gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["TongTien"], (td*d)+(tn*n));
                gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["SoTienDien"], (td * d));
                gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["SoTienNuoc"], (tn * n));

                return;
            }

        }
            #endregion
        private void btnTaoHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form.DienNuoc.frmTaoHoaDon thd = new DienNuoc.frmTaoHoaDon();
            thd.ShowDialog();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView grid = gridDienNuoc.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
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

        private void gridViewDienNuoc_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle == -2147483647)
            {
                list.Add(gridViewDienNuoc.DataRowCount);
            }
            else
            {
                list.Add(e.RowHandle);
                gridViewDienNuoc.OptionsView.ShowGroupedColumns = false;
            }
        }

        private void gridViewDienNuoc_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var dt = dnb.ListDienNuoc();
            Report.reportDienNuoc rper = new Report.reportDienNuoc(dt);
            rper.DataSource = dt;
            rper.ShowPreview();
            this.Cursor = Cursors.Default;
        }

       

       
       

       
        
    }
}

