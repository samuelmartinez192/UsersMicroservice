using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersMicroservice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumMatricula = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: false),
                    Ingreso = table.Column<string>(nullable: true),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    Modifica = table.Column<string>(nullable: true),
                    FechaModifica = table.Column<DateTime>(nullable: false),
                    Estatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Apellidos", "Estatus", "FechaIngreso", "FechaModifica", "Ingreso", "Modifica", "Nombres", "NumMatricula", "Sexo" },
                values: new object[] { 1, "Martinez Magdaleno", true, new DateTime(2019, 5, 27, 23, 32, 36, 7, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SMARTINEZ", null, "Samuel Martin", 182948, "M" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Apellidos", "Estatus", "FechaIngreso", "FechaModifica", "Ingreso", "Modifica", "Nombres", "NumMatricula", "Sexo" },
                values: new object[] { 2, "Maldonado Florez", true, new DateTime(2019, 5, 27, 23, 32, 36, 9, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SMARTINEZ", null, "Cesar Javier", 112897, "M" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Apellidos", "Estatus", "FechaIngreso", "FechaModifica", "Ingreso", "Modifica", "Nombres", "NumMatricula", "Sexo" },
                values: new object[] { 3, "Hernandez Rivas", true, new DateTime(2019, 5, 27, 23, 32, 36, 9, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SMARTINEZ", null, "Adrian", 182996, "M" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
