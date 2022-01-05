using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class TicketPint
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? HrsPrograma { get; set; }
        public string Programado { get; set; }
        public string Estado { get; set; }
    }
}
