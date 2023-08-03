using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.WEB.API.Migrations
{
    /// <inheritdoc />
    public partial class _u3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ChatId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CratedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => new { x.SenderId, x.ChatId });
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedAt", "Name", "OwnerId" },
                values: new object[] { 3, new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(861), "ptp2", 2 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Bobr", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Test", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Usver", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Admin", 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Admin", 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "ChatId", "SenderId", "CratedAt", "Text" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(973), "Hellow every one" },
                    { 1, 2, new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(976), "Hi Admin" }
                });

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "ChatId", "SenderId", "CratedAt", "Text" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(977), "What happens" },
                    { 3, 3, new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(978), "Has trouble" }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "AddedTime" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(901) },
                    { 3, 3, new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(902) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Bobr", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Test", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Usver", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Admin", 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Admin", 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6748));
        }
    }
}
