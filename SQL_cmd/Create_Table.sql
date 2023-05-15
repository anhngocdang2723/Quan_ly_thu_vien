CREATE TABLE Accounts(
accountID int not null identity(1,1) primary key,
username nvarchar(50) not null,
password nvarchar(50) not null,
role nvarchar(10) not null)
--Drop table Accounts


Create TABLE Readers(
readerID int not null identity(1,1) primary key,
name nvarchar(100) not null,
address nvarchar(100) not null,
student_code int not null, 
phone_num int not null)
--Drop table Readers

CREATE TABLE Books(
bookID int not null identity(1,1) primary key,
name nvarchar(50) not null,
title nvarchar(100) not null,
author nvarchar(100) not null,
year_published int not null,
quantity int not null)
--Drop table Books


CREATE TABLE Borrows(
borrowID int identity(1,1) not null primary key,
readerID int not null foreign key references Readers(readerID),
bookID int not null foreign key references Books(bookID),
borrow_date date not null,
due_date date,
quantity_borrowed int not null)
--Drop table Borrows


CREATE TABLE Returns(
returnID int not null primary key,
borrowID int not null foreign key references Borrows(borrowID),
return_date date not null,
quantity_returned int not null,
late_fee float not null)
--Drop table Returns
