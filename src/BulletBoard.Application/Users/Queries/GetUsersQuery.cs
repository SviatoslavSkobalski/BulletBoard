using BulletBoard.Application.Base;
using BulletBoard.Application.Users.Responses;

namespace BulletBoard.Application.Users.Queries
{
    public sealed record GetUsersQuery : IQuery<GetUsersQueryResponse>
    {
    }
}
