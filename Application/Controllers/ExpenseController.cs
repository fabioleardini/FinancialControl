using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Service;
using Domain;

namespace Application
{
    [Route("api/[controller]")]
    public class ExpenseController : Controller
    {
        readonly IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        // GET: api/expense
        [HttpGet]
        public ICollection<Expense> Get() => _expenseService.List();

        // GET api/expense/5
        [HttpGet("{id}")]
        public string Get(int id) => "Not Implemented!";

        // POST api/expense
        [HttpPost]
        public void Post([FromBody]Expense expense) => _expenseService.Add(expense);

        // PUT api/expense/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/expense/5
        [HttpDelete("{id}")]
        public void Delete(int id) 
        {

        }
    }
}
