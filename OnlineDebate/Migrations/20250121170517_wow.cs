using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineDebate.Migrations
{
    /// <inheritdoc />
    public partial class wow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "TopicId" },
                values: new object[] { new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5775), 1 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "TopicId" },
                values: new object[] { new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5780), 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb112d28-ed8f-4fb6-b53b-a4608ddbc757", "AQAAAAIAAYagAAAAEG4t2sS6rVBsCjt3mOcaLLdbbNip9Jq3ZjXyoEPI1T32senlim6nM3mZh0gsliLv0g==", "b03bb00f-be20-458b-87aa-85cc2b6ef18f" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 22, 1, 5, 16, 951, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.CreateIndex(
                name: "IX_Argument_TopicId",
                table: "Argument",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Argument_Topic_TopicId",
                table: "Argument",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Argument_Topic_TopicId",
                table: "Argument");

            migrationBuilder.DropIndex(
                name: "IX_Argument_TopicId",
                table: "Argument");

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "TopicId" },
                values: new object[] { new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4300), 0 });

            migrationBuilder.UpdateData(
                table: "Argument",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "TopicId" },
                values: new object[] { new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4304), 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48f2adfa-80db-4ec5-b684-9501d35f0985", "AQAAAAIAAYagAAAAEPq0cTmT2Eu6bqw5zL9ipD2rg9fxbcYIgF7sfRNG6QyKeFvOJ6Chil7nrGq6rErBwQ==", "d499ae65-ac0d-4200-b6d3-22992721b0e4" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Topic",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 11, 33, 8, 31, DateTimeKind.Local).AddTicks(4092));
        }
    }
}
