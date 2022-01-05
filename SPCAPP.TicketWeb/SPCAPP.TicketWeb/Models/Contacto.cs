using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class Contacto
    {
        public string CodAuc { get; set; }
        public string NomCon { get; set; }
        public string CarCon { get; set; }
        public string FonCon { get; set; }
        public string FonCon2 { get; set; }
        public string FonCon3 { get; set; }
        public string FaxCon { get; set; }
        public string Casilla { get; set; }
        public string Email { get; set; }
        public string Idnotas { get; set; }
        public string TipoSaludo { get; set; }
        public string Usuario { get; set; }
        public string Proceso { get; set; }
        public DateTime? FechaUlMod { get; set; }
        public string Sistema { get; set; }
        public DateTime? FechaUltEnvCorreo { get; set; }
    }
}
