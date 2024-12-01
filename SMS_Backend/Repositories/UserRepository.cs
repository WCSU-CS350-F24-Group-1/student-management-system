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

        public string UpdateUser(User user)
        {
            try
            {
                var query = @"
                    UPDATE Users
                    SET username = @Username,
                        password = @Password,
                        role = @Role,
                        department = @Department,
                        office_location = @OfficeLocation
                    WHERE user_id = @UserId";

                using (var command = new NpgsqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@UserId", user.UserId);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role);
                    command.Parameters.AddWithValue("@Department", user.Department);
                    command.Parameters.AddWithValue("@OfficeLocation", user.OfficeLocation);

                    var rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0 ? "User updated successfully." : "User not found.";
                }
            }
            catch (Exception ex)
            {
                return $"Error updating user: {ex.Message}";
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
                    var query = "SELECT user_id, username, role, department, office_location FROM Users";

                    using (var command = new NpgsqlCommand(query, _connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                UserId = reader.GetGuid(0),
                                Username = reader.GetString(1),
                                Role = reader.GetString(2),
                                Department = reader.GetString(3),
                                OfficeLocation = reader.GetString(4)
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

        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                var query = "SELECT COUNT(*) FROM Users WHERE username = @Username AND password = @Password";

                using (var command = new NpgsqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    var count = (long)command.ExecuteScalar(); // Assuming COUNT(*) returns an integer or long
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error authenticating user: {ex.Message}");
                return false;
            }
        }
    }
}
