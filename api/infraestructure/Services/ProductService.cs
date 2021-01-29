using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using domain.Entities;
using domain.Repositories;
using domain.Services;
using infraestructure.Repositories;

namespace infraestructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) 
        {
            this._productRepository = productRepository;
        }
        public Result delete(int id)
        {
            return _productRepository.delete(id);
        }

        public Product get(int id)
        {
            var result = _productRepository.get(id);          
            return result;       
            
        }

        public IEnumerable<Product> list()
        {
            return _productRepository.list();
        }

        public Result update(Product product)
        {
            return _productRepository.update(product);
        }

        public Result validateProductID(int id)
        {
            var result = _productRepository.get(id);
            if (result != null)
            {
                return new Result { message = $"Produto com ID {id} foi encontrado", success = true };
            }
            else
            {
                return new Result { message = $"Produto com ID {id} não foi encontrado", success = false };
                
            }
        }
    }
}
