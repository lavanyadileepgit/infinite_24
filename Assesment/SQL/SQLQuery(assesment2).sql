create database assesment2
----------------------------------------------------------------------------------------------------------------------------
--1.Write a query to display your birthday( day of week)
select Datename(dw,'2001-01-31')as day

--output

--day
--Wednesday
----------------------------------------------------------------------------------------------------------------------------
--2.Write a query to display your age in days
Declare @BDate Datetime = '2001-01-31',@CDate datetime = Getdate()
Select @CDate as currentdate,@BDate as birthdate,Datediff(d, @BDate, @CDate) as ageindays

--output

--currentdate	            birthdate	               ageindays
--2024-03-28 10:07:08.200	2001-01-31 00:00:00.000	   8457
----------------------------------------------------------------------------------------------------------------------------
--3.Write a query to display all employees information those who joined before 5 years in the current month

select * from Emp
where Datediff(year, hiredate, Getdate()) <= 5
  and Month(hiredate) = Month(Getdate())
drop table emp
create table emp(empno int primary key,
ename varchar(30),
job varchar(30),
mgr_id int ,
hiredate date ,
sal int,
comm int,
deptno int)

insert into emp values
(7369, 'SMITH', 'CLERK', 7902, '2009-03-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '2018-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '2019-03-28', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '2020-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '2024-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '2016-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '2018-10-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '2020-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '2021-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '2023-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '2018-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '2019-10-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '2019-03-28', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '2019-03-23', 1300, NULL, 10);


--output

--empno  	ename	  job	   mgr_id	hiredate	sal	    comm	deptno
--7521    	WARD	SALESMAN	7698	2019-03-28	1250	500	    30
--7902	   FORD	    ANALYST	    7566	2019-03-28	3000	NULL	20
--7934	   MILLER	CLERK	    7782	2019-03-23	1300	NULL	10
----------------------------------------------------------------------------------------------------------------------------
--4.Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
--a. First insert 3 rows 
--b. Update the second row sal with 15% increment  
--c. Delete first row.
--After completing above all actions how to recall the deleted row without losing increment of second row.
begin transaction

create table employee
(
empno int primary key,
ename varchar(20),
sal float,
doj datetime
)

insert into employee values
(1, 'lavanya', 15000, '2024-02-15'),
(2, 'sejal', 15300, '2021-02-01'),
(3, 'rishi', 12500, '2020-05-21')

select * from employee;

update employee
set sal = sal * 1.15
where empno = 2

declare @table table (empno int, ename varchar(20), sal float, doj datetime)
insert into @table
select empno, ename, sal, doj
from employee
where empno = 1

delete from employee
where empno = 1

select ename as deletedemp, sal, doj
from @table

select ename, sal, doj
from employee

commit transaction

--output

--empno	ename	sal	     doj
--1	    lavanya	15000	2024-02-15 00:00:00.000
--2	    sejal	15300	2021-02-01 00:00:00.000
--3	    rishi	12500	2020-05-21 00:00:00.000

--deletedemp	sal	  doj
--lavanya	  15000	  2024-02-15 00:00:00.000

--ename	    sal   	doj
--sejal 	17595	2021-02-01 00:00:00.000
--rishi  	12500	2020-05-21 00:00:00.000

----------------------------------------------------------------------------------------------------------------------------
--5. Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
--a.     For Deptno 10 employees 15% of sal as bonus.
--b.     For Deptno 20 employees  20% of sal as bonus
--c      For Others employees 5%of sal as bonus

create function CalculateBonus(@Salary float, @DeptNo int)
returns float
as
begin
  declare @Bonus float

  if (@DeptNo = 10)
    set @Bonus = @Salary * 0.15
  else if (@DeptNo = 20)
    set @Bonus = @Salary * 0.20
  else
    set @Bonus = @Salary * 0.05

  return @Bonus
end

select empno, ename, sal, hiredate, dbo.CalculateBonus(sal, deptno) as Bonus
from Emp
where deptno = 10


--output
--empno	ename	sal	    hiredate	    Bonus
--7782	CLARK	2450	2018-10-09	    367.5
--7839	KING	5000	2021-11-17	    750
--7934	MILLER	1300	2019-03-23	    195

----------------------------------------------------------------------------------------------------------------------------






