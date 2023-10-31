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
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public CategoriaRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        #region Sincronos
        public bool Insert(Categoria categoria)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaInsert";
                var parameters = new DynamicParameters();
                parameters.Add("NombreCategoria", categoria.NombreCategoria);
                parameters.Add("Descripcion", categoria.Descripcion);
                var result= connection.Execute(query, param:parameters, commandType: CommandType.StoredProcedure);
                return result>0;
            }
        }
        public bool Update(Categoria categoria)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("IdCategoria", categoria.IdCategoria);
                parameters.Add("NombreCategoria", categoria.NombreCategoria);
                parameters.Add("Descripcion", categoria.Descripcion);
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public bool Delete(int IdCategoria)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaDelete";
                var parameters = new DynamicParameters();
                parameters.Add("IdCategoria", IdCategoria);
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public Categoria Get(int IdCategoria)
        {
            using(var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaGetById";
                var parameters = new DynamicParameters();
                parameters.Add("IdCategoria", IdCategoria);
                //metodos de consulta usa querysingle de dapper
                var result = connection.QuerySingle<Categoria>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public IEnumerable<Categoria> GetAll()
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaGetAll";

                var result = connection.Query<Categoria>(query, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        #endregion

        #region Asincronos
        public async Task<bool> InsertAsync(Categoria categoria)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaInsert";
                var parameters = new DynamicParameters();
                parameters.Add("NombreCategoria", categoria.NombreCategoria);
                parameters.Add("Descripcion", categoria.Descripcion);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public async Task<bool> UpdateAsync(Categoria categoria)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("IdCategoria", categoria.IdCategoria);
                parameters.Add("NombreCategoria", categoria.NombreCategoria);
                parameters.Add("Descripcion", categoria.Descripcion);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public async Task<bool> DeleteAsync(int IdCategoria)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaDelete";
                var parameters = new DynamicParameters();
                parameters.Add("IdCategoria", IdCategoria);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public async Task<Categoria> GetAsync(int IdCategoria)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaGetById";
                var parameters = new DynamicParameters();
                parameters.Add("IdCategoria", IdCategoria);
                //metodos de consulta usa querysingle de dapper
                var result = await connection.QuerySingleAsync<Categoria>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "CategoriaGetAll";

                var result = await connection.QueryAsync<Categoria>(query, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        #endregion

    }
}
