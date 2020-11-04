create database QuanLyBanHangQuaMang
go

use QuanLyBanHangQuaMang
go

/*---------------------------------------------- THIẾT KẾ CƠ SỞ DỮ LIỆU ------------------------------------------- */

/* Bảng KHACH_HANG */
create table KHACH_HANG
(
	MaKH int not null identity(100,1),
	TenKH nvarchar(50) not null,
	Email varchar(50) not null,
	MatKhau varchar(50) not null,
	SDT_KH varchar(10),
	TinhTrangCMT int not null,		-- (0 - ko dc cmt, 1 - duoc cmt)
	XetTangQua int not null			-- (0 - ko tang qua, 1 - duoc tang qua)
	primary key (MaKH)
)

/* Bảng NHAN_VIEN */
create table NHAN_VIEN
(
	MaNV int not null identity(1000,1),
	TenNV nvarchar(50) not null,
	Email varchar(50) not null,
	MatKhau varchar(50) not null,
	SDT_NV varchar(10),
	LoaiNV nvarchar(30)				-- Loai nhan vien
	primary key (MaNV)
)
/* Bảng NCC */
create table NCC
(
	MaNCC int not null identity(100,1),
	TenNCC nvarchar(50) not null,
	GioiThieu nvarchar(100)			--có thể giới thiệu 1 vài thông tin về NCC
	primary key (MaNCC)
)

/* Bảng MAT_HANG */
create table MAT_HANG
(
	MaMH int not null identity(100,1),
	TenMH nvarchar(50) not null,
	NCC int not null,
	LoaiMH nvarchar(50),
	SoLuongTon int not null,			--số lượng mat hang đang còn trong kho ở hiện tại
	SoLuongHangToiThieu int not null,	--so luong mat hang toi thieu cua 1 mat hang
	GiaTien money not null,
	NVQuanLy int						
	primary key (MaMH)
)

/* Bảng COMMENT */
create table COMMENT
(
	MaCMT int not null identity(1,1),
	MaMH_CMT int not null,							--cho biet mat hang nao duoc cmt
	MaKH_CMT int not null,							--cho biết khách hàng nào cmt
	LoaiCMT int not null,							-- false (0): Xau, true (1): Tot, (2) - chua phan loai 
	NgayCMT datetime not null,						--cho biết ngày khách hàng cmt
	NoiDungCMT nvarchar(100) not null,				--nội dung khách hàng góp ý (comment) cho sản phẩm
	primary key (MaCMT)
)

/* Bảng THANH_TOAN */
create table THANH_TOAN
(
	HoaDon int not null,					-- Hoa don duoc thanh toan
	KH_ThanhToan int not null,				-- KH nao thanh toan
	NV_ThanhToan int not null,				-- NV nao thuc hien thanh toan
	LoaiThanhToan int not null,				-- (0 - Dung the, 1 - Tien mat, 2 - Chua biet)
	SoTienNhan money not null,				
	SoTaiKhoan char(14)
	primary key (HoaDon,KH_ThanhToan)
)

/* Bảng TIN_NHAN_QC */
create table TIN_NHAN_QC
(
	MaTN int not null identity(1,1),			
	NgayPhatTN datetime not null,				-- ngay phat tin nhan
	KH_TN int not null,							-- ma KH duoc nhan tin
	NguoiQL int not null,						-- NV chiu trach nhiem nhan tin
	MatHang_TN int not null						-- Mat hang duoc nhan tin QC					
	primary key (MaTN,NgayPhatTN)
)

/* Bảng DOITAC_QUANGCAO */
create table DOITAC_QUANGCAO
(
	MaDTac int not null identity(200,1),		-- ma doi tac
	TenDTac nvarchar(50) not null,				-- ten doi tac
	NgayKyHD datetime not null,					-- ngay ky hop dong
	ThoiHan datetime not null,					-- thoi han hop dong
	ViTriDang nvarchar(100) not null,			-- Vi tri dang tin
	NguoiQL int not null						-- NV chiu trach nhiem quan ly
	primary key (MaDTac)
)

/* Bảng DON_HANG */
create table DON_HANG
(
	MaDH int not null identity(1000,1),
	MaKH_DatHang int not null,						--cho biết đơn hàng của khách nào
	NgayDatHang datetime not null,					--cho biết ngày khách hàng đặt đơn hàng
	SDT_KH char(10) not null,
	DiaChi_KH nvarchar(100) not null,
	Email_KH varchar(50) not null,
	TongTien money not null,						-- tổng tiền của các CTDH
	HinhThucThanhToan int not null,					-- (0 - tien mat, 1 - qua thẻ)
	TrangThaiDH int not null						-- (0 – Đã xác nhận, 1 – Đã thanh toán, 2 – Đang chuyển hàng, 3 – Giao dịch thành công, 4 - Giao dịch thất bại, Hủy đơn hàng)
	primary key (MaDH)
)

/* Bảng CHI_TIET_DON_HANG */
create table CHI_TIET_DON_HANG
(
	MaDH int not null,						--cho biet ma don hang chua CTDH
	MaMH_CTDH int not null,					--cho biết mat hang trong CTDH
	SoLuong int not null,					--số lượng của mat hang đó là bao nhiêu
	DonGia money not null,					--so luong * gia cua 1 mat hang
	TinhTrangMH nvarchar(50)				--ghi tinh trang mat hang
	primary key (MaDH, MaMH_CTDH)
)

/* Bảng HOADON_BANHANG */
create table HOADON_BANHANG
(
	MaHD int not null identity(1000,1),
	MaDH int not null,								--cho biết ma đơn hàng cua hoa don
	TinhTrangHD int not null,						-- (0 - chua thanh toan, 1 - Da thanh toan)
	NgayGiaoHang datetime,
	NhanVienGiaoHang int not null,
	NhanVienBanHang int not null,
	KhachHang int not null,							--cho biet hoa don cua KH nao
	ThuQuy int not null,
	LoaiHD int not null,							-- (0 - HD thuong, 1 - HD thanh toan the)
	TongTien money not null,						-- tổng tiền của các CTDH
	TrangThaiGiaoHang int not null					-- (0 – Chua giao, 1 – Đã giao)
	primary key (MaHD)
)

/* Bảng CHI_TIET_HOA_DON */
create table CHI_TIET_HOA_DON
(
	MaHD int not null,						--cho biet ma hoa don chua CTHD
	MaMH_CTHD int not null,					--cho biết mat hang trong CTHD
	SoLuong int not null,					--số lượng của mat hang đó là bao nhiêu
	DonGia money not null					--so luong * gia cua 1 mat hang				
	primary key (MaHD,MaMH_CTHD)
)

/* Bảng DON_NHAP_HANG */
create table DON_NHAP_HANG
(
	MaDNH int not null identity(1000,3),
	NgayNhap datetime not null,
	TongSLHangNhap int not null,
	LyDoNhap nvarchar(50),
	NCC int not null,
	TrangThaiDuyet int not null,			-- (0 - chua duyet, 1 - da duyet)
	NguoiQL int not null					-- NV chiu trach nhiem quan ly
	primary key (MaDNH)
)

/* Bảng CHI_TIET_DON_NHAP_HANG */
create table CHI_TIET_DON_NHAP_HANG
(
	MaDNH int not null,						-- cho biet ma don nhap hang chua CTDNH
	MaMH_CTDNH int not null,				--cho biết mat hang se nhap
	SoLuong int not null					--số lượng của mat hang đó là bao nhiêu				
	primary key (MaDNH,MaMH_CTDNH)
)

/* Bảng DON_TRA_HANG */
create table DON_TRA_HANG
(
	MaDTH int not null identity(1000,5),
	NgayLap datetime not null,
	DoiTac int not null,
	LyDoTra nvarchar(50),
	NguoiQL int not null
	primary key (MaDTH)
)

/* Bảng CHI_TIET_DON_TRA_HANG */
create table CHI_TIET_DON_TRA_HANG
(
	MaDTH int not null,						-- cho biet ma don tra hang chua CTDTH
	MaMH_CTDTH int not null,				--cho biết mat hang se tra lai (mat hang lay tu CTDH)
	CTDH int not null,						--cho biet ma cua CTDH chua mat hang bi tra lai
	SoLuong int not null					--số lượng của mat hang đó là bao nhiêu				
	primary key (MaDTH, MaMH_CTDTH,CTDH)
)

/***** DEFAULT *****/
GO
ALTER TABLE [dbo].[COMMENT] ADD DEFAULT ((2)) FOR [LoaiCMT]	-- CMT chua phan loai
GO
ALTER TABLE [dbo].[KHACH_HANG] ADD  DEFAULT ((0)) FOR [XetTangQua]	-- khong duoc tang qua
GO
ALTER TABLE [dbo].[KHACH_HANG] ADD  DEFAULT ((1)) FOR [TinhTrangCMT]	-- duoc phep cmt
GO
ALTER TABLE [dbo].[THANH_TOAN] ADD  DEFAULT ((2)) FOR [LoaiThanhToan]	-- Chua chon loai thanh toan
GO
ALTER TABLE [dbo].[DON_HANG] ADD  DEFAULT ((0)) FOR [HinhThucThanhToan]	-- tien mat
GO
ALTER TABLE [dbo].[DON_HANG] ADD  DEFAULT ((0)) FOR [TrangThaiDH]	-- Da xac nhan don hang
GO
ALTER TABLE [dbo].[HOADON_BANHANG] ADD  DEFAULT ((0)) FOR [TinhTrangHD]	-- Chua thanh toan
GO
ALTER TABLE [dbo].[HOADON_BANHANG] ADD  DEFAULT ((0)) FOR [TrangThaiGiaoHang]	-- Chua giao hang
GO
ALTER TABLE [dbo].[HOADON_BANHANG] ADD  DEFAULT ((0)) FOR [LoaiHD]	-- Hoa don thuong
GO
ALTER TABLE [dbo].[DON_NHAP_HANG] ADD  DEFAULT ((0)) FOR [TrangThaiDuyet]	-- chua duyet don nhap hang

/*---------------------------------------------- CÀI ĐẶT KHÓA NGOẠI ------------------------------------------- */
-- MAT_HANG --
go
alter table MAT_HANG add constraint FK_MAT_HANG_NCC foreign key(NCC) REFERENCES NCC(MaNCC)
alter table MAT_HANG add constraint FK_MAT_HANG_NHAN_VIEN foreign key(NVQuanLy) REFERENCES NHAN_VIEN(MaNV)

-- COMMENT --
alter table COMMENT add constraint FK_COMMENT_KHACH_HANG foreign key(MaKH_CMT) REFERENCES KHACH_HANG(MaKH)
alter table COMMENT add constraint FK_COMMENT_MAT_HANG foreign key(MaMH_CMT) REFERENCES MAT_HANG(MaMH)

-- TIN_NHAN_QC --
alter table TIN_NHAN_QC add constraint FK_TIN_NHAN_QC_KHACH_HANG foreign key(KH_TN) REFERENCES KHACH_HANG(MaKH)
alter table TIN_NHAN_QC add constraint FK_TIN_NHAN_QC_MAT_HANG foreign key(MatHang_TN) REFERENCES MAT_HANG(MaMH)
alter table TIN_NHAN_QC add constraint FK_TIN_NHAN_QC_NHAN_VIEN foreign key(NguoiQL) REFERENCES NHAN_VIEN(MaNV)

-- DOITAC_QUANGCAO --
alter table DOITAC_QUANGCAO add constraint FK_DOITAC_QUANGCAO_NHAN_VIEN foreign key(NguoiQL) REFERENCES NHAN_VIEN(MaNV)

-- DON_HANG --
alter table DON_HANG add constraint FK_DON_HANG_KHACH_HANG foreign key(MaKH_DatHang) REFERENCES KHACH_HANG(MaKH)

-- CHI_TIET_DON_HANG --
alter table CHI_TIET_DON_HANG add constraint FK_CHI_TIET_DON_HANG_DON_HANG foreign key(MaDH) REFERENCES DON_HANG(MaDH)
alter table CHI_TIET_DON_HANG add constraint FK_CHI_TIET_DON_HANG_MAT_HANG foreign key(MaMH_CTDH) REFERENCES MAT_HANG(MaMH)

-- HOADON_BANHANG --
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_NHAN_VIEN1 foreign key(NhanVienGiaoHang) REFERENCES NHAN_VIEN(MaNV)
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_NHAN_VIEN2 foreign key(NhanVienBanHang) REFERENCES NHAN_VIEN(MaNV)
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_NHAN_VIEN3 foreign key(ThuQuy) REFERENCES NHAN_VIEN(MaNV)
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_KHACH_HANG foreign key(KhachHang) REFERENCES KHACH_HANG(MaKH)
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_DON_HANG foreign key(MaDH) REFERENCES DON_HANG(MaDH)

--CHI_TIET_HOA_DON--
alter table CHI_TIET_HOA_DON add constraint FK_CHI_TIET_HOA_DON_HOADON_BANHANG foreign key(MaHD) REFERENCES HOADON_BANHANG(MaHD)
alter table CHI_TIET_HOA_DON add constraint FK_CHI_TIET_HOA_DON_HOADON_MAT_HANG foreign key(MaMH_CTHD) REFERENCES MAT_HANG(MaMH)

-- DON_NHAP_HANG --
alter table DON_NHAP_HANG add constraint FK_DON_NHAP_HANG_NHAN_VIEN foreign key(NguoiQL) REFERENCES NHAN_VIEN(MaNV)
alter table DON_NHAP_HANG add constraint FK_DON_NHAP_HANG_NCC foreign key(NCC) REFERENCES NCC(MaNCC)

-- CHI_TIET_DON_NHAP_HANG --
alter table CHI_TIET_DON_NHAP_HANG add constraint FK_CHI_TIET_DON_NHAP_HANG_DON_NHAP_HANG foreign key(MaDNH) REFERENCES DON_NHAP_HANG(MaDNH)
alter table CHI_TIET_DON_NHAP_HANG add constraint FK_CHI_TIET_DON_NHAP_HANG_MAT_HANG foreign key(MaMH_CTDNH) REFERENCES MAT_HANG(MaMH)

-- DON_TRA_HANG --
alter table DON_TRA_HANG add constraint FK_DON_TRA_HANG_NCC foreign key(DoiTac) REFERENCES NCC(MaNCC)
alter table DON_TRA_HANG add constraint FK_DON_TRA_HANG_NHAN_VIEN foreign key(NguoiQL) REFERENCES NHAN_VIEN(MaNV)

-- CHI_TIET_DON_TRA_HANG --
alter table CHI_TIET_DON_TRA_HANG add constraint FK_CHI_TIET_DON_TRA_HANG_DON_TRA_HANG foreign key(MaDTH) REFERENCES DON_TRA_HANG(MaDTH)
alter table CHI_TIET_DON_TRA_HANG add constraint FK_CHI_TIET_DON_TRA_HANG_CHI_TIET_DON_HANG foreign key(CTDH, MaMH_CTDTH) REFERENCES CHI_TIET_DON_HANG(MaDH, MaMH_CTDH)

-- THANH_TOAN --
alter table THANH_TOAN add constraint FK_THANH_TOAN_HOADON_BANHANG foreign key(HoaDon) REFERENCES HOADON_BANHANG(MaHD)
alter table THANH_TOAN add constraint FK_THANH_TOAN_NHAN_VIEN foreign key(NV_ThanhToan) REFERENCES NHAN_VIEN(MaNV)
alter table THANH_TOAN add constraint FK_THANH_TOAN_KHACH_HANG foreign key(KH_ThanhToan) REFERENCES KHACH_HANG(MaKH)

/*---------------------------------------------- NHAP DU LIEU ------------------------------------------- */
-- KHACH_HANG --
go
insert into KHACH_HANG (TenKH,Email,MatKhau,SDT_KH,TinhTrangCMT,XetTangQua) values (N'Nguyễn Phương Ly','ply@gmail.com','123456','0984568126',1,0);
insert into KHACH_HANG (TenKH,Email,MatKhau,SDT_KH,TinhTrangCMT,XetTangQua) values (N'Dương Văn Phong','vphong@gmail.com','vphong123','0995462398',1,0);
insert into KHACH_HANG (TenKH,Email,MatKhau,SDT_KH,TinhTrangCMT,XetTangQua) values (N'Trần Văn Thy','vthy@gmail.com','thy159','0669845632',1,0);
insert into KHACH_HANG (TenKH,Email,MatKhau,SDT_KH,TinhTrangCMT,XetTangQua) values (N'Nguyễn Thị Lan','lan@gmail.com','lan5672','0222698459',1,0);
insert into KHACH_HANG (TenKH,Email,MatKhau,SDT_KH,TinhTrangCMT,XetTangQua) values (N'Phạm Thạch Minh','minh@gmail.com','minh444','0449856236',1,0);
insert into KHACH_HANG (TenKH,Email,MatKhau,SDT_KH,TinhTrangCMT,XetTangQua) values (N'Nguyễn Văn Lý','ly@gmail.com','ly753','0984562482',1,0);

-- NHAN_VIEN --
insert into NHAN_VIEN (TenNV,Email,MatKhau,SDT_NV,LoaiNV) values (N'David','david@gmail.com','david','0369845698',N'Quản Lý');
insert into NHAN_VIEN (TenNV,Email,MatKhau,SDT_NV,LoaiNV) values (N'Bùi Phạm Phương Khanh','pkhanh@gmail.com','khanh','0336984562',N'Bán Hàng');
insert into NHAN_VIEN (TenNV,Email,MatKhau,SDT_NV,LoaiNV) values (N'Hứa Mỹ Nghi','mynghi@gmail.com','nghi','0366945810',N'Bán Hàng');
insert into NHAN_VIEN (TenNV,Email,MatKhau,SDT_NV,LoaiNV) values (N'Bùi Tấn Lân','tanlan@gmail.com','lan','0115896259',N'Đăng Tin');
insert into NHAN_VIEN (TenNV,Email,MatKhau,SDT_NV,LoaiNV) values (N'Bùi Minh Quân','minhquan@gmail.com','quan','0998469523',N'Thủ Quỹ');
insert into NHAN_VIEN (TenNV,Email,MatKhau,SDT_NV,LoaiNV) values (N'Emily Stone','emily@gmail.com','emily','0369845992',N'Giao Hàng');
insert into NHAN_VIEN (TenNV,Email,MatKhau,SDT_NV,LoaiNV) values (N'Nguyễn Văn Tần','vantan@gmail.com','tan','0798954268',N'Bán Hàng');

-- NCC --
insert into NCC (TenNCC,GioiThieu) values (N'Siêu Táo', N'Điện thoại di động và phụ kiện chính hãng');
insert into NCC (TenNCC,GioiThieu) values (N'CheckBuy', N'Chuyên bán các sản phẩm phụ kiện điện thoại chính hãng');
insert into NCC (TenNCC,GioiThieu) values (N'Gameshop Trọng Lễ', N'Chuyên cung cấp : Sony Playstation . Nintendo switch , Iphone,…');
insert into NCC (TenNCC,GioiThieu) values (N'Cửa Hàng Đồ Gia Dụng CC', NULL);
insert into NCC (TenNCC,GioiThieu) values (N'Máy Tinh Dầu', N'Chuyên cung cấp các loại máy tinh dầu');
insert into NCC (TenNCC,GioiThieu) values (N'IVY Moda', NULL);
insert into NCC (TenNCC,GioiThieu) values (N'MOLLYNISTA', NULL);
insert into NCC (TenNCC,GioiThieu) values (N'TOKBOKKI BÁNH GẠO', N' Chuyên cung cấp sỉ lẻ Bánh gạo Hàn Quốc, Gia vị Hàn Quốc,…');
insert into NCC (TenNCC,GioiThieu) values (N'Hàng Nhật Bản', NULL);
insert into NCC (TenNCC,GioiThieu) values (N'Siêu Thị Bách Hoá Thái Lan', N'Những sản phẩm ở "Siêu Thị Bách Hoá Thái Lan" được xách tay từ Thái về hoặc nhập khẩu chính hãng');

-- MAT HANG --
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Đồng hồ thông minh Samsung Galaxy Watch', 100,N'Điện tử', 200, 100, 6490000,1006);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Tai nghe Samsung AKG Jack', 100,N'Điện tử', 200, 100, 6490000,1001);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Bàn phím cơ Fuhlen Eraser', 100,N'Điện tử', 150, 50, 88000,1002);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Lò vi sóng Samsung', 100,N'Điện tử', 90, 100, 3699000,1006);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Máy tính bảng Samsung Galaxy Tab S6 Lite', 100,N'Điện tử', 110, 100, 7599000,1001);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Tai Nghe Bluetooth AP2 - Chip Jerry A8S', 101,N'Điện tử', 55, 50, 550000,1002);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Máy Playstation 4 Pro 1tb Model 7218b', 102,N'Điện tử', 52, 50, 7990000,1006);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Quạt Tích Điện Đa Năng F0326', 103,N'Gia dụng', 122, 100, 165000,1001);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Máy Xay Sinh Tố Đa Năng Cầm Tay', 103,N'Gia dụng', 130, 100, 215000,1002);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Máy may mini cao cấp có đèn', 103,N'Gia dụng', 166, 100, 164500,1006);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Máy hút bụi cầm tay mini không dây Adapter', 103,N'Gia dụng', 144, 100, 395000,1001);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Máy tinh dầu vân gỗ cao cấp', 104,N'Gia dụng', 134, 50, 225000,1002);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Ivy moda Áo Thun Trơn Cổ Đức', 105,N'Thời trang', 110, 50, 299000,1006);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Ivy moda Quần Kẻ Nam', 105,N'Thời trang', 105, 50, 399000,1001);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Ivy moda Áo sơ mi dài tay', 105,N'Thời trang', 144, 50, 499000,1002);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'MOLLYNISTA Áo Tiana đen tay len trắng dài', 106,N'Thời trang', 70, 50, 550000,1006);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'MOLLYNISTA Đầm Lisa xám organza', 106,N'Thời trang', 55, 50, 950000,1001);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Bánh yến mạch Hàn quốc gói 400G', 107,N'Thực phẩm', 75, 50, 195000,1002);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Bánh gạo Hàn quốc gói 1KG', 107,N'Thực phẩm', 88, 50, 55000,1002);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'2 túi Ngũ cốc Calbee 800g nội địa Nhật Bản', 108,N'Thực phẩm', 53, 50, 360000,1006);
insert into MAT_HANG(TenMH,NCC,LoaiMH,SoLuongTon,SoLuongHangToiThieu,GiaTien,NVQuanLy) values (N'Kẹo ngậm Play More xí muội thái lan', 109,N'Thực phẩm', 200, 50, 15000,1001);

--COMMENT --
insert into COMMENT(MaMH_CMT,MaKH_CMT,NgayCMT,LoaiCMT,NoiDungCMT) values (100,100,'2020-08-08',1,N'Hàng tốt, chất lượng');
insert into COMMENT(MaMH_CMT,MaKH_CMT,NgayCMT,LoaiCMT,NoiDungCMT) values (120,101,'2020-08-09',1,N'Kẹo dở, nên dẹp đi');
insert into COMMENT(MaMH_CMT,MaKH_CMT,NgayCMT,LoaiCMT,NoiDungCMT) values (106,102,'2020-08-08',1,N'Đồ xịn, đẹp');
insert into COMMENT(MaMH_CMT,MaKH_CMT,NgayCMT,LoaiCMT,NoiDungCMT) values (116,103,'2020-08-12',1,N'Áp đẹp');

--TIN_NHAN_QC --
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-08',100,1003,100);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-08',101,1003,100);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-08',102,1003,100);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-08',103,1003,100);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-08',104,1003,100);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-09',100,1003,101);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-09',101,1003,101);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-09',102,1003,101);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-09',103,1003,101);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-09',104,1003,101);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-10',100,1003,110);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-10',101,1003,110);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-10',102,1003,110);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-10',103,1003,110);
insert into TIN_NHAN_QC(NgayPhatTN,KH_TN,NguoiQL,MatHang_TN) values ('2020-08-10',104,1003,110);

-- DOITAC_QUANGCAO --
insert into DOITAC_QUANGCAO (TenDTac,NgayKyHD,ThoiHan,ViTriDang,NguoiQL) values ('IVY Moda','2020-05-10','2020-06-10',N'Đầu trang giới thiệu nhãn hàng',1003);
insert into DOITAC_QUANGCAO (TenDTac,NgayKyHD,ThoiHan,ViTriDang,NguoiQL) values ('MOLLYNISTA','2020-06-10','2020-07-10',N'Đầu trang giới thiệu nhãn hàng',1003);
insert into DOITAC_QUANGCAO (TenDTac,NgayKyHD,ThoiHan,ViTriDang,NguoiQL) values ('IVY Moda','2020-08-10','2020-10-10',N'Đầu trang giới thiệu nhãn hàng',1003);
insert into DOITAC_QUANGCAO (TenDTac,NgayKyHD,ThoiHan,ViTriDang,NguoiQL) values ('MOLLYNISTA','2020-08-12','2020-10-12',N'Đầu trang giới thiệu nhãn hàng',1003);

-- DON_HANG--
insert into DON_HANG(MaKH_DatHang,NgayDatHang,SDT_KH,DiaChi_KH,Email_KH,TongTien,HinhThucThanhToan,TrangThaiDH) values (100,'2020-08-08','0984623698',N'360 Lê Đức Thọ, phường 6, Gò Vấp','ply@gmail.com',6490000,0,1);
insert into DON_HANG(MaKH_DatHang,NgayDatHang,SDT_KH,DiaChi_KH,Email_KH,TongTien,HinhThucThanhToan,TrangThaiDH) values (101,'2020-08-05','0944568823',N'90 quận 1','vphong@gmail.com',30000,1,1);
insert into DON_HANG(MaKH_DatHang,NgayDatHang,SDT_KH,DiaChi_KH,Email_KH,TongTien,HinhThucThanhToan,TrangThaiDH) values (102,'2020-08-08','0971698899',N'33/56 Nguyễn Tất Thành','vthy@gmail.com',395000,0,1);
insert into DON_HANG(MaKH_DatHang,NgayDatHang,SDT_KH,DiaChi_KH,Email_KH,TongTien,HinhThucThanhToan,TrangThaiDH) values (103,'2020-08-12','0222698459',N'290 Lê Đức Thọ, phường 7, Gò Vấp','lan@gmail.com',110000,0,1);

-- CTĐH --
insert into CHI_TIET_DON_HANG(MaDH,MaMH_CTDH,SoLuong,DonGia,TinhTrangMH) values (1000,101,1,6490000,N'Bị trả lại');
insert into CHI_TIET_DON_HANG(MaDH,MaMH_CTDH,SoLuong,DonGia,TinhTrangMH) values (1001,120,2,30000,N'Tốt');
insert into CHI_TIET_DON_HANG(MaDH,MaMH_CTDH,SoLuong,DonGia,TinhTrangMH) values (1002,110,1,395000,N'Tốt');
insert into CHI_TIET_DON_HANG(MaDH,MaMH_CTDH,SoLuong,DonGia,TinhTrangMH) values (1003,118,2,110000,N'Bị trả lại');

-- HOA_DON --
insert into HOADON_BANHANG(MaDH,TinhTrangHD,NgayGiaoHang,NhanVienGiaoHang,NhanVienBanHang,KhachHang,ThuQuy,LoaiHD,TongTien,TrangThaiGiaoHang)
values (1000,1,'2020-08-10',1005,1001,100,1004,0,6490000,1);
insert into HOADON_BANHANG(MaDH,TinhTrangHD,NgayGiaoHang,NhanVienGiaoHang,NhanVienBanHang,KhachHang,ThuQuy,LoaiHD,TongTien,TrangThaiGiaoHang)
values (1001,1,'2020-08-07',1005,1001,101,1004,1,30000,1);
insert into HOADON_BANHANG(MaDH,TinhTrangHD,NgayGiaoHang,NhanVienGiaoHang,NhanVienBanHang,KhachHang,ThuQuy,LoaiHD,TongTien,TrangThaiGiaoHang)
values (1002,1,'2020-08-10',1005,1002,102,1004,0,395000,1);
insert into HOADON_BANHANG(MaDH,TinhTrangHD,NgayGiaoHang,NhanVienGiaoHang,NhanVienBanHang,KhachHang,ThuQuy,LoaiHD,TongTien,TrangThaiGiaoHang)
values (1003,1,'2020-08-14',1005,1002,103,1004,0,110000,0);

-- CTHĐ --
insert into CHI_TIET_HOA_DON(MaHD,MaMH_CTHD,SoLuong,DonGia)values(1000,101,1,6490000);
insert into CHI_TIET_HOA_DON(MaHD,MaMH_CTHD,SoLuong,DonGia)values(1001,120,2,30000);
insert into CHI_TIET_HOA_DON(MaHD,MaMH_CTHD,SoLuong,DonGia)values(1002,110,1,395000);
insert into CHI_TIET_HOA_DON(MaHD,MaMH_CTHD,SoLuong,DonGia)values(1003,118,2,110000);

-- THANH TOAN --
insert into THANH_TOAN(HoaDon,KH_ThanhToan,NV_ThanhToan,LoaiThanhToan,SoTienNhan,SoTaiKhoan)
values(1000,100,1004,0,6490000,'01563987452168');
insert into THANH_TOAN(HoaDon,KH_ThanhToan,NV_ThanhToan,LoaiThanhToan,SoTienNhan,SoTaiKhoan)
values(1001,101,1004,1,30000,'94621863498721');
insert into THANH_TOAN(HoaDon,KH_ThanhToan,NV_ThanhToan,LoaiThanhToan,SoTienNhan,SoTaiKhoan)
values(1002,102,1004,0,395000,'12584632954128');
insert into THANH_TOAN(HoaDon,KH_ThanhToan,NV_ThanhToan,LoaiThanhToan,SoTienNhan,SoTaiKhoan)
values(1003,103,1004,0,110000,'62489513649852');

-- DON NHAP HANG --
insert into DON_NHAP_HANG(NgayNhap,TongSLHangNhap,LyDoNhap,TrangThaiDuyet,NguoiQL,NCC) 
values('2020-02-05',200,N'Hết hàng',1,1001,100);
insert into DON_NHAP_HANG(NgayNhap,TongSLHangNhap,LyDoNhap,TrangThaiDuyet,NguoiQL,NCC) 
values('2020-05-15',50,N'Hết hàng',1,1002,102);
insert into DON_NHAP_HANG(NgayNhap,TongSLHangNhap,LyDoNhap,TrangThaiDuyet,NguoiQL,NCC) 
values('2020-06-20',250,N'Hết hàng',1,1001,106);

-- CTĐNH --
insert into CHI_TIET_DON_NHAP_HANG(MaDNH,MaMH_CTDNH,SoLuong) values(1000,100,100);
insert into CHI_TIET_DON_NHAP_HANG(MaDNH,MaMH_CTDNH,SoLuong) values(1000,102,100);
insert into CHI_TIET_DON_NHAP_HANG(MaDNH,MaMH_CTDNH,SoLuong) values(1003,106,50);
insert into CHI_TIET_DON_NHAP_HANG(MaDNH,MaMH_CTDNH,SoLuong) values(1006,115,100);
insert into CHI_TIET_DON_NHAP_HANG(MaDNH,MaMH_CTDNH,SoLuong) values(1006,116,150);

-- DON TRA HANG --

-- CTĐTH --

/*---------------------------------------------- STORED PROCEDURE ------------------------------------------- */
--- Them Mat hang
go
Create proc sp_ThemMatHang
	@TenMH nvarchar(50),
	@LoaiMH nvarchar(50),
	@MaNCC int,
	@SoLuongTon int,
	@SoLuongHangToiThieu int,
	@GiaTien money
as
	insert into MAT_HANG(TenMH,LoaiMH,NCC,SoLuongTon,SoLuongHangToiThieu,GiaTien) 
	values(@TenMH,@LoaiMH,@MaNCC,@SoLuongTon,@SoLuongHangToiThieu,@GiaTien)

exec sp_ThemMatHang 'Kem tuoi',N'Điện tử','100','10','50','50000'

Select MH.MaMH,MH.TenMH,MH.LoaiMH,NCC.TenNCC,MH.SoLuongTon,MH.SoLuongHangToiThieu,MH.GiaTien, NV.TenNV
from MAT_HANG MH, NCC, NHAN_VIEN NV
where MH.NCC=NCC.MaNCC and MH.NVQuanLy=NV.MaNV

Select * from NHAN_VIEN where LoaiNV = 'Bán hàng';

Select * From MAT_HANG 

SELECT DATALENGTH('Đồng hồ thông minh Samsung Galaxy Watch rtyrtyrtyh');

select * from MAT_HANG where TenMH like '%Tai%';