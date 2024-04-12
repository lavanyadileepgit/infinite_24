create database employeemanagement
use employeemanagement

CREATE TABLE Employee_Details
(
    Empno int primary key,
    EmpName varchar(20) NOT NULL,
    Empsal float CHECK (Empsal >= 25000),
    Emptype char(1) CHECK (Emptype IN ('P', 'C'))
)

select* from employee_details
delete from Employee_Details where empno=103

CREATE OR ALTER PROCEDURE addemployee
(
    @name VARCHAR(20),
    @empsal float,
    @emptype CHAR(1)
)
AS
BEGIN
    DECLARE @empno INT;
    SELECT @empno = ISNULL(MAX(Empno), 99) + 1 FROM Employee_Details;
    INSERT INTO Employee_Details (Empno, EmpName, Empsal, Emptype)
    VALUES (@empno, @name, @empsal, @emptype);
END

exec addemployee 'Lavanya', 50000.00 , 'P'

----------------------------------------------------------------------------------------
--100	Lavanya Dileep	50000	P
--101	Ramya Shree	    30000	C
--102	Hema	        40000	P