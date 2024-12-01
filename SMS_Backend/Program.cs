// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using SMS_Backend.Models;
using SMS_Backend.Repositories;
using System.Net.Sockets;
using System.Text.Json;

namespace SMS_Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
                    // Example: Add a student
                    var studentRequest = new
                    {
                        Command = "AddStudent",
                        Data = JsonSerializer.Serialize(new
                        {
                            StudentId = Guid.NewGuid(),
                            Name = "John Doe",
                            DateOfBirth = "2000-01-01",
                            Email = "johndoe@example.com",
                            Phone = "555-1234",
                            GPA = 3.8,
                            Credits = 120,
                            Major = "Computer Science"
                        })
                    };

                    var requestJson = JsonSerializer.Serialize(studentRequest);
                    writer.WriteLine(requestJson);

                    // Read the server response
                    var response = reader.ReadLine();
                    Console.WriteLine($"Server Response: {response}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
