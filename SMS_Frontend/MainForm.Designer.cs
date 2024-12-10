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
            TableLayoutPanel tblStudents;
            Panel pnlStudentSection;
            Panel pnlStudents;
            Panel pnlClasses;
            TableLayoutPanel tblClasses;
            Panel pnlClassSection;
            Panel pnlBottom;
            TableLayoutPanel tableLayoutPanel1;
            btnEditStudent = new Button();
            btnStudentResult = new Label();
            txtStudentQuery = new TextBox();
            btnStudentSearch = new Button();
            btnAddStudent = new Button();
            btnDelStudent = new Button();
            lstStudentResults = new ListBox();
            lstClassResults = new ListBox();
            txtClassQuery = new TextBox();
            btnClassSearch = new Button();
            btnAddClass = new Button();
            btnDelClass = new Button();
            btnEditClass = new Button();
            lblClassResult = new Label();
            btnLogout = new Button();
            prgProcessingIndicator = new ProgressBar();
            btnViewUsers = new Button();
            tblStudents = new TableLayoutPanel();
            pnlStudentSection = new Panel();
            pnlStudents = new Panel();
            pnlClasses = new Panel();
            tblClasses = new TableLayoutPanel();
            pnlClassSection = new Panel();
            pnlBottom = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tblStudents.SuspendLayout();
            pnlStudentSection.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlClasses.SuspendLayout();
            tblClasses.SuspendLayout();
            pnlClassSection.SuspendLayout();
            pnlBottom.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblStudents
            // 
            tblStudents.AutoSize = true;
            tblStudents.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblStudents.ColumnCount = 3;
            tblStudents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblStudents.ColumnStyles.Add(new ColumnStyle());
            tblStudents.ColumnStyles.Add(new ColumnStyle());
            tblStudents.Controls.Add(pnlStudentSection, 0, 1);
            tblStudents.Controls.Add(txtStudentQuery, 0, 0);
            tblStudents.Controls.Add(btnStudentSearch, 1, 0);
            tblStudents.Controls.Add(btnAddStudent, 1, 1);
            tblStudents.Controls.Add(btnDelStudent, 2, 1);
            tblStudents.Dock = DockStyle.Top;
            tblStudents.Location = new Point(0, 0);
            tblStudents.Name = "tblStudents";
            tblStudents.RowCount = 2;
            tblStudents.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStudents.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStudents.Size = new Size(463, 68);
            tblStudents.TabIndex = 13;
            // 
            // pnlStudentSection
            // 
            pnlStudentSection.AutoSize = true;
            pnlStudentSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlStudentSection.Controls.Add(btnEditStudent);
            pnlStudentSection.Controls.Add(btnStudentResult);
            pnlStudentSection.Dock = DockStyle.Fill;
            pnlStudentSection.Location = new Point(3, 37);
            pnlStudentSection.Name = "pnlStudentSection";
            pnlStudentSection.Size = new Size(247, 28);
            pnlStudentSection.TabIndex = 15;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Dock = DockStyle.Fill;
            btnEditStudent.Enabled = false;
            btnEditStudent.Location = new Point(82, 0);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(165, 28);
            btnEditStudent.TabIndex = 13;
            btnEditStudent.Text = "Student Info...";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnStudentResult
            // 
            btnStudentResult.Dock = DockStyle.Left;
            btnStudentResult.Location = new Point(0, 0);
            btnStudentResult.Margin = new Padding(3, 9, 3, 0);
            btnStudentResult.Name = "btnStudentResult";
            btnStudentResult.Size = new Size(82, 28);
            btnStudentResult.TabIndex = 11;
            btnStudentResult.Text = "Search Results";
            btnStudentResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStudentQuery
            // 
            txtStudentQuery.Dock = DockStyle.Fill;
            txtStudentQuery.Location = new Point(3, 5);
            txtStudentQuery.Margin = new Padding(3, 5, 3, 3);
            txtStudentQuery.Name = "txtStudentQuery";
            txtStudentQuery.PlaceholderText = "Search for a student's name...";
            txtStudentQuery.Size = new Size(247, 23);
            txtStudentQuery.TabIndex = 1;
            // 
            // btnStudentSearch
            // 
            tblStudents.SetColumnSpan(btnStudentSearch, 2);
            btnStudentSearch.Dock = DockStyle.Fill;
            btnStudentSearch.Location = new Point(256, 3);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(204, 28);
            btnStudentSearch.TabIndex = 0;
            btnStudentSearch.Text = "Student Search";
            btnStudentSearch.UseVisualStyleBackColor = true;
            btnStudentSearch.Click += btnStudentSearch_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Dock = DockStyle.Fill;
            btnAddStudent.Location = new Point(256, 37);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(81, 28);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDelStudent
            // 
            btnDelStudent.Dock = DockStyle.Fill;
            btnDelStudent.Enabled = false;
            btnDelStudent.Location = new Point(343, 37);
            btnDelStudent.Name = "btnDelStudent";
            btnDelStudent.Size = new Size(117, 28);
            btnDelStudent.TabIndex = 12;
            btnDelStudent.Text = "Remove Selected";
            btnDelStudent.UseVisualStyleBackColor = true;
            btnDelStudent.Click += btnDelStudent_Click;
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(lstStudentResults);
            pnlStudents.Controls.Add(tblStudents);
            pnlStudents.Dock = DockStyle.Fill;
            pnlStudents.Location = new Point(6, 6);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(463, 218);
            pnlStudents.TabIndex = 13;
            // 
            // lstStudentResults
            // 
            lstStudentResults.Dock = DockStyle.Fill;
            lstStudentResults.FormattingEnabled = true;
            lstStudentResults.HorizontalScrollbar = true;
            lstStudentResults.IntegralHeight = false;
            lstStudentResults.ItemHeight = 15;
            lstStudentResults.Items.AddRange(new object[] { "Daniel Coffman", "Jeff Bezos", "Joe Biden", "Ronan Banton" });
            lstStudentResults.Location = new Point(0, 68);
            lstStudentResults.Name = "lstStudentResults";
            lstStudentResults.Size = new Size(463, 150);
            lstStudentResults.TabIndex = 10;
            lstStudentResults.SelectedIndexChanged += lstStudentResults_SelectedIndexChanged;
            // 
            // pnlClasses
            // 
            pnlClasses.Controls.Add(lstClassResults);
            pnlClasses.Controls.Add(tblClasses);
            pnlClasses.Dock = DockStyle.Fill;
            pnlClasses.Location = new Point(475, 6);
            pnlClasses.Name = "pnlClasses";
            pnlClasses.Size = new Size(463, 218);
            pnlClasses.TabIndex = 14;
            // 
            // lstClassResults
            // 
            lstClassResults.Dock = DockStyle.Fill;
            lstClassResults.FormattingEnabled = true;
            lstClassResults.HorizontalScrollbar = true;
            lstClassResults.IntegralHeight = false;
            lstClassResults.ItemHeight = 15;
            lstClassResults.Items.AddRange(new object[] { "CS 215", "CS 221", "CS 315", "CS 444" });
            lstClassResults.Location = new Point(0, 68);
            lstClassResults.Name = "lstClassResults";
            lstClassResults.Size = new Size(463, 150);
            lstClassResults.TabIndex = 12;
            lstClassResults.SelectedIndexChanged += lstClassResults_SelectedIndexChanged;
            // 
            // tblClasses
            // 
            tblClasses.AutoSize = true;
            tblClasses.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblClasses.ColumnCount = 3;
            tblClasses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblClasses.ColumnStyles.Add(new ColumnStyle());
            tblClasses.ColumnStyles.Add(new ColumnStyle());
            tblClasses.Controls.Add(txtClassQuery, 0, 0);
            tblClasses.Controls.Add(btnClassSearch, 1, 0);
            tblClasses.Controls.Add(btnAddClass, 1, 1);
            tblClasses.Controls.Add(btnDelClass, 2, 1);
            tblClasses.Controls.Add(pnlClassSection, 0, 1);
            tblClasses.Dock = DockStyle.Top;
            tblClasses.Location = new Point(0, 0);
            tblClasses.Name = "tblClasses";
            tblClasses.RowCount = 2;
            tblClasses.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblClasses.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblClasses.Size = new Size(463, 68);
            tblClasses.TabIndex = 14;
            // 
            // txtClassQuery
            // 
            txtClassQuery.Dock = DockStyle.Fill;
            txtClassQuery.Location = new Point(3, 5);
            txtClassQuery.Margin = new Padding(3, 5, 3, 3);
            txtClassQuery.Name = "txtClassQuery";
            txtClassQuery.PlaceholderText = "Search for a course's name...";
            txtClassQuery.Size = new Size(247, 23);
            txtClassQuery.TabIndex = 1;
            // 
            // btnClassSearch
            // 
            tblClasses.SetColumnSpan(btnClassSearch, 2);
            btnClassSearch.Dock = DockStyle.Fill;
            btnClassSearch.Location = new Point(256, 3);
            btnClassSearch.Name = "btnClassSearch";
            btnClassSearch.Size = new Size(204, 28);
            btnClassSearch.TabIndex = 0;
            btnClassSearch.Text = "Course Search";
            btnClassSearch.UseVisualStyleBackColor = true;
            btnClassSearch.Click += btnClassSearch_Click;
            // 
            // btnAddClass
            // 
            btnAddClass.Dock = DockStyle.Fill;
            btnAddClass.Location = new Point(256, 37);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(81, 28);
            btnAddClass.TabIndex = 3;
            btnAddClass.Text = "Add Course";
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // btnDelClass
            // 
            btnDelClass.Dock = DockStyle.Fill;
            btnDelClass.Enabled = false;
            btnDelClass.Location = new Point(343, 37);
            btnDelClass.Name = "btnDelClass";
            btnDelClass.Size = new Size(117, 28);
            btnDelClass.TabIndex = 12;
            btnDelClass.Text = "Remove Selected";
            btnDelClass.UseVisualStyleBackColor = true;
            btnDelClass.Click += btnDelClass_Click;
            // 
            // pnlClassSection
            // 
            pnlClassSection.AutoSize = true;
            pnlClassSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlClassSection.Controls.Add(btnEditClass);
            pnlClassSection.Controls.Add(lblClassResult);
            pnlClassSection.Dock = DockStyle.Fill;
            pnlClassSection.Location = new Point(3, 37);
            pnlClassSection.Name = "pnlClassSection";
            pnlClassSection.Size = new Size(247, 28);
            pnlClassSection.TabIndex = 14;
            // 
            // btnEditClass
            // 
            btnEditClass.Dock = DockStyle.Fill;
            btnEditClass.Enabled = false;
            btnEditClass.Location = new Point(82, 0);
            btnEditClass.Name = "btnEditClass";
            btnEditClass.Size = new Size(165, 28);
            btnEditClass.TabIndex = 13;
            btnEditClass.Text = "Course Info...";
            btnEditClass.UseVisualStyleBackColor = true;
            btnEditClass.Click += btnEditClass_Click;
            // 
            // lblClassResult
            // 
            lblClassResult.Dock = DockStyle.Left;
            lblClassResult.Location = new Point(0, 0);
            lblClassResult.Margin = new Padding(3, 9, 3, 0);
            lblClassResult.Name = "lblClassResult";
            lblClassResult.Size = new Size(82, 28);
            lblClassResult.TabIndex = 11;
            lblClassResult.Text = "Search Results";
            lblClassResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBottom
            // 
            pnlBottom.AutoSize = true;
            pnlBottom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(pnlBottom, 2);
            pnlBottom.Controls.Add(btnLogout);
            pnlBottom.Controls.Add(prgProcessingIndicator);
            pnlBottom.Controls.Add(btnViewUsers);
            pnlBottom.Dock = DockStyle.Fill;
            pnlBottom.Location = new Point(6, 230);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(932, 25);
            pnlBottom.TabIndex = 15;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Location = new Point(872, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(60, 25);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // prgProcessingIndicator
            // 
            prgProcessingIndicator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prgProcessingIndicator.Enabled = false;
            prgProcessingIndicator.Location = new Point(147, 0);
            prgProcessingIndicator.Margin = new Padding(12, 3, 12, 3);
            prgProcessingIndicator.MarqueeAnimationSpeed = 50;
            prgProcessingIndicator.Name = "prgProcessingIndicator";
            prgProcessingIndicator.Size = new Size(710, 25);
            prgProcessingIndicator.Step = 0;
            prgProcessingIndicator.TabIndex = 2;
            // 
            // btnViewUsers
            // 
            btnViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewUsers.AutoSize = true;
            btnViewUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewUsers.Location = new Point(0, 0);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(132, 25);
            btnViewUsers.TabIndex = 11;
            btnViewUsers.Text = "View Users/Professors";
            btnViewUsers.UseVisualStyleBackColor = true;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlStudents, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlClasses, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlBottom, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(944, 261);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 261);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(960, 300);
            Name = "MainForm";
            Text = "Student Management System";
            FormClosed += MainForm_FormClosed;
            tblStudents.ResumeLayout(false);
            tblStudents.PerformLayout();
            pnlStudentSection.ResumeLayout(false);
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            pnlClasses.ResumeLayout(false);
            pnlClasses.PerformLayout();
            tblClasses.ResumeLayout(false);
            tblClasses.PerformLayout();
            pnlClassSection.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnStudentSearch;
        private Button btnLogout;
        private ProgressBar prgProcessingIndicator;
        private TextBox txtStudentQuery;
        private Button btnAddStudent;
        private Button btnViewUsers;
        private ListBox lstStudentResults;
        private Button btnDelStudent;
        private TableLayoutPanel tblStudents;
        private Panel pnlStudents;
        private Panel pnlClasses;
        private ListBox lstClassResults;
        private Panel pnlBottom;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblClasses;
        private TextBox txtClassQuery;
        private Button btnClassSearch;
        private Label lblClassResult;
        private Button btnAddClass;
        private Button btnDelClass;
        private Button btnEditClass;
        private Panel pnlStudentSection;
        private Button btnEditStudent;
        private Label btnStudentResult;
        private Panel pnlClassSection;
    }
}