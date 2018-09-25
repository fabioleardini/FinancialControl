using FinancialControl.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FinancialControl.Kernel
{
    public static class Bootstrap
    {
        public static void Configure(IServiceCollection services)
        {
            // Repository
            services.AddTransient<IContextFactory, ContextFactory>();
        }
    }
}
