using BulletBoard.Core.Models;

namespace BulletBoard.Application.Items.Responses
{
    public class GetAllItemsResponse
    {
        public GetAllItemsResponse(IEnumerable<Item> items)
        {
            Response = items;
        }
        public IEnumerable<Item> Response { get; }
    }
}
