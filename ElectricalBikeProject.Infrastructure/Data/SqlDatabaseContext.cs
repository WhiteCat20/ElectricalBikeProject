using ElectricalBikeProject.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace ElectricalBikeProject.Infrastructure.Data;

public class SqlDatabaseContext : DatabaseContext
{
    public SqlDatabaseContext(DbContextOptions options) : base(options, new SwModelConfiguration())
    {
    }
}