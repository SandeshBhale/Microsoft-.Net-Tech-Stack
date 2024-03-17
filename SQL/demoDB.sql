create table Emp(EmpId bigint constraint PK_Emp Primary Key,EmpName varchar(30),Mob varchar(10),DeptId bigint Constraint FK_Dept Foreign Key References Dept(DeptId),AreaId bigint constraint EK_Area foreign key references Area(AreaId))
create table Area(AreaId bigint constraint PK_Area Primary Key,AreaName varchar(30))
create table Dept(DeptId bigint constraint PK_Dept Primary Key,DeptName varchar(30))

insert into Dept values (1,'Computer'),(2,'Sales'),(3,'Purchase')
insert into Area values (1,'Parbhani'),(2,'Pune'),(3,'PCMC')
insert into Emp values (1,'Rushikesh','1234567890',1,1),(2,'Shivam','1234567890',1,2),
(3,'Sandesh','1234567890',1,3),(4,'Ritesh','1234567890',2,3),(5,'Omka3','1234567890',1,2)
