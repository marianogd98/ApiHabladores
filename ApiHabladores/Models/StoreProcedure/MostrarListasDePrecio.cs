using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Models.StoreProcedure
{
    public class MostrarListasDePrecio
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }
        public double CantidadArticulos { get; set; }
        public int Estatus { get; set; }
        public string NumeroDocumento { get; set; }
        public string comprador { get; set; }
        public int tiendaId { get; set; }
        public string tienda { get; set; }
        public DateTime Create_at { get; set; }
        public DateTime? FechaInicioOferta { get; set; }
        public DateTime? FechaFinOferta { get; set; }
        public int Tipo { get; set; }
    }
}
