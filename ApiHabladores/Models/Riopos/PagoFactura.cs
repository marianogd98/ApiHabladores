using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class PagoFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int FormaPagoId { get; set; }
        public int? BancoadquirienteId { get; set; }
        public string Lote { get; set; }
        public string NumeroTransaccion { get; set; }
        public double Monto { get; set; }
        public string Nombre { get; set; }
        public string TipoTarjeta { get; set; }
        public string NroAutorizacion { get; set; }
        public string Vposdata { get; set; }

        public virtual Factura Factura { get; set; }
        public virtual FormaPago01 FormaPago { get; set; }
    }
}
