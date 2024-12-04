using System;

namespace SMS_Backend.Models
{
    public class Student
    {
        public Guid StudentId { get; set; } // Maps to student_id
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal GPA { get; set; }
        public int Credits { get; set; }
        public string Major { get; set; }
    }
}
