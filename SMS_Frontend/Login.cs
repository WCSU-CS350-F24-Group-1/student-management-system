using System.Media;

namespace SMS_Frontend
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!true || txtUsername.TextLength == 0) // Username validation
            {
                SystemSounds.Exclamation.Play();
                lblUsernameWrong.Visible = true;
                return;
            }
            if (!true || txtPassword.TextLength == 0) // Password validation
            {
                SystemSounds.Exclamation.Play();
                lblPasswordWrong.Visible = true;
                return;
            }
            // Correct username and password, let's login:
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            if (mainForm.DialogResult == DialogResult.Continue)
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                this.Show();
                mainForm.Dispose();
            }
            else Application.Exit();
        }

        private void clearErrorText(object sender, EventArgs e)
        {
            if (sender == txtUsername) lblUsernameWrong.Visible = false;
            if (sender == txtPassword) lblPasswordWrong.Visible = false;
        }
    }
}
