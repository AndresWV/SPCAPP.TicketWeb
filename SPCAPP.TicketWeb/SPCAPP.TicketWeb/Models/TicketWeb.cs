using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Models
{
    public class TicketWeb
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La Fecha es un campo obligatorio")]
        [DataType(DataType.Date)]
        public DateTime Fecha{ get; set; }

        [Required(ErrorMessage = "La Hora es un campo obligatorio")]
        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        [Required(ErrorMessage = "El Folio es un campo obligatorio")]
        public String Folio { get; set; }

        [Required(ErrorMessage = "El Estado es un campo obligatorio")]
        public String Estado { get; set; }

        [Required(ErrorMessage = "El Cliente es un campo obligatorio")]
        public String Cliente { get; set; }

        public String Alias { get; set; }

        public String Emailempresa { get; set; }

        [Required(ErrorMessage = "El Contacto es un campo obligatorio")]
        public String Contacto { get; set; }

        public int Telefono1 { get; set; }

        public int Telefono2 { get; set; }

        public int Telefono3 { get; set; }

        public String Email { get; set; }

        [Required(ErrorMessage = "El Modo de contacto es un campo obligatorio")]
        public String ModoContacto { get; set; }

        [Required(ErrorMessage = "El Area de trabajo es un campo obligatorio")]
        public String AreaTrabajo { get; set; }

        [Required(ErrorMessage = "El Tipo de soporte es un campo obligatorio")]
        public String TipoSoporte { get; set; }

        [Required(ErrorMessage = "El Asignado es un campo obligatorio")]
        public String Asignado { get; set; }

        [Required(ErrorMessage = "El Proyecto es un campo obligatorio")]
        public String Proyecto { get; set; }

        public String ResumenTicket { get; set; }
    }
}
