drop database quanlythuvien
create database quanlythuvien
use quanlythuvien
create table TacGia(
		MaTacGia int Identity(1,1) primary key not null,
		TenTacGia nvarchar(100) not null,
		NgaySinh date not null,
		GioiTinh bit not null,
		DiaChi nvarchar(1000) null,
		SoDienThoai varchar(50) null,
		Email varchar(100) null
		)


create table LoaiSach(
		MaLoaiSach int Identity(1,1) primary key not null,
		TenLoaiSach nvarchar(100) not null,
		)


create table Sach(
		MaSach int Identity(1,1) primary key not null,
		MaLoaiSach int references LoaiSach(MaLoaiSach) not null,
		MaTacGia int references TacGia(MaTacGia) not null,
		TenSach nvarchar(1000) not null,
		TrangThai bit not null,
)


create table DocGia(
		MaDocGia int identity(1,1) primary key not null,
		HoTen nvarchar(100) not null,
		NgaySinh date not null,
		GioiTinh bit not null,
		DiaChi nvarchar(100) not null,
		SoDienThoai varchar(50) not null,
		Email varchar(100) null,
)



create table MuonTraSach(
		MaMuonTraSach int identity(1,1) primary key not null,
		MaDocGia int references DocGia(MaDocGia) not null,
		NgayMuon date not null,
		TrangThai bit not null,
		Note nvarchar(1000) 
)


create table MuonTraSachChiTiet(
		MaMuonTraSachChiTiet int identity(1,1) primary key not null,
		MaMuonTraSach int references MuonTraSach(MaMuonTraSach) not null,
		MaSach int references Sach(MaSach) not null,
		NgayHenTra date not null,
		NgayTra date null,		
)

