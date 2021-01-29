using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace api.DataBase
{
    // Interface de conexão
    public interface IConnection
    {
        // Conexão SQL
        SqlConnection sqlConnection();
    }
}
