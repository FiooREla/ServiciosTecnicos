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
    public class UserRepository : IUserRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public UserRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public Users Authenticate(string Usuario, string Contrasena)
        {
            using (var connection = _connectionFactory.CreateConnection)
            {
                var query = "UsersGetByUserAndPassword";
                var parameters = new DynamicParameters();
                parameters.Add("Usuario", Usuario);
                parameters.Add("Contrasena", Contrasena);
                var user = connection.QuerySingle<Users>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return user;
            }
        }
    }
}
