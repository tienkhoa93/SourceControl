using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;
using Common;
using DevExpress.LookAndFeel;
using QLNT.Form.UserControl;
using System.Threading;
using DevExpress.XtraReports.UI;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using System.Xml;
using QLNT.Form.PhanQuyen;
using QLNT.LinQToSQL;
using QLNT.Business;
using QLNT.Form.UserControl;
using QLNT.Form.In;
namespace QLNT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Thread a;
        Thread b;
        Business.ThongKe_Bus tk = new Business.ThongKe_Bus();
        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Task t = new Task(() =>
            {
                // đăng ký giao diện
                InitSkinGallery();
            });
            t.Start();   
            PhanQuyen();
            AddNewTab();
        }

        private void PhanQuyen()
        {
            SysNguoiDung_Bus ndb = new SysNguoiDung_Bus();
            SysQuyenSuDung_Bus qsdb = new SysQuyenSuDung_Bus();
            List<SysUser> lisuser = ndb.SelectNguoiDung(Common.UserInfo.Account);
            string manhom = "";
            foreach (var a in lisuser)
            {
                manhom = a.MaNhom;
            }
            List<SysQuyenSuDung> listnhomquyen = qsdb.SelectNhomQuyen(manhom);
            foreach (var b in listnhomquyen)
            {
                List<SysQuyenSuDung> listqsd = qsdb.SelectQuyenSuDung(manhom, b.MaChucNang);
                foreach (var c in listqsd)
                {
                    if (c.TruyCap == false)
                    {
                        switch (c.MaChucNang.ToString())
                        {
                            case "1": ribbonPage2.Visible = false; break;
                            case "2": ribbonPage1.Visible = false; navQuanLySinhVien.Visible = false; break;
                            case "3": ribbonPage3.Visible = false; navQuanLyPhongkhu.Visible = false; break;
                            case "4": ribbonPage4.Visible = false; navQuanLyDienNuoc.Visible = false; break;

                            case "5": giaodien.Enabled = false; break;
                            case "6": btnDoiMatKhau.Enabled = false; break;
                            case "7": btnThietLap.Enabled = false; break;
                            case "8": btnBackup.Enabled = false; break;
                            case "9": barButtonItem7.Enabled = false; break;
                            case "10": btnNhatKy.Enabled = false; break;
                            case "11": barButtonItem1.Enabled = false; break;
                            case "12": btnDanhSachNguoiDung.Enabled = false; break;
                            case "13": btnDanhSachNhomQuyen.Enabled = false; break;
                            case "14": btnDanhSachKhachTro.Enabled = false;
                                navBarItem3.Enabled=false;break;
                            case "16": btnDanhMuc.Enabled = false;
                                navDanhBa.Enabled = false; break;
                            case "17": btnDanhSachPhong.Enabled = false;
                                navBarItem6.Enabled = false; break;

                            case "18": btnDanhSachKhu.Enabled = false; 
                                navDanhSachKhu.Enabled = false; break;
                            case "19": btnTienPhong.Enabled = false;
                                navBarItem7.Enabled = false; break;
                            case "20": btnDienNuocChiSo.Enabled = false;
                                navDienNuocChiSo.Enabled = false; break;
                            case "21": btnHoaDonS.Enabled = false;
                                btnHoaDon.Enabled = false; break;

                            case "22": btnQuanLyVatTu.Enabled = false;
                                navQuanLyVatTu.Enabled = false; break;                       
                        }
                    }

                }

            }

        }
        #region Backup tu dong 
            void BackupAuto()
            {
                Business.Backups_Bus bk = new Business.Backups_Bus();
                LinQToSQL.Backupss backup = bk.GetListBackups();
                Business.Options_Bus opb = new Business.Options_Bus();
                LinQToSQL.Option op=  opb.GetOp();
                Common.BackupData bkcm = new Common.BackupData();
                if (backup.Onn == true&&backup.TrangThai==false)
                {                    
                    string date=DateTime.Today.DayOfWeek.ToString();
                    if (date.Equals(backup.Ngay))
                    {
                        if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn sao lưu dữ liệu không?", "Sao Lưu Tự Động", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            bkcm.Backup_click(op.TenFileBackup, op.LuufileBackup);
                            bk.DaBackup();// sua lai trang thai đã backup
                            return;
                        }
                    }
                    else bk.ChuaBackup();                
                    
                }

            }
        #endregion
        #region Đăng ký giao diện cho phần mềm
        /// <summary>
        /// Giao diện cho phần mềm
        /// </summary>
        void InitSkinGallery()
        {
            RegistryFile.ReadRegistry();
            try {
                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.Skins.SkinManager.EnableMdiFormSkins();
                DevExpress.UserSkins.BonusSkins.Register();
                UserLookAndFeel.Default.UseDefaultLookAndFeel = true;
                UserLookAndFeel.Default.UseWindowsXPTheme = false;
                UserLookAndFeel.Default.SkinName = UserInfo.Skin;
                SkinHelper.InitSkinGallery(giaodien, true);
            }
            catch
            {
                UserLookAndFeel.Default.SkinName = "Blue";
            }
            
        }
        #endregion                  
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            (arg.Page as XtraTabPage).PageVisible = false;
        }
      
        public void AddNewTab()
        {
            CheckForIllegalCrossThreadCalls = false;
            uclKhachTro phong = new uclKhachTro();
            phong.Dock = DockStyle.Fill;
            tabQuanLyPhong.Controls.Add(phong);
            tabQuanLyPhong.PageVisible = true;
            tabMain.SelectedTabPageIndex = 1;
        }        
        /// <summary>
        /// Luu giao dien he thong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void giaodien_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {   
            UserInfo.Skin = e.Item.Caption;                   
        }

        #region Sự kiện sao lưu và phục hồi giữ liệu 
        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form.Systems.frmBackup backup = new Form.Systems.frmBackup();
            backup.ShowDialog();
        }
        private void barButtonItem7_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form.Systems.frmRestore restore = new Form.Systems.frmRestore();
            restore.ShowDialog();
        }
        #endregion
        

        /// <summary>
        ///  Su kien truoc khi dong form thi luu giao dien lai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { 
                RegistryFile.GhiUser(UserInfo.Stt, UserInfo.Account, UserInfo.Pass, UserInfo.Skin);
               // SetConnectionString();
            }
            catch { }
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            SystemOption.Dialog.ThayDoiMatKhau dmk = new SystemOption.Dialog.ThayDoiMatKhau();
            dmk.ShowDialog();
        }
        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uclPhong phong = new uclPhong();
            phong.Dock = DockStyle.Fill;
            tabQuanLyPhong.Controls.Add(phong);        
            tabQuanLyPhong.PageVisible = true;
            tabMain.SelectedTabPageIndex = 1;
        }
        #region sau khi form show len
        /// <summary>
        /// Su kien show form len xong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Shown(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                BackupAuto();
            });
            t.Start();          
        }
        #endregion

        private void btnThietLap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form.Systems.Options frmop = new Form.Systems.Options();
            frmop.ShowDialog();
        }

        private void navDienNuoc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uclDienNuoc dn = new uclDienNuoc();
            dn.Dock = DockStyle.Fill;
            tabDienNuoc.Controls.Add(dn);
            tabDienNuoc.PageVisible = true;
            tabMain.SelectedTabPage = tabDienNuoc;
        }
        void Addcontrol1()
        {
            uclTienPhong tp = new uclTienPhong();
            tp.Dock = DockStyle.Fill;
            this.BeginInvoke((Action)(() =>
            {
                grTien.Controls.Clear();
                grTien.Controls.Add(tp);
            }));
        }
        void Addcontrol2()
        {
            uclLoaiTienDong tp = new uclLoaiTienDong();
            tp.Dock = DockStyle.Fill;
            this.BeginInvoke((Action)(() =>
            {
                grLoaiTien.Controls.Clear();
                grLoaiTien.Controls.Add(tp);
            }));

           
        }
        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            a = new Thread(new ThreadStart(Addcontrol1));
            b = new Thread(new ThreadStart(Addcontrol2));
            a.Start();
            b.Start();
            a.Join();
            b.Join();
            tabTienPhong.PageVisible = true;
            tabMain.SelectedTabPage = tabTienPhong;
        }

        private void navDanhSachKhu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uclKhu khu = new uclKhu();
            khu.Dock = DockStyle.Fill;
            tabkhu.Controls.Add(khu);
            tabkhu.PageVisible = true;
            tabMain.SelectedTabPage = tabkhu;
        }

        private void navQuanLyVatTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uclQuanLyVatTu khu = new uclQuanLyVatTu();
            khu.Dock = DockStyle.Fill;
            tabQuanLyVatTu.Controls.Add(khu);
            tabQuanLyVatTu.PageVisible = true;
            tabMain.SelectedTabPage = tabQuanLyVatTu;
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form.Systems.frmQuanLiDungChung ch = new Form.Systems.frmQuanLiDungChung();
            ch.ShowDialog();
        }
       
        
        /// <summary>
        /// Kỷ luật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void navDienNuocSoTien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uclDienNuocSoTien dn = new uclDienNuocSoTien();
            dn.Dock = DockStyle.Fill;
            tabHoaDon.Controls.Add(dn);
            tabHoaDon.PageVisible = true;
            tabMain.SelectedTabPage = tabHoaDon;
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
          
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
          
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uclDSKhachTro dn = new uclDSKhachTro();
            dn.Dock = DockStyle.Fill;
            tabKhachTro.Controls.Add(dn);
            tabKhachTro.PageVisible = true;
            tabMain.SelectedTabPage = tabKhachTro;
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

     

       
        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form.In.frmInHoaDonDienNuocKoCS frm = new Form.In.frmInHoaDonDienNuocKoCS();
            frm.ShowDialog();
        }

        private void btnNhatKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            uclLichSuTruyCap nk = new uclLichSuTruyCap();
            nk.Dock = DockStyle.Fill;
            tabLichSu.Controls.Add(nk);
            tabLichSu.PageVisible = true;
            tabMain.SelectedTabPage = tabLichSu;
        }
        #region thong ke
        
       
        //}
        //#region Thống kê sinh viên
        //    #region thống kê chỗ trống
        //    /// <summary>
        //    /// thống kê chỗ còn trống theo khu
        //    /// </summary>

        //    void ThongKeChoTrong()
        //    {
        //        CharSiSo.SideBySideEqualBarWidth = false; // resize width's column 
        //        Series series;
        //        List<QLNT.Business.ThongKe_Bus.ThongKeKhu> listkhutrong = tk.SiSoTheoKhu();
        //        foreach (QLNT.Business.ThongKe_Bus.ThongKeKhu tt in listkhutrong)
        //        {
        //            series = new Series(tt.TenKhu, ViewType.Bar);
        //            VeBD(CharSiSo, series, tt.TenKhu, tt.ConTrong);
        //        }
        //        ChartTitle TitleTuoi = new ChartTitle();
        //        TitleTuoi.Text = "Thống kê chỗ trống theo khu";
        //        TitleTuoi.Font = new Font("Times New Roman", 17, FontStyle.Bold);
        //        TitleTuoi.TextColor = Color.Red;
        //        CharSiSo.Titles.Add(TitleTuoi);
        //        CharSiSo.Dock = DockStyle.Fill;

        //    }
        //    #endregion
        //    #region thống kê theo giới tính
        //    void ThongKeGioiTinh()
        //    {
        //        CharGioiTinh.SideBySideEqualBarWidth = false;

        //        List<Business.ThongKe_Bus.ThongKeNamNu_> nn = tk.ThongKeNamNu();
        //        Series sr = new Series("Thống Kê Nam Nữ", ViewType.Pie);
        //        sr.Points.Add(new SeriesPoint(nn[0].GioiTinh, nn[0].TongSo));
        //        sr.Points.Add(new SeriesPoint(nn[1].GioiTinh, nn[1].TongSo));
        //        sr.Label.PointOptions.PointView = PointView.ArgumentAndValues;
        //        CharGioiTinh.Series.Add(sr);

        //        ChartTitle Title = new ChartTitle();
        //        Title.Text = "Thống Kê Sinh Viên KTX";
        //        Title.Font = new Font("Times New Roman", 17, FontStyle.Bold);
        //        Title.TextColor = Color.Red;
        //        CharGioiTinh.Titles.Add(Title);

        //        CharGioiTinh.Dock = DockStyle.Fill;
        //    }
        //    #endregion
        //    #region Thongkedotuoi
        //    void ThongKeDoTuoi() { 
      
            
           
        //        CharThongKeTuoi.SideBySideEqualBarWidth = false;

        //        List<Business.ThongKe_Bus.Tuoi_> nn = tk.ThongKeTuoi();
        //        Series sr = new Series("Thống Kê Sinh Viên Theo Độ Tuổi", ViewType.Pie);
        //        foreach (Business.ThongKe_Bus.Tuoi_ t in nn)
        //        {
        //            sr.Points.Add(new SeriesPoint(t.Tuoi.ToString() +" tuổi",t.SoSV));
        //        }
        //        sr.Label.PointOptions.PointView = PointView.ArgumentAndValues;
        //        CharThongKeTuoi.Series.Add(sr);

        //        ChartTitle Title = new ChartTitle();
        //        Title.Text = "Thống Kê Sinh Viên Theo Độ Tuổi";
        //        Title.Font = new Font("Times New Roman", 17, FontStyle.Bold);
        //        Title.TextColor = Color.Red;
        //        CharThongKeTuoi.Titles.Add(Title);

        //        CharThongKeTuoi.Dock = DockStyle.Fill;
           
           
        //    }

        //    #endregion
        //    #region thống kê theo khóa học

        //void ThongKeKhoaHoc(){
         
        //    // thống kê khóa học
        //    CharKhoaHoc.SideBySideEqualBarWidth = false;

        //    List<Business.ThongKe_Bus.KhoaHoc_> kh = tk.ThongKeTheoKhoaHoc();
        //    Series srkh = new Series("Thống Kê Sinh Viên Theo Độ Tuổi", ViewType.Bar);
        //    foreach (Business.ThongKe_Bus.KhoaHoc_ t in kh)
        //    { 
        //        srkh = new Series("Khóa " + t.TenKhoaHoc.ToString(), ViewType.Bar);
        //        VeBD(CharKhoaHoc, srkh, "Khóa " + t.TenKhoaHoc.ToString(), t.SoSV);
        //    }
        //    srkh.Label.PointOptions.PointView = PointView.ArgumentAndValues;          
        //    ChartTitle TitleKh = new ChartTitle();
        //    TitleKh.Text = "Thống Kê Sinh Viên Theo Khóa Học";
        //    TitleKh.Font = new Font("Times New Roman", 17, FontStyle.Bold);
        //    TitleKh.TextColor = Color.Red;
        //    CharKhoaHoc.Titles.Add(TitleKh);

        //    CharKhoaHoc.Dock = DockStyle.Fill;
           
        //}
        // #endregion
        //    #region Thong ke tat ca dan toc
        //void ThongKeTatCaDanToc()
        //{
        //    CharAllDanToc.SideBySideEqualBarWidth = false;

        //    List<Business.ThongKe_Bus.TatCaDanToc> nn = tk.ThongKeTatCaDanToc();
        //    Series sr = new Series("", ViewType.Pie);
        //    foreach (Business.ThongKe_Bus.TatCaDanToc dt in nn)
        //    {
        //        sr.Points.Add(new SeriesPoint(dt.TenDanToc, dt.SoSV));
        //    }
        //    sr.Label.PointOptions.PointView = PointView.ArgumentAndValues;
        //    CharAllDanToc.Series.Add(sr);

        //    ChartTitle Title = new ChartTitle();
        //    Title.Text = "Thống Kê Tất Cả Dân Tộc";
        //    Title.Font = new Font("Times New Roman", 17, FontStyle.Bold);
        //    Title.TextColor = Color.Red;
        //    CharAllDanToc.Titles.Add(Title);

        //    CharAllDanToc.Dock = DockStyle.Fill;
        //}

        //#endregion
        //    #region Thống kê dân tộc thiểu số
        //    void ThongKeDanTocThieuSo()
        //    {
        //        CharDanTocThieuSo.SideBySideEqualBarWidth = false;

        //        List<Business.ThongKe_Bus.DanTocThieuSo> nn = tk.ThongKeDanTocThieuSo();
        //        Series sr = new Series("", ViewType.Pie);
        //        foreach (Business.ThongKe_Bus.DanTocThieuSo dt in nn)
        //        {
        //            sr.Points.Add(new SeriesPoint(dt.DanToc, dt.SoSV));
        //        }
        //        sr.Label.PointOptions.PointView = PointView.ArgumentAndValues;
        //        CharDanTocThieuSo.Series.Add(sr);

        //        ChartTitle Title = new ChartTitle();
        //        Title.Text = "Thống Kê Dân Tộc Thiểu Số";
        //        Title.Font = new Font("Times New Roman", 17, FontStyle.Bold);
        //        Title.TextColor = Color.Red;
        //        CharDanTocThieuSo.Titles.Add(Title);

        //        CharDanTocThieuSo.Dock = DockStyle.Fill;

        //    }
        
        //    #endregion
            
        //private void btnDanhSachSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //   // splashScreenManager1.ShowWaitForm();
        //    uctlSinhVien sv = new uctlSinhVien();
        //    sv.Dock = DockStyle.Fill;
        //    tabQLSV.Controls.Add(sv);
        //    tabQLSV.PageVisible = true;
        //   // splashScreenManager1.CloseWaitForm();
        //    tabMain.SelectedTabPage = tabQLSV;
           
        //}


        //#endregion
        #endregion
        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnDanhSachPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            uclPhong phong = new uclPhong();
            phong.Dock = DockStyle.Fill;
            tabQuanLyPhong.Controls.Add(phong);
            tabQuanLyPhong.PageVisible = true;
            tabMain.SelectedTabPageIndex = 1;
        }
        private void btnDanhSachKhu_ItemClick(object sender, ItemClickEventArgs e)
        {
            uclKhu khu = new uclKhu();
            khu.Dock = DockStyle.Fill;
            tabkhu.Controls.Add(khu);
            tabkhu.PageVisible = true;
            tabMain.SelectedTabPage = tabkhu;
        }

        private void btnTienPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            a = new Thread(new ThreadStart(Addcontrol1));
            b = new Thread(new ThreadStart(Addcontrol2));
            a.Start();
            b.Start();
            a.Join();
            b.Join();
            tabTienPhong.PageVisible = true;
            tabMain.SelectedTabPage = tabTienPhong;
        }

        private void btnDienNuocChiSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            uclDienNuoc dn = new uclDienNuoc();
            dn.Dock = DockStyle.Fill;
            tabDienNuoc.Controls.Add(dn);
            tabDienNuoc.PageVisible = true;
            tabMain.SelectedTabPage = tabDienNuoc;
        }

        private void btnDienNuocSoTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            uclDienNuocSoTien dn = new uclDienNuocSoTien();
            dn.Dock = DockStyle.Fill;
            tabHoaDon.Controls.Add(dn);
            tabHoaDon.PageVisible = true;
            tabMain.SelectedTabPage = tabHoaDon;
        }

        private void btnQuanLyVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            uclQuanLyVatTu khu = new uclQuanLyVatTu();
            khu.Dock = DockStyle.Fill;
            tabQuanLyVatTu.Controls.Add(khu);
            tabQuanLyVatTu.PageVisible = true;
            tabMain.SelectedTabPage = tabQuanLyVatTu;
        }
        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        private void ribbon_Click(object sender, EventArgs e)
        {
            if (ribbon.SelectedPage==ribbonPage1)
            {
                navQuanLySinhVien.Expanded = true;
                return;
            }
            if (ribbon.SelectedPage == ribbonPage3)
            {
                navQuanLyPhongkhu.Expanded = true;
                return;
            }
            if (ribbon.SelectedPage == ribbonPage4)
            {
                navQuanLyDienNuoc.Expanded = true;
                return;
            }
        }
        private void btnDanhMuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            Form.Systems.frmQuanLiDungChung qldt = new Form.Systems.frmQuanLiDungChung();
            qldt.TopLevel = false;
            qldt.Dock = DockStyle.Fill;
            tabDanhMuc.Controls.Add(qldt);
            tabDanhMuc.PageVisible = true;
            tabMain.SelectedTabPage = tabDanhMuc;
            qldt.Show();
        }

        private void btnBaoCaoSinhVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
         
        }
        #region Danh sách khách trọ
        private void btnDanhSachSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            uclDSKhachTro dn = new uclDSKhachTro();
            dn.Dock = DockStyle.Fill;
            tabKhachTro.Controls.Add(dn);
            tabKhachTro.PageVisible = true;
            tabMain.SelectedTabPage = tabKhachTro;
        }

        private void navDSKhachTro_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uclDSKhachTro dn = new uclDSKhachTro();
            dn.Dock = DockStyle.Fill;
            tabKhachTro.Controls.Add(dn);
            tabKhachTro.PageVisible = true;
            tabMain.SelectedTabPage = tabKhachTro;
        } 
        #endregion
        private void btnHoaDon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uclHoaDon hd = new uclHoaDon();
            tabHoaDon.Controls.Add(hd);
            hd.Dock = DockStyle.Fill;
            tabHoaDon.PageVisible = true;
            tabMain.SelectedTabPage = tabHoaDon;
        }

        private void btnHoaDon_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uclHoaDon hd = new uclHoaDon();
            tabHoaDon.Controls.Add(hd);
            hd.Dock = DockStyle.Fill;
            tabHoaDon.PageVisible = true;
            tabMain.SelectedTabPage = tabHoaDon;
        }

        #region Thống kê

        public void VeBD(ChartControl chart, Series se, string tc, int value)
        {
            //add vào các side-by-side
            se.Points.Add(new SeriesPoint(tc, new double[] { value }));
            se.LabelsVisibility = DefaultBoolean.True;
            //add cot vao bieu do
            chart.Series.Add(se);
        }
        #endregion
        #region Thống kê khách trọ hiện tại trong khu
        /// <summary>
        /// thống kê chỗ còn trống theo khu
        /// </summary>

        
        #endregion

        private void btnDanhSachKhachTro_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            uclDSKhachTro dn = new uclDSKhachTro();
            dn.Dock = DockStyle.Fill;
            tabKhachTro.Controls.Add(dn);
            tabKhachTro.PageVisible = true;
            tabMain.SelectedTabPage = tabKhachTro;
            this.Cursor = Cursors.Default;
        }

        private void btnDanhSachNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLNT.Form.PhanQuyen.frmDanhSachNguoiDung frm = new Form.PhanQuyen.frmDanhSachNguoiDung();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            tabDanhSachNguoiDung.Controls.Add(frm);
            tabDanhSachNguoiDung.PageVisible = true;
            tabMain.SelectedTabPage = tabDanhSachNguoiDung;
            frm.Show();
        }

        private void btnDanhSachNhomQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLNT.Form.PhanQuyen.frmNhomNguoiDung frm = new Form.PhanQuyen.frmNhomNguoiDung();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            tabDanhSachNhomQuyen.Controls.Add(frm);
            tabDanhSachNhomQuyen.PageVisible = true;
            tabMain.SelectedTabPage = tabDanhSachNhomQuyen;
            frm.Show();
        }

        private void btnDanhSachKyLuat_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form.Systems.Login lg = new Form.Systems.Login();
            this.Hide();
            lg.ShowDialog();
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void navDanhBa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form.Systems.frmQuanLiDungChung qldt = new Form.Systems.frmQuanLiDungChung();
            qldt.TopLevel = false;
            qldt.Dock = DockStyle.Fill;
            tabDanhMuc.Controls.Add(qldt);
            tabDanhMuc.PageVisible = true;
            tabMain.SelectedTabPage = tabDanhMuc;
            qldt.Show();
        }

        private void navThungRac_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            uclThungRac dn = new uclThungRac();
            dn.Dock = DockStyle.Fill;
            xtraThungRac.Controls.Add(dn);
            xtraThungRac.PageVisible = true;
            tabMain.SelectedTabPage = xtraThungRac;
            this.Cursor = Cursors.Default;
        }

        private void btnDSKhachTroXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            uclThungRac dn = new uclThungRac();
            dn.Dock = DockStyle.Fill;
            xtraThungRac.Controls.Add(dn);
            xtraThungRac.PageVisible = true;
            tabMain.SelectedTabPage = xtraThungRac;
            this.Cursor = Cursors.Default;
        }

        private void btnThongKePhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            uclBaoCaoPhong pb = new uclBaoCaoPhong();
            pb.Dock = DockStyle.Fill;
            tabBaoCaoPhong.Controls.Add(pb);
            tabBaoCaoPhong.PageVisible = true;
            tabMain.SelectedTabPage = tabBaoCaoPhong;
            this.Cursor = Cursors.Default;
        }

        private void btnThongKeP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            uclBaoCaoPhong pb = new uclBaoCaoPhong();
            pb.Dock = DockStyle.Fill;
            tabBaoCaoPhong.Controls.Add(pb);
            tabBaoCaoPhong.PageVisible = true;
            tabMain.SelectedTabPage = tabBaoCaoPhong;
            this.Cursor = Cursors.Default;
        }

        private void btnThongKeDoanhSo_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btnThongKeDoanhSo1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
             
        }
    }
}