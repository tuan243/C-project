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
as select * from dbo.ResTable
go

exec UserProc_GetListTable
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
	select f.name, bi.count, f.price, f.price*bi.count as TotalPrice
	from dbo.Billinfo as bi, dbo.Bill as b, dbo.Food as f
	where bi.IDBill = b.ID and bi.IDFood = f.ID and b.IDTable = @IDTable
end
go

exec USerProc_GetMenu @IDTable = 1