using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Tranverse.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Aplication.Interface
{
    public interface ICarreraAplication
    {
        #region Métodos Síncronos
        Response<bool> Insert(CarreraDto carrera);
        Response<bool> Update(CarreraDto carrera);
        Response<bool> Delete(int IdCarrera);
        Response<CarreraDto> Get(int IdCarrera);
        Response<IEnumerable<CarreraDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<bool>> InsertAsync(CarreraDto carrera);
        Task<Response<bool>> UpdateAsync(CarreraDto carrera);
        Task<Response<bool>> DeleteAsync(int IdCarrera);
        Task<Response<CarreraDto>> GetAsync(int IdCarrera);
        Task<Response<IEnumerable<CarreraDto>>> GetAllAsync();
        #endregion
    }
}
