using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class Uwahhhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnlineDebateUserId",
                table: "Argument");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(8833), 1 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(8845), 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1149341e-dc66-4717-8462-f14be396fc7c", "AQAAAAIAAYagAAAAECYNqSkdd2GUY3DFoQJgLf7S1gkUamNMC70a9A6oW2qWW9BtDY+HjMLQpGbvufelnA==", "ccc0a27c-d158-4bc7-909d-fae9f3c3b7dd" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(8309));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnlineDebateUserId",
                table: "Argument",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(3827), "3781efa7-66dc-47f0-860f-e506d04102e4", 0 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(3834), "3781efa7-66dc-47f0-860f-e506d04102e4", 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "460d0dc9-b3b1-40aa-9117-cc005bd711e6", "AQAAAAIAAYagAAAAEE8yxi5IVnU/JFI1AaBDaSIqKooanRPgtFLZvfZ+1Rjw+pwPz4yr9Wox38e6HQksUA==", "61d7a70d-cd99-4eff-aaa7-a64205d15046" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(3528));
        }
    }
}
