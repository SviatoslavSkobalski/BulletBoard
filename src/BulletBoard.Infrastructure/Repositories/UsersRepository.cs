using BulletBoard.Core.Entities;
using BulletBoard.Core.Repositories;
using BulletBoard.Infrastructure.Data;
using BulletBoard.Infrastructure.Repositories.Base;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BulletBoard.Infrastructure.Repositories
{
    public class UsersRepository : MongoDbRepository, IUsersRepository
    {
        private IMongoCollection<User> _usersCollection;

        public UsersRepository(IOptions<MongoDbSettings> options) : base(options)
        {
            _usersCollection = _mongoDatabase.GetCollection<User>(options.Value.UsersCollectionName);
        }

        public async Task<IReadOnlyList<User>> GetAllAsync()
        {
            var result = await _usersCollection.Find(_ => true).ToListAsync();
            return result;
        }

        public async Task<User> GetByIdAsync(string id)
        {
            var result = await _usersCollection.Find(item => item.Id == id).FirstOrDefaultAsync();
            return result;
        }
        public async Task<User> AddAsync(User entity)
        {
            await _usersCollection.InsertOneAsync(entity);
            return entity;
        }

        public async Task<User> UpdateAsync(User entity)
        {
            var result = await _usersCollection.ReplaceOneAsync(item => item.Id == entity.Id, entity);
            return entity;
        }
        public async Task<User> DeleteAsync(User entity)
        {
            var result = await _usersCollection.DeleteOneAsync(item => item.Id == entity.Id);
            return entity;
        }

    }
}
