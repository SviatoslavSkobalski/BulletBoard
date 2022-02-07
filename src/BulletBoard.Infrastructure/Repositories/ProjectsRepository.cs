using BulletBoard.Core.Models;
using BulletBoard.Core.Repositories;
using BulletBoard.Infrastructure.Data;
using BulletBoard.Infrastructure.Repositories.Base;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BulletBoard.Infrastructure.Repositories
{
    public class ProjectsRepository : MongoDbRepository, IProjectsRepository
    {
        private readonly IMongoCollection<Project> _projectsCollection;

        public ProjectsRepository(IOptions<MongoDbSettings> options) : base(options)
        {
            _projectsCollection = _mongoDatabase.GetCollection<Project>(options.Value.ProjectsCollectionName);
        }

        public async Task<IReadOnlyList<Project>> GetAllAsync()
        {
            var result = await _projectsCollection.Find(_ => true).ToListAsync();
            return result;
        }
        public async Task<Project> GetByIdAsync(string id)
        {
            var result = await _projectsCollection.Find(item => item.Id == id).FirstOrDefaultAsync();
            return result;
        }
        public async Task<Project> AddAsync(Project entity)
        {
            await _projectsCollection.InsertOneAsync(entity);
            return entity;
        }
        public async Task<Project> UpdateAsync(Project entity)
        {
            var result = await _projectsCollection.ReplaceOneAsync(item => item.Id == entity.Id, entity);
            return entity;
        }
        public async Task<Project> DeleteAsync(Project entity)
        {
            var result = await _projectsCollection.DeleteOneAsync(item => item.Id == entity.Id);
            return entity;
        }
    }
}
