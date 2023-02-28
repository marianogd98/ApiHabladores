using System;

namespace ApiHabladores.Models.StoreProcedure
{
    public class SpBuscarProductoHab
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Codigo { get; set; }
        public string Barra { get; set; }
        public string Descripcion { get; set; }
        public double PrecioDetal { get; set; }
        public double PrecioDetalBs { get; set; }
        public double PrecioOferta { get; set; }
        public double PrecioOfertaBs { get; set; }
        public double Descuento { get; set; }
        public int Pesado { get; set; }
        public string CodigoMoneda { get; set; }
        public string Impuesto { get; set; }
        public double Valor { get; set; }
        public DateTime FechaOfertaIni { get; set; }
        public DateTime FechaOfertaFin { get; set; }
        public string Departamento { get; set; }
        public string codigoBalanza { get; set; }
        public int Estatus { get; set; }
    }
}
