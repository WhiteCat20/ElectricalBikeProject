using ElectricalBikeProject.Domain;
using ElectricalBikeProject.Domain.Data;
using ElectricalBikeProject.Infrastructure.Configuration;
using ElectricalBikeProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ElectricalBikeProject.Infrastructure;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfra(this IServiceCollection services, string connectionString)
    {
        services.AddDomain();
        services.AddDbContextPool<DatabaseContext, SqlDatabaseContext>(options =>
        {
            options.UseNpgsql(connectionString, sqlOptions =>
            {
                sqlOptions.MigrationsAssembly(
                    typeof(ServiceRegistration).Assembly.FullName);
            }) .EnableSensitiveDataLogging()
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });
        return services;
    }
}