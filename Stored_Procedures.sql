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


-------------------- INSERT OR UPDATE TABLES FROM XML -------------------------

IF OBJECT_ID ('dbo.spInsertOrUpdateInstructor', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spInsertOrUpdateInstructor;  
GO
CREATE PROCEDURE spInsertOrUpdateInstructor
    @Faculty NVARCHAR(MAX),
    @Rank NVARCHAR(MAX),
    @University NVARCHAR(MAX)
AS
BEGIN
    -- Starting a transaction
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Check if the instructor already exists (Assuming combination of Faculty, Rank, and University is unique for each instructor)
        IF NOT EXISTS (SELECT 1 FROM dbo.Instructors WHERE Faculty = @Faculty AND Rank = @Rank AND University = @University)
        BEGIN
            -- Insert the new instructor since it does not exist
            INSERT INTO dbo.Instructors (Faculty, Rank, University)
            VALUES (@Faculty, @Rank, @University);
        END
        -- Optionally, update the instructor if it exists and you need to change some data
        -- ELSE
        -- BEGIN
        --     UPDATE dbo.Instructors SET [Column] = @Value WHERE Faculty = @Faculty AND Rank = @Rank AND University = @University;
        --     -- If you don't need to update, you can either skip this part or handle it accordingly.
        -- END
        
        -- Commit the transaction if no errors
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if there's an error
        ROLLBACK TRANSACTION;
        
        -- Re-throw the caught exception to handle it in the application or log it accordingly
        THROW;
    END CATCH
END


IF OBJECT_ID ('dbo.spInsertOrUpdateStudent', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spInsertOrUpdateStudent;  
GO
CREATE PROCEDURE spInsertOrUpdateStudent
    @Major CHAR(4),
    @Gender VARCHAR(MAX)
AS
BEGIN
    -- Starting a transaction
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Check if the instructor already exists (Assuming combination of Faculty, Rank, and University is unique for each instructor)
        IF NOT EXISTS (SELECT 1 FROM dbo.Students WHERE Major = @Major AND Gender = @Gender)
        BEGIN
            -- Insert the new instructor since it does not exist
            INSERT INTO dbo.Students(Major, Gender)
            VALUES (@Major, @Gender);
        END
        -- Optionally, update the instructor if it exists and you need to change some data
        -- ELSE
        -- BEGIN
        --     UPDATE dbo.Instructors SET [Column] = @Value WHERE Faculty = @Faculty AND Rank = @Rank AND University = @University;
        --     -- If you don't need to update, you can either skip this part or handle it accordingly.
        -- END
        
        -- Commit the transaction if no errors
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if there's an error
        ROLLBACK TRANSACTION;
        
        -- Re-throw the caught exception to handle it in the application or log it accordingly
        THROW;
    END CATCH
END


IF OBJECT_ID ('dbo.spInsertOrUpdateCourse', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spInsertOrUpdateCourse;  
GO
CREATE PROCEDURE spInsertOrUpdateCourse
    @Department VARCHAR(MAX),
    @Faculty VARCHAR(MAX),
	@University VARCHAR(MAX)
AS
BEGIN
    -- Starting a transaction
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Check if the instructor already exists (Assuming combination of Faculty, Rank, and University is unique for each instructor)
        IF NOT EXISTS (SELECT 1 FROM dbo.Courses WHERE Department = @Department AND Faculty = @Faculty AND University = @University)
        BEGIN
            -- Insert the new instructor since it does not exist
            INSERT INTO dbo.Courses(Department, Faculty, University)
            VALUES (@Department, @Faculty, @University);
        END
        -- Optionally, update the instructor if it exists and you need to change some data
        -- ELSE
        -- BEGIN
        --     UPDATE dbo.Instructors SET [Column] = @Value WHERE Faculty = @Faculty AND Rank = @Rank AND University = @University;
        --     -- If you don't need to update, you can either skip this part or handle it accordingly.
        -- END
        
        -- Commit the transaction if no errors
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if there's an error
        ROLLBACK TRANSACTION;
        
        -- Re-throw the caught exception to handle it in the application or log it accordingly
        THROW;
    END CATCH
END



IF OBJECT_ID ('dbo.spInsertOrUpdateDate', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spInsertOrUpdateDate;  
GO
CREATE PROCEDURE spInsertOrUpdateDate
    @Semester VARCHAR(MAX),
    @Year numeric(4, 0)
AS
BEGIN
    -- Starting a transaction
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Check if the instructor already exists (Assuming combination of Faculty, Rank, and University is unique for each instructor)
        IF NOT EXISTS (SELECT 1 FROM dbo.Date WHERE Semester = @Semester AND Year = @Year)
        BEGIN
            -- Insert the new instructor since it does not exist
            INSERT INTO dbo.Date(Semester, Year)
            VALUES (@Semester, @Year);
        END
        -- Optionally, update the instructor if it exists and you need to change some data
        -- ELSE
        -- BEGIN
        --     UPDATE dbo.Instructors SET [Column] = @Value WHERE Faculty = @Faculty AND Rank = @Rank AND University = @University;
        --     -- If you don't need to update, you can either skip this part or handle it accordingly.
        -- END
        
        -- Commit the transaction if no errors
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if there's an error
        ROLLBACK TRANSACTION;
        
        -- Re-throw the caught exception to handle it in the application or log it accordingly
        THROW;
    END CATCH
END




IF OBJECT_ID ('dbo.spInsertOrUpdateCT', 'P') IS NOT NULL  
    DROP PROCEDURE dbo.spInsertOrUpdateCT;  
GO
CREATE PROCEDURE spInsertOrUpdateCT
	@InstructorKey	numeric(18, 0),	
	@StudentKey	numeric(18, 0),	
	@CourseKey	numeric(18, 0),	
	@DateKey	numeric(18, 0),	
	@TotalCourses	numeric(18, 0)
AS
BEGIN
    -- Starting a transaction
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Check if the instructor already exists (Assuming combination of Faculty, Rank, and University is unique for each instructor)
        IF NOT EXISTS (SELECT 1 FROM dbo.CoursesTaken WHERE Instructor_Key = @InstructorKey AND Student_Key = @StudentKey AND Course_Key = @CourseKey AND Date_Key = @DateKey and Total_Courses = Total_Courses)
        BEGIN
            -- Insert the new instructor since it does not exist
            INSERT INTO dbo.CoursesTaken(Instructor_Key, Student_Key, Course_Key, Date_Key, Total_Courses)
            VALUES (@InstructorKey, @StudentKey, @CourseKey, @DateKey, @TotalCourses);
        END
        -- Optionally, update the instructor if it exists and you need to change some data
        -- ELSE
        -- BEGIN
        --     UPDATE dbo.Instructors SET [Column] = @Value WHERE Faculty = @Faculty AND Rank = @Rank AND University = @University;
        --     -- If you don't need to update, you can either skip this part or handle it accordingly.
        -- END
        
        -- Commit the transaction if no errors
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if there's an error
        ROLLBACK TRANSACTION;
        
        -- Re-throw the caught exception to handle it in the application or log it accordingly
        THROW;
    END CATCH
END