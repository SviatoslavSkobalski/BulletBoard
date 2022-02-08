using BulletBoard.Application.Base;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Teams.Commands
{
    public sealed record CreateTeamCommand(Team team) : ICommand
    {
    }
}
