﻿// <auto-generated />
using System;
using ElectricalBikeProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ElectricalBikeProject.Infrastructure.Migrations
{
    [DbContext(typeof(SqlDatabaseContext))]
    partial class SqlDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ElectricalBikeProject.Domain.Entity.BikeRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("BikeUsageHistory")
                        .HasColumnType("text")
                        .HasColumnName("bike_usage_history");

                    b.Property<bool>("ChargingStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("charging_status");

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_timestamp");

                    b.Property<int>("LastSocValue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(100)
                        .HasColumnName("last_soc_value");

                    b.Property<DateTime>("LastUsedTimestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_used_timestamp");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("bike_record", (string)null);
                });

            modelBuilder.Entity("ElectricalBikeProject.Domain.Entity.HistoryBikeUsage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("BikeRecordId")
                        .HasColumnType("uuid")
                        .HasColumnName("bike_record_id");

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_timestamp");

                    b.Property<DateTime>("FinishTimestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("finish_timestamp");

                    b.Property<DateTime>("StartTimestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_timestamp");

                    b.HasKey("Id");

                    b.ToTable("history_bike_usage", (string)null);
                });

            modelBuilder.Entity("ElectricalBikeProject.Domain.Entity.SecurityLockSys", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_timestamp");

                    b.Property<bool>("IsMember")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_member");

                    b.Property<DateTime?>("LastActiveTimestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_active_timestamp");

                    b.Property<Guid?>("LastBikeUsed")
                        .HasColumnType("uuid")
                        .HasColumnName("last_bike_used");

                    b.Property<double>("Mileage")
                        .HasColumnType("double precision")
                        .HasColumnName("mileage");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("phone_number");

                    b.Property<string>("RfidCredential")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("rfid_credential");

                    b.HasKey("Id");

                    b.ToTable("security_lock_sys", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
