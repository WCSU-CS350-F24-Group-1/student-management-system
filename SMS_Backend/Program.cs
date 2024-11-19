// See https://aka.ms/new-console-template for more information

using System;
using SMS_Backend.Models;
using SMS_Backend.Repositories;

namespace SMS_Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dbConnection = new Services.DatabaseConnection();
             dbConnection.TestConnection();

            Console.WriteLine("Starting TestRepositories...");

            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=supersaiyanuser;Database=sms_database";

           var studentRepository = new StudentRepository(connectionString);
    var courseRepository = new CourseRepository(connectionString);
    var userRepository = new UserRepository(connectionString);
    var enrollmentRepository = new EnrollmentRepository(connectionString);

    try
    {
        // Test UserRepository
        Console.WriteLine("\n=== Testing UserRepository ===");
        var professor = new User
        {
            UserId = Guid.NewGuid(),
            Username = "professor",
            Password = "password123",
            Role = "Professor",
            Department = "Computer Science",
            OfficeLocation = "Room 201"
        };
        Console.WriteLine(userRepository.AddUser(professor));

        // Test StudentRepository
        Console.WriteLine("\n=== Testing StudentRepository ===");
        var student = new Student
        {
            StudentId = Guid.NewGuid(),
            Name = "Jane Doe",
            DateOfBirth = new DateTime(1995, 5, 15),
            Email = "janedoe@example.com",
            Phone = "555-5678",
            GPA = 3.5m,
            Credits = 90,
            Major = "Physics"
        };
        Console.WriteLine(studentRepository.AddStudent(student));

        // Test CourseRepository
        Console.WriteLine("\n=== Testing CourseRepository ===");
        var course = new Course
        {
            CourseId = Guid.NewGuid(),
            CourseName = "Algorithms",
            CreditHours = 3,
            ProfessorId = professor.UserId // Reference the professor ID
        };
        Console.WriteLine(courseRepository.AddCourse(course));

        // Test EnrollmentRepository
        Console.WriteLine("\n=== Testing EnrollmentRepository ===");
        Console.WriteLine(enrollmentRepository.AddEnrollment(student.StudentId, course.CourseId));

        // Clean up
        Console.WriteLine(enrollmentRepository.RemoveEnrollment(student.StudentId, course.CourseId));
        Console.WriteLine(courseRepository.DeleteCourse(course.CourseId));
        Console.WriteLine(studentRepository.DeleteStudent(student.StudentId));
        Console.WriteLine(userRepository.DeleteUser(professor.UserId));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error during testing: {ex.Message}");
    }
        }
    }
}
