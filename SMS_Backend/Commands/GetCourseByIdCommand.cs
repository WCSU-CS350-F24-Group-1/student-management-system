using SMS_Backend.Repositories;
using System.Text.Json;

namespace SMS_Backend.Commands
{
    public class GetCourseByIdCommand : ICommand
    {
        private readonly CourseRepository _repository;
        private readonly Guid _courseId;

        public GetCourseByIdCommand(CourseRepository repository, Guid courseId)
        {
            _repository = repository;
            _courseId = courseId;
        }

        public string Execute()
        {
            var course = _repository.GetCourseById(_courseId);
            return course != null ? JsonSerializer.Serialize(course) : "Course not found.";
        }
    }
}
