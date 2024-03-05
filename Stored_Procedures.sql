USE [391_1_2]
GO

-------------------- GET INSTUCTORS -------------------------
CREATE PROCEDURE spGetInstFaculty
AS
BEGIN
    SELECT DISTINCT Faculty
    FROM Instructors
    ORDER BY Faculty ASC;
END;
GO

CREATE PROCEDURE spGetInstRank
AS
BEGIN
    SELECT DISTINCT Rank
    FROM Instructors
    ORDER BY Rank ASC;
END;
GO

CREATE PROCEDURE spGetInstUni
AS
BEGIN
    SELECT DISTINCT University
    FROM Instructors
    ORDER BY University ASC;
END;
GO

CREATE PROCEDURE spGetInst
AS
BEGIN
    SELECT DISTINCT Instructor_Key
    FROM Instructors
    ORDER BY Instructor_Key ASC;
END;
GO

-------------------- GET STUDENTS -------------------------
CREATE PROCEDURE spGetStuMajor
AS
BEGIN
    SELECT DISTINCT Major
    FROM Students
    ORDER BY Major ASC;
END;
GO

CREATE PROCEDURE spGetStuGender
AS
BEGIN
    SELECT DISTINCT Gender
    FROM Students
    ORDER BY Gender ASC;
END;
GO

CREATE PROCEDURE spGetStu
AS
BEGIN
    SELECT DISTINCT Student_Key
    FROM Students
    ORDER BY Student_Key ASC;
END;
GO

-------------------- GET COURSES -------------------------
CREATE PROCEDURE spGetCourseDept
AS
BEGIN
    SELECT DISTINCT Department
    FROM Courses
    ORDER BY Department ASC;
END;
GO

-------------------- GET DATES -------------------------
CREATE PROCEDURE spGetSemester
AS
BEGIN
    SELECT DISTINCT Semester
    FROM Date
    ORDER BY Semester ASC;
END;
GO

CREATE PROCEDURE spGetYear
AS
BEGIN
    SELECT DISTINCT Year
    FROM Date
    ORDER BY Year ASC;
END;
GO
