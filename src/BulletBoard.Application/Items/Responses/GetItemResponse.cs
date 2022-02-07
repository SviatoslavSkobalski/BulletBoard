using BulletBoard.Core.Models;

namespace BulletBoard.Application.Items.Responses
{
    public class GetItemResponse
    {
        public GetItemResponse(Item item)
        {
            Response = item;
        }
        public Item Response { get; }
    }
}
