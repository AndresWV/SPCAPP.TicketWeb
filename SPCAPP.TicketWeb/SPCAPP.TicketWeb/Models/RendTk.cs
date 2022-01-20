using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class RendTk
    {
        public int Id { get; set; }
        public int? Tk { get; set; }
        public string GastoId { get; set; }
        public double? Precio { get; set; }
        public double? Cantidad { get; set; }
        public double? Total { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
