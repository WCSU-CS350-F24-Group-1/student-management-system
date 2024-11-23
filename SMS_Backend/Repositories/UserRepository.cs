using System;
using System.Collections.Generic;
using Npgsql;
using SMS_Backend.Models;

namespace SMS_Backend.Repositories
{
    public class UserRepository
    {
        private readonly NpgsqlConnection _connection;

        public UserRepository(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public string AddUser(User user)
        {
            try
            {
                {
                    var query = @"
                        INSERT INTO Users (user_id, username, password, role, department, office_location)
                        VALUES (@UserId, @Username, @Password, @Role, @Department, @OfficeLocation)";

                    using (var command = new NpgsqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@UserId", user.UserId);
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@Role", user.Role);
                        command.Parameters.AddWithValue("@Department", user.Department);
                        command.Parameters.AddWithValue("@OfficeLocation", user.OfficeLocation);
                        command.ExecuteNonQuery();
                    }
                }
                return "User added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding user: {ex.Message}";
            }
        }

        public User GetUserById(Guid userId)
        {
            try
            {
                {
                    var query = "SELECT * FROM Users WHERE user_id = @UserId";

                    using (var command = new NpgsqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserId = reader.GetGuid(0),
                                    Username = reader.GetString(1),
                                    Password = reader.GetString(2),
                                    Role = reader.GetString(3),
                                    Department = reader.GetString(4),
                                    OfficeLocation = reader.GetString(5)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving user: {ex.Message}");
            }
            return null;
        }

        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            try
            {
                {
                    var query = "SELECT * FROM Users";

                    using (var command = new NpgsqlCommand(query, _connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                UserId = reader.GetGuid(0),
                                Username = reader.GetString(1),
                                Password = reader.GetString(2),
                                Role = reader.GetString(3),
                                Department = reader.GetString(4),
                                OfficeLocation = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving all users: {ex.Message}");
            }
            return users;
        }

        public string DeleteUser(Guid userId)
        {
            try
            {
                {
                    var query = "DELETE FROM Users WHERE user_id = @UserId";

                    using (var command = new NpgsqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        var rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0 ? "User deleted successfully." : "User not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting user: {ex.Message}";
            }
        }

        public User AuthenticateUser(string username, string password)
        {
            try
            {
                {
                    var query = "SELECT * FROM Users WHERE username = @Username AND password = @Password";

                    using (var command = new NpgsqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserId = reader.GetGuid(0),
                                    Username = reader.GetString(1),
                                    Password = reader.GetString(2),
                                    Role = reader.GetString(3),
                                    Department = reader.GetString(4),
                                    OfficeLocation = reader.GetString(5)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error authenticating user: {ex.Message}");
            }
            return null;
        }
    }
}
