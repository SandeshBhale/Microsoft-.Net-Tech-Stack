Create table ProductCatagory (ProductCatagoryId bigint constraint PK_ProductCatagory Primary key,CatagoryName varchar(20))

Create table Color ( ColorId bigint constraint PK_Color Primary Key,ColorName varchar(20))

Create table MfgName ( MfgId bigint constraint PK_MfgName Primary Key,MfgName varchar(30),Address varchar(30),EmailId varchar(30),MobileNo varchar(10))

Create table Product (ProductId bigint constraint PK_Product Primary Key,ProductName varchar(30),ProductDesc varchar(50),
ProductCatagoryId bigint,MfgId bigint,ColorId bigint,Price int)

insert into ProductCatagory values (1,'Computer'),(2,'Coloths')
insert into MfgName values (1,'Intex','Abc','Abc@gmail.com','123456789')
,(2,'Polo','Abc','Abc@gmail.com','123456789'),
(3,'Logitech','Abc','Abc@gmail.com','123456789'),
(4,'Zeel','Abc','Abc@gmail.com','123456789')

select * from MfgName

insert into Color values (1,'Black'),(2,'Red'),(3,'Blue')

Insert into Product values ('Mouese','ThreeKey',1,1,1,450),
('T-Shirt','Cotton',2,2,2,1100),
('Keyboard','Multimedia',1,3,1,650),
('RainCoat','Grade III',2,4,3,1500)

