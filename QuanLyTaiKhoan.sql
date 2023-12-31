create database QuanLyTaiKhoan
go
USE [QuanLyTaiKhoan]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TieuDe] [nvarchar](500) NOT NULL,
	[NoiDung] [ntext] NOT NULL,
	[HinhAnh] [nvarchar](255) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgaySua] [datetime] NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[MaTK] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BaiDang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BinhLuan]    Script Date: 12/16/2022 23:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BinhLuan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDBaiDang] [int] NULL,
	[NoiDung] [ntext] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[MaTK] [nvarchar](50) NULL,
 CONSTRAINT [PK_BinhLuan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [nvarchar](50) NOT NULL,
	[TenTK] [nvarchar](100) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[SDT] [nvarchar](20) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BaiDang] ON 

INSERT [dbo].[BaiDang] ([ID], [TieuDe], [NoiDung], [HinhAnh], [NgayTao], [NgaySua], [TrangThai], [MaTK]) VALUES (7, N'cdef', N'cdef', N'', CAST(N'2022-12-16T23:18:38.583' AS DateTime), CAST(N'2022-12-16T23:44:53.717' AS DateTime), 1, N'abc')
INSERT [dbo].[BaiDang] ([ID], [TieuDe], [NoiDung], [HinhAnh], [NgayTao], [NgaySua], [TrangThai], [MaTK]) VALUES (8, N'áđâsd', N'âdsfsadf', N'R:\Gmail Logo_48px.png', CAST(N'2022-12-16T23:44:18.930' AS DateTime), CAST(N'2022-12-16T23:44:18.930' AS DateTime), 1, N'abc')
SET IDENTITY_INSERT [dbo].[BaiDang] OFF
GO
SET IDENTITY_INSERT [dbo].[BinhLuan] ON 

INSERT [dbo].[BinhLuan] ([ID], [IDBaiDang], [NoiDung], [NgayTao], [TrangThai], [MaTK]) VALUES (5, 7, N'vvvvvvvv', CAST(N'2022-12-16T23:38:41.937' AS DateTime), 1, N'tiennam')
SET IDENTITY_INSERT [dbo].[BinhLuan] OFF
GO
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [Email], [SDT], [TrangThai]) VALUES (N'conghau', N'Công Hậu', N'123', N'haudang2212@gmail.com', N'0788045380', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [Email], [SDT], [TrangThai]) VALUES (N'abc', N'Phùng Quang', N'123', N'phungquang@gmail.com', N'3882429492', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [Email], [SDT], [TrangThai]) VALUES (N'pdquang', N'Hoàng Nam', N'123', N'12123', N'434343', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [Email], [SDT], [TrangThai]) VALUES (N'tiennam', N'Lam', N'123', N'32424', N'332', 1)
GO
ALTER TABLE [dbo].[BaiDang]  WITH CHECK ADD  CONSTRAINT [FK_BaiDang_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[BaiDang] CHECK CONSTRAINT [FK_BaiDang_TaiKhoan]
GO
ALTER TABLE [dbo].[BinhLuan]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuan_BaiDang] FOREIGN KEY([IDBaiDang])
REFERENCES [dbo].[BaiDang] ([ID])
GO
ALTER TABLE [dbo].[BinhLuan] CHECK CONSTRAINT [FK_BinhLuan_BaiDang]
GO
ALTER TABLE [dbo].[BinhLuan]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuan_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[BinhLuan] CHECK CONSTRAINT [FK_BinhLuan_TaiKhoan]
GO

select* from TaiKhoan
select * from BaiDang
select * from BinhLuan