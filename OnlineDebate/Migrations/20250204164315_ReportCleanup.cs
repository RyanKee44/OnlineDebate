using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class ReportCleanup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnlineDebateUserId",
                table: "Report",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fa5a15e-1053-47fb-8f92-c7c8c770ab3b", "AQAAAAIAAYagAAAAEG03UM6Mc7Rk92Ko3gCnlOEBxRVSQSsiFncy/BKvji+6YdRF1AEkCIGkziy2OCjf5g==", "c8470046-235e-4740-8c3f-e4db6eaded32" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArgumentId", "CommentId", "DateCreated", "OnlineDebateUserId" },
                values: new object[] { 1, 1, new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2575), "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArgumentId", "CommentId", "DateCreated", "OnlineDebateUserId" },
                values: new object[] { 2, 2, new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2582), "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.CreateIndex(
                name: "IX_Report_ArgumentId",
                table: "Report",
                column: "ArgumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_CommentId",
                table: "Report",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_OnlineDebateUserId",
                table: "Report",
                column: "OnlineDebateUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Argument_ArgumentId",
                table: "Report",
                column: "ArgumentId",
                principalTable: "Argument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_AspNetUsers_OnlineDebateUserId",
                table: "Report",
                column: "OnlineDebateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Comment_CommentId",
                table: "Report",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_Argument_ArgumentId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_AspNetUsers_OnlineDebateUserId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Comment_CommentId",
                table: "Report");

            migrationBuilder.DropIndex(
                name: "IX_Report_ArgumentId",
                table: "Report");

            migrationBuilder.DropIndex(
                name: "IX_Report_CommentId",
                table: "Report");

            migrationBuilder.DropIndex(
                name: "IX_Report_OnlineDebateUserId",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "OnlineDebateUserId",
                table: "Report");

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
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(533));

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
                columns: new[] { "ArgumentId", "CommentId", "DateCreated" },
                values: new object[] { 0, 0, new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArgumentId", "CommentId", "DateCreated" },
                values: new object[] { 0, 0, new DateTime(2025, 2, 5, 0, 31, 34, 969, DateTimeKind.Local).AddTicks(891) });

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
        }
    }
}
