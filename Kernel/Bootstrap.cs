using Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Kernel
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
