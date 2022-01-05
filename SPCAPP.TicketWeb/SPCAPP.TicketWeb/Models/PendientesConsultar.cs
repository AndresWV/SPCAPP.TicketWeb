using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class PendientesConsultar
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Contacto { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Requerimiento { get; set; }
        public string Tecnico { get; set; }
        public string Tipo { get; set; }
        public string Avance { get; set; }
        public string Fono { get; set; }
    }
}
