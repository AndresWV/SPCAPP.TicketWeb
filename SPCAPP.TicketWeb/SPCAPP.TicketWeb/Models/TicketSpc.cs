﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class TicketSpc
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Contacto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Requerimiento { get; set; }
        public string Trabajo { get; set; }
        public string TerminadoPor { get; set; }
        public string Visita { get; set; }
        public string Taller { get; set; }
        public string Remoto { get; set; }
        public string Proyecto { get; set; }
        public DateTime? HrsInicio { get; set; }
        public DateTime? HrsTermino { get; set; }
        public string Tecnico { get; set; }
        public string Ot { get; set; }
        public string Tw { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaTrabajo { get; set; }
        public string Realizado { get; set; }
        public string Email { get; set; }
        public string CodAux { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Programado { get; set; }
        public DateTime? HrsPrograma { get; set; }
        public TimeSpan? HrsPrograma1 { get; set; }
        public string Grupo { get; set; }
        public string Avance { get; set; }
        public DateTime? FechaAvance { get; set; }
        public string Medio { get; set; }
        public string Fk_procede { get; set; }
        public string Fono_contacto { get; set; }
        public string Telefono { get; set; }
        public string ProyectoId { get; set; }
        public int? CerradoId { get; set; }
        public string UserCierre { get; set; }
        public string Modo { get; set; }
        public string UserCreaTk { get; set; }
        public string Passwords { get; set; }
        public string CpbAno { get; set; }
        public string CpbNum { get; set; }
    }
}
