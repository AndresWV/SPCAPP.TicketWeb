using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class TblExclusionBloqueo
    {
        public long IdBloqueo { get; set; }
        public string CodAux { get; set; }
        public bool Bloqueado { get; set; }
    }
}
