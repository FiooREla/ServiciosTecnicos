using AutoMapper;
using ServiciosTecnicos.Tranverse.Mapper;

namespace ServiciosTecnicos.Services.WebApi.Extensions.Mapper
{
    public static class MapperExtensions
    {
        public static IServiceCollection AddMapper(this IServiceCollection services) 
        { 
            //Mapeo entre entiedades de nagocio y dto
            var mappingConfig = new MapperConfiguration(mc=>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
