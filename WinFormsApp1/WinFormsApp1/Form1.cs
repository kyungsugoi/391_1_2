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
            String connectionString = "Server = DESKTOP-5HTNF3D\\SQLEXPRESS; Database = 391_1_2; Trusted_Connection = yes;";
            //String connectionString = "Server = (local); Database = 391_1_2; Trusted_Connection = yes;";

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
