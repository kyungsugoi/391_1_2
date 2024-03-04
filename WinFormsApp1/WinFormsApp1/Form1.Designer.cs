namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbUni = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.cmbInstruct = new System.Windows.Forms.ComboBox();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(68, 646);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(229, 36);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbUni
            // 
            this.cmbUni.FormattingEnabled = true;
            this.cmbUni.Items.AddRange(new object[] {
            "Any"});
            this.cmbUni.Location = new System.Drawing.Point(158, 140);
            this.cmbUni.Name = "cmbUni";
            this.cmbUni.Size = new System.Drawing.Size(136, 23);
            this.cmbUni.TabIndex = 1;
            this.cmbUni.Text = "Any";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "Any"});
            this.cmbSemester.Location = new System.Drawing.Point(158, 526);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(136, 23);
            this.cmbSemester.TabIndex = 2;
            this.cmbSemester.Text = "Any";
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Any"});
            this.cmbDept.Location = new System.Drawing.Point(158, 441);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(136, 23);
            this.cmbDept.TabIndex = 3;
            this.cmbDept.Text = "Any";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "Any"});
            this.cmbFaculty.Location = new System.Drawing.Point(158, 99);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(136, 23);
            this.cmbFaculty.TabIndex = 4;
            this.cmbFaculty.Text = "Any";
            // 
            // cmbInstruct
            // 
            this.cmbInstruct.FormattingEnabled = true;
            this.cmbInstruct.Items.AddRange(new object[] {
            "Any"});
            this.cmbInstruct.Location = new System.Drawing.Point(158, 57);
            this.cmbInstruct.Name = "cmbInstruct";
            this.cmbInstruct.Size = new System.Drawing.Size(136, 23);
            this.cmbInstruct.TabIndex = 5;
            this.cmbInstruct.Text = "Any";
            // 
            // cmbRank
            // 
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Items.AddRange(new object[] {
            "Any"});
            this.cmbRank.Location = new System.Drawing.Point(158, 180);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(136, 23);
            this.cmbRank.TabIndex = 6;
            this.cmbRank.Text = "Any";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "Any"});
            this.cmbYear.Location = new System.Drawing.Point(158, 561);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(136, 23);
            this.cmbYear.TabIndex = 7;
            this.cmbYear.Text = "Any";
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Items.AddRange(new object[] {
            "Any"});
            this.cmbStudents.Location = new System.Drawing.Point(158, 268);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(136, 23);
            this.cmbStudents.TabIndex = 8;
            this.cmbStudents.Text = "Any";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "University";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Faculty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Instructor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Students";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 701);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Results:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 698);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(136, 23);
            this.textBox1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(68, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Instructors";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(59, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "______________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(68, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Students";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(59, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "______________________________";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Major";
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Items.AddRange(new object[] {
            "Any"});
            this.cmbMajor.Location = new System.Drawing.Point(158, 311);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(136, 23);
            this.cmbMajor.TabIndex = 23;
            this.cmbMajor.Text = "Any";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(77, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Any"});
            this.cmbGender.Location = new System.Drawing.Point(158, 358);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(136, 23);
            this.cmbGender.TabIndex = 25;
            this.cmbGender.Text = "Any";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(68, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "Courses";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(59, 409);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(252, 25);
            this.label17.TabIndex = 28;
            this.label17.Text = "______________________________";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(68, 486);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 25);
            this.label18.TabIndex = 29;
            this.label18.Text = "Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(59, 495);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(252, 25);
            this.label19.TabIndex = 30;
            this.label19.Text = "______________________________";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(69, 595);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 25);
            this.label20.TabIndex = 31;
            this.label20.Text = "Results";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(60, 604);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(252, 25);
            this.label21.TabIndex = 32;
            this.label21.Text = "______________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(367, 742);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbRank);
            this.Controls.Add(this.cmbInstruct);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.cmbUni);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label11);
            this.Name = "Form1";
            this.Text = "Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private ComboBox cmbUni;
        private ComboBox cmbSemester;
        private ComboBox cmbDept;
        private ComboBox cmbFaculty;
        private ComboBox cmbInstruct;
        private ComboBox cmbRank;
        private ComboBox cmbYear;
        private ComboBox cmbStudents;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox cmbMajor;
        private Label label15;
        private ComboBox cmbGender;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
    }
}