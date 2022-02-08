using BulletBoard.Application.Base;
using BulletBoard.Application.Pojects.Commands;
using BulletBoard.Application.Pojects.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Pojects.Handlers.CommandHandlers
{
    public class CreateProjectCommandHandler : ICommandHandler<CreateProjectCommand>
    {
        private readonly ProjectsRepository _projectRepository;

        public CreateProjectCommandHandler(ProjectsRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public async Task<IResponse> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var result = await _projectRepository.AddAsync(request.Project);

            return new ProjectCommandResponse(result);
        }
    }
}
