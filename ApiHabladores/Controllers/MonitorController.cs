using ApiHabladores.Dto;
using ApiHabladores.Models.Riopos;
using ApiHabladores.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiHabladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitorController : ControllerBase
    {
        private readonly IMonitorRepository _monitorRepo;
        private readonly IMapper _mapper;
        private ProductoMntrDto _monitorDto;
        private MonitorDto _listMonitorDto;
        //NumberFormatInfo _FormatVenezuela;
        public MonitorController(IMonitorRepository monitorRepo, IMapper mapper)
        {
            _monitorRepo = monitorRepo;
            _mapper = mapper;
            _listMonitorDto = new MonitorDto();
            //_FormatVenezuela = new CultureInfo("en-US", false).NumberFormat;
        }
        // GET: api/<MonitorController>
        [HttpGet("charcuteria")]
        public IActionResult Charcuteria()
        {
            try
            {
                List<string> queso1 = new List<string> { "1201021", "1200921" };//costo >0
                List<string> queso2 = new List<string> { "1201002", "1201036", "1200107", "1200803", "1201012" };//costo >0
                List<string> jamon1 = new List<string> { "1200619", "1200112", "1200683", "1201076", "1200512" };//costo >0
                List<string> jamon2 = new List<string> { "1200839", "1200904", "1200113" };//costo >0

                IEnumerable<Producto> dataqueso1 = _monitorRepo.GetProductosMonitor(queso1);
                IEnumerable<Producto> dataqueso2 = _monitorRepo.GetProductosMonitor(queso2);
                IEnumerable<Producto> datajamon1 = _monitorRepo.GetProductosMonitor(jamon1);
                IEnumerable<Producto> datajamon2 = _monitorRepo.GetProductosMonitor(jamon2);

                List<Producto> Queso1 = new List<Producto>();
                List<Producto> Queso2 = new List<Producto>();
                List<Producto> Jamon1 = new List<Producto>();
                List<Producto> Jamon2 = new List<Producto>();

                for (int i = 0; i < dataqueso1.Count(); i++)
                {
                    Queso1.Add(dataqueso1.ElementAt(i));
                }

                for (int i = 0; i < dataqueso2.Count(); i++)
                {
                    Queso2.Add(dataqueso2.ElementAt(i));
                }

                for (int i = 0; i < datajamon1.Count(); i++)
                {
                    Jamon1.Add(datajamon1.ElementAt(i));
                }

                for (int i = 0; i < datajamon2.Count(); i++)
                {
                    Jamon2.Add(datajamon2.ElementAt(i));
                }

                object DataPantalla = new
                {
                    Slug = "Charcutería",
                    Moneda = "Ref.",
                    Imagen = "charcuteria-1.png",
                    Productos = new
                    {
                        P1 = Queso1,
                        P2 = Queso2,
                        P3 = Jamon1,
                        P4 = Jamon2
                    }
                };

                if (dataqueso1 != null)
                    return Ok(new Response<object>(DataPantalla));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("carniceria")]
        public IActionResult Carniceria()
        {
            try
            {
                List<string> productos = new List<string> { "1000256", "1000235", "1000259", "1000234", "1000080", "1000251", "1000230", "1000225", "1000083", "1000253", "1000252", "1000237", "1000231", "1000120" };//costo >0

                var datas = _monitorRepo.GetProductosMonitor(productos).ToList();

                Producto data = datas.Where(p => p.CodigoProducto.Contains("015718")).FirstOrDefault();
                var dataCarniceria = new List<Producto>();

                Producto producto = new Producto { Id = data.Id, CodigoProducto = data.CodigoProducto, Descripcion = "Pulpa Negra", PrecioDetal = data.PrecioDetal, FechaOfertaFin = data.FechaOfertaFin, CodigoMoneda = data.CodigoMoneda, Valor = data.Valor, Tasa = data.Tasa };
                dataCarniceria.Add(producto);
                producto = new Producto { Id = data.Id, CodigoProducto = data.CodigoProducto, Descripcion = "Chocozuela", PrecioDetal = data.PrecioDetal, FechaOfertaFin = data.FechaOfertaFin, CodigoMoneda = data.CodigoMoneda, Valor = data.Valor, Tasa = data.Tasa };
                dataCarniceria.Add(producto);
                producto = new Producto { Id = data.Id, CodigoProducto = data.CodigoProducto, Descripcion = "Ganzo", PrecioDetal = data.PrecioDetal, FechaOfertaFin = data.FechaOfertaFin, CodigoMoneda = data.CodigoMoneda, Valor = data.Valor, Tasa = data.Tasa };
                dataCarniceria.Add(producto);
                producto = new Producto { Id = data.Id, CodigoProducto = data.CodigoProducto, Descripcion = "Muchacho Redondo", PrecioDetal = data.PrecioDetal, FechaOfertaFin = data.FechaOfertaFin, CodigoMoneda = data.CodigoMoneda, Valor = data.Valor, Tasa = data.Tasa };
                dataCarniceria.Add(producto);
                producto = new Producto { Id = data.Id, CodigoProducto = data.CodigoProducto, Descripcion = "Muchacho Cuadrado", PrecioDetal = data.PrecioDetal, FechaOfertaFin = data.FechaOfertaFin, CodigoMoneda = data.CodigoMoneda, Valor = data.Valor, Tasa = data.Tasa };
                dataCarniceria.Add(producto);
                var dataCarniceria2 = new List<Producto>();
                var dataCarniceria3 = new List<Producto>();
                var mydata = datas.Where(p => !p.CodigoProducto.Contains("1000256")).ToList();

                for (int i = 0; i < mydata.Count(); i++)
                {
                    if (i < 7)
                    {
                        dataCarniceria2.Add(mydata.ElementAt(i));
                    }
                    else
                    {
                        dataCarniceria3.Add(mydata.ElementAt(i));
                    }
                }
                object DataPantalla = new
                {
                    Slug = "Carnicería",
                    Moneda = "Ref.",
                    Imagen = "carniceria-1.png",
                    Productos = new
                    {
                        P1 = dataCarniceria,
                        P2 = dataCarniceria2,
                        P3 = dataCarniceria3
                    }
                };

                //_monitorDto = new ProductoMntrDto("Carnicería", "carniceria", DataPantalla);

                if (data != null)
                    return Ok(new Response<object>(DataPantalla));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("carniceria/pollo")]
        public IActionResult CarniceriaPollo()
        {
            try
            {
                List<string> productos = new List<string> { "1000182", "1000179", "1000147", "1000130", "1000180", "1000071", "1000203", "1000146", "1000219", "1000214", "1000181", "1000218", "1000144", "1000082", "1000263", "1000220" };//costo >0

                var data = _monitorRepo.GetProductosMonitor(productos).ToList();
                var dataCarniceria = new List<Producto>();
                var dataCarniceria2 = new List<Producto>();
                var dataCarniceria3 = new List<Producto>();
                var dataCarniceria4 = new List<Producto>();

                for (int i = 0; i < data.Count(); i++)
                {
                    if (i < 6)
                    {
                        dataCarniceria.Add(data.ElementAt(i));
                    }
                    if (i >= 6 && i < 11)
                    {
                        dataCarniceria2.Add(data.ElementAt(i));
                    }
                    if (i >= 11 && i < 16)
                    {
                        dataCarniceria3.Add(data.ElementAt(i));
                    }
                    if (i >= 16)
                    {
                        dataCarniceria4.Add(data.ElementAt(i));
                    }
                }
                object DataPantalla = new
                {
                    Slug = "Carnicería",
                    Moneda = "Ref.",
                    Imagen = "pollo.png",
                    Productos = new
                    {
                        P1 = dataCarniceria,
                        P2 = dataCarniceria2,
                        P3 = dataCarniceria3,
                        P4 = dataCarniceria4
                    }
                };

                //_monitorDto = new ProductoMntrDto("Carnicería", "carniceria", DataPantalla);

                if (data != null)
                    return Ok(new Response<object>(DataPantalla));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("carniceria/cerdo")]
        public IActionResult CarniceriaCerdo()
        {
            try
            {
                List<string> productos = new List<string> { "1000212", "1000057", "1000197", "1000187", "1000199", "1000198", "1000211", "1000183", "1000201", "1000208" };//costo >0

                var data = _monitorRepo.GetProductosMonitor(productos).ToList();
                var dataCarniceria = new List<Producto>();
                var dataCarniceria2 = new List<Producto>();

                for (int i = 0; i < data.Count(); i++)
                {
                    if (i < 6)
                    {
                        data.ElementAt(i).PrecioDetal = Math.Round(data.ElementAt(i).PrecioDetal, 2);
                        dataCarniceria.Add(data.ElementAt(i));
                    }
                    if (i >= 6 && i < 11)
                    {
                        data.ElementAt(i).PrecioDetal = Math.Round(data.ElementAt(i).PrecioDetal, 2);
                        dataCarniceria2.Add(data.ElementAt(i));
                    }
                }
                object DataPantalla = new
                {
                    Slug = "Carnicería",
                    Moneda = "Ref.",
                    Imagen = "cerdo.png",
                    Productos = new
                    {
                        P1 = dataCarniceria,
                        P2 = dataCarniceria2
                    }
                };

                //_monitorDto = new ProductoMntrDto("Carnicería", "carniceria", DataPantalla);

                if (data != null)
                    return Ok(new Response<object>(DataPantalla));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("empanada")]
        public IActionResult Empanada()
        {
            try
            {
                List<string> productos = new List<string> { "046897", "046896", "046895", "047137" };//costo >0

                var data = _monitorRepo.GetProductosMonitor(productos);
                _monitorDto = new ProductoMntrDto("Empanadas", "empanadas", data);

                if (data != null)
                    return Ok(new Response<ProductoMntrDto>(_monitorDto));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("riopollo")]
        public IActionResult Riopollo()
        {
            try
            {
                List<string> productos = new List<string> { "028177", "028178", "028414", "033785", "037376", "037377", "037722", "028864", "044382" };

                var data = _monitorRepo.GetProductosMonitor(productos).ToList();
                var dataPollo = new List<Producto>();
                var dataPollo2 = new List<Producto>();

                for (int i = 0; i < data.Count(); i++)
                {
                    if (i < 3)
                    {
                        data.ElementAt(i).PrecioDetal = Math.Round(data.ElementAt(i).PrecioDetal, 2);
                        if(data.ElementAt(i).CodigoProducto == "028414")
                        {
                            data.ElementAt(i).CodigoMoneda = "Con guasacaca";
                        }
                        else
                        {
                            data.ElementAt(i).CodigoMoneda = "Con guasacaca, ración de arepitas y ensalada";
                        }
                        dataPollo.Add(data.ElementAt(i));
                    }
                    if (i >= 3 && i < 8)
                    {
                        data.ElementAt(i).PrecioDetal = Math.Round(data.ElementAt(i).PrecioDetal, 2);
                        dataPollo2.Add(data.ElementAt(i));
                    }
                }
                object DataPantalla = new
                {
                    Slug = "Pollo Asado",
                    Moneda = "Ref.",
                    Imagen = "pollo-asado-1.png",
                    Productos = new
                    {
                        P1 = dataPollo,
                        P2 = dataPollo2
                    }
                };

                if (data != null)
                    return Ok(new Response<object>(DataPantalla));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("panaderia")]
        public IActionResult Panaderia()
        {
            try
            {
                List<string> productos = new List<string> { "0900721", "0900726", "0900731", "0900604", "0900608", "0900607", "0900606", "0900645" };//costo >0 "0900399", "0900243", "0900230", "0900397", "0900393", "0900402", "0900401", "0900400", "0900380"

                var data = _monitorRepo.GetProductosMonitor(productos).ToList();
                var dataPanaderia = new List<Producto>();
                var dataPanaderia2 = new List<Producto>();

                for (int i = 0; i < data.Count(); i++)
                {
                    if (i < 4)
                    {
                        data.ElementAt(i).PrecioDetal = Math.Round(data.ElementAt(i).PrecioDetal, 2);
                        dataPanaderia.Add(data.ElementAt(i));
                    }
                    if (i >= 4 && i < 8)
                    {
                        data.ElementAt(i).PrecioDetal = Math.Round(data.ElementAt(i).PrecioDetal, 2);
                        dataPanaderia2.Add(data.ElementAt(i));
                    }
                }
                object DataPantalla = new
                {
                    Slug = "Panadería",
                    Moneda = "Ref.",
                    Imagen = "panaderia-1.png",
                    Productos = new
                    {
                        P1 = dataPanaderia,
                        P2 = dataPanaderia2
                    }
                };

                //_monitorDto = new ProductoMntrDto("Carnicería", "carniceria", DataPantalla);

                if (data != null)
                    return Ok(new Response<object>(DataPantalla));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("rio/gourmet")]
        public IActionResult RioGourmet()
        {
            try
            {
                List<string> waffles = new List<string> { "036983", "036984", "036985", "036986", "036987", "036988", "036989", "036990", "036991" }; /*<- waffles*/
                List<string> crepes = new List<string> { "036992", "036993", "036994", "036995", "036996", "036997", "036998", "036999", "037000", "037001" };/*<-crepes 18*/
                List<string> panqueca = new List<string> { "037002", "037003", "037004", "037005", "037006", "037007" };/*<-panqueca 24*/
                List<string> sandwich = new List<string> { "037009", "037013", "037014", "037015", "037018", "044019", "037019" }; /*<-Sandwich 31*/
                List<string> ensalada = new List<string> { "037035", "037037", "037038", "037039", "037040", "037041", "037193" }; /*<-Ensalada 38*/
                List<string> jugos1 = new List<string> { "037042", "037043", "037044", "037045", "037046", "037048", "037088", "037089", "037384", "037394", "037386" };/*<-Jugos y merengadas 71*/
                List<string> jugos2 = new List<string> { "037050", "037385", "038304", "038305", "037083", "037084", "037085", "037086", "041327", "037092" }; /*<- Jugos 2 74*/
                List<string> jugos3 = new List<string> { "037076", "037077", "037078", "037079", "037080" }; /*<- Jugos 3 74*/
                List<string> smooties = new List<string> { "037382", "037090", "037091", "038306", "037095", "037051" }; /*<- Jugos 3 74*/
                List<string> etc = new List<string> { "037096", "037097", "037098" }; /*<- Vainasraras 74*/
                List<string> extra = new List<string> { "037198", "037967", "037199", "037200", "037201", "037202", "037203", "037204", "041328" };/*Extras 83*/
                List<string> salsas = new List<string> { "041342", "041343", "041344", "041345", "041341" };/*<-Salsas 88*/
                List<string> carpacio = new List<string> { "037194" }; /*<-carpacio 89*/
                List<string> yogourt = new List<string> { "037355", "037691" };/*<yogourt 91*/

                IEnumerable<Producto> datawaffle = _monitorRepo.GetProductosMonitor(waffles);
                IEnumerable<Producto> datacrepe = _monitorRepo.GetProductosMonitor(crepes);
                IEnumerable<Producto> datapanqueca = _monitorRepo.GetProductosMonitor(panqueca);
                IEnumerable<Producto> datasandwich = _monitorRepo.GetProductosMonitor(sandwich);
                IEnumerable<Producto> dataensalada = _monitorRepo.GetProductosMonitor(ensalada);
                IEnumerable<Producto> datajugos1 = _monitorRepo.GetProductosMonitor(jugos1);
                IEnumerable<Producto> datajugos2 = _monitorRepo.GetProductosMonitor(jugos2);
                IEnumerable<Producto> datajugos3 = _monitorRepo.GetProductosMonitor(jugos3);
                IEnumerable<Producto> datasmooties = _monitorRepo.GetProductosMonitor(smooties);
                IEnumerable<Producto> dataetc = _monitorRepo.GetProductosMonitor(etc);
                IEnumerable<Producto> datasalsas = _monitorRepo.GetProductosMonitor(salsas);
                IEnumerable<Producto> dataextra = _monitorRepo.GetProductosMonitor(extra);
                IEnumerable<Producto> datacarpacio = _monitorRepo.GetProductosMonitor(carpacio);
                IEnumerable<Producto> datayogourt = _monitorRepo.GetProductosMonitor(yogourt);


                List<Producto> Waffles = new List<Producto>();
                List<Producto> Crepes = new List<Producto>();
                List<Producto> Panqueca = new List<Producto>();
                List<Producto> Sandwich = new List<Producto>();
                List<Producto> Ensalada = new List<Producto>();
                List<Producto> Jugos1 = new List<Producto>();
                List<Producto> Jugos2 = new List<Producto>();
                List<Producto> Jugos3 = new List<Producto>();
                List<Producto> Smooties = new List<Producto>();
                List<Producto> Vainasraras = new List<Producto>();
                List<Producto> Extras = new List<Producto>();
                List<Producto> Salsas = new List<Producto>();
                List<Producto> Carpacio = new List<Producto>();
                List<Producto> Yogourt = new List<Producto>();

                for (int i = 0; i < datawaffle.Count(); i++)
                {
                    Waffles.Add(datawaffle.ElementAt(i));
                }

                for (int i = 0; i < datacrepe.Count(); i++)
                {
                    Crepes.Add(datacrepe.ElementAt(i));
                }

                for (int i = 0; i < datapanqueca.Count(); i++)
                {
                    Panqueca.Add(datapanqueca.ElementAt(i));
                }

                for (int i = 0; i < datasandwich.Count(); i++)
                {
                    Sandwich.Add(datasandwich.ElementAt(i));
                }

                for (int i = 0; i < dataensalada.Count(); i++)
                {
                    Ensalada.Add(dataensalada.ElementAt(i));
                }

                for (int i = 0; i < datajugos1.Count(); i++)
                {
                    Jugos1.Add(datajugos1.ElementAt(i));
                }

                for (int i = 0; i < datajugos2.Count(); i++)
                {
                    Jugos2.Add(datajugos2.ElementAt(i));
                }

                for (int i = 0; i < datajugos3.Count(); i++)
                {
                    Jugos3.Add(datajugos3.ElementAt(i));
                }

                for (int i = 0; i < datasmooties.Count(); i++)
                {
                    Smooties.Add(datasmooties.ElementAt(i));
                }

                for (int i = 0; i < dataetc.Count(); i++)
                {
                    Vainasraras.Add(dataetc.ElementAt(i));
                }

                for (int i = 0; i < dataextra.Count(); i++)
                {
                    Extras.Add(dataextra.ElementAt(i));
                }

                for (int i = 0; i < datasalsas.Count(); i++)
                {
                    Salsas.Add(datasalsas.ElementAt(i));
                }

                for (int i = 0; i < datacarpacio.Count(); i++)
                {
                    Carpacio.Add(datacarpacio.ElementAt(i));
                }

                for (int i = 0; i < datayogourt.Count(); i++)
                {
                    Yogourt.Add(datayogourt.ElementAt(i));
                }

                object Data = new
                {
                    Slug = "",
                    Moneda = "Ref.",
                    Productos = new
                    {
                        Waffles = new { W1 = Waffles.Take(5), w2 = Waffles.TakeLast(4) },
                        Crepes = new { C1 = Crepes.Take(5), C2 = Crepes.TakeLast(4) },
                        Panqueca = Panqueca,
                        Sandwich = new { S1 = Sandwich.Take(5), S2 = Sandwich.TakeLast(4) },
                        Ensalada = new { E1 = Ensalada.Take(4), E2 = Ensalada.TakeLast(3) },
                        Jugos1 = new { J1 = Jugos1.Take(5), J2 = Jugos1.TakeLast(6) },
                        Jugos2 = new { J3 = Jugos2.Take(5), J4 = Jugos2.TakeLast(5) },
                        Jugos3 = Jugos3,
                        Smooties = Smooties,
                        Vainasraras = Vainasraras,
                        Extras = new { Ex1 = Extras.Take(4), Ex2 = Extras.TakeLast(5) },
                        Salsas = Salsas,
                        Carpacio = Carpacio,
                        Yogourt = Yogourt
                    }
                };

                //List<Producto> mil = new List<Producto>();
                // _listMonitorDto.ProductosMntrDtos = new List<ProductoMntrDto>();

                if (datawaffle != null)
                    return Ok(new Response<object>(Data));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("rio/menu")]
        public IActionResult RioMenu()
        {
            try
            {
                List<string> productos = new List<string> { "1600162", "1600186", "1600162", "1600159", "1600160", "1600157", "1600158", "1600163", "1600182", "1600181", "1600183", "1600184", "1600185", "1600187", "1600189", "1600192", "1600190", "1600191", "1600188" };//camnbiar productos

                IEnumerable<Producto> data = _monitorRepo.GetProductosMonitor(productos);

                List<Producto> Suave = new List<Producto>();
                List<Producto> Fuertes = new List<Producto>();
                List<Producto> Ensalada = new List<Producto>();

                for (int i = 0; i < data.Count(); i++)
                {
                    if (i < 7)
                    {
                        Suave.Add(data.ElementAt(i));
                    }
                    if (i > 6 && i <= 12)
                    {
                        Fuertes.Add(data.ElementAt(i));
                    }
                    if (i > 12 && i <= 19)
                    {
                        Ensalada.Add(data.ElementAt(i));
                    }

                }
                object Data = new
                {
                    Slug = "",
                    Moneda = "Ref.",
                    Imagen = "rio-menu-fondo.png",
                    Productos = new
                    {
                        Suave = Suave,
                        Fuertes = Fuertes,
                        Ensalada = Ensalada
                    }
                };

                if (data != null)
                    return Ok(new Response<object>(Data));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

    }
}
