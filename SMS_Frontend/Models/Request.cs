namespace SMS_Frontend.Models
{
    public class Request
    {
        public string Command { get; set; } = string.Empty; // Command name (ex., "AddStudent")
        public string Data { get; set; } = string.Empty;    // Serialized object
    }
}
