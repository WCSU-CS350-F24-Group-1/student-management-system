using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class EnrollStudentCommand : ICommand
    {
        private readonly EnrollmentRepository _enrollmentRepository;
        private readonly Guid _studentId;
        private readonly Guid _courseId;

        public EnrollStudentCommand(EnrollmentRepository enrollmentRepository, Guid studentId, Guid courseId)
        {
            _enrollmentRepository = enrollmentRepository;
            _studentId = studentId;
            _courseId = courseId;
        }

        public string Execute()
        {
            return _enrollmentRepository.AddEnrollment(_studentId, _courseId);
        }
    }
}
