using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        //Strings For Building
        public String Instructor = "Any";
        public String Faculty = "Any";
        public String University = "Any";
        public String Rank = "Any";

        public String Students = "Any";
        public String Major = "Any";
        public String Gender = "Any";

        public String Department = "Any";

        public String Semester = "Any";
        public String Year = "Any";








        public Form1()
        {
            InitializeComponent();

            // (local) will default to your server, no need to hardcode it anymore
            // String connectionString = "Server = DESKTOP-5HTNF3D\\SQLEXPRESS; Database = 391_1_2; Trusted_Connection = yes;";
            String connectionString = "Server = (local); Database = 391_1_2; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();

            }

            

        }

        public void stringBuilder()
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String connectionString = "Server = (local); Database = 391_1_2; Trusted_Connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            StringBuilder query = new StringBuilder();

            // Initial query for empty selections
            query.Append("SELECT COUNT(Total_Courses) AS Total FROM CoursesTaken");

            // FROM string builder
            StringBuilder fromQuery = new StringBuilder();

            // WHERE string builder
            StringBuilder whereQuery = new StringBuilder();

            if (cmbInstruct.SelectedIndex != 0 || cmbFaculty.SelectedIndex != 0 || cmbUni.SelectedIndex != 0 || cmbRank.SelectedIndex != 0 || cmbStudents.SelectedIndex != 0 || cmbMajor.SelectedIndex != 0 || cmbGender.SelectedIndex != 0 || cmbDept.SelectedIndex != 0 || cmbSemester.SelectedIndex != 0 || cmbYear.SelectedIndex != 0)
            {
                whereQuery.Append(" WHERE");
            }

            // WHERE or AND builder to whereQuery

            // Instructor Table dynamic conditions
            if (cmbInstruct.SelectedIndex != 0 || cmbFaculty.SelectedIndex != 0 || cmbUni.SelectedIndex != 0 || cmbRank.SelectedIndex != 0)
            {
                fromQuery.Append(", Instructors");

                if (whereQuery.ToString().TrimEnd().EndsWith("WHERE")) 
                {
                    whereQuery.Append(" CoursesTaken.Instructor_Key=Instructors.Instructor_Key");
                }
                else
                {
                    whereQuery.Append(" AND CoursesTaken.Instructor_Key=Instructors.Instructor_Key");
                }

                // Check to see which cmb is not index 0 then put a where clause for it
                if (cmbInstruct.SelectedIndex != 0)
                {
                    String instructorID = (String)cmbInstruct.SelectedItem;
                    whereQuery.Append(" AND Instructors.Instructor_Key = '" + instructorID + "'");
                }
                if (cmbFaculty.SelectedIndex != 0)
                {
                    String faculty = (String)cmbFaculty.SelectedItem;
                    whereQuery.Append(" AND Instructors.Faculty = '" + faculty + "'");
                }
                if (cmbUni.SelectedIndex != 0)
                {
                    String university = (String)cmbUni.SelectedItem;
                    whereQuery.Append(" AND Instructors.University = '" + university + "'");
                }
                if (cmbRank.SelectedIndex != 0)
                {
                    String rank = (String)cmbRank.SelectedItem;
                    whereQuery.Append(" AND Instructors.Rank = '" + rank + "'");
                }
            }

            // Student Table dynamic conditions
            if (cmbStudents.SelectedIndex != 0 || cmbMajor.SelectedIndex != 0 || cmbGender.SelectedIndex != 0)
            {
                fromQuery.Append(", Students");

                if (whereQuery.ToString().TrimEnd().EndsWith("WHERE"))
                {
                    whereQuery.Append(" CoursesTaken.Student_Key=Students.Student_Key");
                }
                else
                {
                    whereQuery.Append(" AND CoursesTaken.Student_Key=Students.Student_Key");
                }

                // Check to see which cmb is not index 0 then put a where clause for it
                if (cmbStudents.SelectedIndex != 0)
                {
                    String studentID = (String)cmbStudents.SelectedItem;
                    whereQuery.Append(" AND Students.Student_Key = '" + studentID + "'");
                }
                if (cmbMajor.SelectedIndex != 0)
                {
                    String major = (String)cmbMajor.SelectedItem;
                    whereQuery.Append(" AND Students.Major = '" + major + "'");
                }
                if (cmbGender.SelectedIndex != 0)
                {
                    String gender = (String)cmbGender.SelectedItem;
                    whereQuery.Append(" AND Students.Gender = '" + gender + "'");
                }
            }

            // Courses Table dynamic conditions
            if (cmbDept.SelectedIndex != 0)
            {
                fromQuery.Append(", Courses");

                if (whereQuery.ToString().TrimEnd().EndsWith("WHERE"))
                {
                    whereQuery.Append(" CoursesTaken.Course_Key=Courses.Course_Key");
                }
                else
                {
                    whereQuery.Append(" AND CoursesTaken.Course_Key=Courses.Course_Key");
                }

                // Check to see which cmb is not index 0 then put a where clause for it
                if (cmbDept.SelectedIndex != 0)
                {
                    String department = (String)cmbDept.SelectedItem;
                    whereQuery.Append(" AND Courses.Department = '" + department + "'");
                }
            }

            // Date Table dynamic conditions
            if (cmbSemester.SelectedIndex != 0 || cmbYear.SelectedIndex != 0)
            {
                fromQuery.Append(", Date");


                if (whereQuery.ToString().TrimEnd().EndsWith("WHERE"))
                {
                    whereQuery.Append(" CoursesTaken.Date_Key=Date.Date_Key");
                }
                else
                {
                    whereQuery.Append(" AND CoursesTaken.Date_Key=Date.Date_Key");
                }

                // Check to see which cmb is not index 0 then put a where clause for it
                if (cmbSemester.SelectedIndex != 0)
                {
                    String semester = (String)cmbSemester.SelectedItem;
                    whereQuery.Append(" AND Date.Semester = '" + semester + "'");
                }
                if (cmbYear.SelectedIndex != 0)
                {
                    String year = (String)cmbYear.SelectedItem;
                    whereQuery.Append(" AND Date.Year = '" + year + "'");
                }
            }

            query.Append(fromQuery).Append(whereQuery);

            try
            {
                myConnection.Open();
                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                int total = (int)command.ExecuteScalar();

                txtResult.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                this.Close();
            }
        }

        public void fillInstFacultyBox()
        {
            try
            {
                myCommand.CommandText = "spGetInstFaculty"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbFaculty.Items.Add(myReader["Faculty"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        public void fillInstBox()
        {
            try
            {
                myCommand.CommandText = "spGetInst"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbInstruct.Items.Add(myReader["Instructor_Key"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        public void fillInstRankBox()
        {
            try
            {
                myCommand.CommandText = "spGetInstRank"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbRank.Items.Add(myReader["Rank"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        public void fillInstUniBox()
        {
            try
            {
                myCommand.CommandText = "spGetInstUni"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbUni.Items.Add(myReader["University"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        public void fillStuBox()
        {
            try
            {
                myCommand.CommandText = "spGetStu"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbStudents.Items.Add(myReader["Student_Key"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        public void fillStuMajorBox()
        {
            try
            {
                myCommand.CommandText = "spGetStuMajor"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbMajor.Items.Add(myReader["Major"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        public void fillStuGenderBox()
        {
            try
            {
                myCommand.CommandText = "spGetStuGender"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbGender.Items.Add(myReader["Gender"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }


        public void fillCourseBox()
        {
            try
            {
                myCommand.CommandText = "spGetCourseDept"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbDept.Items.Add(myReader["Department"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }


        public void fillSemesterBox()
        {
            try
            {
                myCommand.CommandText = "spGetSemester"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbSemester.Items.Add(myReader["Semester"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        public void fillYearBox()
        {
            try
            {
                myCommand.CommandText = "spGetYear"; // Assuming your stored procedure name is spLogin
                myCommand.CommandType = CommandType.StoredProcedure;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cmbYear.Items.Add(myReader["Year"].ToString());

                }


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // FILL INSTUCTORS
            fillInstBox();
            fillInstFacultyBox();
            fillInstRankBox(); 
            fillInstUniBox();

            // FILL STUDENTS
            fillStuBox();
            fillStuMajorBox();
            fillStuGenderBox();

            // FILL COURSES
            fillCourseBox();


            // FILL DATE
            fillSemesterBox();
            fillYearBox();

            


        }

        // Update Strings
        private void cmbInstruct_TextChanged(object sender, EventArgs e)
        {
            Instructor = cmbInstruct.Text;
            //txtResult.Text = Instructor;
        }

        private void cmbFaculty_TextChanged(object sender, EventArgs e)
        {
            Faculty = cmbFaculty.Text;
        }

        private void cmbUni_TextChanged(object sender, EventArgs e)
        {
            University = cmbUni.Text;
        }

        private void cmbRank_TextChanged(object sender, EventArgs e)
        {
            Rank = cmbRank.Text;
        }

        private void cmbStudents_TextChanged(object sender, EventArgs e)
        {
            Students = cmbStudents.Text; 
        }

        private void cmbMajor_TextChanged(object sender, EventArgs e)
        {
            Major = cmbMajor.Text;
        }

        private void cmbGender_TextChanged(object sender, EventArgs e)
        {
            Gender = cmbGender.Text;
        }

        private void cmbDept_TextChanged(object sender, EventArgs e)
        {
            Department = cmbDept.Text;
        }

        private void cmbSemester_TextChanged(object sender, EventArgs e)
        {
            Semester = cmbSemester.Text;
        }

        private void cmbYear_TextChanged(object sender, EventArgs e)
        {
            Year = cmbYear.Text;
        }
    }
}
