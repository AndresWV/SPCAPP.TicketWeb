using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class Empresa
    {
        public string CodAux { get; set; }
        public string NomAux { get; set; }
        public double? Uf { get; set; }
        public double? Km { get; set; }
        public double? HorasContratadas { get; set; }
        public double? HorasVisita { get; set; }
        public double? HorasRespldos { get; set; }
        public double? TotalHoras { get; set; }
        public string Codigo { get; set; }
        public double? ValorKmAc { get; set; }
        public string Clave { get; set; }
    }
}
