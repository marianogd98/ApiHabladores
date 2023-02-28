using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Models.StoreProcedure
{
    public class BuscarProductoOfertaDia
    {
        public string CodigoArticulo { get; set; }
        public string Descripcion { get; set; }
        public double PVPOferta { get; set; }
    }
}
