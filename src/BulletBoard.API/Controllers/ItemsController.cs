using BulletBoard.Application.Items.Mappers;
using BulletBoard.Application.Items.Queries;
using BulletBoard.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulletBoard.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ItemsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ItemMapper _mapper;

        public ItemsController(IMediator mediator, ItemMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Item>> Get()
        {
            var query = new GetAllItemsQuery();

            var response = await _mediator.Send(query);

            return response.Response;
        }

        [HttpGet("{id}")]
        public async Task<Item> Get(string id)
        {
            var query = new GetItemQuery(id);

            var response = await _mediator.Send(query);

            return response.Response;
        }

        [HttpPost]
        public async Task<Item> Post([FromBody] Item value)
        {
            var command = _mapper.MapToCreateCommand(value);

            var response = await _mediator.Send(command);

            if(response.Response is Item item)
            {
                return item;
            }

            throw new ArgumentNullException();
        }

       [HttpPut("{id}")]
        public async Task<Item> Put([FromBody] Item value)
        {
            var command = _mapper.MapToUpdateCommand(value);

            var response = await _mediator.Send(command);

            if(response.Response is Item item)
            {
                return item;
            }

            throw new ArgumentNullException(nameof(item));
        }

        [HttpDelete("{id}")]
        public async Task<Item> Delete([FromBody]Item value)
        {
            var command = _mapper.MapToRemoveCommand(value);

            var response = await _mediator.Send(command);

            if(response.Response is Item item)
            {
                return item;
            }

            throw new ArgumentNullException(nameof(item));
        }
    }
}
