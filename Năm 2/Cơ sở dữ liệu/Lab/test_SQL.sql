create database sql_test
go
use sql_test
go
create table khachhang
(
	makhachhang char(4) primary key,
	tenkhachhang nvarchar(12) not null,
	diachi nvarchar(30) not null
)
go
create table baotapchi
(
	mabaotapchi char(4) primary key,
	ten nvarchar(30) not null,
	dinhky nvarchar(30) not null,
	soluong int not null,
	giaban int not null
)
go
create table Phathanh
(
	mabaotapchi char(4) references baotapchi(mabaotapchi),
	sobaotapchi int not null,
	ngayph datetime not null,
	primary key(mabaotapchi,sobaotapchi)
)
go
create table datbao
(
	makhachhang char(4) references khachhang(makhachhang),
	mabaotapchi char(4) references baotapchi(mabaotapchi),
	solanmua int not null,
	ngaystartdatmua datetime not null,
	primary key(makhachhang,mabaotapchi)
)
go
select *from baotapchi
select *from khachhang
select *from datbao
select *from Phathanh

insert into baotapchi values('TT01',N'Tuổi trẻ',N'Nhật Báo',1000,1500)
insert into baotapchi values('KT01',N'kiến Thức Ngày Nay',N'Bán Nguyệt San',3000,6000)
insert into baotapchi values('TN01',N'Thanh Niên',N'Nhật Báo',1000,2000)
insert into baotapchi values('PN01',N'Phụ Nữ',N'Tuần Báo',2000,4000)
insert into baotapchi values('PN02',N'Phụ Nữ',N'Nhật Báo',1000,2000)

insert into khachhang values('KH01',N'LAN',N'2 NCT')
insert into khachhang values('KH02',N'NAM',N'32 THĐ')
insert into khachhang values('KH03',N'NGỌC',N'16 LHP')

set dateformat dmy
insert into Phathanh values('TT01',123,'15/12/2005')
insert into Phathanh values('KT01',70,'15/12/2005')
insert into Phathanh values('TT01',124,'16/12/2005')
insert into Phathanh values('TN01',256,'17/12/2005')
insert into Phathanh values('PN01',45,'23/12/2005')
insert into Phathanh values('PN02',111,'18/12/2005')
insert into Phathanh values('PN02',112,'19/12/2005')
insert into Phathanh values('TT01',125,'17/12/2005')
insert into Phathanh values('PN01',46,'30/12/2005')

set dateformat dmy

insert into datbao values('KH01','TT01',100,'12/01/2000')
insert into datbao values('KH02','TN01',150,'01/05/2001')
insert into datbao values('KH01','PN01',200,'25/06/2001')
insert into datbao values('KH03','KT01',50,'17/03/2002')
insert into datbao values('KH03','PN02',200,'26/08/2003')
insert into datbao values('KH02','TT01',250,'15/01/2004')
insert into datbao values('KH01','KT01',300,'14/10/2004')

--
select KH.makhachhang, Bao.mabaotapchi, Bao.giaban from baotapchi as Bao, khachhang as KH
where giaban > 2000

--
select * from khachhang

select KH.makhachhang, Bao.mabaotapchi, Bao.dinhky from baotapchi as Bao, khachhang as KH
where dinhky = N'Nhật Báo'