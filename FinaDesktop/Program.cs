using FinaApp.Services;
using FinaApp.Services.Abstraction;
using FinaData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FinaDesktop;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        ServiceCollection services = new ServiceCollection();
        
        ConfigureServices(services);

        using ServiceProvider provider = services.BuildServiceProvider();
        MainForm mainForm = provider.GetRequiredService<MainForm>();
        Application.Run(mainForm);
    }   

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<MainForm>();
        services.AddDbContext<ProductionDbContext>(options =>
            options.UseSqlServer("Data Source = localhost; Initial Catalog = Production; Integrated Security = True;"));
        services.AddScoped<IProductionService, ProductionService>();
    }
}
