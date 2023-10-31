using ServiciosTecnicos.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Infrastructure.Interface
{
    public interface ICategoriaRepository
    {
        #region Sincronos

        bool Insert(Categoria categoria);
        bool Update(Categoria categoria);
        bool Delete(int categoria);
        Categoria Get(int id);
        IEnumerable<Categoria> GetAll();
        #endregion

        #region Asincrono
        Task<bool> InsertAsync(Categoria categoria);
        Task<bool> UpdateAsync(Categoria categoria);
        Task<bool> DeleteAsync(int id);
        Task<Categoria> GetAsync(int id);
        Task<IEnumerable<Categoria>> GetAllAsync();
        #endregion
    }
}
