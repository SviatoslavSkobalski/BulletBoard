using BulletBoard.Application.Base;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Teams.Commands
{
    public sealed record UpdateTeamCommand(Team team) : ICommand
    {
    }
}
