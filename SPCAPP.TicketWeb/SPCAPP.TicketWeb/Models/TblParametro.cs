using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class TblParametro
    {
        public long IdParametro { get; set; }
        public string Parametro { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }
    }
}
