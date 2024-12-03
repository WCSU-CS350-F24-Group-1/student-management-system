using System.Text.Json;
using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class GetCoursesForStudentCommand : ICommand
    {
        private readonly EnrollmentRepository _repository;
        private readonly Guid _studentId;

        public GetCoursesForStudentCommand(EnrollmentRepository repository, Guid studentId)
        {
            _repository = repository;
            _studentId = studentId;
        }

        public string Execute()
        {
            var courses = _repository.GetCoursesForStudent(_studentId);
            return JsonSerializer.Serialize(courses);
        }
    }
}
