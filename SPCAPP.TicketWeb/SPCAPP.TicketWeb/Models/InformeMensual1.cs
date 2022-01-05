using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class InformeMensual1
    {
        public DateTime? Fecha { get; set; }
        public string HoraDeSolicitud { get; set; }
        public int TicketId { get; set; }
        public string Contacto { get; set; }
        public string MotivoDeLlamada { get; set; }
        public string Tecnico { get; set; }
        public string Ot { get; set; }
        public string VR { get; set; }
        public string Tipo { get; set; }
        public DateTime? FechaTrabajo { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public string TotalHoras { get; set; }
        public string Trabajo { get; set; }
        public string Tw { get; set; }
        public string Empresa { get; set; }
    }
}
