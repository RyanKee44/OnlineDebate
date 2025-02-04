using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class LeaderboardAddedIPray : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnlineDebateUserId",
                table: "Leaderboard",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d455518-f9c1-4860-b379-45ef8377ccd5", "AQAAAAIAAYagAAAAELw8lsGAbCetJ9/SWECxtinFnuaeam2ERNu+OEzYsxiugQCD+uRN4IV2PnQVEtcABA==", "9ba69550-6abd-48ea-8cd3-805c08189e2d" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 28, 31, 194, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.CreateIndex(
                name: "IX_Leaderboard_OnlineDebateUserId",
                table: "Leaderboard",
                column: "OnlineDebateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaderboard_TopicId",
                table: "Leaderboard",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leaderboard_AspNetUsers_OnlineDebateUserId",
                table: "Leaderboard",
                column: "OnlineDebateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Leaderboard_Topic_TopicId",
                table: "Leaderboard",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leaderboard_AspNetUsers_OnlineDebateUserId",
                table: "Leaderboard");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaderboard_Topic_TopicId",
                table: "Leaderboard");

            migrationBuilder.DropIndex(
                name: "IX_Leaderboard_OnlineDebateUserId",
                table: "Leaderboard");

            migrationBuilder.DropIndex(
                name: "IX_Leaderboard_TopicId",
                table: "Leaderboard");

            migrationBuilder.DropColumn(
                name: "OnlineDebateUserId",
                table: "Leaderboard");

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
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 6, 11, 800, DateTimeKind.Local).AddTicks(9819));

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
        }
    }
}
