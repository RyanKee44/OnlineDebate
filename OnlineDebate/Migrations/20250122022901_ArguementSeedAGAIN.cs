using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class ArguementSeedAGAIN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(666), 1 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(670), 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "074b84c3-febe-4455-9c77-5cf8ae1d2b42", "AQAAAAIAAYagAAAAEKihZNEjpQW9gA9Q6AwCOBInBx/nZkU81qIkV9UikyGmMSmFfpkZJYcdJ8NXnA4jPQ==", "e98e483b-f009-488f-a698-4c689a8cfe9f" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(426));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(6694), 0 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(6708), 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be2b8072-1e5c-4fdb-a2fb-198f7409c6b0", "AQAAAAIAAYagAAAAEPLPjZM6Wy+LPjNzNftZCZqdytap5rjrQhuwPNwzIlVfjlJtyc4VwFZ45jHPWeWwIw==", "63119f0c-1b38-4581-865c-c277cf354693" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(5622));
        }
    }
}
