using Microsoft.EntityFrameworkCore.Migrations;

namespace y.Migrations
{
    public partial class ChangedPetNameBackToName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "petName",
                table: "Pets",
                newName: "name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Pets",
                newName: "petName");
        }
    }
}
