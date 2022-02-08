using BulletBoard.Core.Models;

namespace BulletBoard.Application.Teams.Responses
{
    public class GetAllTeamsResponse
    {
        public GetAllTeamsResponse(IEnumerable<Team> teams)
        {
            Response = teams;
        }
        public IEnumerable<Team> Response { get; }
    }
}
