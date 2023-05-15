Select Br.borrowID As N'Mã mượn', R.readerID, R.rname, B.bookID, B.bname, Br.borrow_date, Br.due_date, Br.quantity_borrowed
From Borrows Br
Join Books B on B.bookID = Br.bookID
Join Readers R On R.ReaderID = Br.readerID

select * from Borrows
select * from borrows where borrowID = 1

select * from Readers
insert into Borrows values

insert into Accounts values ('ngocanh','pass','admin')
insert into Borrows( readerID,bookID,borrow_date,due_date,quantity_borrowed)
values(1,3,GETDATE(),GETDATE(),1)

select br.borrowID,b.bookID,b.bname, r.readerID, r.rname
from Borrows br
Join Books b on br.bookID = b.bookID
Join Readers r on br.readerID = r.readerID
where br.bookID = 3 and br.readerID = 1