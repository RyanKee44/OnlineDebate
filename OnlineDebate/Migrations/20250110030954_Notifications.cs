using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class Notifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 9, 52, 878, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 9, 52, 878, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e81012de-f97e-4da0-8d7f-13a555837adc", "AQAAAAIAAYagAAAAEJc1zVsbkok5Iq0nIV+tx8ZNc41bh6cVOLy/ltu+khc8PIPFkOlqJsenY/QxrNIcBA==", "de372d25-887e-4551-8acd-47ba814ae9cb" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 9, 52, 878, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 9, 52, 878, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 9, 52, 878, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 9, 52, 878, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 9, 52, 878, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 9, 52, 878, DateTimeKind.Local).AddTicks(7506));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 8, 18, 40, 46, 827, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 8, 18, 40, 46, 827, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ed4f83a-f11c-437b-a509-d423c2da89bf", "AQAAAAIAAYagAAAAEH7x4E2H5b7iPWve0Ot68+im4Qnn2jLJ8kOvz9GtASsBjiLVIGoOmepc53qByRaQ3w==", "9f6cbf21-be70-43e8-8625-346361d45f9b" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 8, 18, 40, 46, 827, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 8, 18, 40, 46, 827, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 8, 18, 40, 46, 827, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 8, 18, 40, 46, 827, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 8, 18, 40, 46, 827, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 8, 18, 40, 46, 827, DateTimeKind.Local).AddTicks(4745));
        }
    }
}
