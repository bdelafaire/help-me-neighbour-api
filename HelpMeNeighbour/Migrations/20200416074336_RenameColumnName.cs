using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpMeNeighbour.Migrations
{
    public partial class RenameColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_ad",
                table: "message");

            migrationBuilder.DropColumn(
                name: "id_author",
                table: "message");

            migrationBuilder.DropColumn(
                name: "id_user",
                table: "ad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "id_ad",
                table: "message",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "id_author",
                table: "message",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "id_user",
                table: "ad",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
