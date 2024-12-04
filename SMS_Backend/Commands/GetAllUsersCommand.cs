using SMS_Backend.Repositories;
using System.Text.Json;

namespace SMS_Backend.Commands
{
    public class GetAllUsersCommand : ICommand
    {
        private readonly UserRepository _repository;

        public GetAllUsersCommand(UserRepository repository)
        {
            _repository = repository;
        }

        public string Execute()
        {
            try
            {
                var users = _repository.GetAllUsers();
                return JsonSerializer.Serialize(users);
            }
            catch (Exception ex)
            {
                return $"Error retrieving users: {ex.Message}";
            }
        }
    }
}
