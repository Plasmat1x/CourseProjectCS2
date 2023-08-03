using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.WEB.API.Migrations
{
    /// <inheritdoc />
    public partial class _u1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => new { x.OwnerId, x.Name });
                    table.ForeignKey(
                        name: "FK_Contacts_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contacts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Name", "OwnerId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { "Bobr", 1, new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9130), 2 },
                    { "Admin", 2, new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9132), 1 },
                    { "Admin", 3, new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9134), 1 }
                });

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserId",
                table: "Contacts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(55));
        }
    }
}
