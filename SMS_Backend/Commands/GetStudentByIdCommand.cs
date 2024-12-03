using SMS_Backend.Repositories;
using System.Text.Json;


namespace SMS_Backend.Commands
{
    public class GetStudentByIdCommand : ICommand
    {
        private readonly StudentRepository _repository;
        private readonly Guid _studentId;

        public GetStudentByIdCommand(StudentRepository repository, Guid studentId)
        {
            _repository = repository;
            _studentId = studentId;
        }

        public string Execute()
        {
            var student = _repository.GetStudentById(_studentId);
            return student != null ? JsonSerializer.Serialize(student) : "Student not found.";
        }
    }
}
