using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraBars.Ribbon;
using Common;
using QLNT.Business;
using QLNT.LinQToSQL;
using System.IO;
using System.Data.Linq;

namespace QLNT.Form.UserControl
{
    public partial class uclKhachTro : DevExpress.XtraEditors.XtraUserControl
    {
        QLNTDataContext dtcontext = new QLNTDataContext();
        Business.Khu_Bus kb = new Business.Khu_Bus();
        Business.Phong_Bus pb = new Business.Phong_Bus();
        public uclKhachTro()
        {
            InitializeComponent();
            CreateGroupKhu();
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
            List<SysQuyenSuDung> listquyen = qsdb.SelectQuyenSuDung(manhom, "17");
            foreach (var b in listquyen)
            {
                if (b.Them == false)
                    btnThemPhong.Enabled = false;

            }

        }
        void RefeshG(object ob)
        {
            galleryPhong.Gallery.Groups.Clear();
            List<QLNT.LinQToSQL.Khu> khu = kb.GetAllKhu();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup g;
            DevExpress.XtraBars.Ribbon.GalleryItem item;
            foreach (QLNT.LinQToSQL.Khu k in khu)
            {
                g = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
                g.Caption = k.TenKhu;
                List<LinQToSQL.Phong> phong = pb.ListPhong_TheoMaKhu(k.MaKhu);
                for (int i = 0; i < phong.Count; i++)
                {
                    item = new DevExpress.XtraBars.Ribbon.GalleryItem();
                    item.Caption = phong[i].TenPhong + "[" + phong[i].MaPhong + "]\nGiá:" + String.Format("{0:0,0}", phong[i].GiaPhong) + " vnd";
                    if (phong[i].SoNguoi > 0)
                    {
                        item.Description = "Hiện đang có " + phong[i].SoNguoi + " người\n";
                    }
                    else { item.Description = "Trạng thái: Rỗng. "; }
                    item.Value = phong[i].MaPhong;
                    item.Image = Image.FromFile(@"../../Resources/1.png");
                    g.Items.Add(item);
                }

                galleryPhong.Gallery.Groups.Add(g);
            }
        }

        void CreateGroupKhu()
        {

            List<QLNT.LinQToSQL.Khu> khu = kb.GetAllKhu();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup g;
            DevExpress.XtraBars.Ribbon.GalleryItem item;
            foreach (QLNT.LinQToSQL.Khu k in khu)
            {
                g = new GalleryItemGroup();
                g.Caption = k.TenKhu;
                List<LinQToSQL.Phong> phong = pb.ListPhong_TheoMaKhu(k.MaKhu);
               
                for (int i = 0; i < phong.Count; i++)
                {
                    
                    item = new DevExpress.XtraBars.Ribbon.GalleryItem();
                    item.Caption = phong[i].TenPhong + "[" + phong[i].MaPhong + "]\nGiá:" + String.Format("{0:0,0}", phong[i].GiaPhong) + " vnd";
                    ISingleResult<NT_StatisticsCountEachRoomResult> result = dtcontext.NT_StatisticsCountEachRoom(phong[i].MaPhong);
                    
                    int count = 0;
                    foreach( var item1 in result)
                    {
                        count = item1.Total.Value;
                    }
                   //if (value != null && value..count > 0)
                   //{
                   //    string a = value[0][0].ToString();
                   //}
                    if (count > 0)
                    {
                        item.Description = "Hiện đang có " + count + " người\n";
                    }
                    else { item.Description = "Trạng thái: Trống. "; }

                    //if (phong[i].SoNguoi > 0)
                    //{
                    //    item.Description = "Hiện đang có " + phong[i].SoNguoi + " người\n";
                    //    item.Description = "Hiện đang có " + count + " người\n";
                    //}
                    //else { item.Description = "Trạng thái: Trống. "; }
                    item.Value = phong[i].MaPhong;
                    if (File.Exists(@"../../Resources/1.png"))// user-icon1 @"../../Resources/1.png"
                        item.Image = Image.FromFile(@"../../Resources/1.png");
                    g.Items.Add(item);
                }
                galleryPhong.Gallery.Groups.Add(g);
            }
        }

        private void galleryPhong_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {


        }

        private void galleryControlGallery1_ItemDoubleClick(object sender, GalleryItemClickEventArgs e)
        {
            Form.PhongBan.frmKhachTro_Phong kt = new PhongBan.frmKhachTro_Phong(e.Item.Value.ToString());
            kt.ShowDialog();
            Phong_Bus pb = new Phong_Bus();
            Phong pg = pb.SoNguoi(e.Item.Value.ToString());
            e.Item.Caption = pg.TenPhong + "[" + pg.MaPhong + "]\nGiá:" + String.Format("{0:0,0}", pg.GiaPhong) + " vnd";
            ISingleResult<NT_StatisticsCountEachRoomResult> result = dtcontext.NT_StatisticsCountEachRoom(pg.MaPhong);

            int count = 0;
            foreach (var item1 in result)
            {
                count = item1.Total.Value;
            }
            if (count > 0)
            {
                e.Item.Description = "Hiện đang có " + count + " người\n";
            }
                else { e.Item.Description = "Trạng thái: Trống. "; }
            //if (pg.SoNguoi > 0)
            //{
            //    e.Item.Description = "Hiện đang có " + pg.SoNguoi + " người\n";
            //}
           // else { e.Item.Description = "Trạng thái: Trống. "; }
            e.Item.Value = pg.MaPhong;

        }

        private void btnThemPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form.PhongBan.frmPhongBan pb = new PhongBan.frmPhongBan(Common.ChucNang.Them, null);
            Delegates.Regrib = new Delegates.RefeshGrid(RefeshG);
            pb.ShowDialog();
        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateGroupKhu();
        }


    }
}
