using BulletBoard.Application.Base;
using BulletBoard.Application.Pojects.Queries;
using BulletBoard.Application.Pojects.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Pojects.Handlers.QueryHandlers
{
    public class GetAllProjectsQueryHandler : IQueryHandler<GetAllProjectsQuery, GetAllProjectsResponse>
    {
        private readonly ProjectsRepository _projectsRepository;

        public GetAllProjectsQueryHandler(ProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }
        public async Task<GetAllProjectsResponse> Handle(GetAllProjectsQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _projectsRepository.GetAllAsync();

            return new GetAllProjectsResponse(response);
        }
    }
}
