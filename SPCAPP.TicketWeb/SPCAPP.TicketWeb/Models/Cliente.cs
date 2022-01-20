using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class Cliente
    {
        public string CorreoName { get; set; }
        public string Clave { get; set; }
        public int? Puerto { get; set; }
        public string Server { get; set; }
    }
}
