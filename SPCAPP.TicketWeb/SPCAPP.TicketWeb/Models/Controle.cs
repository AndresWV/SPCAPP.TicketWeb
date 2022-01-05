using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class Controle
    {
        public int IdControl { get; set; }
        public string ControlNombre { get; set; }
        public string ControlAccion { get; set; }
        public int? FkForm { get; set; }
    }
}
