using BulletBoard.Application.Base;
using BulletBoard.Application.Users.Commands;
using BulletBoard.Application.Users.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Users.Handlers.CommandHandlers
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly UsersRepository _usersRepository;

        public CreateUserCommandHandler(UsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public async Task<IResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _usersRepository.AddAsync(request.user);

            return new UserCommandResponse(response);
        }
    }
}
