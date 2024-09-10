CREATE DATABASE QLBH
GO
USE QLBH
CREATE TABLE KHACHHANG
(
	MaKH nchar (5) constraint PK_makh_kh primary key not null,
	HoTenKH nvarchar (50),
	GioiTinhKH nvarchar(10) check (GioiTinhKH in (N'Nam', N'Nữ')),
	NgaySinhKH date,
	SDTKH nchar (10),
	EmailKH varchar (50)
)
GO
CREATE TABLE BOPHAN
(
	MaBP nchar (5) constraint PK_macv_cv primary key not null,
	TenBP nvarchar (20) UNIQUE
)
GO
CREATE TABLE CUAHANG
(
	MaCH nchar (5) constraint PK_mach_ch primary key not null,
	TenCH nvarchar (50),
	DiaChiCH nvarchar (50),
)
GO
CREATE TABLE NHANVIEN
(
	MaNV nchar (5) constraint PK_manv_nv primary key not null,
	HoTenNV nvarchar (50),
	GioiTinhNV nvarchar(10) check (GioiTinhNV in (N'Nam', N'Nữ')),
	NgaySinhNV date,
	SDTNV nchar (10),
	EmailNV varchar (50),
	MaBP nchar(5) constraint FK_mabophan_nv foreign key references BOPHAN,
	MaCH nchar(5) constraint FK_macuahang_nv foreign key references CUAHANG
)
GO
CREATE TABLE NHACUNGCAP
(
	MaNCC nchar (5) constraint PK_mancc_ncc primary key not null,
	TenNCC nvarchar (50),
	SDTNCC nchar (10),
	EmailNCC varchar (50)
)

GO
CREATE TABLE LOAISANPHAM
(
	MaLoaiSP nchar (5) constraint PK_maloaisp_loaisp primary key not null,
	TenLoaiSP nvarchar (50)
)
GO
CREATE TABLE SANPHAM
(
	MaSP nchar (5) constraint PK_masp_sp primary key not null,
	TenSP nvarchar (50),
	DonViTinh nvarchar(10),
	SLTon int,
	Hinhanh nvarchar (100),
	MaLoaiSP nchar (5) constraint FK_maloaisp_sp foreign key references LOAISANPHAM
)
GO
CREATE TABLE HOADONKH
(
	MaHD nchar (5) constraint PK_mahd_hd primary key not null,
	MaKH nchar (5) constraint FK_mkh_cthd foreign key references KHACHHANG,
	MaNV nchar (5) constraint FK_mnv_cthd foreign key references NHANVIEN,
	NgayIn date,
	PTTT nvarchar (20) check (PTTT in (N'Chuyển khoản', N'Tiền mặt')),
	ApDungKM nvarchar (20) check (ApDungKM in (N'Có', N'Không'))
)
GO
CREATE TABLE CTHOADONKH
(
	MaHD nchar (5) constraint FK_mhd_cthd foreign key references HOADONKH,
	MaSP nchar (5) constraint FK_msp_cthd foreign key references SANPHAM,
	SoLuongMua int,
	DonGiaBan float,
	PRIMARY KEY (MaHD, MaSP)
)
GO
CREATE TABLE DONDATHANGNCC
(
	MaDDH nchar (5) constraint PK_maddh_ddh primary key not null,
	MaCH nchar (5) constraint FK_mch_ddh foreign key references CUAHANG,
	MaNCC nchar (5) constraint FK_mncc_ddh foreign key references NHACUNGCAP,
	NgayDH date,
	NgayDKNH date
)
GO
CREATE TABLE CTDONDATHANGNCC
(
	MaDDH nchar (5) constraint FK_ctddh_ddh foreign key references DONDATHANGNCC,
	MaSP nchar (5) constraint FK_msp_ddh foreign key references SANPHAM,
	SLDat int,
	PRIMARY KEY (MaDDH,MaSP)
)
GO
CREATE TABLE PHIEUNHAP
(
	MaPN nchar (5) constraint PK_mapn_pn primary key not null,
	MaCH nchar (5) constraint FK_mch_pn foreign key references CUAHANG,
	MaNV nchar (5) constraint FK_mnv_pn foreign key references NHANVIEN,
	MaNCC nchar (5) constraint FK_mncc_PN foreign key references NHACUNGCAP,
	NgayNhap date,
)
GO
CREATE TABLE CTPHIEUNHAP
(
	MaPN nchar (5) constraint FK_mpn_ctpn foreign key references PHIEUNHAP,
	MaSP nchar (5) constraint FK_msp_ctpn foreign key references SANPHAM,
	SoLuongNhap int,
	DonGiaNhap float,
	PRIMARY KEY (MaPN, MaSP)
)
GO
CREATE TABLE PHIEUXUAT
(
	MaPX nchar (5) constraint PK_mapx_px primary key not null,
	MaCH nchar (5) constraint FK_mch_px foreign key references CUAHANG,
	MaNV nchar (5) constraint FK_mnv_px foreign key references NHANVIEN,
	NgayXuat date,
)
GO
CREATE TABLE CTPHIEUXUAT
(
	MaPX nchar (5) constraint FK_mpx_ctpx foreign key references PHIEUXUAT,
	MaSP nchar (5) constraint FK_msp_ctpx foreign key references SANPHAM,
	SoLuongXuat int,
	PRIMARY KEY (MaPX, MaSP)
)

-- Dữ liệu mẫu
INSERT INTO KHACHHANG 
VALUES  ('10100',N'Đinh Mạnh Cường',N'Nam','1987-02-16','0215822697','bluan14@gmail.com'),
		('10101',N'Nguyễn Tiến Đạt',N'Nam','2009-04-30','0352124225','ntdattt@gmail.com'),
		('10102',N'Đào Minh Quân',N'Nam','2004-01-01','0214458793','dmq@gmail.com'),
		('10103',N'Nguyễn Thị Yến Nhi',N'Nữ','1999-12-14','0987523115','yennhiii@gmail.com'),
		('10104',N'Nguyễn Thị Minh Ngọc',N'Nữ','2003-12-05','0978546236','minok@gmail.com'),
		('10105',N'Vũ Huy Hoàng',N'Nam','2000-05-06','0215222698','hhoang@gmail.com'),
		('10106',N'Lê Anh Sơn',N'Nam','2001-06-14','0987023056','leason@gmail.com'),
		('10107',N'Đặng Nguyên An',N'Nam','1998-10-10','0972492659','ananan@gmail.com'),
		('10108',N'Nguyễn Lệ Quyên',N'Nữ','1973-02-16','0346521257','nlquyen@gmail.com'),
		('10109',N'Tạ Long Duy',N'Nam','1981-06-17','0356215422','duylong@gmail.com'),
		('10110',N'Mai Nguyễn Nhã Trân',N'Nữ','2003-05-06','0987232003','mnnhatrann@gmail.com'),
		('10111',N'Tống Thị Thu Hoa',N'Nữ','2001-03-15','0975212269','thuhoa2001@gmail.com'),
		('10112',N'Nguyễn Viết Minh',N'Nam','2006-03-14','0321425633','vietminh@gmail.com'),
		('10113',N'Đỗ Thị Phương',N'Nữ','2005-12-08','0325112020','dotphuong@gmail.com'),
		('10114',N'Trần Thị Hải Phương',N'Nữ','2003-09-17','0326262559','haiphuog03@gmail.com'),
		('10115',N'Nguyễn Đức Trí',N'Nam','1996-01-31','0975002156','ducktri@gmail.com'),
		('10116',N'Nguyễn Khánh Đoan',N'Nữ','1999-02-02','0972456889','kdondon@gmail.com'),
		('10117',N'Đoàn Thế Lân',N'Nam','2002-06-17','0325660023','greydlan@gmail.com'),
		('10118',N'Đỗ Vũ Huyền Anh',N'Nữ','1998-09-20','0214445893','huynanh@gmail.com'),
		('10119',N'Đỗ Vinh Quang',N'Nam','1997-07-16','0232522533','vihquang@gmail.com'),
		('10120',N'Hoàng Minh Lê',N'Nam','1995-11-04','0524759993','minhle1995@gmail.com')
GO
INSERT INTO BOPHAN 
VALUES  ('BP001',N'Marketing'),
		('BP002',N'Kho'),
		('BP003',N'Quản lý'),
		('BP004',N'Bán hàng'),
		('BP005',N'Công nghệ thông tin'),
		('BP006',N'Kế toán')
GO

INSERT INTO NHACUNGCAP 
VALUES  ('NCC01',N'Công Ty TNHH Cellulose Acetate 01','0033733954','@gmail.com'),
		('NCC02',N'Công Ty TNHH Cellulose Acetate 02','0202175507','@gmail.com'),
		('NCC03',N'Essilor','0909155366','@gmail.com'),
		('NCC04',N'Chemi','0922424112','@gmail.com'),
		('NCC05',N'Zeiss','0303245779','@gmail.com'),
		('NCC06',N'Visual Tech','0357057073','@gmail.com'),
		('NCC07',N'Công Ty TNHH Mắt Việt','0566059663','@gmail.com')
GO
INSERT INTO CUAHANG 
VALUES  ('CH001',N'Hanoi IRL Flagship Store',N'44 Tôn Đức Thắng, Quận Đống Đa, Hà Nội'),
		('CH002',N'Saigon D3 Store',N'199 Điện Biên Phủ, Phường Võ Thị Sáu, Q3, HCM'),
		('CH003',N'Saigon D2 Store',N'243 Nguyễn Trãi, Phường Nguyễn Cư Trinh, Q1, HCM'),
		('CH004',N'Saigon SS2 Store',N'142 Nguyễn Gia Trí, Phường 25, Bình Thạnh, HCM'),
		('CH005',N'Hanoi SEESON Store',N'144 Cầu Giấy, Quan Hoa, Cầu Giấy, Hà Nội'),
		('CH006',N'DaNang Flagship Store',N'104 Lê Duẩn, Quận Hải Châu, Đà Nẵng'),
		('CH007',N'DaNang Minium Store',N'167 Nguyễn Văn Thoại, Sơn Trà, Đà Nẵng')
GO
INSERT INTO NHANVIEN 
VALUES  ('10100',N'Lê Đức',N'Nam','1987-02-16','0215822697','leduc@gmail.com','BP002','CH001'),
		('10101',N'Lê Thị Ngọc Quý',N'Nữ','2009-04-30','0352124225','ltnqui@gmail.com','BP004','CH001'),
		('20102',N'Nguyễn Minh Hoàng',N'Nam','2004-01-01','0214458793','nguyenhoaq@gmail.com','BP004','CH002'),
		('20103',N'Nguyễn Như Mai',N'Nữ','1999-12-14','0987523115','nnmai@gmail.com','BP002','CH002'),
		('30104',N'Lê Thị Quỳnh Trúc',N'Nữ','2003-12-05','0978546236','qtruc@gmail.com','BP002','CH003'),
		('40105',N'Phan Thị Hương Bình',N'Nữ','2000-05-06','0215222698','pthbig@gmail.com','BP002','CH004'),
		('30106',N'Vũ Đức Minh Nam',N'Nam','2001-06-14','0987023056','minhnamvu@gmail.com','BP004','CH003'),
		('40107',N'Lê Thị Minh Anh',N'Nữ','1998-10-10','0972492659','minhanh123@gmail.com','BP004','CH004'),
		('50108',N'Trần Công Thiện',N'Nam','1973-02-16','0346521257','tranthien@gmail.com','BP002','CH005'),
		('10109',N'Lê Đức Duy',N'Nam','1981-06-17','0356215422','duczuy@gmail.com','BP002','CH001'),
		('50110',N'Hoàng Đình Huy',N'Nam','2003-05-06','0987232003','hdinhhuy2@gmail.com','BP004','CH005'),
		('20111',N'Phạm Hoàng Như',N'Nữ','2001-03-15','0975212269','phnhu@gmail.com','BP003','CH002'),
		('60112',N'Hoàng Như Quỳnh',N'Nữ','2006-03-14','0321425633','mibe325@gmail.com','BP002','CH006'),
		('60113',N'Đỗ Toàn Khang',N'Nam','2005-12-08','0325112020','toankhag@gmail.com','BP003','CH001'),
		('60114',N'Nguyễn Ngọc Thư Trang',N'Nữ','2003-09-17','0326262559','ngoctrang@gmail.com','BP004','CH006'),
		('60115',N'Lê Hồng Thương',N'Nam','1996-01-31','0975002156','lhogthuong@gmail.com','BP003','CH006'),
		('70116',N'Lê Nguyên Hoài',N'Nữ','1999-02-02','0972456889','hoaile@gmail.com','BP002','CH007'),
		('60117',N'Tạ Việt Minh',N'Nam','2002-06-17','0325660023','tvminh@gmail.com','BP002','CH006'),
		('30118',N'Hoàng Nguyễn Anh Duy',N'Nam','1998-09-20','0214445893','adzuy1998@gmail.com','BP003','CH003'),
		('40119',N'Thái Trần Nhật Anh',N'Nữ','1997-07-16','0232522533','nhatanhhh@gmail.com','BP003','CH004'),
		('50120',N'Hoàng Vỹ',N'Nam','1995-11-04','0524759993','hoangvy@gmail.com','BP003','CH005')
GO
INSERT INTO LOAISANPHAM 
VALUES  ('LOAI1',N'Kính mát'),
		('LOAI2',N'Kính cận gọng kim loại'),
		('LOAI3',N'Kính cận Cellulose Acetate'),
		('LOAI4',N'Tròng kính đổi màu'),
		('LOAI5',N'Tròng kính thường'),
		('LOAI6',N'Tròng kính chức năng đặc biệt')
GO
INSERT INTO SANPHAM 
VALUES  ('SP001',N'ANTHONY',N'Chiếc','15','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\athony.jpg','LOAI2'),
		('SP002',N'THE METAL 06',N'Chiếc','27','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\mental6.jpg','LOAI2'),
		('SP003',N'THE METAL 07',N'Chiếc','36','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\mental7.jpg','LOAI2'),
		('SP004',N'THE METAL 08',N'Chiếc','49','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\mental8.jpg','LOAI2'),
		('SP005',N'THE FLOW 01',N'Chiếc','20','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\flow1.jpg','LOAI2'),
		('SP006',N'THE FLOW 02',N'Chiếc','11','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\flow2.jpg','LOAI2'),
		('SP007',N'THE ASSEMBLED 08',N'Chiếc','10','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\assemble.jpg','LOAI3'),
		('SP008',N'THE SOAP 01 A',N'Chiếc','7','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\soap.jpg','LOAI3'),
		('SP009',N'QUENTIN',N'Chiếc','8','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\quentin.jpg','LOAI3'),
		('SP010',N'AUDE',N'Chiếc','35','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\aude.jpg','LOAI3'),
		('SP011',N'NOGUCHI',N'Chiếc','25','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\noguchi.jpg','LOAI3'),
		('SP012',N'PAULINE - 2024 VERSION',N'Chiếc','1','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\pauline.jpg','LOAI3'),
		('SP013',N'CAROL',N'Chiếc','11','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\carol.jpg','LOAI3'),
		('SP014',N'OSCAR',N'Chiếc','13','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\oscar.jpg','LOAI3'),
		('SP015',N'THE OBSIDIAN 01 SUNGLASSES',N'Chiếc','5','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\obsidian.jpg','LOAI1'),
		('SP016',N'THE SNORKEL 03 SUNGLASSES',N'Chiếc','6','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\snokel.jpg','LOAI1'),
		('SP017',N'THE CUT 19 SUNGLASSES',N'Chiếc','5','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\thecut19.jpg','LOAI1'),
		('SP018',N'THE CUT EDGE 01 SUNGLASSES',N'Chiếc','7','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\thecutedge.jpg','LOAI1'),
		('SP019',N'THE FRANCOIS SUNGLASSES',N'Chiếc','4','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\francois.jpg','LOAI1'),
		('SP020',N'THE JIL SUNGLASSES',N'Chiếc','3','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\jil.jpg','LOAI1'),
		('SP021',N'THE MAXENCE SUNGLASSES',N'Chiếc','2','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\maxence.jpg','LOAI1'),
		('SP022',N'CAMILLE','Chiếc','9','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\camile.jpg','LOAI3'),
		('SP023',N'JEAN-FRANCOIS',N'Chiếc','11','C:\Users\Lenovo\source\repos\THNN\THNN\Hinhanh\jeansfrancois.jpg','LOAI3'),
		('SP024',N'Tròng tính năng cơ bản - Chemi',N'Cặp','12','NULL','LOAI4'),
		('SP025',N'Tròng tính năng cơ bản - Zeiss',N'Cặp','30','NULL','LOAI4'),
		('SP026',N'Tròng hạn chế ánh sáng xanh - Chemi',N'Cặp','40','NULL','LOAI4'),
		('SP027',N'Tròng hạn chế ánh sáng xanh - Zeiss',N'Cặp','60','NULL','LOAI4'),
		('SP028',N'Tròng râm cận - Chemi',N'Cặp','20','NULL','LOAI4'),
		('SP029',N'Tròng râm cận - Essilor',N'Cặp','90','NULL','LOAI4'),
		('SP030',N'Tròng đổi màu - Essilor',N'Cặp','110','NULL','LOAI5'),
		('SP031',N'Tròng đổi màu - Zeiss',N'Cặp','22','NULL','LOAI5'),
		('SP032',N'Tròng thư giãn mắt - Essilor',N'Cặp','46','NULL','LOAI6'),
		('SP033',N'Đa tròng - Zeiss',N'Cặp','78','NULL','LOAI6'),
		('SP034',N'Tròng lái xe - Chemi',N'Cặp','36','NULL','LOAI6')
GO
INSERT INTO HOADONKH 
VALUES  ('10001','10100','40107','2024-06-24',N'Chuyển khoản',N'Không'),
		('10002','10107','40107','2024-06-24',N'Chuyển khoản',N'Không'),
		('10003','10112','40107','2024-06-24',N'Chuyển khoản',N'Không'),
		('10004','10110','40107','2024-06-24',N'Tiền mặt',N'Có'),
		('10005','10111','40107','2024-06-24',N'Chuyển khoản',N'Không'),
		('10006','10108','10101','2024-06-24',N'Chuyển khoản',N'Không'),
		('10007','10113','10101','2024-06-24',N'Tiền mặt',N'Không'),
		('10008','10120','10101','2024-06-24',N'Chuyển khoản',N'Không'),
		('10009','10109','10101','2024-06-24',N'Chuyển khoản',N'Không'),
		('10010','10115','10101','2024-06-24',N'Tiền mặt',N'Không'),
		('10011','10106','60114','2024-06-24',N'Chuyển khoản',N'Không'),
		('10012','10116','60114','2024-06-24',N'Chuyển khoản',N'Không'),
		('10013','10118','60114','2024-06-24',N'Chuyển khoản',N'Có'),
		('10014','10102','30106','2024-06-24',N'Tiền mặt',N'Không'),
		('10015','10110','30106','2024-06-24',N'Chuyển khoản',N'Có'),
		('10016','10100','30106','2024-06-24',N'Chuyển khoản',N'Không'),
		('10017','10101','30106','2024-06-24',N'Chuyển khoản',N'Có'),
		('10018','10118','30106','2024-06-24',N'Chuyển khoản',N'Có'),
		('10019','10117','20102','2024-06-24',N'Chuyển khoản',N'Có'),
		('10020','10120','20102','2024-06-24',N'Chuyển khoản',N'Có'),
		('10021','10102','20102','2024-06-24',N'Chuyển khoản',N'Không'),
		('10022','10105','20102','2024-06-24',N'Chuyển khoản',N'Có'),
		('10023','10104','20102','2024-06-24',N'Chuyển khoản',N'Có'),
		('10024','10100','50110','2024-06-24',N'Chuyển khoản',N'Có'),
		('10025','10103','50110','2024-06-24',N'Chuyển khoản',N'Có'),
		('10026','10106','50110','2024-06-24',N'Chuyển khoản',N'Có'),
		('10027','10111','50110','2024-06-24',N'Tiền mặt',N'Không'),
		('10028','10100','50110','2024-06-24',N'Tiền mặt',N'Có'),
		('10029','10108','50110','2024-06-24',N'Tiền mặt',N'Có')
GO
INSERT INTO CTHOADONKH 
VALUES  ('10001','SP004','1','750000'),
		('10002','SP015','1','525000'),
		('10002','SP026','1','410000'),
		('10003','SP005','1','785000'),
		('10004','SP006','1','695000'),
		('10005','SP008','1','725000'),
		('10006','SP021','1','589000'),
		('10007','SP021','1','589000'),
		('10008','SP006','1','695000'),
		('10009','SP001','1','800000'),
		('10010','SP023','1','250000'),
		('10011','SP024','1','275000'),
		('10012','SP007','2','737000'),
		('10013','SP006','1','695000'),
		('10014','SP006','1','695000'),
		('10015','SP014','1','450000'),
		('10016','SP016','1','637000'),
		('10017','SP021','1','589000'),
		('10018','SP015','2','660000'),
		('10019','SP022','1','593000'),
		('10020','SP006','1','695000'),
		('10021','SP009','1','725000'),
		('10022','SP009','1','725000'),
		('10025','SP021','1','589000'),
		('10026','SP006','1','695000'),
		('10027','SP022','1','593000'),
		('10028','SP014','1','450000'),
		('10029','SP006','1','695000'),
		('10024','SP002','1','670000')
GO
INSERT INTO DONDATHANGNCC
VALUES  ('DH101','CH001','NCC01','2024-06-01','2024-06-26'),
		('DH102','CH001','NCC02','2024-05-18','2024-06-18'),
		('DH103','CH001','NCC03','2024-05-17','2024-06-01'),
		('DH104','CH001','NCC04','2024-05-25','2024-06-26'),
		('DH201','CH002','NCC01','2024-05-30','2024-06-18'),
		('DH202','CH002','NCC02','2024-04-19','2024-05-01'),
		('DH203','CH002','NCC02','2024-05-11','2024-05-20'),
		('DH204','CH002','NCC03','2024-05-17','2024-06-01'),
		('DH302','CH003','NCC03','2024-06-15','2024-06-30'),
		('DH303','CH003','NCC04','2024-03-24','2024-04-02'),
		('DH304','CH003','NCC06','2024-04-15','2024-05-01'),
		('DH305','CH003','NCC01','2024-05-05','2024-05-25'),
		('DH306','CH003','NCC05','2024-06-17','2024-06-25')
GO
INSERT INTO CTDONDATHANGNCC
VALUES  ('DH101','SP007','20'),
		('DH104','SP024','40'),
		('DH201','SP010','10'),
		('DH202','SP012','15'),
		('DH204','SP032','20'),
		('DH302','SP028','80'),
		('DH303','SP021','30'),
		('DH304','SP007','35'),
		('DH305','SP013','40'),
		('DH306','SP003','20'),
		('DH102','SP008','20'),
		('DH103','SP032','15')
GO
INSERT INTO PHIEUNHAP
VALUES  ('10001','CH001','20102','NCC01','2024-06-26'),
		('10002','CH001','20102','NCC02','2024-06-18'),
		('10003','CH001','20102','NCC03','2024-06-10'),
		('10004','CH001','20102','NCC04','2024-06-30'),
		('10005','CH001','20102','NCC05','2024-06-25'),
		('20001','CH002','20103','NCC01','2024-06-26'),
		('20002','CH002','20103','NCC02','2024-05-11'),
		('20003','CH002','20103','NCC02','2024-05-26'),
		('20004','CH002','20103','NCC03','2024-06-05'),
		('30001','CH003','30104','NCC03','2024-06-30'),
		('30002','CH003','30104','NCC04','2024-04-02'),
		('30003','CH003','30104','NCC06','2024-05-01'),
		('30004','CH003','30104','NCC01','2024-05-25'),
		('30005','CH003','30104','NCC02','2024-06-25'),
		('30006','CH003','30104','NCC05','2024-06-25'),
		('40001','CH004','40105','NCC02','2024-06-26'),
		('40002','CH004','40105','NCC01','2024-06-26'),		
		('50014','CH005','50108','NCC01','2024-06-26'),
		('50015','CH005','50108','NCC03','2024-06-26'),
		('60020','CH006','60117','NCC02','2024-06-26'),
		('60048','CH006','60117','NCC02','2024-06-26'),
		('60003','CH006','60112','NCC04','2024-06-26'),
		('60004','CH006','60112','NCC01','2024-06-26'),
		('70020','CH007','70116','NCC01','2024-06-26'),
		('70077','CH007','70116','NCC02','2024-06-26'),
		('70021','CH007','70116','NCC03','2024-06-26'),
		('70048','CH007','70116','NCC04','2024-06-26')
GO
INSERT INTO CTPHIEUNHAP
VALUES  ('10001','SP007','20','600000'),
		('10002','SP008','15','525000'),
		('10003','SP032','15','250000'),
		('10004','SP024','40','210000'),
		('10005','SP031','30','240000'),
		('20001','SP010','10','500000'),
		('20002','SP012','15','420000'),
		('20003','SP008','20','525000'),
		('20004','SP032','60','250000'),
		('30001','SP032','80','250000'),
		('30002','SP028','30','175000'),
		('30003','SP021','35','350000'),
		('30004','SP007','40','600000'),
		('30005','SP013','20','360000'),
		('30006','SP031','100','240000'),
		('40001','SP007','30','600000'),
		('40002','SP010','20','500000'),
		('50014','SP009','40','650000'),
		('50015','SP032','70','250000'),
		('60020','SP014','15','450000'),
		('60048','SP008','20','360000'),
		('60003','SP034','150','210000'),
		('60004','SP011','50','390000'),
		('70020','SP007','30','480000'),
		('70077','SP014','10','275000'),
		('70021','SP032','80','240000'),
		('70048','SP024','30','210000')
GO
INSERT INTO PHIEUXUAT
VALUES  ('41111','CH004','40105','2024-06-24'),
		('41112','CH004','40105','2024-06-24'),
		('41125','CH004','40105','2024-06-24'),
		('41197','CH004','40105','2024-06-24'),
		('41135','CH004','40105','2024-06-24'),
		('42422','CH001','10100','2024-06-24'),
		('11111','CH001','10109','2024-06-24'),
		('15236','CH001','10100','2024-06-24'),
		('15500','CH001','10109','2024-06-24'),
		('60215','CH006','60112','2024-06-24'),
		('60003','CH006','60117','2024-06-24'),
		('30005','CH003','30104','2024-06-24'),
		('31212','CH003','30104','2024-06-24'),
		('37589','CH003','30104','2024-06-24'),
		('32303','CH003','30104','2024-06-24')
GO
INSERT INTO CTPHIEUXUAT
VALUES  ('41111','SP004','1'),
		('41125','SP015','1'),
		('41112','SP026','1'),
		('41135','SP005','1'),
		('42422','SP006','1'),
		('11111','SP021','1'),
		('15236','SP006','1'),
		('15500','SP001','1'),
		('60215','SP007','1'),
		('60003','SP006','1'),
		('30005','SP014','1'),
		('31212','SP016','1'),
		('37589','SP021','1'),
		('32303','SP015','1')
				
-- Ràng buộc toàn vẹn
CREATE TRIGGER NGAY_DDH
ON DONDATHANGNCC
FOR INSERT, UPDATE
AS
IF EXISTS (SELECT * FROM inserted INNER JOIN DONDATHANGNCC
					ON DONDATHANGNCC.MaDDH=inserted.MaDDH
					WHERE inserted.NgayDH > DONDATHANGNCC.NgayDKNH)
	BEGIN 
	PRINT (N'Ngày đặt hàng phải bé hơn ngày đăng ký nhận hàng')
	ROLLBACK TRAN
	END

SELECT b.MaHD, b.MaKH, b.MaNV, b.NgayIn, b.PTTT, b.ApDungKM, a.MaSP, a.SoLuongMua, a.DonGiaBan 
FROM CTHOADONKH AS a, HOADONKH AS b 
WHERE b.MaHD=a.MaHD