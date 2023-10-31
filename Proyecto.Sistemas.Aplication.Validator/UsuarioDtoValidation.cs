using FluentValidation;
using ServiciosTecnicos.Aplication.Dto;

namespace Proyecto.Sistemas.Aplication.Validator
{
    public class UsuarioDtoValidation: AbstractValidator<UsuarioDto>
    {
        public UsuarioDtoValidation()
        {
            RuleFor(u => u.Usuario).NotNull().NotEmpty();
            RuleFor(u => u.Contrasena).NotNull().NotEmpty();
        }
    }
}