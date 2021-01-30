using api.DataBase;
using Dapper;
using domain.Entities;
using domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace infraestructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConnection _connection;


        public ProductRepository(IConnection connection)
        {
            this._connection = connection;
        }

        public Result delete(int id)
        {
            try
            {
                using (var conn = this._connection.sqlConnection())
                {
                    
                    conn.Execute(@"DELETE FROM [dbo].[products]                    
                    WHERE [id]=@id",
                    new
                    {
                        @id = id,
                    
                    });
                    return new Result { message = "Produto deletado com sucesso!", success = true };
                };
            }
            catch (Exception ex)
            {

                return new Result { message = $"Não foi possível deletar o produto ID{id}", success = false };
            }
        }

        public Product get(int id)
        {
            try
            {
                using (var conn = this._connection.sqlConnection())
                {

                    Product product = conn.QuerySingle<Product>(@"SELECT * FROM [dbo].[products] WHERE [id]=@id", new { id = id });
                    return product;
                };
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public Result insert(Product product)
        {
            try
            {
                using (var conn = this._connection.sqlConnection())
                {

                    conn.Execute(@"INSERT INTO [dbo].[products]
                   ([name]
                   ,[description]
                   ,[bar_code]
                   ,[value]
                   ,[active])
                    VALUES(
                    @name,
                    @description, 
                    @bar_code,
                    @value, 
                    @active)",
                    new
                    {
                        @id = product.id,
                        @name = product.name,
                        @description = product.description,
                        @bar_code = product.bar_code,
                        @value = product.value,
                        @active = product.active
                    });
                    return new Result { message = "Produto inserido com sucesso!", success = true };
                };
            }
            catch (Exception ex)
            {

                return new Result { message = $"Não foi possível inserir o produto", success = false };
            }
        }

        public IEnumerable<Product> list()
        {
            try
            {
                using (var conn = this._connection.sqlConnection())
                {
                    IEnumerable<Product> products = conn.Query<Product>(@"SELECT * FROM [dbo].[products] ORDER BY name");
                    return products;
                };
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public Result update(Product product)
        {
            try
            {
                using (var conn = this._connection.sqlConnection())
                {

                    conn.Execute(@"UPDATE [dbo].[products]
                    SET [name] = @name
                    ,[description] = @description
                    ,[bar_code] = @bar_code
                    ,[value] = @value
                    ,[active] = @active
                    WHERE [id]=@id",
                    new
                    {
                        @id = product.id,
                        @name = product.name,
                        @description = product.description,
                        @bar_code = product.bar_code,
                        @value = product.value,
                        @active = product.active
                    });
                    return new Result { message = "Produto alterado com sucesso!", success = true };
                };
            }
            catch (Exception ex)
            {

                return new Result { message = $"Não foi possível alterar o produto ID {product.id}", success = false };
            }
        }
    }
}
