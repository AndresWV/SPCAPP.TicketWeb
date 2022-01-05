using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class ProjTk
    {
        public string IdProy { get; set; }
        public string Obs { get; set; }
        public int? Fc { get; set; }
        public double? Horas { get; set; }
        public string Empresa { get; set; }
        public string Activo { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Nv { get; set; }
        public string Sence { get; set; }
        public string CodAux { get; set; }
    }
}
