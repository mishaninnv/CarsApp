using CarsApp.DataBase.Migrations;
using FluentMigrator.Runner;

namespace CarsApp.DataBase;

public static class ForStartup
{
    public static void UpdateDatabase(this IServiceCollection services)
    {
        services
            .AddFluentMigratorCore()
            .ConfigureRunner(
                builder => builder
                .AddPostgres()
                .WithGlobalConnectionString("Host=localhost; Port=5432; Database=postgres; User ID=postgres; Password=password;")
                .WithMigrationsIn(typeof(Date_202302260004_Cars).Assembly))
                .BuildServiceProvider();
    }

    public static void UpdateDatabase(this WebApplication webApplication)
    {
        using (var scope = webApplication.Services.CreateScope())
        {
            var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }    
    }
}
