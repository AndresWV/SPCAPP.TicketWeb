using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Models
{
    public class Tickett
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Codigo { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        public String Folio { get; set; }

        public String Estado { get; set; }

        public String Cliente { get; set; }

        public String Alias { get; set; }

        public String Emailempresa { get; set; }

        public String Contacto { get; set; }

        public String Telefono1 { get; set; }

        public String Telefono2 { get; set; }

        public String Telefono3 { get; set; }

        public String Email { get; set; }

        public String ModoContacto { get; set; }

        public String AreaTrabajo { get; set; }

        public String TipoSoporte { get; set; }

        public String Asignado { get; set; }

        public String Proyecto { get; set; }

        public String ResumenTicket { get; set; }
    }
}
