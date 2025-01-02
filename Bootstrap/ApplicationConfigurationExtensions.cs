using Autofac;
using Autofac.Extensions.DependencyInjection;
using NLog.Extensions.Logging;
using Patterns.Domain;
using Patterns.Domain.DecoratorPattern;
using AssemblyAnchor = Patterns.Api.AssemblyAnchor;


namespace Patterns.Bootstrap
{
    public static class ApplicationConfigurationExtensions
    {
        public static void ConfigureApplication(this WebApplication app)
        {
            app.UseRouting();
            app.MapControllers();
        }
        
        public static void AddConfiguration(this WebApplicationBuilder builder, string[] args)
        {
            var environment = builder.Environment;

            builder.Configuration
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args);

            if (builder.Environment.IsDevelopment())
            {
                builder.Logging.AddConsole().SetMinimumLevel(LogLevel.Information);
            }
            else if (File.Exists("nlog.config"))
            {
                builder.Logging.AddNLog("nlog.config");
            }
        }

        public static void ConfigureServicesContainer(this WebApplicationBuilder builder)
        {
        
            builder.Services.AddMvc().AddApplicationPart(typeof(AssemblyAnchor).Assembly)
                .AddControllersAsServices();
            
            builder.Services.AddMemoryCache();
            builder.Services.AddScoped<CoffeeDescription>();
            builder.Services.AddScoped<ICoffeeDescription, CappuccinoDecorator>();
            builder.Services.AddScoped<ICoffeeDescription, AmericanoDecorator>();
            builder.Services.AddOptions();
            builder.Services.Configure<ApplicationSettings>(builder.Configuration);
            builder.Services.AddHttpClient();
            builder.Services.AddHttpContextAccessor();
        }

        public static void ConfigureAutofacContainer(this WebApplicationBuilder builder)
        {
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
            {
                containerBuilder.RegisterModule<AutoDiscoveryRegistrar>();
            });
        }
    }
}