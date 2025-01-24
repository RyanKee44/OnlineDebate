using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class testy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        IF EXISTS (
            SELECT 1
            FROM sys.foreign_keys
            WHERE name = 'FK_Argument_AspNetUsers_OnlineDebateUserId'
        )
        BEGIN
            ALTER TABLE [Argument] DROP CONSTRAINT [FK_Argument_AspNetUsers_OnlineDebateUserId];
        END
    ");

            migrationBuilder.AlterColumn<string>(
                name: "OnlineDebateUserId",
                table: "Argument",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AlterColumn<string>(
                name: "OnlineDebateUserId",
                table: "Argument",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 317, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 317, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "113c39ad-b217-40d2-9a9b-1b3b7f02ac71", "AQAAAAIAAYagAAAAEFv1qYGZn1x9G3p7vAawTPl9yezbJO3meuXYXozu/Q+TLRNz25YJZkvBpuuBunxRPg==", "68c87352-5615-45ff-b34a-2733765162f3" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 317, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 317, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 317, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 317, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 317, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 317, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 316, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 20, 22, 316, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.AddForeignKey(
                name: "FK_Argument_AspNetUsers_OnlineDebateUserId",
                table: "Argument",
                column: "OnlineDebateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
