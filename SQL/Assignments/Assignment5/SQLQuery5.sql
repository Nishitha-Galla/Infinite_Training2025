use Assignments

--1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

--   a) HRA as 10% of Salary
--   b) DA as 20% of Salary
--   c) PF as 8% of Salary
--   d) IT as 5% of Salary
--   e) Deductions as sum of PF and IT
--   f) Gross Salary as sum of Salary, HRA, DA
--   g) Net Salary as Gross Salary - Deductions

--Print the payslip neatly with all details

create or alter proc PaySlip(@empno int)
as
begin
	declare @ename varchar(20), @sal int
	declare @HRA float
	declare @DA float
	declare @PF float
	declare @IT float
	declare @Deductions float
	declare @Gross_Salary float
	declare @Net_Salary float

select @ename = ename, @sal = sal from emp where empno = @empno

	set @HRA = @sal * 0.10
	set @DA = @sal * 0.20
	set @PF = @sal * 0.08
	set @IT = @sal * 0.05
	set @Deductions = @PF + @IT
	set @Gross_Salary = @sal + @HRA + @DA
	set @Net_Salary = @Gross_Salary - @Deductions

	print 'Payslip of  : ' + @ename
	print 'Salary : ' + cast(@sal as varchar(20))
	print 'HRA : ' + cast(@HRA as varchar(20))
	print 'DA : ' + cast(@DA as varchar(20))
	print 'PF : ' +cast(@PF as varchar(20))
	print 'IT : ' + cast(@IT as varchar(20))
	print 'Deductions : ' + cast(@Deductions as varchar(20))
	print 'Gross Salary : ' + cast(@Gross_Salary as varchar(20))
	print 'Net Salary : ' +cast(@Net_Salary as varchar(20))

end

exec PaySlip 7934

--2.  Create a trigger to restrict data manipulation on EMP table during General holidays. 
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manipulate" etc

create table holiday
(
holiday_date date,
holiday_name varchar(20),
)

insert into holiday values
('2025-07-09', 'Rakshabandhan'),
('2025-08-15', 'Independence day'),
('2025-08-16', 'Janmashtami'),
('2025-08-27', 'Ganesh Chathurthi')

select * from holiday

create or alter trigger restrictManipulation
on emp
after insert, delete, update
as
begin
	declare @holiday_name varchar(20)
	select @holiday_name = holiday_name from holiday where holiday_date = cast(getdate() as date)

	if @holiday_name is not null
	begin
		raiserror('Due to %s you cannot manipulate data',16,1, @holiday_name)
		rollback tran
	end 
end

insert into holiday values('2025-07-23', 'Holiday')

delete from emp where empno = 7654

select * from emp

