using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pointeuse.Migrations
{
    public partial class ldfhljg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Prenom = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Identifiant = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Service = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pointage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false),
                    Heure_Matin = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Heure_Midi = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Heure_ApresMidi = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Heure_Soir = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pointage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pointage_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pointage_IdUser",
                table: "Pointage",
                column: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pointage");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
