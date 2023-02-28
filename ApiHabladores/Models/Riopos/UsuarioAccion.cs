using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class UsuarioAccion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int AccionId { get; set; }

        public virtual Accion Accion { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
