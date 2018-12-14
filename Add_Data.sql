use RestaurantManagement
go
--insert Account
insert into dbo.Account	( Username, Displayname, Password, Type ) values ( N'Admin_01', N'Minh Quân', N'1', 1 )

insert into dbo.Account	( Username, Displayname, Password, Type ) values ( N'Admin_02', N'Minh Tuấn', N'1', 1 )

insert into dbo.Account	( Username, Displayname, Password, Type ) values ( N'Admin_03', N'Minh Cảnh', N'1', 1 )

insert into dbo.Account	( Username, Displayname, Password, Type ) values ( N'Staff_01', N'A', N'1', 0 )

insert into dbo.Account	( Username, Displayname, Password, Type ) values ( N'Staff_02', N'B', N'1', 0 )

go
select * from dbo.Account
go

--insert Table
go
--size 4
declare @i int = 1
while @i <= 5
begin
	insert dbo.ResTable (Name, Status, Size) values ( N'Bàn ' + CAST(@i as nvarchar(100)),N'Trống',4) 
	set @i = @i + 1
end
go

--size 6
declare @i int = 6
while @i <= 10
begin
	insert dbo.ResTable (Name, Status, Size) values ( N'Bàn ' + CAST(@i as nvarchar(100)),N'Trống',6) 
	set @i = @i + 1
end
go

--size 8
declare @i int = 11
while @i <= 15
begin
	insert dbo.ResTable (Name, Status, Size) values ( N'Bàn ' + CAST(@i as nvarchar(100)),N'Trống',8) 
	set @i = @i + 1
end
go

--size 10
declare @i int = 16
while @i <= 20
begin
	insert dbo.ResTable (Name, Status, Size) values ( N'Bàn ' + CAST(@i as nvarchar(100)),N'Trống',10) 
	set @i = @i + 1
end
go

select * from dbo.ResTable
go

--insert Category
insert into dbo.Category ( Name ) values ( N'Breakfast - Ăn sáng' )
insert into dbo.Category ( Name ) values ( N'Lunch - Ăn trưa' )
insert into dbo.Category ( Name ) values ( N'Dinner - Ăn tối' )
insert into dbo.Category ( Name ) values ( N'Noodles and Pasta - Các loại mì' )
insert into dbo.Category ( Name ) values ( N'SeaFood - Hải sản' )
insert into dbo.Category ( Name ) values ( N'Meat - Thịt' )
insert into dbo.Category ( Name ) values ( N'Hotpot - Lẩu' )
insert into dbo.Category ( Name ) values ( N'Dessert - Tráng miệng' )
insert into dbo.Category ( Name ) values ( N'Alcohol - Đồ uống có cồn' )
insert into dbo.Category ( Name ) values ( N'Soft drink - Nước ngọt' )
go

update dbo.Category set Name = N'Hotpot - Lẩu' where ID = 7
--insert Food
go
--Breakfast
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 1, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 1, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 1, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 1, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 1, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 1, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 1, 0 )

go
--Lunch
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 2, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 2, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 2, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 2, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 2, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 2, 0 )

go
--Dinner
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 3, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 3, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 3, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 3, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 3, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 3, 0 )

go

--Noodles and Pasta
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 4, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 4, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 4, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 4, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 4, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 4, 0 )

go

--SeaFood
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 5, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 5, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 5, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 5, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 5, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 5, 0 )

go

--Meat
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 6, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 6, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 6, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 6, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 6, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 6, 0 )
go

--Hotpot
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 7, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 7, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 7, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 7, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 7, 0 )

go

--Dessert
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 8, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 8, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 8, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 8, 0 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 8, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 8, 0 )

go

--Alcohol
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Vừa', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Lớn', 9, 0 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Vừa', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Lớn', 9, 0 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Vừa', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Lớn', 9, 0 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Vừa', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Lớn', 9, 0 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Vừa', 9, 0 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Lớn', 9, 0 )

go

--Soft drink
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Coca-cola' , N'Nhỏ', 10, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Coca-cola' , N'Vừa', 10, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Pepsi' , N'Nhỏ', 10, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Pepsi' , N'Vừa', 10, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'7up' , N'Nhỏ', 10, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'7up' , N'Vừa', 10, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Orange juice - Nước cam' , N'Nhỏ', 10, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Orange juice - Nước cam' , N'Vừa', 10, 15000 )


insert into dbo.food(Name , size, Fcategory, Price) values ( N'Lemonade - Nước chanh' , N'Nhỏ', 10, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Lemonade - Nước chanh' , N'Vừa', 10, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Nhỏ', 10, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'' , N'Vừa', 10, 15000 )

go

--insert Bill
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 1, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 2, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 3, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 4, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 5, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 6, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 7, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 8, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 9, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 10, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 11, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 12, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 13, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 14, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 15, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 16, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 17, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 18, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 19, 0 )
insert into dbo.Bill ( dateCheckin, datecheckout, IDTable, Status ) values ( GETDATE(), null, 20, 0 )

go

--insert BillInfo
insert into dbo.Billinfo ( IDBill, IDFood, Count ) values ( 1, 1, 2 )