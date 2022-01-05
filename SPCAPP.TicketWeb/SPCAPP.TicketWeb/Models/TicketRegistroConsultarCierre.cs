using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class TicketRegistroConsultarCierre
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Contacto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Requerimiento { get; set; }
        public string Tecnico { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public DateTime? HrsPrograma { get; set; }
        public string Avance { get; set; }
        public DateTime? FechaAvance { get; set; }
        public string Ot { get; set; }
        public string Horaav { get; set; }
    }
}
