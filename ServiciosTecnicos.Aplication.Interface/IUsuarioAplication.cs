using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Tranverse.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Aplication.Interface
{
    public interface IUsuarioAplication
    {
        Response<UsuarioDto> Authenticate(string usuario, string contrasena);
    }
}
