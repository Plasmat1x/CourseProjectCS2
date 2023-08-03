using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.WEB.API.Migrations
{
    /// <inheritdoc />
    public partial class _u4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CratedAt",
                table: "Messages",
                newName: "CreatedAt");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Bobr", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Test", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Usver", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Admin", 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Admin", 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumns: new[] { "ChatId", "SenderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumns: new[] { "ChatId", "SenderId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumns: new[] { "ChatId", "SenderId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumns: new[] { "ChatId", "SenderId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 3, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 13, 18, 2, 12, DateTimeKind.Local).AddTicks(3136));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Messages",
                newName: "CratedAt");

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

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(861));

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

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumns: new[] { "ChatId", "SenderId" },
                keyValues: new object[] { 1, 1 },
                column: "CratedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumns: new[] { "ChatId", "SenderId" },
                keyValues: new object[] { 1, 2 },
                column: "CratedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumns: new[] { "ChatId", "SenderId" },
                keyValues: new object[] { 3, 2 },
                column: "CratedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumns: new[] { "ChatId", "SenderId" },
                keyValues: new object[] { 3, 3 },
                column: "CratedAt",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(978));

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
                keyValues: new object[] { 3, 2 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "AddedTime",
                value: new DateTime(2023, 8, 3, 11, 23, 51, 595, DateTimeKind.Local).AddTicks(902));

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
        }
    }
}
