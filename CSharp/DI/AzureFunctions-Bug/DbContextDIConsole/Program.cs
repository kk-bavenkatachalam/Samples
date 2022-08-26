// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ApplicationDbContext;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services
        .AddDbContext<ApplicationContext>((provider, options) =>
                    options.UseSqlServer(ConnectionString.GetConnectionString()))
        .AddScoped<Application>())
    .Build();

var app = host.Services.GetRequiredService<Application>();
app.Print();

await host.RunAsync();

public class Application
{
    private ApplicationContext productContext;
    public Application(ApplicationContext productContext)
    {
        this.productContext = productContext;
    }

    public void Print()
    {
        Console.WriteLine("ApplicationContext is accessible");
    }
}
