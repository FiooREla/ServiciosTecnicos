using AutoMapper;
using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Aplication.Interface;
using ServiciosTecnicos.Domain.Entity;
using ServiciosTecnicos.Domain.Interface;
using ServiciosTecnicos.Tranverse.Common;

namespace ServiciosTecnicos.Aplication.Main
{
    public class CategoriaAplication:ICategoriaAplication
    {
        private readonly ICategoriaDomain _categoriaDomain;
        private readonly IMapper _mapper;

        public CategoriaAplication(ICategoriaDomain categoriaDomain, IMapper mapper)
        {
            _categoriaDomain = categoriaDomain;
            _mapper = mapper;
        }
        #region Síncrono
        public Response<bool> Insert(CategoriaDto categoriaDto)
        {
            var response = new Response<bool>();
            try
            {
                //se mapea categoria dto hacia categoria
                //map<destino>ORIGEN ASi trabsformas el dto en categoria
                var categoriaMapeada = _mapper.Map<Categoria>(categoriaDto);
                response.Data = _categoriaDomain.Insert(categoriaMapeada);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!";
                }
            }
            catch (Exception ex)
            {
                response.Message= ex.Message;
            }
            return response;
        }
        public Response<bool> Update(CategoriaDto categoriaDto)
        {
            var response = new Response<bool>();
            try
            {
                //se mapea categoria dto hacia categoria
                //map<destino>ORIGEN ASi trabsformas el dto en categoria
                var categoriaMapeada = _mapper.Map<Categoria>(categoriaDto);
                response.Data = _categoriaDomain.Update(categoriaMapeada);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public Response<bool> Delete(int IdCategoria)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _categoriaDomain.Delete(IdCategoria);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public Response<CategoriaDto> Get(int IdCategoria)
        {
            var response = new Response<CategoriaDto>();
            try
            {
                //los metodos del dominio devulven entidades de negocio y la capa de aplicacion devuelve dtos
                var obtenerCategoria = _categoriaDomain.Get(IdCategoria);
                response.Data = _mapper.Map<CategoriaDto>(obtenerCategoria);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public Response<IEnumerable<CategoriaDto>> GetAll()
        {
            var response = new Response<IEnumerable<CategoriaDto>>();
            try
            {
                var obtenerCategoria = _categoriaDomain.GetAll();
                response.Data = _mapper.Map< IEnumerable<CategoriaDto>>(obtenerCategoria);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        #endregion


        #region Asincronos
        public async Task<Response<bool>> InsertAsync(CategoriaDto categoriaDtos)
        {
            var response = new Response<bool>();
            try
            {
                //se mapea categoria dto hacia categoria
                //map<destino>ORIGEN ASi trabsformas el dto en categoria
                var categoriaMapeada = _mapper.Map<Categoria>(categoriaDtos);
                response.Data = await _categoriaDomain.InsertAsync(categoriaMapeada);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<bool>> UpdateAsync(CategoriaDto categoriaDtos)
        {
            var response = new Response<bool>();
            try
            {
                //se mapea categoria dto hacia categoria
                //map<destino>ORIGEN ASi trabsformas el dto en categoria
                var categoriaMapeada = _mapper.Map<Categoria>(categoriaDtos);
                response.Data = await _categoriaDomain.UpdateAsync(categoriaMapeada);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<bool>> DeleteAsync(int IdCategoria)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _categoriaDomain.DeleteAsync(IdCategoria);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<CategoriaDto>> GetAsync(int IdCategoria)
        {
            var response = new Response<CategoriaDto>();
            try
            {
                //los metodos del dominio devulven entidades de negocio y la capa de aplicacion devuelve dtos
                var obtenerCategoria = await _categoriaDomain.GetAsync(IdCategoria);
                response.Data =  _mapper.Map<CategoriaDto>(obtenerCategoria);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<IEnumerable<CategoriaDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CategoriaDto>>();
            try
            {
                var obtenerCategoria = await _categoriaDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CategoriaDto>>(obtenerCategoria);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        #endregion

    }
}