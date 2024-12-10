using SMS_Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Frontend
{
    public partial class ClassInfo : Form
    {
        private Course? course;
        public bool createMode = false; // if true, creates instead of editing
        public ClassInfo()
        {
            InitializeComponent();
        }
        public Tuple<DialogResult, string> OpenForm(bool creating = false, string guid = "")
        {
            createMode = creating;
            if (!creating)
            {
                btnConfirm.Text = "Edit Course";
                course = Program.Courses[guid];

                txtClassName.Text = course.CourseName;
                txtClassProf.Text = course.ProfessorUsername;
                numClassCredits.Value = course.CreditHours;
            }
            else btnConfirm.Enabled = false;
            return Tuple.Create(ShowDialog(), "");
        }
        private void ValidateConfirmAllowed(object sender, EventArgs e)
        {
            btnConfirm.Enabled = txtClassName.Text.Length > 0 &&
                                 txtClassProf.Text.Length > 0 &&
                                 Program.Users.ContainsKey(txtClassProf.Text);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (createMode)
            {
                Course newCourse = new Course(txtClassName.Text, (int)numClassCredits.Value, txtClassProf.Text);
                Program.Courses.Add(newCourse.CourseId.ToString(), newCourse);
            }
            else
            {
                course.CourseName = txtClassName.Text;
                course.CreditHours = (int)numClassCredits.Value;
                course.ProfessorUsername = txtClassProf.Text;
                Program.Courses[course.CourseId.ToString()] = course;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
