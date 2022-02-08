using BulletBoard.Application.Base;
using BulletBoard.Application.Pojects.Responses;

namespace BulletBoard.Application.Pojects.Queries
{
    public sealed record GetAllProjectsQuery : IQuery<GetAllProjectsResponse>
    {
    }
}
