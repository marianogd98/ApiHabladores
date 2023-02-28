using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class Acceso
    {
        public int Id { get; set; }
        public int MacAdress { get; set; }
        public int Activo { get; set; }
        public int UsuarioId { get; set; }
    }
}
