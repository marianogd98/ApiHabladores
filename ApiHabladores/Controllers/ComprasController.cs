using ApiHabladores.Dto;
using ApiHabladores.Models.Riopos;
using ApiHabladores.Models.StoreProcedure;
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
using System.Xml;
using X.PagedList;


//using ExcelDataReader;
using ClosedXML.Excel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiHabladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private readonly IComprasRepository _comprasRepo;
        private readonly IMapper _mapper;
        NumberFormatInfo _FormatVenezuela;
        public ComprasController(IComprasRepository comprasRepo , IMapper mapper)
        {
            _comprasRepo = comprasRepo;
            _mapper = mapper;
            _FormatVenezuela = new CultureInfo("en-US", false).NumberFormat;
        }

        [HttpGet("listas/precio")]
        public IActionResult GetListasDePrecio([FromQuery] FiltrosListasDePrecio filtros)
        {
            try
            {
                var data = _comprasRepo.MostrarListasDePrecio(pTiendaId: filtros.tienda,
                pCodProducto: (filtros.codProducto == null) ? "" : filtros.codProducto,
                usuarioId: filtros.usuarioId, tipo: filtros.tipo).ToPagedList(filtros.Page, filtros.PerPage);


                if (data != null)
                    return Ok(new Response<DataPaginationDto<IEnumerable<MostrarListasDePrecio>>>(new DataPaginationDto<IEnumerable<MostrarListasDePrecio>>(data, data.PageNumber, data.TotalItemCount)));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("producto/oferta")]
        public IActionResult BuscarProductoOfertaDia([FromQuery] FiltrosBuscarProductoOferta filtros)
        {
            try
            {
                var data = _comprasRepo.BuscarProductoOfertaDia(filtros.Fecha,filtros.Tienda,filtros.CodProducto);


                if (data != null)
                    return Ok(new Response<BuscarProductoOfertaDia>(data));
                else
                    return BadRequest(new Response<string>("No se encontro producto con los parametros indicados"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        // GET api/Compras/lista/precios/reporte/5
        [HttpGet("lista/precio/{id}")]
        public IActionResult GetListaPrecioById(int id)
        {
            try
            {
                var data = _comprasRepo.MostrarListaDePrecio(pListaPrecioId: id);
                if (data == null || data.Count() == 0)
                    return BadRequest(new Response<string>("No existe la lista de precio"));
                else
                    return Ok(new Response<IEnumerable<MostrarListaDePrecio>>(data));
            }
            catch (Exception ex)
            {
                return BadRequest("Error interno en el servidor");
            }
        }

        [HttpGet("lista/costos")]
        public IActionResult GetListaDeCostos()
        {
            try
            {
                var data = _comprasRepo.GetListaDeCostos();
                if (data != null)
                    return Ok(new Response<IEnumerable<M66002>>(data));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
            
        }

        [HttpGet("productos/lista/costos")]
        public IActionResult GetProductListaDeCostos([FromQuery] FiltrosProductListaCostosDto filtros)
        {

            try
            {

                var data = _comprasRepo.GetProductosListaDePrecios(listaPreciosId: filtros.listaCost, codSap: (filtros.codSap == null) ? "0" : filtros.codSap,
                                                            codBarra: (filtros.codBarra == null) ? "0" : filtros.codBarra,
                                                            codDepartamento: (filtros.departamento == null) ? "0" : filtros.departamento,
                                                            descripcion: (filtros.descripcion == null) ? "0" : filtros.descripcion).ToPagedList(filtros.Page, filtros.PerPage);

                if (data != null)
                    return Ok(new Response<DataPaginationDto<IEnumerable<ProductoCosto>>>(new DataPaginationDto<IEnumerable<ProductoCosto>>(data, data.PageNumber, data.TotalItemCount)));
                else
                    return BadRequest(new Response<string>("No se encontro el producto"));

            }
            catch(Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }
        
        [HttpGet("productos/lista/precio")]
        public IActionResult GetProductListaDePrecio([FromQuery] FiltrosProductosListaPrecio filtros)
        {
            try
            {
                var data = _comprasRepo.GetProductosListaDePrecios(filtros.value,filtros.listaCost).ToPagedList(filtros.Page, filtros.PerPage);

                if (data != null)
                    return Ok(new Response<DataPaginationDto<IEnumerable<ProductoCosto>>>(new DataPaginationDto<IEnumerable<ProductoCosto>>(data, data.PageNumber, data.TotalItemCount)));
                else
                    return BadRequest(new Response<string>("No se encontraron productos"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }
        


        [HttpGet("productos")]
        public IActionResult GetProductListaDeCostosSinPaginar([FromQuery] FiltrosProductListaCostosDto filtros)
        {
            try
            {
                var data = _comprasRepo.GetProductosListaDePrecios(listaPreciosId: filtros.listaCost, codSap: (filtros.codSap == null) ? "0" : filtros.codSap,
                                                            codBarra: (filtros.codBarra == null) ? "0" : filtros.codBarra,
                                                            codDepartamento: (filtros.departamento == null) ? "0" : filtros.departamento,
                                                            descripcion: (filtros.descripcion == null) ? "0" : filtros.descripcion);

                if (data != null)
                    return Ok(new Response<IEnumerable<ProductoCosto>>(data));
                else
                    return BadRequest(new Response<string>("No hay data"));
            }
            catch(Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }

        [HttpGet("proveedor")]
        public IActionResult GetProveedores()
        {
            try
            {
                var data = _mapper.Map<IEnumerable<ProveedorDto>>(_comprasRepo.GetListaProveedores());
                if (data != null)
                    return Ok(new Response<IEnumerable<ProveedorDto>>(data));
                else
                    return BadRequest(new Response<string>("No hay data"));

            }catch(Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
        }
        
        [HttpGet("categoria/productos")]
        public IActionResult GetCategoriaProductos()
        {
            try
            {

                var data = _mapper.Map<IEnumerable<DepartamentoDto>>(_comprasRepo.GetCategoriasProductos());
                if (data != null)
                    return Ok(new Response<IEnumerable<DepartamentoDto>>(data));
                else
                    return BadRequest(new Response<string>("No hay data"));

            }
            catch(Exception ex)
            {
                return BadRequest(new Response<string>("Error interno en el servidor"));
            }
            
        }

        // POST api/<ComprasController>
        [HttpPost]
        public IActionResult Post([FromBody] ListaPrecioDto value)
        {
            var data = value;
            XmlDocument doc = new XmlDocument();

            try
            {
                XmlElement root = doc.CreateElement("Root");
                XmlElement product = doc.CreateElement("Productos");

                value.listaDePrecios.ForEach(p => {
                    XmlElement producto = doc.CreateElement("Producto");
                    producto.SetAttribute("CodArt", p.codArt.Trim());
                    producto.SetAttribute("CodAlt", (string.IsNullOrEmpty(p.CodigoProducto)) ? " " : p.CodigoProducto.Trim());
                    producto.SetAttribute("Descripcion", p.descripcion.Trim());
                    producto.SetAttribute("Departamento", p.departamento.Trim());
                    producto.SetAttribute("Moneda", p.moneda.Trim());
                    producto.SetAttribute("Costo", p.costo.ToString(_FormatVenezuela).Trim());
                    producto.SetAttribute("FV", p.fv.ToString(_FormatVenezuela).Trim());
                    producto.SetAttribute("PVP", p.pvp.ToString(_FormatVenezuela).Trim());
                    producto.SetAttribute("CodImpuesto", p.codImpuesto.Trim());
                    producto.SetAttribute("PorImpuesto", p.porImpuesto.ToString().Trim());

                    product.AppendChild(producto);
                });
                root.AppendChild(product);
                doc.AppendChild(root);

                int tiendaInsert = 0;
                 
                tiendaInsert = _comprasRepo.SaveListaPrecio(value.usuario, value.tiendas, value.descripcion, value.observacion, value.usuario, Convert.ToDouble(value.listaDePrecios.Count()), root.OuterXml);

                if (tiendaInsert != 0)
                    return Ok(new Response<int>(tiendaInsert));
                else
                    return BadRequest(new Response<string>("No se pudo procesar la lista de precio"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("No se pudo procesar la lista de precio"));
            }
        }
         // POST api/<ComprasController>
        [HttpPost("lista/oferta")]
        public IActionResult PostListaOfertas([FromBody] ListaDeOfertaDto value)
        {
            var data = value;
            XmlDocument doc = new XmlDocument();

            try
            {
                bool flag = false;
                value.listaDeOfertas.ForEach(p => {
                    if (p.precioOferta == 0)
                    {
                        flag = true;
                    }
                });

                if(flag)
                    return BadRequest(new Response<string>($"No puede crear ofertas con precio cero (0)."));

                XmlElement root = doc.CreateElement("Root");
                XmlElement product = doc.CreateElement("Productos");

                value.listaDeOfertas.ForEach(p => {
                    XmlElement producto = doc.CreateElement("Producto");
                    producto.SetAttribute("CodArt", p.CodArt.Trim());
                    producto.SetAttribute("Descripcion", string.IsNullOrEmpty(p.descripcion) ? "" : p.descripcion.Trim());
                    //producto.SetAttribute("Moneda", string.IsNullOrEmpty(p.codigoMoneda) ? "" : p.codigoMoneda.Trim());
                    //producto.SetAttribute("Costo", p.costo.ToString(_FormatVenezuela).Trim());
                    producto.SetAttribute("PVP", p.precioDetal.ToString(_FormatVenezuela).Trim());
                    producto.SetAttribute("Descuento", p.descuento.ToString(_FormatVenezuela).Trim());
                    producto.SetAttribute("PVPOferta", p.precioOferta.ToString(_FormatVenezuela).Trim());

                    product.AppendChild(producto);
                });
                root.AppendChild(product);
                doc.AppendChild(root);

                int tiendaInsert = 0;
                for (int i = 0; i < value.tiendas.Length; i++)
                    tiendaInsert = _comprasRepo.SaveListaOferta(value.usuario, value.tiendas[i], value.descripcion, (string.IsNullOrEmpty(value.observacion))? "" : value.observacion, value.usuario, Convert.ToDouble(value.listaDeOfertas.Count()), root.OuterXml,value.fechaI, value.fechaF);
                    

                if (tiendaInsert != -1)
                    return Ok(new Response<int>(tiendaInsert));
                else
                    return BadRequest(new Response<string>("No se pudo procesar la lista de precio"));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>("No se pudo procesar la lista de oferta"));
            }
        }




        // GET api/Compras/lista/precios/reporte/5
        [HttpGet("lista/precios/reporte/{id}")]
        public IActionResult ReporteListaPrecio(int id)
        {
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = $"ListaDePrecio({DateTime.Now}).xlsx";
            int index = 1;
            try
            {
                var data = _comprasRepo.MostrarListaDePrecio(pListaPrecioId: id);

                using (var workbook = new XLWorkbook())
                {
                    IXLWorksheet worksheet =
                    workbook.Worksheets.Add("ListaDePrecio");

                    //-----------Le damos el formato a la cabecera----------------
                    var rango = worksheet.Range("A1:I1"); //Seleccionamos un rango
                    rango.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thick); //Generamos las lineas exteriores
                    rango.Style.Border.SetInsideBorder(XLBorderStyleValues.Medium); //Generamos las lineas interiores
                    rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; //Alineamos horizontalmente
                    rango.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;  //Alineamos verticalmente
                    rango.Style.Font.FontSize = 14; //Indicamos el tamaño de la fuente
                    rango.Style.Fill.BackgroundColor = XLColor.AliceBlue; //Indicamos el color de background
                    //Ajustamos el ancho de las columnas para que se muestren todos los contenidos
                    worksheet.Column("A").Width = 50;
                    worksheet.Column("B").Width = 20;
                    worksheet.Column("C").Width = 45;
                    worksheet.Column("D").Width = 20;
                    worksheet.Column("E").Width = 20;
                    worksheet.Column("F").Width = 20;
                    worksheet.Column("G").Width = 20;
                    worksheet.Column("H").Width = 20;
                    worksheet.Column("I").Width = 20;


                    worksheet.Cell(1, 1).Value = "DETALLE";
                    worksheet.Cell(1, 2).Value = "CODART";
                    worksheet.Cell(1, 3).Value = "DESCRIPCION";
                    //worksheet.Cell(1, 4).Value = "COSTO";
                    //worksheet.Cell(1, 5).Value = "FV";
                    worksheet.Cell(1, 4).Value = "PVP";
                    //worksheet.Cell(1, 7).Value = "COSTO ANT";
                    //worksheet.Cell(1, 8).Value = "PVP ANT";
                    worksheet.Cell(1, 5).Value = "PVP OFERTA";

                    worksheet.RangeUsed().SetAutoFilter();

                    foreach (var item in data)
                    {
                        if (index == 1)
                        {
                            worksheet.Cell(index + 1, 1).Value = $"Lista De Precio";
                            var t = (item.TiendaId == 0) ? "Todas" : item.Tienda;
                            worksheet.Cell(index + 2, 1).Value = $"Tienda: {t}";
                            worksheet.Cell(index + 3, 1).Value = $"Comprador: {item.Usuario}";
                            worksheet.Cell(index + 4, 1).Value = $"Descripcion: {item.Descripcion}";
                            worksheet.Cell(index + 5, 1).Value = $"Cantidad De Articulos {item.CantidadArticulos}";
                            //worksheet.Cell(index + 6, 1).Value = $"Tasa: {item.Tasa}";
                            worksheet.Cell(index + 6, 1).Value = $"Realizado : {item.Create_at}";
                            if (item.Tipo == 2)
                            {
                                worksheet.Cell(index + 1, 1).Value = $"Lista De Oferta";
                                worksheet.Cell(index + 8, 1).Value = $"F.Inicio: {item.FechaInicioOferta}";
                                worksheet.Cell(index + 9, 1).Value = $"F.Fin: {item.FechaFinOferta}";
                            }
                           
                        }

                        worksheet.Cell(index + 1, 2).Style.NumberFormat.Format = "0000000";
                        worksheet.Cell(index + 1, 2).Value = item.CodigoArticulo;

                        worksheet.Cell(index + 1, 3).Value = item.ProductoDescripcion;
                        //worksheet.Cell(index + 1, 4).Value = item.Costo;
                        //worksheet.Cell(index + 1, 5).Value = item.FactorVenta;
                        worksheet.Cell(index + 1, 4).Value = item.PVP;
                        //worksheet.Cell(index + 1, 7).Value = item.CostoAnt;
                        //worksheet.Cell(index + 1, 8).Value = item.PVPAnt;
                        worksheet.Cell(index + 1, 5).Value = (item.PVPOferta == null) ? "--": item.PVPOferta;

                        index++;
                    }

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();
                        var file = File(content, contentType, fileName);
                        return file;
                    }
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("carga/masiva/productos")]
        public IActionResult GetProductCargaMasiva([FromBody] CargaMasivaProductosDto productos)
        {
            try
            {

                List<ProductosFvDto> listProduct = new List<ProductosFvDto>();


                var countFvError = productos.listaProductosFV.Where(p => p.fv < 1.3 || p.fv > 1.7).ToList();
                if (countFvError.Count > 0)
                    return BadRequest(new Response<List<ProductoPrecioDto>>(false, countFvError, "Estos productos no cumplen los valores minimos y maximos de factor de venta"));

                productos.listaProductosFV.ForEach(p =>
                {

                    var producto = _comprasRepo.GetProductosListaDePrecios(codSap: p.codArt , listaPreciosId: productos.listaCostoExcel).FirstOrDefault();
                    if (producto != null)
                    {
                        listProduct.Add(
                        new ProductosFvDto()
                        {
                            CodArt = producto.CodArt,
                            Descripcion = producto.Descripcion,
                            Costo = (double)producto.Costo,
                            FV = p.fv,
                            Moneda = producto.Moneda
                        });
                    }
                    else
                    {

                    }
                    producto = null;

                });

                if (listProduct.Count > 0)
                    return Ok(new Response<List<ProductosFvDto>>(listProduct));
                else
                    return BadRequest(new Response<string>("No hay data"));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[HttpPost("carga/masiva/oferta")]
        //public IActionResult GetProductCargaMasiva([FromBody] CargaMasivaOfertaDto productos)
        //{
        //    try
        //    {
        //        List<ProductoOfertaDto> listProduct = new List<ProductoOfertaDto>();
        //        productos.ofertas.ForEach(p =>
        //        {

        //            var producto = _comprasRepo.GetProductosListaDePrecios(codSap: p.CodigoProducto , listaPreciosId: productos.listaCosto).FirstOrDefault();
        //            if (producto != null)
        //            {
        //                listProduct.Add(
        //                new ProductoOfertaDto()
        //                {
        //                    CodArt = producto.CodArt,
        //                    Descripcion = producto.Descripcion,
        //                    Costo = (double)producto.Costo,
        //                    PVP = producto.PrecioDetal,
        //                    PrecioOferta = productos.ofertas.Where(p => p.CodigoProducto == producto.CodArt).FirstOrDefault().PrecioOferta,
        //                    Moneda = producto.Moneda
        //                });
        //            }
        //            producto = null;

        //        });

        //        if (listProduct.Count > 0)
        //            return Ok(new Response<List<ProductoOfertaDto>>(listProduct));
        //        else
        //            return BadRequest(new Response<string>("No hay data"));

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        [HttpPost("carga/masiva/oferta")]
        public IActionResult GetProductCargaMasiva()
        {
            try
            {
                var file = HttpContext.Request.Form.Count > 0 ? HttpContext.Request.Form : null;
                var listaCosto = HttpContext.Request.Form["listaCosto"].ToString();
                List<ProductoOfertaDto> listProduct = new List<ProductoOfertaDto>();
                if (file.Files.Count() == 0)
                    return BadRequest("fallo");

                var fileXlsx = HttpContext.Request.Form.Files[0];
                string text = string.Empty;
                
                using (var workbook = new XLWorkbook(fileXlsx.OpenReadStream()))
                {
                    var sheet = workbook.Worksheets.First();
                    foreach(var dataRow in sheet.RowsUsed())
                    {
                        //var colMax = sheet.ColumnsUsed().Count();
                        string cod = String.Format("{0:0000000}", dataRow.Cell(1).Value); //dataRow.Cell(1).Value.ToString("0000000");
                        var producto = _comprasRepo.GetProductosListaDePrecios(codSap: cod, listaPreciosId: listaCosto).FirstOrDefault();
                        if(producto != null)
                        {
                            listProduct.Add(new ProductoOfertaDto()
                            {
                                CodArt = producto.CodArt,
                                Costo = (double)producto.Costo,
                                Descripcion = producto.Descripcion,
                                Moneda = producto.Moneda,
                                PrecioOferta = Convert.ToDouble(dataRow.Cell(2).Value,_FormatVenezuela),
                                PrecioDetal = producto.PrecioDetal,
                                CodImpuesto = producto.CodImpuesto,
                                ValorImpuesto = producto.ValorImpuesto
                            });
                        }
                    }
                }

                if (listProduct.Count > 0)
                    return Ok(new Response<List<ProductoOfertaDto>>(listProduct));
                else
                    return BadRequest(new Response<string>("No existen los productos"));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
