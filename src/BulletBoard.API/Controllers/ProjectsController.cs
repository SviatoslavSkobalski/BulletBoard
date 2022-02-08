using BulletBoard.Application.Pojects.Mappers;
using BulletBoard.Application.Pojects.Queries;
using BulletBoard.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BulletBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ProjectMapper _mapper;

        public ProjectsController(IMediator mediator, ProjectMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<Project>> Get()
        {
            var query = new GetAllProjectsQuery();

            var response = await _mediator.Send(query);

            return response.Response;
        }

        [HttpGet("{id}")]
        public async Task<Project> Get(string id)
        {
            var query = new GetProjectQuery(id);

            var response = await _mediator.Send(query);

            return response.Response;
        }

        [HttpPost]
        public async Task<Project> Post([FromBody] Project value)
        {
            var command = _mapper.MapToCreateCommand(value);

            var response = await _mediator.Send(command);

            if(response.Response is Project project)
            {
                return project;
            }
            throw new ArgumentNullException(nameof(project));
        }

        [HttpPut("{id}")]
        public async Task<Project> Put([FromBody] Project value)
        {
            var command = _mapper.MapToUpdateCommand(value);

            var response = await _mediator.Send(command);

            if(response.Response is Project project)
            {
                return project;
            }
            throw new ArgumentNullException(nameof(project));
        }

        [HttpDelete("{id}")]
        public async Task<Project> Delete(Project value)
        {
            var command = _mapper.MapToRemoveCommand(value);

            var response = await _mediator.Send(command);

            if(response.Response is Project project)
            {
                return project;
            }

            throw new ArgumentNullException();
        }
    }
}
