using BulletBoard.Core.Models;
using BulletBoard.Core.Repositories;
using BulletBoard.Infrastructure.Data;
using BulletBoard.Infrastructure.Repositories.Base;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BulletBoard.Infrastructure.Repositories
{
    public class ItemsRepository : MongoDbRepository, IItemsRepository
    {
        private readonly IMongoCollection<Item> _itemsCollection;

        public ItemsRepository(IOptions<MongoDbSettings> options): base(options)
        {
            _itemsCollection = _mongoDatabase.GetCollection<Item>(options.Value.ItemsCollectionName);
        }

        public async Task<IReadOnlyList<Item>> GetAllAsync()
        {
            var result = await _itemsCollection.Find(_ => true).ToListAsync();
            return result;
        }
        public async Task<Item> GetByIdAsync(string id)
        {
            var result = await _itemsCollection.Find(item => item.Id == id).FirstOrDefaultAsync();
            return result;
        }
        public async Task<Item> AddAsync(Item entity)
        {
            await _itemsCollection.InsertOneAsync(entity);
            return entity;
        }
        public async Task<Item> UpdateAsync(Item entity)
        {
            var result = await _itemsCollection.ReplaceOneAsync(item => item.Id == entity.Id, entity);
            return entity;
        }
        public async Task<Item> DeleteAsync(Item entity)
        {
            var result = await _itemsCollection.DeleteOneAsync(item => item.Id == entity.Id);
            return entity;
        }
    }
}
