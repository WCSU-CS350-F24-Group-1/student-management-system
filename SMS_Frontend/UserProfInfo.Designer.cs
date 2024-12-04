namespace SMS_Frontend
{
    partial class UserProfInfo
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
            Panel pnlRight;
            clbStudentEnrollment = new CheckedListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnClose = new Button();
            pnlRight = new Panel();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // clbStudentEnrollment
            // 
            clbStudentEnrollment.Dock = DockStyle.Fill;
            clbStudentEnrollment.FormattingEnabled = true;
            clbStudentEnrollment.IntegralHeight = false;
            clbStudentEnrollment.Items.AddRange(new object[] { "CS 215", "CS 221", "CS 315", "CS 444" });
            clbStudentEnrollment.Location = new Point(0, 0);
            clbStudentEnrollment.Name = "clbStudentEnrollment";
            clbStudentEnrollment.Size = new Size(689, 450);
            clbStudentEnrollment.TabIndex = 1;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(tableLayoutPanel1);
            pnlRight.Controls.Add(btnClose);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(489, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(200, 450);
            pnlRight.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(200, 427);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Location = new Point(0, 427);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(200, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // UserProfInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 450);
            Controls.Add(pnlRight);
            Controls.Add(clbStudentEnrollment);
            Name = "UserProfInfo";
            Text = "UserProfInfo";
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox clbStudentEnrollment;
        private Panel pnlRight;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClose;
    }
}