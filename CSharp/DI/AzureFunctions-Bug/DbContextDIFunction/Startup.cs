using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApplicationDbContext;
using DbContextDIFunction;

[assembly: FunctionsStartup(typeof(Startup))]
namespace DbContextDIFunction
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services
                .AddDbContext<ApplicationContext>((provider, options) =>
                    options.UseSqlServer(ConnectionString.GetConnectionString()));
        }
    }
}
