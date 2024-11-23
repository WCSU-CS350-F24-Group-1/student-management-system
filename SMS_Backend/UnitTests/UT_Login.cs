// using Xunit;

// public class AuthenticationServiceTests
// {
//     private AuthenticationService _authService;

//     // Constructor to initialize the AuthenticationService before each test
//     public AuthenticationServiceTests()
//     {
//         _authService = new AuthenticationService();
//     }

//     [Fact]
//     public void Authenticate_ValidCredentials_ReturnsTrue()
//     {
//         // Arrange: Set up valid username and password for the test
//         string username = "admin";
//         string password = "password123";
        
//         // Act: Call the Authenticate method with valid credentials
//         bool result = _authService.Authenticate(username, password);

//         // Assert: Check that the result is true, meaning authentication succeeded
//         Assert.True(result, "Authentication should succeed with valid credentials.");
//     }

//     [Fact]
//     public void Authenticate_InvalidPassword_ReturnsFalse()
//     {
//         // Arrange: Set up a valid username with an invalid password
//         string username = "admin";
//         string password = "wrongpassword";

//         // Act: Call the Authenticate method with an incorrect password
//         bool result = _authService.Authenticate(username, password);

//         // Assert: Check that the result is false, meaning authentication failed
//         Assert.False(result, "Authentication should fail with an invalid password.");
//     }

//     [Fact]
//     public void Authenticate_CheckAdminRole_ReturnsTrueIfAdmin()
//     {
//         // Arrange: Set up a valid username with an admin role
//         string username = "admin";
//         string password = "password123";

//         // Act: Call the IsAdmin method to check if the user has an admin role
//         bool isAdmin = _authService.IsAdmin(username);

//         // Assert: Check that the result is true, confirming the user has an admin role
//         Assert.True(isAdmin, "User should have admin role.");
//     }

//     [Fact]
//     public void Authenticate_ExceedsAllowedAttempts_ThrowsException()
//     {
//         // Arrange: Set up valid username and incorrect password to simulate failed attempts
//         string username = "admin";
//         string password = "wrongpassword";
        
//         // Act and Assert: Attempt to authenticate more than the allowed three times
//         // Using Assert.Throws to check if an InvalidOperationException is thrown after three attempts
//         Assert.Throws<InvalidOperationException>(() =>
//         {
//             for (int i = 0; i < 4; i++) // Simulating 4 attempts
//             {
//                 _authService.Authenticate(username, password);
//             }
//         });
//     }
// }
