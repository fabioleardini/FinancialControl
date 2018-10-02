using System.Collections.Generic;
using Domain;

namespace Service
{
    public interface IExpenseService
    {
        ICollection<Expense> List();

        void Add(Expense expense);
    }
}