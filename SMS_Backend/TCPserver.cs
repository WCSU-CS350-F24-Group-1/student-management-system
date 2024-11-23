using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SMS_Backend.Repositories;
using SMS_Backend.Services;
using Npgsql;

namespace SMS_Backend
{
    public class TcpServer
    {
        private readonly int _port;
        private readonly StudentRepository _studentRepository;
        private readonly CourseRepository _courseRepository;
        private readonly EnrollmentRepository _enrollmentRepository;
        private readonly UserRepository _userRepository;

        public TcpServer(int port, NpgsqlConnection connection)
        {
            _port = port;

            // Initialize repos with shared database connection
            _studentRepository = new StudentRepository(connection);
            _courseRepository = new CourseRepository(connection);
            _enrollmentRepository = new EnrollmentRepository(connection);
            _userRepository = new UserRepository(connection); 
        }

        public void Start()
        {
            var listener = new TcpListener(IPAddress.Any, _port);
            listener.Start();
            Console.WriteLine($"Server is running on port {_port}...");

            while (true)
            {
                try
                {
                    var client = listener.AcceptTcpClient();
                    Console.WriteLine("Client connected.");

                    // Handle client connection in a new thread
                    ThreadPool.QueueUserWorkItem(HandleClient, client);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error accepting client: {ex.Message}");
                }
            }
        }

        private void HandleClient(object? obj)
        {
            var client = obj as TcpClient;
            if (client == null) return;

            using (var netStream = client.GetStream())
            using (var reader = new StreamReader(netStream))
            using (var writer = new StreamWriter(netStream) { AutoFlush = true })
            {
                try
                {
                    // Read client request
                    var request = reader.ReadLine();
                    Console.WriteLine($"Received: {request}");

                    // Process the request
                    var response = ProcessRequest(request);
                    writer.WriteLine(response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error handling client: {ex.Message}");
                }
                finally
                {
                    client.Close();
                }
            }
        }

        private string ProcessRequest(string? request)
        {
            if (string.IsNullOrWhiteSpace(request)) return "Invalid request.";

            try
            {
                // Sim request processing (in future expand with JSON deserialization and command desing)
                if (request == "ping") return "pong";

                return $"Processed: {request}";
            }
            catch (Exception ex)
            {
                return $"Error processing request: {ex.Message}";
            }
        }
    }
}
