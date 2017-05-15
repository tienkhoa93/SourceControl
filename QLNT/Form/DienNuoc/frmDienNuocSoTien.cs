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
    public partial class frmDienNuocSoTien : DevExpress.XtraEditors.XtraForm
    {
        Business.Phong_Bus pb = new Business.Phong_Bus();
        Business.DienNuoc_Bus dnb = new Business.DienNuoc_Bus();
        public frmDienNuocSoTien(DataTable dt)
        {
            InitializeComponent();
            grcDienNuoc.DataSource = dt;
           
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
           
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                    gvDienNuoc.DeleteSelectedRows();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt = new DataTable();
            DataView dv = (DataView)gvDienNuoc.DataSource;
            dt = dv.ToTable();

            if(dt.Rows.Count>0)
                dnb.InsertDataTable(dt);
            this.Close();
        }
    }
}