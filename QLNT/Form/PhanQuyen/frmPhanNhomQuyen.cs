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
using DevExpress.XtraTreeList.Nodes;
using QLNT.LinQToSQL;
using QLNT.Business;
using DevExpress.XtraTreeList;
using System.Drawing.Drawing2D;

namespace QLNT.Form.PhanQuyen
{
    public partial class frmPhanNhomQuyen : DevExpress.XtraEditors.XtraForm
    {
        SysChucNang cn = new SysChucNang();
        SysChucNang_Bus cnb = new SysChucNang_Bus();
        SysQuyenSuDung_Bus qsdb = new SysQuyenSuDung_Bus();
        SysQuyenSuDung qsd = new SysQuyenSuDung();
        SysNguoiDung_Bus ndb = new SysNguoiDung_Bus();
        string manhom;
        string machucnang = "1";
        public frmPhanNhomQuyen(string mn)
        {
            InitializeComponent();
            VeCayChucNang();
            string user = Common.UserInfo.Account;
            manhom = mn;
            gridQuyenSuDung.DataSource = qsdb.SelectQuyenSuDung(manhom, "0");


        }

        private void VeCayChucNang()
        {

            SysChucNang cn = new SysChucNang();

            TreeListNode rootNode = null;
            TreeListNode childnode0 = null;
            TreeListNode childNode = null;
            TreeListNode childNode1 = null;

            rootNode = treeListPhanQuyen.AppendNode(null, null);
            rootNode.SetValue("ChucNang", "Ký Túc Xá Cao Đẳng Công Thương");
            rootNode.StateImageIndex = 0;
            List<SysChucNang> chucnang = cnb.SelectSysChucNang_Cap("0", 0);
            foreach (var a in chucnang)
            {
                childnode0 = treeListPhanQuyen.AppendNode(null, rootNode);
                childnode0.SetValue("ChucNang", a.TenChucNang);
                childnode0.StateImageIndex = 1;
                childnode0.Tag = a.MaChucNang;

                List<SysChucNang> chucnang1 = cnb.SelectSysChucNang_Cap(a.MaChucNang, 1);
                foreach (var c in chucnang1)
                {
                    childNode = treeListPhanQuyen.AppendNode(null, childnode0);
                    childNode.SetValue("ChucNang", c.TenChucNang);
                    childNode.Tag = c.MaChucNang;
                    childNode.StateImageIndex = 2;

                    List<SysChucNang> chucnang2 = cnb.SelectSysChucNang_Cap(c.MaChucNang, 2);
                    foreach (var d in chucnang2)
                    {
                        childNode1 = treeListPhanQuyen.AppendNode(null, childNode);
                        childNode1.SetValue("ChucNang", d.TenChucNang);
                        childNode1.Tag = d.MaChucNang;
                        childNode1.StateImageIndex = 2;
                    }
                }

            }
            treeListPhanQuyen.ExpandAll();


        }

        private void treeListPhanQuyen_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            TreeList tree = sender as TreeList;
            Brush backBrush, foreBrush;
            if (e.Node == tree.FocusedNode)
            {
                backBrush = new LinearGradientBrush(e.Bounds, Color.OldLace, Color.Orange,
                   LinearGradientMode.Horizontal);
                foreBrush = new SolidBrush(Color.Black);
                e.Graphics.FillRectangle(backBrush, e.Bounds);
                e.Graphics.DrawString(e.CellText, e.Appearance.Font, foreBrush, e.Bounds, e.Appearance.GetStringFormat());
                e.Handled = true;
            }
        }

        private void treeListPhanQuyen_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            try
            {
                gridQuyenSuDung.DataSource = qsdb.SelectQuyenSuDung(manhom, e.Node.Tag.ToString());
                machucnang = e.Node.Tag.ToString();
            }
            catch { }


        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            bool a = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["TatCa"]).ToString());
            bool b = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["Them"]).ToString());
            bool c = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["Xoa"]).ToString());
            bool d = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["Sua"]).ToString());
            bool h = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["InAn"]).ToString());
            bool f = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["NhapDuLieu"]).ToString());
            bool g = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["XuatDuLieu"]).ToString());
            bool k = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["TruyCap"]).ToString());
            if (e.Column.Name == "colTatCa")
            {

                if (a == false)
                {
                    gridView2.SetRowCellValue(0, gridView2.Columns["TatCa"], true);
                    gridView2.SetRowCellValue(0, gridView2.Columns["Them"], true);
                    gridView2.SetRowCellValue(0, gridView2.Columns["Xoa"], true);
                    gridView2.SetRowCellValue(0, gridView2.Columns["Sua"], true);
                    gridView2.SetRowCellValue(0, gridView2.Columns["InAn"], true);
                    gridView2.SetRowCellValue(0, gridView2.Columns["TruyCap"], true);
                    gridView2.SetRowCellValue(0, gridView2.Columns["NhapDuLieu"], true);
                    gridView2.SetRowCellValue(0, gridView2.Columns["XuatDuLieu"], true);
                }
                else
                {
                    gridView2.SetRowCellValue(0, gridView2.Columns["TatCa"], false);
                    gridView2.SetRowCellValue(0, gridView2.Columns["Them"], false);
                    gridView2.SetRowCellValue(0, gridView2.Columns["Xoa"], false);
                    gridView2.SetRowCellValue(0, gridView2.Columns["Sua"], false);
                    gridView2.SetRowCellValue(0, gridView2.Columns["InAn"], false);
                    gridView2.SetRowCellValue(0, gridView2.Columns["TruyCap"], false);
                    gridView2.SetRowCellValue(0, gridView2.Columns["NhapDuLieu"], false);
                    gridView2.SetRowCellValue(0, gridView2.Columns["XuatDuLieu"], false);
                }
            }
            else if (e.Column.Name == "colThem")
            {

                if (b == true)
                {

                    gridView2.SetRowCellValue(0, gridView2.Columns["TatCa"], false);
                }
            }
            else if (e.Column.Name == "colSua")
            {
                if (d == true)
                {

                    gridView2.SetRowCellValue(0, gridView2.Columns["TatCa"], false);
                }
            }
            else if (e.Column.Name == "colXoa")
            {
                if (c == true)
                {

                    gridView2.SetRowCellValue(0, gridView2.Columns["TatCa"], false);
                }
            }
            else if (e.Column.Name == "colTruyCap")
            {
                if (k == true)
                {
                    gridView2.SetRowCellValue(0, gridView2.Columns["TatCa"], false);
                }
            }
            else if (e.Column.Name == "colIn")
            {
                if (h == true)
                {

                    gridView2.SetRowCellValue(0, gridView2.Columns["TatCa"], false);
                }
            }
            else if (e.Column.Name == "colNhapDuLieu")
            {
                if (f == true)
                {
                    gridView2.SetRowCellValue(0, gridView2.Columns["TatCa"], false);
                }
            }
            else
            {
                if (g == true)
                {

                    gridView2.SetRowCellValue(0, gridView2.Columns["TatCa"], false);
                }
            }

            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            qsd.MaNhom = manhom;
            qsd.MaChucNang = machucnang;
            qsd.MaThaoTac = 0;
            qsd.TatCa = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["TatCa"]).ToString());
            qsd.Them = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["Them"]).ToString());
            qsd.Xoa = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["Xoa"]).ToString());
            qsd.Sua = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["Sua"]).ToString());
            qsd.InAn = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["InAn"]).ToString());
            qsd.TruyCap = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["TruyCap"]).ToString());
            qsd.XuatDuLieu = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["XuatDuLieu"]).ToString());
            qsd.NhapDuLieu = bool.Parse(gridView2.GetRowCellValue(0, gridView2.Columns["NhapDuLieu"]).ToString());
            qsd.HoatDong = true;

            if (!qsdb.UpdateQuyenSuDung(qsd))
                XtraMessageBox.Show("Sửa Quyền Không Thành Công !!!");
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}