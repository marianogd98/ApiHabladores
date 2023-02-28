using ApiHabladores.Dto;
using ApiHabladores.Models.StoreProcedure;
using ApiHabladores.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ApiHabladores.Models.ViewModels;

namespace ApiHabladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductosRepository _productosRepository;
        private readonly IMapper _mapper;

        public ProductosController(IProductosRepository productosRepository , IMapper mapper)
        {
            _productosRepository = productosRepository;
            _mapper = mapper;
        }

        [HttpGet("{codigoProducto}")]
        public IActionResult GetOfertas(string codigoProducto)
        {
            try
            {
                var data = _productosRepository.GetProducto(codigoProducto);

                if (data != null)
                    return Ok(new Response<SpBuscarProductoHab>(data));
                else
                    return BadRequest(new Response<string>($"No existe producto con el codigo/barra indicado."));
                
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("ofertas")]
        public IActionResult GetOfertas()
        {
            try
            {
                var data = _mapper.Map<IEnumerable<OfertasDto>>(_productosRepository.GetProductosEnOferta());

                if (data != null)
                    return Ok(new Response<IEnumerable<OfertasDto>>(data));
                else
                    return BadRequest(new Response<string>($"Al {DateTime.Now.ToString("dd/MM/aaaa")} no hay productos en oferta"));
                
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("habladores")]
        public IActionResult GetHabladores(int tipo_consulta)
        {
            try
            {
                var data = _productosRepository.GetProductosHabladores(tipo_consulta);

                if (data != null)
                    return Ok(new Response<IEnumerable<SpListaProdHablador>>(data));
                else
                    return BadRequest(new Response<string>($"Invalid Response Habladores"));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("hablador/{codigo}")]
        public IActionResult GetHablador(string codigo, int tipo_consulta)
        {
            try
            {
                var data = _productosRepository.GetProductoHablador(codigo, tipo_consulta);

                if (data != null)
                    return Ok(new Response<SpListaProdHablador>(data));
                else
                    return BadRequest(new Response<string>($"Invalid Response Habladores"));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("hablador/descripcion/{descripcion}")]
        public IActionResult GetHabladorDesc(string descripcion, int tipo_consulta)
        {
            try
            {
                var data = _productosRepository.GetProductoHabladorDesc(descripcion, tipo_consulta);

                if (data != null)
                    return Ok(new Response<IEnumerable<SpListaProdHablador>>(data));
                else
                    return BadRequest(new Response<string>($"Invalid Response Habladores"));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("habladores/farmacia")]
        public IActionResult GetHabladoresFarmacia(int tipo_consulta)
        {
            try
            {
                var data = _productosRepository.GetProductosHabladoresFarm(tipo_consulta);

                if (data != null)
                    return Ok(new Response<IEnumerable<SpListaProdHablador>>(data));
                else
                    return BadRequest(new Response<string>($"Invalid Response Habladores"));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("hablador/farmacia/{codigo}")]
        public IActionResult GetHabladorFarmacia(string codigo, int tipo_consulta)
        {
            try
            {
                var data = _productosRepository.GetProductoHabladorFarm(codigo, tipo_consulta);

                if (data != null)
                    return Ok(new Response<SpListaProdHablador>(data));
                else
                    return BadRequest(new Response<string>($"Invalid Response Habladores"));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("hablador/farmacia/descripcion/{descripcion}")]
        public IActionResult GetHabladorFarmDesc(string descripcion, int tipo_consulta)
        {
            try
            {
                var data = _productosRepository.GetProductoHabladorFarmDesc(descripcion, tipo_consulta);

                if (data != null)
                    return Ok(new Response<IEnumerable<SpListaProdHablador>>(data));
                else
                    return BadRequest(new Response<string>($"Invalid Response Habladores"));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("habladores/actualizados")]
        public IActionResult GetHabladoresActualizados(int tipo_consulta)
        {
            try
            {
                var data = _productosRepository.GetProductosHabladoresAct(tipo_consulta);

                if (data != null)
                    return Ok(new Response<IEnumerable<SpListaProdHablador>>(data));
                else
                    return BadRequest(new Response<string>($"Invalid Response Habladores"));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] BodyGuardarDetalleProducto data)
        {

            try
            {
                var guardar = _productosRepository.GuardarDetalleProducto(data.CodigoSAP, data.FHorizontal, data.FVertical, data.CapacidadReal, data.CapacidadTeorica, data.Orientacion, data.CantFrente, data.Presentacion, data.Alto, data.Ancho, data.Profundidad, data.Marca, data.Proveedor, data.Peso, data.CantUnidad, data.Familia, data.Imagen, data.UsuarioId, data.Tipo);

                if (guardar == 1)
                    return Ok(new { data = guardar, message = "Guardado Detalles Producto con exito" });
                else
                    return BadRequest(new { data = guardar, message = "Detalles del Producto no pudieron ser guardados" });

            }
            catch (Exception e)
            {
                return BadRequest();
            }

        }
    }
}
