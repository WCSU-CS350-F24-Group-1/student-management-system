using SMS_Backend.Models;

namespace SMS_Frontend
{
    internal static class Program
    {
        public static TcpClientService TcpService = new("localhost", 9000);
        public static Dictionary<string, User> Users = new();
        public static Dictionary<string, Course> Courses = new();
        public static Dictionary<string, Student> Students = new();
        public static User? LoggedInUser;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}