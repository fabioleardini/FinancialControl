using System;

namespace FinancialControl.Repository
{
    public class ContextFactory : IContextFactory
    {
        MongoContext _context;

        public MongoContext GetContext() => _context ?? (_context = new MongoContext());
    }
}
