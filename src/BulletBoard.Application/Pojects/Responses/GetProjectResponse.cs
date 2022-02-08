using BulletBoard.Core.Models;

namespace BulletBoard.Application.Pojects.Responses
{
    public class GetProjectResponse
    {
        public GetProjectResponse(Project project)
        {
            Response = project;
        }
        public Project Response { get; }
    }
}
