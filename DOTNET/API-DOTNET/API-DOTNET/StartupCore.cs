using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace EasyLOB.Shell
{
    public static class StartupCore
    {
        public static IServiceProvider Startup()
        {
            IServiceCollection services = new ServiceCollection();

            ConfigureServices(services);

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            // ConfigurationHelper
            Microsoft.Extensions.Configuration.IConfiguration configuration = serviceProvider.GetService<Microsoft.Extensions.Configuration.IConfiguration>();

            return serviceProvider;
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
            services.AddSingleton<IConfiguration>(configuration);
        }
    }
}
