// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
namespace SMS_Backend
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var dbConnection = new Services.DatabaseConnection();
            dbConnection.TestConnection();
        }
    }
}
