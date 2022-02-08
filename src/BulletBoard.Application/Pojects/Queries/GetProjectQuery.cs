using BulletBoard.Application.Base;
using BulletBoard.Application.Pojects.Responses;

namespace BulletBoard.Application.Pojects.Queries
    
{
    public sealed record GetProjectQuery(string id) : IQuery<GetProjectResponse>
    {
    }
}
