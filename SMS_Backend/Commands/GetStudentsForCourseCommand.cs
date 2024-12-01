using System.Text.Json;
using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class GetStudentsForCourseCommand : ICommand
    {
        private readonly EnrollmentRepository _repository;
        private readonly Guid _courseId;

        public GetStudentsForCourseCommand(EnrollmentRepository repository, Guid courseId)
        {
            _repository = repository;
            _courseId = courseId;
        }

        public string Execute()
        {
            var students = _repository.GetStudentsForCourse(_courseId);
            return JsonSerializer.Serialize(students);
        }
    }
}
