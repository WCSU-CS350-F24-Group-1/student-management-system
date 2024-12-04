namespace SMS_Frontend
{
    partial class StudentInfo
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
            Label lblStudentCredits;
            Label txtStudentGPA;
            Label lblStudentPhone;
            Label lblStudentEmail;
            Label lblStudentMajor;
            Label lblStudentDOB;
            Label lblStudentEnrollment;
            TableLayoutPanel tblStudentInfo;
            Label lblStudentName;
            TableLayoutPanel tblBottomButtons;
            txtStudentName = new TextBox();
            dteStudentDOB = new DateTimePicker();
            txtStudentMajor = new TextBox();
            txtStudentEmail = new TextBox();
            numStudentGPA = new NumericUpDown();
            numStudentCredits = new NumericUpDown();
            btnConfirm = new Button();
            btnCancel = new Button();
            clbStudentEnrollment = new CheckedListBox();
            txtStudentPhone = new TextBox();
            lblStudentCredits = new Label();
            txtStudentGPA = new Label();
            lblStudentPhone = new Label();
            lblStudentEmail = new Label();
            lblStudentMajor = new Label();
            lblStudentDOB = new Label();
            lblStudentEnrollment = new Label();
            tblStudentInfo = new TableLayoutPanel();
            lblStudentName = new Label();
            tblBottomButtons = new TableLayoutPanel();
            tblStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStudentGPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStudentCredits).BeginInit();
            tblBottomButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudentCredits
            // 
            lblStudentCredits.AutoSize = true;
            lblStudentCredits.Dock = DockStyle.Top;
            lblStudentCredits.Location = new Point(167, 146);
            lblStudentCredits.Margin = new Padding(3, 6, 0, 0);
            lblStudentCredits.Name = "lblStudentCredits";
            lblStudentCredits.Size = new Size(44, 15);
            lblStudentCredits.TabIndex = 9;
            lblStudentCredits.Text = "Credits";
            lblStudentCredits.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStudentGPA
            // 
            txtStudentGPA.AutoSize = true;
            txtStudentGPA.Dock = DockStyle.Top;
            txtStudentGPA.Location = new Point(3, 146);
            txtStudentGPA.Margin = new Padding(3, 6, 0, 0);
            txtStudentGPA.Name = "txtStudentGPA";
            txtStudentGPA.Size = new Size(73, 15);
            txtStudentGPA.TabIndex = 8;
            txtStudentGPA.Text = "GPA";
            txtStudentGPA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentPhone
            // 
            lblStudentPhone.AutoSize = true;
            lblStudentPhone.Dock = DockStyle.Top;
            lblStudentPhone.Location = new Point(3, 118);
            lblStudentPhone.Margin = new Padding(3, 6, 0, 0);
            lblStudentPhone.Name = "lblStudentPhone";
            lblStudentPhone.Size = new Size(73, 15);
            lblStudentPhone.TabIndex = 7;
            lblStudentPhone.Text = "Phone";
            lblStudentPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentEmail
            // 
            lblStudentEmail.AutoSize = true;
            lblStudentEmail.Dock = DockStyle.Top;
            lblStudentEmail.Location = new Point(3, 90);
            lblStudentEmail.Margin = new Padding(3, 6, 0, 0);
            lblStudentEmail.Name = "lblStudentEmail";
            lblStudentEmail.Size = new Size(73, 15);
            lblStudentEmail.TabIndex = 6;
            lblStudentEmail.Text = "E-mail";
            lblStudentEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentMajor
            // 
            lblStudentMajor.AutoSize = true;
            lblStudentMajor.Dock = DockStyle.Top;
            lblStudentMajor.Location = new Point(3, 62);
            lblStudentMajor.Margin = new Padding(3, 6, 0, 0);
            lblStudentMajor.Name = "lblStudentMajor";
            lblStudentMajor.Size = new Size(73, 15);
            lblStudentMajor.TabIndex = 5;
            lblStudentMajor.Text = "Major";
            lblStudentMajor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentDOB
            // 
            lblStudentDOB.AutoSize = true;
            lblStudentDOB.Dock = DockStyle.Top;
            lblStudentDOB.Location = new Point(3, 34);
            lblStudentDOB.Margin = new Padding(3, 6, 0, 0);
            lblStudentDOB.Name = "lblStudentDOB";
            lblStudentDOB.Size = new Size(73, 15);
            lblStudentDOB.TabIndex = 4;
            lblStudentDOB.Text = "Date of Birth";
            lblStudentDOB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentEnrollment
            // 
            lblStudentEnrollment.AutoSize = true;
            lblStudentEnrollment.Dock = DockStyle.Top;
            lblStudentEnrollment.Location = new Point(0, 173);
            lblStudentEnrollment.Margin = new Padding(3, 3, 3, 0);
            lblStudentEnrollment.Name = "lblStudentEnrollment";
            lblStudentEnrollment.Size = new Size(65, 15);
            lblStudentEnrollment.TabIndex = 17;
            lblStudentEnrollment.Text = "Enrollment";
            // 
            // tblStudentInfo
            // 
            tblStudentInfo.ColumnCount = 4;
            tblStudentInfo.ColumnStyles.Add(new ColumnStyle());
            tblStudentInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStudentInfo.ColumnStyles.Add(new ColumnStyle());
            tblStudentInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStudentInfo.Controls.Add(lblStudentName, 0, 0);
            tblStudentInfo.Controls.Add(txtStudentName, 1, 0);
            tblStudentInfo.Controls.Add(lblStudentDOB, 0, 1);
            tblStudentInfo.Controls.Add(dteStudentDOB, 1, 1);
            tblStudentInfo.Controls.Add(lblStudentMajor, 0, 2);
            tblStudentInfo.Controls.Add(txtStudentMajor, 1, 2);
            tblStudentInfo.Controls.Add(lblStudentEmail, 0, 3);
            tblStudentInfo.Controls.Add(txtStudentEmail, 1, 3);
            tblStudentInfo.Controls.Add(lblStudentPhone, 0, 4);
            tblStudentInfo.Controls.Add(txtStudentPhone, 1, 4);
            tblStudentInfo.Controls.Add(txtStudentGPA, 0, 5);
            tblStudentInfo.Controls.Add(numStudentGPA, 1, 5);
            tblStudentInfo.Controls.Add(lblStudentCredits, 2, 5);
            tblStudentInfo.Controls.Add(numStudentCredits, 3, 5);
            tblStudentInfo.Dock = DockStyle.Top;
            tblStudentInfo.Location = new Point(0, 0);
            tblStudentInfo.Name = "tblStudentInfo";
            tblStudentInfo.RowCount = 6;
            tblStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblStudentInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblStudentInfo.Size = new Size(300, 173);
            tblStudentInfo.TabIndex = 6;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Dock = DockStyle.Top;
            lblStudentName.Location = new Point(3, 6);
            lblStudentName.Margin = new Padding(3, 6, 0, 0);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(73, 15);
            lblStudentName.TabIndex = 3;
            lblStudentName.Text = "Name";
            lblStudentName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStudentName
            // 
            tblStudentInfo.SetColumnSpan(txtStudentName, 3);
            txtStudentName.Dock = DockStyle.Fill;
            txtStudentName.Location = new Point(79, 3);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.PlaceholderText = "Student name";
            txtStudentName.Size = new Size(218, 23);
            txtStudentName.TabIndex = 10;
            // 
            // dteStudentDOB
            // 
            tblStudentInfo.SetColumnSpan(dteStudentDOB, 3);
            dteStudentDOB.Dock = DockStyle.Fill;
            dteStudentDOB.Format = DateTimePickerFormat.Short;
            dteStudentDOB.Location = new Point(79, 31);
            dteStudentDOB.Name = "dteStudentDOB";
            dteStudentDOB.Size = new Size(218, 23);
            dteStudentDOB.TabIndex = 2;
            // 
            // txtStudentMajor
            // 
            tblStudentInfo.SetColumnSpan(txtStudentMajor, 3);
            txtStudentMajor.Dock = DockStyle.Fill;
            txtStudentMajor.Location = new Point(79, 59);
            txtStudentMajor.Name = "txtStudentMajor";
            txtStudentMajor.PlaceholderText = "Major of study";
            txtStudentMajor.Size = new Size(218, 23);
            txtStudentMajor.TabIndex = 11;
            // 
            // txtStudentEmail
            // 
            tblStudentInfo.SetColumnSpan(txtStudentEmail, 3);
            txtStudentEmail.Dock = DockStyle.Fill;
            txtStudentEmail.Location = new Point(79, 87);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.PlaceholderText = "E-mail address";
            txtStudentEmail.Size = new Size(218, 23);
            txtStudentEmail.TabIndex = 12;
            // 
            // numStudentGPA
            // 
            numStudentGPA.DecimalPlaces = 2;
            numStudentGPA.Dock = DockStyle.Fill;
            numStudentGPA.Location = new Point(79, 143);
            numStudentGPA.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numStudentGPA.Name = "numStudentGPA";
            numStudentGPA.Size = new Size(82, 23);
            numStudentGPA.TabIndex = 15;
            // 
            // numStudentCredits
            // 
            numStudentCredits.Dock = DockStyle.Fill;
            numStudentCredits.Location = new Point(214, 143);
            numStudentCredits.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numStudentCredits.Name = "numStudentCredits";
            numStudentCredits.Size = new Size(83, 23);
            numStudentCredits.TabIndex = 16;
            // 
            // tblBottomButtons
            // 
            tblBottomButtons.AutoSize = true;
            tblBottomButtons.ColumnCount = 2;
            tblBottomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblBottomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblBottomButtons.Controls.Add(btnConfirm, 0, 0);
            tblBottomButtons.Controls.Add(btnCancel, 1, 0);
            tblBottomButtons.Dock = DockStyle.Bottom;
            tblBottomButtons.Location = new Point(0, 332);
            tblBottomButtons.Name = "tblBottomButtons";
            tblBottomButtons.RowCount = 1;
            tblBottomButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblBottomButtons.Size = new Size(300, 29);
            tblBottomButtons.TabIndex = 18;
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Fill;
            btnConfirm.Location = new Point(3, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(144, 23);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Add Student";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(153, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // clbStudentEnrollment
            // 
            clbStudentEnrollment.Dock = DockStyle.Fill;
            clbStudentEnrollment.FormattingEnabled = true;
            clbStudentEnrollment.IntegralHeight = false;
            clbStudentEnrollment.Items.AddRange(new object[] { "CS 215", "CS 221", "CS 315", "CS 444" });
            clbStudentEnrollment.Location = new Point(0, 188);
            clbStudentEnrollment.Name = "clbStudentEnrollment";
            clbStudentEnrollment.Size = new Size(300, 173);
            clbStudentEnrollment.TabIndex = 0;
            // 
            // txtStudentPhone
            // 
            tblStudentInfo.SetColumnSpan(txtStudentPhone, 3);
            txtStudentPhone.Dock = DockStyle.Fill;
            txtStudentPhone.Location = new Point(79, 115);
            txtStudentPhone.Name = "txtStudentPhone";
            txtStudentPhone.PlaceholderText = "Phone number";
            txtStudentPhone.Size = new Size(218, 23);
            txtStudentPhone.TabIndex = 17;
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 361);
            Controls.Add(tblBottomButtons);
            Controls.Add(clbStudentEnrollment);
            Controls.Add(lblStudentEnrollment);
            Controls.Add(tblStudentInfo);
            MinimumSize = new Size(300, 400);
            Name = "StudentInfo";
            Text = "Student Info";
            tblStudentInfo.ResumeLayout(false);
            tblStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStudentGPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStudentCredits).EndInit();
            tblBottomButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numStudentCredits;
        private Label lblStudentCredits;
        private NumericUpDown numStudentGPA;
        private Label txtStudentGPA;
        private Label lblStudentPhone;
        private TextBox txtStudentEmail;
        private Label lblStudentEmail;
        private TextBox txtStudentMajor;
        private Label lblStudentMajor;
        private DateTimePicker dteStudentDOB;
        private Label lblStudentDOB;
        private Label lblStudentEnrollment;
        private CheckedListBox clbStudentEnrollment;
        private TableLayoutPanel tblStudentInfo;
        private Label lblStudentName;
        private TextBox txtStudentName;
        private Button btnConfirm;
        private Button btnCancel;
        private TextBox txtStudentPhone;
    }
}