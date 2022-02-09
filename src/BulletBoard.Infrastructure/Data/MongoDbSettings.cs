namespace BulletBoard.Infrastructure.Data
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string TeamsCollectionName { get; set; } = null!;
        public string ProjectsCollectionName { get; set; } = null!;
        public string ItemsCollectionName { get; set; } = null!;
        public string UsersCollectionName { get; set; } = null!;
    }
}
