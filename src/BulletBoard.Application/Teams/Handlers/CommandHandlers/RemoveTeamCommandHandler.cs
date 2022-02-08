using BulletBoard.Application.Base;
using BulletBoard.Application.Teams.Commands;
using BulletBoard.Application.Teams.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Teams.Handlers.CommandHandlers
{
    internal class RemoveTeamCommandHandler : ICommandHandler<RemoveTeamCommand>
    {
        private readonly TeamsRepository _teamsRepository;

        public RemoveTeamCommandHandler(TeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }
        public async Task<IResponse> Handle(RemoveTeamCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (request == null)
            {
                throw new ArgumentNullException();
            }

            var result = await _teamsRepository.DeleteAsync(request.team);

            return new TeamCommandResponse(result);
        }
    }
}
