using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class CommentCleanup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnlineDebateUserId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 968, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 968, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41688262-aaf2-45fe-80e1-c6aab5102948", "AQAAAAIAAYagAAAAEP2NwzAlxZqRv7MYImS6cyKB0ZnCpFvwTKS5CDeIQ1/FsLAB1rl6XOZ2xJYyAjB/rQ==", "e4a0cf40-318f-4662-8771-25c390f1175e" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArgumentId", "DateCreated", "OnlineDebateUserId" },
                values: new object[] { 1, new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(522), "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArgumentId", "DateCreated", "OnlineDebateUserId" },
                values: new object[] { 2, new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(533), "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 968, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 968, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ArgumentId",
                table: "Comment",
                column: "ArgumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_OnlineDebateUserId",
                table: "Comment",
                column: "OnlineDebateUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Argument_ArgumentId",
                table: "Comment",
                column: "ArgumentId",
                principalTable: "Argument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_OnlineDebateUserId",
                table: "Comment",
                column: "OnlineDebateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Argument_ArgumentId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_OnlineDebateUserId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_ArgumentId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_OnlineDebateUserId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "OnlineDebateUserId",
                table: "Comment");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 355, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 355, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "183461e4-c0e1-4ce8-ab99-167cce387a92", "AQAAAAIAAYagAAAAED3re+mFzBKuoyWDtp0uF1/+FGH9Q6Ttu32qihee9IA/mVGkRsRnJj90+UmShr8g9Q==", "e34c4333-5729-4393-b122-a16d646239d1" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArgumentId", "DateCreated" },
                values: new object[] { 0, new DateTime(2025, 2, 3, 0, 39, 27, 356, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArgumentId", "DateCreated" },
                values: new object[] { 0, new DateTime(2025, 2, 3, 0, 39, 27, 356, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 356, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 356, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 356, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 356, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 355, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 355, DateTimeKind.Local).AddTicks(9336));
        }
    }
}
