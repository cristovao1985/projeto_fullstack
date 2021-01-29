using api.DataBase;
using Dapper;
using domain.Entities;
using helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace infraestructure.Repositories
{
    public class ProductRepository : IGenericInterface<Product>
    {
        private readonly IConnection _connection;
        

        public ProductRepository(IConnection connection)
        {
            this._connection = connection;
        }

        public Result delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> list()
        {
            try
            {
                using (var conn = this._connection.sqlConnection())
                {
                    IEnumerable<Product> produtos = conn.Query<Product>(@"SELECT * FROM [dbo].[products] ORDER BY name");
                    return produtos;
                };
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Result update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
