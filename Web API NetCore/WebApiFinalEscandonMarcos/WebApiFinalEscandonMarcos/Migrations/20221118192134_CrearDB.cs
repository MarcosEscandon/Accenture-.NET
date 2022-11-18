using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinalEscandonMarcos.Migrations
{
    public partial class CrearDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Hospital_Cod = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(50)", nullable: false),
                    Num_Cama = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Hospital_Cod);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Doctor_No = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hospital_Cod = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    Especialidad = table.Column<string>(type: "varchar(50)", nullable: false),
                    Hospital_Cod1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Doctor_No);
                    table.ForeignKey(
                        name: "FK_Doctor_Hospital_Hospital_Cod1",
                        column: x => x.Hospital_Cod1,
                        principalTable: "Hospital",
                        principalColumn: "Hospital_Cod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Hospital_Cod1",
                table: "Doctor",
                column: "Hospital_Cod1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Hospital");
        }
    }
}
