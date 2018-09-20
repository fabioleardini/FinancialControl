using MongoDB.Driver;

namespace FinancialControl.Repository
{
    public class MongoContext : IMongoContext
    {
        public IMongoDatabase Database { get; }

        readonly string connectionString = "mongodb+srv://fabioleardini:mongodbFFlma6!!973634@cluster0-rnnjy.mongodb.net/test?retryWrites=true";

        public MongoContext()
        {
            Database = new MongoClient(connectionString).GetDatabase(new MongoUrl(connectionString).DatabaseName);
        }
    }
}
