create database lab4QuanLyDatBao
go
use lab4QuanLyDatBao
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


/*query*/
/*1*/
select  mabaotapchi,ten,giaban
from baotapchi
where dinhky=N'Tuần Báo'
/*2*/
select *
from baotapchi
where mabaotapchi like 'PN%'
/*3*/
select  distinct b.tenkhachhang
from baotapchi A,khachhang B,datbao C
where a.mabaotapchi=c.mabaotapchi and b.makhachhang=c.makhachhang and c.mabaotapchi like 'PN%'
/*4*/
select A.tenkhachhang
from  khachhang A
where a.makhachhang =all(select c.makhachhang from khachhang B,datbao C where b.makhachhang=c.makhachhang and c.mabaotapchi like 'PN%')
/*5*/
select a.tenkhachhang
from khachhang A
where a.makhachhang not in(select b.makhachhang from datbao B where b.mabaotapchi like 'TN%')
/*6*/
select a.makhachhang,a.tenkhachhang,SUM(solanmua) as sotobao
from khachhang a,datbao b
where a.makhachhang=b.makhachhang
group by a.makhachhang,a.tenkhachhang
/*7*/
select a.makhachhang,a.tenkhachhang
from  khachhang A,datbao b
where a.makhachhang=b.makhachhang and YEAR(b.ngaystartdatmua)=2004 
/*8*/
select tenkhachhang,ten,dinhky,sum(solanmua) as soluongmua ,SUM(solanmua)*giaban as sotien
from khachhang A,datbao B,baotapchi C
where a.makhachhang=b.makhachhang and c.mabaotapchi=b.mabaotapchi
group by tenkhachhang,ten,dinhky,giaban
/*9*/
select ten,dinhky,SUM(solanmua) as soluongdatmua
from baotapchi A,datbao B 
where a.mabaotapchi=b.mabaotapchi
group by ten,dinhky
/*10*/
select *
from baotapchi
where mabaotapchi like 'HS%'

/*11*/
select *
from baotapchi A
where a.mabaotapchi not in(select b.mabaotapchi from datbao B )
/*12*/
select  ten,dinhky
from  baotapchi A,datbao b
where a.mabaotapchi=b.mabaotapchi 
group by a.ten,dinhky
having sum(solanmua)>=all(select SUM(c.solanmua) from datbao C,baotapchi D  where c.mabaotapchi=d.mabaotapchi group by c.mabaotapchi ,d.dinhky  )
/*13*/
select  tenkhachhang
from khachhang A,datbao B
where a.makhachhang=b.makhachhang 
group by tenkhachhang
having sum(solanmua)>=all(select SUM(c.solanmua) from datbao C group by c.makhachhang)
/*14*/
select ten
from baotapchi A,Phathanh b
where a.mabaotapchi=b.mabaotapchi
group by  ten
having  count(a.mabaotapchi)>=2
/*15*/
select ten
from datbao A,baotapchi b
where a.mabaotapchi=b.mabaotapchi
group by b.mabaotapchi,ten
having count(a.makhachhang)>=3



















