create table Roles
(
RoleId INT PRIMARY KEY IDENTITY(1,1),
RoleName NVARCHAR(20)
)

GO

create table Users
(
Id INT PRIMARY KEY IDENTITY(1,1),
FirstName NVARCHAR(20),
LastName NVARCHAR(20),
Email NVARCHAR(50),
[Password] NVARCHAR(50),
RoleId INT FOREIGN KEY REFERENCES Roles(RoleId)
)

GO

INSERT INTO Roles VALUES ('Admin'),('IT User'),('Finance User')

INSERT INTO Roles VALUES ('Super Admin'),('XYZ User')