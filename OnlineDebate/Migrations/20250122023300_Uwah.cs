using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class Uwah : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OnlineDebateUserId",
                table: "Argument",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2825), 0 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2838), 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19fa6c8c-0dcc-4dad-9b08-82301951a487", "AQAAAAIAAYagAAAAELhTu24lq/mhD6WHpxtKZ7bBupkJv92Y1zdtTr43OTT2rdiztKrUzx0U9Vfmns429g==", "81139497-432f-4961-b9ee-78fd66bd2a40" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2537));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnlineDebateUserId",
                table: "Argument");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 29, 0, 397, DateTimeKind.Local).AddTicks(670));

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
    }
}
