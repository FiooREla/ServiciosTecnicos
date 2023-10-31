using ServiciosTecnicos.Aplication.Dto;
using ServiciosTecnicos.Tranverse.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Aplication.Interface
{
    public interface ICategoriaAplication
    {
        //los metodos van a devolver entidad generica
        #region Métodos Síncronos
        Response<bool> Insert(CategoriaDto categoria);
        Response<bool> Update(CategoriaDto categoria);
        Response<bool> Delete(int IdCategoria);
        Response<CategoriaDto> Get(int IdCategoria);
        Response<IEnumerable<CategoriaDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<bool>> InsertAsync(CategoriaDto categoria);
        Task<Response<bool>> UpdateAsync(CategoriaDto categoria);
        Task<Response<bool>> DeleteAsync(int IdCategoria);
        Task<Response<CategoriaDto>> GetAsync(int IdCategoria);
        Task<Response<IEnumerable<CategoriaDto>>> GetAllAsync();
        #endregion
    }
}
