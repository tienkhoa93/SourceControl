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
using DevExpress.XtraGrid.Columns;

namespace QLNT.Form.DienNuoc
{
    public partial class frmDienNuocUcl : DevExpress.XtraEditors.XtraForm
    {
        Business.DienNuoc_Bus dnb = new Business.DienNuoc_Bus();
        Business.Khu_Bus kb = new Business.Khu_Bus();
        Business.Phong_Bus pb = new Business.Phong_Bus();
        DataTable dt = new DataTable();
        Business.Options_Bus opb = new Business.Options_Bus();
        public frmDienNuocUcl()
        {
            InitializeComponent();
        }
        public frmDienNuocUcl(DataTable dt)
        {
            InitializeComponent();

          
         
            gridPhong.DisplayMember = "TenPhong";
            gridPhong.ValueMember = "MaPhong";

     
            gridPhong.DataSource = pb.ListPhong();

            colThang.Fixed = FixedStyle.Left;
            colNam.Fixed = FixedStyle.Left;
         
            gridDienNuoc.DataSource = dt;
            this.dt = dt;
        }
        bool KiemTra()
        {
            int fc = gridViewDienNuoc.FocusedRowHandle;
                DataView view = (DataView)gridViewDienNuoc.DataSource;
                DataTable dt = view.ToTable();
               
                bool er = false;
                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    float dc = 0, dm = 0, nc = 0, nm = 0, td = 0, tn = 0, gd = 0, gn = 0;
                    int thang = 0, nam = 0;
                    if (!float.TryParse(dt.Rows[i]["SoDienCu"].ToString(), out dc))
                        dt.Rows[i]["SoDienCu"] = 0;
                    if (!float.TryParse(dt.Rows[i]["SoDienMoi"].ToString(), out dm))
                        dt.Rows[i]["SoDienMoi"] = 0;
                    if (!float.TryParse(dt.Rows[i]["SoNuocCu"].ToString(), out nc))
                        dt.Rows[i]["SoNuocCu"] = 0;
                    if (!float.TryParse(dt.Rows[i]["SoNuocMoi"].ToString(), out nm))
                        dt.Rows[i]["SoNuocMoi"] = 0;
                    if (!float.TryParse(dt.Rows[i]["GiaTienDien"].ToString(), out td))
                        dt.Rows[i]["GiaTienDien"] = 0;
                    if (!float.TryParse(dt.Rows[i]["GiaTienNuoc"].ToString(), out tn))
                        dt.Rows[i]["GiaTienNuoc"] = 0;
                    if (!int.TryParse(dt.Rows[i]["Thang"].ToString(), out thang))
                        dt.Rows[i]["Thang"] = DateTime.Today.Month.ToString();
                    if (!int.TryParse(dt.Rows[i]["Nam"].ToString(), out nam))
                        dt.Rows[i]["Nam"] = DateTime.Today.Year.ToString();

                    if (!float.TryParse(dt.Rows[i]["GiaTienDien"].ToString(), out gd) || gd == 0)
                        dt.Rows[i]["GiaTienDien"] = opb.GetOp().GiaTienDien;

                    if (!float.TryParse(dt.Rows[i]["GiaTienNuoc"].ToString(), out gn) || gn == 0)
                        dt.Rows[i]["GiaTienNuoc"] = opb.GetOp().GiaTienNuoc;

                    if (dc < 0 || dm < 0 || dc > dm || nc < 0 || nm < 0 || nc > nm || gd < 0 || gn < 0)
                    {
                        gridViewDienNuoc.SelectRow(i);
                        gridViewDienNuoc.Appearance.SelectedRow.BackColor = Color.Red;
                        er = true;
                    }
                }
                if (er)
                {
                    XtraMessageBox.Show("Tìm thấy lỗi trong quá trình tính toán.\nVui lòng kiểm tra lại các dòng được đánh dấu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                  else
                {
                    return true;
                }
             
            
        }
        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataView dv = (DataView)gridViewDienNuoc.DataSource;
            dt = dv.ToTable();
            int k = dt.Rows.Count;
            int k1 = dt.Columns.Count;
            bool er = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    if (int.Parse(dt.Rows[i]["SoNuocCu"].ToString()) < 0 || int.Parse(dt.Rows[i]["SoNuocMoi"].ToString()) < 0 || (int.Parse(dt.Rows[i]["SoNuocCu"].ToString()) > int.Parse(dt.Rows[i]["SoNuocMoi"].ToString()) || int.Parse(dt.Rows[i]["SoDienCu"].ToString()) < 0 || int.Parse(dt.Rows[i]["SoDienMoi"].ToString()) < 0 || int.Parse(dt.Rows[i]["SoDienCu"].ToString()) > int.Parse(dt.Rows[i]["SoDienMoi"].ToString())))
                    {
                        gridViewDienNuoc.SelectRow(i);
                        gridViewDienNuoc.Appearance.SelectedRow.BackColor = Color.Red;
                        er = true;
                    }
                    else
                    {
                        dt.Rows[i]["SoNuocTieuThu"] = int.Parse(dt.Rows[i]["SoNuocMoi"].ToString()) - int.Parse(dt.Rows[i]["SoNuocCu"].ToString());
                        dt.Rows[i]["SoDienTieuThu"] = int.Parse(dt.Rows[i]["SoDienMoi"].ToString()) - int.Parse(dt.Rows[i]["SoDienCu"].ToString());
                        dt.Rows[i]["SoTienDien"] = int.Parse(dt.Rows[i]["SoDienTieuThu"].ToString()) * float.Parse(dt.Rows[i]["GiaTienDien"].ToString());
                        dt.Rows[i]["SoTienNuoc"] = int.Parse(dt.Rows[i]["SoNuocTieuThu"].ToString()) * float.Parse(dt.Rows[i]["GiaTienNuoc"].ToString());
                        dt.Rows[i]["TongTien"] = float.Parse(dt.Rows[i]["SoTienDien"].ToString()) + float.Parse(dt.Rows[i]["SoTienNuoc"].ToString());
                        dt.Rows[i]["TrangThai"] = false;
                    }
                }
                catch
                {
                    gridViewDienNuoc.SelectRow(i);
                    gridViewDienNuoc.Appearance.SelectedRow.BackColor = Color.Red;
                    er = true;
                }
            }

            if (!er)
            {

                dnb.SaveDienNuoc(dt);
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Tạo hóa đơn thành công click Nạp Lại để xem hóa đơn mới tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Phát hiện lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Cursor = Cursors.Default;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {                   
            gridViewDienNuoc.DeleteSelectedRows();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            this.Close();
        }

        private void gridViewDienNuoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {



            if (e.Column.Name == "colSoDienCu" || e.Column.Name == "colSoDienMoi")
            {
                int dc = 0, dm = 0;
                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoDienCu").ToString(), out dc);
                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoDienMoi").ToString(), out dm);

                gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["SoDienTieuThu"], dm - dc);
                return;
            }
            if (e.Column.Name == "colSoNuocCu" || e.Column.Name == "colSoNuocMoi")
            {
                int dc = 0, dm = 0;
                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoNuocCu").ToString(), out dc);
                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoNuocMoi").ToString(), out dm);

                gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["SoNuocTieuThu"], dm - dc);
                return;
            }
            if (e.Column.Name == "colGiaTienDien" || e.Column.Name == "colGiaTienNuoc")
            {
                double td = 0, tn = 0;
                int d = 0, n = 0;
                double.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("GiaTienDien").ToString(), out td);
                double.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("GiaTienNuoc").ToString(), out tn);

                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoDienTieuThu").ToString(), out d);
                int.TryParse(gridViewDienNuoc.GetFocusedRowCellValue("SoNuocTieuThu").ToString(), out n);

                gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["TongTien"], (td * d) + (tn * n));
                gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["SoTienDien"], (td * d));
                gridViewDienNuoc.SetRowCellValue(e.RowHandle, gridViewDienNuoc.Columns["SoTienNuoc"], (tn * n));

                return;
            }
        }
    }
}