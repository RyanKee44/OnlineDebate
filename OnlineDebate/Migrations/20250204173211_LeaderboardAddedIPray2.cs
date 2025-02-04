using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class LeaderboardAddedIPray2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a539ecf6-33fa-458e-887b-905eef2b5b05", "AQAAAAIAAYagAAAAEJJK8PISa5crJGsSIBX7AyEn6cM/NpSkV1kd+vSpIXZj/X92fUytyIJbHuC0XfxbxQ==", "b9f7c81e-f206-4ec9-a3e4-ccde5b450764" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(3040));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d455518-f9c1-4860-b379-45ef8377ccd5", "AQAAAAIAAYagAAAAELw8lsGAbCetJ9/SWECxtinFnuaeam2ERNu+OEzYsxiugQCD+uRN4IV2PnQVEtcABA==", "9ba69550-6abd-48ea-8cd3-805c08189e2d" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(5746));
        }
    }
}
