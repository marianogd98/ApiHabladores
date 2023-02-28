using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class ListaPrecioDetalle
    {
        public int Id { get; set; }
        public int ListaPrecioId { get; set; }
        public string CodigoArticulo { get; set; }
        public string CodigoAlterno { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double FactorVenta { get; set; }
        public double Pvp { get; set; }
        public double CostoAnt { get; set; }
        public double Pvpant { get; set; }
        public double? Pvpoferta { get; set; }

        public virtual ListaPrecio ListaPrecio { get; set; }
    }
}
