using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class CodigoBarra
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string CodigoBarra1 { get; set; }
        public int? Activo { get; set; }
        public int? Predeterminado { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
