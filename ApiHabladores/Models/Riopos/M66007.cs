using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class M66007
    {
        public string CodArt { get; set; }
        public string PriceList { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaI { get; set; }
        public string UsuarioI { get; set; }
        public string EstacionI { get; set; }
        public DateTime? FechaU { get; set; }
        public string UsuarioU { get; set; }
        public string EstacionU { get; set; }
        public string SubSociedad { get; set; }
        public int IdM66007 { get; set; }
        public string Currency { get; set; }
        public string Taplication { get; set; }
        public decimal? PriceAnt { get; set; }
    }
}
