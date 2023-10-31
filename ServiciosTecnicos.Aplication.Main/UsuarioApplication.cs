using AutoMapper;
using Proyecto.Sistemas.Aplication.Validator;
using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Aplication.Interface;
using ServiciosTecnicos.Domain.Interface;
using ServiciosTecnicos.Tranverse.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Aplication.Main
{
    public class UsuarioApplication : IUsuarioAplication
    {
        private readonly IUsuarioDomain _usuarioDomain;
        private readonly IMapper _mapper;
        private readonly UsuarioDtoValidation _validationRules ;

        public UsuarioApplication(IUsuarioDomain usuarioDomain, IMapper mapper, UsuarioDtoValidation validationRules)
        {
            _usuarioDomain = usuarioDomain;
            _mapper = mapper;
            _validationRules = validationRules;
        }

        public Response<UsuarioDto> Authenticate(string usuario, string contrasena)
        {
            var response = new Response<UsuarioDto>();
            var validation = _validationRules.Validate(new UsuarioDto() { Usuario = usuario, Contrasena = contrasena });
            if (!validation.IsValid)
            {
                response.Message = "Errores de validación";
                response.Errors = validation.Errors;
                return response;
            }
            try
            {
                var user = _usuarioDomain.Authenticate(usuario, contrasena);
                response.Data = _mapper.Map<UsuarioDto>(user);
                response.IsSuccess = true;
                response.Message = "Autenticación Exitosa";
            }
            catch (InvalidOperationException)
            {
                response.IsSuccess=false;
                response.Message = "Uusario no existe";
            }
            catch(Exception ex)
            {
                response.Message=ex.Message;
            }
            return response;
        }
    }
}
