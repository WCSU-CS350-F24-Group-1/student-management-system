using SMS_Backend.Repositories;
using SMS_Backend.Models;

namespace SMS_Backend.Commands
{
    public class AddStudentCommand : ICommand
    {
        private readonly StudentRepository _repository;
        private readonly Student _student;

        public AddStudentCommand(StudentRepository repository, Student student)
        {
            _repository = repository;
            _student = student;
        }

        public string Execute()
        {
            return _repository.AddStudent(_student);
        }
    }
}
