create database PV_TEAMCELL
GO
use PV_TEAMCELL
GO
create table Employee(
  IdEmployee int identity(1,1) primary key,
  FirstName varchar(50),
  SecondName varchar(50),
  FirstSurname varchar(50),
  SecondSurname varchar(50),
  BirthDay date,
  IdentificationCard varchar(100),
  State varchar(50),
  Status bit
)