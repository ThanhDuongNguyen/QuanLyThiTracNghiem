USE [QLThi]
GO
ALTER TABLE [dbo].[NguoiDung] DROP CONSTRAINT [FK_NguoiDung_Quyen]
GO
ALTER TABLE [dbo].[KyThi] DROP CONSTRAINT [FK_KT_LKT]
GO
ALTER TABLE [dbo].[HocSinh] DROP CONSTRAINT [FK_HocSinh_NguoiDung]
GO
ALTER TABLE [dbo].[GiaoVien] DROP CONSTRAINT [FK_GiaoVien_NguoiDung]
GO
ALTER TABLE [dbo].[DeThi_CauHoi] DROP CONSTRAINT [FK_DT_CH__DT]
GO
ALTER TABLE [dbo].[DeThi_CauHoi] DROP CONSTRAINT [FK_DT_CH__CH]
GO
ALTER TABLE [dbo].[DeThi] DROP CONSTRAINT [FK_KT_CH]
GO
ALTER TABLE [dbo].[DapAn] DROP CONSTRAINT [FK_DA_CH]
GO
ALTER TABLE [dbo].[CauTraLoi] DROP CONSTRAINT [FK_CTL_ND]
GO
ALTER TABLE [dbo].[CauTraLoi] DROP CONSTRAINT [FK_CTL_KT]
GO
ALTER TABLE [dbo].[CauTraLoi] DROP CONSTRAINT [FK_CTL_DT]
GO
ALTER TABLE [dbo].[CauTraLoi] DROP CONSTRAINT [FK_CTL_CH]
GO
ALTER TABLE [dbo].[CauHoi] DROP CONSTRAINT [FK_CauHoi_MonHoc]
GO
ALTER TABLE [dbo].[CauHoi] DROP CONSTRAINT [FK_CauHoi_CapHoc]
GO
ALTER TABLE [dbo].[CauHoi] DROP CONSTRAINT [FK_CauHoi_CapDo]
GO
ALTER TABLE [dbo].[BaiLamHS] DROP CONSTRAINT [FK_BL_ND]
GO
ALTER TABLE [dbo].[BaiLamHS] DROP CONSTRAINT [FK_BL_KT]
GO
ALTER TABLE [dbo].[BaiLamHS] DROP CONSTRAINT [FK_BL_DT]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[Quyen]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[NguoiDung]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[MonHoc]
GO
/****** Object:  Table [dbo].[LoaiKiThi]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[LoaiKiThi]
GO
/****** Object:  Table [dbo].[KyThi]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[KyThi]
GO
/****** Object:  Table [dbo].[KT_HS]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[KT_HS]
GO
/****** Object:  Table [dbo].[KT_DT]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[KT_DT]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[HocSinh]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[GiaoVien]
GO
/****** Object:  Table [dbo].[DeThi_CauHoi]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[DeThi_CauHoi]
GO
/****** Object:  Table [dbo].[DeThi]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[DeThi]
GO
/****** Object:  Table [dbo].[DapAn]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[DapAn]
GO
/****** Object:  Table [dbo].[CauTraLoi]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[CauTraLoi]
GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[CauHoi]
GO
/****** Object:  Table [dbo].[CapHoc]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[CapHoc]
GO
/****** Object:  Table [dbo].[CapDo]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[CapDo]
GO
/****** Object:  Table [dbo].[BaiLamHS]    Script Date: 1/17/2021 5:23:43 PM ******/
DROP TABLE [dbo].[BaiLamHS]
GO
/****** Object:  Table [dbo].[BaiLamHS]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiLamHS](
	[MaNguoiDung] [int] NOT NULL,
	[MaKT] [varchar](10) NOT NULL,
	[MaDT] [varchar](10) NOT NULL,
	[DiemThi] [int] NULL,
 CONSTRAINT [PK_BaiLamHS] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC,
	[MaKT] ASC,
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CapDo]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CapDo](
	[MaCapDo] [int] NOT NULL,
	[TenCapDo] [nchar](10) NULL,
 CONSTRAINT [PK_CapDo] PRIMARY KEY CLUSTERED 
(
	[MaCapDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CapHoc]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CapHoc](
	[IDCapHoc] [int] NOT NULL,
	[TenCapHoc] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCapHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoi](
	[IDCauHoi] [int] IDENTITY(1,1) NOT NULL,
	[CauHoiDeBai] [nvarchar](max) NOT NULL,
	[MonHoc] [varchar](10) NOT NULL,
	[CapHoc] [int] NOT NULL,
	[CapDo] [int] NOT NULL,
	[GoiY] [nvarchar](max) NULL,
 CONSTRAINT [PK_CauHoi] PRIMARY KEY CLUSTERED 
(
	[IDCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CauTraLoi]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauTraLoi](
	[NguoiDungID] [int] NOT NULL,
	[MaDeThi] [varchar](10) NOT NULL,
	[CauHoiID] [int] NOT NULL,
	[DapAn] [int] NOT NULL,
	[MaKyThi] [varchar](10) NOT NULL,
 CONSTRAINT [PK__CauTraLo__1BBAD0129433E598] PRIMARY KEY CLUSTERED 
(
	[NguoiDungID] ASC,
	[CauHoiID] ASC,
	[MaDeThi] ASC,
	[MaKyThi] ASC,
	[DapAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DapAn]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DapAn](
	[DapAnCauHoi] [nvarchar](max) NULL,
	[IDCauHoi] [int] NOT NULL,
	[IsDung] [bit] NULL,
	[STTDapAn] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCauHoi] ASC,
	[STTDapAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeThi]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeThi](
	[MaDeThi] [varchar](10) NOT NULL,
	[MaMH] [varchar](10) NULL,
	[MaCapHoc] [int] NULL,
	[MaGV] [varchar](10) NULL,
	[TenDeThi] [varchar](10) NULL,
	[ThoiGian] [int] NULL,
	[NgayTao] [datetime] NULL,
 CONSTRAINT [PK_DeThi] PRIMARY KEY CLUSTERED 
(
	[MaDeThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeThi_CauHoi]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeThi_CauHoi](
	[MaDT] [varchar](10) NOT NULL,
	[IDCauHoi] [int] NOT NULL,
 CONSTRAINT [PK_DeThi_CauHoi] PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC,
	[IDCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[NguoiDungID] [int] NOT NULL,
 CONSTRAINT [PK__GiaoVien__2725AEF3447FD1EF] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [varchar](10) NOT NULL,
	[Lop] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[NguoiDungID] [int] NOT NULL,
	[DiaChi] [nvarchar](150) NULL,
 CONSTRAINT [PK__HocSinh__2725A6EFF6CFAE27] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KT_DT]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KT_DT](
	[MaKT] [varchar](10) NOT NULL,
	[MaDT] [varchar](10) NOT NULL,
 CONSTRAINT [PK__KT_DT_HS__2725CF129624F62B] PRIMARY KEY CLUSTERED 
(
	[MaKT] ASC,
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KT_HS]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KT_HS](
	[MaKT] [varchar](10) NOT NULL,
	[MaHS] [varchar](10) NOT NULL,
 CONSTRAINT [PK__KT_HS__2725CF123062849E] PRIMARY KEY CLUSTERED 
(
	[MaKT] ASC,
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyThi]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyThi](
	[MaKT] [varchar](10) NOT NULL,
	[TenKT] [nvarchar](100) NULL,
	[LoaiKT] [int] NULL,
	[MaCapHoc] [int] NULL,
	[NgayBD] [datetime] NULL,
	[NgayKT] [datetime] NULL,
	[MaGV] [varchar](10) NULL,
 CONSTRAINT [PK_KyThi] PRIMARY KEY CLUSTERED 
(
	[MaKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiKiThi]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKiThi](
	[LoaiKiThi] [int] NOT NULL,
	[TenLoaiKiThi] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[LoaiKiThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [varchar](10) NOT NULL,
	[TenMonHoc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__MonHoc__4127737F6A2748D1] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 1/17/2021 5:23:43 PM ******/
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
/****** Object:  Table [dbo].[Quyen]    Script Date: 1/17/2021 5:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[QuyenID] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuyenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CapDo] ([MaCapDo], [TenCapDo]) VALUES (1, N'Cực khó   ')
INSERT [dbo].[CapDo] ([MaCapDo], [TenCapDo]) VALUES (2, N'Khó       ')
INSERT [dbo].[CapDo] ([MaCapDo], [TenCapDo]) VALUES (3, N'Trung bình')
INSERT [dbo].[CapDo] ([MaCapDo], [TenCapDo]) VALUES (4, N'Dễ        ')
INSERT [dbo].[CapHoc] ([IDCapHoc], [TenCapHoc]) VALUES (1, N'Lớp 10')
INSERT [dbo].[CapHoc] ([IDCapHoc], [TenCapHoc]) VALUES (2, N'Lớp 11')
INSERT [dbo].[CapHoc] ([IDCapHoc], [TenCapHoc]) VALUES (3, N'Lớp 12')
SET IDENTITY_INSERT [dbo].[CauHoi] ON 

INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (65, N'Các câu nói sau, câu nào không phải là một mệnh đề:', N'T', 1, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (66, N'Kết quả phép toán (-5 ; 5] \cap[0 ; 5) là:', N'T', 1, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (67, N'Kết quả phép toán [-3 ; 7) \cup(3 ; 7] là:', N'T', 1, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (68, N'Kết quả phép toán N/N* là', N'T', 1, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (69, N'Cho hàm số y = -x + 1, các điểm sau đây điểm nào thuộc đồ thị hàm số:', N'T', 1, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (70, N'Trong mặt phẳng tọa độ Oxy cho A(3 ; 5), B(1 ; 2), C(5 ; 2). Tọa độ trọng tâm của tam giác ABC là:', N'T', 1, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (71, N'Với giá trị nào của m thì phương trình x 2 + 3x + m = 0 vô nghiệm?', N'T', 1, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (72, N'Trong mặt phẳng tọa độ Oxy cho A(2 ; 3), B(-1 ; -1), C(6 ; 0), khi đó chu vi tam giác ABC là:', N'T', 1, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (73, N'Trong mặt phẳng tọa độ O xy cho ba điểm A(2 ; 4), B(1 ; x ), C(6 ; 2). Tìm x để AB  AC ', N'T', 1, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (74, N'Cho tam giác đều ABC có cạnh bằng a và có chiều cao AH. Khi đó AB.AC là:', N'T', 1, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (75, N'Chuyển động cơ là gì ?', N'VL', 1, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (76, N'Nhận xét nào là nhận xét sai trong những nhận xét sau đây?', N'VL', 1, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (77, N'Một ô tô di chuyển từ A và đến B trong 5 giờ, trong đó, 2 giờ đầu di chuyển với tốc độ 50km/h và 3 giờ tiếp theo sau di chuyển với tốc độ 30km/h.  Tính vận tốc trung bình trên toàn đoạn đường AB của ô tô ?', N'VL', 1, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (78, N'Tính chất của gia tốc của chuyển động thẳng nhanh dần đều là tính chất nào sau đây ?', N'VL', 1, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (79, N'Một xe đang di chuyển với tốc độ 36km/h thì gia tốc và sau 2s xe lên tới tốc độ 54km/h. Tính gia tốc của xe trong 2s ?', N'VL', 1, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (80, N'Điều nào sau đây đúng khi nói về sự rơi tự do ?', N'VL', 1, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (81, N'Một giọt nước rơi tự do xuống đất từ sân thượng tòa nhà có độ cao 45m . Cho g = 10 m/s². Thời gian từ lúc rơi tới lúc giọt nước tới mặt đất là bao nhiêu?', N'VL', 1, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (82, N'Các công thức dùng để thể hiện sự liên hệ giữa tốc độ góc ω với chu kỳ T và giữa tốc độ góc ω với tần số f trong chuyển động tròn đều là gì ?', N'VL', 1, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (83, N'Một bánh xe ôtô có bán kính vành ngoài là 25cm. Xe di chuyển với vận tốc 10m/s. Vận tốc góc của một điểm trên vành ngoài xe so với trục bánh xe là bao nhiêu ?', N'VL', 1, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (84, N' Điều nào sau đây là sai khi xét về trạng thái của một vật trong các hệ quy chiếu khác nhau ?', N'HH', 2, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (85, N'Cấu hình electron của nguyên tử có Z = 9 là', N'HH', 2, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (86, N'Nguyên tố X thuộc chu kì 3, nhóm VIA trong bảng tuần hoàn. Phát biểu nào sau đây đúng?', N'HH', 2, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (87, N'Số oxi hóa của nguyên tử lưu huỳnh trong phân tử H2SO3 là', N'HH', 2, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (88, N'Nguyên tử photpho (Z=15) có cấu hình electron: 1s22s22p63s23p3. Khẳng định nào sau đây sai?', N'HH', 2, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (89, N'Trong tự nhiên, nguyên tố brom (Br) có 2 đồng vị là và . Biết đồng vị chiếm 54,5 % số nguyên tử. Nguyên tử khối trung bình của brom là', N'HH', 2, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (90, N'Cho các nguyên tố Na (Z=11); Mg (Z=12) và Al (Z=13). Tính kim loại của các nguyên tố giảm dần theo thứ tự là', N'HH', 2, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (91, N'Các hạt cấu tạo nên hạt nhân nguyên tử (trừ Hiđrô) là:', N'HH', 2, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (92, N'Nhóm nguyên tố là tập hợp các nguyên tố, mà nguyên tử của các nguyên tố này có cùng', N'HH', 2, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (93, N' Nguyên tố hóa học là những nguyên tử có cùng', N'HH', 2, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (94, N'The football match was cancelled because it rained.', N'AV', 2, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (95, N'I have been learning English for seven years.', N'AV', 2, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (96, N'In large cases, children feel that they cannot _____ with the teacher.', N'AV', 2, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (97, N'What makes computer a miraculous device?', N'AV', 2, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (98, N'A _____ is a film with factual information, often about a problem in', N'AV', 2, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (99, N'She earned a degree in Physics with flying colours', N'AV', 2, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (100, N'A _____ is a film with factual information, often about a problem in society.', N'AV', 2, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (101, N'I think we should widen the roads.', N'AV', 2, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (102, N'What do you usually do at 17:00 p.m?', N'AV', 2, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (103, N'Tony: For three years.', N'AV', 2, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (104, N'Dấu tích Người tối cổ đã được tìm thấy đầu tiên ở tỉnh nào của Việt Nam?', N'LS', 3, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (105, N'Người tối cổ khác loài vượn cổ ở điểm nào?', N'LS', 3, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (106, N'Công cụ lao động của Người tối cổ ứng với thời kì nào?', N'LS', 3, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (107, N'Người tối cổ đã có phát minh lớn nào?', N'LS', 3, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (108, N'Người tối cổ tự cải biến mình, hoàn thiện mình từng bước nhờ', N'LS', 3, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (109, N'Người tinh khôn xuất hiện vào khoảng thời gian nào?', N'LS', 3, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (110, N'So với Người tối cổ, Người tinh khôn đã', N'LS', 3, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (111, N'Để tăng nguồn thức ăn, Người tinh khôn đã không sử dụng biện pháp nào sau đây?', N'LS', 3, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (112, N'Vì sao các nhà khảo cổ coi thời kì đá mới là một cuộc cách mạng?', N'LS', 3, 3, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (113, N'Sự khác nhau về màu da giữa các chủng tộc trên thế giới là biểu hiện sự khác nhau về', N'LS', 3, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (114, N'Giới hạn dưới của lớp vỏ địa lí còn được xem là :', N'DL', 3, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (115, N'Nội lực là', N'DL', 3, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (116, N'Vận động làm cho các lục địa được nâng lên hay hạ xuống các lớp đất đá bị uốn nếp hay đứt gãy gọi chung là', N'DL', 3, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (117, N'Frông ôn đới (Fp) là frông hình thành do sự tiếp xúc của 2 khối khí', N'DL', 3, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (118, N'Tác nhân của ngoại lực là', N'DL', 3, 2, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (119, N'Kết quả của phong hóa lí học là', N'DL', 3, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (120, N'Thủy quyển là lớp nước trên trái đất, bao gồm:', N'DL', 3, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (121, N'Cho bản đồ: Các mảng kiến tạo lớn của Thạch quyển', N'DL', 3, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (122, N'Quy luật địa đới là sự thay đổi có quy luật của tất cả các thành phần địa lí và cảnh quan địa lí theo', N'DL', 3, 4, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (123, N'Ở nơi mặt trời lên thiên đỉnh, vào đúng giữa trưa, tia sáng mặt trời sẽ tạo với bề mặt một góc là :', N'DL', 3, 1, N'')
INSERT [dbo].[CauHoi] ([IDCauHoi], [CauHoiDeBai], [MonHoc], [CapHoc], [CapDo], [GoiY]) VALUES (124, N'Dao động thủy triều lớn nhất khi:', N'DL', 3, 2, N'')
SET IDENTITY_INSERT [dbo].[CauHoi] OFF
INSERT [dbo].[CauTraLoi] ([NguoiDungID], [MaDeThi], [CauHoiID], [DapAn], [MaKyThi]) VALUES (531, N'DT02', 67, 1, N'KT0123434')
INSERT [dbo].[CauTraLoi] ([NguoiDungID], [MaDeThi], [CauHoiID], [DapAn], [MaKyThi]) VALUES (531, N'DT02', 67, 2, N'KT0123434')
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Chị ơi, mấy giờ rồi?', 65, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Bến Tre có nhiều dừa.', 65, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Anh ấy rất giỏi Toán.', 65, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Đất Bến Tre nằm trên ba dãy Cù lao.', 65, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'[0 ; 5]', 66, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'[0 ; 5)', 66, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'(-5 ; 5]', 66, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'(-5 ; 5)', 66, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'(3 ; 7]', 67, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'[-3 ; 7)', 67, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'[-3 ; 7]', 67, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'(-3 ; 7)', 67, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'N', 68, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'∅', 68, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'N*', 68, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'{0}', 68, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'N(-1 ; 2)', 69, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'H(0 ; -1)', 69, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'M(1 ; -1)', 69, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'K(1 ; 1)', 69, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'(-3 ; 4)', 70, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'(3 ; 3)', 70, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'(4 ; 0)', 70, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'(2 ; 3)', 70, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'm < 9 4', 71, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'm > 9 4', 71, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'm > 9 4', 71, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'm < 9 4', 71, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'25 + 5 2', 72, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'25 2', 72, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'25 2 2', 72, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'10 + 5 2', 72, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'x = 4', 73, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'x = 2', 73, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'x = -2', 73, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'x = -4', 73, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'a', 74, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'a/2', 74, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'a*a', 74, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'(a*a)/2', 74, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Chuyển động cơ là sự thay đổi về hướng của vật này so với một vật khác theo thời gian.', 75, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Chuyển động cơ là sự thay đổi về chiều của vật này so với một vật khác theo thời gian.', 75, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Chuyển động cơ là sự thay đổi về vị trí của vật này so với một vật khác theo thời gian.', 75, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Chuyển động cơ là sự thay đổi về phương của vật này so với một vật khác theo thời gian.', 75, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Tốc độ trung bình trên sẽ là như nhau trên mọi quãng đường trong chuyển động thẳng đều.', 76, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Công thức để tính quãng đường đi được của chuyển động thẳng đều là: s = vt.', 76, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Công thức vận tốc trong chuyển động thẳng đều là : v = v0 + at.', 76, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Phương trình chuyển động trong chuyển động thẳng đều là x = x0 + vt.', 76, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'45 km/h.', 77, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'38 km/h.', 77, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'47 km/h.', 77, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'32 km/h. ', 77, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Có phương, chiều và độ lớn luôn cố định theo thời gian.', 78, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Tăng dần đều theo thời gian.', 78, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Luôn luôn lớn hơn gia tốc của chuyển động chậm dần đều.', 78, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Chỉ có độ lớn giữ nguyễn. Mọi thứ khác đều thay đổi', 78, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'1 m/s²', 79, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'2,5 m/s²', 79, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'1,5 m/s²', 79, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'2 m/s²', 79, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Sự rơi tự do là sự chuyển động khi không có lực tác dụng.', 80, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Sự rơi tự do là sự chuyển động khi bỏ qua lực cản.', 80, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Sự rơi tự do là một dạng chuyển động thẳng đều.', 80, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Sự rơi tự do là chuyển động của vật chỉ dưới tác dụng của trọng lực.', 80, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'4,5 s.', 81, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'2,0 s.', 81, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'9,0 s.', 81, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'3,0 s.', 81, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'ω = 2π/T và ω = 2πf.', 82, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'ω = 2π/T và ω = 2πf.', 82, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'ω = 2πT và ω = 2πf.', 82, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'ω = 2πT và ω = 2π/f.', 82, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'30 rad/s', 83, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'10 rad/s', 83, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'20 rad /s', 83, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'40 rad/s.', 83, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'vật có thể có vật tốc khác nhau trong 2 hệ quy chiếu khác nhau .', 84, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'vật có thể chuyển động với quỹ đạo khác nhau trong 2 hệ quy chiếu khác nhau.', 84, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'vật có theå có hình dạng khác nhau trong 2 hệ quy chiếu khác nhau.', 84, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'vật có thể đứng yên hoặc chuyển động trong 2 hệ quy chiếu khác nhau.', 84, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'1s22s23p5', 85, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'1s22s23s2 3p3', 85, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'1s23s2 3p5', 85, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'1s22s22p5', 85, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nguyên tử X có 6 lớp electron', 86, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nguyên tố X là kim loại', 86, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nguyên tử X có 6 electron hóa trị', 86, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Hóa trị cao nhất của X với oxi là 3', 86, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N' -6', 87, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'6', 87, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'4', 87, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'-4', 87, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'-4', 87, 1, 5)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Lớp M (n=3) của nguyên tử photpho gồm 3 electron', 88, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nguyên tử photpho có 3 lớp electron', 88, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Photpho là nguyên tố p', 88, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Photpho là phi kim vì có 5 electron lớp ngoài cùng', 88, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Lớp M (n=3) của nguyên tử photpho gồm 3 electron', 88, 0, 5)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nguyên tử photpho có 3 lớp electron', 88, 1, 6)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'79,19', 89, 0, 1)
GO
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'79,91', 89, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'80,09', 89, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'80,90', 89, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Al>Mg>Na', 90, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Na>Al>Mg', 90, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Mg>Al>Na', 90, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Na>Mg>Al', 90, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Proton', 91, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Proton và Nơtron', 91, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Proton và electron', 91, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Proton, electron và nơtron', 91, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'số electron.', 92, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'số lớp electron.', 92, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'số electron hóa trị.', 92, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'số electron ở lớp ngoài cùng', 92, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Số khối', 93, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Số nơtron', 93, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Số prton', 93, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Số nơtron và proton', 93, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'We postponed the football match whether it rained or not.', 94, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'We planned to watch a football match because we didn’t know it would rain.', 94, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Despite the rain, we watched the football match as planned.', 94, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'The football match was cancelled because of the rain.', 94, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'We postponed the football match whether it rained or not.', 94, 1, 5)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'I started to learn English for seven years.', 95, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'I started to learn English seven years ago.', 95, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'I have started to learn English for seven years. .', 95, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'I didn''t start to learn English seven years ago.', 95, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'I have started to learn English for seven years. .', 95, 0, 5)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'I didn''t start to learn English seven years ago.', 95, 0, 6)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'contact', 96, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'interact', 96, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'transmit', 96, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'relax', 96, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'strange', 97, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'powerful', 97, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N' magical', 97, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'excellent', 97, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'series', 98, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'soap opera', 98, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'documentary', 98, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'drama', 98, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'make less severe', 99, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'keep in mind', 99, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'developed mind', 99, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'with a very high mark', 99, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'series', 100, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'soap opera', 100, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'documentary', 100, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'drama', 100, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'That’s a good idea', 101, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'I don’t agree with you', 101, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'I don’t think so', 101, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'I disagree with you', 101, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'He has an English lesson.', 102, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'He usually plays football', 102, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'He gets up and brush his teeth', 102, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'He has breakfast and goes to school', 102, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'How long you have lived here?', 103, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'How long have you lived here?', 103, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'How many years you lived here?', 103, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'How far did you live here?', 103, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nghệ An.', 104, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Thanh Hóa.', 104, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Cao Bằng.', 104, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Lạng Sơn.', 104, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Hà Nội.', 104, 1, 5)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Sài Gòn', 104, 0, 6)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Đã bỏ hết dấu tích vượn trên cơ thể mình.', 105, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Đã biết chế tác công cụ lao động.', 105, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Biết chế tạo lao và cung tên.', 105, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Biết săn bắn, hái lượm.', 105, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Đã biết chế tác công cụ lao động.', 105, 0, 5)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Sơ kì đá cũ', 106, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Sơ kì đá mới', 106, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Sơ kì đá giữa', 106, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Hậu kì đá mới', 106, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Biết giữ lửa trong tự nhiên', 107, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Biết tạo ra lửa', 107, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Biết chế tạo nhạc cụ', 107, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Biết chế tạo trang sức', 107, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Phát minh ra lửa.', 108, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Chế tạo đồ đá.', 108, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Lao động.', 108, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Sự thay đổi của thiên nhiên.', 108, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Khoảng 3 vạn năm cách ngày nay.', 109, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Khoảng 4 vạn năm cách ngày nay.', 109, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Khoảng 3 triệu năm cách ngày nay.', 109, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Khoảng 4 triệu năm cách ngày nay.', 109, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Loại bỏ hết dấu tích vượn trên người.', 110, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Tiến hóa thành người nhưng vẫn còn một ít dấu tích vượn trên người.', 110, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Biết chế tạo ra lửa để nấu chín thức ăn.', 110, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Biết chế tạo công cụ lao động.', 110, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Ghè đẽo đá thật sắc bén để giết thú vật.', 111, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Chế tạo cung tên để săn bắn thú vật.', 111, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Tập hợp đông người đi vào rừng săn bắt.', 111, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Tiến hành trồng trọt và chăn nuôi.', 111, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Con người đã biết sử dụng đá mới để làm công cụ.', 112, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Con người đã biết săn bắn, hái lượm và đánh cá.', 112, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Con người đã biết trồng trọt và chăn nuôi.', 112, 0, 3)
GO
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Con người đã biết sử dụng kim loại.', 112, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Trình độ văn minh.', 113, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Đẳng cấp xã hội.', 113, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Trình độ kinh tế.', 113, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Đặc điểm sinh học.', 113, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Giới hạn dưới của tầng trầm tích', 114, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Giới hạn dưới của sinh quyển.', 114, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Giới hạn dưới của lớp vỏ Trái Đất.', 114, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Giới hạn dưới của tầng bazan.', 114, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Giới hạn dưới của sinh quyển.', 114, 0, 5)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Giới hạn dưới của tầng bazan.', 114, 0, 6)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'lực phát sinh từ vũ trụ.', 115, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'lực phát sinh từ bên trong trái đất.', 115, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'lực phát sinh từ lớp vỏ trái đất.', 115, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'lực phát sinh từ bên ngoài, trên bề mặt trái đất.', 115, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'lực phát sinh từ bên trong trái đất.', 115, 0, 5)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'vận động tạo núi.', 116, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'vận động theo phương thẳng đứng.', 116, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'vận động theo phương nằm ngang.', 116, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'vận động kiến tạo.', 116, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'ôn đới và chí tuyến.', 117, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'địa cực lục địa và địa cực hải dương.', 117, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'ôn đới lục địa và ôn đới hải dương.', 117, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'địa cực và ôn đới.', 117, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'sự nâng lên và hạ xuống của vỏ trái đất theo chiều thẳng đứng.', 118, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'yếu tố khí hậu các dạng nước, sinh vật và con người.', 118, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'sự uốn nếp các lớp đá.', 118, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'sự đứt gãy các lớp đất đá.', 118, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'chủ yếu làm biến đổi thành phần tính chất hóa học của đá và khoáng vật.', 119, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'phá hủy đá và khoáng vật nhưng không làm biến đổi chúng về màu sắc thành phần và tính chất hóa học.', 119, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'chủ yếu làm cho đá và khoáng vật nứt vỡ nhưng đồng thời làm thay đổi thành phần tính chất hóa học của chúng.', 119, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'phá hủy đá và khoáng vật đồng thời di chuyển chứng từ nơi khác.', 119, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nước trong các biển và đại dương, nước trên lục địa, nước trong lòng trái đất.', 120, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nước trong các biển và đại dương, nước trên lục địa, hơi nước trong khí quyển.', 120, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nước trên lục địa, nước trong lòng trái đất, hơi nước trong khí quyển.', 120, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Nước trong các biển và đại dương, nước trên lục địa, nước trong lòng trái đất, hơi nước trong khí quyển.', 120, 1, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Mảng Âu Á, mảng Thái Bình Dương, mảng Philippin.', 121, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Mảng Âu Á, mảng Thái Bình Dương, mảng Ấn Độ - Ô-xtrây-li-a.', 121, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Mảng Âu Á, mảng Thái Bình Dương, mảng Phi.', 121, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Mảng Âu Á, mảng Phi, mảng Philippin.', 121, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Thời gian.', 122, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Độ cao và hướng địa hình.', 122, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Vĩ độ.', 122, 1, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Khoảng cách gần hay xa đại dương.', 122, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'90o', 123, 0, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'66o33’’', 123, 1, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'180o', 123, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'23o27’', 123, 0, 4)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Mặt Trăng, Mặt Trời, Trái Đất nằm trên cùng một mặt phẳng', 124, 1, 1)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Bán cầu bắc ngã về phí Mặt Trời', 124, 0, 2)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Mặt Trăng, Mặt Trời, Trái Đất nằm thẳng hàng', 124, 0, 3)
INSERT [dbo].[DapAn] ([DapAnCauHoi], [IDCauHoi], [IsDung], [STTDapAn]) VALUES (N'Trái Đất nằm ở vị trí gần Mặt Trời nhất', 124, 0, 4)
INSERT [dbo].[DeThi] ([MaDeThi], [MaMH], [MaCapHoc], [MaGV], [TenDeThi], [ThoiGian], [NgayTao]) VALUES (N'DT02', N'LS', 1, N'GV0005', N'HKI', 20, CAST(N'2021-01-05T10:20:54.000' AS DateTime))
INSERT [dbo].[DeThi] ([MaDeThi], [MaMH], [MaCapHoc], [MaGV], [TenDeThi], [ThoiGian], [NgayTao]) VALUES (N'DT021', N'LS', 1, N'GV0007', N'HKI', 20, CAST(N'2021-01-17T11:12:10.457' AS DateTime))
INSERT [dbo].[DeThi_CauHoi] ([MaDT], [IDCauHoi]) VALUES (N'DT02', 67)
INSERT [dbo].[DeThi_CauHoi] ([MaDT], [IDCauHoi]) VALUES (N'DT02', 68)
INSERT [dbo].[DeThi_CauHoi] ([MaDT], [IDCauHoi]) VALUES (N'DT02', 71)
INSERT [dbo].[DeThi_CauHoi] ([MaDT], [IDCauHoi]) VALUES (N'DT021', 67)
INSERT [dbo].[DeThi_CauHoi] ([MaDT], [IDCauHoi]) VALUES (N'DT021', 71)
INSERT [dbo].[DeThi_CauHoi] ([MaDT], [IDCauHoi]) VALUES (N'DT021', 72)
INSERT [dbo].[DeThi_CauHoi] ([MaDT], [IDCauHoi]) VALUES (N'DT021', 73)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0001', N'Đoàn Nguyễn Thanh Phong', N'147 Pasteur, P. Võ Thị Sáu, Quận 3', CAST(N'1980-01-01T00:00:00.000' AS DateTime), 501)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0002', N'Tô Thị Cẩm Tiên', N'159 Nam Kỳ Khởi Nghĩa, P. Võ Thị Sáu, Quận 3', CAST(N'1980-02-01T00:00:00.000' AS DateTime), 502)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0003', N'Trần Thanh Việt', N'12 Trần Quốc Toàn, Phường 8, Quận 3', CAST(N'1980-03-01T00:00:00.000' AS DateTime), 503)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0004', N'La Thành Của', N'364, Nguyễn Tất Thành, Quận 4', CAST(N'1980-04-01T00:00:00.000' AS DateTime), 504)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0005', N'Huỳnh Quốc Huy', N'2 Bến Vân Đồn, Phường 13, Quận 4', CAST(N'1980-05-01T00:00:00.000' AS DateTime), 505)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0006', N'Lê Minh Khang', N'220 Trần Bình Trọng, Phường 4, Quận 5', CAST(N'1980-06-01T00:00:00.000' AS DateTime), 506)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0007', N'Nguyễn Ngọc Nhi', N'124 Hùng Vương, Quận 5', CAST(N'1980-07-01T00:00:00.000' AS DateTime), 507)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0008', N'Lê Kiều Thuý', N'280 An Dương Vương, Phường 4, Quận 5', CAST(N'1980-08-01T00:00:00.000' AS DateTime), 508)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0009', N'Nguyễn Hồng Yến', N'225, Nguyễn Tri Phương, Quận 5', CAST(N'1980-09-01T00:00:00.000' AS DateTime), 509)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0010', N'Phạm Anh Kiệt', N'276 Trần Hưng Đạo B, Quận 5', CAST(N'1983-01-02T00:00:00.000' AS DateTime), 510)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0011', N'Trần Thị Mỹ Quyên', N'4, Tân Hòa Đông, Quận 6', CAST(N'1983-02-02T00:00:00.000' AS DateTime), 511)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0012', N'Nguyễn Thanh Tín', N'84/47, Lý Chiêu Hoàng, Quận 6', CAST(N'1983-03-02T00:00:00.000' AS DateTime), 512)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0013', N'Lưu Mỹ Xuyến', N'Số 425 - 435 Gia Phú, Phường 3, Quận 6', CAST(N'1983-04-02T00:00:00.000' AS DateTime), 513)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0014', N'Trần Thúy An', N'Đường 17P, Tân Kiểng, Quận 7', CAST(N'1983-05-02T00:00:00.000' AS DateTime), 514)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0015', N'Phan Tuấn Đạt', N'19F, KDC Ven Sông, Nguyễn Văn Linh, Tân Phong, Quận 7', CAST(N'1983-06-02T00:00:00.000' AS DateTime), 515)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0016', N'Bùi Hữu Lộc', N'1360, Huỳnh Tấn Phát, Quận 7', CAST(N'1983-07-02T00:00:00.000' AS DateTime), 516)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0017', N'Trần Bảo Minh', N'173, Phạm Hùng, Quận 8', CAST(N'1983-08-02T00:00:00.000' AS DateTime), 517)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0018', N'Nguyễn Thành Nam', N'360E, Bình Đông, Quận 8', CAST(N'1983-09-02T00:00:00.000' AS DateTime), 518)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0019', N'Nguyễn Thị Minh Thư', N'909, Tạ Quang Bửu, Quận 8', CAST(N'1983-10-02T00:00:00.000' AS DateTime), 519)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0020', N'Biện Ngọc Như Ý', N'Số 2 Đường 3154 Phạm Thế Hiển Phường 7, Quận 8', CAST(N'1985-01-03T00:00:00.000' AS DateTime), 520)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0021', N'Trần Hoàng Lam', N'629, Bến Bình Đông, Quận 8', CAST(N'1985-02-03T00:00:00.000' AS DateTime), 521)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0022', N'Huỳnh Thiên Phát', N'Dương Đình Hội, phường Phước Long, Quận 9', CAST(N'1985-03-03T00:00:00.000' AS DateTime), 522)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0023', N'Nguyễn Hoàng Phú', N'309, Võ Văn Hát, Khu phố Phước Hiệp, phường Long Trường, Quận 9', CAST(N'1985-04-03T00:00:00.000' AS DateTime), 523)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0024', N'Trương Hữu Vinh', N'50 Thành Thái,Phường 12,Quận 10', CAST(N'1985-05-03T00:00:00.000' AS DateTime), 524)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0025', N'Lư Kiều Bảo My', N'XX1 Đồng Nai, Cư xá Bắc Hải, Quận 10', CAST(N'1985-06-03T00:00:00.000' AS DateTime), 525)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0026', N'Lư Kiều Bảo Nghi', N'93 Trần Nhân Tôn, phường 2, Quận 10', CAST(N'1985-07-03T00:00:00.000' AS DateTime), 526)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0027', N'Nguyễn Gia Hân', N'553, Nguyễn Tri Phương, Quận 10', CAST(N'1985-08-03T00:00:00.000' AS DateTime), 527)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0028', N'Hùyng Thị Cẩm Hường', N'249 Hoà Hảo,phường 3,Quận 10', CAST(N'1985-09-03T00:00:00.000' AS DateTime), 528)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0029', N'Phan Nguyễn Nhất Kiệt', N'3 Dương Đình Nghệ, Q11', CAST(N'1985-10-03T00:00:00.000' AS DateTime), 529)
INSERT [dbo].[GiaoVien] ([MaGV], [HoTen], [DiaChi], [NgaySinh], [NguoiDungID]) VALUES (N'GV0030', N'Lạc Minh Luân', N'Lạc Long Quân Q11', CAST(N'1985-11-03T00:00:00.000' AS DateTime), 530)
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0001', N'10A1      ', N'Nguyễn Hoài An', CAST(N'2004-01-01T00:00:00.000' AS DateTime), 531, N'25/3 Lạc Long Quân, Q.10, TP HCM')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0002', N'10A1      ', N'Trần Trà Hương', CAST(N'2004-02-02T00:00:00.000' AS DateTime), 532, N'125 Trần Hưng Đạo, Q.1,TP HCM')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0003', N'10A1      ', N'Nguyễn Ngọc Ánh', CAST(N'2004-03-05T00:00:00.000' AS DateTime), 533, N'12/21 Võ Văn Ngân Thủ Đức, TP HCM')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0004', N'10A1      ', N'Trương Nam Sơn', CAST(N'2004-04-06T00:00:00.000' AS DateTime), 534, N'215 Lý Thường Kiệt,TP Biên Hòa')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0005', N'10A2      ', N'Lý Hoàng Hà', CAST(N'2004-05-08T00:00:00.000' AS DateTime), 535, N'22/5 Nguyễn Xí, Q.Bình Thạnh, TP HCM')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0006', N'10A2      ', N'Trần Bạch Tuyết', CAST(N'2004-06-09T00:00:00.000' AS DateTime), 536, N'127 Hùng Vương, TP Mỹ Tho')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0007', N'10A2      ', N'Nguyễn An Trung', CAST(N'2004-07-11T00:00:00.000' AS DateTime), 537, N'234 3/2, TP Biên Hòa')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0008', N'10A2      ', N'Trần Trung Hiếu', CAST(N'2004-08-12T00:00:00.000' AS DateTime), 538, N'22/11 Lý Thường Kiệt, TP Mỹ Tho')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0009', N'10A2      ', N'Trần Hoàng Nam', CAST(N'2004-03-03T00:00:00.000' AS DateTime), 539, N'234 Trấn Não, An Phú,TP HCM')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0010', N'11A1      ', N'Phạm Nam Thanh', CAST(N'2003-01-01T00:00:00.000' AS DateTime), 540, N'221 Hùng Vương, Q.5, TP HCM')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0011', N'11A1      ', N'Nguyễn Trọng Chiến', CAST(N'2003-02-01T00:00:00.000' AS DateTime), 541, N'235 Nguyễn Văn Cừ, phường 4, quận 5')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0012', N'11A1      ', N'Hoàng Đức Duy', CAST(N'2003-03-01T00:00:00.000' AS DateTime), 542, N'20 Lý Tự Trọng, P. Bến Nghé, Quận 1')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0013', N'11A1      ', N'Nguyễn Thanh Kim Lan', CAST(N'2003-04-01T00:00:00.000' AS DateTime), 543, N'153 Nguyễn Chí Thanh, Phường 9, Quận 5')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0014', N'11A1      ', N'Đoàn Thị Diễm My', CAST(N'2003-05-01T00:00:00.000' AS DateTime), 544, N'280 An Dương Vương, Phường 4, Quận 5')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0015', N'11A2      ', N'Lê Thị Mai Suốt', CAST(N'2003-06-01T00:00:00.000' AS DateTime), 545, N'649 Hoàng Văn Thụ, Phường 4, .Q.Tân Bình')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0016', N'11A2      ', N'Nguyễn Thị Anh Thư', CAST(N'2003-07-01T00:00:00.000' AS DateTime), 546, N'44 Võ Oanh, Phường 25, Q. Bình Thạnh')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0017', N'11A2      ', N'Đặng Văn Giàu', CAST(N'2003-08-01T00:00:00.000' AS DateTime), 547, N'4, Tân Hòa Đông, Quận 6')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0018', N'11A2      ', N'Lê Nhật Huế', CAST(N'2003-09-01T00:00:00.000' AS DateTime), 548, N'11 Đoàn Kết, Bình Thọ, Q. Thủ Đức')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0019', N'11A2      ', N'Dương Quốc Huy', CAST(N'2003-10-01T00:00:00.000' AS DateTime), 549, N'215 Đường Hoàng Ngân, Phường 16, Quận 8')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0020', N'12A1      ', N'Phạm Trí Luân', CAST(N'2002-01-02T00:00:00.000' AS DateTime), 550, N'43 Điện Biên Phủ, P Đa Kao, Q1')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0021', N'12A1      ', N'Nguyễn Thị Ngọc Mai', CAST(N'2002-02-02T00:00:00.000' AS DateTime), 551, N'A10/3D Mai Bá Hương, Ấp 1, Lê Minh Xuân, Bình Chánh, Hồ Chí Minh')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0022', N'12A1      ', N'Nguyễn Phi Phàm', CAST(N'2002-03-02T00:00:00.000' AS DateTime), 552, N'3A Nguyễn Bỉnh Khiêm, P. Bến Nghé, Quận 1')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0023', N'12A1      ', N'Dương Vĩnh Phúc', CAST(N'2002-04-02T00:00:00.000' AS DateTime), 553, N'73–75 Bùi Thị Xuân, P. Phạm Ngũ Lão, Quận 1')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0024', N'12A1      ', N'Trần Thị Mỹ Phượng', CAST(N'2002-05-02T00:00:00.000' AS DateTime), 554, N'Số 8 Trần Hưng Đạo- phường Phạm Ngũ Lão- Quận 1')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0025', N'12A2      ', N'Ngô Thành Tài', CAST(N'2002-06-02T00:00:00.000' AS DateTime), 555, N'117/4H Hồ Văn Long Khu phố 2, Phường Tân Tạo')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0026', N'12A2      ', N'Lâm Hùynh Phan Thanh', CAST(N'2002-07-02T00:00:00.000' AS DateTime), 556, N'131 Cô Bắc, P. Cô Giang, Quận 1')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0027', N'12A2      ', N'Nguyễn Thị Cẩm Tiên', CAST(N'2002-08-02T00:00:00.000' AS DateTime), 557, N'47 Nguyễn Thị Định, P. Bình Trưng Tây, TP. Thủ Đức')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0028', N'12A2      ', N'Nguyễn Thị Thanh Tuyền', CAST(N'2002-09-02T00:00:00.000' AS DateTime), 558, N'1 Vũ Tông Phan, P. An Phú, TP. Thủ Đức')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0029', N'12A2      ', N'Nguyễn Phong Vinh', CAST(N'2002-10-02T00:00:00.000' AS DateTime), 559, N'595 Kinh Dương Vương, P. An Lạc, Bình Tân')
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh], [NguoiDungID], [DiaChi]) VALUES (N'HS0030', N'12A2      ', N'Nguyễn Ngọc Ánh', CAST(N'2002-11-02T00:00:00.000' AS DateTime), 560, N'275 Điện Biên Phủ, P. Võ Thị Sáu, Quận 3')
INSERT [dbo].[KT_DT] ([MaKT], [MaDT]) VALUES (N'KT0123434', N'DT02')
INSERT [dbo].[KT_HS] ([MaKT], [MaHS]) VALUES (N'KT0123434', N'HS0001')
INSERT [dbo].[KT_HS] ([MaKT], [MaHS]) VALUES (N'KT0123434', N'HS0004')
INSERT [dbo].[KT_HS] ([MaKT], [MaHS]) VALUES (N'KT0123434', N'HS0006')
INSERT [dbo].[KyThi] ([MaKT], [TenKT], [LoaiKT], [MaCapHoc], [NgayBD], [NgayKT], [MaGV]) VALUES (N'KT0123434', N'GKIuysdf', 1, 1, CAST(N'2021-01-17T12:12:50.000' AS DateTime), CAST(N'2021-01-18T12:12:55.000' AS DateTime), NULL)
INSERT [dbo].[KyThi] ([MaKT], [TenKT], [LoaiKT], [MaCapHoc], [NgayBD], [NgayKT], [MaGV]) VALUES (N'KT02', N'sdf', 1, 1, CAST(N'2021-01-05T14:14:42.000' AS DateTime), CAST(N'2021-01-27T14:14:47.000' AS DateTime), N'GV0008')
INSERT [dbo].[LoaiKiThi] ([LoaiKiThi], [TenLoaiKiThi]) VALUES (1, N'Thi chính thức')
INSERT [dbo].[LoaiKiThi] ([LoaiKiThi], [TenLoaiKiThi]) VALUES (2, N'Ôn tập')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'AV', N'Anh Văn')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'DL', N'Địa Lý')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'HH', N'Hóa Học')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'LS', N'Lịch Sử')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'SH', N'Sinh Học')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'T', N'Toán')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'VL', N'Vật Lý')
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (501, N'gv60                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (502, N'gv61                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (503, N'gv62                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (504, N'gv63                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (505, N'gv64                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (506, N'gv65                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (507, N'gv66                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (508, N'gv67                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (509, N'gv68                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (510, N'gv69                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (511, N'gv70                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (512, N'gv71                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (513, N'gv72                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (514, N'gv73                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (515, N'gv74                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (516, N'gv75                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (517, N'gv76                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (518, N'gv77                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (519, N'gv78                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (520, N'gv79                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (521, N'gv80                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (522, N'gv81                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (523, N'gv82                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (524, N'gv83                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (525, N'gv84                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (526, N'gv85                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (527, N'gv86                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (528, N'gv87                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (529, N'gv88                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (530, N'gv89                                              ', N'123                                                                                                 ', 2)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (531, N'hs30                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (532, N'hs31                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (533, N'hs32                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (534, N'hs33                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (535, N'hs34                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (536, N'hs35                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (537, N'hs36                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (538, N'hs37                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (539, N'hs38                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (540, N'hs39                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (541, N'hs40                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (542, N'hs41                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (543, N'hs42                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (544, N'hs43                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (545, N'hs44                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (546, N'hs45                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (547, N'hs46                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (548, N'hs47                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (549, N'hs48                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (550, N'hs49                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (551, N'hs50                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (552, N'hs51                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (553, N'hs52                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (554, N'hs53                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (555, N'hs54                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (556, N'hs55                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (557, N'hs56                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (558, N'hs57                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (559, N'hs58                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (560, N'hs59                                              ', N'123                                                                                                 ', 3)
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [TenTaiKhoan], [MatKhauHash], [Quyen]) VALUES (561, N'ad                                                ', N'123                                                                                                 ', 1)
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
INSERT [dbo].[Quyen] ([QuyenID], [TenQuyen]) VALUES (1, N'Admin')
INSERT [dbo].[Quyen] ([QuyenID], [TenQuyen]) VALUES (2, N'Giáo viên')
INSERT [dbo].[Quyen] ([QuyenID], [TenQuyen]) VALUES (3, N'Học sinh')
ALTER TABLE [dbo].[BaiLamHS]  WITH CHECK ADD  CONSTRAINT [FK_BL_DT] FOREIGN KEY([MaDT])
REFERENCES [dbo].[DeThi] ([MaDeThi])
GO
ALTER TABLE [dbo].[BaiLamHS] CHECK CONSTRAINT [FK_BL_DT]
GO
ALTER TABLE [dbo].[BaiLamHS]  WITH CHECK ADD  CONSTRAINT [FK_BL_KT] FOREIGN KEY([MaKT])
REFERENCES [dbo].[KyThi] ([MaKT])
GO
ALTER TABLE [dbo].[BaiLamHS] CHECK CONSTRAINT [FK_BL_KT]
GO
ALTER TABLE [dbo].[BaiLamHS]  WITH CHECK ADD  CONSTRAINT [FK_BL_ND] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([IDNguoiDung])
GO
ALTER TABLE [dbo].[BaiLamHS] CHECK CONSTRAINT [FK_BL_ND]
GO
ALTER TABLE [dbo].[CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_CauHoi_CapDo] FOREIGN KEY([CapDo])
REFERENCES [dbo].[CapDo] ([MaCapDo])
GO
ALTER TABLE [dbo].[CauHoi] CHECK CONSTRAINT [FK_CauHoi_CapDo]
GO
ALTER TABLE [dbo].[CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_CauHoi_CapHoc] FOREIGN KEY([CapHoc])
REFERENCES [dbo].[CapHoc] ([IDCapHoc])
GO
ALTER TABLE [dbo].[CauHoi] CHECK CONSTRAINT [FK_CauHoi_CapHoc]
GO
ALTER TABLE [dbo].[CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_CauHoi_MonHoc] FOREIGN KEY([MonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[CauHoi] CHECK CONSTRAINT [FK_CauHoi_MonHoc]
GO
ALTER TABLE [dbo].[CauTraLoi]  WITH CHECK ADD  CONSTRAINT [FK_CTL_CH] FOREIGN KEY([CauHoiID])
REFERENCES [dbo].[CauHoi] ([IDCauHoi])
GO
ALTER TABLE [dbo].[CauTraLoi] CHECK CONSTRAINT [FK_CTL_CH]
GO
ALTER TABLE [dbo].[CauTraLoi]  WITH CHECK ADD  CONSTRAINT [FK_CTL_DT] FOREIGN KEY([MaDeThi])
REFERENCES [dbo].[DeThi] ([MaDeThi])
GO
ALTER TABLE [dbo].[CauTraLoi] CHECK CONSTRAINT [FK_CTL_DT]
GO
ALTER TABLE [dbo].[CauTraLoi]  WITH CHECK ADD  CONSTRAINT [FK_CTL_KT] FOREIGN KEY([MaKyThi])
REFERENCES [dbo].[KyThi] ([MaKT])
GO
ALTER TABLE [dbo].[CauTraLoi] CHECK CONSTRAINT [FK_CTL_KT]
GO
ALTER TABLE [dbo].[CauTraLoi]  WITH CHECK ADD  CONSTRAINT [FK_CTL_ND] FOREIGN KEY([NguoiDungID])
REFERENCES [dbo].[NguoiDung] ([IDNguoiDung])
GO
ALTER TABLE [dbo].[CauTraLoi] CHECK CONSTRAINT [FK_CTL_ND]
GO
ALTER TABLE [dbo].[DapAn]  WITH CHECK ADD  CONSTRAINT [FK_DA_CH] FOREIGN KEY([IDCauHoi])
REFERENCES [dbo].[CauHoi] ([IDCauHoi])
GO
ALTER TABLE [dbo].[DapAn] CHECK CONSTRAINT [FK_DA_CH]
GO
ALTER TABLE [dbo].[DeThi]  WITH CHECK ADD  CONSTRAINT [FK_KT_CH] FOREIGN KEY([MaCapHoc])
REFERENCES [dbo].[CapHoc] ([IDCapHoc])
GO
ALTER TABLE [dbo].[DeThi] CHECK CONSTRAINT [FK_KT_CH]
GO
ALTER TABLE [dbo].[DeThi_CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_DT_CH__CH] FOREIGN KEY([IDCauHoi])
REFERENCES [dbo].[CauHoi] ([IDCauHoi])
GO
ALTER TABLE [dbo].[DeThi_CauHoi] CHECK CONSTRAINT [FK_DT_CH__CH]
GO
ALTER TABLE [dbo].[DeThi_CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_DT_CH__DT] FOREIGN KEY([MaDT])
REFERENCES [dbo].[DeThi] ([MaDeThi])
GO
ALTER TABLE [dbo].[DeThi_CauHoi] CHECK CONSTRAINT [FK_DT_CH__DT]
GO
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
ALTER TABLE [dbo].[KyThi]  WITH CHECK ADD  CONSTRAINT [FK_KT_LKT] FOREIGN KEY([LoaiKT])
REFERENCES [dbo].[LoaiKiThi] ([LoaiKiThi])
GO
ALTER TABLE [dbo].[KyThi] CHECK CONSTRAINT [FK_KT_LKT]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_Quyen] FOREIGN KEY([Quyen])
REFERENCES [dbo].[Quyen] ([QuyenID])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_Quyen]
GO
