using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class LastEditedIsppose : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastEdited",
                table: "Argument",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastEdited" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(3744), null });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastEdited" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(3753), null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0213b788-c8e3-48f5-ab44-ef7df0bfd24a", "AQAAAAIAAYagAAAAEPvF/XcujhFYwR7NIbcQOjWeuKjSKZnTvGwfQ3179H+Os2DPYOmwajOJoNsyDjHEYg==", "6fb7ad95-b004-48a1-9a11-cd38de1b4147" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.InsertData(
                table: "Leaderboard",
                columns: new[] { "Id", "DateCreated", "LeaderboardPoints", "LeaderboardRank", "LeaderboardRefresh", "OnlineDebateUserId", "TopicId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(4440), 1000, 1, 3, "3781efa7-66dc-47f0-860f-e506d04102e4", 1, 0 },
                    { 2, new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(4445), 1000, 2, 3, "3781efa7-66dc-47f0-860f-e506d04102e4", 2, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 7, 11, 9, 37, 202, DateTimeKind.Local).AddTicks(3305));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leaderboard",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leaderboard",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "LastEdited",
                table: "Argument");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a539ecf6-33fa-458e-887b-905eef2b5b05", "AQAAAAIAAYagAAAAEJJK8PISa5crJGsSIBX7AyEn6cM/NpSkV1kd+vSpIXZj/X92fUytyIJbHuC0XfxbxQ==", "b9f7c81e-f206-4ec9-a3e4-ccde5b450764" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 5, 1, 32, 9, 495, DateTimeKind.Local).AddTicks(3040));
        }
    }
}
