using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using QLNT.LinQToSQL;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System.Data.Linq;
using DevExpress.XtraGrid.Columns;
using Common;


namespace QLNT.Form.UserControl
{
    public partial class uclQuanLyVatTu : DevExpress.XtraEditors.XtraUserControl
    {
        Business.QuanLyVatTuBus qlvtb = new Business.QuanLyVatTuBus();
        QLNTDataContext db = new QLNTDataContext();
        List<int> list = new List<int>();

        public uclQuanLyVatTu()
        {
            InitializeComponent();
        }
        void RefeshG(object ob)
        {
            gridQuanLiVatTu.DataSource = ob;
        }
        private void gridQuanLiVatTu_Load(object sender, EventArgs e)
        {
            this.gridViewQuaLiVatTu.OptionsBehavior.Editable = false;
            gridQuanLiVatTu.DataSource = qlvtb.ListQuanLyVatTu();
        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridQuanLiVatTu.DataSource = qlvtb.ListQuanLyVatTu();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            //componentLink.Component = gridViewQuaLiVatTu.Ip;
            //componentLink.CreateDocument();
            //PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            //pt.ShowPreviewDialog();
            //if (!gridViewQuaLiVatTu.IsPrintingAvailable)
            //{
            //    MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
            //    return;
            //}

            // Open the Preview window.
            gridViewQuaLiVatTu.ShowPrintPreview();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form.DanhMuc.VatTu.frmQuanLyVatTu frm = new DanhMuc.VatTu.frmQuanLyVatTu(ChucNang.Them, null);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form.DanhMuc.VatTu.frmVatTu frm = new DanhMuc.VatTu.frmVatTu();
            frm.ShowDialog();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<Business.QuanLiVatTu_B> kh = (List<Business.QuanLiVatTu_B>)gridViewQuaLiVatTu.DataSource;
            //gridViewQuaLiVatTu.FocusedRowHandle = Convert.ToInt16(gridQuanLiVatTu.AutoFilterRowHandle);
            Business.QuanLiVatTu_B item = (Business.QuanLiVatTu_B)kh[gridViewQuaLiVatTu.FocusedRowHandle];
            DanhMuc.VatTu.frmQuanLyVatTu pb = new DanhMuc.VatTu.frmQuanLyVatTu(ChucNang.Sua, item);
            Common.Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            pb.ShowDialog();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<Business.QuanLiVatTu_B> sinhvien = (List<Business.QuanLiVatTu_B>)gridViewQuaLiVatTu.DataSource;
            Business.QuanLiVatTu_B khu = (Business.QuanLiVatTu_B)sinhvien[gridViewQuaLiVatTu.FocusedRowHandle];
            try
            {
                qlvtb.DeleteQuanLyVatTu(khu.ID);
                XtraMessageBox.Show("Xóa " + khu.TenPhong + " thành công");
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Khu này có phòng còn Sinh viên, vui lòng xóa hết phòng trong " + khu.TenPhong, "Thông báo");
            }
            gridQuanLiVatTu.DataSource = qlvtb.ListQuanLyVatTu();
        }

        private void gridViewQuaLiVatTu_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
