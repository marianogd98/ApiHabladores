using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Dto
{
    public class ListaDeOfertaDto
    {
        public int usuario { get; set; }
        public int[] tiendas { get; set; }
        public string descripcion { get; set; }
        public string observacion { get; set; }
        public string fechaI { get; set; }
        public string fechaF { get; set; }
        public List<ProductoListaDeOfertaDto> listaDeOfertas { get; set; }

    }
    public class ProductoListaDeOfertaDto
    {
        public int id { get; set; }
        public string CodArt { get; set; }
        public string descripcion { get; set; }
        public double costo { get; set; }
        public double precioDetal { get; set; }
        public double descuento { 
            get {
                if (precioDetal > 0 && precioOferta < precioDetal)
                    return Math.Round( 1-(precioOferta/precioDetal),2);
                else
                    return 0;
            
            } 
        }
        public int pesado { get; set; }
        public string codigoMoneda { get; set; }
        public int tipo { get; set; }
        public double precioOferta { get; set; }
    }

    

}
