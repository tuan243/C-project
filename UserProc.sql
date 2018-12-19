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

exec UserProc_GetListTable
go

create proc UserProc_ChangeTableStatus
@IDTable int, @Status varchar(100)
as
begin
	update dbo.ResTable set Status = @Status
	where ID = @IDTable
end
go

create proc UserProc_CheckOut
@IDBill int, @Discount int
as
begin
	update dbo.Bill set Status = 1, Discount = @Discount where ID = @IDBill
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

create proc UserProc_changeFName
@IDFood int, @Name varchar(100)
as
begin
	update dbo.Food set Name = @Name where ID = @IDFood
end
go

create proc UserProc_changeFPrice
@IDFood int, @Price float
as
begin
	update dbo.Food set Price = @Price where ID = @IDFood
end
go

select max(ID) from dbo.Bill
go

delete dbo.Billinfo

delete dbo.Bill
go

create trigger UserTrigger_UpdateBillInfo
on dbo.Billinfo for insert, update
as
begin
	declare @idBill int
	select @idBill = IDBill from inserted
	declare @idTable int
	select @idTable = IDTable from dbo.Bill where ID = @idBill and Status = 0
	update dbo.ResTable set Status = N'Có người' where ID = @idTable
end
go

create trigger UserTrigger_UpdateBill
on dbo.Bill for update
as
begin
	declare @idBill int 
	select @idBill = ID from inserted
	declare @idTable int
	select @idTable = IDTable from dbo.Bill where ID = @idBill
	declare @count int = 0
	select @count = count(*) from dbo.Bill where IDTable = @idTable and Status = 0
	if(@count = 0)
		update dbo.ResTable set Status = N'Trống' where ID = @idTable
end
go

create proc UserProc_CheckEmptyBill
@iDTable int 
as
begin
	select count(bi.Count) from dbo.Billinfo as bi, dbo.Bill as b 
	where  b.Status = 0 and bi.IDBill = b.ID and b.IDTable = @iDTable
end
go