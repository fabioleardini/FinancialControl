using MongoDB.Driver;

namespace Repository
{
    public interface IMongoContext
    {
        IMongoDatabase Database{ get; }
    }
}