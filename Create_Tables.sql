

USE [391_1_2]
GO

/****** Object:  Table [dbo].[Date]    Script Date: 2024-02-29 9:42:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Date](
	[Date_Key] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Semester] [varchar](max) NULL,
	[Year] [numeric](4, 0) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Courses](
	[Course_Key] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Department] [varchar](max) NULL,
	[Faculty] [varchar](max) NULL,
	[University] [varchar](max) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Instructors](
	[Instructor_Key] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Faculty] [varchar](max) NULL,
	[Rank] [varchar](max) NULL,
	[University] [varchar](max) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Students](
	[Student_Key] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Major] [varchar](max) NULL,
	[Gender] [varchar](max) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[University](
	[Instructor_Key] [numeric](18, 0) NOT NULL,
	[Student_Key] [numeric](18, 0) NOT NULL,
	[Course_Key] [numeric](18, 0) NOT NULL,
	[Date_Key] [numeric](18, 0) NOT NULL,
	[Total_Courses] [numeric](18, 0) NULL,
    FOREIGN KEY ([Instructor_Key]) REFERENCES [dbo].[Instructors]([Instructor_Key]),
    FOREIGN KEY ([Student_Key]) REFERENCES [dbo].[Students]([Student_Key]),
    FOREIGN KEY ([Course_Key]) REFERENCES [dbo].[Courses]([Course_Key]),
    FOREIGN KEY ([Date_Key]) REFERENCES [dbo].[Date]([Date_Key])
) ON [PRIMARY]
GO