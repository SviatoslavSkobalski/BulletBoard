using BulletBoard.Infrastructure.Data;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.API.Extensions
{
    public static class MongoDbExtension
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Configure<MongoDbSettings>(configuration.GetSection("MongoDb"))
                           .AddSingleton<TeamsRepository>()
                           .AddSingleton<ProjectsRepository>()
                           .AddSingleton<ItemsRepository>();
        }
    }
}
