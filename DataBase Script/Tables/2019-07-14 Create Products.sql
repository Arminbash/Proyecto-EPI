use PV_TEAMCELL
Go
Create schema PV
Go
Create table PV.Category(
IdCategory int identity primary key,
Name varchar(100),
Description varchar(500),
Estatus bit
)
Go
Create table PV.Country(
IdCountry int identity primary key,
Name varchar(100),
Estatus bit
)
GO
Create table PV.City(
IdCiy int identity primary key,
Name varchar(100),
IdCountry int foreign key references PV.Country(IdCountry),
Estatus bit
)
Go
Create Table PV.Provider(
IdProvider int identity primary key,
Name varchar(200),
IdCity int foreign key references PV.City(IdCiy),
Address varchar(200),
Estatus bit
)
GO
Create table PV.Product(
IdProduct int identity primary key,
Name varchar(200),
IdProvider int foreign key references  PV.Provider(IdProvider),
IdCategory int foreign key references PV.Category(IdCategory),
costing varchar(100),
Description varchar(500),
Estatus bit
)