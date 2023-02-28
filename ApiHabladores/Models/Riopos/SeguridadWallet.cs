using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class SeguridadWallet
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime LastLoggins { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
