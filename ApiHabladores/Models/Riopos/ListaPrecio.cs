using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class ListaPrecio
    {
        public ListaPrecio()
        {
            ListaPrecioDetalles = new HashSet<ListaPrecioDetalle>();
        }

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int TiendaId { get; set; }
        public string NumeroDocumento { get; set; }
        public string Descripcion { get; set; }
        public int Estatus { get; set; }
        public int UsuarioIdUpdate { get; set; }
        public double Tasa { get; set; }
        public double CantidadArticulos { get; set; }
        public string Observacion { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime? FechaInicioOferta { get; set; }
        public DateTime? FechaFinOferta { get; set; }
        public int? Tipo { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<ListaPrecioDetalle> ListaPrecioDetalles { get; set; }
    }
}
