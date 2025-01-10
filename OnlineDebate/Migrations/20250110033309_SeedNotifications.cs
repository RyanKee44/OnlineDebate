using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class SeedNotifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48f2adfa-80db-4ec5-b684-9501d35f0985", "AQAAAAIAAYagAAAAEPq0cTmT2Eu6bqw5zL9ipD2rg9fxbcYIgF7sfRNG6QyKeFvOJ6Chil7nrGq6rErBwQ==", "d499ae65-ac0d-4200-b6d3-22992721b0e4" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "DateCreated", "NotificationName", "TopicId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4575), "Hey Brother, Here's a topic you might be interested in", 0, 0 },
                    { 2, new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4578), "Oh hi", 0, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4092));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
