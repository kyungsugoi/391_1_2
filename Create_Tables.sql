/*
Note: Make sure database named CMPT391_1_2 has been created first before running this script

Check the messages tab to see progress
Benchmarks: takes ~30 seconds with 1200 instructors, 10000 students, 2000 courses, 140 dates, 105000 courses taken
*/
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
	[Date_Key] [numeric](18, 0) NOT NULL IDENTITY PRIMARY KEY,
	[Semester] [varchar](max) NULL,
	[Year] [numeric](4, 0) NULL
) ON [PRIMARY]
GO


IF OBJECT_ID('dbo.Courses', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO

CREATE TABLE [dbo].[Courses](
	[Course_Key] [numeric](18, 0) NOT NULL IDENTITY PRIMARY KEY,
	[Department] [varchar](max) NULL,
	[Faculty] [varchar](max) NULL,
	[University] [varchar](max) NULL
) ON [PRIMARY]
GO


IF OBJECT_ID('dbo.Instructors', 'U') IS NOT NULL
    DROP TABLE [dbo].[Instructors];
GO

CREATE TABLE [dbo].[Instructors](
	[Instructor_Key] [numeric](18, 0) NOT NULL IDENTITY PRIMARY KEY,
	[Faculty] [varchar](max) NULL,
	[Rank] [varchar](max) NULL,
	[University] [varchar](max) NULL
) ON [PRIMARY]
GO


IF OBJECT_ID('dbo.Students', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO

CREATE TABLE [dbo].[Students](
	[Student_Key] [numeric](18, 0) NOT NULL IDENTITY PRIMARY KEY,
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
	[Student_Key],
	[Instructor_Key],
	[Course_Key],
	[Date_Key]
)
)

PRINT 'Tables created'


-- drop stored procedure if it exists
IF OBJECT_ID ('dbo.getStrFromList', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.getStrFromList;  
GO

/*
SP takes a pipe-delimited string @string_list and assigns @output_str a random string from it
ex. @string_list='blue|red|bright yellow' will randomly assign @output_str 'blue', 'red', or 'bright yellow'
Usage: EXEC getStrFromList @string_list='Associate|Full-time|Assistant',
						   @output_str=@instructor_rank OUTPUT
*/
CREATE PROCEDURE getStrFromList
	@string_list varchar(max),
	@output_str varchar(max) OUTPUT
AS
	SELECT TOP 1 @output_str=value
	FROM STRING_SPLIT(@string_list, '|')
	-- NEWID() generates a random number for each row which the rows are then sorted by
	ORDER BY NEWID()
GO


-- drop stored procedure if it exists
IF OBJECT_ID ('dbo.getRandNum', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.getRandNum;  
GO

-- SP gets random number between 1 and range
-- random number generator idea thanks to https://stackoverflow.com/a/30201297
CREATE PROCEDURE getRandNum 
@range INT
AS
	RETURN FLOOR((RAND() * @range) + 1)
GO


-- Don't spam with messages for every single INSERT
SET NOCOUNT ON;

-- these lists are reused in more than one place
DECLARE @faculties_list varchar(max)
SET @faculties_list = 'Arts and Science|Business|Continuing Education|Fine Arts and Communications|Nursing'

DECLARE @universities_list varchar(max)
SET @universities_list = 'University of Alberta|MacEwan|University of Calgary'


-- Filling the Instructor table with dummy data
-- Instructors (Instructor, Faculty, Rank, University)
DECLARE @instructor_faculty VARCHAR(max)
DECLARE @instructor_rank VARCHAR(max)
DECLARE @instructor_university VARCHAR(max)

-- Generic counter variable used everywhere
DECLARE @i int
SET @i = 1
WHILE @i <= 1200
BEGIN
	EXEC getStrFromList @string_list=@faculties_list,
						@output_str=@instructor_faculty OUTPUT

	EXEC getStrFromList @string_list='Associate|Full-time|Assistant',
						@output_str=@instructor_rank OUTPUT
		
	EXEC getStrFromList @string_list=@universities_list,
						@output_str=@instructor_university OUTPUT

	INSERT INTO Instructors (Faculty, Rank, University)
	VALUES (@instructor_faculty, @instructor_rank, @instructor_university)
	SET @i = @i + 1
END

DECLARE @instructors_count int
SELECT @instructors_count = COUNT(*) FROM Instructors
PRINT 'Inserted ' + LTRIM(STR(@instructors_count)) + ' instructors'


-- Filling the Students table with dummy data
-- Students (Student, Major, Gender)
DECLARE @student_major CHAR(4)
DECLARE @student_gender VARCHAR(2)

SET @i = 1
WHILE @i <= 10000
BEGIN
	EXEC getStrFromList @string_list='BIOL|CHEM|PHYS|NURS|CMPT|ENGL|PSYC|ANTH|DESN|HIST|MUSC|PHIL|MATH|STAT',
						@output_str=@student_major OUTPUT
	
	EXEC getStrFromList @string_list='M|F|NB',
						@output_str=@student_gender OUTPUT

	INSERT INTO Students (Major, Gender)
	VALUES (@student_major, @student_gender)
	SET @i = @i + 1
END

DECLARE @students_count int
SELECT @students_count = COUNT(*) FROM Students
PRINT 'Inserted ' + LTRIM(STR(@students_count)) + ' students'


-- Filling the Courses table with dummy data
-- Courses (Department, Faculty, University)
DECLARE @course_department VARCHAR(max)
DECLARE @course_faculty VARCHAR(max)
DECLARE @course_university VARCHAR(max)
DECLARE @departments_list VARCHAR(max)

SET @i = 1
WHILE @i <= 2000
BEGIN
	EXEC getStrFromList @string_list=@faculties_list,
						@output_str=@course_faculty OUTPUT
		
	EXEC getStrFromList @string_list=@universities_list,
						@output_str=@course_university OUTPUT
	
	-- faculties and their respective departments taken from the MacEwan calendar
	-- https://calendar.macewan.ca/faculties-university/
	SET @departments_list = CASE @course_faculty
        WHEN 'Arts and Science' THEN 'Anthropology, Economics and Political Science|Biological Sciences|Computer Science|English|Humanities|Mathematics and Statistics|Physical Sciences|Psychology|Sociology'
        WHEN 'Business' THEN 'Accounting and Finance|Decision Sciences|International Business, Marketing, Strategy and Law|Management and Operations'
        WHEN 'Continuing Education' THEN 'English as an Additional Language|University Preparation'
        WHEN 'Fine Arts and Communications' THEN 'Arts and Cultural Management|Communication|Design|Music|Studio Arts|Theatre'
        WHEN 'Nursing' THEN 'Nursing Foundations|Nursing Practice|Health Systems & Sustainability|Human Health & Science|Professional Nursing & Allied Health'
        ELSE ''
        END
		
	EXEC getStrFromList @string_list=@departments_list,
						@output_str=@course_department OUTPUT

	INSERT INTO Courses (Department, Faculty, University)
	VALUES (@course_department, @course_faculty, @course_university)
	SET @i = @i + 1
END

DECLARE @courses_count int
SELECT @courses_count = COUNT(*) FROM Courses
PRINT 'Inserted ' + LTRIM(STR(@courses_count)) + ' courses'


-- Filling the Date table with dummy data
-- Date (Semester, Year)
DECLARE @date_year NUMERIC(4, 0)

SET @date_year = 1990
WHILE @date_year <= 2024
BEGIN
	INSERT INTO Date (Semester, Year)
	VALUES ('Winter', @date_year)
	INSERT INTO Date (Semester, Year)
	VALUES ('Spring', @date_year)
	INSERT INTO Date (Semester, Year)
	VALUES ('Summer', @date_year)
	INSERT INTO Date (Semester, Year)
	VALUES ('Fall', @date_year)

	SET @date_year = @date_year + 1
END

DECLARE @date_count int
SELECT @date_count = COUNT(*) FROM Date
PRINT 'Inserted ' + LTRIM(STR(@date_count)) + ' dates'


-- Filling the CoursesTaken table with dummy data
-- CoursesTaken (Instructor_Key, Student_Key, Course_Key, Date_Key, Total_Courses)
DECLARE @coursesTaken_instructorID NUMERIC(18, 0)
DECLARE @coursesTaken_studentID NUMERIC(18, 0)
DECLARE @coursesTaken_courseID NUMERIC(18, 0)
DECLARE @coursesTaken_dateID NUMERIC(18, 0)

DECLARE @rand_num_courses int
DECLARE @rand_num_semesters int
DECLARE @semester_current int
DECLARE @semester_count int
DECLARE @student_courses_taken int

-- assign 1-14 courses for every student across 1-8 semesters each
SET @coursesTaken_studentID = 1
WHILE @coursesTaken_studentID <= @students_count
BEGIN
	-- make semesters taken be realistic (within a 8 semester / 2 year range)
	EXECUTE @rand_num_semesters = getRandNum @range=8
	EXECUTE @semester_current = getRandNum @range=@date_count
	SET @semester_count = 0

	-- students can take a total of 14 courses
	SET @student_courses_taken = 14

	-- make sure not to go into the future and over the number of semesters being taken
	WHILE @semester_current <= @date_count AND @semester_count < @rand_num_semesters AND @student_courses_taken > 0
	BEGIN
		SET @i = 0

		-- up to 5 courses a semester
		EXECUTE @rand_num_courses = getRandNum @range=5
		WHILE @i < @rand_num_courses AND @student_courses_taken > 0
		BEGIN
			EXECUTE @coursesTaken_instructorID = getRandNum @range=@instructors_count
			EXECUTE @coursesTaken_courseID = getRandNum @range=@courses_count
			
			BEGIN TRY
				INSERT INTO CoursesTaken (Instructor_Key, Student_Key, Course_Key, Date_Key, Total_Courses)
				VALUES (@coursesTaken_instructorID, @coursesTaken_studentID, @coursesTaken_courseID, @semester_current, 1)
			END TRY
			BEGIN CATCH
				-- on the rare case the student has already taken that exact course with the same instructor in the same semester before, update the number of times taken
				UPDATE CoursesTaken
				SET Total_Courses = Total_Courses + 1
				WHERE Instructor_Key = @coursesTaken_instructorID AND Student_Key = @coursesTaken_studentID AND Course_Key = @coursesTaken_courseID AND Date_Key = @semester_current;
			END CATCH

			SET @i = @i + 1
			SET @student_courses_taken = @student_courses_taken - 1
		END
		SET @semester_current = @semester_current + 1
		SET @semester_count = @semester_count + 1

	END
	SET @coursesTaken_studentID = @coursesTaken_studentID + 1
END
GO

DECLARE @coursestaken_count int
SELECT @coursestaken_count = COUNT(*) FROM CoursesTaken
PRINT 'Inserted ' + LTRIM(STR(@coursestaken_count)) + ' courses taken'