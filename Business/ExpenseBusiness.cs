using System.Collections.Generic;
using Repository;
using Domain;

namespace Business
{
    public class ExpenseBusiness : IExpenseBusiness
    {
        readonly IExpenseRepository _expenseRepository;

        public ExpenseBusiness(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public ICollection<Expense> List() => _expenseRepository.List();
    }
}
