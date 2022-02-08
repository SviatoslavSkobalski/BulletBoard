using BulletBoard.Application.Base;
using BulletBoard.Application.Teams.Commands;
using BulletBoard.Application.Teams.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Teams.Handlers.CommandHandlers
{
    public class CreateTeamCommandHandler : ICommandHandler<CreateTeamCommand>
    {
        private readonly TeamsRepository _teamsReposittory;

        public CreateTeamCommandHandler(TeamsRepository teamsRepository)
        {
            _teamsReposittory = teamsRepository;
        }
        public async Task<IResponse> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var result = await _teamsReposittory.AddAsync(request.team);

            return new TeamCommandResponse(result);
        }
    }
}
