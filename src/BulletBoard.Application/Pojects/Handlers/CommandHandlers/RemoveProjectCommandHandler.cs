using BulletBoard.Application.Base;
using BulletBoard.Application.Pojects.Commands;
using BulletBoard.Application.Pojects.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Pojects.Handlers.CommandHandlers
{
    internal class RemoveProjectCommandHandler : ICommandHandler<RemoveProjectCommand>
    {
        private readonly ProjectsRepository _projectsRepository;

        public RemoveProjectCommandHandler(ProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }
        public async Task<IResponse> Handle(RemoveProjectCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var result = await _projectsRepository.DeleteAsync(request.project);

            return new ProjectCommandResponse(result);
        }
    }
}
