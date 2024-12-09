using SMS_Backend.Models;
using System.Media;

namespace SMS_Frontend
{
    public partial class Login : Form
    {
        public Login()
        {
            InitLogin();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Program.Users.Keys.ToList().Contains(txtUsername.Text.Trim()) || txtUsername.TextLength == 0) // Username validation
            {
                SystemSounds.Exclamation.Play();
                lblUsernameWrong.Visible = true;
                return;
            }
            User loginUser = Program.Users[txtUsername.Text.Trim()];
            if (!String.Equals(txtPassword.Text, loginUser.Password) || txtPassword.TextLength == 0) // Password validation
            {
                SystemSounds.Exclamation.Play();
                lblPasswordWrong.Visible = true;
                return;
            }
            // Correct username and password, let's login:
            Program.LoggedInUser = loginUser;
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

        private void InitLogin()
        {
            Program.Users.Add("crealol2",  new User("crealol2",  "rono balogno", "Cool Guy",        "Based Department", "308A"));
            Program.Users.Add("jakub",     new User("jakub",     "jakub",        "jakub",           "dept of jakub",    "221J"));
            Program.Users.Add("BobdaFett", new User("BobdaFett", "lucas",        "Asst. Cool Guy",  "Based Department", "204"));
            Program.Users.Add("username",  new User("username",  "password",     "role",            "department",       "room"));
            Program.Users.Add("nikita",    new User("nikita",    "wow",          "Project Manager", "Team 1",           "821"));

            Student stud = new Student("Ronan", DateTime.Parse("Apr 15 2004"), "redacted@wcsu.edu", "860-555-5555", (decimal)3.1, 36, "Computer Science");
            Program.Students.Add(stud.StudentId.ToString(), stud);
            stud = new Student("Jakub", DateTime.Parse("9/9/1965"), "e@mail.com", "555-223-9573", (decimal)4.0, 28, "Jakub Science");
            Program.Students.Add(stud.StudentId.ToString(), stud);
            stud = new Student("Nikita", DateTime.Parse("5/5/2002"), "nikita@example.com", "113-555-3285+1", (decimal)3.9, 43, "Math");
            Program.Students.Add(stud.StudentId.ToString(), stud);

            Course cour = new Course("Advanced Mathematics", 3, "BobdaFett");
            Program.Courses.Add(cour.CourseId.ToString(), cour);
            cour = new Course("Intro to C#", 2, "nikita");
            Program.Courses.Add(cour.CourseId.ToString(), cour);
            cour = new Course("Advanced C#", 2, "nikita");
            Program.Courses.Add(cour.CourseId.ToString(), cour);
        }
    }
}
