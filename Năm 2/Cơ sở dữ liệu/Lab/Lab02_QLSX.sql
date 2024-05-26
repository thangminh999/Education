create database Lab02_QLSX

go
use Lab02_QLSX
go

create table ToSanXuat
(
MaTSX char(4) primary key,
TenTSX nvarchar(10) not null
)
go

create table CongNhan
(
MaCN char(5) primary key,
Ho nvarchar(20) not null,
Ten nvarchar(10) not null,
Phai nvarchar(5) not null,
Ngaysinh datetime,
MaTSX char(4) references ToSanXuat(MaTSX)
)
go

create table SanPham
(
MaSP char(5) primary key,
TenSP nvarchar(20) not null,
DVT nvarchar(10) not null,
TienCong int
)
go

create table ThanhPham
(
MaCN char(5) references CongNhan(MaCN),
MaSP char(5) references SanPham(MaSP),
Ngay datetime,
SoLuong int 
)
go

DROP TABLE ThanhPham
DROP TABLE CongNhan
DROP TABLE ToSanXuat
DROP TABLE SanPham


insert into ToSanXuat values ('TS01',N'Tổ 1')
insert into ToSanXuat values ('TS02',N'Tổ 2')
select * from ToSanXuat

set dateformat dmy
insert into CongNhan values ('CN001',N'Nguyễn Trường',N'An',N'Nam','12/05/1981','TS01')
insert into CongNhan values ('CN002',N'Lê Thị Hồng',N'Gấm',N'Nữ','04/06/1980','TS01')
insert into CongNhan values	('CN003',N'Nguyễn Công',N'Thành',N'Nam','04/05/1981','TS02')
insert into CongNhan values	('CN004',N'Võ Hữu',N'Hạnh',N'Nam','15/02/1980','TS02')
insert into CongNhan values	('CN005',N'Lý Thanh',N'Hân',N'Nữ','03/12/1981','TS01')
select * from CongNhan



insert into SanPham values ('SP001',N'Nồi đất',N'cái','10000')
insert into SanPham values ('SP002',N'Chén',N'cái','2000')
insert into SanPham values ('SP003',N'Bình gốm nhỏ',N'cái','20000')
insert into SanPham values ('SP004',N'Bình gốm lớn',N'cái','25000')
select * from SanPham

insert into ThanhPham values ('CN001','SP001','01/02/2007','10')
insert into ThanhPham values ('CN002','SP001','01/02/2007','5')
insert into ThanhPham values ('CN003','SP002','10/01/2007','50')
insert into ThanhPham values ('CN004','SP003','12/01/2007','10')
insert into ThanhPham values ('CN005','SP002','12/01/2007','100')
insert into ThanhPham values ('CN002','SP004','13/02/2007','10')
insert into ThanhPham values ('CN001','SP003','14/02/2007','15')
insert into ThanhPham values ('CN003','SP001','15/01/2007','20')
insert into ThanhPham values ('CN003','SP004','14/02/2007','15')
insert into ThanhPham values ('CN004','SP002','30/01/2007','100')
insert into ThanhPham values ('CN005','SP003','01/02/2007','50')
insert into ThanhPham values ('CN001','SP001','20/02/2007','30')
select * from ThanhPham


--1)
select TenTSX,Ho+' '+Ten as HoTen, NgaySinh, Phai
from ToSanXuat A, CongNhan B
where A.MaTSX = B.MaTSX
order by TenTSX, HoTen

--2)
select Ho +' '+Ten as HoTen, TenSP, Ngay, SoLuong, TienCong * SoLuong as ThanhTien
from SanPham A, ThanhPham B, CongNhan C
where  A.MaSP = B.MaSP and B.MaCN = C.MaCN and Ho = N'Nguyễn Trường' and Ten = N'An'
order by Ngay

--3)
/*
select MaCN, TenSP, MaSP
from  CongNhan A, ThanhPham B, SanPham C
where A.MaCN and B.MaCN and B.MaSP = C.MaSP not like'Bình gốm lớn'
order by MaCN 
*/

--5)
select TenTSX, 'Tổng Số CN' = count(MaCN)
from ToSanXuat A, CongNhan B
where A.MaTSX = B.MaTSX
group by TenTSX

--6)
select Ho, Ten, TenSp, 'Tổng SL Thành Phẩm' = count(SoLuong)
from CongNhan A, ThanhPham B, ThanhPham C
where A.