using BulletBoard.Application.Base;
using BulletBoard.Application.Teams.Responses;

namespace BulletBoard.Application.Teams.Queries
{
    public sealed record GetAllTeamsQuery : IQuery<GetAllTeamsResponse>
    {
    }
}
