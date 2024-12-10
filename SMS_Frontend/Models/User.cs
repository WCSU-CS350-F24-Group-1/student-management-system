using System;

namespace SMS_Backend.Models
{
    public class User
    {
        public User(string username, string password, string role, string dept, string loc)
        {
            Username = username;
            Password = password;
            Role = role;
            Department = dept;
            OfficeLocation = loc;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public string OfficeLocation { get; set; }
    }
}
