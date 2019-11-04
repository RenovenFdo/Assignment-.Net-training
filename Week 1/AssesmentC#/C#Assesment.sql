create database AssesmentC#


create table tbl_product
(
	id int primary key identity,
	product_name varchar(30)
)
insert into tbl_product values ('Apple') 
insert into tbl_product values ('Mango') 
insert into tbl_product values ('Orange') 
insert into tbl_product values ('Banana') 
insert into tbl_product values ('Grape') 

create table tbl_supplier
(
	supplier_id int primary key identity,
	supplier_name varchar(30),
	product_id int foreign key references tbl_product(id),
	location varchar(30),
	price int 
)
drop table tbl_supplier
insert into tbl_supplier values ('John',1,'Bangalore',30)
insert into tbl_supplier values ('Abraham',1,'Chennai',20)
insert into tbl_supplier values ('Brad',2,'Bangalore',40)
insert into tbl_supplier values ('Emily',3,'Mumbai',10)
insert into tbl_supplier values ('James',3,'Delhi',50)
insert into tbl_supplier values ('Brad',4,'Bangalore',60)
insert into tbl_supplier values ('Charles',2,'Pune',20)
insert into tbl_supplier values ('Lebron',1,'Chennai',40)
insert into tbl_supplier values ('Emily',4,'Mumbai',30)
insert into tbl_supplier values ('Abraham',2,'Chennai',20)
insert into tbl_supplier values ('Kishore',3,'Mysore',50)
insert into tbl_supplier values ('Sam',1,'Trichy',60)
insert into tbl_supplier values ('Dan',5,'Cochin',20)
insert into tbl_supplier values ('Charles',5,'Pune',30)
insert into tbl_supplier values ('James',5,'Delhi',40)

create table tbl_customer
(
	customer_id int primary key identity ,
	customer_name varchar(30),
	product_id int foreign key references tbl_product(id),
	supplier_id int foreign key references tbl_supplier(supplier_id),
	quantity int,
	total bigint 
)
drop table tbl_customer
select *from tbl_product
select *from tbl_supplier
select *from tbl_customer


create procedure sp_Buy( @name varchar(30), @product_id int, @quantity int, @supplier_id int, @price int)
as
begin
declare @total int
select @price = price from tbl_supplier where tbl_supplier.supplier_id = @supplier_id
set @total = @price * @quantity
insert into tbl_customer values (@name, @product_id, @supplier_id,@quantity, @total)
end

drop procedure sp_Buy

create procedure sp_Bill(@id int)
as 
begin
select sum(total) from tbl_customer 
where tbl_customer.customer_id = @id
end

create procedure sp_GetBill(@id int)
as 
begin
select product_name, quantity, total from tbl_customer c inner join tbl_product p 
on c.product_id = p.id
where c.customer_id = @id
end

create procedure sp_GetSupplier(@supplier_id int, @product_id int)
as
begin
select product_id from tbl_supplier s 
where s.supplier_id = @supplier_id and s.product_id = @product_id
end

create procedure sp_GetCustomer(@id int)
as
begin
select count(customer_id) from tbl_customer  where customer_id= @id
end
drop procedure sp_GetCustomer
