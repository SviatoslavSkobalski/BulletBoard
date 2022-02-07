using BulletBoard.Application.Base;
using BulletBoard.Application.Teams.Queries;
using BulletBoard.Application.Teams.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Teams.Handlers.QueryHandlers
{
    public class GetAllTeamsQueryHandler : IQueryHandler<GetAllTeamsQuery, GetAllTeamsResponse>
    {
        private readonly TeamsRepository _teamsRepository;

        public GetAllTeamsQueryHandler(TeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }
        public async Task<GetAllTeamsResponse> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var result = await _teamsRepository.GetAllAsync();

            return new GetAllTeamsResponse(result);
        }
    }
}
