using System.Security.Authentication;
using MongoDB.Driver;

namespace Repository
{
    public class MongoContext
    {
        public IMongoDatabase Database { get; }

         // readonly string connectionString = "mongodb+srv://fabioleardini:mongodbFFlma6!!973634@cluster0-rnnjy.mongodb.net/FinancialControl?retryWrites=true";
        readonly string connectionString = "mongodb://financial-control-cosmos-db:OyGYPiW5CPweua2yZzVqV7qZPlMqufzreahdATqkuH4SxOSxrHM4xXl0nTOcQHxTGsBRfldYDOviRxvgTHV2kQ==@financial-control-cosmos-db.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";

        public MongoContext()
        {
            // Database = new MongoClient(connectionString).GetDatabase(new MongoUrl(connectionString).DatabaseName);

            // string connectionString = @"mongodb://financial-control-cosmos-db:OyGYPiW5CPweua2yZzVqV7qZPlMqufzreahdATqkuH4SxOSxrHM4xXl0nTOcQHxTGsBRfldYDOviRxvgTHV2kQ==@financial-control-cosmos-db.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
            
            // var settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            // settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            
            // var mongoClient = new MongoClient(settings);

            // var mongoUrl = new MongoUrl(connectionString);
            // Database = mongoClient.GetDatabase(mongoUrl.DatabaseName);

            var mongoClient = new MongoClient(connectionString);
            
            Database = mongoClient.GetDatabase("financial-control-cosmos-db");
        }
    }
}
