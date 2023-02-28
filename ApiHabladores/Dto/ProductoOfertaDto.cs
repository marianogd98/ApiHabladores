using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Dto
{
    public class ProductoOfertaDto
    {
        public string CodArt { get; set; }
        public string Descripcion { get; set; }
        public string Moneda { get; set; }
        public double Costo { get; set; }
        public double PrecioDetal { get; set; }
        public double PrecioOferta { get; set; }
        public string CodImpuesto { get; set; }
        public double ValorImpuesto { get; set; }

    }
}
