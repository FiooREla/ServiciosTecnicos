using Microsoft.Extensions.Configuration;
using ServiciosTecnicos.Tranverse.Common;
using System.Data;
using System.Data.SqlClient;

namespace ServiciosTecnicos.Infrastructure.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;
        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection CreateConnection 
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null)
                {
                    return null;
                }
                sqlConnection.ConnectionString = _configuration.GetConnectionString("ServiciosTecnicos");
                sqlConnection.Open();
                return sqlConnection;
            }
        }
    }
}