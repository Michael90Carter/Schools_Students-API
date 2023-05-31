using Entities;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;
using Schools;

namespace Inco_webAPI.V2.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIISIntergration(this IServiceCollection services) =>
            services.Configure<IISOptions> (options =>
            {

            });

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddScoped<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(opts =>
             opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
