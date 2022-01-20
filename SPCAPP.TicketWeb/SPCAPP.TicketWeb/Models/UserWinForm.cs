using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class UserWinForm
    {
        public string Usuario { get; set; }
        public string Tecnico { get; set; }
        public string Clave { get; set; }
        public int? Tipo { get; set; }
    }
}
