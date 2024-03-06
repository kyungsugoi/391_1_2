USE [391_1_2]
GO

-------------------- GET INSTUCTORS -------------------------

-- drop stored procedure if it exists
IF OBJECT_ID ('dbo.spGetInstFaculty', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetInstFaculty;  
GO

CREATE PROCEDURE spGetInstFaculty
AS
BEGIN
    SELECT DISTINCT Faculty
    FROM Instructors
    ORDER BY Faculty ASC;
END;
GO

IF OBJECT_ID ('dbo.spGetInstRank', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetInstRank;  
GO
CREATE PROCEDURE spGetInstRank
AS
BEGIN
    SELECT DISTINCT Rank
    FROM Instructors
    ORDER BY Rank ASC;
END;
GO

IF OBJECT_ID ('dbo.spGetInstUni', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetInstUni;  
GO
CREATE PROCEDURE spGetInstUni
AS
BEGIN
    SELECT DISTINCT University
    FROM Instructors
    ORDER BY University ASC;
END;
GO

IF OBJECT_ID ('dbo.spGetInst', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetInst;  
GO
CREATE PROCEDURE spGetInst
AS
BEGIN
    SELECT Instructor_Key
    FROM Instructors
END;
GO

-------------------- GET STUDENTS -------------------------
IF OBJECT_ID ('dbo.spGetStuMajor', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetStuMajor;  
GO
CREATE PROCEDURE spGetStuMajor
AS
BEGIN
    SELECT DISTINCT Major
    FROM Students
    ORDER BY Major ASC;
END;
GO

IF OBJECT_ID ('dbo.spGetStuGender', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetStuGender;  
GO
CREATE PROCEDURE spGetStuGender
AS
BEGIN
    SELECT DISTINCT Gender
    FROM Students
    ORDER BY Gender ASC;
END;
GO

IF OBJECT_ID ('dbo.spGetStu', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetStu;  
GO
CREATE PROCEDURE spGetStu
AS
BEGIN
    SELECT Student_Key
    FROM Students
END;
GO

-------------------- GET COURSES -------------------------
IF OBJECT_ID ('dbo.spGetCourseDept', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetCourseDept;  
GO
CREATE PROCEDURE spGetCourseDept
AS
BEGIN
    SELECT DISTINCT Department
    FROM Courses
    ORDER BY Department ASC;
END;
GO

-------------------- GET DATES -------------------------
IF OBJECT_ID ('dbo.spGetSemester', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetSemester;  
GO
CREATE PROCEDURE spGetSemester
AS
BEGIN
    SELECT DISTINCT Semester
    FROM Date
    ORDER BY Semester ASC;
END;
GO

IF OBJECT_ID ('dbo.spGetYear', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spGetYear;  
GO
CREATE PROCEDURE spGetYear
AS
BEGIN
    SELECT DISTINCT Year
    FROM Date
    ORDER BY Year ASC;
END;
GO
