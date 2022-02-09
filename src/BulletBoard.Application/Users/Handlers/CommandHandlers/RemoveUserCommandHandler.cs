using BulletBoard.Application.Base;
using BulletBoard.Application.Users.Commands;
using BulletBoard.Application.Users.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Users.Handlers.CommandHandlers
{
    public class RemoveUserCommandHandler : ICommandHandler<RemoveUserCommand>
    {
        private readonly UsersRepository _usersRepoitory;

        public RemoveUserCommandHandler(UsersRepository usersRepoitory)
        {
            _usersRepoitory = usersRepoitory;
        }

        public async Task<IResponse> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _usersRepoitory.DeleteAsync(request.user);

            return new UserCommandResponse(response);
        }
    }
}
