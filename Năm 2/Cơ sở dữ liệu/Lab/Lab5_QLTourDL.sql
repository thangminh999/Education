create database Lab05_test
go
use Lab05_test
go



create table ThanhPho
(
MaTP char(2) primary key,
TenTP nvarchar(10) not null
)
create table Tour
(
MaTour char(4) primary key not null,
TongSoNgay int not null
)
go
create table Tour_TP
(
MaTour char(4) references Tour(MaTour),
MaTP char(2) references ThanhPho(MaTP),
SoNgay int not null,
primary key(MaTour,MaTP) 
)

go
create table Lich_TourDL
(
MaTour char(4) references Tour(MaTour),
NgayKH DateTime,
TenHDV nvarchar(10),
SoNguoi int,
TenKH nvarchar(20),
primary key(MaTour, NgayKH)
)

DROP TABLE TOUR_TP
DROP TABLE THANHPHO
DROP TABLE LICH_TOURDL
DROP TABLE TOUR



insert into ThanhPho values('01',N'?à L?t')
insert into ThanhPho values('02',N'Nha Trang')
insert into ThanhPho values('03',N'Phan Thi?t')
insert into ThanhPho values('04',N'Hu?')
insert into ThanhPho values('05',N'?à N?ng')

insert into Tour values ('T001',3)
insert into Tour values ('T002',4)
insert into Tour values ('T003',5)
insert into Tour values ('T004',7)

insert into Tour_TP values ('T001','01',2)
insert into Tour_TP values ('T001','03',1)
insert into Tour_TP values ('T002','01',2)
insert into Tour_TP values ('T002','02',2)
insert into Tour_TP values ('T003','02',2)
insert into Tour_TP values ('T003','01',1)
insert into Tour_TP values ('T003','04',2)
insert into Tour_TP values ('T004','02',2)
insert into Tour_TP values ('T004','05',2)
insert into Tour_TP values ('T004','04',3)

set dateformat dmy
insert into Lich_TourDL values ('T001','14/02/2017',N'Vân',20,N'Nguy?n Hoàng')
insert into Lich_TourDL values ('T002','14/02/2017',N'Nam',30,N'Lê Ng?c')
insert into Lich_TourDL values ('T002','06/03/2017',N'Hùng',20,N'Lý D?ng')
insert into Lich_TourDL values ('T003','18/02/2017',N'D?ng',20,N'Lý D?ng')
insert into Lich_TourDL values ('T004','18/02/2017',N'Hùng',30,N'D?ng Nam')
insert into Lich_TourDL values ('T003','10/03/2017',N'Nam',45,N'Nguy?n An')
insert into Lich_TourDL values ('T002','28/04/2017',N'Vân',25,N'Ng?c Dung')
insert into Lich_TourDL values ('T004','29/04/2017',N'D?ng',35,N'Lê Ng?c')
insert into Lich_TourDL values ('T001','30/04/2017',N'Nam',25,N'Tr?n Nam')
insert into Lich_TourDL values ('T003','15/06/2017',N'Vân',20,N'Tr?nh Bá')

delete from Lich_TourDL

select *from Tour
select *from ThanhPho
select *from Tour_TP
select *from Lich_TourDL

--1
select MaTour, TongSoNgay from dbo.Tour
where TongSoNgay Between 3 and 5

--2 Các tour du lich to chuc trong thang 2/2017
select MaTour, NgayKH
from Tour A, Lich_TourDL B
where A.MaTour = B.MaTour and NgayKhoiHanh = 

