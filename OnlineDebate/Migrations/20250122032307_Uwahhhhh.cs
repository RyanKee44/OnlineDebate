using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class Uwahhhhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Argument_AspNetUsers_UserId1",
                table: "Argument");

            migrationBuilder.DropIndex(
                name: "IX_Argument_UserId1",
                table: "Argument");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Argument",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId2",
                table: "Argument",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId", "UserId1", "UserId2" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(901), 0, "3781efa7-66dc-47f0-860f-e506d04102e4", null });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId", "UserId1", "UserId2" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 23, 5, 422, DateTimeKind.Local).AddTicks(913), 0, "3781efa7-66dc-47f0-860f-e506d04102e4", null });

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

            migrationBuilder.CreateIndex(
                name: "IX_Argument_UserId2",
                table: "Argument",
                column: "UserId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Argument_AspNetUsers_UserId2",
                table: "Argument",
                column: "UserId2",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Argument_AspNetUsers_UserId2",
                table: "Argument");

            migrationBuilder.DropIndex(
                name: "IX_Argument_UserId2",
                table: "Argument");

            migrationBuilder.DropColumn(
                name: "UserId2",
                table: "Argument");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Argument",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(8833), 1, null });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 6, 57, 160, DateTimeKind.Local).AddTicks(8845), 1, null });

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
    }
}
