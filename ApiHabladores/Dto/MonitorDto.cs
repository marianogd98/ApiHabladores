using ApiHabladores.Models.Riopos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Dto
{
    public class ProductoMntrDto
    {
        public ProductoMntrDto(string slug,string Area ,IEnumerable<Producto> productos)
        {
            Moneda = "Ref.";
            Imagen = Area + "-1.png";
            Slug = slug;
            Productos = productos;
        }

        public string Moneda { get; set; }
        public string Imagen { get; set; }
        public string Slug { get; set; }
        public IEnumerable<Producto> Productos { get; set; }
    }

    public class MonitorDto
    {
        public List<ProductoMntrDto> ProductosMntrDtos { get; set; }
    }

    /* data = "{"+
                  "\"imagen\":\"charcuteria-1.png\"," +
                  "\"slug\": \"Charcuteria\","+
                  "\"productos\": ["+
                   "{"+
                      "\"producto\":\"Mi Queso\","+
                      "\"marca\": \"El Z\"," +
                      "\"precio\": 20," +
                      "\"PrecioOferta\": 10" +
                    "}," +
                    "{"+
                      "\"producto\":\"PECHUGA DE PAVO\","+
                      "\"marca\": \"MILLENIUM\","+
                      "\"precio\": 9,"+
                      "\"PrecioOferta\": 7" +
                    "}," +
                    "{"+                             
                      "\"producto\":\"SALCHICHON MILANO\","+
                      "\"marca\": \"ITALGUARICO\","+
                      "\"precio\": 6,"+
                      "\"PrecioOferta\": 0" +
                    "}," +
                    "{"+
                      "\"producto\":\"PEPPERONI\","+
                      "\"marca\": \"RICCI\","+
                      "\"precio\": 30"+
                    "}"+
                  "] }";*/

}
