using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class OhHi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Argument_AspNetUsers_UserId2",
                table: "Argument");

            migrationBuilder.RenameColumn(
                name: "UserId2",
                table: "Argument",
                newName: "OnlineDebateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Argument_UserId2",
                table: "Argument",
                newName: "IX_Argument_OnlineDebateUserId");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 48, 24, 109, DateTimeKind.Local).AddTicks(8993));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Argument_AspNetUsers_OnlineDebateUserId",
                table: "Argument",
                column: "OnlineDebateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Argument_AspNetUsers_OnlineDebateUserId",
                table: "Argument");

            migrationBuilder.RenameColumn(
                name: "OnlineDebateUserId",
                table: "Argument",
                newName: "UserId2");

            migrationBuilder.RenameIndex(
                name: "IX_Argument_OnlineDebateUserId",
                table: "Argument",
                newName: "IX_Argument_UserId2");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b0ce79a-3184-4a0a-851f-c1d33bb67965", "AQAAAAIAAYagAAAAEPriQdQPdGJQxmLlFPcXfaYUXaaEazLZOPIdkG5StksAfl8aikPya+D8npJJIAT9Ww==", "ae6a2cc5-948f-408b-844e-c1535e8e0805" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.AddForeignKey(
                name: "FK_Argument_AspNetUsers_UserId2",
                table: "Argument",
                column: "UserId2",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
