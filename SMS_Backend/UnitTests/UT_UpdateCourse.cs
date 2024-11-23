// using Xunit;

// public class UpdateCourseTests
// {
//     private CourseService _courseService;

//     public UpdateCourseTests()
//     {
//         _courseService = new CourseService(); // Assuming this service handles course management
//     }

//     [Fact]
//     public void UpdateCourse_ValidData_UpdatesSuccessfully()
//     {
//         // Arrange: Set up a sample course and prepare updated data
//         var courseId = 1;
//         _courseService.AddCourse(new Course { Id = courseId, Name = "Math 101", Credits = 3 });

//         var updatedCourseData = new Course
//         {
//             Id = courseId,
//             Name = "Advanced Math 101",
//             Credits = 4
//         };

//         // Act: Call the UpdateCourse method
//         var result = _courseService.UpdateCourse(courseId, updatedCourseData);

//         // Assert: Ensure the course was updated successfully
//         Assert.True(result, "Course should be updated successfully.");
//         var course = _courseService.GetCourseById(courseId);
//         Assert.Equal("Advanced Math 101", course.Name);
//         Assert.Equal(4, course.Credits);
//     }

//     [Fact]
//     public void UpdateCourse_InvalidData_ReturnsFalse()
//     {
//         // Arrange: Set up a course and prepare invalid update data
//         var courseId = 2;
//         _courseService.AddCourse(new Course { Id = courseId, Name = "Science 101", Credits = 3 });

//         var invalidCourseData = new Course
//         {
//             Id = courseId,
//             Name = "", // Invalid name (empty)
//             Credits = -1 // Invalid credits (negative)
//         };

//         // Act: Call the UpdateCourse method with invalid data
//         var result = _courseService.UpdateCourse(courseId, invalidCourseData);

//         // Assert: Ensure the update was rejected
//         Assert.False(result, "Course update should fail with invalid data.");
//     }

//     [Fact]
//     public void UpdateCourse_NonExistentCourse_ReturnsFalse()
//     {
//         // Arrange: Prepare updated course data for a non-existent course
//         var courseId = 3;
//         var updatedCourseData = new Course
//         {
//             Id = courseId,
//             Name = "History 101",
//             Credits = 3
//         };

//         // Act: Attempt to update a non-existent course
//         var result = _courseService.UpdateCourse(courseId, updatedCourseData);

//         // Assert: Ensure the update was rejected
//         Assert.False(result, "Course update should fail if the course does not exist.");
//     }

//     [Fact]
//     public void UpdateCourse_UnauthorizedAccess_ThrowsException()
//     {
//         // Arrange: Set up a course and disable admin privileges
//         var courseId = 4;
//         _courseService.AddCourse(new Course { Id = courseId, Name = "Physics 101", Credits = 3 });
//         _courseService.DisableAdminPrivileges(); // Simulating unauthorized access

//         var updatedCourseData = new Course
//         {
//             Id = courseId,
//             Name = "Advanced Physics 101",
//             Credits = 4
//         };

//         // Act & Assert: Ensure an exception is thrown for unauthorized access
//         Assert.Throws<UnauthorizedAccessException>(() => _courseService.UpdateCourse(courseId, updatedCourseData));
//     }
// }
