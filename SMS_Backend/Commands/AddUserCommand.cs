using SMS_Backend.Repositories;
using SMS_Backend.Models;

namespace SMS_Backend.Commands
{
    public class AddUserCommand : ICommand
    {
        private readonly UserRepository _repository;
        private readonly User _user;

        public AddUserCommand(UserRepository repository, User user)
        {
            _repository = repository;
            _user = user;
        }

        public string Execute()
        {
            return _repository.AddUser(_user);
        }
    }
}
