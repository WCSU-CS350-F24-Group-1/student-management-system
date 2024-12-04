using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class DeleteStudentCommand : ICommand
    {
        private readonly StudentRepository _repository;
        private readonly Guid _studentId;

        public DeleteStudentCommand(StudentRepository repository, Guid studentId)
        {
            _repository = repository;
            _studentId = studentId;
        }

        public string Execute()
        {
            return _repository.DeleteStudent(_studentId);
        }
    }
}
