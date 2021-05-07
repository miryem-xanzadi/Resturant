using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Persistence.Migrations
{
    public partial class tt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactTable",
                table: "ContactTable");

            migrationBuilder.RenameTable(
                name: "ContactTable",
                newName: "ContactTables");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactTables",
                table: "ContactTables",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactTables",
                table: "ContactTables");

            migrationBuilder.RenameTable(
                name: "ContactTables",
                newName: "ContactTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactTable",
                table: "ContactTable",
                column: "Id");
        }
    }
}
