using Domain;

namespace Repository
{
    public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(IMongoContext context) : base(context)
        {
        }
    }
}