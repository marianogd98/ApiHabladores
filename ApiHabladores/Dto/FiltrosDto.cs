using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Dto
{
    public class FiltrosDto
    {
        //pagina actual
        public int Page { get; set; } = 1;
        //item por paginas
        public int PerPage { get; set; } = 20;
    }

    public class FiltrosProductListaCostosDto : FiltrosDto
    {
        public string listaCost { get; set; } = "0";
        public string codSap { get; set; } = "0";
        public string codBarra { get; set; } = "0";
        public string descripcion { get; set; } = "0";
        public string departamento { get; set; } = "0";
    }
    public class FiltrosListasDePrecio : FiltrosDto
    {
        public int tienda { get; set; } = 0;
        public int usuarioId { get; set; } = 0;
        public string codProducto { get; set; } = "";
        public int tipo { get; set; } = 0;
    }
    public class FiltrosListaDePrecio
    {
        public int tiendaId { get; set; } = 0;
        public string codProducto { get; set; } = "";
        public int usuario { get; set; } = 0;
    }
    public class FiltrosProductosListaPrecio: FiltrosDto
    {
        public string value { get; set; } = "";
        public int listaCost { get; set; }
    }

    public class FiltrosBuscarProductoOferta
    {
        public string Fecha { get; set; }
        public int Tienda { get; set; }
        public string CodProducto { get; set; } 
    }

    



}
