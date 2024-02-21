﻿create database QLHocSinh
go
CREATE TABLE HocSinh (
 Ten varchar(100),
 Diachi varchar(255),
 Cmnd varchar(100)
);
go
INSERT INTO HocSinh (Ten, Diachi, Cmnd)
VALUES ('nva', 'hcm', '123');
INSERT INTO HocSinh (Ten, Diachi, Cmnd)
VALUES ('nva2', 'hcm', '123');
INSERT INTO HocSinh (Ten, Diachi, Cmnd)
VALUES ('nva3', 'hcm', '123');
INSERT INTO HocSinh (Ten, Diachi, Cmnd)
VALUES ('nva4', 'hcm', '123');
INSERT INTO HocSinh (Ten, Diachi, Cmnd)
VALUES ('nva5', 'hcm', '123');
go
select * from HocSinh
go

--tao bang giao vien
CREATE TABLE GiaoVien(
	Ten nvarchar(100),
	DiaChi nvarchar(225),
	cmnd nvarchar(100),
	NgaySinh char(20)
);
GO
INSERT INTO GiaoVien(Ten, DiaChi, cmnd, NgaySinh)
VALUES ('gv1','hcm','221','12-02-1989');
INSERT INTO GiaoVien(Ten, DiaChi, cmnd, NgaySinh)
VALUES ('gv2','hcm','222','18-07-1973');
INSERT INTO GiaoVien(Ten, DiaChi, cmnd, NgaySinh)
VALUES ('gv3','hcm','223','02-04-1992');
INSERT INTO GiaoVien(Ten, DiaChi, cmnd, NgaySinh)
VALUES ('gv4','hcm','224','22-06-1990');
INSERT INTO GiaoVien(Ten, DiaChi, cmnd, NgaySinh)
VALUES ('TOANNGU','hcm','225','29-02-1980');
GO
SELECT * FROM GiaoVien
