

USE [391_1_2]
GO

/****** Object:  Table [dbo].[Date]    Script Date: 2024-02-29 9:42:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Date](
	[Date_Key] [nchar](10) NULL,
	[Semester] [nchar](10) NULL,
	[Year] [nchar](10) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Courses](
	[Course_Key] [nchar](10) NULL,
	[Department] [nchar](10) NULL,
	[Faculty] [nchar](10) NULL,
	[University] [nchar](10) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Instructors](
	[Instructor_Key] [nchar](10) NULL,
	[Faculty] [nchar](10) NULL,
	[Rank] [nchar](10) NULL,
	[University] [nchar](10) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Students](
	[Student_Key] [nchar](10) NULL,
	[Major] [nchar](10) NULL,
	[Gender] [nchar](10) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[University](
	[Instructor_Key] [nchar](10) NULL,
	[Student_Key] [nchar](10) NULL,
	[Course_Key] [nchar](10) NULL,
	[Date_Key] [nchar](10) NULL,
	[Total_Courses] [nchar](10) NULL
) ON [PRIMARY]
GO