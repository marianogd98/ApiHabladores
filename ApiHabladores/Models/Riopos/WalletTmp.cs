using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class WalletTmp
    {
        public int? Id { get; set; }
        public long IdwalletTienda { get; set; }
        public int? ClienteId { get; set; }
        public decimal Saldo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? IdWallet { get; set; }
    }
}
