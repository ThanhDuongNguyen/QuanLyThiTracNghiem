USE [QLThi]
GO
ALTER TABLE [dbo].[NguoiDung] DROP CONSTRAINT [FK_NguoiDung_Quyen]
GO
ALTER TABLE [dbo].[HocSinh] DROP CONSTRAINT [FK_HocSinh_NguoiDung]
GO
ALTER TABLE [dbo].[GiaoVien] DROP CONSTRAINT [FK_GiaoVien_NguoiDung]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 1/10/2021 3:07:16 AM ******/
DROP TABLE [dbo].[Quyen]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 1/10/2021 3:07:16 AM ******/
DROP TABLE [dbo].[NguoiDung]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 1/10/2021 3:07:16 AM ******/
DROP TABLE [dbo].[HocSinh]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 1/10/2021 3:07:16 AM ******/
DROP TABLE [dbo].[GiaoVien]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 1/10/2021 3:07:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [int] NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[NguoiDungID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 1/10/2021 3:07:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [int] NOT NULL,
	[Lop] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[NguoiDungID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 1/10/2021 3:07:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[IDNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiKhoan] [nchar](50) NOT NULL,
	[MatKhauHash] [nchar](100) NOT NULL,
	[Quyen] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 1/10/2021 3:07:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[QuyenID] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[QuyenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (1, N'Nguyễn Thanh Sương', N'TPHCM', CAST(N'1980-10-15T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID]) VALUES (1, N'17CK2     ', N'Nguyễn Thanh Dương', CAST(N'1999-10-15T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (1, N'duongnt_hocsinh                                   ', N'123123                                                                                              ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (2, N'duongnt_giaovien                                  ', N'123123                                                                                              ', 2)
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
INSERT [dbo].[Quyen] ([QuyenID], [TenQuyen]) VALUES (1, N'Admin')
INSERT [dbo].[Quyen] ([QuyenID], [TenQuyen]) VALUES (2, N'Giáo viên')
INSERT [dbo].[Quyen] ([QuyenID], [TenQuyen]) VALUES (3, N'Học sinh')
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_NguoiDung] FOREIGN KEY([NguoiDungID])
REFERENCES [dbo].[NguoiDung] ([IDNguoiDung])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_NguoiDung]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_NguoiDung] FOREIGN KEY([NguoiDungID])
REFERENCES [dbo].[NguoiDung] ([IDNguoiDung])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_NguoiDung]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_Quyen] FOREIGN KEY([Quyen])
REFERENCES [dbo].[Quyen] ([QuyenID])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_Quyen]
GO
