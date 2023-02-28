using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class Producto
    {
        public Producto()
        {
            CodigoBarras = new HashSet<CodigoBarra>();
            ComboProductos = new HashSet<ComboProducto>();
        }

        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoSubgrupo { get; set; }
        public string CodigoTipo { get; set; }
        public string CodigoBalanza { get; set; }
        public bool Pesado { get; set; }
        public bool ManejaSerial { get; set; }
        public bool Regulado { get; set; }
        public string Descripcion { get; set; }
        public bool Estatus { get; set; }
        public double Costo { get; set; }
        public double PrecioDetal { get; set; }
        public double PrecioMayor { get; set; }
        public double PrecioOferta { get; set; }
        public bool ActivoVenta { get; set; }
        public int? CantidadAplicaDescuento { get; set; }
        public DateTime? FechaOfertaIni { get; set; }
        public double? Descuento { get; set; }
        public DateTime? FechaOfertaFin { get; set; }
        public int Punto { get; set; }
        public string CodigoMoneda { get; set; }
        public double Existencia { get; set; }
        public string CodigoSap { get; set; }
        public int? DepartamentoId { get; set; }
        public string CodigoGrupo { get; set; }
        public int? ImpuestoId { get; set; }
        public double Valor { get; set; }
        public double Tasa { get; set; }

        public virtual ICollection<CodigoBarra> CodigoBarras { get; set; }
        public virtual ICollection<ComboProducto> ComboProductos { get; set; }
    }
}
