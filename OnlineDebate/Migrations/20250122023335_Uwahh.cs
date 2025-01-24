using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class Uwahh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(2903), 1, 0 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 33, 35, 61, DateTimeKind.Local).AddTicks(2909), 1, 0 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2825), 0, 1 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2838), 0, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19fa6c8c-0dcc-4dad-9b08-82301951a487", "AQAAAAIAAYagAAAAELhTu24lq/mhD6WHpxtKZ7bBupkJv92Y1zdtTr43OTT2rdiztKrUzx0U9Vfmns429g==", "81139497-432f-4961-b9ee-78fd66bd2a40" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 10, 32, 58, 915, DateTimeKind.Local).AddTicks(2537));
        }
    }
}
