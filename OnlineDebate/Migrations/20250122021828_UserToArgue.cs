using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class UserToArgue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Argument",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(6694), null });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 18, 24, 168, DateTimeKind.Local).AddTicks(6708), null });

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

            migrationBuilder.CreateIndex(
                name: "IX_Argument_UserId1",
                table: "Argument",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Argument_AspNetUsers_UserId1",
                table: "Argument",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Argument_AspNetUsers_UserId1",
                table: "Argument");

            migrationBuilder.DropIndex(
                name: "IX_Argument_UserId1",
                table: "Argument");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Argument");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb112d28-ed8f-4fb6-b53b-a4608ddbc757", "AQAAAAIAAYagAAAAEG4t2sS6rVBsCjt3mOcaLLdbbNip9Jq3ZjXyoEPI1T32senlim6nM3mZh0gsliLv0g==", "b03bb00f-be20-458b-87aa-85cc2b6ef18f" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5569));
        }
    }
}
