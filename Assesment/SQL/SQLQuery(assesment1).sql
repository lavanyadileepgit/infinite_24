create database assesment1
use assesment1
--Create a book table with id as primary key and provide the appropriate data type to other attributes
--.isbn no should be unique for each book 

create table books
(id int primary key,
title varchar(20),
author varchar(20),
isbn varchar(20) unique,
published_date datetime)
drop table books
drop table reviews
create table reviews
(id int primary key,
book_id int references book(id),
reviewer_name varchar(20),
content varchar(20),
rating int,
published_date datetime)
create table reviews (
id int primary key,
book_id int references books(id),
reviewer_name varchar(20),
content varchar(20),
rating int,
published_date datetime)


insert into books values (1,'my first sql book','mary parker','981483029127','2012-02-22 12:08:17')
insert into books values (2,'my second sql book','john mayer','857300923713','1972-07-03 09:22:45')
insert into books values (3,'my third sql book','cary flint','523120967812','2015-10-18 14:05:44')
select * from books

insert into reviews values(1,1,'john smith','my first review',4,'2017-12-10 05:50:11:1')
insert into reviews values(2,2,'john smith','my second review',5,'2017-10-13 15:05:12')
insert into reviews values(3,2,'alice walker',' another review',1,'2017-10-22 23:47:10')
select * from reviews


--Write a query to fetch the details of the books written by author whose name ends with er.
select * from books where author like '%er'


--Display the Title ,Author and ReviewerName for all the books from the above table
select distinct b.title,b.author,r.reviewer_name from books b join reviews r
on b.id=r.book_id

--Display the reviewer name who reviewed more than one book.
select reviewer_name from reviews group by reviewer_name having count(*)>1

create table customer(id int primary key,
name varchar(20),
age int,
address varchar(20),
salary float)

insert into customer values(1,'Ramesh',32,'Ahmedabad',2000.00)
insert into customer values(2,'Khilan',25,'Delhi',1500.00)
insert into customer values(3,'Kaushik',23,'Kota',2000.00)
insert into customer values(4,'chaitali',25,'mumbai',6500.00)
insert into customer values(5,'Hardik',27,'Bhopal',8500.00)
insert into customer values(6,'Komal',22,'MP',4500.00)
insert into customer values(7,'Muffy',24,'Indore',10000.00)
select * from customer

--Display the Name for the customer from above customer table who live in same address which has character o anywhere in address
select * from customer
where address like '%o%' 

create table orders (oid int primary key,
date datetime,
customer_id int references customer(id),
amount int)

insert into orders values(102,'2009-10-08 00:00:00',3,3000)
insert into orders values(100,'2009-10-08 00:00:00',3,1500)
insert into orders values(101,'2009-11-20 00:00:00',2,1560)
insert into orders values(103,'2008-05-20 00:00:00',4,2060)
select * from orders

--Write a query to display the Date,Total no of customer placed order on same Date

select date ,count(customer_id)as totcust
from orders  
group by date

create table employee (id int primary key,
name varchar(20),
age int,
address varchar(20),
salary float null)

insert into employee values(1,'Ramesh',32,'Ahmedabad',2000.00)
insert into employee values(2,'Khilan',25,'Delhi',1500.00)
insert into employee values(3,'Kaushik',23,'Kota',2000.00)
insert into employee values(4,'chaitali',25,'mumbai',6500.00)
insert into employee values(5,'Hardik',27,'Bhopal',8500.00)
insert into employee (id,name,age,address)values(6,'Komal',22,'MP')
insert into employee (id,name,age,address) values(7,'Muffy',24,'Indore')


select * from employee

--Display the Names of the Employee in lower case, whose salary is null
select lower(name) as [employee name] , salary from employee where salary is null

create table studentdetails(register_no int primary key,
name varchar(20),
age int,
qualification varchar(10),
mobileno varchar(10),
mailid varchar(20),
locationn varchar(10),
gender char(1))

insert into studentdetails values(2,'sai',22,'B.E','9952836777','sai@gmail.com','chennai','M')
insert into studentdetails values(3,'Kumar',20,'B.Sc','7890125648','kumar@gmail.com','madurai','M')
insert into studentdetails values(4,'selvi',22,'B.Tech','8904567342','selvi@gmail.com','selam','f')
insert into studentdetails values(5,'Nisha',25,'M.E','7834672310','nisha@gmail.com','Theni','f')
insert into studentdetails values(6,'saisaran',21,'B.A','7890345678','saran@gmail.com','madurai','M')
insert into studentdetails values(7,'Tom',23,'BCA','8901234675','Tom@gmail.com','Pune','M')

select * from studentdetails

--Write a sql server query to display the Gender,Total no of male and female from the above relation

select gender, count(*) AS TotalCount
from studentdetails
group by gender






