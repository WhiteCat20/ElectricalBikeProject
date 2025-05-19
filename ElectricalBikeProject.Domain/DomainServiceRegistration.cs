using ElectricalBikeProject.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ElectricalBikeProject.Domain;

public static class DomainServiceRegistration
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        services.AddScoped<BikeRecordService>();
        return services;
    }
}