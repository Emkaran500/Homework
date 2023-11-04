CREATE DATABASE CinemaPlus

USE CinemaPlus

CREATE TABLE Categories
(
		[ID] int identity not null,
		[Name] nvarchar(20) not null,

		constraint [PK_Categories_ID_1] primary key([ID]),
		constraint [CK_Categories_Name_1] check(len([Name]) > 0)
)

CREATE TABLE Films
(
		[ID] int identity not null,
		[Name] nvarchar(50) not null,
		[TimeLenghtInMin] int null,
		[Rating] nvarchar(10) not null


		constraint [PK_Films_ID_1] primary key([ID]),
		constraint [CK_Films_Name_1] check(len([Name]) > 0),
		constraint [CK_Films_TimeLenghtInMin_1] check([TimeLenghtInMin] > 0),
		constraint [CK_Films_Rating_1] check(len([Rating]) > 0)
)

CREATE TABLE FilmsCategories
(
		[FilmsCategoriesID] int identity not null,
		[FilmID] int not null,
		[CategoryID] int not null

		constraint [PK_FilmsCategories_FilmsCategoriesID] primary key([FilmsCategoriesID]),
		constraint [FK_FilmsCategories_FilmID_1] foreign key([FilmID]) references Films([ID]),
		constraint [FK_FilmsCategories_CategoryID] foreign key([CategoryID]) references Categories([ID])
)

CREATE TABLE Employees
(
		[ID] int identity not null,
		[Name] nvarchar(30) null

		constraint [PK_Employees_ID_1] primary key([ID]),
		constraint [CK_Employees_Name_1] check(len([Name]) > 0),
		constraint [UQ_Employees_Name_1] unique([Name])
)

CREATE TABLE Janitors
(
		[ID] int identity not null,
		[EmployeeID] int not null

		constraint [PK_Janitors_ID_1] primary key([ID]),
		constraint [FK_Janitors_ID_1] foreign key([EmployeeID]) references Employees([ID]) ON DELETE CASCADE
)

CREATE TABLE Operators
(
		[ID] int identity not null,
		[EmployeeID] int not null

		constraint [PK_Operators_ID_1] primary key([ID]),
		constraint [FK_Operators_ID_1] foreign key([EmployeeID]) references Employees([ID]) ON DELETE CASCADE
)

CREATE TABLE Cinemas
(
		[ID] int identity not null,
		[Name] nvarchar(30) not null,
		[Rows] int not null,
		[Seats] int not null,
		[JanitorID] int null,
		[FilmID] int null

		constraint [PK_Cinemas_ID_1] primary key([ID]),
		constraint [CK_Cinemas_Name_1] check(len([Name]) > 0),
		constraint [CK_Cinemas_Rows_1] check([Rows] >= 1 and [Rows] <= 15),
		constraint [CK_Cinemas_Seats_1] check([Seats] / [Rows] >= 1),
		constraint [FK_Cinemas_JanitorID_1] foreign key([JanitorID]) references Janitors([ID]) ON DELETE CASCADE,
		constraint [FK_Cinemas_FilmID_1] foreign key([FilmID]) references Films([ID])
)

INSERT INTO Categories([Name])
VALUES ('Horror'), ('Comedy'), ('Sci-Fi'), ('Fantasy'), ('Superhero')

INSERT INTO Films([Name], [TimeLenghtInMin], [Rating])
VALUES ('Megalodon', 100, 'R'), ('Menu', 106, 'R'), ('Boogeyman', 98, 'PG-13'), ('M3gan', 102, 'PG-13'), ('Scream 6', 122, 'R'),
	   ('Marry My Dead Body', 130, 'R'), ('Red White & Royal Blue', 118, 'R'), ('Cocaine Bear', 95, 'R'), ('Adams Family', 99, 'PG-13'), ('Hubie Halloween', 102, 'PG-13'),
	   ('65', 93, 'PG-13'), ('Dune', 155, 'PG-13'), ('Black Adam', 125, 'PG-13'), ('Avatar 2', 192, 'PG-13'), ('The Tomorrow War', 138, 'PG-13'),
	   ('Lord of The Rings', 178, 'PG-13'), ('Bright', 118, 'R'), ('The Princess Bride', 98, 'PG'), ('Pirates of The Carribean', 143, 'PG-13'), ('Dungeons and Drangons', 134, 'PG-13'),
	   ('Morbius', 104, 'PG-13'), ('Shazam!', 130, 'PG-13'), ('Black Widow', 133, 'PG-13'), ('Dark Knight', 152, 'PG-13'), ('Man of Steel', 143, 'PG-13')

INSERT INTO FilmsCategories([FilmID], [CategoryID])
VALUES (1, 1), (2, 1), (3, 1), (4, 1), (5, 1),
	   (6, 2), (7, 2), (8, 2), (9, 2), (10, 2),
	   (11, 3), (12, 3), (13, 3), (14, 3), (15, 3),
	   (16, 4), (17, 4), (18, 4), (19, 4), (20, 4),
	   (21, 5), (22, 5), (23, 5), (24, 5), (25, 5)

INSERT INTO Employees([Name])
VALUES ('Bianca Rocha'), ('Axel Castillo'), ('Mohamed Carter'), ('Lyra Meyer'), ('Janelle Underwood'),
	   ('Ashton Berry'), ('Isaac Medina'), ('Priscilla Bernal'), ('Adley Ryan'), ('Forest Henson')

INSERT INTO Janitors([EmployeeID])
VALUES (1), (3), (5), (7), (9), (10)

INSERT INTO Operators([EmployeeID])
VALUES (2), (4), (6), (8), (10)

INSERT INTO Cinemas([Name], [Rows], [Seats], [FilmID], [JanitorID])
VALUES ('28 Mall', 10, 100, 3, 1), ('Ganjlik Mall', 13, 156, 13, 3), ('Deniz Mall', 14, 140, 22, 2), ('Amburan Mall', 8, 64, 5, 4), ('Ganja Mall', 7, 70, 7, 5)

SELECT c.[Name] as 'Name of Cinema', c.[Rows] as 'Number of Rows', c.[Seats] as 'Number of Seats'
FROM Cinemas c
ORDER BY c.[Seats] desc, c.[Rows] desc

SELECT c.[Name] as 'Categories', count(c.[ID]) as 'Number of Films'
FROM Categories c
JOIN FilmsCategories fc on c.[ID] = fc.[CategoryID]
GROUP BY c.[Name]

SELECT e.[Name]
FROM Employees e
WHERE e.[ID] = (SELECT j.[ID] FROM Janitors j WHERE j.[ID] = 3)

SELECT distinct e.[ID]
FROM Employees e
JOIN Janitors j on e.[ID] = j.[EmployeeID]
JOIN Operators o on e.[ID] = o.[EmployeeID]