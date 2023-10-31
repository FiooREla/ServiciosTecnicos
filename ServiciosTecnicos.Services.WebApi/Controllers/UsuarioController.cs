using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Aplication.Interface;
using ServiciosTecnicos.Services.WebApi.Helpers;
using ServiciosTecnicos.Tranverse.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ServiciosTecnicos.Services.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioAplication _usuarioAplication;
        private readonly AppSettings _appSettings;

        public UsuarioController(IUsuarioAplication usuarioAplication, IOptions<AppSettings> appSettings )
        {
            _usuarioAplication = usuarioAplication;
            _appSettings = appSettings.Value;
        }

      
    }
}
