using System;

namespace Repository
{
    public class ContextFactory : IContextFactory
    {
        MongoContext _context;

        public MongoContext GetContext() => _context ?? (_context = new MongoContext());
    }
}
