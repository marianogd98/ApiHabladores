using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class Banco
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool? Estatus { get; set; }
        public int? Codigo { get; set; }
        public string CodigoStellar { get; set; }
    }
}
