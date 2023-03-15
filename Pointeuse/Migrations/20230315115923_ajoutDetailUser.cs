using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pointeuse.Migrations
{
    public partial class ajoutDetailUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetailUser",
                columns: table => new
                {
                    idDetailUser = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idUser = table.Column<int>(type: "INTEGER", nullable: false),
                    Details = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailUser", x => x.idDetailUser);
                    table.ForeignKey(
                        name: "FK_DetailUser_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailUser_idUser",
                table: "DetailUser",
                column: "idUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailUser");
        }
    }
}
