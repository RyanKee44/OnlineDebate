using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class SuomiTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Argument");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(2508), "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 50, 14, 743, DateTimeKind.Local).AddTicks(2521), "3781efa7-66dc-47f0-860f-e506d04102e4" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Argument",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(8983), null, "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(8993), null, "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9288bad-e842-4e4a-9ed3-1e0a6138f092", "AQAAAAIAAYagAAAAELANtCyLtjzAN5ChEJod90AfLW44WBrpTn9QV3PTu3W6vD9dyoblJcK+3TuE7kuzIw==", "4e77b4c2-ae02-4cd3-ba72-cb905809a148" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(8478));
        }
    }
}
