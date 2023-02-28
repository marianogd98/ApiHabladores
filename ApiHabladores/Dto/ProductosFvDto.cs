using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Dto
{
    public class ProductosFvDto
    {
        public string CodArt { get; set; }
        public string Descripcion { get; set; }
        public string Moneda { get; set; }
        public double Costo { get; set; }
        public double FV { get; set; }
        public double PVP { get; set; }
    }
}
