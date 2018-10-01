using System.Collections.Generic;
using Domain;

namespace Business
{
    public interface IExpenseBusiness
    {
        ICollection<Expense> List();
    }
}
