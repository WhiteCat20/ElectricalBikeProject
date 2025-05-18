using System.Reflection;
using ElectricalBikeProject;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var configsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
    "Configs");
var loggerFactory = Log4NetServiceCollectionExtension.CreateLoggerFactory(Path.Combine(configsPath, "log4net.config"));
builder.Services.AddLog4Net(loggerFactory);
ILogger logger = new Logger<WebApplication>(loggerFactory);

logger.LogInformation("Starting the Processing SW");

// Add services to the container.



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();