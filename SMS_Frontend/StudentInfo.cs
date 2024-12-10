using SMS_Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Frontend
{
    public partial class StudentInfo : Form
    {
        private Student? student;
        public bool createMode = false; // if true, creates instead of editing
        public StudentInfo()
        {
            InitializeComponent();
        }
        public Tuple<DialogResult, string> OpenForm(bool creating = false, string guid = "", string? selectedCourse = null)
        {
            if (creating)
            {
                clbStudentEnrollment.Visible = false;
                lblStudentEnrollment.Visible = false;
            }
            else { 
                btnConfirm.Text = "Edit Student";
                student = Program.Students[guid];
                if (student != null) { 
                    txtStudentEmail.Text = student.Email;
                    txtStudentMajor.Text = student.Major;
                    txtStudentName.Text = student.Name;
                    txtStudentPhone.Text = student.Phone;
                    numStudentGPA.Value = student.GPA;
                    numStudentCredits.Value = student.Credits;
                    clbStudentEnrollment.Items.Clear();
                    student.EnrolledCourses.ForEach(course => {
                        string courseName = course.CourseName + " (" + course.CourseId + ")";
                        clbStudentEnrollment.Items.Add(courseName);
                        clbStudentEnrollment.SetItemChecked(clbStudentEnrollment.Items.IndexOf(courseName), true);
                    });
                    if (selectedCourse != null) clbStudentEnrollment.Items.Add(selectedCourse);
                }
            }
            return Tuple.Create(ShowDialog(), "");
        }
        private void ValidateConfirmAllowed(object sender, EventArgs e)
        {
            btnConfirm.Enabled = txtStudentName.Text.Length > 0 &&
                                 txtStudentEmail.Text.Length > 0 &&
                                 txtStudentPhone.Text.Length > 0;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (createMode)
            {
                Student newStudent = new Student(txtStudentName.Text, dteStudentDOB.Value, txtStudentEmail.Text, txtStudentPhone.Text, numStudentGPA.Value, (int)numStudentCredits.Value, txtStudentMajor.Text);
                Program.Students.Add(newStudent.StudentId.ToString(), newStudent);
            } else
            {
                student.Name = txtStudentName.Text;
                student.Email = txtStudentEmail.Text;
                student.Major = txtStudentMajor.Text;
                student.Phone = txtStudentPhone.Text;
                student.GPA = numStudentGPA.Value;
                student.Credits = (int)numStudentCredits.Value;
                student.EnrolledCourses.Clear();
                for (int i = 0; i < clbStudentEnrollment.CheckedItems.Count; i++) {
                    string item = clbStudentEnrollment.CheckedItems[i].ToString();
                    student.EnrolledCourses.Add(Program.Courses[item.Substring(item.Length - 37, 36)]);
                }
                Program.Students[student.StudentId.ToString()] = student;
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
