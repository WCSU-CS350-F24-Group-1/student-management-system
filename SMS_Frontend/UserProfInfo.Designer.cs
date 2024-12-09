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
            tblProps = new TableLayoutPanel();
            txtOfficeLoc = new TextBox();
            lblOfficeLoc = new Label();
            txtDept = new TextBox();
            lblDept = new Label();
            txtRole = new TextBox();
            lblRole = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            btnAddUser = new Button();
            btnCancelCreate = new Button();
            btnDelUser = new Button();
            btnClose = new Button();
            lstUsers = new ListBox();
            pnlRight = new Panel();
            pnlRight.SuspendLayout();
            tblProps.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(tblProps);
            pnlRight.Controls.Add(btnAddUser);
            pnlRight.Controls.Add(btnCancelCreate);
            pnlRight.Controls.Add(btnDelUser);
            pnlRight.Controls.Add(btnClose);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(196, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(3, 0, 0, 0);
            pnlRight.Size = new Size(200, 380);
            pnlRight.TabIndex = 2;
            // 
            // tblProps
            // 
            tblProps.ColumnCount = 2;
            tblProps.ColumnStyles.Add(new ColumnStyle());
            tblProps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProps.Controls.Add(txtOfficeLoc, 1, 4);
            tblProps.Controls.Add(lblOfficeLoc, 0, 4);
            tblProps.Controls.Add(txtDept, 1, 3);
            tblProps.Controls.Add(lblDept, 0, 3);
            tblProps.Controls.Add(txtRole, 1, 2);
            tblProps.Controls.Add(lblRole, 0, 2);
            tblProps.Controls.Add(txtPassword, 1, 1);
            tblProps.Controls.Add(lblPassword, 0, 1);
            tblProps.Controls.Add(txtUsername, 1, 0);
            tblProps.Controls.Add(lblUsername, 0, 0);
            tblProps.Dock = DockStyle.Fill;
            tblProps.Location = new Point(3, 0);
            tblProps.Name = "tblProps";
            tblProps.RowCount = 5;
            tblProps.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblProps.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblProps.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblProps.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblProps.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblProps.Size = new Size(197, 280);
            tblProps.TabIndex = 0;
            // 
            // txtOfficeLoc
            // 
            txtOfficeLoc.Dock = DockStyle.Fill;
            txtOfficeLoc.Enabled = false;
            txtOfficeLoc.Location = new Point(97, 227);
            txtOfficeLoc.MaxLength = 10;
            txtOfficeLoc.Name = "txtOfficeLoc";
            txtOfficeLoc.PlaceholderText = "Location";
            txtOfficeLoc.Size = new Size(97, 23);
            txtOfficeLoc.TabIndex = 30;
            txtOfficeLoc.TextChanged += txtOfficeLoc_TextChanged;
            // 
            // lblOfficeLoc
            // 
            lblOfficeLoc.AutoSize = true;
            lblOfficeLoc.Dock = DockStyle.Fill;
            lblOfficeLoc.Location = new Point(3, 227);
            lblOfficeLoc.Margin = new Padding(3);
            lblOfficeLoc.Name = "lblOfficeLoc";
            lblOfficeLoc.Padding = new Padding(0, 3, 0, 0);
            lblOfficeLoc.Size = new Size(88, 50);
            lblOfficeLoc.TabIndex = 29;
            lblOfficeLoc.Text = "Office Location";
            // 
            // txtDept
            // 
            txtDept.Dock = DockStyle.Fill;
            txtDept.Enabled = false;
            txtDept.Location = new Point(97, 171);
            txtDept.MaxLength = 50;
            txtDept.Name = "txtDept";
            txtDept.PlaceholderText = "Department name";
            txtDept.Size = new Size(97, 23);
            txtDept.TabIndex = 28;
            txtDept.TextChanged += txtDept_TextChanged;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Dock = DockStyle.Fill;
            lblDept.Location = new Point(3, 171);
            lblDept.Margin = new Padding(3);
            lblDept.Name = "lblDept";
            lblDept.Padding = new Padding(0, 3, 0, 0);
            lblDept.Size = new Size(88, 50);
            lblDept.TabIndex = 27;
            lblDept.Text = "Department";
            // 
            // txtRole
            // 
            txtRole.Dock = DockStyle.Fill;
            txtRole.Enabled = false;
            txtRole.Location = new Point(97, 115);
            txtRole.MaxLength = 20;
            txtRole.Name = "txtRole";
            txtRole.PlaceholderText = "User's role";
            txtRole.Size = new Size(97, 23);
            txtRole.TabIndex = 26;
            txtRole.TextChanged += txtRole_TextChanged;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Fill;
            lblRole.Location = new Point(3, 115);
            lblRole.Margin = new Padding(3);
            lblRole.Name = "lblRole";
            lblRole.Padding = new Padding(0, 3, 0, 0);
            lblRole.Size = new Size(88, 50);
            lblRole.TabIndex = 25;
            lblRole.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(97, 59);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(97, 23);
            txtPassword.TabIndex = 24;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Location = new Point(3, 59);
            lblPassword.Margin = new Padding(3);
            lblPassword.Name = "lblPassword";
            lblPassword.Padding = new Padding(0, 3, 0, 0);
            lblPassword.Size = new Size(88, 50);
            lblPassword.TabIndex = 23;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(97, 3);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(97, 23);
            txtUsername.TabIndex = 22;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Location = new Point(3, 3);
            lblUsername.Margin = new Padding(3);
            lblUsername.Name = "lblUsername";
            lblUsername.Padding = new Padding(0, 3, 0, 0);
            lblUsername.Size = new Size(88, 50);
            lblUsername.TabIndex = 19;
            lblUsername.Text = "Username";
            // 
            // btnAddUser
            // 
            btnAddUser.AutoSize = true;
            btnAddUser.Dock = DockStyle.Bottom;
            btnAddUser.Location = new Point(3, 280);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(197, 25);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Create User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnCancelCreate
            // 
            btnCancelCreate.AutoSize = true;
            btnCancelCreate.Dock = DockStyle.Bottom;
            btnCancelCreate.Location = new Point(3, 305);
            btnCancelCreate.Name = "btnCancelCreate";
            btnCancelCreate.Size = new Size(197, 25);
            btnCancelCreate.TabIndex = 33;
            btnCancelCreate.Text = "Cancel";
            btnCancelCreate.UseVisualStyleBackColor = true;
            btnCancelCreate.Visible = false;
            btnCancelCreate.Click += btnCancelCreate_Click;
            // 
            // btnDelUser
            // 
            btnDelUser.AutoSize = true;
            btnDelUser.Dock = DockStyle.Bottom;
            btnDelUser.Enabled = false;
            btnDelUser.Location = new Point(3, 330);
            btnDelUser.Name = "btnDelUser";
            btnDelUser.Size = new Size(197, 25);
            btnDelUser.TabIndex = 3;
            btnDelUser.Text = "Delete User";
            btnDelUser.UseVisualStyleBackColor = true;
            btnDelUser.Click += btnDelUser_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Location = new Point(3, 355);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(197, 25);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lstUsers
            // 
            lstUsers.Dock = DockStyle.Fill;
            lstUsers.FormattingEnabled = true;
            lstUsers.IntegralHeight = false;
            lstUsers.ItemHeight = 15;
            lstUsers.Items.AddRange(new object[] { "Jakub", "Ronan", "Nikita", "some fourth person" });
            lstUsers.Location = new Point(3, 3);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(193, 380);
            lstUsers.TabIndex = 1;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // UserProfInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 386);
            Controls.Add(lstUsers);
            Controls.Add(pnlRight);
            MinimumSize = new Size(360, 280);
            Name = "UserProfInfo";
            Padding = new Padding(3);
            Text = "UserProfInfo";
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            tblProps.ResumeLayout(false);
            tblProps.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstUsers;
        private Panel pnlRight;
        private TableLayoutPanel tblProps;
        private Button btnClose;
        private Label lblUsername;
        private TextBox txtOfficeLoc;
        private Label lblOfficeLoc;
        private TextBox txtDept;
        private Label lblDept;
        private TextBox txtRole;
        private Label lblRole;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Button btnAddUser;
        private Button btnDelUser;
        private Button btnCancelCreate;
    }
}