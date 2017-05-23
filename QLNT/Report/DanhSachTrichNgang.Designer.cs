namespace QLNT.Report
{
    partial class DanhSachTrichNgang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.cellSTT = new DevExpress.XtraReports.UI.XRLabel();
            this.cellHoTen = new DevExpress.XtraReports.UI.XRLabel();
            this.cellNgaySinh = new DevExpress.XtraReports.UI.XRLabel();
            this.cellHKTT = new DevExpress.XtraReports.UI.XRLabel();
            this.cellDanToc = new DevExpress.XtraReports.UI.XRLabel();
            this.cellTonGiao = new DevExpress.XtraReports.UI.XRLabel();
            this.cellGhiChu = new DevExpress.XtraReports.UI.XRLabel();
            this.cellKhoa = new DevExpress.XtraReports.UI.XRLabel();
            this.cellPhongCu = new DevExpress.XtraReports.UI.XRLabel();
            this.cellLop = new DevExpress.XtraReports.UI.XRLabel();
            this.tex2 = new DevExpress.XtraReports.UI.FormattingRule();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.text1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.cellPhong = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.cellSTT,
            this.cellHoTen,
            this.cellNgaySinh,
            this.cellHKTT,
            this.cellDanToc,
            this.cellTonGiao,
            this.cellGhiChu,
            this.cellKhoa,
            this.cellPhongCu,
            this.cellLop});
            this.Detail.HeightF = 31.25F;
            this.Detail.KeepTogether = true;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // cellSTT
            // 
            this.cellSTT.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellSTT.CanGrow = false;
            this.cellSTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellSTT.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.cellSTT.Name = "cellSTT";
            this.cellSTT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellSTT.SizeF = new System.Drawing.SizeF(51.73913F, 31.25F);
            this.cellSTT.StylePriority.UseBorders = false;
            this.cellSTT.StylePriority.UseFont = false;
            this.cellSTT.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cellSTT.Summary = xrSummary1;
            this.cellSTT.Text = "STT";
            this.cellSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellSTT.WordWrap = false;
            // 
            // cellHoTen
            // 
            this.cellHoTen.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellHoTen.CanGrow = false;
            this.cellHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellHoTen.LocationFloat = new DevExpress.Utils.PointFloat(51.13648F, 0F);
            this.cellHoTen.Name = "cellHoTen";
            this.cellHoTen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellHoTen.SizeF = new System.Drawing.SizeF(178.9773F, 31.25F);
            this.cellHoTen.StylePriority.UseBorders = false;
            this.cellHoTen.StylePriority.UseFont = false;
            this.cellHoTen.StylePriority.UseTextAlignment = false;
            this.cellHoTen.Text = "Họ và tên";
            this.cellHoTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellHoTen.WordWrap = false;
            // 
            // cellNgaySinh
            // 
            this.cellNgaySinh.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellNgaySinh.CanGrow = false;
            this.cellNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellNgaySinh.LocationFloat = new DevExpress.Utils.PointFloat(230.1137F, 0F);
            this.cellNgaySinh.Name = "cellNgaySinh";
            this.cellNgaySinh.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellNgaySinh.SizeF = new System.Drawing.SizeF(107.9545F, 31.25F);
            this.cellNgaySinh.StylePriority.UseBorders = false;
            this.cellNgaySinh.StylePriority.UseFont = false;
            this.cellNgaySinh.StylePriority.UseTextAlignment = false;
            this.cellNgaySinh.Text = "Ngày sinh";
            this.cellNgaySinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellNgaySinh.WordWrap = false;
            // 
            // cellHKTT
            // 
            this.cellHKTT.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellHKTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellHKTT.LocationFloat = new DevExpress.Utils.PointFloat(338.0682F, 0F);
            this.cellHKTT.Name = "cellHKTT";
            this.cellHKTT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellHKTT.SizeF = new System.Drawing.SizeF(143.8123F, 31.25F);
            this.cellHKTT.StylePriority.UseBorders = false;
            this.cellHKTT.StylePriority.UseFont = false;
            this.cellHKTT.StylePriority.UseTextAlignment = false;
            this.cellHKTT.Text = "HK.Thường trú";
            this.cellHKTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellHKTT.WordWrap = false;
            // 
            // cellDanToc
            // 
            this.cellDanToc.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellDanToc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellDanToc.LocationFloat = new DevExpress.Utils.PointFloat(481.8806F, 0F);
            this.cellDanToc.Name = "cellDanToc";
            this.cellDanToc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellDanToc.SizeF = new System.Drawing.SizeF(77.77863F, 31.25F);
            this.cellDanToc.StylePriority.UseBorders = false;
            this.cellDanToc.StylePriority.UseFont = false;
            this.cellDanToc.StylePriority.UseTextAlignment = false;
            this.cellDanToc.Text = "Dân tộc";
            this.cellDanToc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellDanToc.WordWrap = false;
            // 
            // cellTonGiao
            // 
            this.cellTonGiao.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellTonGiao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellTonGiao.LocationFloat = new DevExpress.Utils.PointFloat(559.6591F, 0F);
            this.cellTonGiao.Name = "cellTonGiao";
            this.cellTonGiao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellTonGiao.SizeF = new System.Drawing.SizeF(103.6932F, 31.25F);
            this.cellTonGiao.StylePriority.UseBorders = false;
            this.cellTonGiao.StylePriority.UseFont = false;
            this.cellTonGiao.StylePriority.UseTextAlignment = false;
            this.cellTonGiao.Text = "Tôn giáo";
            this.cellTonGiao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellTonGiao.WordWrap = false;
            // 
            // cellGhiChu
            // 
            this.cellGhiChu.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellGhiChu.LocationFloat = new DevExpress.Utils.PointFloat(973.0117F, 0F);
            this.cellGhiChu.Name = "cellGhiChu";
            this.cellGhiChu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellGhiChu.SizeF = new System.Drawing.SizeF(95.98822F, 31.25F);
            this.cellGhiChu.StylePriority.UseBorders = false;
            this.cellGhiChu.StylePriority.UseFont = false;
            this.cellGhiChu.StylePriority.UseTextAlignment = false;
            this.cellGhiChu.Text = "Ghi chú";
            this.cellGhiChu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellGhiChu.WordWrap = false;
            // 
            // cellKhoa
            // 
            this.cellKhoa.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellKhoa.LocationFloat = new DevExpress.Utils.PointFloat(779.2268F, 0F);
            this.cellKhoa.Name = "cellKhoa";
            this.cellKhoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellKhoa.SizeF = new System.Drawing.SizeF(96.591F, 31.25F);
            this.cellKhoa.StylePriority.UseBorders = false;
            this.cellKhoa.StylePriority.UseFont = false;
            this.cellKhoa.StylePriority.UseTextAlignment = false;
            this.cellKhoa.Text = "Hệ/Khóa";
            this.cellKhoa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellKhoa.WordWrap = false;
            // 
            // cellPhongCu
            // 
            this.cellPhongCu.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellPhongCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellPhongCu.LocationFloat = new DevExpress.Utils.PointFloat(875.8177F, 0F);
            this.cellPhongCu.Name = "cellPhongCu";
            this.cellPhongCu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellPhongCu.SizeF = new System.Drawing.SizeF(97.19373F, 31.25F);
            this.cellPhongCu.StylePriority.UseBorders = false;
            this.cellPhongCu.StylePriority.UseFont = false;
            this.cellPhongCu.StylePriority.UseTextAlignment = false;
            this.cellPhongCu.Text = "Phòng cũ";
            this.cellPhongCu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellPhongCu.WordWrap = false;
            // 
            // cellLop
            // 
            this.cellLop.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cellLop.LocationFloat = new DevExpress.Utils.PointFloat(663.3524F, 0F);
            this.cellLop.Name = "cellLop";
            this.cellLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellLop.SizeF = new System.Drawing.SizeF(115.8745F, 31.25F);
            this.cellLop.StylePriority.UseBorders = false;
            this.cellLop.StylePriority.UseFont = false;
            this.cellLop.StylePriority.UseTextAlignment = false;
            this.cellLop.Text = "Lớp";
            this.cellLop.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellLop.WordWrap = false;
            // 
            // tex2
            // 
            // 
            // 
            // 
            this.tex2.Formatting.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex2.Name = "tex2";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(9.999985F, 105.5023F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(1049F, 25.91467F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "NĂM 2014 - 2015";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(9.999985F, 78.12505F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(1048.397F, 29.03658F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "DANH SÁCH HỌC SINH-SINH VIÊN NỘI TRÚ PHÒNG         ";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 145.4837F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.HeightF = 45.89161F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(973.0118F, 153.7742F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(95.98822F, 31.25F);
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "Ghi chú";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(875.8181F, 153.7742F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(97.19342F, 31.25F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Phòng cũ";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(779.2269F, 153.7742F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(96.591F, 31.25F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "Hệ/Khóa";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(663.3525F, 153.7742F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(115.8745F, 31.25F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "Lớp";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(559.6591F, 153.7742F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(103.6932F, 31.25F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "Tôn giáo";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(481.8805F, 153.7742F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(77.77863F, 31.25F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "Dân tộc";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(338.0681F, 153.7742F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(143.8123F, 31.25F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "HK.Thường trú";
            this.xrLabel4.WordWrap = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(230.1136F, 153.7742F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(107.9545F, 31.25F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Ngày sinh";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(51.13631F, 153.7742F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(178.9773F, 31.25F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Họ và tên";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 153.7741F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(51.73913F, 31.25002F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "STT";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            // 
            // text1
            // 
            // 
            // 
            // 
            this.text1.Formatting.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Name = "text1";
            // 
            // cellPhong
            // 
            this.cellPhong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhong.LocationFloat = new DevExpress.Utils.PointFloat(812.7292F, 78.12504F);
            this.cellPhong.Name = "cellPhong";
            this.cellPhong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellPhong.SizeF = new System.Drawing.SizeF(160.2823F, 29.03658F);
            this.cellPhong.StylePriority.UseFont = false;
            this.cellPhong.StylePriority.UseTextAlignment = false;
            this.cellPhong.Text = "phong";
            this.cellPhong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel1,
            this.xrLabel11,
            this.xrLabel12,
            this.cellPhong,
            this.xrLabel13,
            this.xrLine1});
            this.GroupHeader1.HeightF = 185.0242F;
            this.GroupHeader1.KeepTogether = true;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(9.999985F, 0F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(383.3388F, 55.31832F);
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "TRƯỜNG CAO ĐẲNG CÔNG THƯƠNG TP.HCM\r\nPHÒNG QUẢN LÝ KÍ TÚC XÁ";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(70.42683F, 53.23499F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(248.9583F, 2.083336F);
            // 
            // DanhSachTrichNgang
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter,
            this.GroupHeader1});
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.tex2,
            this.text1});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(49, 51, 0, 145);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ScriptsSource = "\r\n";
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.FormattingRule tex2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraReports.UI.FormattingRule text1;
        private DevExpress.XtraReports.UI.XRLabel cellSTT;
        private DevExpress.XtraReports.UI.XRLabel cellHoTen;
        private DevExpress.XtraReports.UI.XRLabel cellNgaySinh;
        private DevExpress.XtraReports.UI.XRLabel cellHKTT;
        private DevExpress.XtraReports.UI.XRLabel cellDanToc;
        private DevExpress.XtraReports.UI.XRLabel cellTonGiao;
        private DevExpress.XtraReports.UI.XRLabel cellLop;
        private DevExpress.XtraReports.UI.XRLabel cellKhoa;
        private DevExpress.XtraReports.UI.XRLabel cellPhongCu;
        private DevExpress.XtraReports.UI.XRLabel cellGhiChu;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel cellPhong;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
    }
}
