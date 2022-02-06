using BulletBoard.Core.Models;
using BulletBoard.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BulletBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly TeamsRepository _teamsRepository;

        public TeamsController(TeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Team>> Get()
        {
            var result = await _teamsRepository.GetAllAsync();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<Team> GetAsync(int id)
        {
            var result = await _teamsRepository.GetByIdAsync(id);
            return result;
        }

        [HttpPost]
        public async Task<Team> Post([FromBody] Team value)
        {
            var result = await _teamsRepository.AddAsync(value);
            return result;
        }

        [HttpPut("{id}")]
        public async Task<Team> Put([FromBody] Team value)
        {
            var result = await _teamsRepository.UpdateAsync(value);
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<Team> Delete([FromBody] Team team)
        {
            var result = await _teamsRepository.DeleteAsync(team);
            return result;
        }
    }
}
