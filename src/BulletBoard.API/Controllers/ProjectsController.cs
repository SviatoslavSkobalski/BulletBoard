using BulletBoard.Core.Models;
using BulletBoard.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BulletBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectsRepository _projectRepository;

        public ProjectsController(ProjectsRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Project>> Get()
        {
            return await _projectRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Project> Get(string id)
        {
            return await _projectRepository.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<Project> Post([FromBody] Project value)
        {
            return await _projectRepository.AddAsync(value);
        }

        [HttpPut("{id}")]
        public async Task<Project> Put([FromBody] Project value)
        {
            return await _projectRepository.UpdateAsync(value);
        }

        [HttpDelete("{id}")]
        public async Task<Project> Delete(Project value)
        {
            return await _projectRepository.DeleteAsync(value);
        }
    }
}
