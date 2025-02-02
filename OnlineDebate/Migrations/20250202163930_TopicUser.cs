using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class TopicUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnlineDebateUserId",
                table: "Topic",
                type: "nvarchar(450)",
                nullable: true);

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
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 356, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 3, 0, 39, 27, 356, DateTimeKind.Local).AddTicks(53));

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
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 2, 3, 0, 39, 27, 355, DateTimeKind.Local).AddTicks(9304), "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId" },
                values: new object[] { new DateTime(2025, 2, 3, 0, 39, 27, 355, DateTimeKind.Local).AddTicks(9336), "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.CreateIndex(
                name: "IX_Topic_OnlineDebateUserId",
                table: "Topic",
                column: "OnlineDebateUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_AspNetUsers_OnlineDebateUserId",
                table: "Topic",
                column: "OnlineDebateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topic_AspNetUsers_OnlineDebateUserId",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Topic_OnlineDebateUserId",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "OnlineDebateUserId",
                table: "Topic");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e24050e-a54e-4703-be23-3083005db20a", "AQAAAAIAAYagAAAAECjNaYVJStF/Xr2LrEzq5ufroFZfmPo7S6pOpZ6KXahbCx+1QatTaYpu5O3Lu0qkKw==", "89fc8fb8-19df-4041-b5bf-cbae4bc98ff1" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 24, 10, 59, 58, 401, DateTimeKind.Local).AddTicks(7941));
        }
    }
}
