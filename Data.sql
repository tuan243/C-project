create database RestaurantManagement
go

use RestaurantManagement
go

--Account
create table Account
(
	Username nvarchar(100) primary key,
	Displayname nvarchar(100) not null,
	Password nvarchar(1000) not null default 0,
	Type int not null default 0 -- 1: Admin || 0: Staff
)
go
--Account Type

--Category
create table Category
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên'
)
go
--Food
create table Food
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',
	Size nvarchar(100) not null, --Nhỏ|| Vừa || Lớn
	Fcategory int not null,
	Price float not null default 0

	foreign key (Fcategory) references dbo.Category(id)
)
go
--Table
create table ResTable
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',
	Status nvarchar(100) not null default N'Trống', --Trống || Có người || Đã được đặt
	Size int not null default 4
)
go
--Bill
create table Bill
(
	ID int identity primary key,
	dateCheckIn date not null default getdate(),
	dateCheckOut date,
	IDTable int not null,
	Status int not null default 0 -- 1: đã thanh toán || 0: chưa thanh toán

	foreign key (IDTable) references dbo.ResTable(id)
)
go
--Bill info
create table Billinfo
(
	ID int identity primary key,
	IDBill int not null,
	IDFood int not null,
	Count int not null default 0,

	foreign key (IDBill) references dbo.Bill(id),
	foreign key (IDFood) references dbo.Food(id),
)
go


--update dbo.ResTable set status =N'Có người' where ID = 91
--update dbo.ResTable set status =N'Đã được đặt' where ID = 90


select * from dbo.Bill
select * from dbo.Billinfo
select * from dbo.food
select * from dbo.Category

