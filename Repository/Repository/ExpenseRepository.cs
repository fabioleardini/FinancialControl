using Domain;

namespace Repository
{
    public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(IContextFactory factoryBase) : base(factoryBase)
        {
        }
    }
}