
-------------------- GET INSTUCTORS -------------------------
CREATE PROCEDURE spGetInstFaculty
AS
BEGIN
    SELECT DISTINCT Faculty
    FROM Instructors
    ORDER BY Faculty ASC;
END;


CREATE PROCEDURE spGetInstRank
AS
BEGIN
    SELECT DISTINCT Rank
    FROM Instructors
    ORDER BY Rank ASC;
END;


CREATE PROCEDURE spGetInstUni
AS
BEGIN
    SELECT DISTINCT University
    FROM Instructors
    ORDER BY University ASC;
END;

-------------------- GET STUDENTS -------------------------

CREATE PROCEDURE spGetStuMajor
AS
BEGIN
    SELECT DISTINCT Major
    FROM Students
    ORDER BY Major ASC;
END;


CREATE PROCEDURE spGetStuGender
AS
BEGIN
    SELECT DISTINCT Gender
    FROM Students
    ORDER BY Gender ASC;
END;



-------------------- GET COURSES -------------------------

CREATE PROCEDURE spGetCourseDept
AS
BEGIN
    SELECT DISTINCT Department
    FROM Courses
    ORDER BY Department ASC;
END;


-------------------- GET DATES -------------------------

CREATE PROCEDURE spGetSemester
AS
BEGIN
    SELECT DISTINCT Semester
    FROM Date
    ORDER BY Semester ASC;
END;


CREATE PROCEDURE spGetYear
AS
BEGIN
    SELECT DISTINCT Year
    FROM Date
    ORDER BY Year ASC;
END;
