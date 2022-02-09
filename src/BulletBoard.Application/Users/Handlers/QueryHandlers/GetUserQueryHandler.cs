using BulletBoard.Application.Base;
using BulletBoard.Application.Users.Queries;
using BulletBoard.Application.Users.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Users.Handlers.QueryHandlers
{
    public class GetUserQueryHandler : IQueryHandler<GetUserQuery, GetUserQueryResponse>
    {
        private readonly UsersRepository _userRepository;

        public GetUserQueryHandler(UsersRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GetUserQueryResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _userRepository.GetByIdAsync(request.id);

            return new GetUserQueryResponse(response);
        }
    }
}
