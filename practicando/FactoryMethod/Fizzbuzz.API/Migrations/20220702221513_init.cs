using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fizzbuzz.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FizzBuzzValues",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    fizzBuzzValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FizzBuzzValues");
        }
    }
}
