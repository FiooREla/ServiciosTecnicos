using ServiciosTecnicos.Domain.Entity;
using ServiciosTecnicos.Domain.Interface;
using ServiciosTecnicos.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Domain.Core
{
    public class CarreraDomain : ICarreraDomain
    {
        public readonly ICarreraRepository _carreraDomain;
        public CarreraDomain(ICarreraRepository carreraDomain)
        {
            _carreraDomain = carreraDomain;
        }
        #region Síncronos
        public bool Insert(Carrera carrera)
        {
            return _carreraDomain.Insert(carrera);
        }
        public bool Update(Carrera carrera)
        {
            return _carreraDomain.Update(carrera);
        }
        public bool Delete(int IdCarrera)
        {
            return _carreraDomain.Delete(IdCarrera);
        }
        public Carrera Get(int IdCarrera)
        {
            return _carreraDomain.Get(IdCarrera);
        }
        public IEnumerable<Carrera> GetAll()
        {
            return _carreraDomain.GetAll();
        }
        #endregion
        #region Asíncronos
        public async Task<bool> InsertAsync(Carrera carrera)
        {
            return await _carreraDomain.InsertAsync(carrera);
        }
        public async Task<bool> UpdateAsync(Carrera carrera)
        {
            return await _carreraDomain.UpdateAsync(carrera);
        }
        public async Task<bool> DeleteAsync(int IdCarrera)
        {
            return await _carreraDomain.DeleteAsync(IdCarrera);
        }
        public async Task<Carrera> GetAsync(int IdCarrera)
        {
            return await _carreraDomain.GetAsync(IdCarrera);
        }
        public async Task<IEnumerable<Carrera>> GetAllAsync()
        {
            return await _carreraDomain.GetAllAsync();
            
        }
        #endregion
    }
}
