using BulletBoard.Application.Base;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Items.Commands
{
    public sealed record RemoveItemCommand(Item item) : ICommand
    {
    }
}
