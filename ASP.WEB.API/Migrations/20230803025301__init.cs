using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.WEB.API.Migrations
{
    /// <inheritdoc />
    public partial class _init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserChats",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ChatId = table.Column<int>(type: "int", nullable: false),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChats", x => new { x.UserId, x.ChatId });
                    table.ForeignKey(
                        name: "FK_UserChats_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserChats_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(39), "Admin" },
                    { 2, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(53), "Bobr" },
                    { 3, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(54), "Test" },
                    { 4, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(55), "Usver" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedAt", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(229), "oto", 1 },
                    { 2, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(231), "ptp", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "AddedTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(349) },
                    { 2, 1, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(355) },
                    { 1, 2, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(352) },
                    { 2, 2, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(355) },
                    { 1, 3, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(353) },
                    { 1, 4, new DateTime(2023, 8, 3, 9, 53, 1, 467, DateTimeKind.Local).AddTicks(354) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_OwnerId",
                table: "Chats",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChats_ChatId",
                table: "UserChats",
                column: "ChatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserChats");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
