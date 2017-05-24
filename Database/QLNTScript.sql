USE [QLNT]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vSinhVien'

GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vSinhVien'

GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vSinhVien'

GO
/****** Object:  StoredProcedure [dbo].[NT_TGG_LOG]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_TGG_LOG]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_UpdatePhong]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_UpdatePhong]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_ThongKeTheoGioiTinh]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_ThongKeTheoGioiTinh]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_ThongKeSoNguoiTheoKhu]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_ThongKeSoNguoiTheoKhu]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_THONGKE_KHACHTRO]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_THONGKE_KHACHTRO]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_TAOHOADON]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_TAOHOADON]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_LIST_ROOM_SISO]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_LIST_ROOM_SISO]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_LayDienNuocCu]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_LayDienNuocCu]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_HOADONTIENPHONG]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_HOADONTIENPHONG]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_DemSoNguoi]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_DemSoNguoi]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_DEM_THONGKE_NAM_NU]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_DEM_THONGKE_NAM_NU]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_DELETE_ALL_NHATKY]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_DELETE_ALL_NHATKY]
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_Count_SV_Inroom]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[NT_SP_Count_SV_Inroom]
GO
/****** Object:  StoredProcedure [dbo].[Backup_auto]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP PROCEDURE [dbo].[Backup_auto]
GO
ALTER TABLE [dbo].[GuiEmail] DROP CONSTRAINT [DF__GuiEmail__Gui__345EC57D]
GO
ALTER TABLE [dbo].[GuiEmail] DROP CONSTRAINT [DF__GuiEmail__NoiDun__336AA144]
GO
ALTER TABLE [dbo].[GuiEmail] DROP CONSTRAINT [DF__GuiEmail__TieuDe__32767D0B]
GO
/****** Object:  Table [dbo].[VatTu]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[VatTu]
GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[TrangThai]
GO
/****** Object:  Table [dbo].[ThongTinDongTien]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[ThongTinDongTien]
GO
/****** Object:  Table [dbo].[SysUser]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[SysUser]
GO
/****** Object:  Table [dbo].[SysQuyenSuDung]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[SysQuyenSuDung]
GO
/****** Object:  Table [dbo].[SysQuyenChucNang]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[SysQuyenChucNang]
GO
/****** Object:  Table [dbo].[SysNhomQuyen]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[SysNhomQuyen]
GO
/****** Object:  Table [dbo].[SysChucNang]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[SysChucNang]
GO
/****** Object:  Table [dbo].[QuanLyVatTu]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[QuanLyVatTu]
GO
/****** Object:  Table [dbo].[Options]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[Options]
GO
/****** Object:  Table [dbo].[NhatKy]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[NhatKy]
GO
/****** Object:  Table [dbo].[KyLuat]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[KyLuat]
GO
/****** Object:  Table [dbo].[KhachTro]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[KhachTro]
GO
/****** Object:  Table [dbo].[Khach]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[Khach]
GO
/****** Object:  Table [dbo].[HinhThucKyLuat]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[HinhThucKyLuat]
GO
/****** Object:  Table [dbo].[GuiEmail]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[GuiEmail]
GO
/****** Object:  Table [dbo].[DienNuocTheoSoTien]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[DienNuocTheoSoTien]
GO
/****** Object:  Table [dbo].[ChiPhi]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[ChiPhi]
GO
/****** Object:  Table [dbo].[Backupss]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[Backupss]
GO
/****** Object:  View [dbo].[vSinhVien]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP VIEW [dbo].[vSinhVien]
GO
/****** Object:  Table [dbo].[HoKhauThuongTru]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[HoKhauThuongTru]
GO
/****** Object:  Table [dbo].[DanToc]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[DanToc]
GO
/****** Object:  Table [dbo].[Khu]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[Khu]
GO
/****** Object:  Table [dbo].[TonGiao]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[TonGiao]
GO
/****** Object:  UserDefinedFunction [dbo].[SinhVien_F]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP FUNCTION [dbo].[SinhVien_F]
GO
/****** Object:  View [dbo].[HOADONTIENPHONG]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP VIEW [dbo].[HOADONTIENPHONG]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[HoaDon]
GO
/****** Object:  Table [dbo].[DienNuoc]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[DienNuoc]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[Phong]
GO
/****** Object:  Table [dbo].[Tien]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP TABLE [dbo].[Tien]
GO
/****** Object:  UserDefinedFunction [dbo].[SinhVienF]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP FUNCTION [dbo].[SinhVienF]
GO
/****** Object:  User [phongle]    Script Date: 5/24/2017 10:05:22 PM ******/
DROP USER [phongle]
GO
/****** Object:  User [phongle]    Script Date: 5/24/2017 10:05:22 PM ******/
CREATE USER [phongle] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  UserDefinedFunction [dbo].[SinhVienF]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SinhVienF] (@input VARCHAR(10))
RETURNS VARCHAR(250)
AS BEGIN
    DECLARE @Work VARCHAR(250)

    SET @Work = @Input

    SET @Work = REPLACE(@Work, 'www.', '')
    SET @Work = REPLACE(@Work, '.com', '')
   Return @Work;
END
GO
/****** Object:  Table [dbo].[Tien]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [varchar](50) NULL,
	[MaLoaiTien] [varchar](10) NULL,
	[NgayDong] [datetime] NULL,
	[GhiChu] [ntext] NULL,
	[TongTien] [float] NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
 CONSTRAINT [pkT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](10) NOT NULL,
	[MaKhu] [varchar](10) NULL,
	[TenPhong] [nvarchar](255) NULL,
	[SoNguoi] [int] NULL,
	[GhiChu] [ntext] NULL,
	[HoatDong] [bit] NULL,
	[GiaPhong] [float] NULL,
	[TongNguoi] [int] NULL,
	[TuNgay] [date] NULL,
	[ToiNgay] [date] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DienNuoc]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienNuoc](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[MaPhong] [varchar](10) NULL,
	[SoTienDien] [float] NULL,
	[SoTienNuoc] [float] NULL,
	[SoDienCu] [int] NULL,
	[SoDienMoi] [int] NULL,
	[SoNuocCu] [int] NULL,
	[SoNuocMoi] [int] NULL,
	[SoDienTieuThu] [int] NULL,
	[SoNuocTieuThu] [int] NULL,
	[GiaTienDien] [float] NULL,
	[GiaTienNuoc] [float] NULL,
	[TongTien] [float] NULL,
	[TrangThai] [bit] NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
	[NgayDongTien] [date] NULL,
	[GhiChu] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[MaPhong] [nvarchar](10) NULL,
	[DienNuocId] [bigint] NULL,
	[TienID] [bigint] NULL,
	[TienDienNuoc] [float] NULL,
	[TienPhong] [float] NULL,
	[TongTien] [float] NULL,
	[NgayDong] [date] NULL,
	[NguoiDong] [nvarchar](100) NULL,
	[ThanhToan] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[HOADONTIENPHONG]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HOADONTIENPHONG]
AS (
SELECT p.TenPhong,t.TongTien AS TienPhong,
d.SoDienCu,d.SoDienMoi,d.SoDienTieuThu,d.SoTienDien,d.GiaTienDien,
d.SoNuocCu,d.SoNuocMoi,d.SoNuocTieuThu,d.SoTienNuoc,d.GiaTienNuoc,h.NgayDong, h.NguoiDong,(CONVERT(NVARCHAR(10),d.Thang)++'/'+CONVERT(NVARCHAR(10),d.Nam) ) AS ThangNam
FROM dbo.HoaDon h
LEFT JOIN dbo.Tien t ON t.ID=h.TienID
LEFT JOIN dbo.DienNuoc d ON d.Id=h.DienNuocId
INNER JOIN dbo.Phong p ON p.MaPhong=h.MaPhong
)
GO
/****** Object:  UserDefinedFunction [dbo].[SinhVien_F]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SinhVien_F] (@ma varchar(10))
RETURNS TABLE
AS
RETURN 
(
    SELECT P.MaSV, P.HoTen,p.MaDanToc,pb.TenPhong
    FROM SinhVien AS P 
    JOIN Phong as pb on pb.MaPhong=p.MaPhong     
    WHERE p.MaSV = @ma  
);
GO
/****** Object:  Table [dbo].[TonGiao]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TonGiao](
	[MaTonGiao] [bigint] IDENTITY(1,1) NOT NULL,
	[TenTonGiao] [nvarchar](255) NOT NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pkTG] PRIMARY KEY CLUSTERED 
(
	[MaTonGiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khu]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khu](
	[MaKhu] [varchar](10) NOT NULL,
	[TenKhu] [nvarchar](255) NOT NULL,
	[GhiChu] [ntext] NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [pkKHU] PRIMARY KEY CLUSTERED 
(
	[MaKhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanToc]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanToc](
	[MaDanToc] [bigint] NOT NULL,
	[TenDanToc] [nvarchar](255) NOT NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pkDT] PRIMARY KEY CLUSTERED 
(
	[MaDanToc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoKhauThuongTru]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoKhauThuongTru](
	[MaHoKhau] [bigint] IDENTITY(1,1) NOT NULL,
	[TenHoKhau] [nvarchar](255) NOT NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pkHKTT] PRIMARY KEY CLUSTERED 
(
	[MaHoKhau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  View [dbo].[vSinhVien]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vSinhVien]
AS
SELECT        dbo.SinhVien.MaSV, dbo.SinhVien.HoTen, CONVERT(VARCHAR(50), dbo.SinhVien.NgaySinh, 103) AS NamSinh, dbo.Phong.TenPhong, 
                         dbo.HoKhauThuongTru.TenHoKhau, dbo.DanToc.TenDanToc, dbo.TonGiao.TenTonGiao, dbo.KhoaHoc.TenKhoaHoc, dbo.Lop.TenLop, dbo.SinhVien.MaPhongCu, 
                         dbo.SinhVien.GhiChu, dbo.SinhVien.HoatDong
FROM            dbo.DanToc INNER JOIN
                         dbo.SinhVien ON dbo.DanToc.MaDanToc = dbo.SinhVien.MaDanToc INNER JOIN
                         dbo.TonGiao ON dbo.SinhVien.MaTonGiao = dbo.TonGiao.MaTonGiao INNER JOIN
                         dbo.Phong INNER JOIN
                         dbo.Khu ON dbo.Phong.MaKhu = dbo.Khu.MaKhu ON dbo.SinhVien.MaPhong = dbo.Phong.MaPhong INNER JOIN
                         dbo.HoKhauThuongTru ON dbo.SinhVien.MaHoKhau = dbo.HoKhauThuongTru.MaHoKhau INNER JOIN
                         dbo.KhoaHoc ON dbo.SinhVien.MaKhoaHoc = dbo.KhoaHoc.MaKhoaHoc INNER JOIN
                         dbo.Lop ON dbo.SinhVien.MaLop = dbo.Lop.MaLop

GO
/****** Object:  Table [dbo].[Backupss]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Backupss](
	[Id] [int] NOT NULL,
	[Ngay] [nvarchar](50) NULL,
	[TrangThai] [bit] NULL,
	[Onn] [bit] NULL,
 CONSTRAINT [PK_Backupss] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiPhi]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiPhi](
	[MaChiPhi] [varchar](50) NOT NULL,
	[TenChiPhi] [nvarchar](100) NULL,
	[SoTien] [float] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DienNuocTheoSoTien]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienNuocTheoSoTien](
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
	[TienDien] [float] NOT NULL,
	[TienNuoc] [float] NOT NULL,
	[TongTien] [float] NOT NULL,
	[DaThu] [bit] NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GuiEmail]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuiEmail](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MailNhan] [nvarchar](50) NOT NULL,
	[MailGui] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](200) NOT NULL,
	[TieuDe] [nvarchar](200) NULL,
	[NoiDung] [ntext] NULL,
	[FileBackup] [ntext] NULL,
	[SMTP] [ntext] NULL,
	[Port] [int] NULL,
	[Gui] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HinhThucKyLuat]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThucKyLuat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaHinhThucKyLuat] [varchar](10) NOT NULL,
	[TenHinhThucKyLuat] [nvarchar](255) NOT NULL,
	[GhiChu] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khach]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach](
	[MaKhach] [varchar](50) NOT NULL,
	[HoLot] [nvarchar](255) NOT NULL,
	[Ten] [nvarchar](255) NOT NULL,
	[Anh] [image] NULL,
	[NoiSinh] [nvarchar](255) NULL,
	[NgaySinh] [date] NULL,
	[CMND] [varchar](50) NOT NULL,
	[NoiCap] [nvarchar](255) NULL,
	[NgayCap] [date] NULL,
	[GioVao] [datetime] NULL,
	[NgayVao] [date] NULL,
	[GioRa] [datetime] NULL,
	[NgayRa] [date] NULL,
	[MaKhachTro] [varchar](50) NULL,
	[MaPhong] [varchar](10) NULL,
	[GhiChu] [ntext] NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [PK_Khach_1] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachTro]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachTro](
	[MaKhachTro] [varchar](50) NOT NULL,
	[HoLot] [nvarchar](255) NOT NULL,
	[Ten] [nvarchar](255) NULL,
	[Anh] [image] NULL,
	[NgaySinh] [date] NULL,
	[MaPhong] [varchar](10) NULL,
	[CMND] [varchar](50) NULL,
	[NoiCap] [nvarchar](200) NULL,
	[NgayCap] [date] NULL,
	[ThuongTru] [nvarchar](300) NULL,
	[TamTru] [nvarchar](300) NULL,
	[SDTLienHe] [varchar](20) NULL,
	[SDT] [varchar](20) NULL,
	[MaDanToc] [bigint] NULL,
	[MaTonGiao] [bigint] NULL,
	[MaPhongCu] [varchar](10) NULL,
	[NgayVao] [date] NULL,
	[NgayRa] [date] NULL,
	[HoatDong] [bit] NULL,
	[MaTrangThai] [bigint] NULL,
	[TruongPhong] [bit] NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[GhiChu] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KyLuat]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyLuat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [varchar](10) NULL,
	[MaHinhThucKyLuat] [varchar](10) NULL,
	[NgayKyLuat] [datetime] NULL,
	[GhiChu] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhatKy]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhatKy](
	[STT] [bigint] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](15) NOT NULL,
	[Ngay] [nvarchar](20) NOT NULL,
	[TacVu] [nvarchar](40) NOT NULL,
	[ChiTiet] [ntext] NULL,
	[TenMayTinh] [ntext] NULL,
	[MacAddress] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Options]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Options](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoTenChuTro] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[CMND] [nvarchar](20) NULL,
	[NgayCap] [date] NULL,
	[NoiCap] [nvarchar](100) NULL,
	[ThuongTru] [nvarchar](255) NULL,
	[GiaTienPhong] [float] NULL,
	[GiaTienDien] [float] NULL,
	[GiaTienNuoc] [float] NULL,
	[TenFileBackup] [text] NULL,
	[LuufileBackup] [text] NULL,
	[LuufileRestore] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuanLyVatTu]    Script Date: 5/24/2017 10:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyVatTu](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
	[TenVatTu] [nvarchar](255) NOT NULL,
	[SoLuong] [int] NULL,
	[NgaySuaChua] [date] NULL,
	[SuaChua] [bit] NULL,
	[ThayThe] [bit] NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_QuanLyVatTu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SysChucNang]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysChucNang](
	[MaChucNang] [varchar](10) NOT NULL,
	[TenChucNang] [nvarchar](255) NOT NULL,
	[MoTa] [ntext] NULL,
	[ChucNangGoc] [nvarchar](255) NULL,
	[CapCha] [varchar](20) NULL,
	[Cap] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SysNhomQuyen]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysNhomQuyen](
	[MaNhom] [varchar](10) NOT NULL,
	[TenNhom] [nvarchar](255) NOT NULL,
	[DienGiai] [ntext] NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [pkNQ] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SysQuyenChucNang]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysQuyenChucNang](
	[MaNhomQuyen] [varchar](10) NOT NULL,
	[MaChucNang] [varchar](10) NOT NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [pkQCN] PRIMARY KEY CLUSTERED 
(
	[MaNhomQuyen] ASC,
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SysQuyenSuDung]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysQuyenSuDung](
	[MaNhom] [varchar](10) NOT NULL,
	[MaChucNang] [varchar](10) NOT NULL,
	[MaThaoTac] [tinyint] NULL,
	[TatCa] [bit] NULL,
	[Them] [bit] NULL,
	[Xoa] [bit] NULL,
	[Sua] [bit] NULL,
	[TruyCap] [bit] NULL,
	[InAn] [bit] NULL,
	[XuatDuLieu] [bit] NULL,
	[NhapDuLieu] [bit] NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [pkQSD] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SysUser]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUser](
	[ID] [varchar](20) NOT NULL,
	[TaiKhoan] [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[MatKhau] [varchar](255) NULL,
	[MaNhom] [varchar](10) NULL,
	[Email] [varchar](255) NULL,
	[DienGiai] [ntext] NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [pkSND] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinDongTien]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinDongTien](
	[MaLoaiTien] [varchar](10) NOT NULL,
	[TenLoaiTien] [nvarchar](244) NULL,
	[SoTienDong] [float] NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pkTTDT] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[MaTrangThai] [bigint] IDENTITY(0,1) NOT NULL,
	[TenTrangThai] [nvarchar](50) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pkTT] PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VatTu]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatTu](
	[MaVatTu] [bigint] IDENTITY(1,1) NOT NULL,
	[TenVatTu] [nvarchar](255) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pkVatTu] PRIMARY KEY CLUSTERED 
(
	[MaVatTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Backupss] ([Id], [Ngay], [TrangThai], [Onn]) VALUES (0, N'Sunday', 0, 0)
INSERT [dbo].[ChiPhi] ([MaChiPhi], [TenChiPhi], [SoTien], [GhiChu]) VALUES (N'CP', N'TIỀN BẢO VỆ', 100000, NULL)
INSERT [dbo].[ChiPhi] ([MaChiPhi], [TenChiPhi], [SoTien], [GhiChu]) VALUES (N'CP01', N'Tiền Mạng', 100000, N'tiền mạng')
INSERT [dbo].[ChiPhi] ([MaChiPhi], [TenChiPhi], [SoTien], [GhiChu]) VALUES (N'CP02', N'tiền rác', 20000, N'TIỀN RÁC')
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (1, N'Kinh', N'')
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (3, N'Thái', N'kl')
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (4, N'Mường ', N'-')
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (5, N'Khmer', N'=')
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (6, N'Hoa ', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (7, N'Nùng  ', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (8, N'Mông1', N'')
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (9, N'Dao', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (10, N'Gia Rai', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (11, N'Ê  Đê', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (12, N'Ba Na', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (13, N'Sán Chay ', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (14, N'Chăm ', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (15, N'Cơ Ho', N'--')
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (16, N'Xơ Đăng', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (17, N'Sán Dìu', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (18, N'Hrê', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (19, N'RaGlay', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (20, N'Mnông', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (21, N'Thổ (4)', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (22, N'Xtiêng', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (23, N'Khơ mú', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (24, N'Bru Vân Kiều', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (25, N'Cơ Tu', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (26, N'Giáy', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (27, N'Tà Ôi', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (28, N'Mạ', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (29, N'Giẻ-Triêng', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (30, N'Co', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (31, N'Chơ Ro', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (32, N'Xinh Mun', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (33, N'Hà Nhì', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (34, N'Chu Ru', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (35, N'Lào', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (36, N'La Chí', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (37, N'Kháng', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (38, N'Phù Lá', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (39, N'La Hủ', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (40, N'La Ha', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (41, N'Pà Thẻn', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (42, N'Lự', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (43, N'Ngái', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (44, N'Chứt', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (45, N'Lô Lô', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (46, N'Mảng', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (47, N'Cơ Lao', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (48, N'Bố Y', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (49, N'Cống', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (50, N'Si Lam', N'')
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (51, N'Pu Péo', NULL)
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (52, N'Rơ Măm', N' c')
INSERT [dbo].[DanToc] ([MaDanToc], [TenDanToc], [GhiChu]) VALUES (53, N'Brâu', NULL)
SET IDENTITY_INSERT [dbo].[DienNuoc] ON 

INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10032, N'Phong001', 0, 0, 10, 220, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10033, N'Phong0011', 0, 0, 10, 220, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10034, N'Phong00121', 0, 0, 10, 20, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10035, N'Phong1001', 0, 0, 1, 20, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10036, N'Phong909', 0, 0, 10, 210, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10037, N'PK10_Khu1', 0, 0, 111, 222, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10038, N'PK3_Khu1', 0, 0, 111, 210, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10039, N'PK4_Khu1', 0, 0, 10, 22, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10040, N'PK5_Khu1', 0, 0, 10, 110, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10041, N'PK6_Khu1', 0, 0, 10, 210, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10042, N'PK8_Khu1', 0, 0, 10, 22, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10043, N'PK9_Khu1', 0, 0, 1, 20, 0, 0, 0, 0, 3000, 15000, 0, 0, 1, 2012, CAST(N'2015-06-06' AS Date), N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10044, N'Phong001', 330000, 3120000, 220, 330, 12, 220, 110, 208, 3000, 15000, 3450000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10045, N'Phong0011', 330000, 1530000, 220, 330, 20, 122, 110, 102, 3000, 15000, 1860000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10046, N'Phong00121', 930000, 4620000, 20, 330, 12, 320, 310, 308, 3000, 15000, 5550000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10047, N'Phong1001', 930000, 1500000, 20, 330, 120, 220, 310, 100, 3000, 15000, 2430000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10048, N'Phong909', 360000, 270000, 210, 330, 12, 30, 120, 18, 3000, 15000, 630000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10049, N'PK10_Khu1', 303000, 4620000, 222, 323, 22, 330, 101, 308, 3000, 15000, 4923000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10050, N'PK3_Khu1', 300000, 1650000, 210, 310, 10, 120, 100, 110, 3000, 15000, 1950000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10051, N'PK4_Khu1', 24000, 1500000, 22, 30, 10, 110, 8, 100, 3000, 15000, 1524000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10052, N'PK5_Khu1', 303000, 3000000, 110, 211, 30, 230, 101, 200, 3000, 15000, 3303000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10053, N'PK6_Khu1', 6000, 2850000, 210, 212, 20, 210, 2, 190, 3000, 15000, 2856000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10054, N'PK8_Khu1', 924000, 2700000, 22, 330, 40, 220, 308, 180, 3000, 15000, 3624000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10055, N'PK9_Khu1', 60000, 300000, 20, 40, 10, 30, 20, 20, 3000, 15000, 360000, 1, 2, 2012, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10081, N'P01', 30000, 40000000, 12, 22, 1, 21, 10, 20, 3000, 2000000, 40030000, 0, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10082, N'P02', 570000, 178000000, 22, 212, 22, 111, 190, 89, 3000, 2000000, 178570000, 0, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10083, N'P03', 60000, 86000000, 2, 22, 0, 43, 20, 43, 3000, 2000000, 86060000, 0, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10084, N'P04', 93000, 18000000, 12, 43, 12, 21, 31, 9, 3000, 2000000, 18093000, 0, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10085, N'P05', 93000, 18000000, 12, 43, 12, 21, 31, 9, 3000, 2000000, 18093000, 0, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10086, N'P06', 93000, 42000000, 12, 43, 0, 21, 31, 21, 3000, 2000000, 42093000, 0, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10087, N'P07', 93000, 18000000, 12, 43, 12, 21, 31, 9, 3000, 2000000, 18093000, 1, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10088, N'P08', 93000, 18000000, 12, 43, 12, 21, 31, 9, 3000, 2000000, 18093000, 1, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10089, N'P09', 93000, 18000000, 12, 43, 12, 21, 31, 9, 3000, 2000000, 18093000, 1, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10090, N'P10', 93000, 18000000, 12, 43, 12, 21, 31, 9, 3000, 2000000, 18093000, 0, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10091, N'P11', 30000, 40000000, 12, 22, 2, 22, 10, 20, 3000, 2000000, 40030000, 0, 5, 2015, NULL, N' ')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10092, N'P01', 294000, 15000, 22, 120, 21, 22, 98, 1, 3000, 15000, 309000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10093, N'P02', 300000, 1515000, 212, 312, 111, 212, 100, 101, 3000, 15000, 1815000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10094, N'P03', 294000, 1305000, 22, 120, 43, 130, 98, 87, 3000, 15000, 1599000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10095, N'P04', 231000, 285000, 43, 120, 21, 40, 77, 19, 3000, 15000, 516000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10096, N'P05', 240000, 285000, 43, 123, 21, 40, 80, 19, 3000, 15000, 525000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10097, N'P06', 501000, 285000, 43, 210, 21, 40, 167, 19, 3000, 15000, 786000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10098, N'P07', 501000, 285000, 43, 210, 21, 40, 167, 19, 3000, 15000, 786000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10099, N'P08', 501000, 285000, 43, 210, 21, 40, 167, 19, 3000, 15000, 786000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10100, N'P09', 501000, 285000, 43, 210, 21, 40, 167, 19, 3000, 15000, 786000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10101, N'P10', 231000, 285000, 43, 120, 21, 40, 77, 19, 3000, 15000, 516000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10102, N'P05', 60000, 0, 0, 20, 0, 0, 20, 0, 3000, 15000, 60000, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10103, N'P08', 0, 0, 0, 0, 0, 0, 0, 0, 3000, 15000, 0, 0, 6, 2015, NULL, N'')
INSERT [dbo].[DienNuoc] ([Id], [MaPhong], [SoTienDien], [SoTienNuoc], [SoDienCu], [SoDienMoi], [SoNuocCu], [SoNuocMoi], [SoDienTieuThu], [SoNuocTieuThu], [GiaTienDien], [GiaTienNuoc], [TongTien], [TrangThai], [Thang], [Nam], [NgayDongTien], [GhiChu]) VALUES (10104, N'P101', 3000, 15000, 0, 1, 1, 2, 1, 1, 3000, 15000, 18000, 1, 6, 2015, NULL, N'')
SET IDENTITY_INSERT [dbo].[DienNuoc] OFF
SET IDENTITY_INSERT [dbo].[DienNuocTheoSoTien] ON 

INSERT [dbo].[DienNuocTheoSoTien] ([Thang], [Nam], [MaPhong], [TienDien], [TienNuoc], [TongTien], [DaThu], [Id]) VALUES (5, 2015, N'05N', 99, 96, 195, 1, 8)
INSERT [dbo].[DienNuocTheoSoTien] ([Thang], [Nam], [MaPhong], [TienDien], [TienNuoc], [TongTien], [DaThu], [Id]) VALUES (6, 2014, N'05N', 98, 52, 150, NULL, 9)
INSERT [dbo].[DienNuocTheoSoTien] ([Thang], [Nam], [MaPhong], [TienDien], [TienNuoc], [TongTien], [DaThu], [Id]) VALUES (5, 2013, N'04N', 0, 0, 0, NULL, 10)
SET IDENTITY_INSERT [dbo].[DienNuocTheoSoTien] OFF
SET IDENTITY_INSERT [dbo].[HinhThucKyLuat] ON 

INSERT [dbo].[HinhThucKyLuat] ([id], [MaHinhThucKyLuat], [TenHinhThucKyLuat], [GhiChu]) VALUES (2, N'01', N'Phạt', N'')
INSERT [dbo].[HinhThucKyLuat] ([id], [MaHinhThucKyLuat], [TenHinhThucKyLuat], [GhiChu]) VALUES (3, N'02', N'Buộc ra khỏi phòng trọ', N'--')
INSERT [dbo].[HinhThucKyLuat] ([id], [MaHinhThucKyLuat], [TenHinhThucKyLuat], [GhiChu]) VALUES (4, N'03', N'Cảnh cáo', N'')
INSERT [dbo].[HinhThucKyLuat] ([id], [MaHinhThucKyLuat], [TenHinhThucKyLuat], [GhiChu]) VALUES (5, N'04', N'Khiển trách', N'')
INSERT [dbo].[HinhThucKyLuat] ([id], [MaHinhThucKyLuat], [TenHinhThucKyLuat], [GhiChu]) VALUES (7, N'05', N'Nộp phạt', N'')
SET IDENTITY_INSERT [dbo].[HinhThucKyLuat] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([Id], [MaPhong], [DienNuocId], [TienID], [TienDienNuoc], [TienPhong], [TongTien], [NgayDong], [NguoiDong], [ThanhToan]) VALUES (40022, N'P01', NULL, 2025, 0, 230000, 230000, CAST(N'2015-06-09' AS Date), N'', 0)
INSERT [dbo].[HoaDon] ([Id], [MaPhong], [DienNuocId], [TienID], [TienDienNuoc], [TienPhong], [TongTien], [NgayDong], [NguoiDong], [ThanhToan]) VALUES (40023, N'P02', NULL, 2026, 0, 220000, 220000, CAST(N'2015-06-09' AS Date), N'', 0)
INSERT [dbo].[HoaDon] ([Id], [MaPhong], [DienNuocId], [TienID], [TienDienNuoc], [TienPhong], [TongTien], [NgayDong], [NguoiDong], [ThanhToan]) VALUES (40024, N'P03', NULL, 2027, 0, 1920000, 1920000, CAST(N'2015-06-09' AS Date), N'', 0)
INSERT [dbo].[HoaDon] ([Id], [MaPhong], [DienNuocId], [TienID], [TienDienNuoc], [TienPhong], [TongTien], [NgayDong], [NguoiDong], [ThanhToan]) VALUES (40025, N'P04', NULL, 2028, 0, 1900000, 1900000, CAST(N'2015-06-09' AS Date), N'', 0)
INSERT [dbo].[HoaDon] ([Id], [MaPhong], [DienNuocId], [TienID], [TienDienNuoc], [TienPhong], [TongTien], [NgayDong], [NguoiDong], [ThanhToan]) VALUES (40026, N'P05', NULL, 2029, 0, 1810000, 1810000, CAST(N'2015-06-09' AS Date), N'', 0)
INSERT [dbo].[HoaDon] ([Id], [MaPhong], [DienNuocId], [TienID], [TienDienNuoc], [TienPhong], [TongTien], [NgayDong], [NguoiDong], [ThanhToan]) VALUES (40027, N'P09', 10082, 2030, 36000, 1900000, 180470000, CAST(N'2015-06-09' AS Date), N'', 0)
INSERT [dbo].[HoaDon] ([Id], [MaPhong], [DienNuocId], [TienID], [TienDienNuoc], [TienPhong], [TongTien], [NgayDong], [NguoiDong], [ThanhToan]) VALUES (40028, N'P09', 10091, 2030, 111168000, 1900000, 41930000, CAST(N'2015-06-09' AS Date), N'', 0)
INSERT [dbo].[HoaDon] ([Id], [MaPhong], [DienNuocId], [TienID], [TienDienNuoc], [TienPhong], [TongTien], [NgayDong], [NguoiDong], [ThanhToan]) VALUES (40029, N'P09', 10092, 2030, 420000, 1900000, 2209000, CAST(N'2015-06-09' AS Date), N'', 0)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[HoKhauThuongTru] ON 

INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (2, N'BR-VT', N'  ')
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (3, N'Bạc Liêu', N'')
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (4, N'Bắc Giang', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (5, N'Bắc Kạn', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (6, N'Bắc Ninh', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (7, N'Bến Tre', N'')
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (8, N'Bình Dương', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (9, N'Bình Định', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (10, N'Bình Phước', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (11, N'Bình Thuận', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (12, N'Cà Mau', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (13, N'Cao Bằng', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (16, N'Đăklăk
', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (17, N'Đắk Nông', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (18, N'Điện Biên', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (19, N'Đồng Nai', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (20, N'Đồng Tháp', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (21, N'Gia Lai', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (22, N'Hà Giang', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (23, N'Hà Nam', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (24, N'Hà Nội', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (25, N'Hà Tĩnh', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (26, N'Hải Dương', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (27, N'Hải Phòng', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (28, N'Hậu Giang', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (29, N'Hòa Bình', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (30, N'Hưng Yên', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (31, N'Kiên Giang', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (32, N'Kon Tum', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (33, N'Khánh Hòa', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (34, N'Lai Châu', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (35, N'Lạng Sơn', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (36, N'Lào Cai', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (37, N'Lâm Đồng', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (38, N'Long An', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (39, N'Nam Định', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (40, N'Ninh Bình', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (41, N'Ninh Thuận', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (42, N'Nghệ An', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (43, N'Phú Thọ', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (44, N'Phú Yên', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (45, N'Quảng Bình', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (46, N'Quảng Nam', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (47, N'Quảng Ninh', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (48, N'Quảng Ngãi', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (49, N'Quảng Trị', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (50, N'Sóc Trăng', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (51, N'Sơn La', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (52, N'Tây Ninh', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (53, N'Tiền Giang', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (54, N'TP HCM', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (55, N'Tuyên Quang', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (56, N'Thái Bình', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (57, N'Thái Nguyên', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (58, N'Thanh Hóa', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (59, N'Thừa Thiên Huế', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (60, N'Trà Vinh', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (61, N'Vĩnh Long', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (62, N'Vĩnh Phúc', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (63, N'Yên Bái', NULL)
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (10065, N'Phú Khánh', N'')
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (10066, N'Cần thơ', N'')
INSERT [dbo].[HoKhauThuongTru] ([MaHoKhau], [TenHoKhau], [GhiChu]) VALUES (10067, N'An Giang', N'')
SET IDENTITY_INSERT [dbo].[HoKhauThuongTru] OFF
INSERT [dbo].[Khach] ([MaKhach], [HoLot], [Ten], [Anh], [NoiSinh], [NgaySinh], [CMND], [NoiCap], [NgayCap], [GioVao], [NgayVao], [GioRa], [NgayRa], [MaKhachTro], [MaPhong], [GhiChu], [HoatDong]) VALUES (N'1', N'Phong', N'Phạm', 0x, N'1', CAST(N'2015-06-09' AS Date), N'111112224', N'11111', CAST(N'2015-06-09' AS Date), CAST(N'2015-06-10T17:45:36.080' AS DateTime), CAST(N'2015-06-09' AS Date), CAST(N'2015-06-10T17:45:36.080' AS DateTime), CAST(N'2015-06-10' AS Date), N'KT07', N'P07', N'', 1)
INSERT [dbo].[Khach] ([MaKhach], [HoLot], [Ten], [Anh], [NoiSinh], [NgaySinh], [CMND], [NoiCap], [NgayCap], [GioVao], [NgayVao], [GioRa], [NgayRa], [MaKhachTro], [MaPhong], [GhiChu], [HoatDong]) VALUES (N'453543', N'Nguyễn Văn', N'Hà', 0x, N'', CAST(N'2015-06-12' AS Date), N'45354343444', N'', CAST(N'2015-06-12' AS Date), CAST(N'2015-06-13T08:33:11.670' AS DateTime), CAST(N'2015-06-12' AS Date), CAST(N'2015-06-13T08:33:11.670' AS DateTime), CAST(N'2015-06-13' AS Date), N'KT01', N'P01', N'', 1)
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT01', N'Nguyễn Văn ', N'A01', NULL, CAST(N'1901-06-09' AS Date), N'P01', N'12838201', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh01', N'Hà Nội', N'0999999901', N'0999999901', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT02', N'Nguyễn Văn ', N'A02', NULL, CAST(N'1902-06-09' AS Date), N'P02', N'12838202', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh02', N'Hà Nội', N'0999999902', N'0999999902', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT03', N'Nguyễn Văn ', N'A03', NULL, CAST(N'1903-06-09' AS Date), N'P03', N'12838203', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh03', N'Hà Nội', N'0999999903', N'0999999903', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT04', N'Nguyễn Văn ', N'A04', NULL, CAST(N'1904-06-09' AS Date), N'P04', N'12838204', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh04', N'Hà Nội', N'0999999904', N'0999999904', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT05', N'Nguyễn Văn ', N'A05', NULL, CAST(N'1905-06-09' AS Date), N'P05', N'12838205', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh05', N'Hà Nội', N'0999999905', N'0999999905', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT06', N'Nguyễn Văn ', N'A06', NULL, CAST(N'1906-06-09' AS Date), N'P06', N'12838206', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh06', N'Hà Nội', N'0999999906', N'0999999906', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT07', N'Nguyễn Văn ', N'A07', NULL, CAST(N'1907-06-09' AS Date), N'P07', N'12838207', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh07', N'Hà Nội', N'0999999907', N'0999999907', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT08', N'Nguyễn Văn ', N'A08', NULL, CAST(N'1908-06-09' AS Date), N'P08', N'12838208', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh08', N'Hà Nội', N'0999999908', N'0999999908', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT102', N'Nguyễn Văn ', N'A102', 0x, CAST(N'1902-06-09' AS Date), N'P02', N'128382102', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh02', N'Hà Nội', N'09999999102', N'0999999902', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT103', N'Nguyễn Văn ', N'A103', NULL, CAST(N'1902-06-09' AS Date), N'P02', N'128382103', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh02', N'Hà Nội', N'09999999103', N'0999999902', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT104', N'Nguyễn Văn ', N'A104', NULL, CAST(N'1902-06-09' AS Date), N'P02', N'128382104', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh02', N'Hà Nội', N'09999999104', N'0999999902', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT105', N'Nguyễn Văn ', N'A105', NULL, CAST(N'1902-06-09' AS Date), N'P02', N'128382105', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh02', N'Hà Nội', N'09999999105', N'0999999902', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT107', N'Nguyễn Văn ', N'A107', NULL, CAST(N'1902-06-09' AS Date), N'P03', N'128382107', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh02', N'Hà Nội', N'09999999107', N'0999999902', 5, 0, N'P02', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT108', N'Nguyễn Văn ', N'A108', NULL, CAST(N'1903-06-09' AS Date), N'P03', N'128382108', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh03', N'Hà Nội', N'09999999108', N'0999999903', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT109', N'Nguyễn Văn ', N'A109', NULL, CAST(N'1903-06-09' AS Date), N'P03', N'128382109', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh03', N'Hà Nội', N'09999999109', N'0999999903', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT11', N'Nguyễn Văn ', N'A11', NULL, CAST(N'1911-06-09' AS Date), N'P11', N'12838211', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh11', N'Hà Nội', N'0999999911', N'0999999911', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT110', N'Nguyễn Văn ', N'A110', NULL, CAST(N'1903-06-09' AS Date), N'P03', N'128382110', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh03', N'Hà Nội', N'09999999110', N'0999999903', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 0, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT117', N'Nguyễn Văn ', N'A117', NULL, CAST(N'1904-06-09' AS Date), N'P04', N'128382117', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh04', N'Hà Nội', N'09999999117', N'0999999904', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT118', N'Nguyễn Văn ', N'A118', NULL, CAST(N'1904-06-09' AS Date), N'P04', N'128382118', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh04', N'Hà Nội', N'09999999118', N'0999999904', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT119', N'Nguyễn Văn ', N'A119', NULL, CAST(N'1904-06-09' AS Date), N'P04', N'128382119', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh04', N'Hà Nội', N'09999999119', N'0999999904', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT12', N'Nguyễn Văn ', N'A12', NULL, CAST(N'1912-06-09' AS Date), N'P12', N'12838212', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh12', N'Hà Nội', N'0999999912', N'0999999912', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT120', N'Nguyễn Văn ', N'A120', NULL, CAST(N'1904-06-09' AS Date), N'P04', N'128382120', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh04', N'Hà Nội', N'09999999120', N'0999999904', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT126', N'Nguyễn Văn ', N'A126', NULL, CAST(N'1905-06-09' AS Date), N'P05', N'128382126', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh05', N'Hà Nội', N'09999999126', N'0999999905', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT127', N'Nguyễn Văn ', N'A127', NULL, CAST(N'1905-06-09' AS Date), N'P05', N'128382127', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh05', N'Hà Nội', N'09999999127', N'0999999905', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT128', N'Nguyễn Văn ', N'A128', NULL, CAST(N'1905-06-09' AS Date), N'P05', N'128382128', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh05', N'Hà Nội', N'09999999128', N'0999999905', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT129', N'Nguyễn Văn ', N'A129', NULL, CAST(N'1905-06-09' AS Date), N'P05', N'128382129', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh05', N'Hà Nội', N'09999999129', N'0999999905', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT13', N'Nguyễn Văn ', N'A13', NULL, CAST(N'1913-06-09' AS Date), N'P13', N'12838213', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh13', N'Hà Nội', N'0999999913', N'0999999913', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT135', N'Nguyễn Văn ', N'A135', NULL, CAST(N'1906-06-09' AS Date), N'P06', N'128382135', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh06', N'Hà Nội', N'09999999135', N'0999999906', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT136', N'Nguyễn Văn ', N'A136', NULL, CAST(N'1906-06-09' AS Date), N'P06', N'128382136', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh06', N'Hà Nội', N'09999999136', N'0999999906', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT137', N'Nguyễn Văn ', N'A137', NULL, CAST(N'1906-06-09' AS Date), N'P06', N'128382137', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh06', N'Hà Nội', N'09999999137', N'0999999906', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT138', N'Nguyễn Văn ', N'A138', NULL, CAST(N'1906-06-09' AS Date), N'P06', N'128382138', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh06', N'Hà Nội', N'09999999138', N'0999999906', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT14', N'Nguyễn Văn ', N'A14', NULL, CAST(N'1914-06-09' AS Date), N'P14', N'12838214', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh14', N'Hà Nội', N'0999999914', N'0999999914', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT144', N'Nguyễn Văn ', N'A144', NULL, CAST(N'1907-06-09' AS Date), N'P07', N'128382144', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh07', N'Hà Nội', N'09999999144', N'0999999907', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT145', N'Nguyễn Văn ', N'A145', NULL, CAST(N'1907-06-09' AS Date), N'P07', N'128382145', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh07', N'Hà Nội', N'09999999145', N'0999999907', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT146', N'Nguyễn Văn ', N'A146', NULL, CAST(N'1907-06-09' AS Date), N'P07', N'128382146', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh07', N'Hà Nội', N'09999999146', N'0999999907', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT147', N'Nguyễn Văn ', N'A147', NULL, CAST(N'1907-06-09' AS Date), N'P07', N'128382147', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh07', N'Hà Nội', N'09999999147', N'0999999907', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT15', N'Nguyễn Văn ', N'A15', NULL, CAST(N'1915-06-09' AS Date), N'P15', N'12838215', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh15', N'Hà Nội', N'0999999915', N'0999999915', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT153', N'Nguyễn Văn ', N'A153', NULL, CAST(N'1908-06-09' AS Date), N'P08', N'128382153', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh08', N'Hà Nội', N'09999999153', N'0999999908', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT154', N'Nguyễn Văn ', N'A154', NULL, CAST(N'1908-06-09' AS Date), N'P08', N'128382154', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh08', N'Hà Nội', N'09999999154', N'0999999908', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT155', N'Nguyễn Văn ', N'A155', NULL, CAST(N'1908-06-09' AS Date), N'P08', N'128382155', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh08', N'Hà Nội', N'09999999155', N'0999999908', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT156', N'Nguyễn Văn ', N'A156', NULL, CAST(N'1908-06-09' AS Date), N'P08', N'128382156', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh08', N'Hà Nội', N'09999999156', N'0999999908', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT16', N'Nguyễn Văn ', N'A16', NULL, CAST(N'1916-06-09' AS Date), N'P16', N'12838216', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh16', N'Hà Nội', N'0999999916', N'0999999916', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT162', N'Nguyễn Văn ', N'A162', NULL, CAST(N'1909-06-09' AS Date), N'P09', N'128382162', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh09', N'Hà Nội', N'09999999162', N'0999999909', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT163', N'Nguyễn Văn ', N'A163', NULL, CAST(N'1909-06-09' AS Date), N'P09', N'128382163', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh09', N'Hà Nội', N'09999999163', N'0999999909', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT164', N'Nguyễn Văn ', N'A164', NULL, CAST(N'1909-06-09' AS Date), N'P09', N'128382164', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh09', N'Hà Nội', N'09999999164', N'0999999909', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT165', N'Nguyễn Văn ', N'A165', NULL, CAST(N'1909-06-09' AS Date), N'P09', N'128382165', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh09', N'Hà Nội', N'09999999165', N'0999999909', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT166', N'Nguyễn Văn ', N'A166', NULL, CAST(N'1909-06-09' AS Date), N'P09', N'128382166', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh09', N'Hà Nội', N'09999999166', N'0999999909', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT17', N'Nguyễn Văn ', N'A17', NULL, CAST(N'1917-06-09' AS Date), N'P17', N'12838217', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh17', N'Hà Nội', N'0999999917', N'0999999917', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT171', N'Nguyễn Văn ', N'A171', NULL, CAST(N'1910-06-09' AS Date), N'P10', N'128382171', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh10', N'Hà Nội', N'09999999171', N'0999999910', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT172', N'Nguyễn Văn ', N'A172', NULL, CAST(N'1910-06-09' AS Date), N'P10', N'128382172', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh10', N'Hà Nội', N'09999999172', N'0999999910', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT173', N'Nguyễn Văn ', N'A173', NULL, CAST(N'1910-06-09' AS Date), N'P10', N'128382173', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh10', N'Hà Nội', N'09999999173', N'0999999910', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT174', N'Nguyễn Văn ', N'A174', NULL, CAST(N'1910-06-09' AS Date), N'P10', N'128382174', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh10', N'Hà Nội', N'09999999174', N'0999999910', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT175', N'Nguyễn Văn ', N'A175', NULL, CAST(N'1910-06-09' AS Date), N'P10', N'128382175', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh10', N'Hà Nội', N'09999999175', N'0999999910', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT18', N'Nguyễn Văn ', N'A18', NULL, CAST(N'1918-06-09' AS Date), N'P18', N'12838218', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh18', N'Hà Nội', N'0999999918', N'0999999918', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT180', N'Nguyễn Văn ', N'A180', NULL, CAST(N'1911-06-09' AS Date), N'P11', N'128382180', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh11', N'Hà Nội', N'09999999180', N'0999999911', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT181', N'Nguyễn Văn ', N'A181', NULL, CAST(N'1911-06-09' AS Date), N'P11', N'128382181', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh11', N'Hà Nội', N'09999999181', N'0999999911', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT182', N'Nguyễn Văn ', N'A182', NULL, CAST(N'1911-06-09' AS Date), N'P11', N'128382182', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh11', N'Hà Nội', N'09999999182', N'0999999911', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT183', N'Nguyễn Văn ', N'A183', NULL, CAST(N'1911-06-09' AS Date), N'P11', N'128382183', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh11', N'Hà Nội', N'09999999183', N'0999999911', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT189', N'Nguyễn Văn ', N'A189', NULL, CAST(N'1912-06-09' AS Date), N'P12', N'128382189', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh12', N'Hà Nội', N'09999999189', N'0999999912', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT19', N'Nguyễn Văn ', N'A19', NULL, CAST(N'1919-06-09' AS Date), N'P19', N'12838219', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh19', N'Hà Nội', N'0999999919', N'0999999919', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT190', N'Nguyễn Văn ', N'A190', NULL, CAST(N'1912-06-09' AS Date), N'P12', N'128382190', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh12', N'Hà Nội', N'09999999190', N'0999999912', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT191', N'Nguyễn Văn ', N'A191', NULL, CAST(N'1912-06-09' AS Date), N'P12', N'128382191', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh12', N'Hà Nội', N'09999999191', N'0999999912', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT192', N'Nguyễn Văn ', N'A192', NULL, CAST(N'1912-06-09' AS Date), N'P12', N'128382192', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh12', N'Hà Nội', N'09999999192', N'0999999912', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT198', N'Nguyễn Văn ', N'A198', NULL, CAST(N'1913-06-09' AS Date), N'P13', N'128382198', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh13', N'Hà Nội', N'09999999198', N'0999999913', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT199', N'Nguyễn Văn ', N'A199', NULL, CAST(N'1913-06-09' AS Date), N'P13', N'128382199', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh13', N'Hà Nội', N'09999999199', N'0999999913', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT20', N'Nguyễn Văn ', N'A20', NULL, CAST(N'1920-06-09' AS Date), N'P20', N'12838220', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh20', N'Hà Nội', N'0999999920', N'0999999920', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT200', N'Nguyễn Văn ', N'A200', NULL, CAST(N'1913-06-09' AS Date), N'P13', N'128382200', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh13', N'Hà Nội', N'09999999200', N'0999999913', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT201', N'Nguyễn Văn ', N'A201', NULL, CAST(N'1913-06-09' AS Date), N'P13', N'128382201', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh13', N'Hà Nội', N'09999999201', N'0999999913', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT207', N'Nguyễn Văn ', N'A207', NULL, CAST(N'1914-06-09' AS Date), N'P14', N'128382207', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh14', N'Hà Nội', N'09999999207', N'0999999914', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT208', N'Nguyễn Văn ', N'A208', NULL, CAST(N'1914-06-09' AS Date), N'P14', N'128382208', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh14', N'Hà Nội', N'09999999208', N'0999999914', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT209', N'Nguyễn Văn ', N'A209', NULL, CAST(N'1914-06-09' AS Date), N'P14', N'128382209', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh14', N'Hà Nội', N'09999999209', N'0999999914', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT21', N'Nguyễn Văn ', N'A21', NULL, CAST(N'1921-06-09' AS Date), N'P21', N'12838221', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh21', N'Hà Nội', N'0999999921', N'0999999921', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT210', N'Nguyễn Văn ', N'A210', NULL, CAST(N'1914-06-09' AS Date), N'P14', N'128382210', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh14', N'Hà Nội', N'09999999210', N'0999999914', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT216', N'Nguyễn Văn ', N'A216', NULL, CAST(N'1915-06-09' AS Date), N'P15', N'128382216', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh15', N'Hà Nội', N'09999999216', N'0999999915', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT217', N'Nguyễn Văn ', N'A217', NULL, CAST(N'1915-06-09' AS Date), N'P15', N'128382217', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh15', N'Hà Nội', N'09999999217', N'0999999915', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT218', N'Nguyễn Văn ', N'A218', NULL, CAST(N'1915-06-09' AS Date), N'P15', N'128382218', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh15', N'Hà Nội', N'09999999218', N'0999999915', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT219', N'Nguyễn Văn ', N'A219', NULL, CAST(N'1915-06-09' AS Date), N'P15', N'128382219', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh15', N'Hà Nội', N'09999999219', N'0999999915', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT22', N'Nguyễn Văn ', N'A22', NULL, CAST(N'1922-06-09' AS Date), N'P22', N'12838222', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh22', N'Hà Nội', N'0999999922', N'0999999922', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT225', N'Nguyễn Văn ', N'A225', NULL, CAST(N'1916-06-09' AS Date), N'P16', N'128382225', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh16', N'Hà Nội', N'09999999225', N'0999999916', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT226', N'Nguyễn Văn ', N'A226', NULL, CAST(N'1916-06-09' AS Date), N'P16', N'128382226', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh16', N'Hà Nội', N'09999999226', N'0999999916', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT227', N'Nguyễn Văn ', N'A227', NULL, CAST(N'1916-06-09' AS Date), N'P16', N'128382227', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh16', N'Hà Nội', N'09999999227', N'0999999916', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT228', N'Nguyễn Văn ', N'A228', NULL, CAST(N'1916-06-09' AS Date), N'P16', N'128382228', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh16', N'Hà Nội', N'09999999228', N'0999999916', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT23', N'Nguyễn Văn ', N'A23', NULL, CAST(N'1923-06-09' AS Date), N'P23', N'12838223', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh23', N'Hà Nội', N'0999999923', N'0999999923', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT234', N'Nguyễn Văn ', N'A234', NULL, CAST(N'1917-06-09' AS Date), N'P17', N'128382234', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh17', N'Hà Nội', N'09999999234', N'0999999917', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT235', N'Nguyễn Văn ', N'A235', NULL, CAST(N'1917-06-09' AS Date), N'P17', N'128382235', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh17', N'Hà Nội', N'09999999235', N'0999999917', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT236', N'Nguyễn Văn ', N'A236', NULL, CAST(N'1917-06-09' AS Date), N'P17', N'128382236', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh17', N'Hà Nội', N'09999999236', N'0999999917', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT237', N'Nguyễn Văn ', N'A237', NULL, CAST(N'1917-06-09' AS Date), N'P17', N'128382237', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh17', N'Hà Nội', N'09999999237', N'0999999917', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT243', N'Nguyễn Văn ', N'A243', NULL, CAST(N'1918-06-09' AS Date), N'P18', N'128382243', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh18', N'Hà Nội', N'09999999243', N'0999999918', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT244', N'Nguyễn Văn ', N'A244', NULL, CAST(N'1918-06-09' AS Date), N'P18', N'128382244', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh18', N'Hà Nội', N'09999999244', N'0999999918', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT245', N'Nguyễn Văn ', N'A245', NULL, CAST(N'1918-06-09' AS Date), N'P18', N'128382245', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh18', N'Hà Nội', N'09999999245', N'0999999918', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT246', N'Nguyễn Văn ', N'A246', NULL, CAST(N'1918-06-09' AS Date), N'P18', N'128382246', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh18', N'Hà Nội', N'09999999246', N'0999999918', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT25', N'Nguyễn Văn ', N'A25', NULL, CAST(N'1925-06-09' AS Date), N'P25', N'12838225', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh25', N'Hà Nội', N'0999999925', N'0999999925', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT252', N'Nguyễn Văn ', N'A252', NULL, CAST(N'1919-06-09' AS Date), N'P19', N'128382252', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh19', N'Hà Nội', N'09999999252', N'0999999919', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT253', N'Nguyễn Văn ', N'A253', NULL, CAST(N'1919-06-09' AS Date), N'P19', N'128382253', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh19', N'Hà Nội', N'09999999253', N'0999999919', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT254', N'Nguyễn Văn ', N'A254', NULL, CAST(N'1919-06-09' AS Date), N'P19', N'128382254', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh19', N'Hà Nội', N'09999999254', N'0999999919', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT255', N'Nguyễn Văn ', N'A255', NULL, CAST(N'1919-06-09' AS Date), N'P19', N'128382255', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh19', N'Hà Nội', N'09999999255', N'0999999919', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT26', N'Nguyễn Văn ', N'A26', NULL, CAST(N'1926-06-09' AS Date), N'P26', N'12838226', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh26', N'Hà Nội', N'0999999926', N'0999999926', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT261', N'Nguyễn Văn ', N'A261', NULL, CAST(N'1920-06-09' AS Date), N'P20', N'128382261', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh20', N'Hà Nội', N'09999999261', N'0999999920', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT262', N'Nguyễn Văn ', N'A262', NULL, CAST(N'1920-06-09' AS Date), N'P20', N'128382262', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh20', N'Hà Nội', N'09999999262', N'0999999920', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT263', N'Nguyễn Văn ', N'A263', NULL, CAST(N'1920-06-09' AS Date), N'P20', N'128382263', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh20', N'Hà Nội', N'09999999263', N'0999999920', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
GO
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT264', N'Nguyễn Văn ', N'A264', NULL, CAST(N'1920-06-09' AS Date), N'P20', N'128382264', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh20', N'Hà Nội', N'09999999264', N'0999999920', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT27', N'Nguyễn Văn ', N'A27', NULL, CAST(N'1927-06-09' AS Date), N'P27', N'12838227', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh27', N'Hà Nội', N'0999999927', N'0999999927', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT270', N'Nguyễn Văn ', N'A270', NULL, CAST(N'1921-06-09' AS Date), N'P21', N'128382270', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh21', N'Hà Nội', N'09999999270', N'0999999921', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT271', N'Nguyễn Văn ', N'A271', NULL, CAST(N'1921-06-09' AS Date), N'P21', N'128382271', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh21', N'Hà Nội', N'09999999271', N'0999999921', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT272', N'Nguyễn Văn ', N'A272', NULL, CAST(N'1921-06-09' AS Date), N'P21', N'128382272', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh21', N'Hà Nội', N'09999999272', N'0999999921', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT273', N'Nguyễn Văn ', N'A273', NULL, CAST(N'1921-06-09' AS Date), N'P21', N'128382273', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh21', N'Hà Nội', N'09999999273', N'0999999921', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT279', N'Nguyễn Văn ', N'A279', NULL, CAST(N'1922-06-09' AS Date), N'P22', N'128382279', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh22', N'Hà Nội', N'09999999279', N'0999999922', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT28', N'Nguyễn Văn ', N'A28', NULL, CAST(N'1928-06-09' AS Date), N'P28', N'12838228', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh28', N'Hà Nội', N'0999999928', N'0999999928', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT280', N'Nguyễn Văn ', N'A280', NULL, CAST(N'1922-06-09' AS Date), N'P22', N'128382280', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh22', N'Hà Nội', N'09999999280', N'0999999922', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT281', N'Nguyễn Văn ', N'A281', NULL, CAST(N'1922-06-09' AS Date), N'P22', N'128382281', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh22', N'Hà Nội', N'09999999281', N'0999999922', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT282', N'Nguyễn Văn ', N'A282', NULL, CAST(N'1922-06-09' AS Date), N'P22', N'128382282', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh22', N'Hà Nội', N'09999999282', N'0999999922', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT288', N'Nguyễn Văn ', N'A288', NULL, CAST(N'1923-06-09' AS Date), N'P23', N'128382288', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh23', N'Hà Nội', N'09999999288', N'0999999923', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT289', N'Nguyễn Văn ', N'A289', NULL, CAST(N'1923-06-09' AS Date), N'P23', N'128382289', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh23', N'Hà Nội', N'09999999289', N'0999999923', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT29', N'Nguyễn Văn ', N'A29', NULL, CAST(N'1929-06-09' AS Date), N'P29', N'12838229', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh29', N'Hà Nội', N'0999999929', N'0999999929', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT290', N'Nguyễn Văn ', N'A290', NULL, CAST(N'1923-06-09' AS Date), N'P23', N'128382290', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh23', N'Hà Nội', N'09999999290', N'0999999923', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT291', N'Nguyễn Văn ', N'A291', NULL, CAST(N'1923-06-09' AS Date), N'P23', N'128382291', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh23', N'Hà Nội', N'09999999291', N'0999999923', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT30', N'Nguyễn Văn ', N'A30', NULL, CAST(N'1930-06-09' AS Date), N'P30', N'12838230', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh30', N'Hà Nội', N'0999999930', N'0999999930', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT306', N'Nguyễn Văn ', N'A306', NULL, CAST(N'1925-06-09' AS Date), N'P25', N'128382306', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh25', N'Hà Nội', N'09999999306', N'0999999925', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT307', N'Nguyễn Văn ', N'A307', NULL, CAST(N'1925-06-09' AS Date), N'P25', N'128382307', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh25', N'Hà Nội', N'09999999307', N'0999999925', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT308', N'Nguyễn Văn ', N'A308', NULL, CAST(N'1925-06-09' AS Date), N'P25', N'128382308', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh25', N'Hà Nội', N'09999999308', N'0999999925', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT309', N'Nguyễn Văn ', N'A309', NULL, CAST(N'1925-06-09' AS Date), N'P25', N'128382309', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh25', N'Hà Nội', N'09999999309', N'0999999925', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT31', N'Nguyễn Văn ', N'A31', NULL, CAST(N'1931-06-09' AS Date), N'P31', N'12838231', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh31', N'Hà Nội', N'0999999931', N'0999999931', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT315', N'Nguyễn Văn ', N'A315', NULL, CAST(N'1926-06-09' AS Date), N'P26', N'128382315', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh26', N'Hà Nội', N'09999999315', N'0999999926', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT316', N'Nguyễn Văn ', N'A316', NULL, CAST(N'1926-06-09' AS Date), N'P26', N'128382316', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh26', N'Hà Nội', N'09999999316', N'0999999926', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT317', N'Nguyễn Văn ', N'A317', NULL, CAST(N'1926-06-09' AS Date), N'P26', N'128382317', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh26', N'Hà Nội', N'09999999317', N'0999999926', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT318', N'Nguyễn Văn ', N'A318', NULL, CAST(N'1926-06-09' AS Date), N'P26', N'128382318', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh26', N'Hà Nội', N'09999999318', N'0999999926', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT32', N'Nguyễn Văn ', N'A32', NULL, CAST(N'1932-06-09' AS Date), N'P32', N'12838232', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh32', N'Hà Nội', N'0999999932', N'0999999932', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT324', N'Nguyễn Văn ', N'A324', NULL, CAST(N'1927-06-09' AS Date), N'P27', N'128382324', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh27', N'Hà Nội', N'09999999324', N'0999999927', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT325', N'Nguyễn Văn ', N'A325', NULL, CAST(N'1927-06-09' AS Date), N'P27', N'128382325', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh27', N'Hà Nội', N'09999999325', N'0999999927', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT326', N'Nguyễn Văn ', N'A326', NULL, CAST(N'1927-06-09' AS Date), N'P27', N'128382326', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh27', N'Hà Nội', N'09999999326', N'0999999927', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT327', N'Nguyễn Văn ', N'A327', NULL, CAST(N'1927-06-09' AS Date), N'P27', N'128382327', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh27', N'Hà Nội', N'09999999327', N'0999999927', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT33', N'Nguyễn Văn ', N'A33', NULL, CAST(N'1933-06-09' AS Date), N'P33', N'12838233', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh33', N'Hà Nội', N'0999999933', N'0999999933', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT333', N'Nguyễn Văn ', N'A333', NULL, CAST(N'1928-06-09' AS Date), N'P28', N'128382333', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh28', N'Hà Nội', N'09999999333', N'0999999928', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT334', N'Nguyễn Văn ', N'A334', NULL, CAST(N'1928-06-09' AS Date), N'P28', N'128382334', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh28', N'Hà Nội', N'09999999334', N'0999999928', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT335', N'Nguyễn Văn ', N'A335', NULL, CAST(N'1928-06-09' AS Date), N'P28', N'128382335', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh28', N'Hà Nội', N'09999999335', N'0999999928', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT336', N'Nguyễn Văn ', N'A336', NULL, CAST(N'1928-06-09' AS Date), N'P28', N'128382336', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh28', N'Hà Nội', N'09999999336', N'0999999928', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT34', N'Nguyễn Văn ', N'A34', NULL, CAST(N'1934-06-09' AS Date), N'P34', N'12838234', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh34', N'Hà Nội', N'0999999934', N'0999999934', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT342', N'Nguyễn Văn ', N'A342', NULL, CAST(N'1929-06-09' AS Date), N'P29', N'128382342', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh29', N'Hà Nội', N'09999999342', N'0999999929', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT343', N'Nguyễn Văn ', N'A343', NULL, CAST(N'1929-06-09' AS Date), N'P29', N'128382343', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh29', N'Hà Nội', N'09999999343', N'0999999929', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT344', N'Nguyễn Văn ', N'A344', NULL, CAST(N'1929-06-09' AS Date), N'P29', N'128382344', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh29', N'Hà Nội', N'09999999344', N'0999999929', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT345', N'Nguyễn Văn ', N'A345', NULL, CAST(N'1929-06-09' AS Date), N'P29', N'128382345', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh29', N'Hà Nội', N'09999999345', N'0999999929', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT35', N'Nguyễn Văn ', N'A35', NULL, CAST(N'1935-06-09' AS Date), N'P35', N'12838235', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh35', N'Hà Nội', N'0999999935', N'0999999935', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT351', N'Nguyễn Văn ', N'A351', NULL, CAST(N'1930-06-09' AS Date), N'P30', N'128382351', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh30', N'Hà Nội', N'09999999351', N'0999999930', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT352', N'Nguyễn Văn ', N'A352', NULL, CAST(N'1930-06-09' AS Date), N'P30', N'128382352', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh30', N'Hà Nội', N'09999999352', N'0999999930', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT353', N'Nguyễn Văn ', N'A353', NULL, CAST(N'1930-06-09' AS Date), N'P30', N'128382353', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh30', N'Hà Nội', N'09999999353', N'0999999930', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT354', N'Nguyễn Văn ', N'A354', NULL, CAST(N'1930-06-09' AS Date), N'P30', N'128382354', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh30', N'Hà Nội', N'09999999354', N'0999999930', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT36', N'Nguyễn Văn ', N'A36', NULL, CAST(N'1936-06-09' AS Date), N'P36', N'12838236', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh36', N'Hà Nội', N'0999999936', N'0999999936', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT360', N'Nguyễn Văn ', N'A360', NULL, CAST(N'1931-06-09' AS Date), N'P31', N'128382360', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh31', N'Hà Nội', N'09999999360', N'0999999931', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT361', N'Nguyễn Văn ', N'A361', NULL, CAST(N'1931-06-09' AS Date), N'P31', N'128382361', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh31', N'Hà Nội', N'09999999361', N'0999999931', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT362', N'Nguyễn Văn ', N'A362', NULL, CAST(N'1931-06-09' AS Date), N'P31', N'128382362', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh31', N'Hà Nội', N'09999999362', N'0999999931', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT363', N'Nguyễn Văn ', N'A363', NULL, CAST(N'1931-06-09' AS Date), N'P31', N'128382363', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh31', N'Hà Nội', N'09999999363', N'0999999931', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT369', N'Nguyễn Văn ', N'A369', NULL, CAST(N'1932-06-09' AS Date), N'P32', N'128382369', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh32', N'Hà Nội', N'09999999369', N'0999999932', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT37', N'Nguyễn Văn ', N'A37', NULL, CAST(N'1937-06-09' AS Date), N'P37', N'12838237', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh37', N'Hà Nội', N'0999999937', N'0999999937', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT370', N'Nguyễn Văn ', N'A370', NULL, CAST(N'1932-06-09' AS Date), N'P32', N'128382370', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh32', N'Hà Nội', N'09999999370', N'0999999932', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT371', N'Nguyễn Văn ', N'A371', NULL, CAST(N'1932-06-09' AS Date), N'P32', N'128382371', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh32', N'Hà Nội', N'09999999371', N'0999999932', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT372', N'Nguyễn Văn ', N'A372', NULL, CAST(N'1932-06-09' AS Date), N'P32', N'128382372', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh32', N'Hà Nội', N'09999999372', N'0999999932', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT378', N'Nguyễn Văn ', N'A378', NULL, CAST(N'1933-06-09' AS Date), N'P33', N'128382378', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh33', N'Hà Nội', N'09999999378', N'0999999933', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT379', N'Nguyễn Văn ', N'A379', NULL, CAST(N'1933-06-09' AS Date), N'P33', N'128382379', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh33', N'Hà Nội', N'09999999379', N'0999999933', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT38', N'Nguyễn Văn ', N'A38', NULL, CAST(N'1938-06-09' AS Date), N'P38', N'12838238', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh38', N'Hà Nội', N'0999999938', N'0999999938', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT380', N'Nguyễn Văn ', N'A380', NULL, CAST(N'1933-06-09' AS Date), N'P33', N'128382380', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh33', N'Hà Nội', N'09999999380', N'0999999933', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT381', N'Nguyễn Văn ', N'A381', NULL, CAST(N'1933-06-09' AS Date), N'P33', N'128382381', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh33', N'Hà Nội', N'09999999381', N'0999999933', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT387', N'Nguyễn Văn ', N'A387', NULL, CAST(N'1934-06-09' AS Date), N'P34', N'128382387', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh34', N'Hà Nội', N'09999999387', N'0999999934', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT388', N'Nguyễn Văn ', N'A388', NULL, CAST(N'1934-06-09' AS Date), N'P34', N'128382388', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh34', N'Hà Nội', N'09999999388', N'0999999934', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT389', N'Nguyễn Văn ', N'A389', NULL, CAST(N'1934-06-09' AS Date), N'P34', N'128382389', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh34', N'Hà Nội', N'09999999389', N'0999999934', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT39', N'Nguyễn Văn ', N'A39', NULL, CAST(N'1939-06-09' AS Date), N'P39', N'12838239', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh39', N'Hà Nội', N'0999999939', N'0999999939', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT390', N'Nguyễn Văn ', N'A390', NULL, CAST(N'1934-06-09' AS Date), N'P34', N'128382390', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh34', N'Hà Nội', N'09999999390', N'0999999934', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT396', N'Nguyễn Văn ', N'A396', NULL, CAST(N'1935-06-09' AS Date), N'P35', N'128382396', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh35', N'Hà Nội', N'09999999396', N'0999999935', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT397', N'Nguyễn Văn ', N'A397', NULL, CAST(N'1935-06-09' AS Date), N'P35', N'128382397', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh35', N'Hà Nội', N'09999999397', N'0999999935', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT398', N'Nguyễn Văn ', N'A398', NULL, CAST(N'1935-06-09' AS Date), N'P35', N'128382398', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh35', N'Hà Nội', N'09999999398', N'0999999935', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT399', N'Nguyễn Văn ', N'A399', NULL, CAST(N'1935-06-09' AS Date), N'P35', N'128382399', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh35', N'Hà Nội', N'09999999399', N'0999999935', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT40', N'Nguyễn Văn ', N'A40', NULL, CAST(N'1940-06-09' AS Date), N'P40', N'12838240', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh40', N'Hà Nội', N'0999999940', N'0999999940', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT405', N'Nguyễn Văn ', N'A405', NULL, CAST(N'1936-06-09' AS Date), N'P36', N'128382405', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh36', N'Hà Nội', N'09999999405', N'0999999936', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT406', N'Nguyễn Văn ', N'A406', NULL, CAST(N'1936-06-09' AS Date), N'P36', N'128382406', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh36', N'Hà Nội', N'09999999406', N'0999999936', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT407', N'Nguyễn Văn ', N'A407', NULL, CAST(N'1936-06-09' AS Date), N'P36', N'128382407', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh36', N'Hà Nội', N'09999999407', N'0999999936', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT408', N'Nguyễn Văn ', N'A408', NULL, CAST(N'1936-06-09' AS Date), N'P36', N'128382408', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh36', N'Hà Nội', N'09999999408', N'0999999936', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT41', N'Nguyễn Văn ', N'A41', NULL, CAST(N'1941-06-09' AS Date), N'P41', N'12838241', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh41', N'Hà Nội', N'0999999941', N'0999999941', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT414', N'Nguyễn Văn ', N'A414', NULL, CAST(N'1937-06-09' AS Date), N'P37', N'128382414', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh37', N'Hà Nội', N'09999999414', N'0999999937', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT415', N'Nguyễn Văn ', N'A415', NULL, CAST(N'1937-06-09' AS Date), N'P37', N'128382415', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh37', N'Hà Nội', N'09999999415', N'0999999937', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT416', N'Nguyễn Văn ', N'A416', NULL, CAST(N'1937-06-09' AS Date), N'P37', N'128382416', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh37', N'Hà Nội', N'09999999416', N'0999999937', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT417', N'Nguyễn Văn ', N'A417', NULL, CAST(N'1937-06-09' AS Date), N'P37', N'128382417', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh37', N'Hà Nội', N'09999999417', N'0999999937', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT42', N'Nguyễn Văn ', N'A42', NULL, CAST(N'1942-06-09' AS Date), N'P42', N'12838242', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh42', N'Hà Nội', N'0999999942', N'0999999942', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT423', N'Nguyễn Văn ', N'A423', NULL, CAST(N'1938-06-09' AS Date), N'P38', N'128382423', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh38', N'Hà Nội', N'09999999423', N'0999999938', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT424', N'Nguyễn Văn ', N'A424', NULL, CAST(N'1938-06-09' AS Date), N'P38', N'128382424', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh38', N'Hà Nội', N'09999999424', N'0999999938', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT425', N'Nguyễn Văn ', N'A425', NULL, CAST(N'1938-06-09' AS Date), N'P38', N'128382425', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh38', N'Hà Nội', N'09999999425', N'0999999938', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT426', N'Nguyễn Văn ', N'A426', NULL, CAST(N'1938-06-09' AS Date), N'P38', N'128382426', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh38', N'Hà Nội', N'09999999426', N'0999999938', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT43', N'Nguyễn Văn ', N'A43', NULL, CAST(N'1943-06-09' AS Date), N'P43', N'12838243', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh43', N'Hà Nội', N'0999999943', N'0999999943', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT432', N'Nguyễn Văn ', N'A432', NULL, CAST(N'1939-06-09' AS Date), N'P39', N'128382432', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh39', N'Hà Nội', N'09999999432', N'0999999939', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT433', N'Nguyễn Văn ', N'A433', NULL, CAST(N'1939-06-09' AS Date), N'P39', N'128382433', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh39', N'Hà Nội', N'09999999433', N'0999999939', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT434', N'Nguyễn Văn ', N'A434', NULL, CAST(N'1939-06-09' AS Date), N'P39', N'128382434', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh39', N'Hà Nội', N'09999999434', N'0999999939', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT435', N'Nguyễn Văn ', N'A435', NULL, CAST(N'1939-06-09' AS Date), N'P39', N'128382435', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh39', N'Hà Nội', N'09999999435', N'0999999939', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT44', N'Nguyễn Văn ', N'A44', NULL, CAST(N'1944-06-09' AS Date), N'P44', N'12838244', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh44', N'Hà Nội', N'0999999944', N'0999999944', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT441', N'Nguyễn Văn ', N'A441', NULL, CAST(N'1940-06-09' AS Date), N'P40', N'128382441', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh40', N'Hà Nội', N'09999999441', N'0999999940', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT442', N'Nguyễn Văn ', N'A442', NULL, CAST(N'1940-06-09' AS Date), N'P40', N'128382442', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh40', N'Hà Nội', N'09999999442', N'0999999940', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT443', N'Nguyễn Văn ', N'A443', NULL, CAST(N'1940-06-09' AS Date), N'P40', N'128382443', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh40', N'Hà Nội', N'09999999443', N'0999999940', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT444', N'Nguyễn Văn ', N'A444', NULL, CAST(N'1940-06-09' AS Date), N'P40', N'128382444', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh40', N'Hà Nội', N'09999999444', N'0999999940', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT45', N'Nguyễn Văn ', N'A45', NULL, CAST(N'1945-06-09' AS Date), N'P45', N'12838245', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh45', N'Hà Nội', N'0999999945', N'0999999945', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT450', N'Nguyễn Văn ', N'A450', NULL, CAST(N'1941-06-09' AS Date), N'P41', N'128382450', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh41', N'Hà Nội', N'09999999450', N'0999999941', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT451', N'Nguyễn Văn ', N'A451', NULL, CAST(N'1941-06-09' AS Date), N'P41', N'128382451', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh41', N'Hà Nội', N'09999999451', N'0999999941', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT452', N'Nguyễn Văn ', N'A452', NULL, CAST(N'1941-06-09' AS Date), N'P41', N'128382452', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh41', N'Hà Nội', N'09999999452', N'0999999941', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT453', N'Nguyễn Văn ', N'A453', NULL, CAST(N'1941-06-09' AS Date), N'P41', N'128382453', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh41', N'Hà Nội', N'09999999453', N'0999999941', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
GO
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT459', N'Nguyễn Văn ', N'A459', NULL, CAST(N'1942-06-09' AS Date), N'P42', N'128382459', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh42', N'Hà Nội', N'09999999459', N'0999999942', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT46', N'Nguyễn Văn ', N'A46', NULL, CAST(N'1946-06-09' AS Date), N'P46', N'12838246', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh46', N'Hà Nội', N'0999999946', N'0999999946', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT460', N'Nguyễn Văn ', N'A460', NULL, CAST(N'1942-06-09' AS Date), N'P42', N'128382460', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh42', N'Hà Nội', N'09999999460', N'0999999942', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT461', N'Nguyễn Văn ', N'A461', NULL, CAST(N'1942-06-09' AS Date), N'P42', N'128382461', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh42', N'Hà Nội', N'09999999461', N'0999999942', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT462', N'Nguyễn Văn ', N'A462', NULL, CAST(N'1942-06-09' AS Date), N'P42', N'128382462', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh42', N'Hà Nội', N'09999999462', N'0999999942', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT468', N'Nguyễn Văn ', N'A468', NULL, CAST(N'1943-06-09' AS Date), N'P43', N'128382468', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh43', N'Hà Nội', N'09999999468', N'0999999943', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT469', N'Nguyễn Văn ', N'A469', NULL, CAST(N'1943-06-09' AS Date), N'P43', N'128382469', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh43', N'Hà Nội', N'09999999469', N'0999999943', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT47', N'Nguyễn Văn ', N'A47', NULL, CAST(N'1947-06-09' AS Date), N'P47', N'12838247', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh47', N'Hà Nội', N'0999999947', N'0999999947', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT470', N'Nguyễn Văn ', N'A470', NULL, CAST(N'1943-06-09' AS Date), N'P43', N'128382470', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh43', N'Hà Nội', N'09999999470', N'0999999943', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT471', N'Nguyễn Văn ', N'A471', NULL, CAST(N'1943-06-09' AS Date), N'P43', N'128382471', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh43', N'Hà Nội', N'09999999471', N'0999999943', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT477', N'Nguyễn Văn ', N'A477', NULL, CAST(N'1944-06-09' AS Date), N'P44', N'128382477', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh44', N'Hà Nội', N'09999999477', N'0999999944', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT478', N'Nguyễn Văn ', N'A478', NULL, CAST(N'1944-06-09' AS Date), N'P44', N'128382478', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh44', N'Hà Nội', N'09999999478', N'0999999944', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT479', N'Nguyễn Văn ', N'A479', NULL, CAST(N'1944-06-09' AS Date), N'P44', N'128382479', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh44', N'Hà Nội', N'09999999479', N'0999999944', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT48', N'Nguyễn Văn ', N'A48', NULL, CAST(N'1948-06-09' AS Date), N'P48', N'12838248', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh48', N'Hà Nội', N'0999999948', N'0999999948', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT480', N'Nguyễn Văn ', N'A480', NULL, CAST(N'1944-06-09' AS Date), N'P44', N'128382480', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh44', N'Hà Nội', N'09999999480', N'0999999944', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT486', N'Nguyễn Văn ', N'A486', NULL, CAST(N'1945-06-09' AS Date), N'P45', N'128382486', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh45', N'Hà Nội', N'09999999486', N'0999999945', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT487', N'Nguyễn Văn ', N'A487', NULL, CAST(N'1945-06-09' AS Date), N'P45', N'128382487', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh45', N'Hà Nội', N'09999999487', N'0999999945', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT488', N'Nguyễn Văn ', N'A488', NULL, CAST(N'1945-06-09' AS Date), N'P45', N'128382488', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh45', N'Hà Nội', N'09999999488', N'0999999945', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT489', N'Nguyễn Văn ', N'A489', NULL, CAST(N'1945-06-09' AS Date), N'P45', N'128382489', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh45', N'Hà Nội', N'09999999489', N'0999999945', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT49', N'Nguyễn Văn ', N'A49', NULL, CAST(N'1949-06-09' AS Date), N'P49', N'12838249', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh49', N'Hà Nội', N'0999999949', N'0999999949', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT495', N'Nguyễn Văn ', N'A495', NULL, CAST(N'1946-06-09' AS Date), N'P46', N'128382495', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh46', N'Hà Nội', N'09999999495', N'0999999946', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT496', N'Nguyễn Văn ', N'A496', NULL, CAST(N'1946-06-09' AS Date), N'P46', N'128382496', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh46', N'Hà Nội', N'09999999496', N'0999999946', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT497', N'Nguyễn Văn ', N'A497', NULL, CAST(N'1946-06-09' AS Date), N'P46', N'128382497', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh46', N'Hà Nội', N'09999999497', N'0999999946', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT498', N'Nguyễn Văn ', N'A498', NULL, CAST(N'1946-06-09' AS Date), N'P46', N'128382498', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh46', N'Hà Nội', N'09999999498', N'0999999946', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT50', N'Nguyễn Văn ', N'A50', NULL, CAST(N'1950-06-09' AS Date), N'P50', N'12838250', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh50', N'Hà Nội', N'0999999950', N'0999999950', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT504', N'Nguyễn Văn ', N'A504', NULL, CAST(N'1947-06-09' AS Date), N'P47', N'128382504', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh47', N'Hà Nội', N'09999999504', N'0999999947', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT505', N'Nguyễn Văn ', N'A505', NULL, CAST(N'1947-06-09' AS Date), N'P47', N'128382505', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh47', N'Hà Nội', N'09999999505', N'0999999947', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT506', N'Nguyễn Văn ', N'A506', NULL, CAST(N'1947-06-09' AS Date), N'P47', N'128382506', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh47', N'Hà Nội', N'09999999506', N'0999999947', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT507', N'Nguyễn Văn ', N'A507', NULL, CAST(N'1947-06-09' AS Date), N'P47', N'128382507', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh47', N'Hà Nội', N'09999999507', N'0999999947', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT51', N'Nguyễn Văn ', N'A51', NULL, CAST(N'1951-06-09' AS Date), N'P51', N'12838251', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh51', N'Hà Nội', N'0999999951', N'0999999951', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT513', N'Nguyễn Văn ', N'A513', NULL, CAST(N'1948-06-09' AS Date), N'P48', N'128382513', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh48', N'Hà Nội', N'09999999513', N'0999999948', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT514', N'Nguyễn Văn ', N'A514', NULL, CAST(N'1948-06-09' AS Date), N'P48', N'128382514', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh48', N'Hà Nội', N'09999999514', N'0999999948', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT515', N'Nguyễn Văn ', N'A515', NULL, CAST(N'1948-06-09' AS Date), N'P48', N'128382515', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh48', N'Hà Nội', N'09999999515', N'0999999948', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT516', N'Nguyễn Văn ', N'A516', NULL, CAST(N'1948-06-09' AS Date), N'P48', N'128382516', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh48', N'Hà Nội', N'09999999516', N'0999999948', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT52', N'Nguyễn Văn ', N'A52', NULL, CAST(N'1952-06-09' AS Date), N'P52', N'12838252', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh52', N'Hà Nội', N'0999999952', N'0999999952', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT522', N'Nguyễn Văn ', N'A522', NULL, CAST(N'1949-06-09' AS Date), N'P49', N'128382522', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh49', N'Hà Nội', N'09999999522', N'0999999949', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT523', N'Nguyễn Văn ', N'A523', NULL, CAST(N'1949-06-09' AS Date), N'P49', N'128382523', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh49', N'Hà Nội', N'09999999523', N'0999999949', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT524', N'Nguyễn Văn ', N'A524', NULL, CAST(N'1949-06-09' AS Date), N'P49', N'128382524', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh49', N'Hà Nội', N'09999999524', N'0999999949', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT525', N'Nguyễn Văn ', N'A525', NULL, CAST(N'1949-06-09' AS Date), N'P49', N'128382525', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh49', N'Hà Nội', N'09999999525', N'0999999949', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT53', N'Nguyễn Văn ', N'A53', NULL, CAST(N'1953-06-09' AS Date), N'P53', N'12838253', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh53', N'Hà Nội', N'0999999953', N'0999999953', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT531', N'Nguyễn Văn ', N'A531', NULL, CAST(N'1950-06-09' AS Date), N'P50', N'128382531', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh50', N'Hà Nội', N'09999999531', N'0999999950', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT532', N'Nguyễn Văn ', N'A532', NULL, CAST(N'1950-06-09' AS Date), N'P50', N'128382532', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh50', N'Hà Nội', N'09999999532', N'0999999950', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT533', N'Nguyễn Văn ', N'A533', NULL, CAST(N'1950-06-09' AS Date), N'P50', N'128382533', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh50', N'Hà Nội', N'09999999533', N'0999999950', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT534', N'Nguyễn Văn ', N'A534', NULL, CAST(N'1950-06-09' AS Date), N'P50', N'128382534', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh50', N'Hà Nội', N'09999999534', N'0999999950', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT54', N'Nguyễn Văn ', N'A54', NULL, CAST(N'1954-06-09' AS Date), N'P54', N'12838254', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh54', N'Hà Nội', N'0999999954', N'0999999954', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT540', N'Nguyễn Văn ', N'A540', NULL, CAST(N'1951-06-09' AS Date), N'P51', N'128382540', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh51', N'Hà Nội', N'09999999540', N'0999999951', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT541', N'Nguyễn Văn ', N'A541', NULL, CAST(N'1951-06-09' AS Date), N'P51', N'128382541', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh51', N'Hà Nội', N'09999999541', N'0999999951', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT542', N'Nguyễn Văn ', N'A542', NULL, CAST(N'1951-06-09' AS Date), N'P51', N'128382542', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh51', N'Hà Nội', N'09999999542', N'0999999951', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT543', N'Nguyễn Văn ', N'A543', NULL, CAST(N'1951-06-09' AS Date), N'P51', N'128382543', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh51', N'Hà Nội', N'09999999543', N'0999999951', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT549', N'Nguyễn Văn ', N'A549', NULL, CAST(N'1952-06-09' AS Date), N'P52', N'128382549', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh52', N'Hà Nội', N'09999999549', N'0999999952', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT55', N'Nguyễn Văn ', N'A55', NULL, CAST(N'1955-06-09' AS Date), N'P55', N'12838255', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh55', N'Hà Nội', N'0999999955', N'0999999955', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT550', N'Nguyễn Văn ', N'A550', NULL, CAST(N'1952-06-09' AS Date), N'P52', N'128382550', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh52', N'Hà Nội', N'09999999550', N'0999999952', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT551', N'Nguyễn Văn ', N'A551', NULL, CAST(N'1952-06-09' AS Date), N'P52', N'128382551', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh52', N'Hà Nội', N'09999999551', N'0999999952', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT552', N'Nguyễn Văn ', N'A552', NULL, CAST(N'1952-06-09' AS Date), N'P52', N'128382552', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh52', N'Hà Nội', N'09999999552', N'0999999952', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT558', N'Nguyễn Văn ', N'A558', NULL, CAST(N'1953-06-09' AS Date), N'P53', N'128382558', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh53', N'Hà Nội', N'09999999558', N'0999999953', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT559', N'Nguyễn Văn ', N'A559', NULL, CAST(N'1953-06-09' AS Date), N'P53', N'128382559', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh53', N'Hà Nội', N'09999999559', N'0999999953', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT56', N'Nguyễn Văn ', N'A56', NULL, CAST(N'1956-06-09' AS Date), N'P56', N'12838256', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh56', N'Hà Nội', N'0999999956', N'0999999956', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT560', N'Nguyễn Văn ', N'A560', NULL, CAST(N'1953-06-09' AS Date), N'P53', N'128382560', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh53', N'Hà Nội', N'09999999560', N'0999999953', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT561', N'Nguyễn Văn ', N'A561', NULL, CAST(N'1953-06-09' AS Date), N'P53', N'128382561', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh53', N'Hà Nội', N'09999999561', N'0999999953', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT567', N'Nguyễn Văn ', N'A567', NULL, CAST(N'1954-06-09' AS Date), N'P54', N'128382567', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh54', N'Hà Nội', N'09999999567', N'0999999954', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT568', N'Nguyễn Văn ', N'A568', NULL, CAST(N'1954-06-09' AS Date), N'P54', N'128382568', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh54', N'Hà Nội', N'09999999568', N'0999999954', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT569', N'Nguyễn Văn ', N'A569', NULL, CAST(N'1954-06-09' AS Date), N'P54', N'128382569', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh54', N'Hà Nội', N'09999999569', N'0999999954', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT57', N'Nguyễn Văn ', N'A57', NULL, CAST(N'1957-06-09' AS Date), N'P57', N'12838257', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh57', N'Hà Nội', N'0999999957', N'0999999957', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT570', N'Nguyễn Văn ', N'A570', NULL, CAST(N'1954-06-09' AS Date), N'P54', N'128382570', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh54', N'Hà Nội', N'09999999570', N'0999999954', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT576', N'Nguyễn Văn ', N'A576', NULL, CAST(N'1955-06-09' AS Date), N'P55', N'128382576', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh55', N'Hà Nội', N'09999999576', N'0999999955', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT577', N'Nguyễn Văn ', N'A577', NULL, CAST(N'1955-06-09' AS Date), N'P55', N'128382577', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh55', N'Hà Nội', N'09999999577', N'0999999955', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT578', N'Nguyễn Văn ', N'A578', NULL, CAST(N'1955-06-09' AS Date), N'P55', N'128382578', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh55', N'Hà Nội', N'09999999578', N'0999999955', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT579', N'Nguyễn Văn ', N'A579', NULL, CAST(N'1955-06-09' AS Date), N'P55', N'128382579', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh55', N'Hà Nội', N'09999999579', N'0999999955', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT585', N'Nguyễn Văn ', N'A585', NULL, CAST(N'1956-06-09' AS Date), N'P56', N'128382585', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh56', N'Hà Nội', N'09999999585', N'0999999956', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT586', N'Nguyễn Văn ', N'A586', NULL, CAST(N'1956-06-09' AS Date), N'P56', N'128382586', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh56', N'Hà Nội', N'09999999586', N'0999999956', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT587', N'Nguyễn Văn ', N'A587', NULL, CAST(N'1956-06-09' AS Date), N'P56', N'128382587', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh56', N'Hà Nội', N'09999999587', N'0999999956', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT588', N'Nguyễn Văn ', N'A588', NULL, CAST(N'1956-06-09' AS Date), N'P56', N'128382588', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh56', N'Hà Nội', N'09999999588', N'0999999956', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT594', N'Nguyễn Văn ', N'A594', NULL, CAST(N'1957-06-09' AS Date), N'P57', N'128382594', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh57', N'Hà Nội', N'09999999594', N'0999999957', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT595', N'Nguyễn Văn ', N'A595', NULL, CAST(N'1957-06-09' AS Date), N'P57', N'128382595', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh57', N'Hà Nội', N'09999999595', N'0999999957', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT596', N'Nguyễn Văn ', N'A596', NULL, CAST(N'1957-06-09' AS Date), N'P57', N'128382596', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh57', N'Hà Nội', N'09999999596', N'0999999957', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT597', N'Nguyễn Văn ', N'A597', NULL, CAST(N'1957-06-09' AS Date), N'P57', N'128382597', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh57', N'Hà Nội', N'09999999597', N'0999999957', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT63', N'Nguyễn Văn ', N'A63', NULL, CAST(N'1963-06-09' AS Date), N'P63', N'12838263', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh63', N'Hà Nội', N'0999999963', N'0999999963', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT648', N'Nguyễn Văn ', N'A648', NULL, CAST(N'1963-06-09' AS Date), N'P63', N'128382648', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh63', N'Hà Nội', N'09999999648', N'0999999963', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT649', N'Nguyễn Văn ', N'A649', NULL, CAST(N'1963-06-09' AS Date), N'P63', N'128382649', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh63', N'Hà Nội', N'09999999649', N'0999999963', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT65', N'Nguyễn Văn ', N'A65', NULL, CAST(N'1965-06-09' AS Date), N'P65', N'12838265', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh65', N'Hà Nội', N'0999999965', N'0999999965', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT650', N'Nguyễn Văn ', N'A650', NULL, CAST(N'1963-06-09' AS Date), N'P63', N'128382650', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh63', N'Hà Nội', N'09999999650', N'0999999963', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT651', N'Nguyễn Văn ', N'A651', NULL, CAST(N'1963-06-09' AS Date), N'P63', N'128382651', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh63', N'Hà Nội', N'09999999651', N'0999999963', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT66', N'Nguyễn Văn ', N'A66', NULL, CAST(N'1966-06-09' AS Date), N'P66', N'12838266', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh66', N'Hà Nội', N'0999999966', N'0999999966', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT666', N'Nguyễn Văn ', N'A666', NULL, CAST(N'1965-06-09' AS Date), N'P65', N'128382666', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh65', N'Hà Nội', N'09999999666', N'0999999965', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT667', N'Nguyễn Văn ', N'A667', NULL, CAST(N'1965-06-09' AS Date), N'P65', N'128382667', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh65', N'Hà Nội', N'09999999667', N'0999999965', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT668', N'Nguyễn Văn ', N'A668', NULL, CAST(N'1965-06-09' AS Date), N'P65', N'128382668', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh65', N'Hà Nội', N'09999999668', N'0999999965', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT669', N'Nguyễn Văn ', N'A669', NULL, CAST(N'1965-06-09' AS Date), N'P65', N'128382669', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh65', N'Hà Nội', N'09999999669', N'0999999965', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT67', N'Nguyễn Văn ', N'A67', NULL, CAST(N'1967-06-09' AS Date), N'P67', N'12838267', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh67', N'Hà Nội', N'0999999967', N'0999999967', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT675', N'Nguyễn Văn ', N'A675', NULL, CAST(N'1966-06-09' AS Date), N'P66', N'128382675', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh66', N'Hà Nội', N'09999999675', N'0999999966', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT676', N'Nguyễn Văn ', N'A676', NULL, CAST(N'1966-06-09' AS Date), N'P66', N'128382676', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh66', N'Hà Nội', N'09999999676', N'0999999966', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT677', N'Nguyễn Văn ', N'A677', NULL, CAST(N'1966-06-09' AS Date), N'P66', N'128382677', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh66', N'Hà Nội', N'09999999677', N'0999999966', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT678', N'Nguyễn Văn ', N'A678', NULL, CAST(N'1966-06-09' AS Date), N'P66', N'128382678', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh66', N'Hà Nội', N'09999999678', N'0999999966', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT68', N'Nguyễn Văn ', N'A68', NULL, CAST(N'1968-06-09' AS Date), N'P68', N'12838268', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh68', N'Hà Nội', N'0999999968', N'0999999968', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT684', N'Nguyễn Văn ', N'A684', NULL, CAST(N'1967-06-09' AS Date), N'P67', N'128382684', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh67', N'Hà Nội', N'09999999684', N'0999999967', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT685', N'Nguyễn Văn ', N'A685', NULL, CAST(N'1967-06-09' AS Date), N'P67', N'128382685', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh67', N'Hà Nội', N'09999999685', N'0999999967', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT686', N'Nguyễn Văn ', N'A686', NULL, CAST(N'1967-06-09' AS Date), N'P67', N'128382686', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh67', N'Hà Nội', N'09999999686', N'0999999967', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT687', N'Nguyễn Văn ', N'A687', NULL, CAST(N'1967-06-09' AS Date), N'P67', N'128382687', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh67', N'Hà Nội', N'09999999687', N'0999999967', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT69', N'Nguyễn Văn ', N'A69', NULL, CAST(N'1969-06-09' AS Date), N'P69', N'12838269', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh69', N'Hà Nội', N'0999999969', N'0999999969', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT693', N'Nguyễn Văn ', N'A693', NULL, CAST(N'1968-06-09' AS Date), N'P68', N'128382693', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh68', N'Hà Nội', N'09999999693', N'0999999968', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT694', N'Nguyễn Văn ', N'A694', NULL, CAST(N'1968-06-09' AS Date), N'P68', N'128382694', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh68', N'Hà Nội', N'09999999694', N'0999999968', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
GO
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT695', N'Nguyễn Văn ', N'A695', NULL, CAST(N'1968-06-09' AS Date), N'P68', N'128382695', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh68', N'Hà Nội', N'09999999695', N'0999999968', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT696', N'Nguyễn Văn ', N'A696', NULL, CAST(N'1968-06-09' AS Date), N'P68', N'128382696', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh68', N'Hà Nội', N'09999999696', N'0999999968', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT70', N'Nguyễn Văn ', N'A70', NULL, CAST(N'1970-06-09' AS Date), N'P70', N'12838270', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh70', N'Hà Nội', N'0999999970', N'0999999970', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT702', N'Nguyễn Văn ', N'A702', NULL, CAST(N'1969-06-09' AS Date), N'P69', N'128382702', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh69', N'Hà Nội', N'09999999702', N'0999999969', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT703', N'Nguyễn Văn ', N'A703', NULL, CAST(N'1969-06-09' AS Date), N'P69', N'128382703', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh69', N'Hà Nội', N'09999999703', N'0999999969', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT704', N'Nguyễn Văn ', N'A704', NULL, CAST(N'1969-06-09' AS Date), N'P69', N'128382704', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh69', N'Hà Nội', N'09999999704', N'0999999969', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT705', N'Nguyễn Văn ', N'A705', NULL, CAST(N'1969-06-09' AS Date), N'P69', N'128382705', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh69', N'Hà Nội', N'09999999705', N'0999999969', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT71', N'Nguyễn Văn ', N'A71', NULL, CAST(N'1971-06-09' AS Date), N'P71', N'12838271', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh71', N'Hà Nội', N'0999999971', N'0999999971', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT711', N'Nguyễn Văn ', N'A711', NULL, CAST(N'1970-06-09' AS Date), N'P70', N'128382711', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh70', N'Hà Nội', N'09999999711', N'0999999970', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT712', N'Nguyễn Văn ', N'A712', NULL, CAST(N'1970-06-09' AS Date), N'P70', N'128382712', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh70', N'Hà Nội', N'09999999712', N'0999999970', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT713', N'Nguyễn Văn ', N'A713', NULL, CAST(N'1970-06-09' AS Date), N'P70', N'128382713', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh70', N'Hà Nội', N'09999999713', N'0999999970', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT714', N'Nguyễn Văn ', N'A714', NULL, CAST(N'1970-06-09' AS Date), N'P70', N'128382714', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh70', N'Hà Nội', N'09999999714', N'0999999970', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT72', N'Nguyễn Văn ', N'A72', NULL, CAST(N'1972-06-09' AS Date), N'P72', N'12838272', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh72', N'Hà Nội', N'0999999972', N'0999999972', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT720', N'Nguyễn Văn ', N'A720', NULL, CAST(N'1971-06-09' AS Date), N'P71', N'128382720', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh71', N'Hà Nội', N'09999999720', N'0999999971', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT721', N'Nguyễn Văn ', N'A721', NULL, CAST(N'1971-06-09' AS Date), N'P71', N'128382721', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh71', N'Hà Nội', N'09999999721', N'0999999971', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT722', N'Nguyễn Văn ', N'A722', NULL, CAST(N'1971-06-09' AS Date), N'P71', N'128382722', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh71', N'Hà Nội', N'09999999722', N'0999999971', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT723', N'Nguyễn Văn ', N'A723', NULL, CAST(N'1971-06-09' AS Date), N'P71', N'128382723', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh71', N'Hà Nội', N'09999999723', N'0999999971', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT729', N'Nguyễn Văn ', N'A729', NULL, CAST(N'1972-06-09' AS Date), N'P72', N'128382729', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh72', N'Hà Nội', N'09999999729', N'0999999972', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT73', N'Nguyễn Văn ', N'A73', NULL, CAST(N'1973-06-09' AS Date), N'P73', N'12838273', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh73', N'Hà Nội', N'0999999973', N'0999999973', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT730', N'Nguyễn Văn ', N'A730', NULL, CAST(N'1972-06-09' AS Date), N'P72', N'128382730', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh72', N'Hà Nội', N'09999999730', N'0999999972', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT731', N'Nguyễn Văn ', N'A731', NULL, CAST(N'1972-06-09' AS Date), N'P72', N'128382731', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh72', N'Hà Nội', N'09999999731', N'0999999972', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT732', N'Nguyễn Văn ', N'A732', NULL, CAST(N'1972-06-09' AS Date), N'P72', N'128382732', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh72', N'Hà Nội', N'09999999732', N'0999999972', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT738', N'Nguyễn Văn ', N'A738', NULL, CAST(N'1973-06-09' AS Date), N'P73', N'128382738', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh73', N'Hà Nội', N'09999999738', N'0999999973', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT739', N'Nguyễn Văn ', N'A739', NULL, CAST(N'1973-06-09' AS Date), N'P73', N'128382739', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh73', N'Hà Nội', N'09999999739', N'0999999973', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT740', N'Nguyễn Văn ', N'A740', NULL, CAST(N'1973-06-09' AS Date), N'P73', N'128382740', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh73', N'Hà Nội', N'09999999740', N'0999999973', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT741', N'Nguyễn Văn ', N'A741', NULL, CAST(N'1973-06-09' AS Date), N'P73', N'128382741', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh73', N'Hà Nội', N'09999999741', N'0999999973', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT75', N'Nguyễn Văn ', N'A75', NULL, CAST(N'1975-06-09' AS Date), N'P75', N'12838275', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh75', N'Hà Nội', N'0999999975', N'0999999975', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT756', N'Nguyễn Văn ', N'A756', NULL, CAST(N'1975-06-09' AS Date), N'P75', N'128382756', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh75', N'Hà Nội', N'09999999756', N'0999999975', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT757', N'Nguyễn Văn ', N'A757', NULL, CAST(N'1975-06-09' AS Date), N'P75', N'128382757', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh75', N'Hà Nội', N'09999999757', N'0999999975', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT758', N'Nguyễn Văn ', N'A758', NULL, CAST(N'1975-06-09' AS Date), N'P75', N'128382758', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh75', N'Hà Nội', N'09999999758', N'0999999975', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT759', N'Nguyễn Văn ', N'A759', NULL, CAST(N'1975-06-09' AS Date), N'P75', N'128382759', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh75', N'Hà Nội', N'09999999759', N'0999999975', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT76', N'Nguyễn Văn ', N'A76', NULL, CAST(N'1976-06-09' AS Date), N'P76', N'12838276', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh76', N'Hà Nội', N'0999999976', N'0999999976', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT765', N'Nguyễn Văn ', N'A765', NULL, CAST(N'1976-06-09' AS Date), N'P76', N'128382765', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh76', N'Hà Nội', N'09999999765', N'0999999976', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT766', N'Nguyễn Văn ', N'A766', NULL, CAST(N'1976-06-09' AS Date), N'P76', N'128382766', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh76', N'Hà Nội', N'09999999766', N'0999999976', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT767', N'Nguyễn Văn ', N'A767', NULL, CAST(N'1976-06-09' AS Date), N'P76', N'128382767', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh76', N'Hà Nội', N'09999999767', N'0999999976', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT768', N'Nguyễn Văn ', N'A768', NULL, CAST(N'1976-06-09' AS Date), N'P76', N'128382768', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh76', N'Hà Nội', N'09999999768', N'0999999976', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT77', N'Nguyễn Văn ', N'A77', NULL, CAST(N'1977-06-09' AS Date), N'P77', N'12838277', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh77', N'Hà Nội', N'0999999977', N'0999999977', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT774', N'Nguyễn Văn ', N'A774', NULL, CAST(N'1977-06-09' AS Date), N'P77', N'128382774', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh77', N'Hà Nội', N'09999999774', N'0999999977', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT775', N'Nguyễn Văn ', N'A775', NULL, CAST(N'1977-06-09' AS Date), N'P77', N'128382775', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh77', N'Hà Nội', N'09999999775', N'0999999977', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT776', N'Nguyễn Văn ', N'A776', NULL, CAST(N'1977-06-09' AS Date), N'P77', N'128382776', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh77', N'Hà Nội', N'09999999776', N'0999999977', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT777', N'Nguyễn Văn ', N'A777', NULL, CAST(N'1977-06-09' AS Date), N'P77', N'128382777', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh77', N'Hà Nội', N'09999999777', N'0999999977', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT78', N'Nguyễn Văn ', N'A78', NULL, CAST(N'1978-06-09' AS Date), N'P78', N'12838278', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh78', N'Hà Nội', N'0999999978', N'0999999978', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT783', N'Nguyễn Văn ', N'A783', NULL, CAST(N'1978-06-09' AS Date), N'P78', N'128382783', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh78', N'Hà Nội', N'09999999783', N'0999999978', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT784', N'Nguyễn Văn ', N'A784', NULL, CAST(N'1978-06-09' AS Date), N'P78', N'128382784', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh78', N'Hà Nội', N'09999999784', N'0999999978', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT785', N'Nguyễn Văn ', N'A785', NULL, CAST(N'1978-06-09' AS Date), N'P78', N'128382785', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh78', N'Hà Nội', N'09999999785', N'0999999978', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT786', N'Nguyễn Văn ', N'A786', NULL, CAST(N'1978-06-09' AS Date), N'P78', N'128382786', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh78', N'Hà Nội', N'09999999786', N'0999999978', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT79', N'Nguyễn Văn ', N'A79', NULL, CAST(N'1979-06-09' AS Date), N'P79', N'12838279', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh79', N'Hà Nội', N'0999999979', N'0999999979', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT792', N'Nguyễn Văn ', N'A792', NULL, CAST(N'1979-06-09' AS Date), N'P79', N'128382792', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh79', N'Hà Nội', N'09999999792', N'0999999979', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT793', N'Nguyễn Văn ', N'A793', NULL, CAST(N'1979-06-09' AS Date), N'P79', N'128382793', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh79', N'Hà Nội', N'09999999793', N'0999999979', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT794', N'Nguyễn Văn ', N'A794', NULL, CAST(N'1979-06-09' AS Date), N'P79', N'128382794', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh79', N'Hà Nội', N'09999999794', N'0999999979', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT795', N'Nguyễn Văn ', N'A795', NULL, CAST(N'1979-06-09' AS Date), N'P79', N'128382795', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh79', N'Hà Nội', N'09999999795', N'0999999979', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT80', N'Nguyễn Văn ', N'A80', NULL, CAST(N'1980-06-09' AS Date), N'P80', N'12838280', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh80', N'Hà Nội', N'0999999980', N'0999999980', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT801', N'Nguyễn Văn ', N'A801', NULL, CAST(N'1980-06-09' AS Date), N'P80', N'128382801', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh80', N'Hà Nội', N'09999999801', N'0999999980', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT802', N'Nguyễn Văn ', N'A802', NULL, CAST(N'1980-06-09' AS Date), N'P80', N'128382802', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh80', N'Hà Nội', N'09999999802', N'0999999980', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT803', N'Nguyễn Văn ', N'A803', NULL, CAST(N'1980-06-09' AS Date), N'P80', N'128382803', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh80', N'Hà Nội', N'09999999803', N'0999999980', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT804', N'Nguyễn Văn ', N'A804', NULL, CAST(N'1980-06-09' AS Date), N'P80', N'128382804', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh80', N'Hà Nội', N'09999999804', N'0999999980', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT81', N'Nguyễn Văn ', N'A81', NULL, CAST(N'1981-06-09' AS Date), N'P81', N'12838281', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh81', N'Hà Nội', N'0999999981', N'0999999981', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT810', N'Nguyễn Văn ', N'A810', NULL, CAST(N'1981-06-09' AS Date), N'P81', N'128382810', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh81', N'Hà Nội', N'09999999810', N'0999999981', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT811', N'Nguyễn Văn ', N'A811', NULL, CAST(N'1981-06-09' AS Date), N'P81', N'128382811', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh81', N'Hà Nội', N'09999999811', N'0999999981', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT812', N'Nguyễn Văn ', N'A812', NULL, CAST(N'1981-06-09' AS Date), N'P81', N'128382812', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh81', N'Hà Nội', N'09999999812', N'0999999981', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT813', N'Nguyễn Văn ', N'A813', NULL, CAST(N'1981-06-09' AS Date), N'P81', N'128382813', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh81', N'Hà Nội', N'09999999813', N'0999999981', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT817', N'Nguyễn Văn', N'Long', 0x, CAST(N'1993-06-10' AS Date), N'P100', N'122991122', N'Hà Long', CAST(N'2015-05-26' AS Date), N'Hồ Chí Minh', N'Hồ Chí Minh', N'22222', N'112', 1, 10, N'', CAST(N'2015-06-26' AS Date), NULL, 1, 7, 1, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT818', N'Nguyễn Thanh', N'Hà', NULL, CAST(N'2015-01-13' AS Date), N'P100', N'123', N'Lý Nhân- Hà Nam', CAST(N'2015-02-18' AS Date), N'Chính lý Hà Nam', N'Chính lý Hà Nam', N'019239', N'2233', 1, 0, N'P02', CAST(N'2015-06-10' AS Date), CAST(N'2015-06-10' AS Date), 1, 7, 1, N'Nam', N'121')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT819', N'Nguyễn Văn ', N'A819', NULL, CAST(N'1982-06-09' AS Date), N'P82', N'128382819', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh82', N'Hà Nội', N'09999999819', N'0999999982', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT82', N'Nguyễn Văn ', N'A82', NULL, CAST(N'1982-06-09' AS Date), N'P82', N'12838282', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh82', N'Hà Nội', N'0999999982', N'0999999982', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT820', N'Nguyễn Văn ', N'A820', NULL, CAST(N'1982-06-09' AS Date), N'P82', N'128382820', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh82', N'Hà Nội', N'09999999820', N'0999999982', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT821', N'Nguyễn Văn ', N'A821', NULL, CAST(N'1982-06-09' AS Date), N'P82', N'128382821', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh82', N'Hà Nội', N'09999999821', N'0999999982', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT822', N'Nguyễn Văn ', N'A822', NULL, CAST(N'1982-06-09' AS Date), N'P82', N'128382822', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh82', N'Hà Nội', N'09999999822', N'0999999982', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT828', N'Nguyễn Văn ', N'A828', NULL, CAST(N'1983-06-09' AS Date), N'P83', N'128382828', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh83', N'Hà Nội', N'09999999828', N'0999999983', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT829', N'Nguyễn Văn ', N'A829', NULL, CAST(N'1983-06-09' AS Date), N'P83', N'128382829', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh83', N'Hà Nội', N'09999999829', N'0999999983', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT83', N'Nguyễn Văn ', N'A83', NULL, CAST(N'1983-06-09' AS Date), N'P83', N'12838283', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh83', N'Hà Nội', N'0999999983', N'0999999983', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT830', N'Nguyễn Văn ', N'A830', NULL, CAST(N'1983-06-09' AS Date), N'P83', N'128382830', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh83', N'Hà Nội', N'09999999830', N'0999999983', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT831', N'Nguyễn Văn ', N'A831', NULL, CAST(N'1983-06-09' AS Date), N'P83', N'128382831', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh83', N'Hà Nội', N'09999999831', N'0999999983', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT837', N'Nguyễn Văn ', N'A837', NULL, CAST(N'1984-06-09' AS Date), N'P84', N'128382837', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh84', N'Hà Nội', N'09999999837', N'0999999984', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT838', N'Nguyễn Văn ', N'A838', NULL, CAST(N'1984-06-09' AS Date), N'P84', N'128382838', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh84', N'Hà Nội', N'09999999838', N'0999999984', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT839', N'Nguyễn Văn ', N'A839', NULL, CAST(N'1984-06-09' AS Date), N'P84', N'128382839', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh84', N'Hà Nội', N'09999999839', N'0999999984', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT84', N'Nguyễn Văn ', N'A84', NULL, CAST(N'1984-06-09' AS Date), N'P84', N'12838284', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh84', N'Hà Nội', N'0999999984', N'0999999984', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT840', N'Nguyễn Văn ', N'A840', NULL, CAST(N'1984-06-09' AS Date), N'P84', N'128382840', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh84', N'Hà Nội', N'09999999840', N'0999999984', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT846', N'Nguyễn Văn ', N'A846', NULL, CAST(N'1985-06-09' AS Date), N'P85', N'128382846', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh85', N'Hà Nội', N'09999999846', N'0999999985', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT847', N'Nguyễn Văn ', N'A847', NULL, CAST(N'1985-06-09' AS Date), N'P85', N'128382847', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh85', N'Hà Nội', N'09999999847', N'0999999985', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT848', N'Nguyễn Văn ', N'A848', NULL, CAST(N'1985-06-09' AS Date), N'P85', N'128382848', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh85', N'Hà Nội', N'09999999848', N'0999999985', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT849', N'Nguyễn Văn ', N'A849', NULL, CAST(N'1985-06-09' AS Date), N'P85', N'128382849', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh85', N'Hà Nội', N'09999999849', N'0999999985', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT85', N'Nguyễn Văn ', N'A85', NULL, CAST(N'1985-06-09' AS Date), N'P85', N'12838285', N'', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh85', N'Hà Nội', N'0999999985', N'0999999985', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT855', N'Nguyễn Văn ', N'A855', NULL, CAST(N'1986-06-09' AS Date), N'P86', N'128382855', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh86', N'Hà Nội', N'09999999855', N'0999999986', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT856', N'Nguyễn Văn ', N'A856', NULL, CAST(N'1986-06-09' AS Date), N'P86', N'128382856', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh86', N'Hà Nội', N'09999999856', N'0999999986', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT857', N'Nguyễn Văn ', N'A857', NULL, CAST(N'1986-06-09' AS Date), N'P86', N'128382857', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh86', N'Hà Nội', N'09999999857', N'0999999986', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT858', N'Nguyễn Văn ', N'A858', NULL, CAST(N'1986-06-09' AS Date), N'P86', N'128382858', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh86', N'Hà Nội', N'09999999858', N'0999999986', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT859', N'Nguyễn Văn ', N'A859', NULL, CAST(N'1986-06-09' AS Date), N'P86', N'128382859', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh86', N'Hà Nội', N'09999999859', N'0999999986', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT864', N'Nguyễn Văn ', N'A864', NULL, CAST(N'1987-06-09' AS Date), N'P87', N'128382864', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh87', N'Hà Nội', N'09999999864', N'0999999987', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT865', N'Nguyễn Văn ', N'A865', NULL, CAST(N'1987-06-09' AS Date), N'P87', N'128382865', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh87', N'Hà Nội', N'09999999865', N'0999999987', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT866', N'Nguyễn Văn ', N'A866', NULL, CAST(N'1987-06-09' AS Date), N'P87', N'128382866', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh87', N'Hà Nội', N'09999999866', N'0999999987', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT867', N'Nguyễn Văn ', N'A867', NULL, CAST(N'1987-06-09' AS Date), N'P87', N'128382867', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh87', N'Hà Nội', N'09999999867', N'0999999987', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT868', N'Nguyễn Văn ', N'A868', NULL, CAST(N'1987-06-09' AS Date), N'P87', N'128382868', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh87', N'Hà Nội', N'09999999868', N'0999999987', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT873', N'Nguyễn Văn ', N'A873', NULL, CAST(N'1988-06-09' AS Date), N'P88', N'128382873', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh88', N'Hà Nội', N'09999999873', N'0999999988', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT874', N'Nguyễn Văn ', N'A874', NULL, CAST(N'1988-06-09' AS Date), N'P88', N'128382874', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh88', N'Hà Nội', N'09999999874', N'0999999988', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT875', N'Nguyễn Văn ', N'A875', NULL, CAST(N'1988-06-09' AS Date), N'P88', N'128382875', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh88', N'Hà Nội', N'09999999875', N'0999999988', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT876', N'Nguyễn Văn ', N'A876', NULL, CAST(N'1988-06-09' AS Date), N'P88', N'128382876', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh88', N'Hà Nội', N'09999999876', N'0999999988', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT877', N'Nguyễn Văn ', N'A877', NULL, CAST(N'1988-06-09' AS Date), N'P88', N'128382877', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh88', N'Hà Nội', N'09999999877', N'0999999988', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT882', N'Nguyễn Văn ', N'A882', NULL, CAST(N'1989-06-09' AS Date), N'P89', N'128382882', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh89', N'Hà Nội', N'09999999882', N'0999999989', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT883', N'Nguyễn Văn ', N'A883', NULL, CAST(N'1989-06-09' AS Date), N'P89', N'128382883', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh89', N'Hà Nội', N'09999999883', N'0999999989', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
GO
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT884', N'Nguyễn Văn ', N'A884', NULL, CAST(N'1989-06-09' AS Date), N'P89', N'128382884', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh89', N'Hà Nội', N'09999999884', N'0999999989', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT885', N'Nguyễn Văn ', N'A885', NULL, CAST(N'1989-06-09' AS Date), N'P89', N'128382885', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh89', N'Hà Nội', N'09999999885', N'0999999989', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT886', N'Nguyễn Văn ', N'A886', NULL, CAST(N'1989-06-09' AS Date), N'P89', N'128382886', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh89', N'Hà Nội', N'09999999886', N'0999999989', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT891', N'Nguyễn Văn ', N'A891', NULL, CAST(N'1990-06-09' AS Date), N'P90', N'128382891', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh90', N'Hà Nội', N'09999999891', N'0999999990', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT892', N'Nguyễn Văn ', N'A892', NULL, CAST(N'1990-06-09' AS Date), N'P90', N'128382892', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh90', N'Hà Nội', N'09999999892', N'0999999990', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT893', N'Nguyễn Văn ', N'A893', NULL, CAST(N'1990-06-09' AS Date), N'P90', N'128382893', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh90', N'Hà Nội', N'09999999893', N'0999999990', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT894', N'Nguyễn Văn ', N'A894', NULL, CAST(N'1990-06-09' AS Date), N'P90', N'128382894', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh90', N'Hà Nội', N'09999999894', N'0999999990', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT895', N'Nguyễn Văn ', N'A895', NULL, CAST(N'1990-06-09' AS Date), N'P90', N'128382895', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh90', N'Hà Nội', N'09999999895', N'0999999990', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nam', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT91', N'Nguyễn Văn ', N'A91', NULL, CAST(N'1901-06-09' AS Date), N'P01', N'12838291', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh01', N'Hà Nội', N'0999999991', N'0999999901', 5, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT92', N'Nguyễn Văn ', N'A92', NULL, CAST(N'1901-06-09' AS Date), N'P01', N'12838292', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh01', N'Hà Nội', N'0999999992', N'0999999901', 4, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT93', N'Nguyễn Văn ', N'A93', NULL, CAST(N'1901-06-09' AS Date), N'P01', N'12838293', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh01', N'Hà Nội', N'0999999993', N'0999999901', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 1, 7, 0, N'Nữ', N'')
INSERT [dbo].[KhachTro] ([MaKhachTro], [HoLot], [Ten], [Anh], [NgaySinh], [MaPhong], [CMND], [NoiCap], [NgayCap], [ThuongTru], [TamTru], [SDTLienHe], [SDT], [MaDanToc], [MaTonGiao], [MaPhongCu], [NgayVao], [NgayRa], [HoatDong], [MaTrangThai], [TruongPhong], [GioiTinh], [GhiChu]) VALUES (N'KT94', N'Nguyễn Văn ', N'A94', NULL, CAST(N'1901-06-09' AS Date), N'P01', N'12838294', N'Hồ Chí Minh', CAST(N'2000-06-09' AS Date), N'tp Hồ Chí Minh01', N'Hà Nội', N'0999999994', N'0999999901', 1, 0, N'', CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 0, 7, 0, N'Nữ', N'')
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu1', N'Khu 1', N'', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu10', N'Khu 10', N' ', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu2', N'Khu 2', N'', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu3', N'Khu 3', N'', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu4', N'Khu 4', N'', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu5', N'Khu 5', N'', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu6', N'Khu 6', N'', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu7', N'Khu 7', N'', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu8', N'Khu 8', N' ', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [GhiChu], [HoatDong]) VALUES (N'Khu9', N'Khu 9', N' ', 1)
SET IDENTITY_INSERT [dbo].[KyLuat] ON 

INSERT [dbo].[KyLuat] ([id], [MaPhong], [MaHinhThucKyLuat], [NgayKyLuat], [GhiChu]) VALUES (1, N'Phong909', N'02', CAST(N'2015-05-21T00:00:00.000' AS DateTime), N'')
INSERT [dbo].[KyLuat] ([id], [MaPhong], [MaHinhThucKyLuat], [NgayKyLuat], [GhiChu]) VALUES (2, N'PK3_Khu1', N'02', CAST(N'2015-06-05T00:00:00.000' AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[KyLuat] OFF
SET IDENTITY_INSERT [dbo].[NhatKy] ON 

INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10216, N'admin', N'Jun  9 2015  3:10PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10217, N'admin', N'Jun  9 2015  3:12PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10218, N'admin', N'Jun  9 2015  3:12PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10219, N'admin', N'Jun  9 2015  3:13PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10220, N'admin', N'Jun  9 2015  3:16PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10221, N'admin', N'Jun  9 2015  3:17PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10222, N'admin', N'Jun  9 2015  3:19PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10223, N'admin', N'Jun  9 2015  3:23PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10224, N'admin', N'Jun  9 2015  3:23PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10225, N'admin', N'Jun  9 2015  3:25PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10226, N'admin', N'Jun  9 2015  3:28PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10227, N'admin', N'Jun  9 2015  3:28PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10228, N'admin', N'Jun  9 2015  3:34PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10229, N'admin', N'Jun  9 2015  3:34PM', N'Sửa điện nước theo chỉ số', N'Sửa điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10230, N'admin', N'Jun  9 2015  3:38PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10231, N'admin', N'Jun  9 2015  3:44PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10232, N'admin', N'Jun  9 2015  4:02PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10233, N'admin', N'Jun  9 2015  4:02PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10234, N'admin', N'Jun  9 2015  4:02PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10235, N'admin', N'Jun  9 2015  4:02PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10236, N'admin', N'Jun  9 2015  4:02PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10237, N'admin', N'Jun  9 2015  4:02PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10238, N'admin', N'Jun  9 2015  4:02PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10239, N'admin', N'Jun  9 2015  4:02PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10240, N'admin', N'Jun  9 2015  4:02PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10241, N'admin', N'Jun  9 2015  4:32PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10242, N'admin', N'Jun  9 2015  4:36PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10243, N'admin', N'Jun  9 2015  4:37PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10244, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10245, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10246, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10247, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10248, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10249, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10250, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10251, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10252, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10253, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10254, N'admin', N'Jun  9 2015  4:37PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10255, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10256, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10257, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10258, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10259, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10260, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10261, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10262, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10263, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10264, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10265, N'admin', N'Jun  9 2015  4:41PM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10266, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10267, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10268, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10269, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10270, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10271, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10272, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10273, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10274, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10275, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10276, N'admin', N'Jun  9 2015  4:41PM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10277, N'admin', N'Jun  9 2015  5:08PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10278, N'admin', N'Jun  9 2015  5:13PM', N'Xem danh sách quản lý vật tư.', N'', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10279, N'admin', N'Jun  9 2015  5:15PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10280, N'admin', N'Jun  9 2015  5:41PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10281, N'admin', N'Jun  9 2015  5:45PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10282, N'admin', N'Jun  9 2015  5:45PM', N'Thêm khách 1', N'Thêm khách', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10283, N'admin', N'Jun 10 2015  2:43PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10284, N'admin', N'Jun 10 2015  2:44PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10285, N'admin', N'Jun 10 2015  2:47PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10286, N'admin', N'Jun 10 2015  2:50PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10287, N'admin', N'Jun 10 2015  2:57PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10288, N'admin', N'Jun 10 2015  2:59PM', N'Xóa sinh viên (Thùng rác) KT94', N'Xóa sinh viên', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10289, N'admin', N'Jun 10 2015  3:04PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10290, N'admin', N'Jun 10 2015  3:07PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10291, N'admin', N'Jun 10 2015  3:11PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10292, N'admin', N'Jun 10 2015  4:04PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10293, N'admin', N'Jun 10 2015  4:19PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10294, N'admin', N'Jun 11 2015  8:55AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10295, N'admin', N'Jun 11 2015  9:07AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10296, N'admin', N'Jun 11 2015  9:09AM', N'Xem danh sách quản lý vật tư.', N'', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10297, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10298, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10299, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10300, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10301, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10302, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10303, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10304, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10305, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10306, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10307, N'admin', N'Jun 11 2015  9:20AM', N'Xóa danh sách điện nước theo chỉ số', N'Xóa danh sách điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10308, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10309, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10310, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10311, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10312, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10313, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10314, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
GO
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10315, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10316, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10317, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10318, N'admin', N'Jun 11 2015  9:20AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10319, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10320, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10321, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10322, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10323, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10324, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10325, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10326, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10327, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10328, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10329, N'admin', N'Jun 11 2015  9:22AM', N'Thêm điện nước theo chỉ số', N'Thêm điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10330, N'admin', N'Jun 11 2015  9:22AM', N'Sửa điện nước theo chỉ số', N'Sửa điện nước theo chỉ số', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10331, N'admin', N'Jun 11 2015  9:28AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10332, N'admin', N'Jun 11 2015 10:12AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10333, N'admin', N'Jun 11 2015  2:37PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10334, N'admin', N'Jun 11 2015  3:52PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10335, N'admin', N'Jun 11 2015  6:15PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'D4BED95190BC')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10336, N'admin', N'Jun 11 2015  9:59PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10337, N'admin', N'Jun 11 2015 10:00PM', N'Xem danh sách quản lý vật tư.', N'', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10338, N'admin', N'Jun 11 2015 10:02PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10339, N'admin', N'Jun 11 2015 10:03PM', N'Sửa điện nước theo chỉ số', N'Sửa điện nước theo chỉ số', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10340, N'admin', N'Jun 11 2015 10:08PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10341, N'admin', N'Jun 11 2015 10:09PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10342, N'binh', N'Jun 11 2015 10:11PM', N'Tài khoản binh đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10343, N'binh', N'Jun 11 2015 10:11PM', N'Tài khoản binh đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10344, N'admin', N'Jun 11 2015 10:12PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10345, N'admin', N'Jun 11 2015 10:13PM', N'Xóa sinh viên (Thùng rác) KT110', N'Xóa sinh viên', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10346, N'admin', N'Jun 11 2015 10:19PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10347, N'admin', N'Jun 11 2015 10:25PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10348, N'admin', N'Jun 11 2015 10:28PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10349, N'admin', N'Jun 11 2015 10:56PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10350, N'admin', N'Jun 11 2015 10:57PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10351, N'admin', N'Jun 11 2015 11:44PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'84A6C83F47B0')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10352, N'admin', N'Jun 12 2015  8:26AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10353, N'admin', N'Jun 12 2015  8:28AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10354, N'admin', N'Jun 12 2015  8:30AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10355, N'admin', N'Jun 12 2015  8:31AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10356, N'admin', N'Jun 12 2015  8:33AM', N'Thêm khách 453543', N'Thêm khách', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10357, N'admin', N'Jun 12 2015  8:35AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10358, N'admin', N'Jun 12 2015  8:39AM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính THANHBINH', N'THANHBINH', N'')
INSERT [dbo].[NhatKy] ([STT], [TenDangNhap], [Ngay], [TacVu], [ChiTiet], [TenMayTinh], [MacAddress]) VALUES (10359, N'admin', N'May 24 2017 10:02PM', N'Tài khoản admin đăng nhập vào hệ thống.', N'Máy tính DESKTOP-6525FJ7', N'DESKTOP-6525FJ7', N'20689DE1F665')
SET IDENTITY_INSERT [dbo].[NhatKy] OFF
SET IDENTITY_INSERT [dbo].[Options] ON 

INSERT [dbo].[Options] ([Id], [HoTenChuTro], [NgaySinh], [CMND], [NgayCap], [NoiCap], [ThuongTru], [GiaTienPhong], [GiaTienDien], [GiaTienNuoc], [TenFileBackup], [LuufileBackup], [LuufileRestore]) VALUES (1, N'Nguyễn Minh Tư', CAST(N'1994-02-02' AS Date), N'215343679', CAST(N'2010-11-10' AS Date), N'CA Bình Định', N'Hoài Thanh- Hoài Nhơn-Bình Định', 1500000, 2500, 15000, N'QLNT', N'D:\', N'D:\')
SET IDENTITY_INSERT [dbo].[Options] OFF
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P01', N'Khu1', N'Phòng 1', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P02', N'Khu1', N'Phòng 2', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P03', N'Khu1', N'Phòng 3', 4, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P04', N'Khu1', N'Phòng 4', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P05', N'Khu1', N'Phòng 5', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2016-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P06', N'Khu1', N'Phòng 6', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P07', N'Khu1', N'Phòng 7', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P08', N'Khu1', N'Phòng 8', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P09', N'Khu1', N'Phòng 9', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P10', N'Khu1', N'Phòng 10', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P100', N'Khu10', N'Phòng 100', 2, N'', 1, 1300000, 3, CAST(N'2015-06-10' AS Date), CAST(N'2015-06-28' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P101', N'Khu1', N'Phòng 101', 0, N'', 1, 1300000, NULL, NULL, NULL)
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P11', N'Khu2', N'Phòng 11', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P12', N'Khu2', N'Phòng 12', 5, N'', 1, 1300000, 5, CAST(N'2015-12-12' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P13', N'Khu2', N'Phòng 13', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P14', N'Khu2', N'Phòng 14', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P15', N'Khu2', N'Phòng 15', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P16', N'Khu2', N'Phòng 16', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P17', N'Khu3', N'Phòng 17', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P18', N'Khu3', N'Phòng 18', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P19', N'Khu3', N'Phòng 19', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P20', N'Khu3', N'Phòng 20', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P21', N'Khu3', N'Phòng 21', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P22', N'Khu3', N'Phòng 22', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P23', N'Khu3', N'Phòng 23', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P24', N'Khu3', N'Phòng 24', 0, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P25', N'Khu3', N'Phòng 25', 5, N'', 1, 1300000, 5, CAST(N'2015-12-12' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P26', N'Khu3', N'Phòng 26', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P27', N'Khu3', N'Phòng 27', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P28', N'Khu4', N'Phòng 28', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P29', N'Khu4', N'Phòng 29', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P30', N'Khu4', N'Phòng 30', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P31', N'Khu4', N'Phòng 31', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P32', N'Khu4', N'Phòng 32', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P33', N'Khu4', N'Phòng 33', 5, N'', 1, 1300000, 5, CAST(N'2015-12-12' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P34', N'Khu4', N'Phòng 34', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P35', N'Khu4', N'Phòng 35', 5, N'', 1, 1300000, 5, CAST(N'2015-12-12' AS Date), CAST(N'2016-06-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P36', N'Khu4', N'Phòng 36', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P37', N'Khu4', N'Phòng 37', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P38', N'Khu5', N'Phòng 38', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P39', N'Khu5', N'Phòng 39', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P40', N'Khu5', N'Phòng 40', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P41', N'Khu5', N'Phòng 41', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P42', N'Khu5', N'Phòng 42', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P43', N'Khu5', N'Phòng 43', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P44', N'Khu5', N'Phòng 44', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P45', N'Khu5', N'Phòng 45', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P46', N'Khu5', N'Phòng 46', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P47', N'Khu5', N'Phòng 47', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P48', N'Khu6', N'Phòng 48', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P49', N'Khu6', N'Phòng 49', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P50', N'Khu6', N'Phòng 50', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P51', N'Khu6', N'Phòng 51', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P52', N'Khu6', N'Phòng 52', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P53', N'Khu6', N'Phòng 53', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P54', N'Khu6', N'Phòng 54', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P55', N'Khu6', N'Phòng 55', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P56', N'Khu6', N'Phòng 56', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P57', N'Khu6', N'Phòng 57', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P58', N'Khu6', N'Phòng 58', 0, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P59', N'Khu6', N'Phòng 59', 0, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P60', N'Khu6', N'Phòng 60', 0, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P61', N'Khu6', N'Phòng 61', 0, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P62', N'Khu6', N'Phòng 62', 0, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P63', N'Khu6', N'Phòng 63', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P64', N'Khu6', N'Phòng 64', 0, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P65', N'Khu6', N'Phòng 65', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P66', N'Khu6', N'Phòng 66', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P67', N'Khu6', N'Phòng 67', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P68', N'Khu7', N'Phòng 68', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P69', N'Khu7', N'Phòng 69', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P70', N'Khu7', N'Phòng 70', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P71', N'Khu7', N'Phòng 71', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P72', N'Khu7', N'Phòng 72', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P73', N'Khu7', N'Phòng 73', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P74', N'Khu7', N'Phòng 74', 0, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P75', N'Khu7', N'Phòng 75', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P76', N'Khu8', N'Phòng 76', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P77', N'Khu8', N'Phòng 77', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P78', N'Khu8', N'Phòng 78', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P79', N'Khu8', N'Phòng 79', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P80', N'Khu8', N'Phòng 80', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P81', N'Khu9', N'Phòng 81', 5, N'', 1, 1300000, 5, CAST(N'2014-03-03' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P82', N'Khu9', N'Phòng 82', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-05-06' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P83', N'Khu9', N'Phòng 83', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2016-03-03' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P84', N'Khu9', N'Phòng 84', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P85', N'Khu9', N'Phòng 85', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P86', N'Khu9', N'Phòng 86', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P87', N'Khu9', N'Phòng 87', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P88', N'Khu9', N'Phòng 88', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P89', N'Khu9', N'Phòng 89', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
INSERT [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [SoNguoi], [GhiChu], [HoatDong], [GiaPhong], [TongNguoi], [TuNgay], [ToiNgay]) VALUES (N'P90', N'Khu9', N'Phòng 90', 5, N'', 1, 1300000, 5, CAST(N'2015-05-01' AS Date), CAST(N'2015-12-12' AS Date))
SET IDENTITY_INSERT [dbo].[QuanLyVatTu] ON 

INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (3, N'04N', N'ĐÈN NEON 0,6', 10, CAST(N'2015-03-28' AS Date), 0, 1, N'')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10002, N'05N', N'VÒI NƯỚC WC', 4, CAST(N'2015-04-17' AS Date), 1, 0, N'DFDF')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10003, N'103C', N'Đèn cầy', 1, CAST(N'2015-04-03' AS Date), 1, 0, N'')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10004, N'02N', N'THÔNG NGHẸT', 4, CAST(N'2015-04-16' AS Date), 0, 1, N'')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10005, N'05N', N'ĐÈN COMPACT NHÀ TẮM', 1, CAST(N'2015-05-04' AS Date), 1, 0, N'')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10006, N'101A', N'CÔNG TẮC NỔI', 8, CAST(N'2015-05-09' AS Date), 1, 1, N'')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10007, N'Phong001', N'CÔNG TẮC NỔI', 1, CAST(N'2015-05-19' AS Date), 0, 1, N'a')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10008, N'Phong001', N'CÔNG TẮC NỔI', 12, CAST(N'2015-05-22' AS Date), 0, 1, N'21')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10009, N'P05', N'ĐÈN NEON 0,6', 5, CAST(N'2015-06-09' AS Date), 1, 1, N'')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10010, N'P11', N'VÒI NƯỚC WC', 3, CAST(N'2015-06-09' AS Date), 0, 1, N'')
INSERT [dbo].[QuanLyVatTu] ([ID], [MaPhong], [TenVatTu], [SoLuong], [NgaySuaChua], [SuaChua], [ThayThe], [GhiChu]) VALUES (10011, N'P13', N'VÒI NƯỚC WC', 0, CAST(N'2015-06-09' AS Date), 1, 1, N'')
SET IDENTITY_INSERT [dbo].[QuanLyVatTu] OFF
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'1', N'Hệ thống', NULL, NULL, N'0', 0)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'2', N'Quản lý khách trọ', NULL, NULL, N'0', 0)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'3', N'Quản lý phòng - khu', NULL, NULL, N'0', 0)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'4', N'Quản lý điện - nước', NULL, NULL, N'0', 0)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'5', N'Giao diện', NULL, NULL, N'1', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'6', N'Đổi mật khẩu', NULL, NULL, N'1', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'7', N'Thiết lập', NULL, NULL, N'1', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'8', N'Sao chép dữ liệu', NULL, NULL, N'1', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'9', N'Phục hồi dữ liệu', NULL, NULL, N'1', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'10', N'Lịch sử truy cập', NULL, NULL, N'1', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'11', N'Đăng xuất', NULL, NULL, N'1', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'12', N'Danh sách người dùng', NULL, NULL, N'1', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'13', N'Danh sách nhóm quyền', NULL, NULL, N'1', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'14', N'Danh sách khách trọ', NULL, N'', N'2', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'15', N'Danh sách kỷ luật', NULL, NULL, N'2', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'16', N'Danh mục', NULL, NULL, N'2', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'17', N'Danh sách phòng', NULL, NULL, N'3', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'18', N'Danh sách khu', NULL, NULL, N'3', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'19', N'Quản lý tiền phòng', NULL, NULL, N'4', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'20', N'Quản lý tiền điện nước', NULL, NULL, N'4', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'21', N'Hóa Đơn', NULL, NULL, N'4', 1)
INSERT [dbo].[SysChucNang] ([MaChucNang], [TenChucNang], [MoTa], [ChucNangGoc], [CapCha], [Cap]) VALUES (N'22', N'Quản lý vật tư', NULL, NULL, N'4', 1)
INSERT [dbo].[SysNhomQuyen] ([MaNhom], [TenNhom], [DienGiai], [HoatDong]) VALUES (N'NQ01', N'Admin', N'', 1)
INSERT [dbo].[SysNhomQuyen] ([MaNhom], [TenNhom], [DienGiai], [HoatDong]) VALUES (N'NQ02', N'CSDL', N'', 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'10', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'11', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'12', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'13', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'14', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'15', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'16', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'17', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'18', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'19', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'2', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'20', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'21', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'22', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'23', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'24', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'25', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'26', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'27', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'28', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'3', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'4', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'5', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'6', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'7', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'8', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ01', N'9', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'10', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'11', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'12', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'13', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'14', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'15', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'16', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'17', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'18', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'19', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'2', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'20', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'21', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'22', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'23', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'24', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'25', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'26', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'27', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'28', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'3', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'4', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'5', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'6', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'7', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'8', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysQuyenSuDung] ([MaNhom], [MaChucNang], [MaThaoTac], [TatCa], [Them], [Xoa], [Sua], [TruyCap], [InAn], [XuatDuLieu], [NhapDuLieu], [HoatDong]) VALUES (N'NQ02', N'9', 0, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SysUser] ([ID], [TaiKhoan], [HoTen], [MatKhau], [MaNhom], [Email], [DienGiai], [HoatDong]) VALUES (N'1', N'admin', N'Khoa', N'21232f297a57a5a743894a0e4a801fc3', N'NQ01', N'1', N'1', 1)
INSERT [dbo].[SysUser] ([ID], [TaiKhoan], [HoTen], [MatKhau], [MaNhom], [Email], [DienGiai], [HoatDong]) VALUES (N'ND01', N'binh', N'nguyễn thanh bình', N'21232f297a57a5a743894a0e4a801fc3', N'NQ02', N'ntbinh1001@gmail.com', N'nhân viên', 1)
INSERT [dbo].[SysUser] ([ID], [TaiKhoan], [HoTen], [MatKhau], [MaNhom], [Email], [DienGiai], [HoatDong]) VALUES (N'ND02', N'phong', N'Phạm Lê Phong', N'81dc9bdb52d04dc20036dbd8313ed055', N'NQ02', N'phamlephong@gmail.com', N'nhanvien', 1)
INSERT [dbo].[ThongTinDongTien] ([MaLoaiTien], [TenLoaiTien], [SoTienDong], [GhiChu]) VALUES (N'0', N'Tiền Phòng ở', 1800000, N'Tiền đóng phòng ở trong 1 năm')
INSERT [dbo].[ThongTinDongTien] ([MaLoaiTien], [TenLoaiTien], [SoTienDong], [GhiChu]) VALUES (N'1', N'Tiền bảo trì thiết bị', 120000, N'Tiền đóng để sửa thiết bị cho phòng khi hỏng')
INSERT [dbo].[ThongTinDongTien] ([MaLoaiTien], [TenLoaiTien], [SoTienDong], [GhiChu]) VALUES (N'3', N'Tiền vệ sinh', 100000, N'đóng quét vệ sinh')
INSERT [dbo].[ThongTinDongTien] ([MaLoaiTien], [TenLoaiTien], [SoTienDong], [GhiChu]) VALUES (N'4', N'Tiền rác', 10000, N'')
INSERT [dbo].[ThongTinDongTien] ([MaLoaiTien], [TenLoaiTien], [SoTienDong], [GhiChu]) VALUES (N'LT002', N'Tiền phòng1', 1000, N'')
SET IDENTITY_INSERT [dbo].[Tien] ON 

INSERT [dbo].[Tien] ([ID], [MaPhong], [MaLoaiTien], [NgayDong], [GhiChu], [TongTien], [Thang], [Nam]) VALUES (2025, N'P01', N'1, 3, 4', CAST(N'2015-06-10T00:00:00.000' AS DateTime), N'', 230000, 5, 2015)
INSERT [dbo].[Tien] ([ID], [MaPhong], [MaLoaiTien], [NgayDong], [GhiChu], [TongTien], [Thang], [Nam]) VALUES (2026, N'P02', N'1, 3', NULL, N'', 220000, 5, 2015)
INSERT [dbo].[Tien] ([ID], [MaPhong], [MaLoaiTien], [NgayDong], [GhiChu], [TongTien], [Thang], [Nam]) VALUES (2027, N'P03', N'0, 1', NULL, N'', 1920000, 5, 2015)
INSERT [dbo].[Tien] ([ID], [MaPhong], [MaLoaiTien], [NgayDong], [GhiChu], [TongTien], [Thang], [Nam]) VALUES (2028, N'P04', N'0, 3', NULL, N'', 1900000, 5, 2015)
INSERT [dbo].[Tien] ([ID], [MaPhong], [MaLoaiTien], [NgayDong], [GhiChu], [TongTien], [Thang], [Nam]) VALUES (2029, N'P05', N'0, 4', CAST(N'2015-06-01T00:00:00.000' AS DateTime), N'', 1810000, 5, 2015)
INSERT [dbo].[Tien] ([ID], [MaPhong], [MaLoaiTien], [NgayDong], [GhiChu], [TongTien], [Thang], [Nam]) VALUES (2030, N'P09', N'0, 3', NULL, N'', 1900000, 5, 2015)
SET IDENTITY_INSERT [dbo].[Tien] OFF
SET IDENTITY_INSERT [dbo].[TonGiao] ON 

INSERT [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu]) VALUES (0, N'Không', N'Không có tôn giáo.')
INSERT [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu]) VALUES (1, N'Phật Giáo', NULL)
INSERT [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu]) VALUES (2, N'Công Giáo', N'-')
INSERT [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu]) VALUES (3, N'Hòa Hảo', NULL)
INSERT [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu]) VALUES (4, N'Hồi Giáo', NULL)
INSERT [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu]) VALUES (5, N'Cao Đài', NULL)
INSERT [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu]) VALUES (6, N'Minh Sư Đạo', NULL)
INSERT [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu]) VALUES (9, N'Thiên Chúa', NULL)
INSERT [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu]) VALUES (10, N'Bà La Môn', NULL)
SET IDENTITY_INSERT [dbo].[TonGiao] OFF
SET IDENTITY_INSERT [dbo].[TrangThai] ON 

INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai], [GhiChu]) VALUES (6, N'Tấc cả', NULL)
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai], [GhiChu]) VALUES (7, N'Đang ở', NULL)
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai], [GhiChu]) VALUES (9, N'Không còn ở', NULL)
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai], [GhiChu]) VALUES (10, N'Kỷ luật', NULL)
SET IDENTITY_INSERT [dbo].[TrangThai] OFF
SET IDENTITY_INSERT [dbo].[VatTu] ON 

INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu], [GhiChu]) VALUES (3, N'Ổ CẮM ĐIỆN NỔI1', N'')
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu], [GhiChu]) VALUES (4, N'CÔNG TẮC NỔI', NULL)
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu], [GhiChu]) VALUES (5, N'ĐỀN TRẦN', N'-')
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu], [GhiChu]) VALUES (7, N'VÒI NƯỚC WC', NULL)
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu], [GhiChu]) VALUES (8, N'THÔNG NGHẸT', NULL)
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu], [GhiChu]) VALUES (9, N'ĐÈN NEON 0,6', NULL)
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu], [GhiChu]) VALUES (10, N'ĐÈN COMPACT NHÀ VS', NULL)
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu], [GhiChu]) VALUES (11, N'ĐÈN COMPACT NHÀ TẮM', NULL)
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu], [GhiChu]) VALUES (12, N'ĐÈN COMPACT1', N'')
SET IDENTITY_INSERT [dbo].[VatTu] OFF
ALTER TABLE [dbo].[GuiEmail] ADD  DEFAULT (N'[Phần Mềm Quản Lý Ký Túc Xá]') FOR [TieuDe]
GO
ALTER TABLE [dbo].[GuiEmail] ADD  DEFAULT (N'Thông tin') FOR [NoiDung]
GO
ALTER TABLE [dbo].[GuiEmail] ADD  DEFAULT ((0)) FOR [Gui]
GO
/****** Object:  StoredProcedure [dbo].[Backup_auto]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Backup_auto]
as
begin
	declare  @bk nvarchar(500);
	set @bk='D:\Dropbox\QLKTX\';
	set @bk=@bk+convert(nvarchar(19),getdate(),105)+'_qlktx.bak';
	backup database QLKTX to disk =@bk with init,stats=10
end

GO
/****** Object:  StoredProcedure [dbo].[NT_SP_Count_SV_Inroom]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- SELECT * FROM PHONG
-- EXEC [dbo].[KTX_SP_Count_SV_Inroom] '307C'
CREATE   Proc [dbo].[NT_SP_Count_SV_Inroom]
(
	 @maphong nvarchar(100) 
)
AS 
BEGIN
	SELECT COUNT(SV.MASV) AS SISO
	FROM KhachTro AS SV(NOLOCK)
	WHERE SV.MAPHONG=@maphong
END

-----------------



GO
/****** Object:  StoredProcedure [dbo].[NT_SP_DELETE_ALL_NHATKY]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NT_SP_DELETE_ALL_NHATKY]
AS 
BEGIN
		DELETE FROM NHATKY	
END
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_DEM_THONGKE_NAM_NU]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	STORE THONG KE SO SINH VIEN NAM VA NU
	[dbo].[KTX_SP_DEM_THONGKE_NAM_NU]
*/
CREATE PROC [dbo].[NT_SP_DEM_THONGKE_NAM_NU]
AS
BEGIN
	SELECT GioiTinh,COUNT(GioiTinh) TongSo
	 FROM dbo.KhachTro
	 WHERE  HoatDong=1
	 GROUP BY GioiTinh
END



GO
/****** Object:  StoredProcedure [dbo].[NT_SP_DemSoNguoi]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NT_SP_DemSoNguoi]
(
 @maphong NVARCHAR(50)
)
AS 
BEGIN
DECLARE @i INT=0;
	SELECT @i=COUNT(MaKhachTro) FROM dbo.KhachTro WHERE MaPhong=@maphong AND HoatDong=1
	UPDATE dbo.Phong SET SoNguoi=@i WHERE MaPhong=@maphong
END
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_HOADONTIENPHONG]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NT_SP_HOADONTIENPHONG] @ID BIGINT
AS
	BEGIN
	SELECT p.TenPhong,
	 t.TongTien AS TienPhong,
	 h.TongTien AS TongTien,
	 (CASE WHEN d.SoDienCu IS NULL THEN 0 ELSE d.SoDienCu END) AS SoDienCu,
	 (CASE WHEN d.SoDienMoi IS NULL THEN 0 ELSE d.SoDienMoi END) AS SoDienMoi,
	 (CASE WHEN d.SoDienTieuThu IS NULL THEN 0 ELSE d.SoDienTieuThu END) AS SoDienTieuThu,
	 (CASE WHEN d.SoTienDien IS NULL THEN 0 ELSE d.SoTienDien END) AS SoTienDien,
	 (CASE WHEN d.GiaTienDien IS NULL THEN 0 ELSE d.GiaTienDien END) AS GiaTienDien,
	 (CASE WHEN d.SoNuocCu IS NULL THEN 0 ELSE d.SoNuocCu END) AS SoNuocCu,
	 (CASE WHEN d.SoNuocMoi IS NULL THEN 0 ELSE d.SoNuocMoi END)AS SoNuocMoi,
	 (CASE WHEN d.SoNuocTieuThu IS NULL THEN 0 ELSE d.SoNuocTieuThu END)AS SoNuocTieuThu,
	 (CASE WHEN d.SoTienNuoc IS NULL THEN 0 ELSE d.SoTienNuoc END)AS SoTienNuoc,
	 (CASE WHEN d.GiaTienNuoc IS NULL THEN 0 ELSE d.GiaTienNuoc END)AS GiaTienNuoc,
	 h.NgayDong,
	 h.NguoiDong,
	 (CONVERT(NVARCHAR(10),d.Thang)++'/'+CONVERT(NVARCHAR(10),d.Nam) ) AS ThangNam
	FROM dbo.HoaDon h
	LEFT JOIN dbo.Tien t ON t.ID=h.TienID
	LEFT JOIN dbo.DienNuoc d ON d.Id=h.DienNuocId
	INNER JOIN dbo.Phong p ON p.MaPhong=h.MaPhong
	WHERE h.Id = @ID
	END    
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_LayDienNuocCu]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[NT_SP_LayDienNuocCu] 
(
	@thang INT=0,
	@nam INT=0,
	@makhu NVARCHAR(20)=''
)
AS
BEGIN
	SELECT d.MaPhong,d.SoDienMoi,d.SoNuocMoi
	FROM dbo.DienNuoc d
	INNER JOIN dbo.Phong p ON p.MaPhong =d.MaPhong AND p.MaKhu=@makhu
	WHERE Thang = (CASE WHEN @thang=1 THEN 12 ELSE @thang-1 END) AND Nam = (CASE WHEN @thang=1 THEN @nam-1 ELSE @nam END)
END
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_LIST_ROOM_SISO]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- [dbo].[KTX_SP_LIST_ROOM_SISO]
CREATE   Proc [dbo].[NT_SP_LIST_ROOM_SISO]

AS 
BEGIN
	SELECT * 
	FROM PHONG
	ORDER BY SoNguoi 
END

--------------------------


GO
/****** Object:  StoredProcedure [dbo].[NT_SP_TAOHOADON]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NT_SP_TAOHOADON]
(
	@THANG INT=0,
	@NAM INT=0,
	@MAKHU NVARCHAR(10)=''
)
AS
BEGIN
	SELECT 
	t.ID AS TienID,
	t.Thang,
	t.Nam,
	t.MaPhong,
	t.TongTien  INTO #tien
	FROM dbo.Tien t
	INNER JOIN dbo.Phong p ON p.MaPhong=t.MaPhong AND p.MaKhu=@MAKHU
	WHERE t.Thang=@THANG AND t.Nam=@NAM 

	SELECT 
	t.Id AS DienNuocId,
	t.Thang,
	t.Nam,
	t.MaPhong,
	t.TongTien  INTO #diennuoc
	FROM dbo.DienNuoc t
	INNER JOIN dbo.Phong p ON p.MaPhong=t.MaPhong AND p.MaKhu=@MAKHU
	WHERE t.Thang=@THANG AND t.Nam=@NAM AND p.MaKhu=@MAKHU

	DECLARE @tienid NVARCHAR(20)
	DECLARE @diennuocid NVARCHAR(20)
	DECLARE @maphong NVARCHAR(20)
	DECLARE @tiendien FLOAT
	DECLARE @tienphong FLOAT
	
	DECLARE @t INT
	DECLARE @n INT

	DECLARE Cur_InHoaDon CURSOR FOR
	SELECT (CASE WHEN t.Thang IS NULL THEN d.Thang ELSE t.Thang END) Thang,
	(CASE WHEN t.Nam IS NULL THEN d.Nam ELSE t.Nam END) Nam,
	(CASE WHEN t.MaPhong IS NULL THEN d.MaPhong ELSE t.MaPhong END) AS MaPhong, t.TienID,d.DienNuocId,(CASE WHEN t.TongTien IS NULL THEN 0 ELSE t.TongTien END ) AS tienphong,(CASE WHEN d.TongTien IS NULL THEN 0 ELSE d.TongTien END ) AS tiendn
	FROM  #tien t 
	FULL OUTER JOIN #diennuoc d ON d.Thang=t.Thang AND d.Nam=t.Nam AND t.MaPhong=d.MaPhong

	OPEN Cur_InHoaDon
	FETCH NEXT FROM Cur_InHoaDon INTO @t,@n,@maphong,@tienid,@diennuocid,@tienphong,@tiendien

	WHILE @@FETCH_STATUS=0
	BEGIN 
		INSERT INTO dbo.HoaDon
		        ( MaPhong ,
		          DienNuocId ,
		          TienID ,
		          TienDienNuoc ,
		          TienPhong ,
		          TongTien ,
		          NgayDong ,
		          NguoiDong ,
		          ThanhToan
		        )
		VALUES  ( @maphong , -- MaPhong - nvarchar(10)
		          @diennuocid, -- DienNuocId - bigint
		          @tienid , -- TienID - bigint
		          @tiendien , -- TienDienNuoc - float
		          @tienphong , -- TienPhong - float
		          @tiendien+@tienphong , -- TongTien - float
		          GETDATE() , -- NgayDong - date
		          N'' , -- NguoiDong - nvarchar(100)
		          0  -- ThanhToan - bit
		        )
				FETCH NEXT FROM Cur_InHoaDon INTO @t,@n,@maphong,@tienid,@diennuocid,@tienphong,@tiendien

	END
    CLOSE Cur_InHoaDon;
	DEALLOCATE Cur_InHoaDon;

	DROP TABLE #tien,#diennuoc

END
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_THONGKE_KHACHTRO]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NT_SP_THONGKE_KHACHTRO]
(
	 @maphong NVARCHAR(50)='',
	 @makhu NVARCHAR(50)='',
	 @gioitinh NVARCHAR(5)='',
	 @trangthai SMALLINT=7,
	 @tungay DATETIME=NULL,
	 @toingay DATETIME=NULL
)
AS
BEGIN
	SELECT kt.*,p.TenPhong,pc.TenPhong AS TenPhongCu,tt.TenTrangThai,k.TenKhu,tg.TenTonGiao, dt.TenDanToc
	FROM KhachTro kt WITH(NOLOCK)	    
		LEFT JOIN dbo.Phong p ON p.MaPhong=kt.MaPhong
		LEFT JOIN dbo.Phong pc ON pc.MaPhong=kt.MaPhongCu
		LEFT JOIN dbo.TrangThai tt ON tt.MaTrangThai=kt.MaTrangThai 
		LEFT JOIN dbo.Khu k ON k.MaKhu=p.MaKhu
		LEFT JOIN dbo.DanToc dt ON dt.MaDanToc=kt.MaDanToc
		LEFT JOIN dbo.TonGiao tg ON tg.MaTonGiao = kt.MaTonGiao
		WHERE kt.MaPhong=
		(
			CASE WHEN @maphong IS NULL 
			OR @maphong='' 
			OR LEN(@maphong) <1 
			THEN kt.MaPhong
			ELSE @maphong END )  
			AND
			kt.GioiTinh=(CASE WHEN @gioitinh='' OR @gioitinh=N'NN' OR @gioitinh='NN'
			OR @gioitinh IS NULL THEN kt.GioiTinh
							ELSE @gioitinh END)  
			AND
            kt.MaTrangThai=(CASE WHEN @trangthai = '6' OR @trangthai IS NULL OR @trangthai='0' THEN kt.MaTrangThai
								ELSE @trangthai END)
			AND p.MaKhu=(
					CASE WHEN @makhu IS NULL 
					OR @makhu='' THEN p.MaKhu
					ELSE @makhu END)
			AND 
			(
			CONVERT(DATE,kt.NgayVao,101)  >= (CASE WHEN CONVERT(DATE,@tungay,101) IS NULL OR CONVERT(DATE,@tungay,101)=''  THEN  CONVERT(DATE,kt.NgayVao,101) ELSE CONVERT(DATE,@tungay,101)  END) 
			and  CONVERT(DATE,kt.NgayVao,101) <= (CASE WHEN CONVERT(DATE,@toingay,101) IS NULL OR CONVERT(DATE,@toingay,101)='' THEN  CONVERT(DATE,kt.NgayVao,101) ELSE CONVERT(DATE,@toingay,101)	 END)   															
		)
END
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_ThongKeSoNguoiTheoKhu]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NT_SP_ThongKeSoNguoiTheoKhu]
AS
BEGIN	
	 SELECT k.TenKhu,
	 (CASE WHEN COUNT(kt.MaKhachTro) IS NULL THEN 0 ELSE COUNT(kt.MaKhachTro) END) AS SoNguoi
	 FROM dbo.KhachTro kt
	 INNER JOIN dbo.Phong p ON p.MaPhong=kt.MaPhong
	 INNER JOIN dbo.Khu k ON k.MaKhu=p.MaKhu
	 WHERE kt.HoatDong=1
	 GROUP BY k.TenKhu
END
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_ThongKeTheoGioiTinh]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NT_SP_ThongKeTheoGioiTinh]
AS
BEGIN	
	 SELECT GioiTinh,
	 (CASE WHEN COUNT(GioiTinh) IS NULL THEN 0 ELSE COUNT(GioiTinh) END) AS TongSo
	 FROM dbo.KhachTro 
	 WHERE HoatDong=1
	 GROUP BY GioiTinh
END
GO
/****** Object:  StoredProcedure [dbo].[NT_SP_UpdatePhong]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NT_SP_UpdatePhong]
(
	@mp NVARCHAR(50),
	@tenphong NVARCHAR(200),
	@makhu NVARCHAR(50),
	@songuoi INT,
	@giaphong FLOAT,
	@quanly BIT,
	@ghichu NTEXT
)
AS
BEGIN
		UPDATE dbo.Phong SET MaKhu=@makhu,TenPhong=@tenphong,
		SoNguoi=@songuoi,GiaPhong=@giaphong,HoatDong=@quanly,GhiChu=@ghichu
		WHERE MaPhong=@mp
		
END
GO
/****** Object:  StoredProcedure [dbo].[NT_TGG_LOG]    Script Date: 5/24/2017 10:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[NT_TGG_LOG] 
(
	@TDN NVARCHAR(200)=null,	
	@TV NVARCHAR(200)=NULL,
	@CT NVARCHAR(200)=NULL,
	@Mac NVARCHAR(100)=NULL,
	@Name NVARCHAR(100)=NULL
)
AS 
BEGIN
	DECLARE @NGAY DATETIME=GETDATE()
	INSERT INTO  [dbo].[NHATKY] 
	(TENDANGNHAP,NGAY,TACVU,CHITIET,MacAddress,TenMayTinh) VALUES (@TDN,@NGAY,@TV,@CT,@Mac,@Name)
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[26] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -384
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DanToc"
            Begin Extent = 
               Top = 104
               Left = 21
               Bottom = 216
               Right = 191
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SinhVien"
            Begin Extent = 
               Top = 169
               Left = 260
               Bottom = 494
               Right = 439
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "TonGiao"
            Begin Extent = 
               Top = 608
               Left = 509
               Bottom = 720
               Right = 679
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Phong"
            Begin Extent = 
               Top = 411
               Left = 490
               Bottom = 570
               Right = 659
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Khu"
            Begin Extent = 
               Top = 245
               Left = 687
               Bottom = 357
               Right = 857
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "HoKhauThuongTru"
            Begin Extent = 
               Top = 188
               Left = 471
               Bottom = 300
               Right = 641
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "KhoaHoc"
            Begin Extent = 
               Top = 317
               Left = 24
               Bottom = 429
               Right = 194
            End
            DisplayFl' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vSinhVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'ags = 280
            TopColumn = 0
         End
         Begin Table = "Lop"
            Begin Extent = 
               Top = 431
               Left = 38
               Bottom = 543
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 645
         Width = 1965
         Width = 1980
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3525
         Alias = 960
         Table = 1170
         Output = 765
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vSinhVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vSinhVien'
GO
