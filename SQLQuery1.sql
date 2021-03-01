--create table Student_table(student_Id int not null primary key,
--student_Name nvarchar(100),Gender nvarchar(100),Course nvarchar(120));
insert into Student_table values(1,N'山田','M','C101'),
(2,N'西尾','W','C256'),
(3,N'菅根','W','C154'),
(4,N'神戸','W','C106'),
(5,N'長田','M','C259'),
(6,N'大阪','G','C147');
select * from Student_table;


