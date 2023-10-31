using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Aplication.Interface;
using ServiciosTecnicos.Services.WebApi.Helpers;
using ServiciosTecnicos.Services.WebApi.Modelos;
using ServiciosTecnicos.Tranverse.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ServiciosTecnicos.Services.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class SessionController : Controller
    {
        private readonly IUsuarioAplication _usuarioAplication;
        private readonly AppSettings _appSettings;

        public SessionController(IUsuarioAplication usuarioAplication, IOptions<AppSettings> appSettings )
        {
            _usuarioAplication = usuarioAplication;
            _appSettings = appSettings.Value;
        }

      
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] LoginModel login) 
        {
            var response = _usuarioAplication.Authenticate(login.Usuario, login.Contrasena);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                {
                    response.Data.Token = BuildToken(response);
                    return Ok(response);
                }
                else
                {
                    return NotFound(response);
                }
            }
            return BadRequest(response);
        }

        private string BuildToken(Response<UsuarioDto> userDto)
        {
            //jwtsecurity valida los tokens
            var tokenHandler = new JwtSecurityTokenHandler();
            //_appSettings.Secret se hace por rendimiento, como se tiene en memoria se accede
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            //SecurityTokenDescriptor especifica atributos para la emisión del token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                //subject especifica la informacion que contiene el token
                Subject = new ClaimsIdentity(new Claim[]
                {
                    //Calims son los atributos
                    //el claim que se va almacenar en el token va ser el id del usuario
                    new Claim(ClaimTypes.Name, userDto.Data.IdUsuario.ToString())
                    //va almacenar el id del cliente userDto.Data.UserId.ToString()
                }),
                Expires = DateTime.UtcNow.AddMinutes(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                //signals es la clave con la que se encripta
                Issuer = _appSettings.Issuer,
                Audience = _appSettings.Audience
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
    }
}
