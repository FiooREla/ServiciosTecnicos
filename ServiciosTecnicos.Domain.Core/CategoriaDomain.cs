using ServiciosTecnicos.Domain.Entity;
using ServiciosTecnicos.Domain.Interface;
using ServiciosTecnicos.Infrastructure.Interface;

namespace ServiciosTecnicos.Domain.Core
{
    public class CategoriaDomain : ICategoriaDomain
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaDomain(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        #region Síncronos
        public bool Insert(Categoria categoria)
        {
            return _categoriaRepository.Insert(categoria);
        }
        public bool Update(Categoria categoria)
        {
            return _categoriaRepository.Update(categoria);
        }
        public bool Delete(int IdCategoria)
        {
            return _categoriaRepository.Delete(IdCategoria);
        }
        public Categoria Get(int IdCategoria)
        {
            return _categoriaRepository.Get(IdCategoria);
        }
        public IEnumerable<Categoria> GetAll()
        {
            return _categoriaRepository.GetAll();

        }
        #endregion
        #region Asíncronos
        public async Task<bool> InsertAsync(Categoria categoria)
        {
            return await _categoriaRepository.InsertAsync(categoria);
        }
        public async Task<bool> UpdateAsync(Categoria categoria)
        {
            return await _categoriaRepository.UpdateAsync(categoria);
        }
        public async Task<bool> DeleteAsync(int IdCategoria)
        {
            return await _categoriaRepository.DeleteAsync(IdCategoria);
        }
        public async Task<Categoria> GetAsync(int IdCategoria)
        {
            return await _categoriaRepository.GetAsync(IdCategoria);
        }
        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _categoriaRepository.GetAllAsync();
        }
        #endregion
    }
}