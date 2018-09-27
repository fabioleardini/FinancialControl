using System.Collections.Generic;
using Domain;
using Repository;

namespace Service
{
    public class ExpenseService : IExpenseService
    {
        IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public ICollection<Expense> List()
        {
            return null;
        }
    }
}