using SMS_Backend.Repositories;
using SMS_Backend.Models;

namespace SMS_Backend.Commands
{
    public class UpdateUserCommand : ICommand
    {
        private readonly UserRepository _repository;
        private readonly User _user;
        private readonly User _authenticatedUser;

        public UpdateUserCommand(UserRepository repository, User user, User authenticatedUser)
        {
            _repository = repository;
            _user = user;
            _authenticatedUser = authenticatedUser;
        }

        public string Execute()
        {
            // Allow self updates only if already logged in 
            if (_authenticatedUser.UserId != _user.UserId)
            {
                return "Permission denied: Nice try bucko! You can only update your own account.";
            }

            // go ahead with the update
            return _repository.UpdateUser(_user);
        }
    }
}
