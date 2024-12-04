namespace SMS_Backend.Models
{
    public class Request
    {
        public string Command { get; set; } = string.Empty; // e.g., "AddStudent"
        public string Data { get; set; } = string.Empty;    // Serialized object (e.g., Student JSON)
    }
}
