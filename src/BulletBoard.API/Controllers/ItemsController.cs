using BulletBoard.Core.Models;
using BulletBoard.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BulletBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsRepository _itemsRepository;

        public ItemsController(ItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Item>> Get()
        {
            return await _itemsRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Item> Get(int id)
        {
            return await _itemsRepository.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<Item> Post([FromBody] Item value)
        {
            return await _itemsRepository.AddAsync(value);
        }

        [HttpPut("{id}")]
        public async Task<Item> Put([FromBody] Item value)
        {
            return await _itemsRepository.UpdateAsync(value);
        }

        [HttpDelete("{id}")]
        public async Task<Item> Delete([FromBody]Item value)
        {
            return await _itemsRepository.DeleteAsync(value);
        }
    }
}
