create database Assessments

use Assessments

--create books table
create table books
(id int primary key,
title varchar(20),
author varchar(20),
isbn bigint unique,
published_date dateTime)

--insert values to book table
insert into books values
(1,'My First SQL book', 'Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My Second SQL book', 'John Mayer',857300923713,'1972-07-03 9:22:45'),
(3,'My Third SQL book', 'Cary Flint',523120967812,'2015-10-18 14:05:44')

--books data
select * from books

--1. Write a query to fetch the details of the books written by author whose name ends with er
select * from books where author like '%er'

--create reviews table
create table reviews
(id int primary key,
book_id int references books(id),
reviewer_name varchar(20),
content varchar(20),
rating int,
published_data dateTime)

--insert into reviews table
insert into reviews values
(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11'),
(2,2,'John Smith','My second review',5,'2017-10-13 15:05:12'),
(3,2,'Alice Walker','Another review',1,'2017-10-22 23:47:10')

--reviews table data
select * from reviews

--2. Display the Title ,Author and ReviewerName for all the books from the above table
select b.title, b.author, r.reviewer_name from books b join reviews r on b.id = r.id

--3. Display the reviewer name who reviewed more than one book
select reviewer_name from reviews
group by reviewer_name
having count(*) > 1

--create customer table
create table customer 
(ID int primary key,
[NAME] varchar(20),
AGE int,
[ADDRESS] varchar(30),
SALARY float)

--insert into customer table
insert into customer values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00)

--customer table data
select * from customer

--4. Display the Name for the customer from above customer table who live in same address which has character o anywhere in address
select [NAME], [ADDRESS] from customer
where [ADDRESS] like '%o%'

--craete order table
create table orders
(OID int primary key,
[DATE] DateTime,
CUSTOMER_ID int references customer(ID),
AMOUNT int)

--insert into orders table
insert into orders values
(102, '2009-10-08 00:00:00', 3, 3000),
(100, '2009-10-08 00:00:00', 3, 1500),
(101, '2009-11-20 00:00:00', 2, 1560),
(103, '2008-05-20 00:00:00', 4, 2060)

--orders table data
select * from orders

--5. Write a query to display the Date,Total no of customer placed order on same Date
select [DATE], count(CUSTOMER_ID) 'Total no of customers' from orders
group by [DATE]

--create employee table
create table Employee
(ID int primary key,
[NAME] varchar(20),
AGE int,
[ADDRESS] varchar(30),
SALARY float)

--insert into employee table
insert into Employee values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null)

--employee table data
select * from Employee

--6. Display the Names of the Employee in lower case, whose salary is null
select lower([NAME]) from Employee 
where SALARY is null

--create Studentdetails table
create table Studentdetails 
(RegisterNo int primary key,
[Name] varchar(20),
Age int,
Qualification varchar(20),
MobileNo bigint,
Mail_id varchar(30),
[Location] varchar(20),
Gender varchar(10))

--insert into Studentdetails table
insert into Studentdetails values
(2,'Sai', 22, 'B.E', 9952836777,'Sai@gmail.com','Chennai', 'M'),
(3,'Kumar', 20, 'BSC', 7890125648,'Kumar@gmail.com','Madurai', 'M'),
(4,'Selvi', 22, 'B.Tech', 8904567342,'selvi@gmail.com','Selam', 'F'),
(5,'Nisha', 25, 'M.E', 7834672310,'Nisha@gmail.com','Theni', 'F'),
(6,'SaiSaran', 21, 'B.A',7890345678,'saran@gmail.com','Madurai', 'F'),
(7,'Tom', 23, 'BCA', 8901234675,'Tom@gmail.com','Pune', 'M')

--studentdetails table data
select * from Studentdetails

--7. Write a sql server query to display the Gender,Total no of male and female from the above relation
select Gender, count(*) [Total no of male and female] from Studentdetails
group by Gender


