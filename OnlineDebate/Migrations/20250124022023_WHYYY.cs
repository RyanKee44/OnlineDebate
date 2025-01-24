using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class WHYYY : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            //migrationBuilder.AddForeignKey(
               // name: "FK_Argument_AspNetUsers_OnlineDebateUserId",
               // table: "Argument",
               // column: "OnlineDebateUserId",
               // principalTable: "AspNetUsers",
              //  principalColumn: "Id",
              //  onDelete: ReferentialAction.Cascade);
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
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Argument_AspNetUsers_OnlineDebateUserId",
                table: "Argument",
                column: "OnlineDebateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
