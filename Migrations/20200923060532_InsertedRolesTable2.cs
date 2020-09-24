using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class InsertedRolesTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "263e32eb-7084-4075-bdda-5dd5cf14d794", "f7e3206a-8d5e-4266-b753-12c085e1f1ff", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0980a1a1-0d41-4f0a-8073-6fb3a502cc84", "a38c32a8-386a-40a9-98c7-d41f778e3871", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0980a1a1-0d41-4f0a-8073-6fb3a502cc84");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "263e32eb-7084-4075-bdda-5dd5cf14d794");

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<Guid>",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
    }
}
