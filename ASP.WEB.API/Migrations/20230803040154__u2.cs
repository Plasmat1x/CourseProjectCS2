using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.WEB.API.Migrations
{
    /// <inheritdoc />
    public partial class _u2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValues: new object[] { "Admin", 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Admin", 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Name", "OwnerId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { "Test", 1, new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7054), 3 },
                    { "Usver", 1, new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7055), 4 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Test", 1 });

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Usver", 1 });

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

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Bobr", 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Admin", 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumns: new[] { "Name", "OwnerId" },
                keyValues: new object[] { "Admin", 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9134));

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
        }
    }
}
