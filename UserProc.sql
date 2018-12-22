use RestaurantManagement
go

create proc UserProc_GetAccountByUsername
@username nvarchar(100)
as
begin
	select * from dbo.Account where Username = @username
end
go

exec UserProc_GetAccountByUsername @username = N'Admin_02'
go

create proc UserProc_Login
@username nvarchar(100), @password nvarchar(100)
as
begin
	select * from dbo.Account where Username = @username and password = @password
end
go

exec UserProc_Login @username = N'Admin_02' , @password = N'1'
go

create proc UserProc_GetListTable
as 
begin
	select * from dbo.ResTable
end
go

create proc UserProc_GetListTableByStatus
@status nvarchar(100)
as
begin
	select * from dbo.ResTable where Status = @status
end
go

select * from dbo.ResTable
exec UserProc_GetListTableByStatus @status = N'Trống'
go

create proc UserProc_CheckOut
@IDBill int, @Discount int, @Total float
as
begin
	update dbo.Bill set dateCheckOut = Getdate() , Status = 1, Discount = @Discount, Total = @Total where ID = @IDBill
end
go

create proc UserProc_GetUnCheckOutBilliD
@IDTable int
as
begin
	select * from dbo.Bill where IDTable = @IDTable and status = 0
end
go

exec UserProc_GetUnCheckOutBilliD @IDTable = 1
go

create proc UserProc_GetBillinfo
@IDBill int
as
begin
	select * from dbo.Billinfo where IDBill = @IDBill
end
go

exec UserProc_GetBillinfo @IDBill = 1
go

create proc USerProc_GetMenu
@IDTable int
as
begin
	select f.ID, f.name, f.Size, bi.count, f.price, f.price*bi.count as TotalPrice
	from dbo.Billinfo as bi, dbo.Bill as b, dbo.Food as f
	where bi.IDBill = b.ID and bi.IDFood = f.ID and b.Status = 0 and b.IDTable = @IDTable
end
go

exec USerProc_GetMenu @IDTable = 1
go

create proc UserProc_GetFoodByCategoryID
@ID int
as
begin
	select * from dbo.Food where Fcategory = @ID
end
go

create proc UserProc_InsertBill
@IDTable int
as
begin
	insert into  dbo.Bill ( dateCheckIn, dateCheckOut, IDTable, Status, Discount, Total)
	values ( GETDATE(), null, @IDTable, 0, 0, 0 )
end
go

create proc UserProc_InsertBillInfo
@IDBill int, @IDFood int, @Count int
as
begin
	declare @ExistBI int
	declare @Existcount int

	select @ExistBI = ID, @Existcount = Count
	from dbo.Billinfo where IDBill = @IDBill and IDFood = @IDFood

	if(@ExistBI > 0)
	begin
		declare @NewCount int = @Existcount + @Count
		if(@NewCount <= 0)
			delete dbo.Billinfo where IDBill = @IDBill and IDFood = @IDFood
		else
			update dbo.Billinfo set Count = @NewCount where IDBill = @IDBill and IDFood = @IDFood
	end
	else
	begin
		if(@Count > 0)
			insert into dbo.Billinfo ( IDBill, IDFood, Count) values ( @IDBill, @IDFood , @Count )
	end
end
go

create proc UserProc_RemoveItemInBillInfo 
@IDBill int, @IDFood int
as
begin
	delete dbo.Billinfo where IDBill = @IDBill and IDFood = @IDFood
end
go

create proc UserProc_ChangePassWord
@username nvarchar(100), @newpass nvarchar(100)
as
begin
	update dbo.Account set Password = @newpass where Username = @username
end
go

create proc UserProc_ChangeDisplayName
@username nvarchar(100), @displayname nvarchar(100)
as
begin
	update dbo.Account set Displayname = @displayname where Username = @username
end
go

create proc UserProc_ChangeTableStatus
@IDTable int, @Status nvarchar(100)
as
begin
	update dbo.ResTable set Status = @Status
	where ID = @IDTable
end
go

create proc UserProc_SwitchTable
@idFirstTable int, @idSecondTable int
as
begin
	declare @idFirstBill int
	declare @idSecondBill int
	declare @SecondisNULL int = 0

	select @idFirstBill = ID from dbo.Bill where IDTable = @idFirstTable and Status = 0
	select @idSecondBill = ID from dbo.Bill where IDTable = @idSecondTable and Status = 0

	if(@idSecondBill is null)
	begin
		set @SecondisNULL = 1
		insert into dbo.Bill ( dateCheckIn, dateCheckOut, IDTable, Status, Discount, Total) values ( GETDATE(), null, @idSecondTable, 0, 0, 0)

		select @idSecondBill = max(ID) from dbo.Bill where IDTable = @idSecondTable and Status = 0
	end

	select ID into fIDBillInfo from dbo.Billinfo where IDBill = @idFirstBill

	if(@SecondisNULL > 0)
	begin
		update dbo.Billinfo set IDBill = @idSecondBill where ID in ( select * from dbo.fIDBillInfo )
		update dbo.ResTable set Status = N'Trống' where ID = @idFirstTable
		update dbo.ResTable set Status = N'Có người' where ID = @idSecondBill
	end
	else
	begin
		select ID into sIDBillinfo from dbo.Billinfo where IDBill = @idSecondBill
		update dbo.Billinfo set IDBill = @idFirstBill where ID in ( select * from dbo.sIDBillInfo )
		update dbo.Billinfo set IDBill = @idSecondBill where ID in ( select * from dbo.fIDBillInfo )
		drop table dbo.sIDBillInfo
	end
	drop table dbo.fIDBillinfo

end
go

exec UserProc_SwitchTable @idFirstTable = 1 , @idSecondTable = 2
go

create proc UserProc_CombineTable
@idFirstTable int, @idSecondTable int
as
begin
	if(@idFirstTable <> @idSecondTable)
	begin
		declare @idFirstBill int
		declare @idSecondBill int

		select @idFirstBill = ID from dbo.Bill where IDTable = @idFirstTable and Status = 0
		select @idSecondBill = ID from dbo.Bill where IDTable = @idSecondTable and Status = 0

		select ID into IDBillInfo from dbo.Billinfo where IDBill = @idSecondBill
		update dbo.Billinfo set IDBill = @idFirstBill where ID in ( select * from dbo.IDBillInfo )
		delete from dbo.Bill where ID = @idSecondBill and IDTable = @idSecondTable 
		update dbo.ResTable set Status = N'Trống' where ID = @idSecondTable

		drop table dbo.IDBillInfo
	end
end
go

create proc UserProc_GetIncome
@from date, @to date
as
begin
	select t.Name, b.Total, b.dateCheckIn, b.dateCheckOut, b.Discount
	from dbo.Bill as b, dbo.ResTable as t
	where b.IDTable = t.ID and b.Status = 1 and b.dateCheckOut >= @from and b.dateCheckOut <= @to
end
go

create proc UserProc_InsertFood
@name nvarchar(100), @size nvarchar(100), @Fcategory int, @price float
as
begin
	insert into dbo.Food (Name , size, Fcategory, Price) values ( @name, @size, @Fcategory, @price )
end
go

create proc UserProc_EditFood
@id int, @name nvarchar(100), @size nvarchar(100), @Fcategory int, @price float
as
begin
	update dbo.Food set Name = @name, Size = @size, Fcategory = @Fcategory, Price = @price where ID = @id
end
go

create proc UserProc_InsertTable
@id int, @name nvarchar(100), @status nvarchar(100), @size int
as
begin
	insert into dbo.Restable(ID, Name, Status, Size) values (@id, @name, @status, @size)
end
go

create proc UserProc_EitTable
@id int, @name nvarchar(100), @status nvarchar(100), @size int
as
begin
	update dbo.Restable set  Name= @name, Status = @status, Size = @size
end
go

create proc UserProc_InsertAccount
@username nvarchar(100), @displayname nvarchar(100), @pass nvarchar(1000), @type int
as
begin 
	insert into dbo.Account(Username, Displayname, Password, Type) values (@username, @displayname, @pass, @type)
end 
go


create proc UserProc_EditAccount
@username nvarchar(100), @displayname nvarchar(100), @pass nvarchar(1000), @type int
as
begin 
	update dbo.Account set Username = @username, Displayname = @displayname, Password= @pass, Type = @type

end 
go

create proc User_InsertCategory
@id int, @name nvarchar(100)
as
begin
	insert into dbo.Category(ID, Name) values (@id, @name)
end
go

create proc User_EditCategory
@id int, @name nvarchar(100)
as
begin
	update dbo.Category set  Name = @name
end
go


create proc UserProc_DeleteBillinfoByFoodID
@id int
as
begin
	delete dbo.Billinfo where IDFood = @id
end
go


create proc UserProc_DeleteFood
@id int
as
begin
	delete dbo.Food where ID = @id
end
go


----chưa dùng
--create proc UserProc_changeFName
--@IDFood int, @Name nvarchar(100)
--as
--begin
--	update dbo.Food set Name = @Name where ID = @IDFood
--end
--go

--create proc UserProc_changeFPrice
--@IDFood int, @Price float
--as
--begin
--	update dbo.Food set Price = @Price where ID = @IDFood
--end
--go

--create proc UserProc_CheckEmptyBill
--@iDTable int 
--as
--begin
--	select count(bi.Count) from dbo.Billinfo as bi, dbo.Bill as b 
--	where  b.Status = 0 and bi.IDBill = b.ID and b.IDTable = @iDTable
--end
--go

