using BulletBoard.Application.Items.Commands;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Items.Mappers
{
    public class ItemMapper
    {
        public CreateItemCommand MapToCreateCommand(Item item)
        {
            return new CreateItemCommand(item);
        }
        public UpdateItemCommand MapToUpdateCommand(Item item)
        {
            return new UpdateItemCommand(item);
        }
        public RemoveItemCommand MapToRemoveCommand(Item item)
        {
            return new RemoveItemCommand(item);
        }
    }
}
