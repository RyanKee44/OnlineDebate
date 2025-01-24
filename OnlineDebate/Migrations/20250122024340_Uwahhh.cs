using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class Uwahhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OnlineDebateUserId",
                table: "Argument",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(3827), "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 43, 39, 618, DateTimeKind.Local).AddTicks(3834), "3781efa7-66dc-47f0-860f-e506d04102e4" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OnlineDebateUserId",
                table: "Argument",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(2903), 1 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(2909), 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62da148b-5f86-4a99-911e-a13131ab8f55", "AQAAAAIAAYagAAAAELJqQrRD8XzppU21UM+MPeRzz/sjOpxsS6xKxt7SsU/GvmUi480KEtwcWG3mfaJBnA==", "77c0711d-a11a-4f2d-8735-a71b38b154a5" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(2683));
        }
    }
}
