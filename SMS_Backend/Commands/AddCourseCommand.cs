using SMS_Backend.Repositories;
using SMS_Backend.Models;

namespace SMS_Backend.Commands
{
    public class AddCourseCommand : ICommand
    {
        private readonly CourseRepository _repository;
        private readonly Course _course;

        public AddCourseCommand(CourseRepository repository, Course course)
        {
            _repository = repository;
            _course = course;
        }

        public string Execute()
        {
            return _repository.AddCourse(_course);
        }
    }
}
