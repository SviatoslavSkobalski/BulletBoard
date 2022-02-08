using BulletBoard.Application.Base;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Teams.Responses
{
    public class TeamCommandResponse : IResponse
    {
        public TeamCommandResponse(Team team)
        {
            Team = team;
        }

        public Team Team { get; }

        public object Response => Team;
    }
}
