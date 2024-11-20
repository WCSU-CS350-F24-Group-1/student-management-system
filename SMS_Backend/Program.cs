// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using System.Net;
using System.Net.Sockets;

namespace SMS_Backend
{
    internal static class Program
    {
        /// <summary>
        /// Entry point for the server program.
        /// Handles initialization of database connection and server connection listener.
        /// </summary>
        public static void Main(string[] args)
        {
            // Create and test database connection
            var dbConnection = new Services.DatabaseConnection();
            dbConnection.TestConnection();
            
            // Get server connection information
            // This will always be hosted on the local machine
            var ipAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
            IPEndPoint endPoint = new IPEndPoint(ipAddress, 9000);
            
            // Create a socket listener
            using (Socket listener = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
            {
                listener.Bind(endPoint);
                listener.Listen(10);  // Start listening
                Console.WriteLine("Server is running...");

                while (true)
                {
                    var connection = listener.Accept();  // We would want to offload this into a class
                    Console.WriteLine("Found connection");
                    // This is where the message will be received and processed
                    using (var netStream = new NetworkStream(connection))
                    {
                        var reader = new StreamReader(netStream);
                        var writer = new StreamWriter(netStream);
                        
                        // Read something
                        var testString = reader.ReadToEnd();
                        
                        // Write something
                        writer.WriteLine("Hello from the server!");
                    }
                    // After this point, our stream is gone
                    // Close the connection
                    connection.Close();
                    
                    // Break the loop and end program
                    break;
                }
            }
        }
    }
}
