using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Dto
{
    public class CargaMasivaProductosDto
    {
        public List<ProductoPrecioDto> listaProductosFV { get; set; }
        public string listaCostoExcel { get; set; }
    }
    public class ProductoPrecioDto
    {
        public string codArt { get; set; }
        public double fv { get; set; }
    }
    public class CargaMasivaOfertaDto
    {
        public List<RequestProductoOfertaDto> ofertas { get; set; }
        public string listaCosto { get; set; }
    }

    public class RequestProductoOfertaDto
    {
        public string CodigoProducto { get; set; }
        public double PrecioOferta { get; set; }
    }
}
