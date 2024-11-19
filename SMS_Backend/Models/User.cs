using System;

namespace SMS_Backend.Models
{
    public class User
    {
        public Guid UserId { get; set; } // Maps to user_id
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public string OfficeLocation { get; set; }
    }
}
