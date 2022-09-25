use School

create table Student
(
StudentId int primary key,
StudentName varchar(30),
Address varchar(100),
Email varchar(75),
)

select * from Student

create table Class
(
Classid int primary key,
ClassName varchar(5)
)

create table subject
(
SubjectId int primary key,
SubjectName varchar(50),
classId int foreign key references Class(classid)
)

select * from subject
Select * from Class
Select*  from Student


alter table Student
add Classid int foreign key references Class(classid)

insert into Class values(1,'XII A')
insert into Class values(2,'XII B')
insert into Class values(3,'XII E')
insert into Class values(4,'XII C')
insert into Class values(5,'XII D')


insert into Student values(1,'Salini S','Periyar street,Krishnagiri','salini@gmail.com',2)
insert into Student values(2,'Sameer Ahmed','Shanthi street,Trichy','sameer@gmail.com',2),
(3,'Thaswanth','3rd cross,Selam','thashwanth@gmail.com',1),
(4,'Rubini','Teachers colony,Hosur','rubini@gmail.com',1),
(5,'Shivaani','Ankur Palm springs','shiva@gmail.com',3),
(6,'Kalpana','Srivi street,Srivilliputtur','kalpu@gmail.com',3),
(7,'Lavanya','Periyar street,Vellore','lavi@gmail.com',4),
(8,'Gabi','Shanthi street,Selam','gabi@gmail.com',4),
(9,'Saravanan','Teachers colonoy,vellore','saran@gmail.com',5),
(10,'Pavithra','Periyar street,Vellore','pavi@gmail.com',5)


select * from Student

insert into subject values(1,'Physics',1),
(2,'Biology',1),(3,'Chemistry',2),
(4,'Maths',2),(5,'Economics',3),
(6,'Commerce',3),(7,'Engineering graphics',4),
(8,'Arabic',4),(9,'Social',5),(10,'Computer Science',5)
 
select * from Subject