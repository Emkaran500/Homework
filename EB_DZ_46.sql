CREATE TABLE Students
(
		[studentName] nvarchar(30) null,
		[ID] int not null,
		[STEPCOINS] int not null,
		[isActive] bit not null
)

CREATE TABLE Teachers
(
		[teacherName] nvarchar(30) null,
		[ID] int not null,
		[numOfGroups] tinyint not null
)

CREATE TABLE Class
(
		[teacherName] nvarchar(30) null,
		[groupName] nvarchar(15) null,
		[numOfStudents] tinyint not null
)

INSERT INTO Students ([studentName], [ID], [STEPCOINS], [isActive])
VALUES ('Emil', 1, 100000, 1), ('Ayxan', 2, 1000, 1), ('Nijat', 3, 1241232, 0)

INSERT INTO Teachers ([ID], [numOfGroups])
VALUES (123, 5), (222, 3), (231, 3), (532, 0)

INSERT INTO Class ([teacherName], [numOfStudents])
VALUES ('Elnur', 10), ('Fuad', 9), ('Ali', 5)

SELECT *
FROM Students s
Where s.[STEPCOINS] > 5000

SELECT TOP 2
		[teacherName],
		[ID],
		[numOfGroups]
FROM Teachers t
WHERE t.[ID] = 222

SELECT TOP 2
		[teacherName],
		[numOfStudents]
FROM Class c
Where c.[teacherName] <> 'Fuad'