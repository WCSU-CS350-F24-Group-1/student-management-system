namespace SMS_Frontend
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "John Doe", "12345678", "3.25", "Computer Science", "8/24/1989", "(860) 555-0172", "johndoe@example.com", "1600 Pennsylvania Ave. NW, Washington, DC" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Billy Mays", "98765432", "1.59", "Marketing", "1/1/1933", "(233) 555-0195", "bilmays@example.com", "181 White St, Danbury, CT" }, -1);
            lstStudents = new ListView();
            colName = new ColumnHeader();
            colID = new ColumnHeader();
            colGPA = new ColumnHeader();
            colMajor = new ColumnHeader();
            colDOB = new ColumnHeader();
            colPhone = new ColumnHeader();
            colEmail = new ColumnHeader();
            colAddress = new ColumnHeader();
            txtStudentQuery = new TextBox();
            btnStudentSearch = new Button();
            txtClassQuery = new TextBox();
            btnClassSearch = new Button();
            btnLogout = new Button();
            prgProcessingIndicator = new ProgressBar();
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            btnEditStudent = new Button();
            lstClasses = new ListView();
            colClassName = new ColumnHeader();
            btnEditEnrollment = new Button();
            btnEditClass = new Button();
            btnRemoveClass = new Button();
            btnAddClass = new Button();
            btnViewUsers = new Button();
            SuspendLayout();
            // 
            // lstStudents
            // 
            lstStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstStudents.Columns.AddRange(new ColumnHeader[] { colName, colID, colGPA, colMajor, colDOB, colPhone, colEmail, colAddress });
            lstStudents.FullRowSelect = true;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            lstStudents.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6 });
            lstStudents.Location = new Point(9, 76);
            lstStudents.Name = "lstStudents";
            lstStudents.ShowGroups = false;
            lstStudents.Size = new Size(614, 342);
            lstStudents.TabIndex = 0;
            lstStudents.UseCompatibleStateImageBehavior = false;
            lstStudents.View = View.Details;
            // 
            // colName
            // 
            colName.Text = "Student Name";
            colName.Width = 100;
            // 
            // colID
            // 
            colID.Text = "ID";
            colID.Width = 75;
            // 
            // colGPA
            // 
            colGPA.Text = "GPA";
            colGPA.Width = 36;
            // 
            // colMajor
            // 
            colMajor.Text = "Major";
            colMajor.Width = 120;
            // 
            // colDOB
            // 
            colDOB.Text = "Date of Birth";
            colDOB.Width = 80;
            // 
            // colPhone
            // 
            colPhone.Text = "Phone #";
            colPhone.Width = 100;
            // 
            // colEmail
            // 
            colEmail.Text = "E-mail";
            colEmail.Width = 150;
            // 
            // colAddress
            // 
            colAddress.Text = "Address";
            colAddress.Width = 250;
            // 
            // txtStudentQuery
            // 
            txtStudentQuery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentQuery.Location = new Point(9, 9);
            txtStudentQuery.Margin = new Padding(0, 0, 3, 3);
            txtStudentQuery.Name = "txtStudentQuery";
            txtStudentQuery.PlaceholderText = "Search for a student's name or ID...";
            txtStudentQuery.Size = new Size(510, 23);
            txtStudentQuery.TabIndex = 1;
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStudentSearch.Location = new Point(525, 9);
            btnStudentSearch.Margin = new Padding(3, 0, 0, 3);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(98, 23);
            btnStudentSearch.TabIndex = 0;
            btnStudentSearch.Text = "Student Search";
            btnStudentSearch.UseVisualStyleBackColor = true;
            // 
            // txtClassQuery
            // 
            txtClassQuery.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtClassQuery.Location = new Point(629, 9);
            txtClassQuery.Margin = new Padding(0, 0, 3, 3);
            txtClassQuery.Name = "txtClassQuery";
            txtClassQuery.PlaceholderText = "Search for a class...";
            txtClassQuery.Size = new Size(203, 23);
            txtClassQuery.TabIndex = 2;
            // 
            // btnClassSearch
            // 
            btnClassSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClassSearch.Location = new Point(838, 9);
            btnClassSearch.Margin = new Padding(3, 0, 0, 3);
            btnClassSearch.Name = "btnClassSearch";
            btnClassSearch.Size = new Size(85, 23);
            btnClassSearch.TabIndex = 1;
            btnClassSearch.Text = "Class Search";
            btnClassSearch.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.Location = new Point(863, 424);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(60, 25);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // prgProcessingIndicator
            // 
            prgProcessingIndicator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prgProcessingIndicator.Enabled = false;
            prgProcessingIndicator.Location = new Point(147, 424);
            prgProcessingIndicator.MarqueeAnimationSpeed = 50;
            prgProcessingIndicator.Name = "prgProcessingIndicator";
            prgProcessingIndicator.Size = new Size(710, 25);
            prgProcessingIndicator.Step = 0;
            prgProcessingIndicator.Style = ProgressBarStyle.Marquee;
            prgProcessingIndicator.TabIndex = 2;
            // 
            // btnAddStudent
            // 
            btnAddStudent.AutoSize = true;
            btnAddStudent.Location = new Point(9, 38);
            btnAddStudent.MinimumSize = new Size(0, 32);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(83, 32);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.AutoSize = true;
            btnRemoveStudent.Location = new Point(98, 38);
            btnRemoveStudent.MinimumSize = new Size(0, 32);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(104, 32);
            btnRemoveStudent.TabIndex = 4;
            btnRemoveStudent.Text = "Remove Student";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            // 
            // btnEditStudent
            // 
            btnEditStudent.AutoSize = true;
            btnEditStudent.Location = new Point(208, 38);
            btnEditStudent.MinimumSize = new Size(0, 32);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(105, 32);
            btnEditStudent.TabIndex = 5;
            btnEditStudent.Text = "Edit Student Info";
            btnEditStudent.UseVisualStyleBackColor = true;
            // 
            // lstClasses
            // 
            lstClasses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstClasses.Columns.AddRange(new ColumnHeader[] { colClassName });
            lstClasses.Location = new Point(629, 76);
            lstClasses.Name = "lstClasses";
            lstClasses.Size = new Size(294, 342);
            lstClasses.TabIndex = 6;
            lstClasses.UseCompatibleStateImageBehavior = false;
            lstClasses.View = View.Details;
            // 
            // colClassName
            // 
            colClassName.Text = "Class Name";
            colClassName.Width = 100;
            // 
            // btnEditEnrollment
            // 
            btnEditEnrollment.AutoSize = true;
            btnEditEnrollment.Location = new Point(319, 38);
            btnEditEnrollment.MinimumSize = new Size(0, 32);
            btnEditEnrollment.Name = "btnEditEnrollment";
            btnEditEnrollment.Size = new Size(184, 32);
            btnEditEnrollment.TabIndex = 7;
            btnEditEnrollment.Text = "Change Enrollment for Selected";
            btnEditEnrollment.UseVisualStyleBackColor = true;
            // 
            // btnEditClass
            // 
            btnEditClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditClass.AutoSize = true;
            btnEditClass.Location = new Point(832, 38);
            btnEditClass.MinimumSize = new Size(0, 32);
            btnEditClass.Name = "btnEditClass";
            btnEditClass.Size = new Size(91, 32);
            btnEditClass.TabIndex = 10;
            btnEditClass.Text = "Edit Class Info";
            btnEditClass.UseVisualStyleBackColor = true;
            // 
            // btnRemoveClass
            // 
            btnRemoveClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoveClass.AutoSize = true;
            btnRemoveClass.Location = new Point(736, 38);
            btnRemoveClass.MinimumSize = new Size(0, 32);
            btnRemoveClass.Name = "btnRemoveClass";
            btnRemoveClass.Size = new Size(90, 32);
            btnRemoveClass.TabIndex = 9;
            btnRemoveClass.Text = "Remove Class";
            btnRemoveClass.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            btnAddClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddClass.AutoSize = true;
            btnAddClass.Location = new Point(661, 38);
            btnAddClass.MinimumSize = new Size(0, 32);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(69, 32);
            btnAddClass.TabIndex = 8;
            btnAddClass.Text = "Add Class";
            btnAddClass.UseVisualStyleBackColor = true;
            // 
            // btnViewUsers
            // 
            btnViewUsers.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnViewUsers.AutoSize = true;
            btnViewUsers.Location = new Point(9, 424);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(132, 25);
            btnViewUsers.TabIndex = 11;
            btnViewUsers.Text = "View Users/Professors";
            btnViewUsers.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 461);
            Controls.Add(btnViewUsers);
            Controls.Add(btnEditClass);
            Controls.Add(btnRemoveClass);
            Controls.Add(btnAddClass);
            Controls.Add(btnEditEnrollment);
            Controls.Add(lstClasses);
            Controls.Add(btnEditStudent);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(prgProcessingIndicator);
            Controls.Add(btnLogout);
            Controls.Add(lstStudents);
            Controls.Add(txtStudentQuery);
            Controls.Add(btnStudentSearch);
            Controls.Add(txtClassQuery);
            Controls.Add(btnClassSearch);
            MinimumSize = new Size(400, 300);
            Name = "MainForm";
            Text = "Main";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnStudentSearch;
        private Button btnLogout;
        private ProgressBar prgProcessingIndicator;
        private TextBox txtStudentQuery;
        private TextBox txtClassQuery;
        private Button btnClassSearch;
        private ListView lstStudents;
        private ColumnHeader colName;
        private ColumnHeader colID;
        private ColumnHeader colGPA;
        private ColumnHeader colMajor;
        private ColumnHeader colPhone;
        private ColumnHeader colEmail;
        private ColumnHeader colDOB;
        private ColumnHeader colAddress;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
        private Button btnEditStudent;
        private ListView lstClasses;
        private ColumnHeader colClassName;
        private Button btnEditEnrollment;
        private Button btnEditClass;
        private Button btnRemoveClass;
        private Button btnAddClass;
        private Button btnViewUsers;
    }
}