create database PayrollServiceADO;
use PayrollServiceADO

create table EmployeeDetails(EmployeeID int identity(1,1) Primary Key,
FirstName varchar(50),
LastName varchar(50),
Gender varchar(50),
StartDate datetime,
Company varchar(50),
Departent varchar(50),
Address varchar(50),
BasicPay int,
Deductions int,
TaxablePay int,
IncomeTax int,
NetPay int);

select * from EmployeeDetails;

insert into EmployeeDetails values ('Amisha','Jain','Female','2022-10-04','BridgeLabs','Production','Aurangabad',20000,1000,180,600,25000)
insert into EmployeeDetails values ('Aarvik','Kalburgi','Male','2022-01-04','BridgeLabs','Developer','Pune',25000,1200,210,7500,30000)

