create schema Users
Go
create table Users.Users(
IdUser int identity primary key,
UserName varchar(50),
Password varchar(200),
IdEmployee int foreign key references RRHH.Employee(IdEmployee),
Status bit
)