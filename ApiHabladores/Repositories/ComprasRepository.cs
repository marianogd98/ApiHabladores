using ApiHabladores.Models;
using ApiHabladores.Models.Riopos;
using ApiHabladores.Models.StoreProcedure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Repositories
{
    public class ComprasRepository : IComprasRepository
    {
        private readonly RIOPOSContext _context;
        public ComprasRepository(RIOPOSContext context)
        {
            _context = context;
        }

        public IEnumerable<M66001> GetCategoriasProductos()
        {
            var data = from dept in _context.M66001s select new M66001() { IdM66001 = dept.IdM66001, ItmsGrpNam = dept.ItmsGrpNam, ItmsGrpCod = (string)dept.ItmsGrpCod.Trim() };
            return data;
        }

        public IEnumerable<M66002> GetListaDeCostos()
        {
            List<M66002> data = _context.spBuscarListaCostoGeneral
                .FromSqlRaw("EXEC spBuscarListaCostoGeneral").ToList();

            return data;
        }

        public IEnumerable<M64001> GetListaProveedores()
        {
            var data = (from prov in _context.M64001s select new M64001() { CardName = prov.CardName, CardCode = prov.CardCode });

            return data;
        }

        public IEnumerable<ProductoCosto> GetProductosListaDePrecios(string listaPreciosId = "0", string codSap = "0", string codBarra = "0", string codDepartamento = "0", string proovedor = "0", string descripcion = "0")
        {
            try
            {
                //using (var context = new POS_HQ_RIO_PRDContext())
                //{

                var parameters = new List<SqlParameter>()
                {
                    new SqlParameter("@pListaPrecio", listaPreciosId),
                    new SqlParameter("@pCodSap", codSap),
                    new SqlParameter("@pCodBarra", codBarra),
                    new SqlParameter("@pDescripcion", descripcion),
                    new SqlParameter("@pDepartamento", codDepartamento)
                };

                List<ProductoCosto> data = _context.SpProductosCosto
                    .FromSqlRaw("EXEC spBuscarListaCosto @pListaPrecio=@pListaPrecio, @pCodSap=@pCodSap , @pCodBarra=@pCodBarra , @pDescripcion=@pDescripcion , @pDepartamento=@pDepartamento",
                    parameters.ToArray()).ToList();

                return data;
                //}
            }
            catch (Exception e)
            {
                var m = e.Message.ToString();
                return null;
            }
        }

        public IEnumerable<ProductoCosto> GetProductosListaDePrecios(string pBuscar = "", int listaCost = 0)
        {
            try
            {
                //using (var context = new POS_HQ_RIO_PRDContext())
                //{

                var parameters = new List<SqlParameter>()
                {
                    new SqlParameter("@buscar", pBuscar),
                    new SqlParameter("@pListaPrecio", listaCost)
                };

                List<ProductoCosto> data = _context.SpBuscarProductosListaPrecio
                    .FromSqlRaw("EXEC [BuscarProductosListaPrecio] @buscar=@buscar,@pListaPrecio=@pListaPrecio",
                    parameters.ToArray()).ToList();

                return data;
                //}
            }
            catch (Exception e)
            {
                var m = e.Message.ToString();
                return null;
            }
        }

        public IEnumerable<MostrarListaDePrecio> MostrarListaDePrecio(int pListaPrecioId = 0, string pCodAlt = "", int pTiendaId = 0)
        {
            
            var parameters = new List<SqlParameter>(){
                    new SqlParameter("@ListaPrecioId", pListaPrecioId),
                    new SqlParameter("@CodAlt", pCodAlt),
                    new SqlParameter("@TiendaId", pTiendaId)
            };

            List<MostrarListaDePrecio> data = _context.SpMostrarListaDePrecio
                    .FromSqlRaw("EXEC [dbo].[MostrarListasdePrecio] @CodAlt=@CodAlt , @TiendaId=@TiendaId , @ListaPrecioId=@ListaPrecioId",
                    parameters.ToArray()).ToList();

            return data;
            
        }

        public IEnumerable<MostrarListasDePrecio> MostrarListasDePrecio(string pCodProducto = "", int pTiendaId = 0, int usuarioId = 0,int tipo = 0)
        {
            var parameters = new List<SqlParameter>(){
                    new SqlParameter("@CodAlt", pCodProducto),
                    new SqlParameter("@TiendaId", pTiendaId),
                    new SqlParameter("@usuarioId", usuarioId),
                    new SqlParameter("@tipo", tipo)
            };

            List<MostrarListasDePrecio> data = _context.SpMostrarListasDePrecio
                    .FromSqlRaw("EXEC [dbo].[MostrarListasdePrecioCabecera] @usuarioId=@usuarioId, @CodAlt=@CodAlt , @TiendaId=@TiendaId,@tipo=@tipo",
                    parameters.ToArray()).ToList();

            return data;
        }

        public int SaveListaPrecio(int UsuarioId, int TiendaId, string Descripcion, string Observacion, int UsuarioIdUpdate, double CantidadArticulos, string productos)
        {
            try
            {
                var parameters = new List<SqlParameter>(){
                        //new SqlParameter("@pListaPrecio", listaPreciosId),
                        new SqlParameter("@pUsuarioId", UsuarioId),
                        new SqlParameter("@pTiendaId", TiendaId),
                        new SqlParameter("@pDescripcion", Descripcion),
                        new SqlParameter("@pUsuarioIdUpdate", UsuarioIdUpdate),
                        new SqlParameter("@pCantidadArticulos", CantidadArticulos),
                        new SqlParameter("@pObservacion", Observacion),
                        new SqlParameter("@pProductos", productos)
                };

                List<InsertListaPrecio> data = _context.SpInsertListaDePrecio
                        .FromSqlRaw("EXEC [dbo].[GuardarListaPrecio] @UsuarioId=@pUsuarioId , @TiendaId=@pTiendaId , @Descripcion=@pDescripcion , @UsuarioIdUpdate=@pUsuarioIdUpdate , @CantidadArticulos=@pCantidadArticulos , @Observacion=@pObservacion , @productos=@pProductos",
                        parameters.ToArray()).ToList();

                return (int)data[0].Id;
            }
            catch(Exception ex)
            {
                var m = ex.Message.ToString();
                return 0;
            }
        }

        public int SaveListaOferta(int UsuarioId, int TiendaId, string Descripcion, string Observacion, int UsuarioIdUpdate, double CantidadArticulos, string productos, string fechaI, string fechaF)
        {
            try
            {
                var parameters = new List<SqlParameter>(){
                        new SqlParameter("@UsuarioId", UsuarioId),
                        new SqlParameter("@TiendaId", TiendaId),
                        new SqlParameter("@Descripcion", Descripcion),
                        new SqlParameter("@UsuarioIdUpdate", UsuarioIdUpdate),
                        new SqlParameter("@CantidadArticulos", CantidadArticulos),
                        new SqlParameter("@Observacion", Observacion),
                        new SqlParameter("@Productos", productos),
                        new SqlParameter("@FechaInicioOferta", fechaI),
                        new SqlParameter("@FechaFinOferta", fechaF)
                };

                List<InsertListaPrecio> data = _context.SpInsertListaDePrecio
                        .FromSqlRaw("EXEC [dbo].[GuardarListaPrecioOferta] @UsuarioId=@UsuarioId , @TiendaId=@TiendaId , @Descripcion=@Descripcion , @UsuarioIdUpdate=@UsuarioIdUpdate , @CantidadArticulos=@CantidadArticulos , @Observacion=@Observacion , @productos=@Productos, @FechaInicioOferta=@FechaInicioOferta , @FechaFinOferta=@FechaFinOferta",
                        parameters.ToArray()).ToList();

                return (int)data[0].Id;
            }
            catch (Exception ex)
            {
                var m = ex.Message.ToString();
                return -1;
            }
        }

        public BuscarProductoOfertaDia BuscarProductoOfertaDia(string pFecha = "", int pTiendaId = 0, string pCodProducto = "")
        {
            try
            {
                var parameters = new List<SqlParameter>(){
                        new SqlParameter("@fecha", pFecha),
                        new SqlParameter("@codProducto", pCodProducto),
                        new SqlParameter("@tienda", pTiendaId)
                };

                List<BuscarProductoOfertaDia> data = _context.spBuscarProductoOfertaDia
                        .FromSqlRaw("EXEC [dbo].[spBuscarProductoOfertaDia] @fecha=@fecha , @codProducto=@codProducto, @tienda=@tienda",
                        parameters.ToArray()).ToList();

                return (BuscarProductoOfertaDia)data[0];
            }
            catch (Exception ex)
            {
                //var m = ex.Message.ToString();
                //return -1;
                return null;
            }
        }
    }
}
