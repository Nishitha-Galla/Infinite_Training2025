--1.	Write a T-SQL Program to find the factorial of a given number.
create procedure fact @num int
as
begin
declare @fact int = 1
declare @count int = 1

while @count <= @num
begin
	set @fact = @fact * @count
	set @count = @count + 1
end

print 'Factorial of the number is ' + cast(@fact as varchar(20))
end

exec fact 6 

--2. Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 

create or alter proc multiplication (@num int, @range int)
as
begin
declare @i int = 1
	while @i <= @range

	begin
	print cast(@num as varchar(10)) + 'x' + cast(@i as varchar(10)) + '=' + cast(@num * @i as varchar(10))
	set @i = @i + 1
	end
end

exec multiplication 2,10

--3. Create a function to calculate the status of the student. If student score >=50 then pass, else fail. Display the data neatly

use Assignments

--student table
create table student
(Sid int primary key,
Sname varchar(20)
)

insert into student values
(1, 'Jack'),
(2, 'Rithvik'),
(3, 'Jaspreeth'),
(4, 'Praveen'),
(5, 'Bisa'),
(6, 'Suraj')

select * from student

--marks table
create table Marks
(Mid int primary key,
Sid int references student(Sid),
Score int
)

insert into Marks values
(1,1,23),
(2,6,95),
(3,4,98),
(4,2,17),
(5,3,53),
(6,5,13)

select * from Marks

--fucntion
create or alter function student_status (@score int)
returns varchar(10)
as
begin
declare @result varchar(10)
	if @score >= 50
	begin
		set @result = 'Pass'
	end
	else
	begin
		set @result = 'Fail'
	end
return @result
end

select s.sid, s.sname, m.mid, m.score, dbo.student_status(m.score) as 'Student_Status' from student s
inner join Marks m on s.sid = m.sid 
order by s.sid

