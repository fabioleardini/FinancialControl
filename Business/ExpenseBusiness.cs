using System.Collections.Generic;
using Repository;
using Domain;

namespace Business
{
    public class ExpenseBusiness : IExpenseBusiness
    {
        readonly IExpenseRepository _expenseRepository;

        public ExpenseBusiness(IExpenseRepository expenseRepository) => _expenseRepository = expenseRepository;

        public ICollection<Expense> List() => _expenseRepository.List();

        public Expense Select(int id) => _expenseRepository.Select(id);

        public void Add(Expense expense) => _expenseRepository.Add(expense);

        public void Update(Expense expense, int id) => _expenseRepository.Update(expense, id);

        public void Delete(int id) => _expenseRepository.Delete(id);
    }
}
