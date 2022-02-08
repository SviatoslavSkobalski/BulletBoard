using BulletBoard.Application.Base;
using BulletBoard.Application.Items.Responses;

namespace BulletBoard.Application.Items.Queries
{
    public sealed record GetItemQuery(string id) : IQuery<GetItemResponse>
    {
    }
}
