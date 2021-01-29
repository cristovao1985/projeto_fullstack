using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace api.DataBase
{
    public class Connection : IConnection
    {
        private readonly IConfiguration _configuration;

        public Connection(IConfiguration configuration)
        {
            // Construtor da classe de conexão
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
