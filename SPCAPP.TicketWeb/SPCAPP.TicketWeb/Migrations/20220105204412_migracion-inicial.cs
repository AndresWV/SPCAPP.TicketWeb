using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCAPP.TicketWeb.Migrations
{
    public partial class migracioninicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailEmpresa = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono_1 = table.Column<int>(type: "int", nullable: false),
                    Telefono_2 = table.Column<int>(type: "int", nullable: false),
                    Telefono_3 = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModoContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaTrabajo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoSoporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asignado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proyecto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionProblema = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
