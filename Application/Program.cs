using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                                .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                .Build();

            if(Debugger.IsAttached || args.Contains("--debug"))
            {
                CreateWebHostBuilder(args, config).Build().Run();
            }
            else
            {
                var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                Directory.SetCurrentDirectory(path);
                CreateWebHostBuilder(args, config).Build().Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args, IConfiguration config) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseConfiguration(config);
    }
}
