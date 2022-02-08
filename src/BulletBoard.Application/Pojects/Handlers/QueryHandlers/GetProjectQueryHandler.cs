using BulletBoard.Application.Base;
using BulletBoard.Application.Pojects.Queries;
using BulletBoard.Application.Pojects.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Pojects.Handlers.QueryHandlers
{
    public class GetProjectQueryHandler : IQueryHandler<GetProjectQuery, GetProjectResponse>
    {
        private readonly ProjectsRepository _projectsRepository;

        public GetProjectQueryHandler(ProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }

        public async Task<GetProjectResponse> Handle(GetProjectQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _projectsRepository.GetByIdAsync(request.id);

            return new GetProjectResponse(response);
        }
    }
}
