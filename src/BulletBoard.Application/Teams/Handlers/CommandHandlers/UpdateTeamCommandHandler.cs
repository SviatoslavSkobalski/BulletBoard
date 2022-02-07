using BulletBoard.Application.Base;
using BulletBoard.Application.Teams.Commands;
using BulletBoard.Application.Teams.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Teams.Handlers.CommandHandlers
{
    internal class UpdateTeamCommandHandler : ICommandHandler<UpdateTeamCommand>
    {
        private readonly TeamsRepository _teamsRepository;

        public UpdateTeamCommandHandler(TeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }

        public async Task<IResponse> Handle(UpdateTeamCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var result = await _teamsRepository.UpdateAsync(request.team);

            return new TeamCommandResponse(result);
        }
    }
}
