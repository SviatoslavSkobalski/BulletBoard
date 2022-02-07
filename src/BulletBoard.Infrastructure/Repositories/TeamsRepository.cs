using BulletBoard.Core.Models;
using BulletBoard.Core.Repositories;
using BulletBoard.Infrastructure.Data;
using BulletBoard.Infrastructure.Repositories.Base;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BulletBoard.Infrastructure.Repositories
{
    public class TeamsRepository : MongoDbRepository, ITeamsRepository
    {
        private readonly IMongoCollection<Team> _teamsCollection;

        public TeamsRepository(IOptions<MongoDbSettings> options) : base(options)
        {
            _teamsCollection = _mongoDatabase.GetCollection<Team>(options.Value.TeamsCollectionName);
        }

        public async Task<IReadOnlyList<Team>> GetAllAsync()
        {
            var result = await _teamsCollection.Find(_ => true).ToListAsync();
            return result;
        }
        public async Task<Team> GetByIdAsync(string id)
        {
            var result = await _teamsCollection.Find(item => item.Id == id).FirstOrDefaultAsync();
            return result;
        }
        public async Task<Team> AddAsync(Team entity)
        {
            await _teamsCollection.InsertOneAsync(entity);
            return entity;
        }
        public async Task<Team> UpdateAsync(Team entity)
        {
            var result = await _teamsCollection.ReplaceOneAsync(item => item.Id == entity.Id, entity);
            return entity;
        }
        public async Task<Team> DeleteAsync(Team entity)
        {
            var result = await _teamsCollection.DeleteOneAsync(item => item.Id == entity.Id);
            return entity;
        }
    }
}
