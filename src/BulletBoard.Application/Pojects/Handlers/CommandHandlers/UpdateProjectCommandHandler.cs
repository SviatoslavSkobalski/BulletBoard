using BulletBoard.Application.Base;
using BulletBoard.Application.Pojects.Commands;
using BulletBoard.Application.Pojects.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Pojects.Handlers.CommandHandlers
{
    public class UpdateProjectCommandHandler : ICommandHandler<UpdateProjectCommand>
    {
        private readonly ProjectsRepository _projectsRepository;

        public UpdateProjectCommandHandler(ProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }
        public async Task<IResponse> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var result = await _projectsRepository.UpdateAsync(request.project);

            return new ProjectCommandResponse(result);
        }
    }
}
