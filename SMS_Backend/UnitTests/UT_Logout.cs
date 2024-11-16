using Xunit;

public class LogoutTests
{
    private AuthenticationService _authService;

    // Constructor to initialize the AuthenticationService before each test
    public LogoutTests()
    {
        _authService = new AuthenticationService();
    }

    [Fact]
    public void Logout_EndsSession_SessionIsInactive()
    {
        // Arrange: Log in to ensure a session is active
        string username = "admin";
        string password = "password123";
        _authService.Authenticate(username, password);

        // Act: Call the Logout method to end the session
        _authService.Logout();

        // Assert: Verify that the session is no longer active
        bool isSessionActive = _authService.IsSessionActive();
        Assert.False(isSessionActive, "Session should be inactive after logout.");
    }

    [Fact]
    public void Logout_WithoutActiveSession_DoesNotThrowException()
    {
        // Arrange: Ensure no session is active
        if (_authService.IsSessionActive())
        {
            _authService.Logout();
        }

        // Act & Assert: Ensure that calling Logout without an active session does not throw exceptions
        var exception = Record.Exception(() => _authService.Logout());
        Assert.Null(exception);
    }
}
