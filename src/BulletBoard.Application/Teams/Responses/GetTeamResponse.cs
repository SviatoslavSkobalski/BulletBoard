using BulletBoard.Core.Models;

namespace BulletBoard.Application.Teams.Responses
{
    public class GetTeamResponse
    {
        public GetTeamResponse(Team team)
        {
            Response = team;
        }
        public Team Response { get; }
    }
}
