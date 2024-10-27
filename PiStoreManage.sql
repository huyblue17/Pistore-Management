use master

go

create database PiStore
--drop database PiStore

go

use PiStore

go

create table Employee (
EID varchar(100),
Ename nvarchar(100),
Email varchar(100),
Ephone integer,
Eaddress nvarchar(100),
Salary money,
HireDate date,
constraint PK_EID primary key (EID)
)

create table Client (
CID varchar(100),
Cname nvarchar(100),
Cmail varchar(100),
Cphone integer,
Caddress nvarchar(100),
constraint PK_CID primary key (CID)
)

create table Product (
PID varchar(100),
Pname nvarchar(100),
Description varchar(100),
Price money,
PQuantity integer,
constraint PK_PID primary key (PID)
)

create table Porder (
OID varchar(100),
CID varchar(100),
EID varchar(100),
OrderDate date,
TotalPrice money,
constraint PK_OID_O primary key (OID),
constraint FK_CID_O foreign key (CID) references Client (CID),
constraint FK_EID_O foreign key (EID) references Employee (EID)
)

create table OrderItem (
IID varchar(100),
OID varchar(100),
PID varchar(100),
Quantity integer,
constraint PK_IID primary key (IID),
constraint FK_OID_OI foreign key (OID) references Porder (OID),
constraint FK_PID_OI foreign key (PID) references Product (PID),
)

create table Bill (
BID varchar(100),
OID varchar(100),
CID varchar(100),
EID varchar(100),
BillDate date,
BTotalPrice money,
constraint PK_BID primary key (BID),
constraint FK_OID_B foreign key (OID) references Porder (OID),
constraint FK_CID_B foreign key (CID) references Client (CID),
constraint FK_EID_B foreign key (EID) references Employee (EID),
)


create table Account (
IDA varchar(100),
Uname varchar(100),
Pword varchar(100),
lock bit not null,
constraint PK_ID_A primary key (IDA)
)

set dateformat DMY

insert into Employee
values
('E001', 'Anh A', 'anha@gmail.com', 0901234567, 'District 1', 200000, '10/10/2020'),
('E002', 'Anh B', 'anhb@gmail.com', 0901275947, 'District 2', 200000, '10/12/2020')
select * from Employee


insert into Client
values
('C001', 'Minh Nguyen', 'minh@gmail.com', 0901234567, 'District 1'),
('C002', 'Thanh Tran', 'thanh@gmail.com', 0901275947, 'District 2')
select * from Client

insert into Product
values
('P001', 'IPhone 13', 'Latest iPhone', 1000000, 20),
('P002', 'Samsung S22', 'Latest Samsung phone', 900000, 15)
select * from Product


insert into Porder
values
('O001', 'C001', 'E001', '10/10/2022', 1000000),
('O002', 'C002', 'E002', '10/12/2022', 900000)
select * from Porder

insert into OrderItem
values
('I001', 'O001', 'P001', 1),
('I002', 'O002', 'P002', 1)
select * from OrderItem

insert into Bill
values
('B001', 'O001', 'C001', 'E001', '10/10/2022', 1000000),
('B002', 'O002', 'C002', 'E002', '10/12/2022', 900000)
select * from Bill

insert into Account
values 
('A001', 'admin', 'admin', 0)
select * from Account

SELECT 
    Bill.BID, 
    Bill.BillDate, 
    Bill.BTotalPrice, 
    Client.Cname AS CustomerName, 
    Employee.Ename AS EmployeeName
FROM 
    Bill
INNER JOIN 
    Client ON Bill.CID = Client.CID
INNER JOIN 
    Employee ON Bill.EID = Employee.EID;


select * from Bill where BillDate = GETDATE()