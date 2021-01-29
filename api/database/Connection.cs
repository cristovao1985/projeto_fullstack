using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace api.DataBase
{
    public class Connection : IConnection
    {
        // Declaração da classe de conexão
        private readonly IConfiguration _configuration;

        public Connection(IConfiguration configuration)
        {
            //Construtor da classe de conexão
            this._configuration = configuration;
        }


        public SqlConnection sqlConnection()
        {
           // Definindo qual a conexão que será usada como base
            string connectionString = this._configuration.GetConnectionString("SQLSERVER");

           // Retornando a conexão com a string definida
            return new SqlConnection(connectionString);

        }
    }
}
