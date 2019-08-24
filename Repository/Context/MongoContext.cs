using MongoDB.Driver;
using Microsoft.Extensions.Options; 
using CrossCutting;

namespace Repository
{
    public class MongoContext : IMongoContext
    {
        public IMongoDatabase Database { get; }

        public MongoContext(IOptions<AppSettings> settings)
        {
            var mongoClient = new MongoClient(settings.Value.MongoConnectionString);
            
            Database = mongoClient.GetDatabase(settings.Value.MongoDatabaseName);
        }
    }
}
