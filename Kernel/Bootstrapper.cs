using Service;
using Business;
using Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Kernel
{
    public static class Bootstrapper
    {
        public static void Configure(IServiceCollection services)
        {

            // Service
            services.AddTransient<IExpenseService, ExpenseService>();

            // Business
            services.AddTransient<IExpenseBusiness, ExpenseBusiness>();

            // Repository
            services.AddTransient<IContextFactory, ContextFactory>();
            services.AddTransient<IExpenseRepository, ExpenseRepository>();
        }
    }
}
