using System;

namespace ApiHabladores.Dto
{
    public class OfertasDto
    {
        public string codigo { get; set; }
        public string barra { get; set; }
        public string Descri { get; set; }
        public string precio { get; set; }
        public string precioBs { get; set; }
        public double pvpRef { get; set; }
        public double pvpBs { get; set; }
        public double iva { get; set; }
        public DateTime fecha { get; set; }
        //public string id_depa { get; set; }
        public string departamento { get; set; }
        public string precioofertaRef { get; set; }
        public string precioofertaBs { get; set; }
        public DateTime FechaOfertaIni { get; set; }
        public DateTime FechaOfertaFin { get; set; }
        //public int cant { get; set; }
        public string moneda { get; set; }
        public double tasa { get; set; }
    }
}
