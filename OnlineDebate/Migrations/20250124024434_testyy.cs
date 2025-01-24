using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class testyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ebfa581-0420-4350-b947-20e44e92b323", "AQAAAAIAAYagAAAAEDiWmHtZ9FZs0ApSpPU5jJCNMre24fNwrzRcfJ+u4TVTaVUmNCkCyrKGGuLGVqCZ2A==", "76c163a5-37a4-46de-9741-62247ba5f2d7" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 38, 38, 335, DateTimeKind.Local).AddTicks(8813));
        }
    }
}
