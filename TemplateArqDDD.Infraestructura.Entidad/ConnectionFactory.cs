using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using TemplateArqDDD.Transversal.Common;

namespace TemplateArqDDD.Infrastructure.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection? GetConnection
        {
            get
            {
                var sqlConnection = new MySqlConnection();
                if (sqlConnection == null) return null;
                sqlConnection.ConnectionString = _configuration.GetConnectionString("ConnectionTesting"); //ConnectionBdProd ConnectionBdNBViejo ConnectionBdNB ConnectionBdCasa ConnectionBdProd
                sqlConnection.Open();
                return sqlConnection;
            }
        }
    }


}