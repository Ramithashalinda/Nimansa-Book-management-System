--ramitha

create database nimansaDB;
use nimansaDB;
select * from nimansaDB.INFORMATION_SCHEMA.TABLES;
create table Customer(customer_id varchar(100) primary key ,first_name varchar(200),last_name  varchar(250),address varchar(300),register_date date,
telephone int,email varchar(200));
select*from Customer;


create table Supplier(supplier_id varchar(10)  primary key,supplier_name varchar(50),address varchar(100),telephone int, email varchar(30),register_date date);
select*from Supplier;
drop table Supplier;

create table Book_Ragistor(book_id varchar(10)  primary key,book_name varchar(50),book_price float,quantity int,book_author_name varchar(70),date date,supplier_id varchar(10)foreign key references Supplier(supplier_id));
select*from Book_Ragistor;
drop table Book_Ragistor;

--insert into Book_Ragistor values('B001','Pembaradevi','250','100','Ganga Shani Gamage','2020-01-20','S001');
--insert into Book_Ragistor values('B002','Sadakiduri','200','100','Biyanka Nanayakkara','2020-01-20','S003');
--insert into Book_Ragistor values('B003','Sanasara sahakari','350','100','Biyanka Nanayakkara','2020-01-20','S003');
--insert into Book_Ragistor values('B004','Athbuutha pemwatha','300','100','Chandrasekara Gunawardhan','2020-01-20','S003');

create table User_Registor(user_id varchar(10)  primary key,first_name varchar(100),last_name varchar(100),address varchar(300),user_role varchar(25),password varchar(20),telephone int, email varchar(100),register_date date);
insert into User_Registor values('U001','Kasun','Perera','610/1,Maradhana rd,colombo 10','Manger','1234',0777541258,'ramithashalinda99@gmail.com','2018-05-03');
insert into User_Registor values('U002','Kamal','Perera','610/1,Maradhana rd,colombo 10','Assistant','123',0714441258,'imalkat96@gmail.com','2020-05-03');

select * from User_Registor ;






create table Purchase_Order(Purchase_ON varchar(10),date date,Address varchar(250),Qty int,book_id varchar(10)foreign key references Book_Ragistor(book_id),Book_name varchar(150),supplier_id varchar(10) foreign key references Supplier(supplier_id));
select * from Purchase_Order;
drop table Purchase_Order;





create table Invoice1(Invoice_No VARCHAR(10) , Date date,bill_type varchar(50),customer_id varchar(10),book_id varchar(10)  foreign key references Book_Ragistor(book_id),book_name varchar(50),price float,Amount float ,qty int,discount float);
select*from Invoice1;
drop table Invoice1;



 --invoice reports
 GetInvoiceReport '2020-07-02','2020-07-02'
 create procedure GetInvoiceReport
 (
	@FromDate datetime,
	@ToDate datetime
 )
 as
 ----------------invoice Reports--------------
	select Invoice_No, customer_id, book_id, book_name, qty, price, discount, Amount from Invoice1
	where Date between @FromDate and @ToDate
	order by date asc
	-------------purchase order Reports-------------------
	select Purchase_ON, date, Address, Qty, book_id, Book_name,
	supplier_id from Purchase_Order
	where Date between @FromDate and @ToDate


	select Invoice_No, customer_id, book_id, book_name, qty, price, discount, Amount from Invoice1
where Date between '2020-07-02' and '2020-07-04'




