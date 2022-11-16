insert into TacGia values ('Do Thanh Son','2001-09-20',1,'Son La','0344025802', null)
insert into TacGia values ('Le Thien Duc','2001-01-20',1,'Thanh Hoa','0123456789', null)
insert into TacGia values ('Hoang Danh Tuan','2001-02-20',1,'Bac Giang','0123456788', null)
insert into TacGia values ('Dang Quoc Tan','2001-03-20',1,'Ha Noi','0123456787', null)

insert into LoaiSach values(N'Sách Ngôn Tình')
insert into LoaiSach values(N'Sách Thiếu Nhi')
insert into LoaiSach values(N'Sách Giáo Trình')
insert into LoaiSach values(N'Sách Phật')
insert into LoaiSach values(N'Sách Truyện')
insert into LoaiSach values(N'Sách Tâm Lý')
insert into LoaiSach values(N'Sách Lịch Sử')
insert into LoaiSach values(N'Sách Văn Học')
insert into LoaiSach values(N'Sách Giáo Khoa')
insert into LoaiSach values(N'Sách Đời Sống')


insert into Sach values (1,1,N'Yêu',0);
insert into Sach values (2,2,N'Conan',0);
insert into Sach values (3,3,N'Dậy học lập trình Java',0);
insert into Sach values (4,4,N'Nam mô A di đà phật',0);
insert into Sach values (5,1,N'Dế mèn phiêu lưu ký',0);
insert into Sach values (6,2,N'Tâm lý tuổi 18',0);
insert into Sach values (7,3,N'Lịch sử Việt Nam',0);
insert into Sach values (8,4,N'Chiếc thuyền ngoài xa',0);
insert into Sach values (9,1,N'Vật Lý',0);
insert into Sach values (10,2,N'Đời sống hàng ngày',0);
insert into Sach values (1,3,N'Tình yêu tuổi 18',0);
insert into Sach values (2,4,N'Doremon',0);
insert into Sach values (3,1,N'C++',0);
insert into Sach values (4,2,N'Phật giáo',0);
insert into Sach values (5,3,N'Rùa và Thỏ',0);
insert into Sach values (6,4,N'Tâm lý tình cảm',0);
insert into Sach values (7,1,N'Lịch sử nước ngoài',0);
insert into Sach values (8,2,N'Tây Tiến',0);

insert into DocGia values (N'A','2001-10-20',1,'Ha Noi','0123456786',null)
insert into DocGia values (N'B','2001-10-19',1,'Ha Noi','0123456785',null)
insert into DocGia values (N'C','2001-10-18',0,'Ha Noi','0123456784',null)
insert into DocGia values (N'D','2001-10-17',1,'Ha Noi','0123456783',null)
insert into DocGia values (N'E','2001-10-16',0,'Ha Noi','0123456782',null)
insert into DocGia values (N'F','2001-10-15',1,'Ha Noi','0123456781',null)
insert into DocGia values (N'G','2001-10-14',1,'Ha Noi','0123456780',null)
insert into DocGia values (N'H','2001-10-13',0,'Ha Noi','0123456799',null)
insert into DocGia values (N'E','2001-10-12',1,'Ha Noi','0123456701',null)
insert into DocGia values (N'K','2001-10-11',0,'Ha Noi','0123456711',null)
insert into DocGia values (N'L','2001-10-10',1,'Ha Noi','0123456722',null)

insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai) values (1, getDate(),0)
insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai)  values (2, getDate(),0)
insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai)  values (3, getDate(),0)
insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai)  values (4, getDate(),0)
insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai)  values (4, getDate(),0)
insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai)  values (3, getDate(),0)
insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai)  values (2, getDate(),0)
insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai)  values (1, getDate(),0)
insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai)  values (1, getDate(),0)
insert into MuonTraSach(MaDocGia, NgayMuon, TrangThai)  values (2, getDate(),0)

insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra) values (1,1,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (2,2,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (3,3,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (4,4,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (5,5,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (6,6,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (7,7,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (8,8,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (9,9,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (10,10,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (1,11,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (2,12,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (3,13,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (4,14,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (5,15,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (6,16,getDate()+30,null)
insert into MuonTraSachChiTiet(MaMuonTraSach, MaSach, NgayHenTra, NgayTra)  values (7,17,getDate()+30,null)
