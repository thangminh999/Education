CREATE DATABASE Lab03_QuanLyNhapXuatHangHoa
go
use Lab03_QuanLyNhapXuatHangHoa
create table HANGHOA
(MAHH char(5) primary key,
TENHH nvarchar(30) not null,
DVT nvarchar(4),
SOLUONGTON int
)
go
create table DOITAC
(MADT char(5) primary key,
TENDT nvarchar(30) not null,
DIACHI nvarchar(30),
DIENTHOAI char(12)
)
go
create table KHANANGCC
(MADT char(5) references DOITAC(MADT),
MAHH char(5) references HANGHOA(MAHH)
)
go
create table HOADON
(SOHD char(5) primary key,
NGAYLAPHD datetime,
MADT char(5) references DOITAC(MADT),
TONGTG int
)
go
create table CT_HOADON
(SOHD char(5) references HOADON(SOHD),
MAHH char(5) references HANGHOA(MAHH),
DONGIA int,
SOLUONG int,
primary key(SOHD, MAHH)
)
select * from HANGHOA
select * from DOITAC
select * from KHANANGCC
select * from HOADON
select * from CT_HOADON

insert into HANGHOA values('CPU01',N'CPU INTEL,CELERON 600 BOX',N'CÁI',5)
insert into HANGHOA values('CPU02',N'CPU INTEL,PII 700',N'CÁI',10)
insert into HANGHOA values('CPU03',N'CPU AMD K7 ATHL,ON 600',N'CÁI',8)
insert into HANGHOA values('HDD01',N'HDD 10.2 GB QUANTUM',N'CÁI',10)
insert into HANGHOA values('HDD02',N'HDD 13.6 GB SEAGATE',N'CÁI',15)
insert into HANGHOA values('HDD03',N'HDD 20 GB QUANTUM',N'CÁI',6)
insert into HANGHOA values('KB01',N'KB GENIUS',N'CÁI',12)
insert into HANGHOA values('KB02',N'KB MITSUMIMI',N'CÁI',5)
insert into HANGHOA values('MB01',N'GIGABYTE CHIPSET INTEL',N'CÁI',10)
insert into HANGHOA values('MB02',N'ACOPR BX CHIPSET VIA',N'CÁI',10)
insert into HANGHOA values('MB03',N'INTEL PHI CHIPSET INTEL',N'CÁI',10)
insert into HANGHOA values('MB04',N'ECS CHIPSET SIS',N'CÁI',10)
insert into HANGHOA values('MB05',N'ECS CHIPSET VIA',N'CÁI',10)
insert into HANGHOA values('MNT01',N'SAMSUNG 14" SYNCMASTER',N'CÁI',5)
insert into HANGHOA values('MNT02',N'LG 14"',N'CÁI',5)
insert into HANGHOA values('MNT03',N'ACER 14"',N'CÁI',8)
insert into HANGHOA values('MNT04',N'PHILIPS 14"',N'CÁI',6)
insert into HANGHOA values('MNT05',N'VIEWSONIC 14"',N'CÁI',7)

select * from HANGHOA

insert into DOITAC values('CC001',N'Cty TNC',N'176 BTX Q1 - TP.HCM','08.8250259')
insert into DOITAC values('CC002',N'Cty Hoàng Long',N'15A TTT Q1 - TP.HCM','08.8250898')
insert into DOITAC values('CC003',N'Cty Hợp Nhất',N'152 BTX Q1 - TP.HCM','08.8252376')
insert into DOITAC values('K0001',N'Nguyễn Minh Hải',N'91 Nguyễn Văn Trỗi Tp.Đà Lạt','063.831129')
insert into DOITAC values('K0002',N'Như Quỳnh',N'21 Điện Biên Phủ.N.Trang','058590270')
insert into DOITAC values('K0003',N'Trần Nhật Duật',N'Lê Lợi TP.Huế','054.848376')
insert into DOITAC values('K0004',N'Phan Nguyễn Hùng Anh',N'11 Nam Kỳ Khởi Nghĩa-TP.Đà Lạt','063.823409')

select * from DOITAC

set dateformat dmy
go
insert into HOADON values('N0001','25/01/2006',N'CC001',' ')
insert into HOADON values('N0002','01/05/2006',N'CC002',' ')
insert into HOADON values('X0001','12/05/2006',N'K0001',' ')
insert into HOADON values('X0002','16/06/2006',N'K0002',' ')
insert into HOADON values('X0003','20/04/2006',N'K0001',' ')

select * from HOADON

insert into KHANANGCC values('CC001',N'CPU01')
insert into KHANANGCC values('CC001','HDD03')
insert into KHANANGCC values('CC001','KB01')
insert into KHANANGCC values('CC001','MB02')
insert into KHANANGCC values('CC001','MB04')
insert into KHANANGCC values('CC001','MNT01')
insert into KHANANGCC values('CC002','CPU01')
insert into KHANANGCC values('CC002','CPU02')
insert into KHANANGCC values('CC002','CPU03')
insert into KHANANGCC values('CC002','KB02')
insert into KHANANGCC values('CC002','MB01')
insert into KHANANGCC values('CC002','MB05')
insert into KHANANGCC values('CC002','MNT03')
insert into KHANANGCC values('CC003','HDD01')
insert into KHANANGCC values('CC003','HDD02')
insert into KHANANGCC values('CC003','HDD03')
insert into KHANANGCC values('CC003','MB03')

select * from KHANANGCC

insert into CT_HOADON values('N0001',N'CPU01','63','10')
insert into CT_HOADON values('N0001',N'HDD03','97','7')
insert into CT_HOADON values('N0001',N'KB01','3','5')
insert into CT_HOADON values('N0001',N'MB02','57','5')
insert into CT_HOADON values('N0001',N'MNT01','112','3')
insert into CT_HOADON values('N0002',N'CPU02','115','3')
insert into CT_HOADON values('N0002',N'KB02','5','7')
insert into CT_HOADON values('N0002',N'MNT03','111','5')
insert into CT_HOADON values('X0001',N'CPU01','67','2')
insert into CT_HOADON values('X0001',N'HDD03','100','2')
insert into CT_HOADON values('X0001',N'KB01','5','2')
insert into CT_HOADON values('X0001',N'MB02','62','1')
insert into CT_HOADON values('X0002',N'CPU01','67','1')
insert into CT_HOADON values('X0002',N'KB02','7','3')
insert into CT_HOADON values('X0002',N'MNT01','115','2')
insert into CT_HOADON values('X0003',N'CPU01','67','1')
insert into CT_HOADON values('X0003',N'MNT03','115','2')

select * from  CT_HOADON
--1
select MAHH, TENHH
from HANGHOA
where MAHH like 'HDD%'
--2
select MAHH, TENHH, SOLUONGTON
from HANGHOA
where SOLUONGTON > 10
--3
select * 
from DOITAC
where DIACHI like '%TP.HCM'
--4
select A.SOHD, NGAYLAPHD, TENDT, DIACHI, DIENTHOAI, SOLUONG
from HOADON A, DOITAC B, CT_HOADON C
where A.MADT = B.MADT and A.SOHD = C.SOHD and MONTH(NGAYLAPHD) = 5 and YEAR(NGAYLAPHD) = 2006
--5
select TENDT, TENHH
from DOITAC A, HANGHOA B, KHANANGCC C
where A.MADT = C.MADT AND C.MAHH = B.MAHH AND B.TENHH LIKE 'HDD%'
--6
select TENDT, count(distinct C.MAHH)
from DOITAC A, HANGHOA B, KHANANGCC C
where A.MADT = C.MADT AND C.MAHH = B.MAHH AND B.TENHH LIKE 'HDD%'
Group by TENDT
Having count(distinct C.MAHH)=3
--7
select MADT, TENDT
from DOITAC
where MADT like 'CC%' and MADT NOT IN (select MADT
       from KHANANGCC
       where MAHH LIKE 'HDD%')
--8                      
select MAHH, TENHH, DVT, SOLUONGTON
from HANGHOA A
where NOT EXISTS(select MAHH from CT_HOADON B
                  where A.MAHH = B.MAHH)
--9
select A.MAHH, TENHH, SUM(SOLUONG) AS TONGSL
from HANGHOA A, CT_HOADON B
where A.MAHH = B.MAHH
group by A.MAHH, TENHH
having SUM(SOLUONG) >= ALL (select SUM(C.SOLUONG)
                            from CT_HOADON C
							group by C.MAHH)
--10
select A.MAHH, TENHH, SUM(SOLUONG) AS TONGSL
from HANGHOA A, CT_HOADON B
where A.MAHH = B.MAHH
group by A.MAHH, TENHH
having SUM(SOLUONG) <= ALL (select SUM(C.SOLUONG)
                            from CT_HOADON C
							group by C.MAHH)
--11
select A.SOHD, A.NGAYLAPHD, COUNT(B.SOHD) AS SOMATHANGNHAP
from HOADON A, CT_HOADON B
where A.SOHD = B.SOHD
group by A.SOHD, A.NGAYLAPHD
having COUNT(B.SOHD) >= ALL (select COUNT(C.SOHD)
							from CT_HOADON C
							group by C.SOHD)
--12
SELECT MAHH, TENHH
FROM HANGHOA
WHERE MAHH NOT IN(SELECT B.MAHH
				FROM HOADON A, CT_HOADON B
				WHERE B.SOHD = A.SOHD AND MONTH(A.NGAYLAPHD) = 1 AND YEAR(A.NGAYLAPHD) = 2006)
--13
SELECT MAHH, TENHH
FROM HANGHOA
WHERE MAHH NOT IN (SELECT B.MAHH
					FROM HOADON A, CT_HOADON B
					WHERE B.SOHD = A.SOHD AND MONTH(A.NGAYLAPHD) = 6 AND YEAR(A.NGAYLAPHD) = 2006)
--14
SELECT COUNT(DISTINCT MAHH) AS SoMatHang
FROM CT_HOADON
--15
SELECT A.MADT, A.TENDT, COUNT(DISTINCT MAHH) AS SoMatHang
FROM DOITAC A, KHANANGCC B
WHERE A.MADT = B.MADT
GROUP BY A.MADT, A.TENDT
--16
SELECT A.MADT, A.TENDT, A.DIACHI, A.DIENTHOAI, COUNT(B.MADT) AS SoLuongGiaoDich
FROM DOITAC A, HOADON B
WHERE A.MADT = B.MADT
GROUP BY A.MADT, A.TENDT, A.DIACHI, A.DIENTHOAI
HAVING COUNT(B.MADT) >= ALL (SELECT COUNT(MADT)
							FROM HOADON
							GROUP BY MADT)
--17
SELECT SUM(B.DONGIA * B.SOLUONG) AS TongDoanhThu_2006
FROM HOADON A, CT_HOADON B
WHERE A.SOHD = B.SOHD AND YEAR(A.NGAYLAPHD) = 2006
--18
SELECT B.MAHH, A.TENHH, SUM(B.SOLUONG) AS MatHangBanChayNhat
FROM HANGHOA A, CT_HOADON B
WHERE A.MAHH = B.MAHH
GROUP BY B.MAHH, A.TENHH
HAVING SUM(B.SOLUONG) >= ALL (SELECT SUM(SOLUONG)
								FROM CT_HOADON
								GROUP BY MAHH)
--19
SELECT C.MAHH, A.TENHH, A.DVT, SUM(C.SOLUONG) AS TongSoLuong, SUM(C.DONGIA * C.SOLUONG) AS TongThanhTien
FROM HANGHOA A, HOADON B, CT_HOADON C
WHERE A.MAHH = C.MAHH AND B.SOHD = C.SOHD AND MONTH(B.NGAYLAPHD) = 5 AND YEAR(B.NGAYLAPHD) = 2006
GROUP BY C.MAHH, A.TENHH, A.DVT
--20
SELECT B.MAHH, A.TENHH, COUNT(B.MAHH) AS MatHangNhieuNguoiMua
FROM HANGHOA A, CT_HOADON B
WHERE A.MAHH = B.MAHH
GROUP BY B.MAHH, A.TENHH
HAVING COUNT(B.MAHH) >= ALL (SELECT COUNT(MAHH)
							FROM CT_HOADON
							GROUP BY MAHH)
