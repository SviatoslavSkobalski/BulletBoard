using BulletBoard.Infrastructure.Data;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BulletBoard.Infrastructure.Repositories.Base
{
    public class MongoDbRepository
    {
        protected readonly IMongoDatabase _mongoDatabase;

        public MongoDbRepository(IOptions<MongoDbSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
            bookStoreDatabaseSettings.Value.ConnectionString);

            _mongoDatabase = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);
        }
    }
}
