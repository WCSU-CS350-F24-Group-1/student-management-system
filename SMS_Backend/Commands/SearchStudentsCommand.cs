using SMS_Backend.Repositories;
using System.Text.Json;


namespace SMS_Backend.Commands
{
    public class SearchStudentsCommand : ICommand
    {
        private readonly StudentRepository _repository;
        private readonly string _searchQuery;

        public SearchStudentsCommand(StudentRepository repository, string searchQuery)
        {
            _repository = repository;
            _searchQuery = searchQuery;
        }

        public string Execute()
        {
            var students = _repository.SearchStudents(_searchQuery);
            return JsonSerializer.Serialize(students);
        }
    }
}
