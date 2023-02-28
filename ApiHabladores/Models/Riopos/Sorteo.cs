using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class Sorteo
    {
        public int Id { get; set; }
        public int NivelId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string Pregunta { get; set; }
    }
}
