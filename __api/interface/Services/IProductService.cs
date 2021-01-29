using domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces.Services
{
    // Interface para chamada dos serviços de product
    // Obs: Pderia ser usado uma classe base para abstração
    public interface IProductService
    {
        IEnumerable<Product> list();
        Product get(int id);
        Result delete(int id);
        Result update(int id);
    }
}
