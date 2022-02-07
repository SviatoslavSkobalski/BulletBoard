using BulletBoard.Application.Base;
using BulletBoard.Application.Teams.Queries;
using BulletBoard.Application.Teams.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Teams.Handlers.QueryHandlers
{
    public class GetTeamQueryHandler : IQueryHandler<GetTeamQuery, GetTeamResponse>
    {
        private readonly TeamsRepository _teamsRepository;

        public GetTeamQueryHandler(TeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }
        public async Task<GetTeamResponse> Handle(GetTeamQuery request, CancellationToken cancellationToken)
        {
            var result = await _teamsRepository.GetByIdAsync(request.id);

            return new GetTeamResponse(result);
        }
    }
}
