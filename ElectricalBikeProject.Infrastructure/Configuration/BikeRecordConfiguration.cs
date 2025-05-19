using ElectricalBikeProject.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectricalBikeProject.Infrastructure.Configuration;

public class BikeRecordConfiguration : IEntityTypeConfiguration<BikeRecord>
{
    public void Configure(EntityTypeBuilder<BikeRecord> builder)
    {
        builder.ToTable("bike_record");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .HasColumnName("name");

        builder.Property(e => e.LastSocValue)
            .HasColumnName("last_soc_value")
            .HasDefaultValue(100);

        builder.Property(e => e.LastUsedTimestamp)
            .HasColumnName("last_used_timestamp")
            .HasColumnType("timestamp without time zone");
        
        builder.Property(e=>e.CreatedTimestamp)
            .HasColumnName("created_timestamp")
            .HasColumnType("timestamp without time zone");

        builder.Property(e => e.BikeUsageHistory)
            .HasColumnName("bike_usage_history");

        builder.Property(e => e.ChargingStatus)
            .HasColumnName("charging_status")
            .HasDefaultValue(false);
    }
}