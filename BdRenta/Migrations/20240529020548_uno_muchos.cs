using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BdRenta.Migrations
{
    /// <inheritdoc />
    public partial class uno_muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutomovilId",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Automoviles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Especificaciones = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automoviles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_AutomovilId",
                table: "Personas",
                column: "AutomovilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Automoviles_AutomovilId",
                table: "Personas",
                column: "AutomovilId",
                principalTable: "Automoviles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Automoviles_AutomovilId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Automoviles");

            migrationBuilder.DropIndex(
                name: "IX_Personas_AutomovilId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "AutomovilId",
                table: "Personas");
        }
    }
}
