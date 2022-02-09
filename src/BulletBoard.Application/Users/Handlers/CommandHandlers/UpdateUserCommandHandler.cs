using BulletBoard.Application.Base;
using BulletBoard.Application.Users.Commands;
using BulletBoard.Application.Users.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Users.Handlers.CommandHandlers
{
    public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand>
    {
        private readonly UsersRepository _usersRepository;

        public UpdateUserCommandHandler(UsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<IResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _usersRepository.UpdateAsync(request.user);

            return new UserCommandResponse(response);
        }
    }
}
