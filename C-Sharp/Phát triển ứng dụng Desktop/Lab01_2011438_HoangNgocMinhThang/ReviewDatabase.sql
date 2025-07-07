
create database ReviewDatabase
go
use ReviewDatabase
go

-- Category Get all
 create proc Catagory_GetAll
as
begin
	select * from dbo.Catagory
end
go

-- Category get by id
create proc Catagory_GetAllId
( @ID int )
as
begin
	select * from dbo.Catagory where ID = @ID
end
go

-- Category insert
create proc Category_Insert
(	@Name nvarchar(1000),
@Type int
)
as
begin
	--kiểm tra tồn tại Name: Lệnh này có thể không cần thiết trong một số bài
	if ( not exists ( select name from dbo.Catagory where Name=@Name))
	insert into dbo.Catagory(Name,Type) values (@Name,@Type)
end
go

-- Category Update
create proc Category_UPdate
(
@ID int,
@Name nvarchar(100),
@Type int
)
as
begin
	update dbo.Catagory
	set [Name]=@Name,[Type]=@Type
	where ID=@ID
end
go

-- Category Delete
create proc Category_Delete
(
	@ID int
)
as
begin
		delete from dbo.Catagory
		where ID=@ID
end
go

EXEC dbo.Category_Insert N'Tráng miệng', 1
exec dbo.Catagory_GetAll 

alter proc dbo.Category_Insert
(
@ID int output,
@Name nvarchar(1000),
@Type int
)
as
begin
	-- kiểm tra tồn tại Name
	if ( not exists ( select Name from dbo.Catagory where Name=@Name))
		insert into dbo.Catagory(Name,Type) values (@Name,@Type)
		set @ID=@@IDENTITY
end

declare @ID int = 0
exec dbo.Category_Insert @ID=@ID output,
@Name = N'Món rau',
@Type =1
select * from dbo.Catagory where ID =@ID

-- thủ tục lấy tất cả mẫu tin theo tên bảng
create proc [dbo].[Getall]
( 
	@Table nvarchar(200)
)
as
begin
	declare @Sql nvarchar(100)
	set @sql = 'Select * from ' + @Table
	exec (@sql) -- thực thi
end
exec dbo.GetAll 'Catagory'


create proc str_Food
(
	@ID int output,
	@Name nvarchar(50),
	@Unit nvarchar(100),
	@FoodCatagoryID int,
	@Price int,
	@Notes nvarchar(100)
)
as
begin
	if exists(select * from Catagory where ID = @FoodCatagoryID)-- kiểm tra khóa chính có trùng với khóa ngoại
	begin
		if not exists (select * from Food where Name=@Name) -- kiểm tra có trùng khóa chính với quan hệ lớp
			insert into Food (Name, Unit,FoodCatagoryID,Price,Notes) values (@Name,@Unit,@FoodCatagoryID,@Price,@Notes)
end
end
go

-- update Food
create proc str_Food_update
(
	@ID int output,
	@Name nvarchar(100),
	@Unit nvarchar(100),
	@FoodCatagoryID int,
	@Price int,
	@Notes nvarchar(100)
)
as
begin
	update dbo.Food
	set [Name]=@Name, [Unit]=@Unit,[FoodCatagoryID]=@FoodCatagoryID,[Price]=@Price,[Notes]=@Notes
	where ID=@ID
end
go

-- Delete 
create proc str_Food_Delete
(
	@ID int output,
	@Name nvarchar(100),
	@Unit nvarchar(100),
	@FoodCatagoryID int,
	@Price int,
	@Notes nvarchar(100)
)
as
begin 
	Delete from dbo.Food
	where ID=@ID
end
go

create proc Food_GetAll
as
begin
	select * from dbo.Food
end 
go

create proc Food_GetByID
( 
	@ID int
)
as
begin
	select * from dbo.Food where ID=@ID
end 
go

alter proc str_Food
(
	@ID int output,
	@Name nvarchar(100),
	@Unit nvarchar(100),
	@FoodCatagoryID int,
	@Price int,
	@Notes nvarchar(100)
)
as
begin 
	-- kiểm tra tồn tại name
	if ( not exists (select Name from dbo.Food where Name = @Name))
	 insert into dbo.Food (Name,Unit,FoodCatagoryID,Price,Notes) values (@Name,@Unit,@FoodCatagoryID,@Price,@Notes)
	 set @ID=@@IDENTITY
end
go
declare @ID int =0;
exec dbo.str_Food @ID = @ID output, @Name=N'Món rau',@Unit=N'Con',@FoodCatagoryID=1,@Price =250000,@Notes = N'None'
Select * from dbo.Food where ID = @ID


-- Insert table
create proc Table_Insert
(
@ID int output,
@Name nvarchar(100),
@Status int,
@Capacity int
)
as
begin
	-- kiểm tra có trùng khóa ngoại
	if( not exists ( select Name from dbo.TableFood where Name=@Name))
		insert into TableFood (Name, Status,Capacity) values (@Name,@Status,@Capacity)
		 set @ID=@@IDENTITY
end
go

--Update table
create proc str_Table_update
(
	@ID int,
	@Name nvarchar(100),
	@Status int,
	@Capacity int
	)
as
begin 
	update dbo.TableFood
	set[Name]=@Name,[Status]=@Status,[Capacity]=@Capacity
	where ID=@ID
end
go

-- delete Table
create proc str_Table_Delete
(
	@ID int,
	@Name nvarchar(100),
	@Status int,
	@Capacity int
	)
as
begin
	Delete dbo.TableFood
	where ID=@ID
end
go

--Bill 
--Bill Get all
create proc str_BillDetails_GetAll
as
begin
	select * from BillDetails
end 
go

--Bill Details GetByID
create proc str_BillDetails_GetByID
(
	@ID int
)
as
begin
	select * from dbo.BillDetails where ID=@ID
end
go

--BillDetails insert
create proc str_BIllDetails_Insert
(
@ID int,
@InvoiceID int,
@FoodID int,
@Quanlity int
)
as 
begin
	if not exists ( select ID from Bills where ID=@InvoiceID) and not exists(select ID from TableFood where ID=@FoodID)
	begin
	if(not exists(select ID from BillDetails where ID=@ID))
	 insert into BillDetails (InvoiceID,FoodID,Quanlity) values (@InvoiceID,@FoodID,@Quanlity)
	 end
end
go

--BillDetails Update
create proc str_BillDetails_Update
(
@ID int output,
@InvoiceID int,
@FoodID int,
@Quanlity int
)
as
begin
	update dbo.BillDetails
	set [InvoiceID]=@InvoiceID,[FoodID]=@FoodID,[Quanlity]=@Quanlity
	where ID=@ID
end
go

--BIllDetails Delete
create proc str_BillDetails_Delete
(
@ID int
)
as 
begin
	delete from dbo.BillDetails
	where ID=@ID
end
go

exec dbo.str_BIllDetails_Insert 1,1,5
exec dbo.str_BillDetails_GetAll

--Bill
-- Bill Getall
create proc str_Bill_GetAll
as
begin
	select * from dbo.Bills
end
go

--Bill GetByID
