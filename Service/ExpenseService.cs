using System.Collections.Generic;
using Business;
using Domain;

namespace Service
{
    public class ExpenseService : IExpenseService
    {
        readonly IExpenseBusiness _expenseBusiness;

        public ExpenseService(IExpenseBusiness expenseBusiness)
        {
            _expenseBusiness = expenseBusiness;
        }

        public ICollection<Expense> List() => _expenseBusiness.List();
    }
}