using ApiHabladores.Models;
using ApiHabladores.Models.Riopos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Repositories
{
    public class MonitorRepository : IMonitorRepository
    {
        private readonly RIOPOSContext _context;
        public MonitorRepository(RIOPOSContext context)
        {
            _context = context;
        }

        public IEnumerable<Producto> GetProductosMonitor(List<string> Productos)
        {
            try
            {
                var data = (from p in _context.Productos
                            join i in _context.Impuestos
                            on p.ImpuestoId equals i.Id
                            from t in _context.Tienda.Where(x => x.Id > 0)
                            where p.Estatus == true && (Productos.Contains(p.CodigoSap) || Productos.Contains(p.CodigoProducto))
                            select new Producto() { Id = p.Id, CodigoProducto = p.CodigoProducto, Descripcion = p.Descripcion, PrecioDetal = p.PrecioDetal, FechaOfertaFin = p.FechaOfertaFin, CodigoMoneda = p.CodigoMoneda, ImpuestoId = p.ImpuestoId, CodigoSap = p.CodigoSap, Valor = i.Valor, Tasa = t.Tasa }).ToList();
                return data;
            }
            catch (Exception ex)
            {
                var m = ex.Message;
                return null;
            }
        }
    }
}
