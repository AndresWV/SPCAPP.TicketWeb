using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCAPP.TicketWeb.Migrations
{
    public partial class Tickett : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.CreateTable(
                name: "Tickett",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Folio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emailempresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono1 = table.Column<int>(type: "int", nullable: false),
                    Telefono2 = table.Column<int>(type: "int", nullable: false),
                    Telefono3 = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModoContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaTrabajo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoSoporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asignado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proyecto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumenTicket = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickett", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickett");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaTrabajo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asignado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionProblema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModoContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proyecto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono1 = table.Column<int>(type: "int", nullable: false),
                    Telefono2 = table.Column<int>(type: "int", nullable: false),
                    Telefono3 = table.Column<int>(type: "int", nullable: false),
                    TipoSoporte = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });
        }
    }
}
