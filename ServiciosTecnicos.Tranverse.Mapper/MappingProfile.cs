using AutoMapper;
using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Domain.Entity;

namespace ServiciosTecnicos.Tranverse.Mapper
{
    public class MappingProfile :Profile
    {
        //mapeo en tre dto y unidades de negocio
        public MappingProfile()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Carrera, CarreraDto>().ReverseMap();
            CreateMap<Users, UsuarioDto>().ReverseMap();

        }
    }
}