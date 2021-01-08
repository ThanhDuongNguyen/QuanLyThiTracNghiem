USE [QLThi]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 1/9/2021 12:12:31 AM ******/
DROP TABLE [dbo].[HocSinh]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 1/9/2021 12:12:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [int] NOT NULL,
	[Lop] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[HocSinh] ([MaHS], [Lop], [HoTen], [NgaySinh]) VALUES (1, N'17CK2     ', N'Nguyễn Thanh Dương', CAST(N'1999-10-15T00:00:00.000' AS DateTime))
