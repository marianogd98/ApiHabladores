using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class Preguntas01
    {
        public int Id { get; set; }
        public int? Nivel { get; set; }
        public string PreguntaRespuesta { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
