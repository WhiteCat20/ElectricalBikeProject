using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricalBikeProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bike_record",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    last_soc_value = table.Column<int>(type: "integer", nullable: false, defaultValue: 100),
                    last_used_timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    created_timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    bike_usage_history = table.Column<string>(type: "text", nullable: true),
                    charging_status = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bike_record", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "history_bike_usage",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    bike_record_id = table.Column<Guid>(type: "uuid", nullable: false),
                    start_timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    finish_timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    created_timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_history_bike_usage", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "security_lock_sys",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    rfid_credential = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    last_bike_used = table.Column<Guid>(type: "uuid", nullable: true),
                    last_active_timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    created_timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    is_member = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    mileage = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_security_lock_sys", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bike_record");

            migrationBuilder.DropTable(
                name: "history_bike_usage");

            migrationBuilder.DropTable(
                name: "security_lock_sys");
        }
    }
}
