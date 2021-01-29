using api.DataBase;
using api.domain.Entities;
using api.domain.Repositories;
using api.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace api.repositories
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

                throw new Exception();
            }
        }

        public Result update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
