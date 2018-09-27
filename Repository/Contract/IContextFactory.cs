namespace Repository
{
    public interface IContextFactory
    {
        MongoContext GetContext();
    }
}
