using Patterns.Domain;
using Patterns.Domain.DecoratorPattern;
using Patterns.Domain.VisitorPattern;

namespace Patterns.Bootstrap;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.AddConfiguration(args);

        builder.ConfigureServicesContainer();

        builder.ConfigureAutofacContainer();

        var app = builder.Build();
        
        app.ConfigureApplication();
        
        app.Urls.Add("http://*:8099");

        await app.RunAsync();
    }
}