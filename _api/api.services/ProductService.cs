using api.domain.Entities;
using api.domain.Repositories;
using api.domain.Services;
using api.Helper;
using api.repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace api.services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;
        public ProductService(ProductRepository productRepository) 
        {
            this._productRepository = productRepository;
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
            return _productRepository.list();
        }

        public Result update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
