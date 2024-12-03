using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class AuthenticateUserCommand : ICommand
    {
        private readonly UserRepository _repository;
        private readonly string _username;
        private readonly string _password;

        public AuthenticateUserCommand(UserRepository repository, string username, string password)
        {
            _repository = repository;
            _username = username;
            _password = password;
        }

        public string Execute()
        {
            var isAuthenticated = _repository.AuthenticateUser(_username, _password);
            return isAuthenticated ? "Authentication successful." : "Authentication failed.";
        }
    }
}
