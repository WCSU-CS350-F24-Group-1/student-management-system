using System;

namespace SMS_Backend.Models
{
    public class Course
    {
        public Guid CourseId { get; set; } // Maps to course_id
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
        public Guid ProfessorId { get; set; } // Maps to professor_id (foreign key)
    }
}
