using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class M64001
    {
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string LicTradNum { get; set; }
        public string CardType { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string PriceList { get; set; }
        public string Email { get; set; }
        public decimal? DescuentoGlobal { get; set; }
        public string CodGrupoSocio { get; set; }
        public string GroupNum { get; set; }
        public string Ciudad { get; set; }
        public string CodPais { get; set; }
        public string Calle { get; set; }
        public string TipoPersona { get; set; }
        public string PaginaWeb { get; set; }
        public decimal? LimiteCredito { get; set; }
        public int IdM64001 { get; set; }
        public bool? Contribuyente { get; set; }
        public bool? SujetoRetencion { get; set; }
        public string CodEstado { get; set; }
        public string DebPayAcct { get; set; }
        public DateTime? CreateUpDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public bool? ValidFor { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool? FrozenFor { get; set; }
        public DateTime? FrozenFrom { get; set; }
        public decimal? Balance { get; set; }
        public string PostalCode { get; set; }
        public string HouseId { get; set; }
        public string CountyName { get; set; }
        public string CityName { get; set; }
        public DateTime? FrozenTo { get; set; }
        public bool? CustomerDefecto { get; set; }
        public decimal? DebtLine { get; set; }
        public decimal? BalanceSys { get; set; }
        public decimal? BalanceFc { get; set; }
        public string AliasName { get; set; }
        public string TypeOfop { get; set; }
        public string CmpPrivate { get; set; }
        public string IndustryC { get; set; }
        public string VatGroup { get; set; }
        public bool? VatStatus { get; set; }
        public bool? ConEspecial { get; set; }
        public string TipoPersonaNw { get; set; }
        public decimal? IntrstRate { get; set; }
        public string SlpCode { get; set; }
        public string CurrencyLimCred { get; set; }
        public string UsoCfdi { get; set; }
    }
}
