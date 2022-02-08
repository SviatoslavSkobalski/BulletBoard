using BulletBoard.Application.Pojects.Commands;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Pojects.Mappers
{
    public class ProjectMapper
    {
        public CreateProjectCommand MapToCreateCommand(Project project)
        {
            return new CreateProjectCommand(project);
        }

        public UpdateProjectCommand MapToUpdateCommand(Project project)
        {
            return new UpdateProjectCommand(project);
        }

        public RemoveProjectCommand MapToRemoveCommand(Project project)
        {
            return new RemoveProjectCommand(project);
        }
    }
}
