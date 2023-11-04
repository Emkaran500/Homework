CREATE DATABASE StepIT
use StepIT

CREATE TABLE Academies
(
		[ID] int primary key identity,
		[Name] nvarchar(30) null
)

CREATE TABLE Departments
(
		[ID] int primary key identity,
		[AcademyID] int foreign key references Academies([ID]),
		[Name] nvarchar(30) null
)

CREATE TABLE Teachers
(
		[ID] int primary key identity,
		[Name] nvarchar(30) not null,
		[DepartmentID] int foreign key references Departments([ID]),
		[AcademyID] int foreign key references Academies([ID])
)

CREATE TABLE Students
(
		[ID] int primary key identity,
		[Name] nvarchar(30) not null,
		[AcademyID] int foreign key references Academies([ID])
)

INSERT INTO Academies([Name])
VALUES ('Step IT')

INSERT INTO Departments([Name], [AcademyID])
VALUES ('Programming', 1), ('Design', 1), ('Cybersecurity', 1)

INSERT INTO Teachers([Name], [AcademyID], [DepartmentID])
VALUES ('Elnur', 1, 1), ('Fuad', 1, 3), ('Ramiz', 1, 2)

INSERT INTO Students([Name], [AcademyID])
VALUES ('Emil', 1), ('Ayxan', 1), ('Nijat', 1), ('Jafar', 1), ('Maksim', 1)

SELECT
		s.[ID] as 'Student''s ID',
		s.[Name] as 'Student''s name',
		a.[Name] as 'Name of Academy'
FROM Students s
JOIN Academies a on s.[AcademyID] = a.[ID]

SELECT
		t.[Name] as 'Teacher''s name',
		d.[Name] as 'Name of Department',
		a.[ID] as 'ID of Academy'
FROM Teachers t
JOIN Departments d on t.[DepartmentID] = d.[ID]
JOIN Academies a on t.[AcademyID] = a.[ID]

SELECT
		d.[ID] as 'ID of Department',
		d.[Name] as 'Name of Department',
		a.[Name] as 'Name of Academy'
FROM Departments d
JOIN Academies a on d.AcademyID = a.ID