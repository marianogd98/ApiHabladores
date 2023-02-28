using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class VwReporteZetum
    {
        public int Id { get; set; }
        public int CajaId { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroZeta { get; set; }
        public double Monto { get; set; }
        public string UltimaFactura { get; set; }
        public double CantidadFactura { get; set; }
    }
}
