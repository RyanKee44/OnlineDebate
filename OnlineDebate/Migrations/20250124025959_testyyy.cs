using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class testyyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e24050e-a54e-4703-be23-3083005db20a", "AQAAAAIAAYagAAAAECjNaYVJStF/Xr2LrEzq5ufroFZfmPo7S6pOpZ6KXahbCx+1QatTaYpu5O3Lu0qkKw==", "89fc8fb8-19df-4041-b5bf-cbae4bc98ff1" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(7941));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f8b6509-7c5f-4463-ad2e-4630fa0836bd", "AQAAAAIAAYagAAAAEBDGl25rf2Ci1DMjoxGywTn9lmARrsvQLzdkZ9br8MQ5RjigrfVI6WJjgJiXVkC0rA==", "0dd14515-b1fd-4f84-ae6a-41dcc9a084a8" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 44, 33, 926, DateTimeKind.Local).AddTicks(6812));
        }
    }
}
