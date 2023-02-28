using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class MovimientoWallet01
    {
        public int Id { get; set; }
        public int WalletId { get; set; }
        public int Tipo { get; set; }
        public decimal Monto { get; set; }
        public int CajeraId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TiendaId { get; set; }
    }
}
