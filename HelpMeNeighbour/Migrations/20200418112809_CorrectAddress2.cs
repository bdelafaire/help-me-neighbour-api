using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpMeNeighbour.Migrations
{
    public partial class CorrectAddress2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "adress",
                table: "ad",
                newName: "address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "address",
                table: "ad",
                newName: "adress");
        }
    }
}
