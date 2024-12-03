using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class DeleteCourseCommand : ICommand
    {
        private readonly CourseRepository _repository;
        private readonly Guid _courseId;

        public DeleteCourseCommand(CourseRepository repository, Guid courseId)
        {
            _repository = repository;
            _courseId = courseId;
        }

        public string Execute()
        {
            return _repository.DeleteCourse(_courseId);
        }
    }
}
