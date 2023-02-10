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
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "User",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Villes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Villes",
                table: "Villes",
                column: "Id");
        }
    }
}
