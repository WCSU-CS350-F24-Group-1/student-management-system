using System;
using System.Collections.Generic;
using Npgsql;
using SMS_Backend.Models;

namespace SMS_Backend.Repositories
{
    public class StudentRepository
    {
        private readonly NpgsqlConnection _connection;

        public StudentRepository(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public string AddStudent(Student student)
        {
            try
            {
                {
                    var query = @"
                        INSERT INTO Students (student_id, name, dob, email, phone, gpa, credits, major)
                        VALUES (@StudentId, @Name, @DateOfBirth, @Email, @Phone, @GPA, @Credits, @Major)";

                    using (var command = new NpgsqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", student.StudentId);
                        command.Parameters.AddWithValue("@Name", student.Name);
                        command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                        command.Parameters.AddWithValue("@Email", student.Email);
                        command.Parameters.AddWithValue("@Phone", student.Phone);
                        command.Parameters.AddWithValue("@GPA", student.GPA);
                        command.Parameters.AddWithValue("@Credits", student.Credits);
                        command.Parameters.AddWithValue("@Major", student.Major);
                        command.ExecuteNonQuery();
                    }
                }
                return "Student added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding student: {ex.Message}";
            }
        }

        public Student GetStudentById(Guid studentId)
        {
            try
            {
                {
                    var query = "SELECT * FROM Students WHERE student_id = @StudentId";

                    using (var command = new NpgsqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Student
                                {
                                    StudentId = reader.GetGuid(0),
                                    Name = reader.GetString(1),
                                    DateOfBirth = reader.GetDateTime(2),
                                    Email = reader.GetString(3),
                                    Phone = reader.GetString(4),
                                    GPA = reader.GetDecimal(5),
                                    Credits = reader.GetInt32(6),
                                    Major = reader.GetString(7)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving student: {ex.Message}");
            }
            return null;
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            try
            {
                {
                    var query = "SELECT * FROM Students";

                    using (var command = new NpgsqlCommand(query, _connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                StudentId = reader.GetGuid(0),
                                Name = reader.GetString(1),
                                DateOfBirth = reader.GetDateTime(2),
                                Email = reader.GetString(3),
                                Phone = reader.GetString(4),
                                GPA = reader.GetDecimal(5),
                                Credits = reader.GetInt32(6),
                                Major = reader.GetString(7)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving all students: {ex.Message}");
            }
            return students;
        }

        public string DeleteStudent(Guid studentId)
        {
            try
            {
                {
                    var query = "DELETE FROM Students WHERE student_id = @StudentId";

                    using (var command = new NpgsqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        var rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0 ? "Student deleted successfully." : "Student not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting student: {ex.Message}";
            }
        }

        public string UpdateStudent(Student student)
        {
            try
            {
                var query = @"
                    UPDATE Students
                    SET 
                        Name = @Name,
                        DateOfBirth = @DateOfBirth,
                        Email = @Email,
                        Phone = @Phone,
                        GPA = @GPA,
                        Credits = @Credits,
                        Major = @Major
                    WHERE StudentId = @StudentId";

                using (var command = new NpgsqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@StudentId", student.StudentId);
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@Phone", student.Phone);
                    command.Parameters.AddWithValue("@GPA", student.GPA);
                    command.Parameters.AddWithValue("@Credits", student.Credits);
                    command.Parameters.AddWithValue("@Major", student.Major);

                    var rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Student updated successfully." : "No student found with the provided ID.";
                }
            }
            catch (Exception ex)
            {
                return $"Error updating student: {ex.Message}";
            }
        }


        public List<Student> SearchStudents(string searchQuery)
        {
            var students = new List<Student>();

            try
            {
                var query = @"
                    SELECT StudentId, Name, DateOfBirth, Email, Phone, GPA, Credits, Major
                    FROM Students
                    WHERE Name ILIKE @SearchQuery OR CAST(StudentId AS TEXT) ILIKE @SearchQuery";

                using (var command = new NpgsqlCommand(query, _connection))
                {
                    // Add the parameter for the search query
                    command.Parameters.AddWithValue("@SearchQuery", $"%{searchQuery}%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create and add a student object to the list
                            students.Add(new Student
                            {
                                StudentId = reader.GetGuid(reader.GetOrdinal("StudentId")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                GPA = reader.GetDecimal(reader.GetOrdinal("GPA")),
                                Credits = reader.GetInt32(reader.GetOrdinal("Credits")),
                                Major = reader.GetString(reader.GetOrdinal("Major"))
                            });
                        }
                    }
                }
                return students;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching for students: {ex.Message}");
                return students;
            }
        }

    }
}
