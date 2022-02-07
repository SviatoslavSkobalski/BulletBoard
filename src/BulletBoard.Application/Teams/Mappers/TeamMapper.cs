using BulletBoard.Application.Teams.Commands;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Teams.Mappers
{
    public class TeamMapper
    {
        public CreateTeamCommand MapToCreateCommand(Team team)
        {
            if (team == null || string.IsNullOrEmpty(team.Name))
            {
                throw new ArgumentNullException(nameof(team));
            }

            return new CreateTeamCommand(team);
        }

        public UpdateTeamCommand MapToUpdateCommand(Team team)
        {
            if (team == null || string.IsNullOrEmpty(team.Name))
            {
                throw new ArgumentNullException(nameof(team));
            }

            return new UpdateTeamCommand(team);
        }

        public RemoveTeamCommand MapToRemoveCommand(Team team)
        {
            if(team == null || string.IsNullOrEmpty(team.Name))
            {
                throw new ArgumentNullException(nameof (team));
            }

            return new RemoveTeamCommand(team);
        }
    }
}
