using ElectricalBikeProject.Infrastructure.Configuration;
using ElectricalBikeProject.SharedKernel.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ElectricalBikeProject.Infrastructure.Data;

public class SwModelConfiguration : IModelConfiguration
{
    public void Configure(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new BikeRecordConfiguration());
        builder.ApplyConfiguration(new HistoryBikeUsageConfiguration());
        builder.ApplyConfiguration(new SecurityLockSysConfiguration());
    }
}