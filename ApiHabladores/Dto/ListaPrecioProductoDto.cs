using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Dto
{
    public class ListaPrecioProductoDto
    {
        public string codArt { get; set; }
        public string CodigoProducto { get; set; }
        public string descripcion { get; set; }
        public string departamento { get; set; }
        public string moneda { get; set; }
        public double costo { get; set; }
        public double fv { get; set; }
        public double pvp { get; set; }
        public string codImpuesto { get; set; }
        public double porImpuesto { get; set; }
    }

    public class ListaPrecioDto
    {
        public int usuario { get; set; }
        public int tiendas { get; set; }
        public string descripcion { get; set; }
        public string observacion { get; set; }
        public List<ListaPrecioProductoDto> listaDePrecios { get; set; }
    }
}
