CREATE DATABASE University

use University

CREATE TABLE Subjects
(
		[ID] int identity not null,
		[Name] nvarchar(100) not null --(ne pustoy)

		constraint [PK_Subjects_ID_1] primary key([ID]),
		constraint [CK_Subjects_Name_1] check(len([Name]) > 0),
		constraint [UQ_Subjects_Name_2] unique([Name])
)

CREATE TABLE Teachers
(
		[ID] int identity not null,
		[Name] nvarchar(max) not null

		constraint [PK_Teachers_ID_1] primary key([ID]),
		constraint [CK_Teachers_Name_1] check(len([Name]) > 0)
)

CREATE TABLE Heads
(
		[ID] int identity not null,
		[TeacherID] int not null

		constraint [PK_Heads_ID_1] primary key([ID]),
		constraint [FK_Heads_TeacherID] foreign key([TeacherID]) references Teachers([ID])
)

CREATE TABLE Assistants
(
		[ID] int identity not null,
		[TeacherID] int not null

		constraint [PK_Assistants_ID_1] primary key([ID]),
		constraint [FK_Assistants_TeacherID_1] foreign key([TeacherID]) references Teachers([ID])
)

CREATE TABLE Curators
(
		[ID] int identity not null,
		[TeacherID] int not null

		constraint [PK_Curators_ID_1] primary key([ID]),
		constraint [FK_Curators_TeacherID_1] foreign key([TeacherID]) references Teachers([ID])
)

CREATE TABLE Deans
(
		[ID] int identity not null,
		[TeacherID] int not null

		constraint [PK_Deans_ID_1] primary key([ID]),
		constraint [FK_Deans_TeacherID_1] foreign key([TeacherID]) references Teachers([ID])
)

CREATE TABLE Faculties
(
		[ID] int identity not null,
		[Building] int not null,
		[Name] nvarchar(100) not null,
		[DeanID] int not null

		constraint [PK_Faculties_ID_1] primary key([ID]),
		constraint [CK_Faculties_Building_1] check([Building] >= 1 and [Building] <= 5),
		constraint [CK_Faculties_Name_1] check(len([Name]) > 0),
		constraint [UQ_Faculties_Name_2] unique([Name]),
		constraint [FK_Faculties_DeanID_1] foreign key([DeanID]) references Deans([ID])
)

CREATE TABLE Lectures
(
		[ID] int identity not null,
		[SubjectID] int not null,
		[TeacherID] int not null

		constraint [PK_Lectures_ID_1] primary key([ID]),
		constraint [FK_Lectures_SubjectID_1] foreign key([SubjectID]) references Subjects([ID]),
		constraint [FK_Lectures_TeacherID_1] foreign key([TeacherID]) references Teachers([ID])
)

CREATE TABLE Departments
(
		[ID] int identity not null,
		[Building] int not null,
		[Name] nvarchar(100) not null,
		[FacultyID] int not null,
		[HeadID] int not null

		constraint [PK_Departments_ID_1] primary key([ID]),
		constraint [CK_Departments_Building_1] check([Building] >= 1 and [Building] <= 5),
		constraint [CK_Departments_Name_1] check(len([Name]) > 0),
		constraint [CK_Departments_Name_2] unique([Name]),
		constraint [FK_Departments_FacultyID_1] foreign key([FacultyID]) references Faculties([ID]),
		constraint [FK_Departments_HeadID_1] foreign key([HeadID]) references Heads([ID])
)

CREATE TABLE Groups
(
		[ID] int identity not null,
		[Name] nvarchar(10) not null,
		[Year] int not null,
		[DepartmentID] int not null

		constraint [PK_Groups_ID_1] primary key([ID]),
		constraint [CK_Groups_Name_1] check(len([Name]) > 0),
		constraint [CK_Groups_Name_2] unique([Name]),
		constraint [CK_Groups_Year_1] check([Year] >= 1 and [Year] <= 5),
		constraint [FK_Groups_DepartmentID_1] foreign key([DepartmentID]) references Departments([ID]),
)

CREATE TABLE GroupsCurators
(
		[ID] int identity not null,
		[CuratorID] int not null,
		[GroupID] int not null

		constraint [PK_GroupsCurators_ID_1] primary key([ID]),
		constraint [FK_GroupsCurators_CuratorID_1] foreign key([CuratorID]) references Curators([ID]),
		constraint [FK_GroupsCurators_GroupID_1] foreign key([GroupID]) references Groups([ID])
)

CREATE TABLE GroupsLectures
(
		[ID] int identity not null,
		[GroupID] int not null,
		[LectureID] int not null

		constraint [PK_GroupsLectures_ID_1] primary key([ID]),
		constraint [FK_GroupsLectures_GroupID_1] foreign key([GroupID]) references Groups([ID]),
		constraint [FK_GroupsLectures_LectureID_1] foreign key([LectureID]) references Lectures([ID])
)

CREATE TABLE LectureRooms
(
		[ID] int identity not null,
		[Building] int not null,
		[Name] nvarchar(10) not null

		constraint [PK_LectureRooms_ID_1] primary key([ID]),
		constraint [CK_LectureRooms_Building_1] check([Building] >= 1 and [Building] <= 5),
		constraint [CK_LectureRooms_Name_1] check(len([Name]) > 0),
		constraint [CK_LectureRooms_Name_2] unique([Name]),
)

CREATE TABLE Schedules
(
		[ID] int identity not null,
		[Class] int not null, --(1 - 8)
		[DayOfWeek] int not null, --(1 - 7)
		[Week] int not null, --(1 - 52)
		[LectureID] int not null,
		[LectureRoomID] int not null

		constraint [PK_Schedules_ID_1] primary key([ID]),
		constraint [CK_Schedules_Class_1] check([Class] >= 1 and [Class] <= 8),
		constraint [CK_Schedules_DayOfWeek_1] check([DayOfWeek] >= 1 and [DayOfWeek] <= 7),
		constraint [CK_Schedules_Week_1] check([Week] >= 1 and [Week] <= 52),
		constraint [FK_Schedules_LectureID_1] foreign key([LectureID]) references Lectures([ID]),
		constraint [FK_Schedules_LectureRoomID_1] foreign key([LectureRoomID]) references LectureRooms([ID])
)

INSERT INTO Subjects([Name])
VALUES ('Chemistry'), ('Mathematics'), ('Physics'), ('Geography'), ('English')

INSERT INTO Teachers([Name])
VALUES ('Edward Hopper'), ('Drew Burke'), ('Eliana Rich'), ('Giovanni Horton'), ('Jago Kelly'), ('Kingsley Wood'),
	   ('Grace Juarez'), ('Miranda Woodward'), ('Sylvie Martin'), ('Alex Carmack'), ('Zaki Miles'), ('Raja Hudson'),
	   ('Zaka Zaka')

INSERT INTO Heads([TeacherID])
VALUES (1), (3), (5)

INSERT INTO Assistants([TeacherID])
VALUES (2), (4), (10)

INSERT INTO Curators([TeacherID])
VALUES (6), (7), (8), (9), (10)

INSERT INTO Deans([TeacherID])
VALUES (11), (12), (13)

INSERT INTO Faculties([Name], [Building], [DeanID])
VALUES ('Computer Science', 2, 1), ('Applied Chemistry', 4, 2), ('Applied Physics', 1, 2), ('Cybersecurity', 3, 1), ('Mathematics', 5, 3)

INSERT INTO Lectures([SubjectID], [TeacherID])
VALUES (1, 1), (2, 5), (3, 8), (4, 3), (5, 10)

INSERT INTO Departments([Name], [Building], [FacultyID], [HeadID])
VALUES ('Computational Mathematics', 5, 5, 3), ('Economic Informatics', 2, 1, 3), ('Statistics', 5, 5, 3), ('Computer Modeling', 2, 1, 2), ('Gas and Wave Dynamics', 1, 3, 2), ('Physical Chemistry', 4, 2, 2), ('Software Development', 2, 1, 2)

INSERT INTO Groups([Name], [Year], [DepartmentID])
VALUES ('A101', 1, 1), ('A102', 2, 1), ('A103', 3, 1), ('A104', 4, 1), ('A105', 5, 1),
	   ('B201', 1, 2), ('B202', 2, 2), ('B203', 3, 2), ('B204', 4, 2), ('B205', 5, 2),
	   ('C301', 1, 3), ('C302', 2, 3), ('C303', 3, 3), ('C304', 4, 3), ('C305', 5, 3),
	   ('D401', 1, 4), ('D402', 2, 4), ('D403', 3, 4), ('D404', 4, 4), ('D405', 5, 4),
	   ('F501', 1, 5), ('F502', 2, 5), ('F503', 3, 5), ('F504', 4, 5), ('F505', 5, 5)

INSERT INTO GroupsCurators([GroupID], [CuratorID])
VALUES (1, 2), (2, 2), (3, 2), (4, 2), (5, 2),
	   (6, 1), (7, 1), (8, 1), (9, 1), (10, 1),
	   (11, 5), (12, 5), (13, 5), (14, 5), (15, 5),
	   (16, 4), (17, 4), (18, 4), (19, 4), (20, 4),
	   (21, 3), (22, 3), (23, 4), (24, 4), (25, 4)

INSERT INTO GroupsLectures([GroupID], [LectureID])
VALUES (1, 1), (2, 2), (3, 3), (4, 4), (5, 5),
	   (6, 1), (7, 2), (8, 3), (9, 4), (10, 5),
	   (11, 1), (12, 2), (13, 3), (14, 4), (15, 5),
	   (16, 1), (17, 2), (18, 3), (19, 4), (20, 5),
	   (21, 1), (22, 2), (23, 3), (24, 4), (25, 5)

INSERT INTO LectureRooms([Name], [Building])
VALUES ('A101', 1), ('A102', 1), ('A103', 1), ('A104', 1), ('A105', 1), ('A106', 1), ('A107', 1), ('A108', 1), ('A109', 1), ('A110', 1), ('A111', 1),
	   ('A201', 1), ('A202', 1), ('A203', 1), ('A204', 1), ('A205', 1), ('A206', 1), ('A207', 1), ('A208', 1), ('A209', 1), ('A210', 1), ('A211', 1),
	   ('A301', 1), ('A302', 1), ('A303', 1), ('A304', 1), ('A305', 1), ('A306', 1), ('A307', 1), ('A308', 1), ('A309', 1), ('A310', 1), ('A311', 1),
	   ('A401', 1), ('A402', 1), ('A403', 1), ('A404', 1), ('A405', 1), ('A406', 1), ('A407', 1), ('A408', 1), ('A409', 1), ('A410', 1), ('A411', 1),
	   ('A501', 1), ('A502', 1), ('A503', 1), ('A504', 1), ('A505', 1), ('A506', 1), ('A507', 1), ('A508', 1), ('A509', 1), ('A510', 1), ('A511', 1)

INSERT INTO Schedules([Class], [LectureID], [LectureRoomID], [DayOfWeek], [Week])
VALUES (1, 1, 1, 1, 1), (1, 2, 2, 2, 1), (1, 3, 3, 3, 1), (1, 4, 4, 4, 1), (1, 5, 5, 5, 1),
	   (2, 1, 6, 6, 1), (2, 2, 7, 7, 1), (2, 3, 8, 1, 2), (2, 4, 9, 2, 2), (2, 5, 10, 3, 2),
	   (3, 1, 11, 4, 2), (3, 2, 12, 5, 2), (3, 3, 13, 6, 2), (3, 4, 14, 7, 2), (3, 5, 15, 1, 3),
	   (4, 1, 16, 2, 3), (4, 2, 17, 3, 3), (4, 3, 18, 4, 3), (4, 4, 19, 5, 3), (4, 5, 20, 6, 3),
	   (5, 1, 21, 7, 3), (5, 2, 22, 1, 4), (5, 3, 23, 2, 4), (5, 4, 24, 3, 4), (5, 5, 25, 4, 4)

--1. ¬ывести названи€ аудиторий, в которых читает лекции преподаватель УEdward HopperФ. 
SELECT lr.[Name] as 'Classrooms'
FROM LectureRooms lr
JOIN Schedules s on s.[LectureRoomID] = lr.ID
JOIN Lectures l on l.[ID] = s.[LectureID]
JOIN Teachers t on t.[ID] = l.[TeacherID] and t.[Name] = 'Edward Hopper'

--2. ¬ывести фамилии ассистентов, читающих лекции в группе УF505Ф. 
SELECT g.[Name] as 'Groups', t.[Name] as 'Teachers'' Names'
FROM GroupsLectures gl
JOIN Groups g on gl.[GroupID] = g.[ID]
JOIN Lectures l on gl.[LectureID] = l.[ID]
JOIN Teachers t on l.[TeacherID] = t.[ID]
JOIN Assistants a on t.[ID] = a.[TeacherID]
WHERE g.[Name] = 'F505'

--3. ¬ывести дисциплины, которые читает преподаватель УAlex CarmackФ дл€ групп 5-го курса.
SELECT s.[Name] as 'Disciplines', g.[Name] as 'Groups'
FROM GroupsLectures gl
JOIN Groups g on gl.[GroupID] = g.[ID] and g.[Year] = 5
JOIN Lectures l on gl.[LectureID] = l.[ID]
JOIN Teachers t on l.[TeacherID] = t.[ID] and t.[Name] = 'Alex Carmack'
JOIN Subjects s on l.[SubjectID] = s.[ID]

--4. ¬ывести фамилии преподавателей, которые не читают лекции по понедельникам.
SELECT t.[Name], s.[DayOfWeek]
FROM Schedules s
JOIN Lectures l on s.[LectureID] = l.[ID]
JOIN Teachers t on l.[TeacherID] = t.[ID]
WHERE s.[DayOfWeek] <> 1

--5. ¬ывести названи€ аудиторий, с указанием их корпусов, в которых нет лекций в среду второй недели на третьей паре. 
SELECT lr.[Name] as 'Lecture Rooms', lr.[Building] as 'Building', s.[Class], s.[DayOfWeek], s.[Week]
FROM Schedules s
JOIN LectureRooms lr on s.[LectureRoomID] = lr.[ID]
WHERE s.[DayOfWeek] <> 3 or s.[Week] <> 2 or s.[Class] <> 3

--6. ¬ывести полные имена преподавателей факультета УComputer ScienceФ, которые не курируют группы кафедры УSoftware DevelopmentФ. 
SELECT t.[Name] as 'Teachers'' Names', f.[Name] as 'Faculties'
FROM GroupsLectures gl
JOIN Groups g on gl.[GroupID] = g.[ID]
JOIN Lectures l on gl.[LectureID] = l.[ID]
JOIN Teachers t on l.[TeacherID] = t.[ID]
JOIN Departments dp on g.[DepartmentID] = dp.[ID]
JOIN Faculties f on dp.[FacultyID] = f.[ID] and f.[Name] = 'Computer Science' and f.[Name] <> 'Software Development'

--7. ¬ывести список номеров всех корпусов, которые имеютс€ в таблицах факультетов, кафедр и аудиторий.
SELECT distinct f.Building as 'Faculties'' Buildings', dp.[Building] as 'Departments'' Buildings', lr.[Building] as 'Lecture Rooms'' Buildings'
FROM Faculties f
JOIN Departments dp on 1 = 1
JOIN LectureRooms lr on 2 = 2
ORDER BY f.Building, dp.[Building], lr.[Building]

--8. ¬ывести полные имена преподавателей в следующем пор€дке: деканы факультетов, заведующие кафедрами, преподаватели, кураторы, ассистенты.
SELECT t.[Name] as 'Teachers'' Names', d.[ID] as 'Deans ID', h.[ID] as 'Heads ID', t.[ID] as 'Teachers ID', c.[ID] as 'Curators ID', a.[ID] as 'Assistants ID'
FROM Teachers t
FULL JOIN Deans d on t.[ID] = d.[TeacherID]
FULL JOIN Heads h on t.[ID] = h.[TeacherID]
FULL JOIN Curators c on t.[ID] = c.[TeacherID]
FULL JOIN Assistants a on t.[ID] = a.[TeacherID]
ORDER BY ISNULL(d.[ID], 10000), ISNULL(h.[ID], 10000), ISNULL(t.[ID], 10000), ISNULL(c.[ID], 10000), ISNULL(a.[ID], 10000)

--9. ¬ывести дни недели (без повторений), в которые имеютс€ зан€ти€ в аудитори€х УA311Ф и УA104Ф корпуса 1.
SELECT distinct lr.[Name] as 'Lecture Room', s.[DayOfWeek]
FROM Schedules s
JOIN LectureRooms lr on s.[LectureRoomID] = lr.[ID] and lr.[Building] = 1
WHERE lr.[Name] = 'A311' or lr.[Name] = 'A104'

--10. ¬ывести количество групп учащихс€ на конкретных курсах (1-ый курс, 2-ой курс, Е ).
SELECT g.[Year] as 'Groups'' Years', count(g.[Year]) as 'Number of Groups'
FROM Groups g
GROUP BY g.[Year]

--11. ¬ывести количество ассистентов дл€ каждого учител€ (јссистенты сами по себе учител€, так что € просто выведу всех ассистентов)
SELECT t.[Name] as 'Assistants'' Names'
FROM Teachers t
JOIN Assistants a on t.[ID] = a.[TeacherID]

--12. ¬ывести отсортированные группы по количеству лекций, которым они обучаютс€
SELECT g.[Name] as 'Groups'' Names', count(l.[ID])
FROM GroupsLectures gl
JOIN Groups g on gl.[GroupID] = g.[ID]
JOIN Lectures l on gl.[LectureID] = l.[ID]
GROUP BY g.[Name]
ORDER BY count(l.[ID])