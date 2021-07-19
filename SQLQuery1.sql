use classsql

create table StudentDetails
(
Studentname varchar(50),
rollno int primary key,
gender varchar(50),
age int,
course varchar(50),
address varchar(100)
)

create table CourseDetails
(
courseid int primary key,
course varchar(50),
duration int,
noofstd int,
cost int
)

create table BatchDetails
(
batchno int primary key,
course varchar(50),
timing varchar(20),
noofstd int,
vacant int
)

create table EnrollDetails
(
city varchar(50),
pin int primary key,
noofcenters int,
totalenroll int
)

select * from StudentDetails
select * from BatchDetails

select course,sum(noofstd) from BatchDetails group by course
select batchno,sum(noofstd) from BatchDetails group by batchno

select course,sum(noofstd) from CourseDetails group by course
select course,sum(cost) from CourseDetails group by course

select city,sum(totalenroll) from EnrollDetails group by city

create procedure studentsonbatch 
as
begin
select course,sum(noofstd) from BatchDetails group by course
end

exec studentsonbatch

create procedure studentsonbatch1
as
begin
select course,sum(noofstd) from BatchDetails group by course
select batchno,sum(noofstd) from BatchDetails group by batchno
end

exec studentsonbatch1