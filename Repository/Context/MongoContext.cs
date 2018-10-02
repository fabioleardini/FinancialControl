using MongoDB.Driver;

namespace Repository
{
    public class MongoContext
    {
        public IMongoDatabase Database { get; }

        readonly string connectionString = "mongodb+srv://fabioleardini:mongodbFFlma6!!973634@cluster0-rnnjy.mongodb.net/FinancialControl?retryWrites=true";

        public MongoContext()
        {
            Database = new MongoClient(connectionString).GetDatabase(new MongoUrl(connectionString).DatabaseName);
        }
    }
}
