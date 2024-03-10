using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        // Strings For Building
        public String Instructor = "Any";
        public String Faculty = "Any";
        public String University = "Any";
        public String Rank = "Any";

        public String Student = "Any";
        public String Major = "Any";
        public String Gender = "Any";

        public String Department = "Any";

        public String Semester = "Any";
        public String Year = "Any";
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();


        public Form1()
        {
            InitializeComponent();

            try
            {
                // (local) will default to your server, no need to hardcode it anymore
                String connectionString = "Server = (local); Database = 391_1_2; Trusted_Connection = yes;";
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
            }
            catch
            {
                String connectionString = "Server = DESKTOP-5HTNF3D\\SQLEXPRESS; Database = 391_1_2; Trusted_Connection = yes;";
                myConnection = new SqlConnection(connectionString);

                try
                {
                    myConnection.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error");
                    this.Close();
                }
            }

            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // no need to connect to the server again, we're already connected from above
            StringBuilder query = new StringBuilder();

            // Initial query for empty selections
            query.Append("SELECT COUNT(Total_Courses) FROM CoursesTaken CT");

            // FROM string builder
            StringBuilder fromQuery = new StringBuilder();

            // WHERE string builder
            StringBuilder whereQuery = new StringBuilder();
            String delimiter = " WHERE ";

            if (cmbInstruct.SelectedIndex != 0)
            {
                whereQuery.Append(delimiter).Append("CT.Instructor_Key = '" + Instructor + "'");
                delimiter = " AND ";
            }

            // Instructor Table dynamic conditions
            if (cmbFaculty.SelectedIndex != 0 || cmbUni.SelectedIndex != 0 || cmbRank.SelectedIndex != 0)
            {
                fromQuery.Append(", Instructors I");
                whereQuery.Append(delimiter).Append("CT.Instructor_Key = I.Instructor_Key");
                delimiter = " AND ";

                // Check to see which cmb is not index 0 then put a where clause for it
                if (cmbFaculty.SelectedIndex != 0)
                {
                    whereQuery.Append(delimiter).Append("I.Faculty = '" + Faculty + "'");
                }
                if (cmbUni.SelectedIndex != 0)
                {
                    whereQuery.Append(delimiter).Append("I.University = '" + University + "'");
                }
                if (cmbRank.SelectedIndex != 0)
                {
                    whereQuery.Append(delimiter).Append("I.Rank = '" + Rank + "'");
                }
            }

            if (cmbStudents.SelectedIndex != 0)
            {
                whereQuery.Append(delimiter).Append("CT.Student_Key = '" + Student + "'");
                delimiter = " AND ";
            }

            // Student Table dynamic conditions
            if (cmbMajor.SelectedIndex != 0 || cmbGender.SelectedIndex != 0)
            {
                fromQuery.Append(", Students S");
                whereQuery.Append(delimiter).Append("CT.Student_Key = S.Student_Key");
                delimiter = " AND ";

                // Check to see which cmb is not index 0 then put a where clause for it
                if (cmbMajor.SelectedIndex != 0)
                {
                    whereQuery.Append(delimiter).Append("S.Major = '" + Major + "'");
                }
                if (cmbGender.SelectedIndex != 0)
                {
                    whereQuery.Append(delimiter).Append("S.Gender = '" + Gender + "'");
                }
            }

            // Courses Table dynamic conditions
            if (cmbDept.SelectedIndex != 0)
            {
                fromQuery.Append(", Courses C");
                whereQuery.Append(delimiter).Append("CT.Course_Key = C.Course_Key");
                delimiter = " AND ";
                whereQuery.Append(delimiter).Append("C.Department = '" + Department + "'");
            }

            // Date Table dynamic conditions
            if (cmbSemester.SelectedIndex != 0 || cmbYear.SelectedIndex != 0)
            {
                fromQuery.Append(", Date D");
                whereQuery.Append(delimiter).Append("CT.Date_Key = D.Date_Key");
                delimiter = " AND ";

                // Check to see which cmb is not index 0 then put a where clause for it
                if (cmbSemester.SelectedIndex != 0)
                {
                    whereQuery.Append(delimiter).Append("D.Semester = '" + Semester + "'");
                }
                if (cmbYear.SelectedIndex != 0)
                {
                    whereQuery.Append(delimiter).Append("D.Year = '" + Year + "'");
                }
            }

            query.Append(fromQuery);
            if (whereQuery.Length > 0)
            {
                query.Append(whereQuery);
            }

            try
            {
                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                int total = (int) command.ExecuteScalar();

                txtResult.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(query.ToString() + "\n\n" + ex.ToString(), "Error");
                this.Close();
            }
        }

        public void fillInstFacultyBox()
        {
            try
            {
                myCommand.CommandText = "spGetInstFaculty"; // Assuming your stored procedure name is spGetInstFaculty
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
                myCommand.CommandText = "spGetInst"; // Assuming your stored procedure name is spGetInst
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
                myCommand.CommandText = "spGetInstRank"; // Assuming your stored procedure name is spGetInstRank
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
                myCommand.CommandText = "spGetInstUni"; // Assuming your stored procedure name is spGetInstUni
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
                myCommand.CommandText = "spGetStu"; // Assuming your stored procedure name is spGetStu
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
                myCommand.CommandText = "spGetStuMajor"; // Assuming your stored procedure name is spGetStuMajor
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
                myCommand.CommandText = "spGetStuGender"; // Assuming your stored procedure name is spGetStuGender
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
                myCommand.CommandText = "spGetCourseDept"; // Assuming your stored procedure name is spGetCourseDept
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
                myCommand.CommandText = "spGetSemester"; // Assuming your stored procedure name is spGetSemester
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
                myCommand.CommandText = "spGetYear"; // Assuming your stored procedure name is spGetYear
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
            Student = cmbStudents.Text; 
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.Title = "Select an XML File";

            // Show the dialog and check if the user selected a file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                var filePath = openFileDialog1.FileName;

                try
                {
                    // Load the XML file
                    XDocument xmlDoc = XDocument.Load(filePath);

                    // Example of processing the XML file
                    // Here, we'll just print the XML to the console.
                    // You might want to process it as per your needs.
                    Console.WriteLine(xmlDoc.ToString());
                    MessageBox.Show(xmlDoc.ToString());

                    // If you need to access specific elements, you can query the document. For example:
                    // var myElements = xmlDoc.Root.Elements("MyElementName");
                    // foreach (var elem in myElements)
                    // {
                    //     Console.WriteLine(elem.Value);
                    // }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading the XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
