using ServiciosTecnicos.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Domain.Interface
{
    public interface ICarreraDomain
    {
        #region Métodos Síncronos
        bool Insert(Carrera categoria);
        bool Update(Carrera categoria);
        bool Delete(int IdCategoria);
        Carrera Get(int IdCategoria);
        IEnumerable<Carrera> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<bool> InsertAsync(Carrera categoria);
        Task<bool> UpdateAsync(Carrera categoria);
        Task<bool> DeleteAsync(int IdCategoria);
        Task<Carrera> GetAsync(int IdCategoria);
        Task<IEnumerable<Carrera>> GetAllAsync();
        #endregion
    }
}
