USE [391_1_2]
GO

/****** Object:  Table [dbo].[Date]    Script Date: 2024-02-29 9:42:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('dbo.FK_CoursesTaken_Instructors_Instructor_Key', 'F') IS NOT NULL
	ALTER TABLE dbo.[CoursesTaken] DROP CONSTRAINT FK_CoursesTaken_Instructors_Instructor_Key
GO

IF OBJECT_ID('dbo.FK_CoursesTaken_Students_Student_Key', 'F') IS NOT NULL
	ALTER TABLE dbo.[CoursesTaken] DROP CONSTRAINT FK_CoursesTaken_Students_Student_Key
GO

IF OBJECT_ID('dbo.FK_CoursesTaken_Courses_Course_Key', 'F') IS NOT NULL
	ALTER TABLE dbo.[CoursesTaken] DROP CONSTRAINT FK_CoursesTaken_Courses_Course_Key
GO

IF OBJECT_ID('dbo.FK_CoursesTaken_Date_Date_Key', 'F') IS NOT NULL
	ALTER TABLE dbo.[CoursesTaken] DROP CONSTRAINT FK_CoursesTaken_Date_Date_Key
GO

IF OBJECT_ID('dbo.Date', 'U') IS NOT NULL
    DROP TABLE [dbo].[Date];
GO

CREATE TABLE [dbo].[Date](
	[Date_Key] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Semester] [varchar](max) NULL,
	[Year] [numeric](4, 0) NULL
) ON [PRIMARY]
GO


IF OBJECT_ID('dbo.Courses', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO

CREATE TABLE [dbo].[Courses](
	[Course_Key] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Department] [varchar](max) NULL,
	[Faculty] [varchar](max) NULL,
	[University] [varchar](max) NULL
) ON [PRIMARY]
GO


IF OBJECT_ID('dbo.Instructors', 'U') IS NOT NULL
    DROP TABLE [dbo].[Instructors];
GO

CREATE TABLE [dbo].[Instructors](
	[Instructor_Key] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Faculty] [varchar](max) NULL,
	[Rank] [varchar](max) NULL,
	[University] [varchar](max) NULL
) ON [PRIMARY]
GO


IF OBJECT_ID('dbo.Students', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO

CREATE TABLE [dbo].[Students](
	[Student_Key] [numeric](18, 0) NOT NULL PRIMARY KEY,
	-- 4 character code for majors, ie. CMPT, MATH, ENGL etc.
	[Major] [char](4) NULL,
	[Gender] [varchar](max) NULL
) ON [PRIMARY]
GO


-- the truth table combines primary keys from all of the dimension tables
IF OBJECT_ID('dbo.CoursesTaken', 'U') IS NOT NULL
    DROP TABLE [dbo].[CoursesTaken];
GO

CREATE TABLE [dbo].[CoursesTaken](
	[Instructor_Key] [numeric](18, 0) NOT NULL,
	[Student_Key] [numeric](18, 0) NOT NULL,
	[Course_Key] [numeric](18, 0) NOT NULL,
	[Date_Key] [numeric](18, 0) NOT NULL,
	[Total_Courses] [numeric](18, 0) NULL,
	CONSTRAINT [FK_CoursesTaken_Instructors_Instructor_Key] FOREIGN KEY([Instructor_Key])
	REFERENCES [dbo].[Instructors] ([Instructor_Key]),
	CONSTRAINT [FK_CoursesTaken_Students_Student_Key] FOREIGN KEY([Student_Key])
	REFERENCES [dbo].[Students] ([Student_Key]),
	CONSTRAINT [FK_CoursesTaken_Courses_Course_Key] FOREIGN KEY([Course_Key])
	REFERENCES [dbo].[Courses] ([Course_Key]),
	CONSTRAINT [FK_CoursesTaken_Date_Date_Key] FOREIGN KEY([Date_Key])
	REFERENCES [dbo].[Date] ([Date_Key]),
	CONSTRAINT [PK_CoursesTaken] PRIMARY KEY CLUSTERED 
(
	[Student_Key] ASC,
	[Instructor_Key] ASC,
	[Course_Key] ASC,
	[Date_Key] ASC
)
)
