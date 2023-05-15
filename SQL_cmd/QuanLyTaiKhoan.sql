USE Quan_ly_thu_vien

CREATE TABLE QuanLyTaiKhoan(
TaiKhoanID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
TaiKhoan NVARCHAR(50) NOT NULL,
MatKhau NVARCHAR(50) NOT NULL,
Quyen Nvarchar(50) NOT NULL)

INSERT INTO QuanLyTaiKhoan(TaiKhoan,MatKhau,Quyen) VALUES ('ngocanh','pass','admin')

DROP Table QuanLyTaiKhoan
SELECT * FROM QuanLyTaiKhoan

UPDATE QuanLyTaiKhoan SET MatKhau = 'pass11' WHERE TaiKhoan = 'anh1'