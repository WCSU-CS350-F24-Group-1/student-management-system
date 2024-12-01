using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SMS_Backend.Repositories;
using SMS_Backend.Services;
using Npgsql;
using System.Text.Json;
using SMS_Backend.Commands;
using SMS_Backend.Models;

namespace SMS_Backend
{
    public class TcpServer
    {
        private readonly int _port;
        private readonly StudentRepository _studentRepository;
        private readonly CourseRepository _courseRepository;
        private readonly EnrollmentRepository _enrollmentRepository;
        private readonly UserRepository _userRepository;
        private readonly Dictionary<string, User> _authenticatedUsers = new Dictionary<string, User>();


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
            // Generate a unique identifier for the client
            var clientId = GetClientIdentifier();
            Console.WriteLine($"Client connected with ID: {clientId}");

            using (var netStream = client.GetStream())
            using (var reader = new StreamReader(netStream))
            using (var writer = new StreamWriter(netStream) { AutoFlush = true })
            {
                try
                {
                    string? request;
                    while ((request = reader.ReadLine()) != null)
                    {
                        Console.WriteLine($"[{clientId}] Received: {request}");

                        // Process the request and pass the clientId
                        var response = ProcessRequest(request, clientId);
                        writer.WriteLine(response);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error handling client {clientId}: {ex.Message}");
                }
                finally
                {
                    client.Close();
                    Console.WriteLine($"Client {clientId} disconnected.");

                    // Remove the client from the authenticated users list 
                    _authenticatedUsers.Remove(clientId);
                }
            }
        }

        private string ProcessRequest(string? request, string clientId)
        {
            if (string.IsNullOrWhiteSpace(request)) return "Invalid request.";

            try
            {
                // Deserialize the request
                var requestObj = JsonSerializer.Deserialize<Request>(request);
                if (requestObj == null) return "Bad request.";

                ICommand command;

                // Map commands to requests
                switch (requestObj.Command)
                {
            // User Management Commands
            case "AddUser":
                var newUser = JsonSerializer.Deserialize<User>(requestObj.Data);
                if (newUser == null) return "Invalid user data.";
                command = new AddUserCommand(_userRepository, newUser);
                break;

            case "UpdateUser":
                if (!_authenticatedUsers.TryGetValue(clientId, out var authenticatedUser))
                {
                    return "User not authenticated.";
                }

                var updateUser = JsonSerializer.Deserialize<User>(requestObj.Data);
                if (updateUser == null) return "Invalid user data.";

                command = new UpdateUserCommand(_userRepository, authenticatedUser, updateUser);
                break;

            case "DeleteUser":
                var deleteUserId = Guid.Parse(requestObj.Data); 
                command = new DeleteUserCommand(_userRepository, deleteUserId);
                break;

            case "AuthenticateUser":
                var authData = JsonSerializer.Deserialize<AuthenticateRequest>(requestObj.Data);
                if (authData == null) return "Invalid authentication data.";

                var authCommand = new AuthenticateUserCommand(_userRepository, authData.Username, authData.Password);
                var authResult = authCommand.Execute();

                if (authResult != "Authentication failed.")
                {
                    var user = JsonSerializer.Deserialize<User>(authResult);
                    _authenticatedUsers[clientId] = user;
                    return "Authentication successful.";
                }

                return "Authentication failed.";

            case "GetUserById":
                var userId = Guid.Parse(requestObj.Data);
                command = new GetUserByIdCommand(_userRepository, userId);
                break;

            case "GetAllUsers":
                command = new GetAllUsersCommand(_userRepository);
                break;

            // Student Management Commands
            case "AddStudent":
                var newStudent = JsonSerializer.Deserialize<Student>(requestObj.Data);
                if (newStudent == null) return "Invalid student data.";
                command = new AddStudentCommand(_studentRepository, newStudent);
                break;

            case "UpdateStudent":
                var updateStudent = JsonSerializer.Deserialize<Student>(requestObj.Data);
                if (updateStudent == null) return "Invalid student data.";
                command = new UpdateStudentCommand(_studentRepository, updateStudent);
                break;

            case "DeleteStudent":
                var deleteStudentId = Guid.Parse(requestObj.Data);
                command = new DeleteStudentCommand(_studentRepository, deleteStudentId);
                break;

            case "GetStudentById":
                var studentId = Guid.Parse(requestObj.Data);
                command = new GetStudentByIdCommand(_studentRepository, studentId);
                break;

            case "SearchStudents":
                var studentSearchQuery = requestObj.Data;
                command = new SearchStudentsCommand(_studentRepository, studentSearchQuery);
                break;

            // Course Management Commands
            case "AddCourse":
                var newCourse = JsonSerializer.Deserialize<Course>(requestObj.Data);
                if (newCourse == null) return "Invalid course data.";
                command = new AddCourseCommand(_courseRepository, newCourse);
                break;

            case "DeleteCourse":
                var deleteCourseId = Guid.Parse(requestObj.Data);
                command = new DeleteCourseCommand(_courseRepository, deleteCourseId);
                break;

            case "GetCourseById":
                var courseId = Guid.Parse(requestObj.Data);
                command = new GetCourseByIdCommand(_courseRepository, courseId);
                break;

            case "SearchCourses":
                var courseSearchQuery = requestObj.Data;
                command = new SearchCoursesCommand(_courseRepository, courseSearchQuery);
                break;

            // Enrollment Management Commands
            case "EnrollStudent":
                var enrollData = JsonSerializer.Deserialize<EnrollRequest>(requestObj.Data);
                if (enrollData == null) return "Invalid enrollment data.";
                command = new EnrollStudentCommand(_enrollmentRepository, enrollData.StudentId, enrollData.CourseId);
                break;

            case "UnenrollStudent":
                var unenrollData = JsonSerializer.Deserialize<EnrollRequest>(requestObj.Data);
                if (unenrollData == null) return "Invalid unenrollment data.";
                command = new UnenrollStudentCommand(_enrollmentRepository, unenrollData.StudentId, unenrollData.CourseId);
                break;

            case "GetCoursesByStudentId":
                var coursesStudentId = Guid.Parse(requestObj.Data);
                command = new GetCoursesForStudentCommand(_enrollmentRepository, coursesStudentId);
                break;

            case "GetStudentsByCourseId":
                var studentsCourseId = Guid.Parse(requestObj.Data);
                command = new GetStudentsForCourseCommand(_enrollmentRepository, studentsCourseId);
                break;

            // Default Case for Unknown Commands
            default:
                return "Unknown command.";
        }

                // Execute the command and return the response
                return command.Execute();
            }
            catch (Exception ex)
            {
                return $"Error processing request: {ex.Message}";
            }
        }

        private string GetClientIdentifier()
        {
            return Thread.CurrentThread.ManagedThreadId.ToString(); // id client by thread
        }

    }
}
