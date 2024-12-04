namespace SMS_Frontend
{
    partial class ClassInfo
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
            TableLayoutPanel tblClassProperties;
            TableLayoutPanel tblBottomButtons;
            txtClassProf = new TextBox();
            lblClassProf = new Label();
            numClassCredits = new NumericUpDown();
            lblClassCredits = new Label();
            txtClassName = new TextBox();
            lblClassName = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            tblClassProperties = new TableLayoutPanel();
            tblBottomButtons = new TableLayoutPanel();
            tblClassProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numClassCredits).BeginInit();
            tblBottomButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblClassProperties
            // 
            tblClassProperties.AutoSize = true;
            tblClassProperties.ColumnCount = 2;
            tblClassProperties.ColumnStyles.Add(new ColumnStyle());
            tblClassProperties.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblClassProperties.Controls.Add(txtClassProf, 1, 2);
            tblClassProperties.Controls.Add(lblClassProf, 0, 2);
            tblClassProperties.Controls.Add(numClassCredits, 1, 1);
            tblClassProperties.Controls.Add(lblClassCredits, 0, 1);
            tblClassProperties.Controls.Add(txtClassName, 1, 0);
            tblClassProperties.Controls.Add(lblClassName, 0, 0);
            tblClassProperties.Dock = DockStyle.Fill;
            tblClassProperties.Location = new Point(0, 0);
            tblClassProperties.Name = "tblClassProperties";
            tblClassProperties.RowCount = 3;
            tblClassProperties.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblClassProperties.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblClassProperties.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblClassProperties.Size = new Size(284, 92);
            tblClassProperties.TabIndex = 11;
            // 
            // txtClassProf
            // 
            txtClassProf.Dock = DockStyle.Fill;
            txtClassProf.Location = new Point(83, 63);
            txtClassProf.Name = "txtClassProf";
            txtClassProf.PlaceholderText = "Professor's username";
            txtClassProf.Size = new Size(198, 23);
            txtClassProf.TabIndex = 21;
            // 
            // lblClassProf
            // 
            lblClassProf.Dock = DockStyle.Fill;
            lblClassProf.Location = new Point(3, 63);
            lblClassProf.Margin = new Padding(3);
            lblClassProf.Name = "lblClassProf";
            lblClassProf.Size = new Size(74, 26);
            lblClassProf.TabIndex = 18;
            lblClassProf.Text = "Professor";
            lblClassProf.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numClassCredits
            // 
            numClassCredits.Dock = DockStyle.Fill;
            numClassCredits.Location = new Point(83, 33);
            numClassCredits.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numClassCredits.Name = "numClassCredits";
            numClassCredits.Size = new Size(198, 23);
            numClassCredits.TabIndex = 22;
            // 
            // lblClassCredits
            // 
            lblClassCredits.Dock = DockStyle.Fill;
            lblClassCredits.Location = new Point(3, 33);
            lblClassCredits.Margin = new Padding(3);
            lblClassCredits.Name = "lblClassCredits";
            lblClassCredits.Size = new Size(74, 24);
            lblClassCredits.TabIndex = 19;
            lblClassCredits.Text = "Credit Hours";
            lblClassCredits.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtClassName
            // 
            txtClassName.Dock = DockStyle.Fill;
            txtClassName.Location = new Point(83, 3);
            txtClassName.Name = "txtClassName";
            txtClassName.PlaceholderText = "Class name";
            txtClassName.Size = new Size(198, 23);
            txtClassName.TabIndex = 20;
            // 
            // lblClassName
            // 
            lblClassName.Dock = DockStyle.Fill;
            lblClassName.Location = new Point(3, 3);
            lblClassName.Margin = new Padding(3);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(74, 24);
            lblClassName.TabIndex = 17;
            lblClassName.Text = "Name";
            lblClassName.TextAlign = ContentAlignment.MiddleLeft;
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
            tblBottomButtons.Location = new Point(0, 92);
            tblBottomButtons.Name = "tblBottomButtons";
            tblBottomButtons.RowCount = 1;
            tblBottomButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblBottomButtons.Size = new Size(284, 29);
            tblBottomButtons.TabIndex = 19;
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Fill;
            btnConfirm.Location = new Point(3, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(136, 23);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Add Course";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(145, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ClassInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 121);
            Controls.Add(tblClassProperties);
            Controls.Add(tblBottomButtons);
            MaximizeBox = false;
            MaximumSize = new Size(4096, 160);
            MinimumSize = new Size(300, 160);
            Name = "ClassInfo";
            Text = "ClassInfo";
            tblClassProperties.ResumeLayout(false);
            tblClassProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numClassCredits).EndInit();
            tblBottomButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpClassProperties;
        private Label lblClassName;
        private TextBox txtClassName;
        private Label lblClassCredits;
        private NumericUpDown numClassCredits;
        private Label lblClassProf;
        private TextBox txtClassProf;
        private TableLayoutPanel tblClassProperties;
        private Button btnConfirm;
        private Button btnCancel;
        private NumericUpDown numStudentID;
    }
}