using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class RolAccion
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public int AccionId { get; set; }

        public virtual Accion Accion { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
