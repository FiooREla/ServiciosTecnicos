using ServiciosTecnicos.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Infrastructure.Interface
{
    public interface ICarreraRepository
    {
        #region Sincronos
        bool Insert(Carrera carrera);
        bool Update(Carrera carrera);
        bool Delete(int IdCarrera);
        Carrera Get(int IdCarrera);
        IEnumerable<Carrera> GetAll();
        #endregion

        #region Asincrono
        Task<bool> InsertAsync(Carrera carrera);
        Task<bool> UpdateAsync(Carrera carrera);
        Task<bool> DeleteAsync(int IdCarrera);
        Task<Carrera> GetAsync(int IdCarrera);
        Task<IEnumerable<Carrera>> GetAllAsync();
        #endregion
    }
}
