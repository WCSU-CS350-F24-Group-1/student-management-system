using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class UnenrollStudentCommand : ICommand
    {
        private readonly EnrollmentRepository _repository;
        private readonly Guid _studentId;
        private readonly Guid _courseId;

        public UnenrollStudentCommand(EnrollmentRepository repository, Guid studentId, Guid courseId)
        {
            _repository = repository;
            _studentId = studentId;
            _courseId = courseId;
        }

        public string Execute()
        {
            return _repository.RemoveEnrollment(_studentId, _courseId);
        }
    }
}
