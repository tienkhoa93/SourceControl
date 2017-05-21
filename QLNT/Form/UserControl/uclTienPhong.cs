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
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;
using QLNT.LinQToSQL;
using QLNT.Business;
using Common;
using DevExpress.XtraReports.UI;

namespace QLNT.Form.UserControl
{
    public partial class uclTienPhong : DevExpress.XtraEditors.XtraUserControl
    {
        List<int> temp = new List<int>();
        Business.Tien_Buss tb = new Business.Tien_Buss();
        Business.Phong_Bus pb = new Business.Phong_Bus();
        List<LinQToSQL.ThongTinDongTien> ttt = new List<LinQToSQL.ThongTinDongTien>();
        int dem = 0;
        public uclTienPhong()
        {
            InitializeComponent();
            Infomation();
            dem = gvTienPhong.RowCount-1;
            for (int i = 1; i < DateTime.Today.Month; i++)
                cboThang.Items.Add(i);
            cboNam.Items.Add(DateTime.Today.Year);
                cboTien.EditValueChanged += cboTien_EditValueChanged;
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
            List<SysQuyenSuDung> listquyen = qsdb.SelectQuyenSuDung(manhom, "19");
            foreach (var b in listquyen)
            {
                if (b.Xoa == false)
                    btnXoa.Enabled = false;
                if (b.XuatDuLieu == false)
                    btnXuat.Enabled = false;
               
                if (b.InAn == false)
                    btnIn.Enabled = false;
            }

        }

        void cboTien_EditValueChanged(object sender, EventArgs e)
        {
            ttt = tb.ListThongTinTien();
            double tien = 0;
            string c=string.Empty;
            List<object>ob = cboTien.Items.GetCheckedValues();
            foreach(object obb in ob)
            {              
                foreach(LinQToSQL.ThongTinDongTien tt in ttt)
                {
                    if (tt.MaLoaiTien == obb.ToString())
                        tien +=(double)tt.SoTienDong;
                }
            }

            gvTienPhong.SetFocusedRowCellValue(gvTienPhong.Columns["TongTien"], tien);
        }

     
        #region  create rows and column for grid


        void Infomation()
        {
            gridTienPhong.DataSource = tb.ListTien();
            cboTien.DataSource = tb.ListThongTinTien();
          

            GridColumn col111 = new GridColumn();
            col111.Caption = "Mã Phòng";
            col111.FieldName = "MaPhong";
            col111.VisibleIndex = 0;

            GridColumn col21 = new GridColumn();
            col21.Caption = "Tên Phòng";
            col21.FieldName = "TenPhong";
            col21.VisibleIndex = 1;

            gluPhongO.DisplayMember = "TenPhong";
            gluPhongO.ValueMember = "MaPhong";

            gluPhongO.View.Columns.Add(col111);
            gluPhongO.View.Columns.Add(col21);
            gluPhongO.DataSource = pb.ListPhong();
           
            //------------------

            gridSoTien.ValueMember = "MaLoaiTien";
            gridSoTien.DisplayMember = "SoTienDong";
        }

        #endregion
        #region change money when click orther column money
        
       //
        /// <summary>
        ///change money when click orther column money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvTienPhong_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colLoaiTien")
            {
                gvTienPhong.SetRowCellValue(gvTienPhong.FocusedRowHandle, gvTienPhong.Columns["colSoTien"], e.Value);
            }
            if (e.RowHandle == -2147483647)           
                temp.Add(gvTienPhong.RowCount - 1);
            else
                temp.Add(e.RowHandle);
        }
        #endregion
        #region In
        
     
        /// <summary>
        ///  in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var dt = tb.ListTien();

            foreach (DataRow row in dt.Rows)
            {
                string[] c = row["MaLoaiTien"].ToString().Split(',', ' ', ' ');
                row["MaLoaiTien"] = tb.TenTien(c);
            }
            Report.reportTienPhong rp = new Report.reportTienPhong(dt);
            rp.DataSource = dt;
            rp.ShowPreview();
            this.Cursor = Cursors.Default;
        }
        #endregion
        #region Them
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int k = 0;
            List<int> list = temp.Distinct().ToList();
            list.RemoveAll(s=>s==-2147483647);
            if(list.Count>0)
            {
                DataView view = (DataView)gvTienPhong.DataSource;
                DataTable dtTien = view.ToTable();
                tb.InsertListTien(list, dtTien);
                gridTienPhong.DataSource = tb.ListTien();
                gvTienPhong.SelectRow(list[0]);
            }
            temp.Clear();
            dem = gvTienPhong.RowCount - 1;
            XtraMessageBox.Show("Thêm thành công.");
        }
        #endregion
        #region Xoa
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Thực hiện thao tác?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                List<int> str = new List<int>();
                for (int i = 0; i < gvTienPhong.RowCount; i++)
                {
                    if (gvTienPhong.IsRowSelected(i) == true)
                        str.Add(int.Parse( gvTienPhong.GetRowCellValue(i, "ID").ToString()));
                }
                str.RemoveAll(s => s == null);
                if(str.Count>0)
                { 
                        tb.DeleteMaTien(str);
                        for (int i = 0; i < gvTienPhong.RowCount; i++)
                            if (gvTienPhong.IsRowSelected(i) == true)
                                gvTienPhong.DeleteSelectedRows();
                }
            }
        }
        #endregion
        #region Nap lai
        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridTienPhong.DataSource = tb.ListTien();
            gridSoTien.DataSource = tb.ListThongTinTien();
        }
        #endregion

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView grid = gridTienPhong.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
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



    }
}
