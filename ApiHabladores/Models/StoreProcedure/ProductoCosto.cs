using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Models.StoreProcedure
{
    public class ProductoCosto
    {
        public string CodArt { get; set; }
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public string Departamento { get; set; }
        public double PrecioDetal { get; set; }
        public string Moneda { get; set; }
        public decimal Costo { get; set; }
        public string CodImpuesto { get; set; }
        public double ValorImpuesto { get; set; }
    }
}
