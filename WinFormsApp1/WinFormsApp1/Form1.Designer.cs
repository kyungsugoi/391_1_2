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
            btnSearch = new Button();
            cmbUni = new ComboBox();
            cmbSemester = new ComboBox();
            cmbDept = new ComboBox();
            cmbFaculty = new ComboBox();
            cmbInstruct = new ComboBox();
            cmbRank = new ComboBox();
            cmbYear = new ComboBox();
            cmbStudents = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtResult = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            cmbMajor = new ComboBox();
            label15 = new Label();
            cmbGender = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(126, 1378);
            btnSearch.Margin = new Padding(6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(425, 77);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbUni
            // 
            cmbUni.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUni.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUni.FormattingEnabled = true;
            cmbUni.Items.AddRange(new object[] { "Any" });
            cmbUni.Location = new Point(293, 299);
            cmbUni.Margin = new Padding(6);
            cmbUni.Name = "cmbUni";
            cmbUni.Size = new Size(249, 40);
            cmbUni.TabIndex = 1;
            cmbUni.Text = "Any";
            cmbUni.TextChanged += cmbUni_TextChanged;
            // 
            // cmbSemester
            // 
            cmbSemester.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSemester.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Items.AddRange(new object[] { "Any" });
            cmbSemester.Location = new Point(293, 1122);
            cmbSemester.Margin = new Padding(6);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(249, 40);
            cmbSemester.TabIndex = 2;
            cmbSemester.Text = "Any";
            cmbSemester.TextChanged += cmbSemester_TextChanged;
            // 
            // cmbDept
            // 
            cmbDept.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDept.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDept.FormattingEnabled = true;
            cmbDept.Items.AddRange(new object[] { "Any" });
            cmbDept.Location = new Point(293, 941);
            cmbDept.Margin = new Padding(6);
            cmbDept.Name = "cmbDept";
            cmbDept.Size = new Size(249, 40);
            cmbDept.TabIndex = 3;
            cmbDept.Text = "Any";
            cmbDept.TextChanged += cmbDept_TextChanged;
            // 
            // cmbFaculty
            // 
            cmbFaculty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbFaculty.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFaculty.FormattingEnabled = true;
            cmbFaculty.Items.AddRange(new object[] { "Any" });
            cmbFaculty.Location = new Point(293, 211);
            cmbFaculty.Margin = new Padding(6);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(249, 40);
            cmbFaculty.TabIndex = 4;
            cmbFaculty.Text = "Any";
            cmbFaculty.TextChanged += cmbFaculty_TextChanged;
            // 
            // cmbInstruct
            // 
            cmbInstruct.FormattingEnabled = true;
            cmbInstruct.Items.AddRange(new object[] { "Any" });
            cmbInstruct.Location = new Point(293, 122);
            cmbInstruct.Margin = new Padding(6);
            cmbInstruct.Name = "cmbInstruct";
            cmbInstruct.Size = new Size(249, 40);
            cmbInstruct.TabIndex = 5;
            cmbInstruct.Text = "Any";
            cmbInstruct.TextChanged += cmbInstruct_TextChanged;
            // 
            // cmbRank
            // 
            cmbRank.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRank.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbRank.FormattingEnabled = true;
            cmbRank.Items.AddRange(new object[] { "Any" });
            cmbRank.Location = new Point(293, 384);
            cmbRank.Margin = new Padding(6);
            cmbRank.Name = "cmbRank";
            cmbRank.Size = new Size(249, 40);
            cmbRank.TabIndex = 6;
            cmbRank.Text = "Any";
            cmbRank.TextChanged += cmbRank_TextChanged;
            // 
            // cmbYear
            // 
            cmbYear.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbYear.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbYear.FormattingEnabled = true;
            cmbYear.Items.AddRange(new object[] { "Any" });
            cmbYear.Location = new Point(293, 1197);
            cmbYear.Margin = new Padding(6);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(249, 40);
            cmbYear.TabIndex = 7;
            cmbYear.Text = "Any";
            cmbYear.TextChanged += cmbYear_TextChanged;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Items.AddRange(new object[] { "Any" });
            cmbStudents.Location = new Point(293, 572);
            cmbStudents.Margin = new Padding(6);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(249, 40);
            cmbStudents.TabIndex = 8;
            cmbStudents.Text = "Any";
            cmbStudents.TextChanged += cmbStudents_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 305);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 9;
            label1.Text = "University";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 218);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 10;
            label2.Text = "Faculty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 947);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 11;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 128);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 12;
            label4.Text = "Instructor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 390);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 32);
            label5.TabIndex = 13;
            label5.Text = "Rank";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 1129);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 32);
            label6.TabIndex = 14;
            label6.Text = "Semester";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 1203);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 32);
            label7.TabIndex = 15;
            label7.Text = "Year";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(143, 578);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(107, 32);
            label8.TabIndex = 16;
            label8.Text = "Students";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(126, 1495);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 32);
            label9.TabIndex = 17;
            label9.Text = "Results:";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(299, 1489);
            txtResult.Margin = new Padding(6);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(249, 39);
            txtResult.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(126, 19);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(215, 51);
            label10.TabIndex = 19;
            label10.Text = "Instructors";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(110, 38);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(502, 51);
            label11.TabIndex = 20;
            label11.Text = "______________________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(126, 467);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(180, 51);
            label12.TabIndex = 21;
            label12.Text = "Students";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(110, 486);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(502, 51);
            label13.TabIndex = 22;
            label13.Text = "______________________________";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(143, 670);
            label14.Margin = new Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new Size(76, 32);
            label14.TabIndex = 24;
            label14.Text = "Major";
            // 
            // cmbMajor
            // 
            cmbMajor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMajor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMajor.FormattingEnabled = true;
            cmbMajor.Items.AddRange(new object[] { "Any" });
            cmbMajor.Location = new Point(293, 663);
            cmbMajor.Margin = new Padding(6);
            cmbMajor.Name = "cmbMajor";
            cmbMajor.Size = new Size(249, 40);
            cmbMajor.TabIndex = 23;
            cmbMajor.Text = "Any";
            cmbMajor.TextChanged += cmbMajor_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(143, 770);
            label15.Margin = new Padding(6, 0, 6, 0);
            label15.Name = "label15";
            label15.Size = new Size(92, 32);
            label15.TabIndex = 26;
            label15.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Any" });
            cmbGender.Location = new Point(293, 764);
            cmbGender.Margin = new Padding(6);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(249, 40);
            cmbGender.TabIndex = 25;
            cmbGender.Text = "Any";
            cmbGender.TextChanged += cmbGender_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(126, 853);
            label16.Margin = new Padding(6, 0, 6, 0);
            label16.Name = "label16";
            label16.Size = new Size(162, 51);
            label16.TabIndex = 27;
            label16.Text = "Courses";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(110, 873);
            label17.Margin = new Padding(6, 0, 6, 0);
            label17.Name = "label17";
            label17.Size = new Size(502, 51);
            label17.TabIndex = 28;
            label17.Text = "______________________________";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(126, 1037);
            label18.Margin = new Padding(6, 0, 6, 0);
            label18.Name = "label18";
            label18.Size = new Size(106, 51);
            label18.TabIndex = 29;
            label18.Text = "Date";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(110, 1056);
            label19.Margin = new Padding(6, 0, 6, 0);
            label19.Name = "label19";
            label19.Size = new Size(502, 51);
            label19.TabIndex = 30;
            label19.Text = "______________________________";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(128, 1269);
            label20.Margin = new Padding(6, 0, 6, 0);
            label20.Name = "label20";
            label20.Size = new Size(150, 51);
            label20.TabIndex = 31;
            label20.Text = "Results";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(111, 1289);
            label21.Margin = new Padding(6, 0, 6, 0);
            label21.Name = "label21";
            label21.Size = new Size(502, 51);
            label21.TabIndex = 32;
            label21.Text = "______________________________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(10, 10);
            BackColor = Color.MistyRose;
            ClientSize = new Size(682, 1583);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(cmbGender);
            Controls.Add(label14);
            Controls.Add(cmbMajor);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(txtResult);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbStudents);
            Controls.Add(cmbYear);
            Controls.Add(cmbRank);
            Controls.Add(cmbInstruct);
            Controls.Add(cmbFaculty);
            Controls.Add(cmbDept);
            Controls.Add(cmbSemester);
            Controls.Add(cmbUni);
            Controls.Add(btnSearch);
            Controls.Add(label11);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Data Viewer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtResult;
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