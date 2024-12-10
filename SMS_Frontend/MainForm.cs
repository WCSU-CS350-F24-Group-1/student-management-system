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
    public partial class MainForm : Form
    {
        private bool LogoutClicked = false;

        public MainForm()
        {
            InitializeComponent();
            RefreshLists();
        }

        private void RefreshLists()
        {
            lstStudentResults.Items.Clear();
            Program.Students.Values.ToList().ForEach(student => {
                if (student.Name.ToLower().Contains(txtStudentQuery.Text.ToLower()))
                    lstStudentResults.Items.Add(student.Name + " (" + student.StudentId.ToString() + ")");
            });
            lstClassResults.Items.Clear();
            Program.Courses.Values.ToList().ForEach(course => {
                if (course.CourseName.ToLower().Contains(txtClassQuery.Text.ToLower()))
                    lstClassResults.Items.Add(course.CourseName + " (" + course.CourseId.ToString() + ")");
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!LogoutClicked) DialogResult = DialogResult.Cancel; // the dialogresult will only be Cancel if the logout button wasn't clicked
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Continue;
            LogoutClicked = true;
            Close();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            string guid = lstStudentResults.SelectedItem.ToString();
            new StudentInfo().OpenForm(false, guid.Substring(guid.Length - 37, 36), lstClassResults.SelectedItem.ToString());
            RefreshLists();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            new StudentInfo().OpenForm(true);
            RefreshLists();
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            if (lstStudentResults.SelectedItems.Count == 0)
            {
                MessageBox.Show("You haven't selected any students to delete.", "Can't delete 0 students",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Delete the selected students?\nThis cannot be undone.",
                "Delete Selected Students",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes) {
                string guid = lstStudentResults.SelectedItem.ToString();
                Program.Students.Remove(guid);
                RefreshLists();
            }
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            RefreshLists();
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            string guid = lstClassResults.SelectedItem.ToString();
            new ClassInfo().OpenForm(false, guid.Substring(guid.Length - 37, 36));
            RefreshLists();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            new ClassInfo().OpenForm(true);
            RefreshLists();
        }

        private void btnDelClass_Click(object sender, EventArgs e)
        {
            if (lstClassResults.SelectedItems.Count == 0)
            {
                MessageBox.Show("You haven't selected any courses to delete.", "Can't delete 0 courses",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Delete the selected courses?\nThis cannot be undone.",
                "Delete Selected Courses",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                string guid = lstClassResults.SelectedItem.ToString();
                Program.Courses.Remove(guid);
                RefreshLists();
            }
        }

        private void btnClassSearch_Click(object sender, EventArgs e)
        {
            RefreshLists();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            new UserProfInfo().ShowDialog();
        }

        private void lstStudentResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = lstStudentResults.SelectedItems.Count != 0;
            btnDelStudent.Enabled = enable;
            btnEditStudent.Enabled = enable;
        }

        private void lstClassResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = lstClassResults.SelectedItems.Count != 0;
            btnDelClass.Enabled = enable;
            btnEditClass.Enabled = enable;
        }
    }
}
