using BulletBoard.Application.Base;
using BulletBoard.Application.Teams.Responses;

namespace BulletBoard.Application.Teams.Queries
{
    public sealed record GetTeamQuery(string id) : IQuery<GetTeamResponse>
    {
    }
}
