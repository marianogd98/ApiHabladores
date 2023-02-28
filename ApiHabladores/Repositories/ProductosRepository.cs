using Newtonsoft.Json;
using ApiHabladores.Models;
using ApiHabladores.Models.StoreProcedure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Data.Odbc;
using System.Globalization;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiHabladores.Repositories
{
    public class ProductosRepository : RIOPOSContext, IProductosRepository
    {
        private readonly RIOPOSContext _context;
        public ProductosRepository(RIOPOSContext context)
        {
            _context = context;
        }
        public SpBuscarProductoHab GetProducto(string codigo)
        {
            try
            {
                var parametro = new List<SqlParameter>()
                    {
                        new SqlParameter("@barra", codigo)
                    };
                List<SpBuscarProductoHab> data = this.SpBuscarProductoHab
                    .FromSqlRaw("EXEC [dbo].[BuscarProductoHab] @barra = @barra", parametro.ToArray()).ToList();

                return data[0];

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<SpListaProductosOferta> GetProductosEnOferta()
        {
            try
            {
                List<SpListaProductosOferta> data = this.spListaProductosOferta
                    .FromSqlRaw("EXEC [dbo].[lista_prod_oferta]").ToList();

                return data;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<SpListaProdHablador> GetProductosHabladores(int tipo_consulta)
        {
            try
            {
                var parametro = new List<SqlParameter>()
                {
                    new SqlParameter("@i", tipo_consulta)
                };
                List<SpListaProdHablador> data = this.SpListProdHab
                    .FromSqlRaw("EXEC [dbo].[lista_prod] @i=@i", parametro.ToArray()).ToList();

                return data.GetRange(0, 50);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public SpListaProdHablador GetProductoHablador(string codigo, int tipo_consulta)
        {
            try
            {
                var parametro = new List<SqlParameter>()
                {
                    new SqlParameter("@codigo", codigo),
                    new SqlParameter("@i", tipo_consulta)
                };
                List<SpListaProdHablador> data = this.SpListProdHab
                    .FromSqlRaw("EXEC [dbo].[lista_prod] @codigo=@codigo, @i=@i", parametro.ToArray()).ToList();

                return data[0];

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<SpListaProdHablador> GetProductoHabladorDesc(string descripcion, int tipo_consulta)
        {
            try
            {
                var parametro = new List<SqlParameter>()
                {
                    new SqlParameter("@desc", descripcion),
                    new SqlParameter("@i", tipo_consulta)
                };
                List<SpListaProdHablador> data = this.SpListProdHab
                    .FromSqlRaw("EXEC [dbo].[lista_prod] @desc=@desc, @i=@i", parametro.ToArray()).ToList();

                return data.GetRange(0, 50);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<SpListaProdHablador> GetProductosHabladoresFarm(int tipo_consulta)
        {
            try
            {
                var parametro = new List<SqlParameter>()
                {
                    new SqlParameter("@i", tipo_consulta)
                };
                List<SpListaProdHablador> data = this.SpListProdHab
                    .FromSqlRaw("EXEC [dbo].[lista_prod_farmacia] @i=@i", parametro.ToArray()).ToList();

                return data.GetRange(0, 50);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public SpListaProdHablador GetProductoHabladorFarm(string codigo, int tipo_consulta)
        {
            try
            {
                var parametro = new List<SqlParameter>()
                {
                    new SqlParameter("@codigo", codigo),
                    new SqlParameter("@i", tipo_consulta)
                };
                List<SpListaProdHablador> data = this.SpListProdHab
                    .FromSqlRaw("EXEC [dbo].[lista_prod_farmacia] @codigo=@codigo, @i=@i", parametro.ToArray()).ToList();

                return data[0];

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<SpListaProdHablador> GetProductoHabladorFarmDesc(string descripcion, int tipo_consulta)
        {
            try
            {
                var parametro = new List<SqlParameter>()
                {
                    new SqlParameter("@desc", descripcion),
                    new SqlParameter("@i", tipo_consulta)
                };
                List<SpListaProdHablador> data = this.SpListProdHab
                    .FromSqlRaw("EXEC [dbo].[lista_prod_farmacia] @desc=@desc, @i=@i", parametro.ToArray()).ToList();

                return data.GetRange(0, 50);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<SpListaProdHablador> GetProductosHabladoresAct(int tipo_consulta)
        {
            try
            {
                var parametro = new List<SqlParameter>()
                {
                    new SqlParameter("@i", tipo_consulta)
                };
                List<SpListaProdHablador> data = this.SpListProdHab
                    .FromSqlRaw("EXEC [dbo].[lista_prod_updated] @i=@i", parametro.ToArray()).ToList();

                return data;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public int GuardarDetalleProducto(string CodigoSAP, int FHorizontal, int FVertical, double CapacidadReal,
                                   double CapacidadTeorica, string Orientacion, int CantFrente, string Presentacion,
                                   double Alto, double Ancho, double Profundidad, string Marca, string Proveedor,
                                   double Peso, int CantUnidad, string Familia, string Imagen, int UsuarioId, int Tipo)
        {
            try
            {
                var parametro = new List<SqlParameter>()
                {
                    new SqlParameter("@CodigoSAP", CodigoSAP),
                    new SqlParameter("@FHorizontal", FHorizontal),
                    new SqlParameter("@FVertical", FVertical),
                    new SqlParameter("@CapacidadReal", CapacidadReal),
                    new SqlParameter("@CapacidadTeorica", CapacidadTeorica),
                    new SqlParameter("@Orientacion", Orientacion),
                    new SqlParameter("@CantFrente", CantFrente),
                    new SqlParameter("@Presentacion", Presentacion),
                    new SqlParameter("@Alto", Alto),
                    new SqlParameter("@Ancho", Ancho),
                    new SqlParameter("@Profundidad", Profundidad),
                    new SqlParameter("@Marca", Marca),
                    new SqlParameter("@Proveedor", Proveedor),
                    new SqlParameter("@Peso", Peso),
                    new SqlParameter("@CantUnidad", CantUnidad),
                    new SqlParameter("@Familia", Familia),
                    new SqlParameter("@Imagen", Imagen),
                    new SqlParameter("@UsuarioId", UsuarioId),
                    new SqlParameter("@Tipo", Tipo),
                };

                List<SaveDetalleProducto> data = _context.GuardarDetalleProducto
                    .FromSqlRaw("EXEC [dbo].[GuardarDetalleProducto] @CodigoSAP=@CodigoSAP, @FHorizontal=@FHorizontal, @FVertical=@FVertical, @CapacidadReal=@CapacidadReal, @CapacidadTeorica=@CapacidadTeorica, @Orientacion=@Orientacion, @CantFrente=@CantFrente, @Presentacion=@Presentacion, @Alto=@Alto, " +
                    "@Ancho=@Ancho, @Profundidad=@Profundidad, @Marca=@Marca, @Proveedor=@Proveedor, @Peso=@Peso, @CantUnidad=@CantUnidad, @Familia=@Familia, @Imagen=@Imagen, @UsuarioId=@UsuarioId, @Tipo=@Tipo", parametro.ToArray()).ToList();

                return (int)data[0].r;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
