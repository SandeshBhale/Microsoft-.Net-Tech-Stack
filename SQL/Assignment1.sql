create table Emptb1(EmpId bigint,EmpName varchar(50),Address varchar(50),EmailId varchar(50),MobileNo varchar(10),DeptName varchar(20),Salary varchar(20))

insert into Emptb1 values (1,'Rushikesh','Parbhani','rushi@gmail.com','1234567890','Computer','20000')
insert into Emptb1 values (2,'Mahesh','Parbhani','mahesh@gmail.com','1234567890','Computer','30000')
insert into Emptb1 values (3,'Kavish','Pune','kavish@gmail.com','1234567890','Manager','50000')
insert into Emptb1 values (4,'Vedant','Pune','vedant@gmail.com','1234567890','Sales','20000')
insert into Emptb1 values (5,'Kishan','PCMC','kishan@gmail.com','1234567890','Sales','10000')
insert into Emptb1 values (6,'Rudra','PCMC','rudra@gmail.com','1234567890','Manager','50000')
insert into Emptb1 values (7,'Sandesh','Wagholi','sandesh@gmail.com','1234567890','Purchase','20000')
insert into Emptb1 values (8,'Keshav','Wagholi','keshav@gmail.com','1234567890','Purchase','30000')
insert into Emptb1 values (9,'Kedar','Kharadi','kedar@gmail.com','1234567890','Purchase','10000')
insert into Emptb1 values (10,'Mangesh','Kharadi','mangesh@gmail.com','1234567890','Manager','40000')

select * from Emptb1 where DeptName='Computer'

select * from Emptb1 where DeptName='Computer' and Salary>30000

select * from Emptb1 where DeptName in('Computer','Sales','Purchase')

select * from Emptb1 where DeptName='Computer' and EmpName like '%h'

select * from Emptb1 where DeptName!='Computer'