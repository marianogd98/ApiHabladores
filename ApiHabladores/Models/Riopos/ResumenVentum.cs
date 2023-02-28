using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class ResumenVentum
    {
        public int TiendaId { get; set; }
        public DateTime Fecha { get; set; }
        public int CantFactura { get; set; }
        public double TotalBolivares { get; set; }
        public double TotalDolares { get; set; }
        public double TicketPromedio { get; set; }
        public int MetaId { get; set; }
    }
}
