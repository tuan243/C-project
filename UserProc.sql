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
@IDBill int, @Discount int
as
begin
	update dbo.Bill set Status = 1, Discount = @Discount where ID = @IDBill
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
	insert into  dbo.Bill ( dateCheckIn, dateCheckOut, IDTable, Status, Discount )
	values ( GETDATE(), null, @IDTable, 0, 0 )
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
		insert into dbo.Bill ( dateCheckIn, dateCheckOut, IDTable, Status, Discount ) values ( GETDATE(), null, @idSecondTable, 0, 0 )

		select @idSecondBill = max(ID) from dbo.Bill where IDTable = @idSecondTable and Status = 0
	end

	select ID into fIDBillInfo from dbo.Billinfo where IDBill = @idFirstBill

	if(@SecondisNULL > 0)
	begin
		update dbo.Billinfo set IDBill = @idSecondBill where ID in ( select * from dbo.fIDBillInfo )
		update dbo.ResTable set Status = N'Trống' where ID = @idFirstTable
	end
	else
	begin
		select ID into sIDBillinfo from dbo.Billinfo where IDBill = @idSecondBill
		update dbo.Billinfo set IDBill = @idFirstBill where ID in ( select * from dbo.sIDBillInfo )
		update dbo.Billinfo set IDBill = @idSecondBill where ID in ( select * from dbo.fIDBillInfo )

	end
	drop table dbo.fIDBillinfo
	drop table dbo.sIDBillInfo
end
go

exec UserProc_SwitchTable @idFirstTable = 1 , @idSecondTable = 3
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