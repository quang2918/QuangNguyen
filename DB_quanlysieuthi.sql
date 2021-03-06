USE [Quanlybanhang]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 05/28/2017 16:36:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [nchar](10) NOT NULL,
	[tennhanvien] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [nchar](3) NULL,
	[sdt] [int] NULL,
	[matkhau] [nchar](20) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'          ', N'', CAST(0x5B950A00 AS Date), N'   ', 0, N'                    ', N'')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N001      ', N'Nguyễn Anh Quang', CAST(0xE71E0B00 AS Date), N'Nam', 1674102566, N'123                 ', N'Hoàng Quốc Việt')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N002      ', N'Nguyễn Hoài Nam', CAST(0xF91C0B00 AS Date), N'Nam', 1674102588, N'145                 ', N'Cầu Giấy')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N003      ', N'Trần Hoàng Thu', CAST(0x351F0B00 AS Date), N'Nữ ', 1674102884, N'111                 ', N'Hồ Tùng Mậu')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N004      ', N'Trần Thị Định', CAST(0x7B1C0B00 AS Date), N'Nữ ', 1674108133, N'122                 ', N'Trường Trinh')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N005      ', N'Trần Du', CAST(0x6D240B00 AS Date), N'Nam', 1674102145, N'126                 ', N'Hoàng Quốc Việt')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N006      ', N'Huỳnh Tú Tài', CAST(0x5B950A00 AS Date), N'Nam', 1674105566, N'111                 ', N'Quận 1')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N007      ', N'Lưu Duy Vũ', CAST(0x381C0B00 AS Date), N'Nam', 1674102544, N'154                 ', N'Trần Thái Tông')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N008      ', N'Nguyễn An Phước ', CAST(0xA71D0B00 AS Date), N'Nam', 1674105447, N'177                 ', N'Mai Dịch')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N009      ', N'Lê Quốc Doanh', CAST(0x82190B00 AS Date), N'Nam', 1666156554, N'156                 ', N'Sóc Sơn')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [gioitinh], [sdt], [matkhau], [diachi]) VALUES (N'N010      ', N'Hoành Tá Tràng', CAST(0x5B950A00 AS Date), N'Nam', 1674100047, N'159                 ', N'Trần Cung')
/****** Object:  Table [dbo].[khachhang]    Script Date: 05/28/2017 16:36:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhang](
	[makhachhang] [nchar](10) NOT NULL,
	[tenkhachhang] [nvarchar](50) NULL,
	[gioitinh] [nchar](3) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [int] NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K001      ', N'Nguyễn Thị Thắm', N'Nữ ', N'Hoàng Mai', 1674108855, N'tham12@gmail.com')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K002      ', N'Trần Thị Tuyết', N'Nữ ', N'Cầu Giấy', 1674102569, N'tuyet123@gmail.com')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K003      ', N'Ngô Bình Đạt', N'Nam', N'Ấp Vuông', 1674102420, N'ngobinhdat@gmail.com')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K004      ', N'Nguyễn Quỳnh Anh', N'Nữ ', N'Bùi Xương Trạch', 1666392613, N'nguyenquynhanh@gmail.com')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K005      ', N'Trần Văn Du', N'Nam', N'Láng', 167466859, N'tranvandu69@gmail.com')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K006      ', N'Phan Văn Khải', N'Nam', N'Cầu Giấy', 1674105567, N'phanvankhai@gmail.com')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K007      ', N'Trần Văn Trữ', N'Nam', N'Mai Dịch', 1674108790, NULL)
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K009      ', N'Phạm Thị Oanh', N'Nữ ', N'Hoàng Hoa Thám', 1674104471, N'phamthioanh@gmail.com')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K010      ', N'Trần Hoài Nam', N'Nam', N'Phạm Văn Đồng', 1674105578, N'')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [diachi], [sdt], [email]) VALUES (N'K011      ', N'Nguyễn Thị Tươi', N'Nữ ', N'Quận 2', 1674108885, N'tuoi12@gmail.com')
/****** Object:  Table [dbo].[hanghoa]    Script Date: 05/28/2017 16:36:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hanghoa](
	[mahang] [nchar](10) NOT NULL,
	[tenhang] [nvarchar](50) NULL,
	[dongia] [float] NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_hanghoa] PRIMARY KEY CLUSTERED 
(
	[mahang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H001      ', N'Bánh đậu xanh', 30000, 15)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H002      ', N'mật ong', 50000, 10)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H003      ', N'dép tổ ong', 20000, 50)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H004      ', N'bút chì ', 5000, 15)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H005      ', N'bút chì màu', 7000, 10)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H006      ', N'tai nghe iphone5', 20000, 40)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H007      ', N'tai nghe samsung ', 20000, 40)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H008      ', N'Ví da nam', 50000, 15)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H009      ', N'Túi đeo chéo nam', 100000, 20)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H010      ', N'Balo nam adidas', 200000, 10)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H011      ', N'Balo nam Gen', 300000, 15)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H012      ', N'Balo du lịch nam', 250000, 10)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H013      ', N'Balo du lịch nữ', 220000, 10)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H014      ', N'Tông Thái', 35000, 20)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H015      ', N'Kéo siêu bền', 15000, 40)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H016      ', N'Băng dính 2 mặt', 15000, 20)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H017      ', N'Băng dính trắng ', 50000, 40)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H018      ', N'Sổ tay Bali ', 15000, 20)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H019      ', N'Sổ tay Saudi', 20000, 10)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H020      ', N'Tông VietNam', 30000, 50)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H021      ', N'Keo dính giấy ', 3000, 15)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H022      ', N'Keo 502', 5000, 15)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H023      ', N'Bánh chocopie', 40000, 15)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H024      ', N'Bánh bông lan', 30000, 20)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H025      ', N'kẹo oishi ổi', 5000, 20)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H026      ', N'Kẹo oishi bạc hà', 5000, 20)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H027      ', N'Mắm Long Hải', 15000, 20)
INSERT [dbo].[hanghoa] ([mahang], [tenhang], [dongia], [soluong]) VALUES (N'H028      ', N'Mắm Nam Ngư', 27000, 30)
/****** Object:  Table [dbo].[chitiethoadon]    Script Date: 05/28/2017 16:36:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiethoadon](
	[mahoadon] [nchar](10) NOT NULL,
	[mahanghoa] [nchar](10) NOT NULL,
	[dongianban] [float] NULL,
	[soluongban] [int] NULL,
 CONSTRAINT [PK_hopdong] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC,
	[mahanghoa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chitiethoadon] ([mahoadon], [mahanghoa], [dongianban], [soluongban]) VALUES (N'HD001     ', N'H001      ', 30000, 5)
INSERT [dbo].[chitiethoadon] ([mahoadon], [mahanghoa], [dongianban], [soluongban]) VALUES (N'HD002     ', N'H002      ', 50000, 1)
INSERT [dbo].[chitiethoadon] ([mahoadon], [mahanghoa], [dongianban], [soluongban]) VALUES (N'HD003     ', N'H003      ', 20000, 2)
INSERT [dbo].[chitiethoadon] ([mahoadon], [mahanghoa], [dongianban], [soluongban]) VALUES (N'HD004     ', N'H002      ', 50000, 2)
INSERT [dbo].[chitiethoadon] ([mahoadon], [mahanghoa], [dongianban], [soluongban]) VALUES (N'HD005     ', N'H010      ', 200000, 1)
/****** Object:  Table [dbo].[hoadon]    Script Date: 05/28/2017 16:36:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahoadon] [nchar](10) NOT NULL,
	[manhanvien] [nchar](10) NOT NULL,
	[makhachhang] [nchar](10) NOT NULL,
	[ngaylap] [date] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC,
	[manhanvien] ASC,
	[makhachhang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[hoadon] ([mahoadon], [manhanvien], [makhachhang], [ngaylap]) VALUES (N'D001      ', N'N001      ', N'K001      ', CAST(0x633B0B00 AS Date))
INSERT [dbo].[hoadon] ([mahoadon], [manhanvien], [makhachhang], [ngaylap]) VALUES (N'D002      ', N'N001      ', N'K002      ', CAST(0xDD3C0B00 AS Date))
INSERT [dbo].[hoadon] ([mahoadon], [manhanvien], [makhachhang], [ngaylap]) VALUES (N'D003      ', N'N002      ', N'k003      ', CAST(0x4D3B0B00 AS Date))
/****** Object:  ForeignKey [FK_hopdong_hanghoa]    Script Date: 05/28/2017 16:36:21 ******/
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD  CONSTRAINT [FK_hopdong_hanghoa] FOREIGN KEY([mahanghoa])
REFERENCES [dbo].[hanghoa] ([mahang])
GO
ALTER TABLE [dbo].[chitiethoadon] CHECK CONSTRAINT [FK_hopdong_hanghoa]
GO
/****** Object:  ForeignKey [FK_hoadon_khachhang1]    Script Date: 05/28/2017 16:36:21 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khachhang1] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khachhang1]
GO
/****** Object:  ForeignKey [FK_hoadon_nhanvien1]    Script Date: 05/28/2017 16:36:21 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_nhanvien1] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_nhanvien1]
GO
