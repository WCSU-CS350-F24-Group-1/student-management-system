using System;
using System.Collections.Generic;
using Npgsql;
using SMS_Backend.Models;

namespace SMS_Backend.Repositories
{
    public class CourseRepository
    {
        private readonly NpgsqlConnection _connection;

        public CourseRepository(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public string AddCourse(Course course)
        {
            try
            {
                {
                    var query = @"
                        INSERT INTO Courses (course_id, course_name, credit_hours, professor_id)
                        VALUES (@CourseId, @CourseName, @CreditHours, @ProfessorId)";

                    using (var command = new NpgsqlCommand(query, _connection))
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
                {
                    var query = "SELECT * FROM Courses WHERE course_id = @CourseId";

                    using (var command = new NpgsqlCommand(query, _connection))
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
                {
                    var query = "SELECT * FROM Courses";

                    using (var command = new NpgsqlCommand(query, _connection))
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
                {
                    var query = "DELETE FROM Courses WHERE course_id = @CourseId";

                    using (var command = new NpgsqlCommand(query, _connection))
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

        public List<Course> SearchCourses(string searchQuery)
        {
            var courses = new List<Course>();

            try
            {
                var query = @"
                    SELECT course_id, course_name, credit_hours, professor_id
                    FROM courses
                    WHERE LOWER(course_name) LIKE @SearchQuery";

                using (var command = new NpgsqlCommand(query, _connection))
                {
                    // Add parameter for case-insensitive search
                    command.Parameters.AddWithValue("@SearchQuery", $"%{searchQuery.ToLower()}%");

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
                Console.WriteLine($"Error searching courses: {ex.Message}");
            }

            return courses;
        }
    }
}
