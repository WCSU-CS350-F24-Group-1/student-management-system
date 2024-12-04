// using Xunit;

// public class SearchStudentTests
// {
//     private StudentService _studentService;

//     public SearchStudentTests()
//     {
//         _studentService = new StudentService(); // Handles student-related operations
//     }

//     [Fact]
//     public void SearchStudent_ValidCriteria_ReturnsResults()
//     {
//         // Arrange: Add some sample students for the search
//         _studentService.AddStudent(new Student { Id = 1, Name = "John Doe", Grade = "A" });
//         _studentService.AddStudent(new Student { Id = 2, Name = "Jane Smith", Grade = "B" });

//         var searchCriteria = new StudentSearchCriteria
//         {
//             Name = "John"
//         };

//         // Act: Perform the search
//         var results = _studentService.SearchStudent(searchCriteria);

//         // Assert: Ensure valid results are returned
//         Assert.NotNull(results);
//         Assert.Single(results); // Only one student matches "John"
//         Assert.Equal("John Doe", results[0].Name);
//     }

//     [Fact]
//     public void SearchStudent_InvalidCriteria_ReturnsEmptyResults()
//     {
//         // Arrange: Add some sample students for the search
//         _studentService.AddStudent(new Student { Id = 1, Name = "John Doe", Grade = "A" });
//         _studentService.AddStudent(new Student { Id = 2, Name = "Jane Smith", Grade = "B" });

//         var searchCriteria = new StudentSearchCriteria
//         {
//             Name = "Michael" // No student named "Michael"
//         };

//         // Act: Perform the search
//         var results = _studentService.SearchStudent(searchCriteria);

//         // Assert: Ensure no results are returned
//         Assert.NotNull(results);
//         Assert.Empty(results); // No student matches "Michael"
//     }

//     [Fact]
//     public void SearchStudent_EmptyCriteria_ReturnsAllStudents()
//     {
//         // Arrange: Add some sample students for the search
//         _studentService.AddStudent(new Student { Id = 1, Name = "John Doe", Grade = "A" });
//         _studentService.AddStudent(new Student { Id = 2, Name = "Jane Smith", Grade = "B" });

//         var searchCriteria = new StudentSearchCriteria(); // Empty criteria

//         // Act: Perform the search
//         var results = _studentService.SearchStudent(searchCriteria);

//         // Assert: Ensure all students are returned
//         Assert.NotNull(results);
//         Assert.Equal(2, results.Count); // Two students exist
//     }

//     [Fact]
//     public void SearchStudent_NavigateBackToMainMenu()
//     {
//         // Arrange: Simulate selecting the "Search Record" option
//         _studentService.NavigateTo("Search Record");

//         // Act: Simulate going back to the main menu
//         _studentService.NavigateTo("Main Menu");

//         // Assert: Ensure the current menu is the main menu
//         var currentMenu = _studentService.GetCurrentMenu();
//         Assert.Equal("Main Menu", currentMenu);
//     }
// }
