using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Persistence.Migrations
{
    public partial class BookTableaddbaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeReserve",
                table: "BookTables",
                type: "Time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "BookTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "BookTables",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveTime",
                table: "BookTables",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "BookTables",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "BookTables");

            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "BookTables");

            migrationBuilder.DropColumn(
                name: "RemoveTime",
                table: "BookTables");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "BookTables");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeReserve",
                table: "BookTables",
                type: "time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "Time");
        }
    }
}
