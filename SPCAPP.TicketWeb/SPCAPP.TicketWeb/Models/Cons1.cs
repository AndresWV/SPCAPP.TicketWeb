using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class Cons1
    {
        public string NomAux { get; set; }
        public decimal? Folio { get; set; }
        public string CodProd { get; set; }
        public string DetProd { get; set; }
        public double? CantFacturada { get; set; }
        public double? TotalProducto { get; set; }
        public double? SubTotalFactura { get; set; }
    }
}
