using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class M66002
    {
        public string PriceList { get; set; }
        public string Descripcion { get; set; }
        public decimal? Factor { get; set; }
        public string PriceListBase { get; set; }
        public bool? Predeterminado { get; set; }
        //public DateTime? FechaI { get; set; }
        //public DateTime? FechaU { get; set; }
        public string UsuarioI { get; set; }
        public string UsuarioU { get; set; }
        public string EstacionI { get; set; }
        public string EstacionU { get; set; }
        //public int IdM66002 { get; set; }
        public string Referencia { get; set; }
        public string CurrencyCode { get; set; }
    }
}
