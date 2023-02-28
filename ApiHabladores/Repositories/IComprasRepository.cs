using ApiHabladores.Models.Riopos;
using ApiHabladores.Models.StoreProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Repositories
{
    public interface IComprasRepository
    {
        IEnumerable<M66001> GetCategoriasProductos();
        IEnumerable<M64001> GetListaProveedores();
        IEnumerable<M66002> GetListaDeCostos();
        IEnumerable<ProductoCosto> GetProductosListaDePrecios(string listaPreciosId = "0", string codSap = "0", string codBarra = "0", string codDepartamento = "0", string proovedor = "0", string descripcion = "0");
        IEnumerable<ProductoCosto> GetProductosListaDePrecios(string pBuscar = "", int listaCost = 0);
        int SaveListaPrecio(int UsuarioId, int TiendaId, string Descripcion, string Observacion, int UsuarioIdUpdate, double CantidadArticulos, string productos);
        int SaveListaOferta(int UsuarioId, int TiendaId, string Descripcion, string Observacion, int UsuarioIdUpdate, double CantidadArticulos, string productos , string fechaI , string fechaF);
        IEnumerable<MostrarListaDePrecio> MostrarListaDePrecio(int pListaPrecioId = 0, string pCodAlt = "", int pTiendaId = 0);
        IEnumerable<MostrarListasDePrecio> MostrarListasDePrecio(string pCodProducto = "", int pTiendaId = 0 , int usuarioId = 0, int tipo=0);
        BuscarProductoOfertaDia BuscarProductoOfertaDia(string pFecha = "", int pTiendaId = 0 , string pCodProducto = "");

    }
}
