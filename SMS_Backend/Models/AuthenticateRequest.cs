namespace SMS_Backend.Models
{
    public class AuthenticateRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
