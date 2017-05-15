using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace QLNT.Form.UserControl
{
    public partial class uclBaoCaoPhong : DevExpress.XtraEditors.XtraUserControl
    {
        Business.Phong_Bus pb = new Business.Phong_Bus();
        public uclBaoCaoPhong()
        {
            InitializeComponent();
            grcPhong.DataSource = pb.ListPhong();
           
        }
        void LocGiuLieu()
        {
            if (cboThongKe.EditValue.ToString() == "Phòng trống")
            {

                dateToiNgay.Edit.ReadOnly = true;
                dateTuNgay.Edit.ReadOnly = true;
                grcPhong.DataSource = pb.ListPhongConTrong();
            }
            else if (cboThongKe.EditValue.ToString() == "Tất cả")
            {
                grcPhong.DataSource = pb.ListPhong();
                dateToiNgay.Edit.ReadOnly = true;
                dateTuNgay.Edit.ReadOnly = true;
            }
            else
            {
                dateToiNgay.Edit.ReadOnly = false;
                dateTuNgay.Edit.ReadOnly = false;
                try { 
                grcPhong.DataSource = pb.PhongXapHetHan(DateTime.Parse(dateTuNgay.EditValue.ToString()),DateTime.Parse(dateToiNgay.EditValue.ToString()));
                }
                catch { }
            }
        }
        private void cboThongKe_EditValueChanged(object sender, EventArgs e)
        {
            LocGiuLieu();
           
        }

        private void dateTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            LocGiuLieu();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView grid = grcPhong.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
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
