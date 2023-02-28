using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class Turno
    {
        public Turno()
        {
            Devolucions = new HashSet<Devolucion>();
            Donacions = new HashSet<Donacion>();
            Facturas = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CajaId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public int Estatus { get; set; }

        public virtual Caja Caja { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Arqueo Arqueo { get; set; }
        public virtual ICollection<Devolucion> Devolucions { get; set; }
        public virtual ICollection<Donacion> Donacions { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
