using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class Tiendum
    {
        public int Id { get; set; }
        public string CodigoTienda { get; set; }
        public string CodigoArea { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Urlapi { get; set; }
        public double Tasa { get; set; }
        public double DescuentoMax { get; set; }
        public double? Margen { get; set; }
        public int? AplicaIva { get; set; }
    }
}
