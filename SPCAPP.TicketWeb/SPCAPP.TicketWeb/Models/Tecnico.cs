using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class Tecnico
    {
        public string IdTec { get; set; }
        public string TecnicoNom { get; set; }
        public string Correo { get; set; }
        public string Activo { get; set; }
        public string NombreCalendario { get; set; }
        public string CodAux { get; set; }
    }
}
