using BulletBoard.Application.Users.Commands;
using BulletBoard.Core.Entities;

namespace BulletBoard.Application.Users.Mappers
{
    public class UserMapper
    {
        public CreateUserCommand MapToCreateUserCommand(User user)
        {
            return new CreateUserCommand(user);
        }
        public UpdateUserCommand MapToUpdateUserCommand(User user)
        {
            return new UpdateUserCommand(user);
        }
        public RemoveUserCommand MapToRemoveUserCommand(User user)
        {
            return new RemoveUserCommand(user);
        }
    }
}
