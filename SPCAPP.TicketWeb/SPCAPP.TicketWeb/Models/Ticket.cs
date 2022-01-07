using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class TicketWeb
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int Codigo { get; set; }
        public string Estado { get; set; }
        public string Cliente { get; set; }
        public string Alias { get; set; }
        public string AreaEmpresa { get; set; }
        public string EmailEmpresa { get; set; }
        public string Contacto { get; set; }
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
        public int Telefono3 { get; set; }
        public string Email { get; set; }
        public string ModoContacto { get; set; }
        public string AreaTrabajo { get; set; }
        public string TipoSoporte { get; set; }
        public string Asignado { get; set; }
        public string Proyecto { get; set; }
        public string DescripcionProblema { get; set; }
    }
}
