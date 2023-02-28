using ApiHabladores.Dto;
using ApiHabladores.Models.Riopos;
using ApiHabladores.Models.StoreProcedure;
using AutoMapper;
namespace ApiHabladores.Profiles
{
    public class ApiProfiles : Profile
    {
        public ApiProfiles()
        {
            CreateMap<M64001, ProveedorDto>();
            CreateMap<M66001, DepartamentoDto>();
            CreateMap<SpListaProductosOferta, OfertasDto>();
        }
    }
}
