using ApiHabladores.Models.StoreProcedure;
using System.Collections.Generic;

namespace ApiHabladores.Repositories
{
    public interface IProductosRepository
    {
        public IEnumerable<SpListaProductosOferta> GetProductosEnOferta();

        public IEnumerable<SpListaProdHablador> GetProductosHabladores(int tipo_consulta);

        public SpListaProdHablador GetProductoHablador(string codigo, int tipo_consulta);

        public IEnumerable<SpListaProdHablador> GetProductoHabladorDesc(string descripcion, int tipo_consulta);

        public SpListaProdHablador GetProductoHabladorFarm(string codigo, int tipo_consulta);

        public IEnumerable<SpListaProdHablador> GetProductosHabladoresFarm(int tipo_consulta);
        public IEnumerable<SpListaProdHablador> GetProductoHabladorFarmDesc(string descripcion, int tipo_consulta);

        public IEnumerable<SpListaProdHablador> GetProductosHabladoresAct(int tipo_consulta);

        public SpBuscarProductoHab GetProducto(string codigo);

        public int GuardarDetalleProducto(string CodigoSAP, int FHorizontal, int FVertical, double CapacidadReal,
                                   double CapacidadTeorica, string Orientacion, int CantFrente, string Presentacion,
                                   double Alto, double Ancho, double Profundidad, string Marca, string Proveedor,
                                   double Peso, int CantUnidad, string Familia, string Imagen, int UsuarioId, int Tipo);
    }
}
