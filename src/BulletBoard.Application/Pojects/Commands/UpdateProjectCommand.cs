using BulletBoard.Application.Base;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Pojects.Commands
{
    public sealed record UpdateProjectCommand(Project project) : ICommand
    {
    }
}
