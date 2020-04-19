using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpMeNeighbour.Migrations
{
    public partial class CorrectAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adress",
                table: "user");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "user",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "user");

            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "user",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
