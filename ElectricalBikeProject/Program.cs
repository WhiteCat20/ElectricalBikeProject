using System.IO;
using System.Reflection;
using ElectricalBikeProject;
using ElectricalBikeProject.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var configsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
    "Configs");
var loggerFactory = Log4NetServiceCollectionExtension.CreateLoggerFactory(Path.Combine(configsPath, "log4net.config"));
builder.Services.AddLog4Net(loggerFactory);
ILogger logger = new Logger<WebApplication>(loggerFactory);

var connectionString = builder.Configuration.GetConnectionString("ProcessingSwConnectionString");

logger.LogInformation("Starting the Processing SW");

// Add services to the container.
builder.Services.AddInfra(connectionString!);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();