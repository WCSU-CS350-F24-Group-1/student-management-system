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
            txtStudentQuery = new TextBox();
            btnStudentSearch = new Button();
            txtClassQuery = new TextBox();
            btnClassSearch = new Button();
            btnLogout = new Button();
            prgProcessingIndicator = new ProgressBar();
            btnAddStudent = new Button();
            btnAddClass = new Button();
            btnViewUsers = new Button();
            splitContainer = new SplitContainer();
            lblStudentResult = new Label();
            lstStudentResults = new ListBox();
            grpStudentsProperties = new GroupBox();
            pnlStudentInfo = new Panel();
            numStudentCredits = new NumericUpDown();
            lblStudentCredits = new Label();
            numStudentGPA = new NumericUpDown();
            txtStudentGPA = new Label();
            txtStudentPhone = new MaskedTextBox();
            lblStudentPhone = new Label();
            txtStudentEmail = new TextBox();
            lblStudentEmail = new Label();
            txtStudentMajor = new TextBox();
            lblStudentMajor = new Label();
            dteStudentDOB = new DateTimePicker();
            lblStudentDOB = new Label();
            txtStudentName = new TextBox();
            lblStudentName = new Label();
            numStudentID = new NumericUpDown();
            lblStudentID = new Label();
            lblStudentEnrollment = new Label();
            clbStudentEnrollment = new CheckedListBox();
            btnDelStudent = new Button();
            lblClassResult = new Label();
            lstClassResults = new ListBox();
            grpClassProperties = new GroupBox();
            lblClassName = new Label();
            txtClassName = new TextBox();
            lblClassCredits = new Label();
            numClassCredits = new NumericUpDown();
            lblClassProf = new Label();
            txtClassProf = new TextBox();
            btnDelClass = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            grpStudentsProperties.SuspendLayout();
            pnlStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStudentCredits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStudentGPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStudentID).BeginInit();
            grpClassProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numClassCredits).BeginInit();
            SuspendLayout();
            // 
            // txtStudentQuery
            // 
            txtStudentQuery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentQuery.Location = new Point(-1, -1);
            txtStudentQuery.Margin = new Padding(0, 0, 3, 3);
            txtStudentQuery.Name = "txtStudentQuery";
            txtStudentQuery.PlaceholderText = "Search for a student's name or ID...";
            txtStudentQuery.Size = new Size(250, 23);
            txtStudentQuery.TabIndex = 1;
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStudentSearch.Location = new Point(255, -2);
            btnStudentSearch.Margin = new Padding(3, 0, 0, 3);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(192, 25);
            btnStudentSearch.TabIndex = 0;
            btnStudentSearch.Text = "Student Search";
            btnStudentSearch.UseVisualStyleBackColor = true;
            // 
            // txtClassQuery
            // 
            txtClassQuery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClassQuery.Font = new Font("Segoe UI", 9F);
            txtClassQuery.Location = new Point(-1, -1);
            txtClassQuery.Margin = new Padding(0, 0, 3, 3);
            txtClassQuery.Name = "txtClassQuery";
            txtClassQuery.PlaceholderText = "Search for a class...";
            txtClassQuery.Size = new Size(252, 23);
            txtClassQuery.TabIndex = 2;
            // 
            // btnClassSearch
            // 
            btnClassSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClassSearch.Location = new Point(257, -2);
            btnClassSearch.Margin = new Padding(3, 0, 0, 3);
            btnClassSearch.Name = "btnClassSearch";
            btnClassSearch.Size = new Size(197, 25);
            btnClassSearch.TabIndex = 1;
            btnClassSearch.Text = "Class Search";
            btnClassSearch.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.Location = new Point(860, 424);
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
            prgProcessingIndicator.Location = new Point(150, 424);
            prgProcessingIndicator.MarqueeAnimationSpeed = 50;
            prgProcessingIndicator.Name = "prgProcessingIndicator";
            prgProcessingIndicator.Size = new Size(704, 25);
            prgProcessingIndicator.Step = 0;
            prgProcessingIndicator.TabIndex = 2;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddStudent.Location = new Point(255, 29);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(81, 25);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            btnAddClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddClass.AutoSize = true;
            btnAddClass.Location = new Point(257, 29);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(83, 25);
            btnAddClass.TabIndex = 8;
            btnAddClass.Text = "Add Class";
            btnAddClass.UseVisualStyleBackColor = true;
            // 
            // btnViewUsers
            // 
            btnViewUsers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewUsers.AutoSize = true;
            btnViewUsers.Location = new Point(12, 424);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(132, 25);
            btnViewUsers.TabIndex = 11;
            btnViewUsers.Text = "View Users/Professors";
            btnViewUsers.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer.BorderStyle = BorderStyle.FixedSingle;
            splitContainer.Location = new Point(12, 12);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(lblStudentResult);
            splitContainer.Panel1.Controls.Add(lstStudentResults);
            splitContainer.Panel1.Controls.Add(grpStudentsProperties);
            splitContainer.Panel1.Controls.Add(btnAddStudent);
            splitContainer.Panel1.Controls.Add(btnDelStudent);
            splitContainer.Panel1.Controls.Add(btnStudentSearch);
            splitContainer.Panel1.Controls.Add(txtStudentQuery);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(lblClassResult);
            splitContainer.Panel2.Controls.Add(lstClassResults);
            splitContainer.Panel2.Controls.Add(grpClassProperties);
            splitContainer.Panel2.Controls.Add(btnAddClass);
            splitContainer.Panel2.Controls.Add(btnDelClass);
            splitContainer.Panel2.Controls.Add(btnClassSearch);
            splitContainer.Panel2.Controls.Add(txtClassQuery);
            splitContainer.Size = new Size(908, 406);
            splitContainer.SplitterDistance = 447;
            splitContainer.SplitterWidth = 6;
            splitContainer.TabIndex = 12;
            // 
            // lblStudentResult
            // 
            lblStudentResult.AutoSize = true;
            lblStudentResult.Location = new Point(3, 34);
            lblStudentResult.Name = "lblStudentResult";
            lblStudentResult.Size = new Size(82, 15);
            lblStudentResult.TabIndex = 11;
            lblStudentResult.Text = "Search Results";
            // 
            // lstStudentResults
            // 
            lstStudentResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstStudentResults.FormattingEnabled = true;
            lstStudentResults.HorizontalScrollbar = true;
            lstStudentResults.IntegralHeight = false;
            lstStudentResults.ItemHeight = 15;
            lstStudentResults.Items.AddRange(new object[] { "Daniel Coffman", "Jeff Bezos", "Joe Biden", "Ronan Banton" });
            lstStudentResults.Location = new Point(3, 60);
            lstStudentResults.Name = "lstStudentResults";
            lstStudentResults.SelectionMode = SelectionMode.MultiExtended;
            lstStudentResults.Size = new Size(246, 341);
            lstStudentResults.TabIndex = 10;
            // 
            // grpStudentsProperties
            // 
            grpStudentsProperties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpStudentsProperties.Controls.Add(pnlStudentInfo);
            grpStudentsProperties.Controls.Add(lblStudentEnrollment);
            grpStudentsProperties.Controls.Add(clbStudentEnrollment);
            grpStudentsProperties.Location = new Point(255, 60);
            grpStudentsProperties.Name = "grpStudentsProperties";
            grpStudentsProperties.Size = new Size(187, 341);
            grpStudentsProperties.TabIndex = 4;
            grpStudentsProperties.TabStop = false;
            grpStudentsProperties.Text = "Student Info";
            // 
            // pnlStudentInfo
            // 
            pnlStudentInfo.AutoSize = true;
            pnlStudentInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlStudentInfo.Controls.Add(numStudentCredits);
            pnlStudentInfo.Controls.Add(lblStudentCredits);
            pnlStudentInfo.Controls.Add(numStudentGPA);
            pnlStudentInfo.Controls.Add(txtStudentGPA);
            pnlStudentInfo.Controls.Add(txtStudentPhone);
            pnlStudentInfo.Controls.Add(lblStudentPhone);
            pnlStudentInfo.Controls.Add(txtStudentEmail);
            pnlStudentInfo.Controls.Add(lblStudentEmail);
            pnlStudentInfo.Controls.Add(txtStudentMajor);
            pnlStudentInfo.Controls.Add(lblStudentMajor);
            pnlStudentInfo.Controls.Add(dteStudentDOB);
            pnlStudentInfo.Controls.Add(lblStudentDOB);
            pnlStudentInfo.Controls.Add(txtStudentName);
            pnlStudentInfo.Controls.Add(lblStudentName);
            pnlStudentInfo.Controls.Add(numStudentID);
            pnlStudentInfo.Controls.Add(lblStudentID);
            pnlStudentInfo.Enabled = false;
            pnlStudentInfo.Location = new Point(5, 15);
            pnlStudentInfo.Name = "pnlStudentInfo";
            pnlStudentInfo.Size = new Size(180, 202);
            pnlStudentInfo.TabIndex = 18;
            // 
            // numStudentCredits
            // 
            numStudentCredits.DecimalPlaces = 1;
            numStudentCredits.Location = new Point(130, 176);
            numStudentCredits.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numStudentCredits.Name = "numStudentCredits";
            numStudentCredits.Size = new Size(47, 23);
            numStudentCredits.TabIndex = 16;
            // 
            // lblStudentCredits
            // 
            lblStudentCredits.Location = new Point(83, 176);
            lblStudentCredits.Margin = new Padding(3, 0, 0, 0);
            lblStudentCredits.Name = "lblStudentCredits";
            lblStudentCredits.Size = new Size(44, 23);
            lblStudentCredits.TabIndex = 9;
            lblStudentCredits.Text = "Credits";
            lblStudentCredits.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numStudentGPA
            // 
            numStudentGPA.DecimalPlaces = 2;
            numStudentGPA.Location = new Point(34, 176);
            numStudentGPA.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numStudentGPA.Name = "numStudentGPA";
            numStudentGPA.Size = new Size(43, 23);
            numStudentGPA.TabIndex = 15;
            // 
            // txtStudentGPA
            // 
            txtStudentGPA.Location = new Point(2, 176);
            txtStudentGPA.Margin = new Padding(3, 0, 0, 0);
            txtStudentGPA.Name = "txtStudentGPA";
            txtStudentGPA.Size = new Size(29, 23);
            txtStudentGPA.TabIndex = 8;
            txtStudentGPA.Text = "GPA";
            txtStudentGPA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStudentPhone
            // 
            txtStudentPhone.Location = new Point(46, 147);
            txtStudentPhone.Mask = "(999) 000-0000";
            txtStudentPhone.Name = "txtStudentPhone";
            txtStudentPhone.Size = new Size(131, 23);
            txtStudentPhone.TabIndex = 14;
            // 
            // lblStudentPhone
            // 
            lblStudentPhone.Location = new Point(2, 147);
            lblStudentPhone.Margin = new Padding(3, 0, 0, 0);
            lblStudentPhone.Name = "lblStudentPhone";
            lblStudentPhone.Size = new Size(41, 23);
            lblStudentPhone.TabIndex = 7;
            lblStudentPhone.Text = "Phone";
            lblStudentPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Location = new Point(46, 118);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.PlaceholderText = "E-mail address";
            txtStudentEmail.Size = new Size(131, 23);
            txtStudentEmail.TabIndex = 12;
            // 
            // lblStudentEmail
            // 
            lblStudentEmail.Location = new Point(2, 118);
            lblStudentEmail.Margin = new Padding(3, 0, 0, 0);
            lblStudentEmail.Name = "lblStudentEmail";
            lblStudentEmail.Size = new Size(41, 23);
            lblStudentEmail.TabIndex = 6;
            lblStudentEmail.Text = "E-mail";
            lblStudentEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStudentMajor
            // 
            txtStudentMajor.Location = new Point(43, 89);
            txtStudentMajor.Name = "txtStudentMajor";
            txtStudentMajor.PlaceholderText = "Major of study";
            txtStudentMajor.Size = new Size(134, 23);
            txtStudentMajor.TabIndex = 11;
            // 
            // lblStudentMajor
            // 
            lblStudentMajor.Location = new Point(2, 89);
            lblStudentMajor.Margin = new Padding(3, 0, 0, 0);
            lblStudentMajor.Name = "lblStudentMajor";
            lblStudentMajor.Size = new Size(38, 23);
            lblStudentMajor.TabIndex = 5;
            lblStudentMajor.Text = "Major";
            lblStudentMajor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dteStudentDOB
            // 
            dteStudentDOB.Format = DateTimePickerFormat.Short;
            dteStudentDOB.Location = new Point(78, 60);
            dteStudentDOB.Name = "dteStudentDOB";
            dteStudentDOB.Size = new Size(99, 23);
            dteStudentDOB.TabIndex = 2;
            // 
            // lblStudentDOB
            // 
            lblStudentDOB.Location = new Point(2, 60);
            lblStudentDOB.Margin = new Padding(3, 0, 0, 0);
            lblStudentDOB.Name = "lblStudentDOB";
            lblStudentDOB.Size = new Size(73, 23);
            lblStudentDOB.TabIndex = 4;
            lblStudentDOB.Text = "Date of Birth";
            lblStudentDOB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(44, 31);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.PlaceholderText = "Student name";
            txtStudentName.Size = new Size(133, 23);
            txtStudentName.TabIndex = 10;
            // 
            // lblStudentName
            // 
            lblStudentName.Location = new Point(2, 31);
            lblStudentName.Margin = new Padding(3, 0, 0, 0);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(39, 23);
            lblStudentName.TabIndex = 3;
            lblStudentName.Text = "Name";
            lblStudentName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numStudentID
            // 
            numStudentID.Location = new Point(23, 2);
            numStudentID.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numStudentID.Name = "numStudentID";
            numStudentID.Size = new Size(154, 23);
            numStudentID.TabIndex = 1;
            // 
            // lblStudentID
            // 
            lblStudentID.Location = new Point(2, 2);
            lblStudentID.Margin = new Padding(3, 0, 0, 0);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(18, 23);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "ID";
            lblStudentID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentEnrollment
            // 
            lblStudentEnrollment.AutoSize = true;
            lblStudentEnrollment.Location = new Point(6, 217);
            lblStudentEnrollment.Name = "lblStudentEnrollment";
            lblStudentEnrollment.Size = new Size(65, 15);
            lblStudentEnrollment.TabIndex = 17;
            lblStudentEnrollment.Text = "Enrollment";
            // 
            // clbStudentEnrollment
            // 
            clbStudentEnrollment.FormattingEnabled = true;
            clbStudentEnrollment.IntegralHeight = false;
            clbStudentEnrollment.Items.AddRange(new object[] { "CS 215", "CS 221", "CS 315", "CS 444" });
            clbStudentEnrollment.Location = new Point(6, 235);
            clbStudentEnrollment.Name = "clbStudentEnrollment";
            clbStudentEnrollment.Size = new Size(175, 94);
            clbStudentEnrollment.TabIndex = 0;
            // 
            // btnDelStudent
            // 
            btnDelStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelStudent.Location = new Point(342, 29);
            btnDelStudent.Name = "btnDelStudent";
            btnDelStudent.Size = new Size(105, 25);
            btnDelStudent.TabIndex = 12;
            btnDelStudent.Text = "Remove Selected";
            btnDelStudent.UseVisualStyleBackColor = true;
            // 
            // lblClassResult
            // 
            lblClassResult.AutoSize = true;
            lblClassResult.Location = new Point(3, 34);
            lblClassResult.Name = "lblClassResult";
            lblClassResult.Size = new Size(82, 15);
            lblClassResult.TabIndex = 13;
            lblClassResult.Text = "Search Results";
            // 
            // lstClassResults
            // 
            lstClassResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstClassResults.FormattingEnabled = true;
            lstClassResults.HorizontalScrollbar = true;
            lstClassResults.IntegralHeight = false;
            lstClassResults.ItemHeight = 15;
            lstClassResults.Items.AddRange(new object[] { "CS 215", "CS 221", "CS 315", "CS 444" });
            lstClassResults.Location = new Point(3, 60);
            lstClassResults.Name = "lstClassResults";
            lstClassResults.Size = new Size(248, 341);
            lstClassResults.TabIndex = 12;
            // 
            // grpClassProperties
            // 
            grpClassProperties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpClassProperties.Controls.Add(lblClassName);
            grpClassProperties.Controls.Add(txtClassName);
            grpClassProperties.Controls.Add(lblClassCredits);
            grpClassProperties.Controls.Add(numClassCredits);
            grpClassProperties.Controls.Add(lblClassProf);
            grpClassProperties.Controls.Add(txtClassProf);
            grpClassProperties.Location = new Point(257, 60);
            grpClassProperties.Name = "grpClassProperties";
            grpClassProperties.Size = new Size(189, 341);
            grpClassProperties.TabIndex = 9;
            grpClassProperties.TabStop = false;
            grpClassProperties.Text = "Class Info";
            // 
            // lblClassName
            // 
            lblClassName.Location = new Point(6, 16);
            lblClassName.Margin = new Padding(3, 0, 0, 0);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(39, 23);
            lblClassName.TabIndex = 17;
            lblClassName.Text = "Name";
            lblClassName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(48, 16);
            txtClassName.Name = "txtClassName";
            txtClassName.PlaceholderText = "Class name";
            txtClassName.Size = new Size(135, 23);
            txtClassName.TabIndex = 20;
            // 
            // lblClassCredits
            // 
            lblClassCredits.Location = new Point(6, 45);
            lblClassCredits.Margin = new Padding(3, 0, 0, 0);
            lblClassCredits.Name = "lblClassCredits";
            lblClassCredits.Size = new Size(74, 24);
            lblClassCredits.TabIndex = 19;
            lblClassCredits.Text = "Credit Hours";
            lblClassCredits.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numClassCredits
            // 
            numClassCredits.Location = new Point(83, 45);
            numClassCredits.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numClassCredits.Name = "numClassCredits";
            numClassCredits.Size = new Size(100, 23);
            numClassCredits.TabIndex = 22;
            // 
            // lblClassProf
            // 
            lblClassProf.Location = new Point(6, 75);
            lblClassProf.Margin = new Padding(3, 0, 0, 0);
            lblClassProf.Name = "lblClassProf";
            lblClassProf.Size = new Size(56, 23);
            lblClassProf.TabIndex = 18;
            lblClassProf.Text = "Professor";
            lblClassProf.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtClassProf
            // 
            txtClassProf.Location = new Point(65, 75);
            txtClassProf.Name = "txtClassProf";
            txtClassProf.PlaceholderText = "Professor's username";
            txtClassProf.Size = new Size(118, 23);
            txtClassProf.TabIndex = 21;
            // 
            // btnDelClass
            // 
            btnDelClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelClass.AutoSize = true;
            btnDelClass.Location = new Point(346, 29);
            btnDelClass.Name = "btnDelClass";
            btnDelClass.Size = new Size(107, 25);
            btnDelClass.TabIndex = 14;
            btnDelClass.Text = "Remove Selected";
            btnDelClass.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 461);
            Controls.Add(splitContainer);
            Controls.Add(btnViewUsers);
            Controls.Add(prgProcessingIndicator);
            Controls.Add(btnLogout);
            MinimumSize = new Size(400, 300);
            Name = "MainForm";
            Text = "Main";
            FormClosed += MainForm_FormClosed;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            grpStudentsProperties.ResumeLayout(false);
            grpStudentsProperties.PerformLayout();
            pnlStudentInfo.ResumeLayout(false);
            pnlStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStudentCredits).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStudentGPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStudentID).EndInit();
            grpClassProperties.ResumeLayout(false);
            grpClassProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numClassCredits).EndInit();
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
        private Button btnAddStudent;
        private Button btnAddClass;
        private Button btnViewUsers;
        private SplitContainer splitContainer;
        private GroupBox grpStudentsProperties;
        private GroupBox grpClassProperties;
        private ListBox lstStudentResults;
        private Label lblStudentResult;
        private Label lblClassResult;
        private ListBox lstClassResults;
        private Button btnDelClass;
        private Button btnDelStudent;
        private Label lblStudentID;
        private NumericUpDown numStudentID;
        private DateTimePicker dteStudentDOB;
        private Label lblStudentCredits;
        private Label txtStudentGPA;
        private Label lblStudentPhone;
        private Label lblStudentEmail;
        private Label lblStudentMajor;
        private Label lblStudentDOB;
        private Label lblStudentName;
        private TextBox txtStudentName;
        private TextBox txtStudentMajor;
        private NumericUpDown numStudentGPA;
        private MaskedTextBox txtStudentPhone;
        private TextBox txtStudentEmail;
        private NumericUpDown numStudentCredits;
        private Label lblStudentEnrollment;
        private CheckedListBox clbStudentEnrollment;
        private Label lblClassName;
        private TextBox txtClassName;
        private Label lblClassProf;
        private TextBox txtClassProf;
        private Label lblClassCredits;
        private NumericUpDown numClassCredits;
        private Panel pnlStudentInfo;
    }
}