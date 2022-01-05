using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class Consulta1P
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Contacto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Requerimiento { get; set; }
        public string Trabajo { get; set; }
        public string TerminadoPor { get; set; }
        public string Visita { get; set; }
        public string Taller { get; set; }
        public string Remoto { get; set; }
        public string Proyecto { get; set; }
        public DateTime? HrsInicio { get; set; }
        public DateTime? HrsTermino { get; set; }
        public string Tecnico { get; set; }
        public string Ot { get; set; }
        public string Tw { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaTrabajo { get; set; }
        public string Realizado { get; set; }
        public string Email { get; set; }
        public string CodAux { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Programado { get; set; }
        public DateTime? HrsPrograma { get; set; }
        public TimeSpan? HrsPrograma1 { get; set; }
        public string Grupo { get; set; }
        public string Avance { get; set; }
        public DateTime? FechaAvance { get; set; }
        public string Medio { get; set; }
        public string FkProcede { get; set; }
        public string FonoContacto { get; set; }
        public string Telefono { get; set; }
        public string ProyectoId { get; set; }
        public int? CerradoId { get; set; }
        public string UserCierre { get; set; }
        public string Modo { get; set; }
        public string GastoId { get; set; }
        public double? Monto { get; set; }
        public double? Equivalencia { get; set; }
        public double? Total { get; set; }
    }
}
