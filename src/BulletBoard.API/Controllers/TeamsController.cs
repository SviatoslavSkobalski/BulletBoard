using BulletBoard.Application.Teams.Mappers;
using BulletBoard.Application.Teams.Queries;
using BulletBoard.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BulletBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly TeamMapper _mapper;

        public TeamsController(IMediator mediator, TeamMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Team>> Get()
        {
            var query = new GetAllTeamsQuery();

            var result = await _mediator.Send(query);

            return result.Response;
        }

        [HttpGet("{id}")]
        public async Task<Team> GetAsync(string id)
        {
            var query = new GetTeamQuery(id);

            var result = await _mediator.Send(query);

            return result.Response;
        }

        [HttpPost]
        public async Task<Team> Post([FromBody] Team value)
        {
            var command = _mapper.MapToUpdateCommand(value);

            var result = await _mediator.Send(command);

            if(result.Response is Team team)
            {
                return team;
            }
            else
            {
                throw new ArgumentNullException(nameof(team));
            }
        }

        [HttpPut("{id}")]
        public async Task<Team> Put([FromBody] Team value)
        {
            var command = _mapper.MapToUpdateCommand(value);

            var result = await _mediator.Send(command);

            if(result?.Response is Team team)
            {
                return team;
            }
            else
            {
                throw new ArgumentNullException(nameof(team));
            }
        }

        [HttpDelete("{id}")]
        public async Task<Team> Delete([FromBody] Team value)
        {
            var command = _mapper.MapToRemoveCommand(value);

            var result = await _mediator.Send(command);

            if(result?.Response is Team team)
            {
                return team;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
