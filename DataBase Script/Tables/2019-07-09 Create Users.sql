create schema Users
Go
create table Users.Users(
IdUser int identity primary key,
UserName varchar(50),
Salt varbinary(max) not null,
Password varbinary(max) not null,
IdEmployee int foreign key references RRHH.Employee(IdEmployee),
Status bit
)