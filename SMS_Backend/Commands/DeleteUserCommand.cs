using SMS_Backend.Repositories;

namespace SMS_Backend.Commands
{
    public class DeleteUserCommand : ICommand
    {
        private readonly UserRepository _repository;
        private readonly Guid _userId;

        public DeleteUserCommand(UserRepository repository, Guid userId)
        {
            _repository = repository;
            _userId = userId;
        }

        public string Execute()
        {
            return _repository.DeleteUser(_userId);
        }
    }
}
