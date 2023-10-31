using Dapper;
using ServiciosTecnicos.Domain.Entity;
using ServiciosTecnicos.Infrastructure.Interface;
using ServiciosTecnicos.Tranverse.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Infrastructure.Repository
{
    public class CarreraRepository : ICarreraRepository
    {
        public readonly IConnectionFactory _connectionFactory;
        public CarreraRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        #region Síncrono
        public bool Insert(Carrera carrera)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraInsert";
                var parameters = new DynamicParameters();
                parameters.Add("IdCategoia", carrera.IdCategoia);
                parameters.Add("NombreCarrera", carrera.NombreCarrera);
                parameters.Add("Activo", carrera.Activo);
                parameters.Add("DescripcionCarr", carrera.DescripcionCarr);
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public bool Update(Carrera carrera)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("IdCarrera", carrera.IdCarrera);
                parameters.Add("IdCategoia", carrera.IdCategoia);
                parameters.Add("NombreCarrera", carrera.NombreCarrera);
                parameters.Add("Activo", carrera.Activo);
                parameters.Add("DescripcionCarr", carrera.DescripcionCarr);
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public bool Delete(int IdCarrera)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraDelete";
                var parameters = new DynamicParameters();
                parameters.Add("IdCarrera", IdCarrera);
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public Carrera Get(int IdCarrera)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraGetById";
                var parameters = new DynamicParameters();
                parameters.Add("IdCarrera", IdCarrera);
                //metodos de consulta usa querysingle de dapper
                var result = connection.QuerySingle<Carrera>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public IEnumerable<Carrera> GetAll()
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraGetAll";

                var result = connection.Query<Carrera>(query, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        #endregion
        #region Asíncrono
        public async Task<bool> InsertAsync(Carrera carrera)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraInsert";
                var parameters = new DynamicParameters();
                parameters.Add("IdCategoia", carrera.IdCategoia);
                parameters.Add("NombreCarrera", carrera.NombreCarrera);
                parameters.Add("Activo", carrera.Activo);
                parameters.Add("DescripcionCarr", carrera.DescripcionCarr);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public async Task<bool> UpdateAsync(Carrera carrera)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("IdCarrera", carrera.IdCarrera);
                parameters.Add("IdCategoia", carrera.IdCategoia);
                parameters.Add("NombreCarrera", carrera.NombreCarrera);
                parameters.Add("Activo", carrera.Activo);
                parameters.Add("DescripcionCarr", carrera.DescripcionCarr);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public async Task<bool> DeleteAsync(int IdCarrera)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraDelete";
                var parameters = new DynamicParameters();
                parameters.Add("IdCarrera", IdCarrera);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public async Task<Carrera> GetAsync(int IdCarrera)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraGetById";
                var parameters = new DynamicParameters();
                parameters.Add("IdCarrera", IdCarrera);
                //metodos de consulta usa querysingle de dapper
                var result = await connection.QuerySingleAsync<Carrera>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public async Task<IEnumerable<Carrera>> GetAllAsync()
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CarreraGetAll";

                var result = await connection.QueryAsync<Carrera>(query, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        #endregion

    }
}
