// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using SMS_Backend.Models;
using SMS_Backend.Repositories;
using System.Net;
using System.Net.Sockets;

namespace SMS_Backend
{
    public class Program
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

            using (var connection = dbConnection.GetConnection())
            {
                // Start the TCP server
                var server = new TcpServer(9000, connection);
                server.Start();
            }

            try
            {
                using (var client = new TcpClient("localhost", 9000))
                using (var stream = client.GetStream())
                using (var reader = new StreamReader(stream))
                using (var writer = new StreamWriter(stream) { AutoFlush = true })
                {
                    // Send a test request
                    writer.WriteLine("ping");

                    // Read the server response
                    var response = reader.ReadLine();
                    Console.WriteLine($"Server Response: {response}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to server: {ex.Message}");
            }

        }
    }
}
