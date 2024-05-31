
--Drop Database QuanLySinhVien;

CREATE DATABASE QuanLySinhVien;
GO

USE QuanLySinhVien;
GO

CREATE TABLE TaiKhoan
(
	Id int identity(1,1) primary key,
	TenDangNhap varchar(255) unique not null,
	MatKhau varchar(255) not null,
	LoaiTaiKhoan nvarchar(40) default N'Cố vấn học tập',
	TrangThai tinyint default 1
);

CREATE TABLE SinhVien
(
	Id int identity(1,1) primary key,
	MaSinhVien char(9) unique not null,
	HoTenSV nvarchar(40) not null,
	GioiTinh nvarchar(3) not null check (GioiTinh in (N'Nam',N'Nữ')),
	NgaySinh date not null,
	DiaChi nvarchar(200) not null,
	SoDienThoai nvarchar(10) not null check (SoDienThoai like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	NgayNhapHoc Date default GETDATE(),
	MaLop char(10) not null,
	TrangThai tinyint default 1

);

CREATE TABLE Lop
(
	Id int identity(1,1) primary key,
	MaLop char(10) unique not null,
	TenLop char(7) not null,
	SoLuong tinyint default 0,
	MaCVHT char(10),
	MaNganh char(10),
	TrangThai tinyint default 1
);

CREATE TABLE CVHT
(
	Id int identity(1,1) primary key,
	MaCVHT char(10) unique not null,
	TenCVHT nvarchar(40) not null,
	NgaySinh Date default GETDATE(),
	GioiTinh nvarchar(3) not null check (GioiTinh in (N'Nam',N'Nữ')),
	TrangThai tinyint default 1
);

CREATE TABLE Khoa
(
	Id int identity(1,1) primary key,
	MaKhoa varchar(10) unique not null,
	TenKhoa nvarchar(100) not null,
	TrangThai tinyint default 1
);

CREATE TABLE Nganh
(
	Id int identity(1,1) primary key,
	MaNganh char(10) unique not null,
	TenNganh nvarchar(100) not null,
	MaKhoa varchar(10) not null,
	TrangThai tinyint default 1
);

CREATE TABLE MonHoc
(
	Id int identity(1,1) primary key,
	MaMonHoc char(10) unique not null,
	TenMonHoc  nvarchar(255) not null,
	SoTinChi tinyint default 0,
	TietLyThuyet int default 0,
	TietThucHanh int default 0,
	TrangThai tinyint default 1
);

CREATE TABLE Diem
(
	Id int identity(1,1) primary key,
	MaSinhVien char(9) not null,
	MaMonHoc char(10) not null,
	PhanTramTrenLop int default 0,
	PhanTramThi int default 0,
	DiemTrenLop float default 0,
	DiemThi float default 0,
	DiemTB float default 0,
	Loai varchar(3) default 'F'
);

alter table SinhVien add constraint FK_SinhVien_Lop
foreign key (MaLop) references Lop(MaLop)

alter table Lop add constraint FK_Lop_CHVT
foreign key (MaCVHT) references CVHT(MaCVHT)

alter table Lop add constraint FK_Lop_Nganh
foreign key (MaNganh) references Nganh(MaNganh)

alter table Nganh add constraint FK_Nganh_Khoa
foreign key (MaKhoa) references Khoa(MaKhoa)

alter table Diem add constraint FK_Diem_SinhVien
foreign key (MaSinhVien) references SinhVien(MaSinhVien)

alter table Diem add constraint FK_Diem_MonHoc
foreign key (MaMonHoc) references MonHoc(MaMonHoc)

-- Thêm Khoa
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CNTT', N'Công Nghệ Thông Tin');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('KQTKD', N'Kinh Tế - Quản Trị Kinh Doanh');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('SP', N'Sư Phạm');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('LLVHCT', N'Luật Và Khoa Học Chính Trị');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('NN-TNTN', N'Nông Nghiệp - Tài Nguyên Thiên Nhiên');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('KKTCNMT', N'Khoa Kỹ Thuật - Công Nghệ - Môi Trường');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('NN', N'Ngoại Ngữ');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('DLVHNT', N'Du Lịch và Văn Hóa Nghệ Thuật');

-- Thêm ngành của khoa Công Nghệ Thông Tin
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('CNTT-01', N'Công Nghệ Thông Tin', 'CNTT');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('KTPM-01', N'Kỹ Thuật Phần Mềm', 'CNTT');

-- Thêm ngành của khoa Kinh Tế - Quản Trị Kinh Doanh
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('KQTKD-01', N'Kinh Tế', 'KQTKD');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('KQTKD-02', N'Quản Trị Kinh Doanh', 'KQTKD');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('KQTKD-03', N'Marketing', 'KQTKD');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('KQTKD-04', N'Kinh Doanh Quốc Tế', 'KQTKD');

-- Thêm ngành của khoa Sư Phạm
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('SP-01', N'Ngôn Ngữ Anh', 'SP');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('SP-02', N'Sư Phạm Toán', 'SP');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('SP-03', N'Sư Phạm Tiểu Học', 'SP');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('SP-04', N'Sư Phạm Ngữ Văn', 'SP');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('SP-05', N'Sư Phạm Mầm Non', 'SP');

-- Thêm ngành của khoa Luật Và Khoa Học Chính Trị
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('LLVHCT-01', N'Luật Học', 'LLVHCT');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('LLVHCT-02', N'Khoa Học Chính Trị', 'LLVHCT');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('LLVHCT-03', N'Triết Học', 'LLVHCT');

-- Thêm ngành của khoa Nông Nghiệp - Tài Nguyên Thiên Nhiên
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('NN-TNTN-01', N'Nông Học', 'NN-TNTN');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('NN-TNTN-02', N'Tài Nguyên Môi Trường', 'NN-TNTN');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('NN-TNTN-03', N'Nông Lâm Nghiệp', 'NN-TNTN');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('NN-TNTN-04', N'Tiểu Thủy Sinh', 'NN-TNTN');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('NN-TNTN-05', N'Quản Lý Tài Nguyên Nước', 'NN-TNTN');

-- Thêm ngành của khoa Khoa Kỹ Thuật - Công Nghệ - Môi Trường
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('KKTCNMT-01', N'Kỹ Thuật Điện', 'KKTCNMT');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('KKTCNMT-02', N'Kỹ Thuật Môi Trường', 'KKTCNMT');

-- Thêm ngành của khoa Ngoại Ngữ
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('NN-01', N'Ngôn Ngữ Anh', 'NN');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('NN-02', N'Ngôn Ngữ Pháp', 'NN');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('NN-03', N'Ngôn Ngữ Trung Quốc', 'NN');

-- Thêm ngành của khoa Du Lịch và Văn Hóa Nghệ Thuật
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('DLVHNT-01', N'Du Lịch', 'DLVHNT');
INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('DLVHNT-02', N'Văn Hóa Nghệ Thuật', 'DLVHNT');

--Thêm cố vấn học tập
INSERT INTO CVHT (MaCVHT, TenCVHT, NgaySinh, GioiTinh) VALUES ('CVHT-01',N'Nguyễn Văn An','1988-01-15',N'Nam');
INSERT INTO CVHT (MaCVHT, TenCVHT, NgaySinh, GioiTinh) VALUES ('CVHT-02',N'Trần Thị Tuyết Nhung','1990-05-20',N'Nữ');
INSERT INTO CVHT (MaCVHT, TenCVHT, NgaySinh, GioiTinh) VALUES ('CVHT-03',N'Trần Thành Tuấn','1987-10-30',N'Nam');


INSERT INTO Lop (MaLop, TenLop, SoLuong,MaCVHT,MaNganh) VALUES ('DH22TH1', 'DH22TH1', 10,'CVHT-01','CNTT-01');
INSERT INTO Lop (MaLop, TenLop, SoLuong,MaCVHT,MaNganh) VALUES ('DH22TH2', 'DH22TH2', 10,'CVHT-02','CNTT-01');
INSERT INTO Lop (MaLop, TenLop, SoLuong,MaCVHT,MaNganh) VALUES ('DH22PM', 'DH22PM', 10,'CVHT-03','KTPM-01');

--Thêm sinh viên
-- Insert 10 example students with student codes starting with DTH21, belonging to class DH22TH1, with class advisor CVHT-01
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210001', N'Nguyễn Văn A', N'Nam', '2003-01-01', N'An Giang', '0123456781', 'DH22TH1');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210002', N'Nguyễn Thị B', N'Nữ', '2003-02-02', N'An Giang', '0123456782', 'DH22TH1');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210003', N'Trần Văn C', N'Nam', '2003-03-03',N'An Giang', '0123456783', 'DH22TH1');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210004', N'Trần Thị D', N'Nữ', '2003-04-04', N'Đồng Tháp', '0123456784', 'DH22TH1');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210005', N'Lê Văn E', N'Nam', '2003-05-05', N'Kiên Giang', '0123456785', 'DH22TH1');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210006', N'Lê Thị F', N'Nữ', '2003-06-06', N'An Giang', '0123456786', 'DH22TH1');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210007', N'Hoàng Văn G', N'Nam', '2003-07-07', N'An Giang', '0123456787', 'DH22TH1');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210008', N'Hoàng Thị H', N'Nữ', '2003-08-08', N'An Giang', '0123456788', 'DH22TH1');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210009', N'Phạm Văn I', N'Nam', '2003-09-09', N'An Giang', '0123456789', 'DH22TH1');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210010', N'Phạm Thị K', N'Nữ', '2003-10-10', N'An Giang', '0123456790', 'DH22TH1');

INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210011', N'Nguyễn Thị Bình', N'Nữ', '2003-02-15', N'An Giang', '0123456782', 'DH22TH2');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210012', N'Trần Văn Cường', N'Nam', '2003-03-20', N'An Giang', '0123456783', 'DH22TH2');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210013', N'Lê Thị Dung', N'Nữ', '2003-04-25', N'An Giang', '0123456784', 'DH22TH2');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210014', N'Phạm Văn Đức', N'Nam', '2003-05-30', N'An Giang', '0123456785', 'DH22TH2');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210015', N'Huỳnh Thị Hằng', N'Nữ', '2003-06-05', N'An Giang', '0123456786', 'DH22TH2');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210016', N'Nguyễn Văn Hoàng', N'Nam', '2003-07-10', N'An Giang', '0123456787', 'DH22TH2');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210017', N'Lê Thị Kiều', N'Nữ', '2003-08-15', N'Kiên Giang', '0123456788', 'DH22TH2');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210018', N'Trần Văn Lực', N'Nam', '2003-09-20', N'An Giang', '0123456789', 'DH22TH2');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210019', N'Phan Thị Mai', N'Nữ', '2003-10-25', N'An Giang', '0123456790', 'DH22TH2');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DTH210020', N'Đặng Văn Nghĩa', N'Nam', '2003-11-30', N'An Giang', '0123456791', 'DH22TH2');

	-- Insert 10 example students for class DH22PM with addresses in An Giang province
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21004', N'Lê Thị Thanh', N'Nữ', '2003-04-25', N'An Giang', '0123456703', 'DH22PM');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21005', N'Nguyễn Văn Đạt', N'Nam', '2003-05-30', N'An Giang', '0123456704', 'DH22PM');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21006', N'Trần Thị Nga', N'Nữ', '2003-06-05', N'An Giang', '0123456705', 'DH22PM');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21007', N'Huỳnh Văn Hùng', N'Nam', '2003-07-10', N'An Giang', '0123456706', 'DH22PM');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21008', N'Lê Thị Mai', N'Nữ', '2003-08-15', N'An Giang', '0123456707', 'DH22PM');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21009', N'Trần Văn Tài', N'Nam', '2003-09-20', N'An Giang', '0123456708', 'DH22PM');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21010', N'Nguyễn Thị Tú', N'Nữ', '2003-10-25', N'An Giang', '0123456709', 'DH22PM');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21011', N'Phan Văn Thành', N'Nam', '2003-11-30', N'An Giang', '0123456710', 'DH22PM');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21012', N'Đặng Thị Huệ', N'Nữ', '2003-12-05', N'An Giang', '0123456711', 'DH22PM');
INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLop)
VALUES 
    ('DPM21013', N'Lê Văn Lâm', N'Nam', '2003-12-10', N'An Giang', '0123456712', 'DH22PM');


INSERT INTO TaiKhoan (TenDangNhap,MatKhau,LoaiTaiKhoan) VALUES ('quantri','quantri',N'Quản trị')
INSERT INTO TaiKhoan (TenDangNhap,MatKhau,LoaiTaiKhoan) VALUES ('cvht','cvht',N'Cố vấn học tập')


INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-01', N'Lập trình căn bản', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-02', N'Cấu trúc dữ liệu và giải thuật', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-03', N'Cơ sở dữ liệu', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-04', N'Hệ điều hành', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-05', N'Đồ án Công nghệ phần mềm', 6, 90, 60);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-06', N'Mạng máy tính', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-07', N'An toàn và bảo mật thông tin', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-08', N'Tính toán đám mây', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-09', N'Tiếng Anh chuyên ngành CNTT', 3, 45, 0);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('CNTT-10', N'Kỹ năng mềm', 3, 45, 0);

INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('KQTKD-01', N'Nguyên lý kinh tế', 3, 45, 0);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('KQTKD-02', N'Kinh tế học', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('KQTKD-03', N'Quản lý kinh doanh', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('NN-01', N'Khoa học cây trồng', 3, 45, 0);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('NN-02', N'Trồng trọt và chế biến sản phẩm nông nghiệp', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('NN-03', N'Nông nghiệp hiện đại', 4, 60, 30);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('SPToan-01', N'Đại số', 3, 45, 0);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('SPToan-02', N'Hình học', 3, 45, 0);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh)
VALUES ('SPToan-03', N'Lý thuyết số', 4, 60, 30);

INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES ('DTH210001', 'CNTT-01', 40, 60, 7.5, 8, 7.8, 'B+');
INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES('DTH210001', 'CNTT-02', 60, 40, 8, 7.5, 7.8, 'B+');
INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES('DTH210002', 'CNTT-01', 50, 50, 8, 8, 8, 'A');
INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES('DTH210002', 'CNTT-02', 40, 60, 7.5, 8, 7.8, 'B+');
INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES('DTH210003', 'CNTT-01', 60, 40, 9, 9, 9.1, 'A+');
INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES('DTH210003', 'CNTT-02', 50, 50, 8, 8, 8, 'A');
INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES('DTH210004', 'CNTT-01', 40, 60, 7.5, 8, 7.8, 'B');
INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES('DTH210004', 'CNTT-02', 60, 40, 8, 7.5, 7.8, 'B');
INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES('DTH210005', 'CNTT-01', 50, 50, 8, 8, 8, 'A');
INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
VALUES('DTH210005', 'CNTT-02', 40, 60, 7.5, 8, 7.8, 'B');
