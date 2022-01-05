using System;
using System.Collections.Generic;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class Adjunto
    {
        public int Ot { get; set; }
        public string Descripcion1 { get; set; }
        public byte[] Img1 { get; set; }
        public byte[] Img2 { get; set; }
        public string Descripcion2 { get; set; }
    }
}
