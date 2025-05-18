namespace ElectricalBikeProject;

public static class Log4NetServiceCollectionExtension
{
    public static IServiceCollection AddLog4Net( this IServiceCollection services, string configPath )
    {
        var loggerFactory = new LoggerFactory();
        loggerFactory.AddLog4Net( configPath );
        services.AddSingleton( loggerFactory );

        return services;
    }

    public static ILoggerFactory CreateLoggerFactory(string configPath)
    {
        var loggerFactory = new LoggerFactory();
        loggerFactory.AddLog4Net(configPath);

        return loggerFactory;
    }

    public static IServiceCollection AddLog4Net(this IServiceCollection services, ILoggerFactory loggerFactory)
    {
        services.AddSingleton( loggerFactory );

        return services;
    }
}
