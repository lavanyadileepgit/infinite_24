create database assignment4
use assignment4
--Write a T-SQL Program to find the factorial of a given number.

declare @n int = 5, @f int , @i int 
set @f = 1
set @i = 1

if @n < 0
    print 'factorial is not defined for negative numbers'
else if @n = 0
    print 'the factorial of 0 is 1'
else
begin
    while @i <= @n
    begin
        set @f = @i * @f
        set @i = @i + 1
    end

    print 'the factorial of ' + cast(@n as varchar(10)) + ' is ' + cast(@f as varchar(50))
end


--Create a stored procedure to generate multiplication tables up to a given number.
create or alter proc multiplicationtable(@num int)
as
begin
declare @n int =1
while @n<=@num
begin
declare @m int =1
while @m<=10
begin
declare @res int =@n*@m
print(cast(@n as varchar(5)) +cast('*'  as varchar(5))+cast(@m  as varchar(5))+cast('='  as varchar(5))+cast(@res  as varchar(5)))
set @m=@m+1
end
set @n=@n+1
end
end
exec multiplicationtable 5

--Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc

create table holiday (
    holiday_date date primary key,
    holiday_name varchar(20)
)
drop table holiday
insert into holiday values
('2024-08-15', 'independence day'),
('2024-11-04', 'diwali'),
('2024-01-31', 'mybirthday')


create table emp(empid int primary key,ename varchar(25))


create or alter trigger holidaymanipulation
on emp
for insert, update, delete
as
begin
    declare @holidayName varchar(20)
 
    select @holidayName = holiday_name 
    from holiday 
    where holiday_date = '2024-01-31'
 
    if @holidayName is not null
    begin
        print 'Data manipulation is not allowed........'
        rollback transaction; 
    end
end

select * from emp
select * from holiday

--insertion
insert into emp
values (2, 'lav')
--deletion
delete from emp
where empid = 1
--updation
update emp
set ename = 'dileep'
where empid = 2
and ename = 'lav'



