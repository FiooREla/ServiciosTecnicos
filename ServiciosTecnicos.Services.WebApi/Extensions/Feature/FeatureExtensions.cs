using Microsoft.AspNetCore.Mvc;

namespace ServiciosTecnicos.Services.WebApi.Extensions.Feature
{
    public static class FeatureExtensions
    {
        public static IServiceCollection AddFeature(this IServiceCollection services, IConfiguration configuration) 
        {
            
            services.AddCors(options => options.AddPolicy("policityApiServicios", builder => builder.AllowAnyOrigin()
                                                                                        .AllowAnyHeader()
                                                                                        .AllowAnyMethod()));
       
            return services;
        }
    }
}
