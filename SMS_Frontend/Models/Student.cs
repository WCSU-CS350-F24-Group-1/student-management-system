using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Xml.Linq;

namespace SMS_Backend.Models
{
    public class Student
    {
        public Student(string name, DateTime dob, string email, string phone, decimal gpa, int credits, string major = "")
        {
            StudentId = Guid.NewGuid();
            Name = name;
            DateOfBirth = dob;
            Email = email;
            Phone = phone;
            GPA = gpa;
            Credits = credits;
            Major = major;
            EnrolledCourses = new List<Course> { };
        }
        public Guid StudentId { get; set; } // Maps to student_id
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal GPA { get; set; }
        public int Credits { get; set; }
        public string Major { get; set; }
        public List<Course> EnrolledCourses { get; set; }
    }
}
