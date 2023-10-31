using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Aplication.Interface;

namespace ServiciosTecnicos.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaAplication _categoriaAplication;
        public CategoriaController(ICategoriaAplication categoriaAplication)
        {
            _categoriaAplication = categoriaAplication;
        }

        #region Síncronos
        [HttpPost("Insert")]
        public IActionResult Insert([FromBody] CategoriaDto categoriaDto)
        {
            if (categoriaDto == null) return BadRequest();
            var respuestaMetodo = _categoriaAplication.Insert(categoriaDto);
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        [HttpPut("Update")]
        public IActionResult Update([FromBody] CategoriaDto categoriaDto)
        {
            if (categoriaDto == null) return BadRequest();
            var respuestaMetodo = _categoriaAplication.Update(categoriaDto);
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        [HttpDelete("Delete/{IdCategoria}")]
        public IActionResult Delete(int IdCategoria)
        {
            var convertido = IdCategoria.ToString();
            if (string.IsNullOrEmpty(convertido)) return BadRequest();
            var respuestaMetodo = _categoriaAplication.Delete(IdCategoria);
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        [HttpGet("Get/{IdCategoria}")]
        public IActionResult Get(int IdCategoria)
        {
            var convertido = IdCategoria.ToString();
            if (string.IsNullOrEmpty(convertido)) return BadRequest();
            var respuestaMetodo = _categoriaAplication.Get(IdCategoria);
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var respuestaMetodo = _categoriaAplication.GetAll();
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        #endregion

        #region Asíncronos
        [HttpPost("InsertAsync")]
        public async Task<IActionResult> InsertAsync([FromBody] CategoriaDto categoriaDto)
        {
            if (categoriaDto == null) return BadRequest();
            var respuestaMetodo =await _categoriaAplication.InsertAsync(categoriaDto);
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] CategoriaDto categoriaDto)
        {
            if (categoriaDto == null) return BadRequest();
            var respuestaMetodo = await _categoriaAplication.UpdateAsync(categoriaDto);
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        [HttpDelete("DeleteAsync/{IdCategoria}")]
        public async Task<IActionResult> DeleteAsync(int IdCategoria)
        {
            var convertido = IdCategoria.ToString();
            if (string.IsNullOrEmpty(convertido)) return BadRequest();
            var respuestaMetodo = await _categoriaAplication.DeleteAsync(IdCategoria);
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        [HttpGet("GetAsync/{IdCategoria}")]
        public async Task<IActionResult> GetAsync(int IdCategoria)
        {
            var convertido = IdCategoria.ToString();
            if (string.IsNullOrEmpty(convertido)) return BadRequest();
            var respuestaMetodo = await _categoriaAplication.GetAsync(IdCategoria);
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var respuestaMetodo = await _categoriaAplication.GetAllAsync();
            if (respuestaMetodo.IsSuccess)
            {
                return Ok(respuestaMetodo);
            }
            return BadRequest(respuestaMetodo.Message);
        }
        #endregion

    }
}
