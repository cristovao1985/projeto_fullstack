
using domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace domain.Repositories
{
    public interface IProductRepository
    {

        IEnumerable<Product> list();
        Result insert(Product product);
        Product get(int id);
        Result delete(int id);
        Result update(Product product);
        
    }
}
