using ElectricalBikeProject.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectricalBikeProject.Infrastructure.Configuration;

public class HistoryBikeUsageConfiguration : IEntityTypeConfiguration<HistoryBikeUsage>
{
    public void Configure(EntityTypeBuilder<HistoryBikeUsage> builder)
    {
        builder.ToTable("history_bike_usage");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.BikeRecordId)
            .HasColumnName("bike_record_id");
        
        builder.Property(e=>e.StartTimestamp)
            .HasColumnName("start_timestamp")
            .HasColumnType("timestamp without time zone");
        
        builder.Property(e=>e.FinishTimestamp)
            .HasColumnName("finish_timestamp")
            .HasColumnType("timestamp without time zone");
        
        builder.Property(e=>e.CreatedTimestamp)
            .HasColumnName("created_timestamp")
            .HasColumnType("timestamp without time zone");
    }
}