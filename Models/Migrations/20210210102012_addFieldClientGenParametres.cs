using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class addFieldClientGenParametres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientGen",
                table: "Parametres",
                maxLength: 13,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientGen",
                table: "Parametres");
        }
    }
}
