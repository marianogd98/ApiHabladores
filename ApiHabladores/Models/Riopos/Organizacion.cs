using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class Organizacion
    {
        public Organizacion()
        {
            Donacions = new HashSet<Donacion>();
        }

        public int Id { get; set; }
        public string Rif { get; set; }
        public string Nombre { get; set; }
        public string Motivo { get; set; }
        public bool? Estatus { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Donacion> Donacions { get; set; }
    }
}
