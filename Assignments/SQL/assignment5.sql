create database assignment5
use assignment5
--drop table employee
create table employee(empid int primary key , ename varchar(20),salary float)
insert into employee values(1,'Sejal',25000),(2,'Tom',10000),(3,'manu',15000)
drop table employee
select * from employee

create or alter procedure emppayslip @eid int
as
begin
	declare @sal float = (select salary from employee where empid = @eid)
    declare @hra float=@sal * 0.1;
    declare @da float=@sal * 0.2;
    declare @pf float=@sal * 0.08;
    declare @it float=@sal * 0.05;
    declare @deductions float = @hra + @da + @pf + @it;
    declare @grosssal float= @sal+@hra+@da;
    declare @netsal float= @sal - @deductions;
	select @eid as empid,ename ,@sal as  salary , @hra as HRA,@da as DA,@pf as PF,@it as IT,@deductions as DEDUCTIONS, 
	@grosssal as GROSSSAL , @netsal as NETSALARY from employee where empid =@eid
end

emppayslip 3
select * from region
delete from region where regionid =8
select * from shippers
update region set RegionDescription ='Eastern' where regionid=49






