using System.Collections.Generic;
using Business;
using Domain;

namespace Service
{
    public class ExpenseService : IExpenseService
    {
        readonly IExpenseBusiness _expenseBusiness;

        public ExpenseService(IExpenseBusiness expenseBusiness) => _expenseBusiness = expenseBusiness;

        public ICollection<Expense> List() => _expenseBusiness.List();

        public Expense Select(int id) => _expenseBusiness.Select(id);

        public void Add(Expense expense) => _expenseBusiness.Add(expense);

        public void Update(Expense expense, int id) => _expenseBusiness.Update(expense, id);

        public void Delete(int id) => _expenseBusiness.Delete(id);
    }
}