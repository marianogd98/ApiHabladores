using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class FormaPago
    {
        public int Id { get; set; }
        public string CodigoMoneda { get; set; }
        public string Descripcion { get; set; }
        public double? Factor { get; set; }
        public string CorreoZelle { get; set; }
        public int Orden { get; set; }
    }
}
