using BulletBoard.Core.Models;

namespace BulletBoard.Application.Pojects.Responses
{
    public class GetAllProjectsResponse
    {
        public GetAllProjectsResponse(IEnumerable<Project> projects)
        {
            Response = projects;
        }
        public IEnumerable<Project> Response { get; }
    }
}
