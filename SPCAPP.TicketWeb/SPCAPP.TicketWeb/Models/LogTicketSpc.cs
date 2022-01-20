using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class LogTicketSpc
    {
        public int Id { get; set; }
        public DateTime? FechaLog { get; set; }
        public string TipoMov { get; set; }
        public string Equipo { get; set; }
        public string Usuario { get; set; }
        public string Ticket { get; set; }
        public string EstadoTk { get; set; }
        public int? TicketId { get; set; }
        public string UserId { get; set; }
    }
}
