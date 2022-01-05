using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Models
{
    public class Ticket
    {

        [Key]
        [Display(Name = "Folio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha es un campo obligatorio")]
        //Limitando a solo entregar la fecha
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La Hora es un campo obligatorio")]
        //Limitando a solo entregar la hora
        [DataType(DataType.Time)]
        [Display(Name = "Hora")]
        public DateTime Hora { get; set; }

        [Required(ErrorMessage = "El Folio es un campo obligatorio")]
        //No encontre como limitar la cantidad de enteros y cuantos digitos son????***********************************************
        [Display(Name = "Código")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El Estado es un campo obligatorio")]
        [Display(Name = "Estado")]
        public String Estado { get; set; }

        [Required(ErrorMessage = "El Cliente es un campo obligatorio")]
        [Display(Name = "Cliente")]
        public String Cliente { get; set; }

        [Display(Name = "Alias")]
        public String Alias { get; set; }

        [Required(ErrorMessage = "El Área empresa es un campo obligatorio")]
        [Display(Name = "Área Empresa")]
        public String AreaEmpresa { get; set; }

        [Required(ErrorMessage = "El Email Empresa es un campo obligatorio")]
        [StringLength(30, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 10)]
        [Display(Name = "Email Empresa")]
        public String EmailEmpresa { get; set; }

        [Required(ErrorMessage = "El Contacto es un campo obligatorio")]
        [Display(Name = "Contacto")]
        public String Contacto { get; set; }

        [Display(Name = "Telefono 1")]
        public int Telefono_1 { get; set; }

        [Display(Name = "Telefono 2")]
        public int Telefono_2 { get; set; }

        [Display(Name = "Telefono 3")]
        public int Telefono_3 { get; set; }

        [Required(ErrorMessage = "El Email es un campo obligatorio")]
        [Display(Name = "Email")]
        public String Email { get; set; }


        [Required(ErrorMessage = "El Modo de contacto es un campo obligatorio")]
        [Display(Name = "Modo de contacto")]
        public String ModoContacto { get; set; }

        [Required(ErrorMessage = "El Área de trabajo es un campo obligatorio")]
        [Display(Name = "Área de trabajo")]
        public String AreaTrabajo { get; set; }

        [Required(ErrorMessage = "El Tipo de Soporte es un campo obligatorio")]
        [Display(Name = "Tipo de soporte")]
        public String TipoSoporte { get; set; }

        [Required(ErrorMessage = "El Asignado es un campo obligatorio")]
        [Display(Name = "Asignado")]
        public String Asignado { get; set; }

        [Display(Name = "Proyecto")]
        public String Proyecto { get; set; }

        [Display(Name = "Descripción del problema")]
        public String DescripcionProblema { get; set; }
    }
}

