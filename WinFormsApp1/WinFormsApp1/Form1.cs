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

        public Form1()
        {
            InitializeComponent();

            // (local) will default to your server, no need to hardcode it anymore
            //String connectionString = "Server = DESKTOP-5HTNF3D\\SQLEXPRESS; Database = 391_1_2; Trusted_Connection = yes;";
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
            fillInstFacultyBox();
            fillInstRankBox(); 
            fillInstUniBox();

            // FILL STUDENTS
            fillStuMajorBox();
            fillStuGenderBox();

            // FILL COURSES
            fillCourseBox();


            // FILL DATE
            fillSemesterBox();
            fillYearBox();

            


        }
    }
}
