
create database QLSV;
use QLSV;
go

create table SINHVIEN (MASV char(10) NOT NULL, HOVATEN char (30) NOT NULL, GIOITINH
char(3) NOT NULL, NGAYSINH datetime, NOISINH char (30), MAKHOA
char(10) NOT NULL, MALOP char (10) NOT NULL, MAHE char (10) NOT
NULL);

create table DMLOP (MALOP char (10) NOT NULL, TENLOP char (50), MAKHOA char (10) NOT
NULL, CVHT char (50), GHICHU char (100));

create table KHOAVIEN (MAKHOA char(10) NOT NULL, TENKHOA char(100) NOT NULL, DIACHI
char(50), SODT char (12));

create table HEDT (MAHE char(10) NOT NULL, TENHE char(50) NOT NULL, MUCHP int, SONAM
int, GHICHU char (100));

create table HETHONG (TENDN char (50) NOT NULL, MATKHAU char (100), QUYEN char (1))

/* Them du lieu vao cac bang */
insert into HETHONG values ('thang', '123456', 'a')

insert into HEDT values ('cq', 'Chinh quy', 200000, 4, 'He dao tao chinh quy do nha nuoc quy dinh')
insert into HEDT values ('qt', 'Quoc te', 500000, 4, 'He dao tao lien ket voi cac truong quoc te')
insert into HEDT values ('tt', 'Tien tien va chat luong cao', 350000, 4, 'He dao tao chat luong cao va giang day bang giao trinh tieng Anh')

insert into KHOAVIEN values ('cntt', 'Cong nghe thong tin va kinh te so', 'A1-1310', '0123456789')
insert into KHOAVIEN values ('mkt', 'Marketing', 'A1-1305', '0123456788')
insert into KHOAVIEN values ('ibd', 'Dao tao quoc te', 'A2-G01', '0123456787')

insert into DMLOP values ('cntt63a', 'Cong nghe thong tin 63A', 'cntt', 'Tran Thi My Diep', '')
insert into DMLOP values ('cntt63b', 'Cong nghe thong tin 63B', 'cntt', 'Tran Thi My Diep', '')
insert into DMLOP values ('htttql63a', 'He thong thong tin quan ly 63A', 'cntt', 'Nguyen Anh Phuong', '')
insert into DMLOP values ('htttql63b', 'He thong thong tin quan ly 63B', 'cntt', 'Nguyen Anh Phuong', '')
insert into DMLOP values ('mkt63a', 'Marketing 63A', 'mkt', 'Nguyen Ha Phuong', '')
insert into DMLOP values ('ibda', 'Tai chinh ngan hang quoc te 63', 'ibd', 'Doan Ngoc Huong', '')

insert into SINHVIEN values ('1231231230', 'Tran Nhat Thang', 'Nam', '12-03-2003', 'Ha Noi', 'cntt', 'cntt63a', 'cq')
insert into SINHVIEN values ('1231231210', 'Nguyen Hong Quan', 'Nam', '11-25-2003', 'Ha Noi', 'cntt', 'cntt63a', 'cq')
insert into SINHVIEN values ('1231231210', 'Nguyen Ha Phuong', 'Nu', '03-24-2003', 'Ha Noi', 'mkt', 'mkt63a', 'cq')
insert into SINHVIEN values ('1231231210', 'Nguyen Thu Trang', 'Nu', '11-30-2003', 'Ha Noi', 'ibd', 'ibda', 'qt')

select * from SINHVIEN
select * from DMLOP
select * from KHOAVIEN
select * from HEDT
select * from HETHONG

create view THONGTIN_SV_LOP 
as
select SINHVIEN.*, TENLOP, CVHT, GHICHU
from SINHVIEN 
inner join DMLOP on SINHVIEN.MALOP = DMLOP.MALOP;

select * from THONGTIN_SV_LOP