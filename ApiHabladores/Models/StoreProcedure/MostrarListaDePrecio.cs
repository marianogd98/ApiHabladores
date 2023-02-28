using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Models.StoreProcedure
{
    public class MostrarListaDePrecio
    {
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public int TiendaId { get; set; }
        public string Tienda { get; set; }
        public string NumeroDocumento { get; set; }
        public string Descripcion { get; set; }
        public int Estatus { get; set; }
        public double Tasa { get; set; }
        public double CantidadArticulos { get; set; }
        public DateTime Create_at { get; set; }
        public DateTime Update_at { get; set; }
        public DateTime? FechaInicioOferta { get; set; }
        public DateTime? FechaFinOferta { get; set; }
        public int Tipo { get; set; }
        public string CodigoArticulo { get; set; }
        public string CodigoAlterno { get; set; }
        public string ProductoDescripcion { get; set; }
        public double Costo { get; set; }
        public double FactorVenta { get; set; }
        public double PVP { get; set; }
        public double CostoAnt { get; set; }
        public double PVPAnt { get; set; }
        public double? PVPOferta { get; set; }
        
            
    }
}
