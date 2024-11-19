using System;
using System.Collections.Generic;
using Npgsql;
using SMS_Backend.Models;

namespace SMS_Backend.Repositories
{
    public class EnrollmentRepository
    {
        private readonly string _connectionString;

        public EnrollmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string AddEnrollment(Guid studentId, Guid courseId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = @"
                        INSERT INTO Enrollment (student_id, course_id)
                        VALUES (@StudentId, @CourseId)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        command.Parameters.AddWithValue("@CourseId", courseId);
                        command.ExecuteNonQuery();
                    }
                }
                return "Enrollment added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding enrollment: {ex.Message}";
            }
        }

        public string RemoveEnrollment(Guid studentId, Guid courseId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = @"
                        DELETE FROM Enrollment
                        WHERE student_id = @StudentId AND course_id = @CourseId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        command.Parameters.AddWithValue("@CourseId", courseId);
                        var rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0 ? "Enrollment removed successfully." : "Enrollment not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error removing enrollment: {ex.Message}";
            }
        }

        public List<Guid> GetCoursesForStudent(Guid studentId)
        {
            var courses = new List<Guid>();
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT course_id FROM Enrollment WHERE student_id = @StudentId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                courses.Add(reader.GetGuid(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving courses for student: {ex.Message}");
            }
            return courses;
        }

        public List<Guid> GetStudentsForCourse(Guid courseId)
        {
            var students = new List<Guid>();
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT student_id FROM Enrollment WHERE course_id = @CourseId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseId", courseId);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                students.Add(reader.GetGuid(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving students for course: {ex.Message}");
            }
            return students;
        }
    }
}
