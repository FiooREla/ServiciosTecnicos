using ServiciosTecnicos.Aplication.Interface;
using ServiciosTecnicos.Aplication.Main;
using ServiciosTecnicos.Domain.Core;
using ServiciosTecnicos.Domain.Interface;
using ServiciosTecnicos.Infrastructure.Data;
using ServiciosTecnicos.Infrastructure.Interface;
using ServiciosTecnicos.Infrastructure.Repository;
using ServiciosTecnicos.Tranverse.Common;

namespace ServiciosTecnicos.Services.WebApi.Extensions.Inyection
{
    public static class InyectionExtensions
    {
        public static IServiceCollection AddInyection(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddSingleton< IConnectionFactory, ConnectionFactory> ();
            services.AddScoped<ICategoriaAplication, CategoriaAplication>();
            services.AddScoped<ICategoriaDomain, CategoriaDomain>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ICarreraAplication, CarreraAplication>();
            services.AddScoped<ICarreraDomain, CarreraDomain>();
            services.AddScoped<ICarreraRepository, CarreraRepository>();
            services.AddScoped<IUsuarioAplication, UsuarioApplication>();
            services.AddScoped<IUsuarioDomain, UsuarioDomain>();
            services.AddScoped<IUserRepository, UserRepository>();


            return services;
        }
    }
}
