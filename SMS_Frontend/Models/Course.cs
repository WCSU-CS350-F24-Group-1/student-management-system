using System;

namespace SMS_Backend.Models
{
    public class Course
    {
        public Course(string name, int hours = 0, string username = "")
        {
            CourseId = Guid.NewGuid();
            CourseName = name;
            CreditHours = hours;
            ProfessorUsername = username;
        }
        public Guid CourseId { get; set; } // Maps to course_id
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
        public string ProfessorUsername { get; set; }
    }
}
