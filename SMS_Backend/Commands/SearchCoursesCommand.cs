using System.Text.Json;
using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class SearchCoursesCommand : ICommand
    {
        private readonly CourseRepository _repository;
        private readonly string _searchQuery;

        public SearchCoursesCommand(CourseRepository repository, string searchQuery)
        {
            _repository = repository;
            _searchQuery = searchQuery;
        }

        public string Execute()
        {
            var courses = _repository.SearchCourses(_searchQuery);
            return JsonSerializer.Serialize(courses);
        }
    }
}
