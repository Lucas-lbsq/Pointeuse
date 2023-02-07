using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pointeuse.Migrations
{
    public partial class PointeuseDBTableUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Villes",
                table: "Villes");

            migrationBuilder.RenameTable(
                name: "Villes",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Villes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Villes",
                table: "Villes",
                column: "Id");
        }
    }
}
