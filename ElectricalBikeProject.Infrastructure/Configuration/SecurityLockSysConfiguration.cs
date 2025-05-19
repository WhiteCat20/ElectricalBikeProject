using ElectricalBikeProject.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectricalBikeProject.Infrastructure.Configuration;

public class SecurityLockSysConfiguration : IEntityTypeConfiguration<SecurityLockSys>
{
    public void Configure(EntityTypeBuilder<SecurityLockSys> builder)
    {
        builder.ToTable("security_lock_sys");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.RfidCredential)
            .HasColumnName("rfid_credential")
            .HasMaxLength(100);

        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(100);

        builder.Property(e => e.PhoneNumber)
            .HasColumnName("phone_number")
            .HasMaxLength(20);

        builder.Property(e => e.LastBikeUsed)
            .HasColumnName("last_bike_used");

        builder.Property(e => e.LastActiveTimestamp)
            .HasColumnName("last_active_timestamp")
            .HasColumnType("timestamp without time zone");

        builder.Property(e => e.CreatedTimestamp)
            .HasColumnName("created_timestamp")
            .HasColumnType("timestamp without time zone");
        
        builder.Property(e => e.IsMember)
            .HasColumnName("is_member")
            .HasDefaultValue(false);

        builder.Property(e => e.Mileage)
            .HasColumnName("mileage");
    }
}
