using System.Collections.Generic;
using Domain;

namespace Service
{
    public interface IExpenseService
    {
        ICollection<Expense> List();

        Expense Select(int id);

        void Add(Expense expense);

        void Update(Expense expense, int id);

        void Delete(int id);
    }
}