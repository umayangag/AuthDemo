using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class InsertedRolesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6b8ec64f-6f9b-4208-86cc-73f2ba985191");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bf88d214-f7fc-4e8a-acad-026565cf9d2d");

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<Guid>",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<Guid>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64c94c06-99d4-4875-a5e5-bdf436411302", "69d175cc-b4e6-438f-a8e1-0b80edf466ac", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a713a9cf-044c-40b2-915d-2a6aa8175a94", "94e08c40-0283-4f28-99d6-664a52621b58", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUserRole<Guid>");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "64c94c06-99d4-4875-a5e5-bdf436411302");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a713a9cf-044c-40b2-915d-2a6aa8175a94");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf88d214-f7fc-4e8a-acad-026565cf9d2d", "3e1c2eb5-e0b0-4a53-acd0-3ea778a68e31", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b8ec64f-6f9b-4208-86cc-73f2ba985191", "2e886652-6426-41e3-970b-bd6f722e6c8e", "Administrator", "ADMINISTRATOR" });
        }
    }
}
