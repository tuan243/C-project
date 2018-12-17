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
insert into dbo.Category ( Name ) values ( N'Salad - Rau trộn')
insert into dbo.Category ( Name ) values ( N'Noodles and Pasta - Các loại mì' )
insert into dbo.Category ( Name ) values ( N'SeaFood - Hải sản' )
insert into dbo.Category ( Name ) values ( N'Meat - Thịt' )
insert into dbo.Category ( Name ) values ( N'Hotpot - Lẩu' )
insert into dbo.Category ( Name ) values ( N'Dessert - Tráng miệng' )
insert into dbo.Category ( Name ) values ( N'Alcohol - Đồ uống có cồn' )
insert into dbo.Category ( Name ) values ( N'Soft drink - Nước ngọt' )
go

--update dbo.Category set Name = N'Dessert - Tráng miệng' where ID = 9
--insert Food
go
--Breakfast
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Trứng ốp la và bánh mì' , N'Nhỏ', 1, 25000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Trứng ốp la và bánh mì' , N'Vừa', 1, 35000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Full English Breakfast' , N'Nhỏ', 1, 60000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Full English Breakfast' , N'Vừa', 1, 75000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Pancake - Bánh kếp' , N'Nhỏ', 1, 30000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Pancake - Bánh kếp' , N'Vừa', 1, 45000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Waffles - Bánh quế' , N'Nhỏ', 1, 30000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Waffles - Bánh quế' , N'Vừa', 1, 45000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Sandwich - Bánh mì kẹp' , N'Nhỏ', 1, 25000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Sandwich - Bánh mì kẹp' , N'Vừa', 1, 35000 )

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

--Salad
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cobb Salad' , N'Nhỏ', 4, 50000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cobb Salad' , N'Vừa', 4, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cobb Salad' , N'Lớn', 4, 100000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Caesar Salad' , N'Nhỏ', 4, 50000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Caesar Salad' , N'Vừa', 4, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Caesar Salad' , N'Lớn', 4, 100000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Oliver Salad' , N'Nhỏ', 4, 50000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Oliver Salad' , N'Vừa', 4, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Oliver Salad' , N'Lớn', 4, 100000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Nicoise Salad' , N'Nhỏ', 4, 50000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Nicoise Salad' , N'Vừa', 4, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Nicoise Salad' , N'Lớn', 4, 100000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Ambrosia Salad' , N'Nhỏ', 4, 50000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Ambrosia Salad' , N'Vừa', 4, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Ambrosia Salad' , N'Lớn', 4, 100000 )

go

--Noodles and Pasta
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Mì xào chua ngọt' , N'Vừa', 5, 45000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Mì xào chua ngọt' , N'Lớn', 5, 60000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Mì xào tôm thịt' , N'Vừa', 5, 50000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Mì xào tôm thịt' , N'Lớn', 5, 65000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Spaghetti with crab sauce' , N'Vừa', 5, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Spaghetti with crab sauce' , N'Lớn', 5, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Spaghetti with meatballs' , N'Nhỏ', 5, 55000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Spaghetti with meatballs' , N'Vừa', 5, 70000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Spaghetti with meatballs' , N'Lớn', 5, 85000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Spaghetti with clams' , N'Nhỏ', 5, 55000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Spaghetti with clams' , N'Vừa', 5, 70000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Spaghetti with clams' , N'Lớn', 5, 85000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lobster Pasta' , N'Nhỏ', 5, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lobster Pasta' , N'Vừa', 5, 90000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lobster Pasta' , N'Lớn', 5, 115000 )

go

--SeaFood
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Tôm hấp bia' , N'Vừa', 6, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Tôm hấp bia' , N'Lớn', 6, 100000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Tôm lăn bột' , N'Vừa', 6, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Tôm lăn bột' , N'Lớn', 6, 100000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Nghêu hấp sả' , N'Vừa', 6, 60000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Nghêu hấp sả' , N'Lớn', 6, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Sò điệp nướng mỡ hành' , N'Vừa', 6, 100000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Sò điệp nướng mỡ hành' , N'Lớn', 6, 125000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Ghẹ sốt trứng muối' , N'Vừa', 6, 250000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Ghẹ sốt trứng muối' , N'Lớn', 6, 300000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Ghẹ sốt tỏi' , N'Vừa', 6, 250000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Ghẹ sốt tỏi' , N'Lớn', 6, 300000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cua rang muối' , N'Vừa', 6, 225000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cua rang muối' , N'Lớn', 6, 275000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cua rang me' , N'Vừa', 6, 225000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cua rang me' , N'Lớn', 6, 275000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Mực nướng muối ớt' , N'Vừa', 6, 125000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Mực nướng muối ớt' , N'Lớn', 6, 150000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Bạch tuộc nướng muối ớt' , N'Vừa', 6, 125000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Bạch tuộc nướng muối ớt' , N'Lớn', 6, 150000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cá hồi áp chảo' , N'nhỏ', 6, 60000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cá hồi áp chảo' , N'vừa', 6, 80000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lươn nướng kiểu nhật' , N'Vừa', 6, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lươn nướng kiểu nhật' , N'Lớn', 6, 100000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lươn chiên giòn mắm me' , N'Vừa', 6, 65000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lươn chiên giòn mắm me' , N'Lớn', 6, 80000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Khô mực nướng' , N'Vừa', 6, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Khô mực nướng' , N'Lớn', 6, 100000 )

go

--Meat
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Beef Steak - Bò bít tết' , N'Vừa', 7, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Beef Steak - Bò bít tết' , N'Lớn', 7, 100000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Bò hầm' , N'Vừa', 7, 65000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Bò hầm' , N'Lớn', 7, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Bò nhúng dấm' , N'Vừa', 7, 120000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Bò nhúng dấm' , N'Lớn', 7, 150000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Dê hấp sả' , N'Vừa', 7, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Dê hấp sả' , N'Lớn', 7, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Dê nướng muối ớt' , N'Vừa', 7, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Dê nướng muối ớt' , N'Lớn', 7, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Sườn cừu nướng' , N'Vừa', 7, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Sườn cừu nướng' , N'Lớn', 7, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Thịt cừu hấp sả' , N'Vừa', 7, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Thịt cừu hấp sả' , N'Lớn', 7, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Thịt cừu áp chảo' , N'Vừa', 7, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Thịt cừu áp chảo' , N'Lớn', 7, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Gà nướng muối ớt' , N'Vừa', 7, 60000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Gà nướng muối ớt' , N'Lớn', 7, 85000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Gà chiên nước mắm' , N'Vừa', 7, 60000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Gà chiên nước mắm' , N'Lớn', 7, 85000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Gà xé phay' , N'Vừa', 7, 60000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Gà xé phay' , N'Lớn', 7, 85000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Gà nướng phô mai' , N'Vừa', 7, 75000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Gà nướng phô mai' , N'Lớn', 7, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Mầm heo nướng' , N'Vừa', 7, 65000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Mầm heo nướng' , N'Lớn', 7, 85000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Sườn heo chua ngọt' , N'Vừa', 7, 60000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Sườn heo chua ngọt' , N'Lớn', 7, 85000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cút chiên bơ' , N'Vừa', 7, 55000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Cút chiên bơ' , N'Lớn', 7, 75000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Vừa', 7, 0 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'' , N'Lớn', 7, 0 )

go

--Hotpot
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu cá diêu hồng' , N'Nhỏ', 8, 100000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu cá diêu hồng' , N'Vừa', 8, 150000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu cá diêu hồng' , N'Lớn', 8, 200000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu nấm' , N'Nhỏ', 8, 150000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu nấm' , N'Vừa', 8, 200000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu nấm' , N'Lớn', 8, 250000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu hải sản' , N'Nhỏ', 8, 200000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu hải sản' , N'Vừa', 8, 250000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu hải sản' , N'Lớn', 8, 300000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu Thái' , N'Nhỏ', 8, 125000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu Thái' , N'Vừa', 8, 175000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu Thái' , N'Lớn', 8, 225000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu xí quách' , N'Nhỏ', 8, 150000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu xí quách' , N'Vừa', 8, 200000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu xí quách' , N'Lớn', 8, 250000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu gà lá chanh' , N'Nhỏ', 8, 100000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu gà lá chanh' , N'Vừa', 8, 150000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu gà lá chanh' , N'Lớn', 8, 200000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu gà ớt hiểm' , N'Nhỏ', 8, 100000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu gà ớt hiểm' , N'Vừa', 8, 150000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu gà ớt hiểm' , N'Lớn', 8, 200000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu cua đồng' , N'Nhỏ', 8, 125000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu cua đồng' , N'Vừa', 8, 175000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu cua đồng' , N'Lớn', 8, 200000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu cá kèo' , N'Nhỏ', 8, 125000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu cá kèo' , N'Vừa', 8, 175000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu cá kèo' , N'Lớn', 8, 200000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu Kim Chi' , N'Nhỏ', 8, 150000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu Kim Chi' , N'Vừa', 8, 200000 )
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Lẩu Kim Chi' , N'Lớn', 8, 250000 )

go

--Dessert
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Trái cây' , N'Nhỏ', 9, 50000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Trái cây' , N'Vừa', 9, 75000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Trái cây' , N'Lớn', 9, 100000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Rau câu dừa' , N'Nhỏ', 9, 50000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Rau câu dừa' , N'Vừa', 9, 75000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Rau câu dừa' , N'Lớn', 9, 100000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Rau câu cà phê' , N'Nhỏ', 9, 50000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Rau câu cà phê' , N'Vừa', 9, 75000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Rau câu cà phê' , N'Lớn', 9, 100000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Chocolate chip cookie - Bánh qui sôcôla' , N'Nhỏ', 9, 45000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Chocolate chip cookie - Bánh qui sôcôla' , N'Vừa', 9, 65000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Chocolate chip cookie - Bánh qui sôcôla' , N'Lớn', 9, 95000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem dừa' , N'Nhỏ', 9, 25000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem dừa' , N'Vừa', 9, 45000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem dừa' , N'Lớn', 9, 65000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem sôcôla' , N'Nhỏ', 9, 25000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem sôcôla' , N'Vừa', 9, 45000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem sôcôla' , N'Lớn', 9, 65000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem chuối' , N'Nhỏ', 9, 25000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem chuối' , N'Vừa', 9, 45000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem chuối' , N'Lớn', 9, 65000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem đậu xanh' , N'Nhỏ', 9, 25000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem đậu xanh' , N'Vừa', 9, 45000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Kem đậu xanh' , N'Lớn', 9, 65000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Chè khúc bạch' , N'Nhỏ', 9, 35000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Chè khúc bạch' , N'Vừa', 9, 55000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Chè khúc bạch' , N'Lớn', 9, 75000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Chè trôi nước' , N'Nhỏ', 9, 25000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Chè trôi nước' , N'Vừa', 9, 45000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Chè trôi nước' , N'Lớn', 9, 65000 )

go

--Alcohol
insert into dbo.food (Name , size, Fcategory, Price) values ( N'Tiger' , N'Lon 330ml', 10, 15000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'heineken' , N'Lon 330ml', 10, 20000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Spy' , N'Chai 275ml', 10, 30000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Strongbow' , N'Chai 330ml', 10, 20000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Rượu Gạo Makkoli' , N'Chai 750ml', 10, 90000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Rượu Soju' , N'Lớn', 10, 85000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Rượu Sake vẩy vàng Shiragiku honjozo' , N'Chai 1800ml', 10, 1500000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'CHIVAS 12' , N'Chai 700ml', 10, 650000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Remy Martin VSOP' , N'Chai 700ml', 10, 1175000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Hennessy VSOP' , N'Chai 700ml', 10, 1350000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'CHIVAS 18' , N'Chai 700ml', 10, 1500000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'CHIVAS 21' , N'Chai 700ml', 10, 2750000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Remy Martin XO' , N'Chai 700ml', 10, 2950000 )

insert into dbo.food (Name , size, Fcategory, Price) values ( N'Hennessy XO' , N'Chai 700ml', 10, 4150000 )

go

--Soft drink
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Coca-cola' , N'Nhỏ', 11, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Coca-cola' , N'Vừa', 11, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Pepsi' , N'Nhỏ', 11, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Pepsi' , N'Vừa', 11, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'7up' , N'Nhỏ', 11, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'7up' , N'Vừa', 11, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Orange juice - Nước cam' , N'Nhỏ', 11, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Orange juice - Nước cam' , N'Vừa', 11, 15000 )


insert into dbo.food(Name , size, Fcategory, Price) values ( N'Lemonade - Nước chanh' , N'Nhỏ', 11, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Lemonade - Nước chanh' , N'Vừa', 11, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Sinh tố dâu' , N'Nhỏ', 11, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Sinh tố dâu' , N'Vừa', 11, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Sinh tố mãng cầu' , N'Nhỏ', 11, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Sinh tố mãng cầu' , N'Vừa', 11, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Sinh tố dưa gang' , N'Nhỏ', 11, 10000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Sinh tố dưa gang' , N'Vừa', 11, 15000 )

insert into dbo.food(Name , size, Fcategory, Price) values ( N'Fresh Blueberry Lemonade ' , N'Nhỏ', 11, 25000 )
insert into dbo.food(Name , size, Fcategory, Price) values ( N'Fresh Blueberry Lemonade' , N'Vừa', 11, 35000 )

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
