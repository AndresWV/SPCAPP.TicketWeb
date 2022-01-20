using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class Todo
    {
        public string Fecha { get; set; }
        public string HoraSolicitud { get; set; }
        public int Ticket { get; set; }
        public string Contacto { get; set; }
        public string MotivoLlamada { get; set; }
        public string Tecnico { get; set; }
        public string NºOt { get; set; }
        public string VR { get; set; }
        public string Km { get; set; }
        public string FechaTrabajo { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public string HorasVisitas { get; set; }
        public string HorasRemoto { get; set; }
        public string HorasTaller { get; set; }
        public string HorasProyec { get; set; }
        public string Detalle { get; set; }
        public string Pc { get; set; }
        public string Empresa { get; set; }
        public string Fact { get; set; }
        public string Cont { get; set; }
        public string Estado { get; set; }
        public string Grupo { get; set; }
        public string Tipo { get; set; }
        public int? Validado { get; set; }
    }
}
