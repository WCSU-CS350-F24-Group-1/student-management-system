using Xunit;

public class AddUserTests
{
    private UserService _userService;

    public AddUserTests()
    {
        _userService = new UserService(); // Assuming this is your service managing user operations
    }

    [Fact]
    public void AddUser_UserDoesNotExist_ConfirmUserAddition()
    {
        // Arrange: Set up a new user that does not exist
        var user = new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" };

        // Act: Call the AddUser method
        var result = _userService.AddUser(user);

        // Assert: Ensure the user was successfully added
        Assert.True(result, "User should be added successfully.");
        Assert.True(_userService.UserExists(user.Id), "User should exist after being added.");
    }

    [Fact]
    public void AddUser_UserAlreadyExists_RejectUserAddition()
    {
        // Arrange: Add an existing user to the system
        var user = new User { Id = 2, Name = "Jane Doe", Email = "jane.doe@example.com" };
        _userService.AddUser(user);

        // Act: Try to add the same user again
        var result = _userService.AddUser(user);

        // Assert: Ensure the user addition was rejected
        Assert.False(result, "User addition should be rejected if the user already exists.");
    }

    [Fact]
    public void AddUser_CheckUserExistence_BeforeAddition()
    {
        // Arrange: Create a new user
        var user = new User { Id = 3, Name = "Mark Smith", Email = "mark.smith@example.com" };

        // Act: Check if the user exists before adding
        var existsBefore = _userService.UserExists(user.Id);
        _userService.AddUser(user);
        var existsAfter = _userService.UserExists(user.Id);

        // Assert: Verify user existence is checked before and after addition
        Assert.False(existsBefore, "User should not exist before addition.");
        Assert.True(existsAfter, "User should exist after addition.");
    }
}
