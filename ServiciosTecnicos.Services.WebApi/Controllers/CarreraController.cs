using Microsoft.AspNetCore.Mvc;
using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Aplication.Interface;
using ServiciosTecnicos.Domain.Entity;

namespace ServiciosTecnicos.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : Controller
    {
        private readonly ICarreraAplication _carreraAplication;
        public CarreraController(ICarreraAplication carreraAplication)
        {
            _carreraAplication = carreraAplication;
        }
        #region Métodos Síncronos
        [HttpPost("Insert")]
        public IActionResult Insert([FromBody] CarreraDto carreraDto)
        {
            if (carreraDto == null)
            {
                return BadRequest();
            }
            var response = _carreraAplication.Insert(carreraDto);
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] CarreraDto carreraDto)
        {
            if (carreraDto == null)
            {
                return BadRequest();
            }
            var response = _carreraAplication.Update(carreraDto);
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        [HttpDelete("Delete/{IdCarrera}")]
        public IActionResult Delete(int IdCarrera)
        {
            var convertido = IdCarrera.ToString();
            if (string.IsNullOrEmpty(convertido))
            {
                return BadRequest();
            }
            var response = _carreraAplication.Delete(IdCarrera);
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        [HttpGet("Get/{IdCarrera}")]
        public IActionResult Get(int IdCarrera)
        {
            var convertido = IdCarrera.ToString();
            if (string.IsNullOrEmpty(convertido))
            {
                return BadRequest();
            }

            var response = _carreraAplication.Get(IdCarrera);
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var response = _carreraAplication.GetAll();
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos Asíncronos
        [HttpPost("InsertAsync")]
        public async Task<IActionResult> InsertAsync([FromBody] CarreraDto carreraDto)
        {
            if (carreraDto == null)
            {
                return BadRequest();
            }
            var response = await _carreraAplication.InsertAsync(carreraDto);
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] CarreraDto carreraDto)
        {
            if (carreraDto == null)
            {
                return BadRequest();
            }
            var response = await _carreraAplication.UpdateAsync(carreraDto);
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        [HttpDelete("DeleteAsync/{IdCarrera}")]
        public async Task<IActionResult> DeleteAsync(int IdCarrera)
        {
            var convertido = IdCarrera.ToString();
            if (string.IsNullOrEmpty(convertido))
            {
                return BadRequest();
            }
            var response = await _carreraAplication.DeleteAsync(IdCarrera);
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        [HttpGet("GetAsync/{IdCarrera}")]
        public async Task<IActionResult> GetAsync(int IdCarrera)
        {
            var convertido = IdCarrera.ToString();
            if (string.IsNullOrEmpty(convertido))
            {
                return BadRequest();
            }

            var response = await _carreraAplication.GetAsync(IdCarrera);
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        [HttpGet("GetAllAsync/{IdCarrera}")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _carreraAplication.GetAllAsync();
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }
        #endregion
    }
}
