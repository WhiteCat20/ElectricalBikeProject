using ElectricalBikeProject.SharedKernel.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ElectricalBikeProject.Domain.Data;

public class DatabaseContext : DbContext
{
    private readonly IModelConfiguration _modelConfiguration;

    public DatabaseContext(DbContextOptions options, IModelConfiguration modelConfiguration) : base(options)
    {
        _modelConfiguration = modelConfiguration;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        _modelConfiguration.Configure(modelBuilder);
    }
}