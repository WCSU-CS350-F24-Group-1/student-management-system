using System.Text.Json;
using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class GetUserByIdCommand : ICommand
    {
        private readonly UserRepository _repository;
        private readonly Guid _userId;

        public GetUserByIdCommand(UserRepository repository, Guid userId)
        {
            _repository = repository;
            _userId = userId;
        }

        public string Execute()
        {
            var user = _repository.GetUserById(_userId);
            return user != null ? JsonSerializer.Serialize(user) : "User not found.";
        }
    }
}
