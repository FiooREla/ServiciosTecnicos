using ServiciosTecnicos.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Domain.Interface
{
    public interface ICategoriaDomain
    {
        
        #region Métodos Síncronos
        bool Insert(Categoria categoria);
        bool Update(Categoria categoria);
        bool Delete(int IdCategoria);
        Categoria Get(int IdCategoria);
        IEnumerable<Categoria> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<bool> InsertAsync(Categoria categoria);
        Task<bool> UpdateAsync(Categoria categoria);
        Task<bool> DeleteAsync(int IdCategoria);
        Task<Categoria> GetAsync(int IdCategoria);
        Task<IEnumerable<Categoria>> GetAllAsync();
        #endregion
    }
}
