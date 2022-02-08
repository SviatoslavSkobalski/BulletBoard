using BulletBoard.Application.Base;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Pojects.Commands
{
    public sealed record RemoveProjectCommand(Project project) : ICommand
    {
    }
}
