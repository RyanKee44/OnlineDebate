using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class NotificationCleanup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnlineDebateUserId",
                table: "Notifications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ccd3375-f40d-41ce-b19f-7c05933968f4", "AQAAAAIAAYagAAAAEFP9gsvxcI+NYACcUafkvWRBshVBU5whXEm1/ElWNCt+xd2vOPnmSCqZl1rLqHVaAQ==", "665a761b-1606-4cb1-9d91-668de412a0d4" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "TopicId" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(9809), "3781efa7-66dc-47f0-860f-e506d04102e4", 1 });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OnlineDebateUserId", "TopicId" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(9819), "3781efa7-66dc-47f0-860f-e506d04102e4", 1 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_OnlineDebateUserId",
                table: "Notifications",
                column: "OnlineDebateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_TopicId",
                table: "Notifications",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_AspNetUsers_OnlineDebateUserId",
                table: "Notifications",
                column: "OnlineDebateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Topic_TopicId",
                table: "Notifications",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_AspNetUsers_OnlineDebateUserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Topic_TopicId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_OnlineDebateUserId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_TopicId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "OnlineDebateUserId",
                table: "Notifications");

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
                columns: new[] { "DateCreated", "TopicId" },
                values: new object[] { new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2800), 0 });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "TopicId" },
                values: new object[] { new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2804), 0 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 0, 43, 13, 208, DateTimeKind.Local).AddTicks(2582));

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
        }
    }
}
