using BulletBoard.Application.Base;
using BulletBoard.Application.Users.Queries;
using BulletBoard.Application.Users.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Users.Handlers.QueryHandlers
{
    public class GetUsersQueryHandler : IQueryHandler<GetUsersQuery, GetUsersQueryResponse>
    {
        private readonly UsersRepository _usersRepository;

        public GetUsersQueryHandler(UsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<GetUsersQueryResponse> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _usersRepository.GetAllAsync();

            return new GetUsersQueryResponse(response);
        }
    }
}
