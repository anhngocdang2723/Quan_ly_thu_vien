USE [Quan_ly_thu_vien]
GO
/****** Object:  StoredProcedure [dbo].[sp_DangNhap]    Script Date: 4/11/2023 12:09:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[sp_DangNhap]
	@uname NVARCHAR(50),
	@upass NVARCHAR(50)
AS
BEGIN
	SELECT * FROM Accounts WHERE username = @uname AND password = @upass
END