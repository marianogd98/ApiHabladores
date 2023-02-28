using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Models.ViewModels
{
    public class BodyGuardarDetalleProducto
    {
        public string CodigoSAP { get; set; }
        public int FHorizontal { get; set; }
        public int FVertical { get; set; }
        public double CapacidadReal { get; set; }
        public double CapacidadTeorica { get; set; }
        public string Orientacion { get; set; }
        public int CantFrente { get; set; }
        public string Presentacion { get; set; }
        public double Alto { get; set; }
        public double Ancho { get; set; }
        public double Profundidad { get; set; }
        public string Marca { get; set; }
        public string Proveedor { get; set; }
        public double Peso { get; set; }
        public int CantUnidad { get; set; }
        public string Familia { get; set; }
        public string Imagen { get; set; }
        public int UsuarioId { get; set; }
        public int Tipo { get; set; }
    }
}
