using ApiHabladores.Models.Riopos;
using System.Collections.Generic;

namespace ApiHabladores.Repositories
{
    public interface IMonitorRepository
    {
        IEnumerable<Producto> GetProductosMonitor(List<string> Propductos);
    }
}