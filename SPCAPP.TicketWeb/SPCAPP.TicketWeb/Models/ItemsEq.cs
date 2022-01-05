using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class ItemsEq
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string CodAux { get; set; }
        public DateTime? FechaI { get; set; }
        public DateTime? FecahaT { get; set; }
        public string Activo { get; set; }
        public double? Valor { get; set; }
    }
}
