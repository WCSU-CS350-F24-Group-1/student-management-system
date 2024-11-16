using Xunit;

public class RemoveStudentTests
{
    private StudentService _studentService;

    public RemoveStudentTests()
    {
        _studentService = new StudentService(); // Handles student-related operations
    }

    [Fact]
    public void RemoveStudent_StudentExists_ConfirmAndDelete()
    {
        // Arrange: Add a sample student to the system
        var studentId = 1;
        _studentService.AddStudent(new Student { Id = studentId, Name = "John Doe" });

        // Act: Call the RemoveStudent method
        var result = _studentService.RemoveStudent(studentId);

        // Assert: Verify that the student was removed successfully
        Assert.True(result, "Student should be removed successfully.");
        Assert.False(_studentService.StudentExists(studentId), "Student should no longer exist in the system.");
    }

    [Fact]
    public void RemoveStudent_StudentDoesNotExist_ReturnsFalse()
    {
        // Arrange: Ensure the student does not exist
        var studentId = 2;

        // Act: Attempt to remove a non-existent student
        var result = _studentService.RemoveStudent(studentId);

        // Assert: Verify that the removal failed
        Assert.False(result, "Attempt to remove a non-existent student should return false.");
    }

    [Fact]
    public void RemoveStudent_ConfirmRemoval_DeletesStudent()
    {
        // Arrange: Add a sample student and simulate admin confirmation
        var studentId = 3;
        _studentService.AddStudent(new Student { Id = studentId, Name = "Jane Doe" });

        // Act: Call the ConfirmRemoval and RemoveStudent methods
        var confirmResult = _studentService.ConfirmRemoval(studentId);
        var removeResult = _studentService.RemoveStudent(studentId);

        // Assert: Verify that the student was confirmed and removed successfully
        Assert.True(confirmResult, "Student removal should be confirmed.");
        Assert.True(removeResult, "Student should be removed after confirmation.");
        Assert.False(_studentService.StudentExists(studentId), "Student should no longer exist after removal.");
    }
}
