using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class FormaPago01
    {
        public FormaPago01()
        {
            PagoFacturas = new HashSet<PagoFactura>();
        }

        public int Id { get; set; }
        public string CodigoMoneda { get; set; }
        public string Descripcion { get; set; }
        public string Telefono { get; set; }
        public string CorreoZelle { get; set; }
        public int Orden { get; set; }

        public virtual ICollection<PagoFactura> PagoFacturas { get; set; }
    }
}
