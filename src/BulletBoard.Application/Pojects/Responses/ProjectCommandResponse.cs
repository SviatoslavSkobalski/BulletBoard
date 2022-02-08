using BulletBoard.Application.Base;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Pojects.Responses
{
    internal class ProjectCommandResponse : IResponse
    {
        public ProjectCommandResponse(Project project)
        {
            Response = project;
        }
        public object Response { get; }
    }
}
