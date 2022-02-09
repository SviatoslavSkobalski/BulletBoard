using BulletBoard.Application.Base;
using BulletBoard.Core.Entities;

namespace BulletBoard.Application.Users.Commands
{
    public sealed record UpdateUserCommand(User user) : ICommand
    {
    }
}
