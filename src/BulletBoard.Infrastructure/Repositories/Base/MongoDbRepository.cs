using BulletBoard.Infrastructure.Data;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BulletBoard.Infrastructure.Repositories.Base
{
    public class MongoDbRepository
    {
        protected readonly IMongoDatabase _mongoDatabase;

        public MongoDbRepository(IOptions<MongoDbSettings> bulletBoardDatabaseSettings)
        {
            var mongoClient = new MongoClient(
            bulletBoardDatabaseSettings.Value.ConnectionString);

            _mongoDatabase = mongoClient.GetDatabase(
                bulletBoardDatabaseSettings.Value.DatabaseName);
        }
    }
}
