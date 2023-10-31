using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Tranverse.Common
{
    public class Response<T>
    {
        //response contiene todos los recursos de nuestra webapi
        public T Data { get; set; }
        //data almacena respuesta de metodos
        public bool IsSuccess { get; set; }
        //almacena estados de ejecucion, true o dfalse
        public string Message { get; set; }
        //true: satisfactorio, sino no
        //public IEnumerable<ValidationFailure> Errors { get; set; }
        public IEnumerable<ValidationFailure> Errors { get; set; }
    }
}
