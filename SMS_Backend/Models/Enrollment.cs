using System;

namespace SMS_Backend.Models
{
    public class Enrollment
    {
        public Guid CourseId { get; set; } // Foreign key
        public Guid StudentId { get; set; } // Foreign key
    }
}
