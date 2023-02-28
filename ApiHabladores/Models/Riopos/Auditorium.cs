using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class Auditorium
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int? Accion { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
