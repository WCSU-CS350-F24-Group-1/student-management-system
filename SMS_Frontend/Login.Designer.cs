namespace SMS_Frontend
{
    partial class Login
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
            Label lblUsername;
            Label lblPassword;
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUsernameWrong = new Label();
            lblPasswordWrong = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 53);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(12, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username...";
            txtUsername.Size = new Size(260, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += clearErrorText;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(12, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password...";
            txtPassword.Size = new Size(260, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += clearErrorText;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(57, 100);
            btnLogin.Margin = new Padding(48, 3, 48, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 25);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsernameWrong
            // 
            lblUsernameWrong.AutoSize = true;
            lblUsernameWrong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameWrong.ForeColor = Color.IndianRed;
            lblUsernameWrong.Location = new Point(108, 9);
            lblUsernameWrong.Name = "lblUsernameWrong";
            lblUsernameWrong.Size = new Size(164, 15);
            lblUsernameWrong.TabIndex = 5;
            lblUsernameWrong.Text = "This username doesn't exist.";
            lblUsernameWrong.Visible = false;
            // 
            // lblPasswordWrong
            // 
            lblPasswordWrong.AutoSize = true;
            lblPasswordWrong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordWrong.ForeColor = Color.IndianRed;
            lblPasswordWrong.Location = new Point(120, 53);
            lblPasswordWrong.Name = "lblPasswordWrong";
            lblPasswordWrong.Size = new Size(152, 15);
            lblPasswordWrong.TabIndex = 6;
            lblPasswordWrong.Text = "This password is incorrect.";
            lblPasswordWrong.Visible = false;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 137);
            Controls.Add(lblPasswordWrong);
            Controls.Add(lblUsernameWrong);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "SMS Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUsernameWrong;
        private Label lblPasswordWrong;
    }
}
