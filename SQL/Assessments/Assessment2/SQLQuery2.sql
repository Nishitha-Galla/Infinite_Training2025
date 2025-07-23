use assignments

--1. Write a query to display your birthday(day of week)
select datename(weekday, '2002-11-22') as 'My Birthday'

--2. Write a query to display your age in days
select datediff(day, '2002-11-22', getdate()) as 'Age in Days'

--3.	Write a query to display all employees information those who joined before 5 years in the current month
--(Hint : If required update some HireDates in your EMP table of the assignment)

select * from emp

select * from emp where hiredate <= dateadd(year, -5, getdate()) and month(hiredate) = month(getdate())

update emp set hiredate = '1981-07-28' where empno = 7654
update emp set hiredate = '1981-07-23' where empno = 7934

--4. Create table Employee with empno, ename, sal, doj columns or use your emp table and perform the following operations in a single transaction
--a. First insert 3 rows 
--b. Update the second row sal with 15% increment  
--c. Delete first row.
--After completing above all actions, recall the deleted row without losing increment of second row.

begin tran

create table newemp
(
empno int primary key,
ename varchar(30),
salary bigint,
doj date
)

--a. First insert 3 rows
insert into newemp values
(22, 'Nishitha', 36000, '2025-06-05'),
(26, 'Madhu', 44000, '2025-04-10'),
(48, 'Sudha', 50000, '2025-08-10')

select * from newemp

--b. Update the second row sal with 15% increment 
update newemp set salary = salary + salary * 0.15 where empno = 26

save tran t
delete from newemp where empno = 22
rollback tran t

--5. Create a user defined function calculate Bonus for all employees of a  given dept using 	following conditions
--a. For Deptno 10 employees 15% of sal as bonus.
--b. For Deptno 20 employees  20% of sal as bonus
--c. For Others employees 5%of sal as bonus

create function fn_CalculateBonus
(
@deptno int,
@sal decimal(10, 2)
)
returns decimal(10,2)
as
begin
	declare @bonus float

	if @deptno = 10
		set @bonus = @sal * 0.15
	else if @deptno = 20
		set @bonus = @sal * 0.20
	else
		set @bonus = @sal * 0.5

		return @bonus
end

select empno, ename, dbo.fn_CalculateBonus(deptno, sal) as bonus from emp

--6. Create a procedure to update the salary of employee by 500 
--whose dept name is Sales and current salary is below 1500 (use emp table)

create or alter proc salary_update
as
begin
	update emp set sal = sal + 500
	where deptno = (select deptno from dept where dname = 'Sales')
	and sal < 1500
end

exec salary_update
select * from emp


