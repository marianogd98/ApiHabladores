using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class ConfigBoton
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public string Imagen { get; set; }
        public int ProductoId { get; set; }

        public virtual Area Area { get; set; }
    }
}
