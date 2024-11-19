using System;
using System.Collections.Generic;
using Npgsql;
using SMS_Backend.Models;

namespace SMS_Backend.Repositories
{
    public class CourseRepository
    {
        private readonly string _connectionString;

        public CourseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string AddCourse(Course course)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = @"
                        INSERT INTO Courses (course_id, course_name, credit_hours, professor_id)
                        VALUES (@CourseId, @CourseName, @CreditHours, @ProfessorId)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseId", course.CourseId);
                        command.Parameters.AddWithValue("@CourseName", course.CourseName);
                        command.Parameters.AddWithValue("@CreditHours", course.CreditHours);
                        command.Parameters.AddWithValue("@ProfessorId", course.ProfessorId);
                        command.ExecuteNonQuery();
                    }
                }
                return "Course added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding course: {ex.Message}";
            }
        }

        public Course GetCourseById(Guid courseId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Courses WHERE course_id = @CourseId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseId", courseId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Course
                                {
                                    CourseId = reader.GetGuid(0),
                                    CourseName = reader.GetString(1),
                                    CreditHours = reader.GetInt32(2),
                                    ProfessorId = reader.GetGuid(3)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving course: {ex.Message}");
            }
            return null;
        }

        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Courses";

                    using (var command = new NpgsqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course
                            {
                                CourseId = reader.GetGuid(0),
                                CourseName = reader.GetString(1),
                                CreditHours = reader.GetInt32(2),
                                ProfessorId = reader.GetGuid(3)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving all courses: {ex.Message}");
            }
            return courses;
        }

        public string DeleteCourse(Guid courseId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM Courses WHERE course_id = @CourseId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseId", courseId);
                        var rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0 ? "Course deleted successfully." : "Course not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting course: {ex.Message}";
            }
        }
    }
}
