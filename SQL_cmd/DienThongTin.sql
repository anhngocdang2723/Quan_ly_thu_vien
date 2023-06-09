USE [Quan_ly_thu_vien]
GO
/****** Object:  StoredProcedure [dbo].[sp_DienThongTin]    Script Date: 4/11/2023 12:26:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[sp_DienThongTin]
	@name NVARCHAR(40),
	@scode Char(30),
	@add NVARCHAR(50),
	@pnum CHAR(30)
AS
BEGIN
	SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM Readers WHERE name = @name)
    BEGIN
        RAISERROR('Ho ten da ton tai', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM Readers WHERE student_code = @scode)
    BEGIN
        RAISERROR('Ma sinh vien da ton tai', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM Readers WHERE phone_num = @pnum)
    BEGIN
        RAISERROR('So dien thoai da ton tai', 16, 1);
        RETURN;
    END

    INSERT INTO Readers (name, student_code, address, phone_num)
    VALUES (@name,@scode,@add,@pnum);
END