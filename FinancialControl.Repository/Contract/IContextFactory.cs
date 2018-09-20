using System;

namespace FinancialControl.Repository
{
    public interface IContextFactory
    {
        MongoContext GetContext();
    }
}
