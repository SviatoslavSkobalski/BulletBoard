using BulletBoard.Application.Base;
using BulletBoard.Application.Users.Responses;
using BulletBoard.Core.Entities;

namespace BulletBoard.Application.Users.Queries
{
    public sealed record GetUserQuery(string id) : IQuery<GetUserQueryResponse>
    {
    }
}
