using Xunit;

namespace UserManagementTests
{
    // Main UserService class for validation and deletion
    public class UserService
    {
        public bool ValidateUser(string username, string password)
        {
            // Simulate validation logic
            return username == "admin" && password == "password123";
        }

        public bool RemoveUser(string username, string password)
        {
            // Simulate removal logic after validation
            if (ValidateUser(username, password))
            {
                return true; // Simulate successful removal
            }
            return false; // Simulate failure
        }
    }

    // Unit Tests for UserService
    public class UserServiceTests
    {
        private readonly UserService _userService = new UserService();

        [Fact]
        public void ValidateUser_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string username = "admin";
            string password = "password123";

            // Act
            bool result = _userService.ValidateUser(username, password);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateUser_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            string username = "admin";
            string password = "wrongPassword";

            // Act
            bool result = _userService.ValidateUser(username, password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveUser_ValidUser_Success()
        {
            // Arrange
            string username = "admin";
            string password = "password123";

            // Act
            bool result = _userService.RemoveUser(username, password);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void RemoveUser_InvalidCredentials_Fails()
        {
            // Arrange
            string username = "admin";
            string password = "wrongPassword";

            // Act
            bool result = _userService.RemoveUser(username, password);

            // Assert
            Assert.False(result);
        }
    }
}