using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pointeuse.Migrations
{
    public partial class PointeuseDBMiseAJour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PointsOfInsterest");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Villes",
                newName: "Service");

            migrationBuilder.AddColumn<string>(
                name: "Identifiant",
                table: "Villes",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nom",
                table: "Villes",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Villes",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prenom",
                table: "Villes",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Identifiant",
                table: "Villes");

            migrationBuilder.DropColumn(
                name: "Nom",
                table: "Villes");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Villes");

            migrationBuilder.DropColumn(
                name: "Prenom",
                table: "Villes");

            migrationBuilder.RenameColumn(
                name: "Service",
                table: "Villes",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "PointsOfInsterest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VilleId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointsOfInsterest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PointsOfInsterest_Villes_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Villes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfInsterest_VilleId",
                table: "PointsOfInsterest",
                column: "VilleId");
        }
    }
}
