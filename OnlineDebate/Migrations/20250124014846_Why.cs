using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class Why : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0546499c-f827-40bf-bfaa-5ed52a63181e", "AQAAAAIAAYagAAAAEJ5vZGijtwcbILa5z/PwBLRV26i76DtaqybBZvK1OkUGmP9D6GVVRvYLjTyJvUOiLA==", "44b8bc6d-db50-41e7-be62-2ffed071ab91" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 9, 48, 44, 590, DateTimeKind.Local).AddTicks(7515));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be9d9b35-4e2f-4237-a427-b4d54dbce68e", "AQAAAAIAAYagAAAAEByxP0LKnxY9+oewEYSyBoXAAROievYzhIeg2jQeH5GlROp+SxfnTN29ehBtkBmoSQ==", "94238b00-064b-4093-bfd0-ce983fead491" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(1762));
        }
    }
}
