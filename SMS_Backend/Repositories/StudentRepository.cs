using System;
using System.Collections.Generic;
using Npgsql;
using SMS_Backend.Models;

namespace SMS_Backend.Repositories
{
    public class StudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string AddStudent(Student student)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = @"
                        INSERT INTO Students (student_id, name, dob, email, phone, gpa, credits, major)
                        VALUES (@StudentId, @Name, @DateOfBirth, @Email, @Phone, @GPA, @Credits, @Major)";

                    using (var command = new NpgsqlCommand(query, connection))
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
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Students WHERE student_id = @StudentId";

                    using (var command = new NpgsqlCommand(query, connection))
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
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Students";

                    using (var command = new NpgsqlCommand(query, connection))
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
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM Students WHERE student_id = @StudentId";

                    using (var command = new NpgsqlCommand(query, connection))
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
    }
}
