CREATE DATABASE ToDoDB
USE ToDoDB

CREATE TABLE Priorities
(
		[ID] int identity not null,
		[Name] nvarchar(20) not null

		constraint [PK_Priorities_ID_1] primary key([ID]),
		constraint [CK_Priorities_Name_1] check(len([Name]) > 0)
)

CREATE TABLE Statuses
(
		[ID] int identity not null,
		[Name] nvarchar(20) not null

		constraint [PK_Statuses_ID_1] primary key([ID]),
		constraint [CK_Statuses_Name_1] check(len([Name]) > 0)
)

CREATE TABLE Tasks
(
		[ID] int identity not null,
		[Name] nvarchar(50) not null,
		[PriorityID] int not null,
		[StatusID] int not null

		constraint [PK_Tasks_ID_1] primary key([ID]),
		constraint [CK_Tasks_Name_1] check(len([Name]) > 0),
		constraint [FK_Tasks_PriorityID_1] foreign key([PriorityID]) references Priorities([ID]),
		constraint [FK_Tasks_StatusID_1] foreign key([StatusID]) references Statuses([ID])
)