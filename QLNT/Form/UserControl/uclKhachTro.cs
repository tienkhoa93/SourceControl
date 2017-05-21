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
using DevExpress.XtraBars.Ribbon;
using Common;
using QLNT.Business;
using QLNT.LinQToSQL;
using System.IO;

namespace QLNT.Form.UserControl
{
    public partial class uclKhachTro : DevExpress.XtraEditors.XtraUserControl
    {
        Business.Khu_Bus kb = new Business.Khu_Bus();
        Business.Phong_Bus pb = new Business.Phong_Bus();
        public uclKhachTro()
        {
            InitializeComponent();
            CreateGroupKhu();
            PhanQuyen();
           
        }

     
        void CreateGroupKhu()
        {
           
            List<QLNT.LinQToSQL.Khu> khu = kb.GetAllKhu();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup g;
            DevExpress.XtraBars.Ribbon.GalleryItem item;
            foreach(QLNT.LinQToSQL.Khu k in khu)
            {
                g = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
                g.Caption = k.TenKhu;
                List<LinQToSQL.Phong> phong = pb.ListPhong_TheoMaKhu(k.MaKhu);
                for (int i = 0; i < phong.Count;i++ )
                {
                    item = new DevExpress.XtraBars.Ribbon.GalleryItem();
                    item.Caption = phong[i].TenPhong + "[" + phong[i].MaPhong + "]\nGiá:" + String.Format("{0:0,0}", phong[i].GiaPhong) + " vnd";
                    if(phong[i].SoNguoi>0)
                    {
                        item.Description = "Hiện đang có " + phong[i].SoNguoi+" người\n";
                    }
                    else { item.Description = "Trạng thái: Trống. "; }
                    item.Value = phong[i].MaPhong;
                    if (File.Exists(@"../../../Resources/user-icon1.png"))
                        item.Image = Image.FromFile(@"../../../Resources/user-icon1.png"); 
                    g.Items.Add(item);
                }
                    galleryPhong.Gallery.Groups.Add(g);
            }
        }

        private void galleryPhong_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
           
           
        }


        
    }
}
