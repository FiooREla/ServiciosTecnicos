using AutoMapper;
using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Aplication.Interface;
using ServiciosTecnicos.Domain.Entity;
using ServiciosTecnicos.Domain.Interface;
using ServiciosTecnicos.Tranverse.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Aplication.Main
{
    public class CarreraAplication : ICarreraAplication
    {
        public readonly ICarreraDomain _CarreraDomain;
        public readonly IMapper _mapper;
        public CarreraAplication(ICarreraDomain carreraDomain, IMapper mapper)
        {
            _CarreraDomain = carreraDomain;
            this._mapper = mapper;
        }
        #region Sìncronos
        public Response<bool> Insert(CarreraDto carreraDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Carrera>(carreraDto);
                response.Data = _CarreraDomain.Insert(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message= ex.Message;
            }
            return response;
        }
        public Response<bool> Update(CarreraDto carreraDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Carrera>(carreraDto);
                response.Data = _CarreraDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public Response<bool> Delete(int IdCarrera)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _CarreraDomain.Delete(IdCarrera);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public Response<CarreraDto> Get(int IdCarrera)
        {
            var response = new Response<CarreraDto>();
            try
            {
                var carrera = _CarreraDomain.Get(IdCarrera);
                response.Data = _mapper.Map<CarreraDto>(carrera);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public Response<IEnumerable<CarreraDto>> GetAll()
        {
            var response = new Response<IEnumerable<CarreraDto>>();
            try
            {
                var carrera = _CarreraDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CarreraDto>>(carrera);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        #endregion
        #region Asìncronos
        public async Task<Response<bool>> InsertAsync(CarreraDto carreraDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Carrera>(carreraDto);
                response.Data = await _CarreraDomain.InsertAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<bool>> UpdateAsync(CarreraDto carreraDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Carrera>(carreraDto);
                response.Data = await _CarreraDomain.UpdateAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<bool>> DeleteAsync(int IdCarrera)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _CarreraDomain.DeleteAsync(IdCarrera);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<CarreraDto>> GetAsync(int IdCarrera)
        {
            var response = new Response<CarreraDto>();
            try
            {
                var carrera = await _CarreraDomain.GetAsync(IdCarrera);
                response.Data = _mapper.Map<CarreraDto>(carrera);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<IEnumerable<CarreraDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CarreraDto>>();
            try
            {
                var carrera = await _CarreraDomain.GetAllAsync();
                response.Data =  _mapper.Map<IEnumerable<CarreraDto>>(carrera);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
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
