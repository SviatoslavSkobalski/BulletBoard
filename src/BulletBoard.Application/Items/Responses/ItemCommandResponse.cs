using BulletBoard.Application.Base;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Items.Responses
{
    public class ItemCommandResponse : IResponse
    {
        public ItemCommandResponse(Item item)
        {
            Response = item;
        }
        public object Response { get; }
    }
}
