using MongoDB.Driver;

namespace FinancialControl.Repository
{
    public interface IMongoContext
    {
        IMongoDatabase Database { get; }
    }
}
