using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Models.StoreProcedure
{
    public class SpListaProdHablador
    {
        public string codigo { get; set; }
        public string barra { get; set; }
        public string Descri { get; set; }
        public string precio { get; set; }
        public double pmvp { get; set; }
        public double iva { get; set; }
        public DateTime fecha { get; set; }
        public int id_depa { get; set; }
        public string oferta { get; set; }
        public string precioo { get; set; }
        public int cant { get; set; }
        public string moneda { get; set; }
        public double tasa { get; set; }
        public string codigoSap { get; set; }
        public int tipoPesado { get; set; }


    }
}
