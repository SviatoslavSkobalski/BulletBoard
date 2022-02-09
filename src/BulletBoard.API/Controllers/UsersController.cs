using BulletBoard.Application.Users.Mappers;
using BulletBoard.Application.Users.Queries;
using BulletBoard.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BulletBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly UserMapper _mapper;

        public UsersController(IMediator mediator, UserMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            var query = new GetUsersQuery();
            
            var response = await _mediator.Send(query);

            return response.Users;
        }

        [HttpGet("{id}")]
        public async Task<User> Get(string id)
        {
            var query = new GetUserQuery(id);

            var response = await _mediator.Send(query);

            return response.User;
        }

        [HttpPost]
        public async Task<User> Post([FromBody] User value)
        {
            var command = _mapper.MapToCreateUserCommand(value);

            var response = await _mediator.Send(command);

            if(response.Response is User user)
            {
                return user;
            }
            throw new ArgumentNullException();
        }

        [HttpPut("{id}")]
        public async Task<User> Put([FromBody] User value)
        {
            var command = _mapper.MapToUpdateUserCommand(value);

            var response = await _mediator.Send(command);

            if(response is User user)
            {
                return user;
            }
            throw new ArgumentNullException();
        }

        [HttpDelete("{id}")]
        public async Task<User> Delete(User value)
        {
            var command = _mapper.MapToRemoveUserCommand(value);

            var response = await _mediator.Send(command);

            if(response.Response is User user)
            {
                return user;
            }
            throw new ArgumentNullException();
        }
    }
}
