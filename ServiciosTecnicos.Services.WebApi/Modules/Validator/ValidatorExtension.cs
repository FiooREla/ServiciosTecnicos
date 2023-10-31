using Proyecto.Sistemas.Aplication.Validator;
using System.Runtime.CompilerServices;

namespace ServiciosTecnicos.Services.WebApi.Modules.Validator
{
    public static class ValidatorExtension
    {
        public static IServiceCollection AddValidator(this IServiceCollection services)
        {
            services.AddTransient<UsuarioDtoValidation>();
            return services;
        }
    }
}
